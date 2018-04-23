Imports DevExpress.Diagram.Core
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraDiagram
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace XtraDiagram.CustomShapeProperties
    Public Class DiagramShapeEx
        Inherits DiagramShape

        <XtraSerializableProperty> _
        Public Property DatabaseObjectID() As Integer
        Shared Sub New()
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
        End Sub
    End Class
End Namespace
