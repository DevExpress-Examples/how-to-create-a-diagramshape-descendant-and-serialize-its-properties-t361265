Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraDiagram
Imports System.IO
Imports DevExpress.Diagram.Core

Namespace XtraDiagram.CustomShapeProperties
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private Const diagramName As String = "diagram.xml"
        Private DataObjects As New List(Of DataObject)()
        Public Sub New()
            InitializeComponent()
            RegisterStencil()
            DataObjects.Add(New DataObject With {.ID = 0, .Content = "Start"})
            DataObjects.Add(New DataObject With {.ID = 1, .ParentID = 0, .Content = "Node 1"})
            DataObjects.Add(New DataObject With {.ID = 2, .ParentID = 1, .Content = "Node 1_1"})
            DataObjects.Add(New DataObject With {.ID = 3, .ParentID = 0, .Content = "Node 2"})
            DataObjects.Add(New DataObject With {.ID = 4, .ParentID = 3, .Content = "Node 2_1"})
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not File.Exists(diagramName) Then
                CreateDiagram()
            Else
                LoadDiagram()
            End If
        End Sub
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            diagramControl1.SaveDocument(diagramName)
        End Sub
        Private Sub RegisterStencil()
            Dim stencil = New DevExpress.Diagram.Core.DiagramStencil("CustomStencil", "Custom Shapes")
            stencil.RegisterTool(New FactoryItemTool("CustomShape", Function() "Custom Shape", Function(diagram) New DiagramShapeEx(), New System.Windows.Size(230, 110), False))
            DevExpress.Diagram.Core.DiagramToolboxRegistrator.RegisterStencil(stencil)
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
        End Sub
        Private Sub LoadDiagram()
            Try
                diagramControl1.LoadDocument(diagramName)
                For Each item In diagramControl1.Items
                    Dim shape = TryCast(item, DiagramShapeEx)
                    Dim dataObject As DataObject
                    If shape IsNot Nothing Then
                        dataObject = DataObjects.FirstOrDefault(Function(x) x.ID = shape.DatabaseObjectID)
                        shape.Content = If(dataObject Is Nothing, Nothing, dataObject.Content)
                    End If
                Next item
            Catch e As Exception
                CreateDiagram()
            End Try
        End Sub
        Private Sub CreateDiagram()
            For Each dataObject In DataObjects
                Dim shape = New DiagramShapeEx With {.Shape = BasicShapes.Rectangle, .Size = New Size(150, 100), .DatabaseObjectID = dataObject.ID, .Content = dataObject.Content}
                diagramControl1.Items.Add(shape)
                If dataObject.ParentID <> dataObject.ID Then
                    diagramControl1.Items.Add(New DiagramConnector With {.BeginItem = diagramControl1.Items.First(Function(x) TypeOf x Is DiagramShapeEx AndAlso CType(x, DiagramShapeEx).DatabaseObjectID = dataObject.ParentID), .EndItem = shape})
                End If
            Next dataObject
            diagramControl1.ApplyTreeLayout(Direction.Right)
        End Sub
        Private Sub OnShowingEditor(ByVal sender As Object, ByVal e As DiagramShowingEditorEventArgs) Handles diagramControl1.ShowingEditor
            e.Cancel = True
        End Sub

        Private Sub diagramControl1_CustomGetEditableItemProperties(sender As Object, e As DiagramCustomGetEditableItemPropertiesEventArgs) Handles diagramControl1.CustomGetEditableItemProperties
            If TypeOf e.Item Is DiagramShapeEx Then
                e.Properties.Add(TypeDescriptor.GetProperties(GetType(DiagramShapeEx))("DatabaseObjectID"))
            End If
        End Sub
    End Class
    Public Class DataObject
        Public Property ID() As Integer
        Public Property ParentID() As Integer
        Public Property Content() As String
    End Class
End Namespace