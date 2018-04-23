Namespace XtraDiagram.CustomShapeProperties
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        Private Sub InitializeComponent()
            Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
            DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' diagramControl1
            ' 
            Me.diagramControl1.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.AutoSize
            Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl1.DocumentSource = Nothing
            Me.diagramControl1.FileDialogFilter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*"
            Me.diagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.diagramControl1.Name = "diagramControl1"
            Me.diagramControl1.OptionsBehavior.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Collapsed
            Me.diagramControl1.OptionsView.FitToDrawingMargin = New System.Windows.Forms.Padding(10)
            Me.diagramControl1.OptionsView.PageSize = New System.Drawing.SizeF(800F, 600F)
            Me.diagramControl1.OptionsView.ShowGrid = True
            Me.diagramControl1.OptionsView.ShowRulers = True
            Me.diagramControl1.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl1.Size = New System.Drawing.Size(1321, 806)
            Me.diagramControl1.TabIndex = 0
            Me.diagramControl1.Text = "diagramControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1321, 806)
            Me.Controls.Add(Me.diagramControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents diagramControl1 As DevExpress.XtraDiagram.DiagramControl
    End Class
End Namespace

