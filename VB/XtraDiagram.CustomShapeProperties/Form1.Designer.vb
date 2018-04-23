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
            Dim DockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
            Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
            Me.DiagramPropertyGridDockPanel1 = New DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel()
            Me.DiagramToolboxDockPanel1 = New DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel()
            Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager()
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DiagramControlDockPanel1 = New DevExpress.XtraDiagram.Docking.DiagramControlDockPanel()
            Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.diagramControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DiagramPropertyGridDockPanel1.PropertyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerRight.SuspendLayout()
            Me.DiagramControlDockPanel1.SuspendLayout()
            Me.ControlContainer1.SuspendLayout()
            CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DocumentGroup1
            '
            Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1})
            '
            'Document1
            '
            Me.Document1.Caption = ""
            Me.Document1.ControlName = "DiagramControlDockPanel1"
            Me.Document1.FloatLocation = New System.Drawing.Point(0, 0)
            Me.Document1.FloatSize = New System.Drawing.Size(300, 200)
            Me.Document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.Document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.Document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
            '
            'diagramControl1
            '
            Me.diagramControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.diagramControl1.Name = "diagramControl1"
            Me.diagramControl1.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl1.OptionsView.PageSize = New System.Drawing.SizeF(800.0!, 600.0!)
            Me.diagramControl1.PropertyGrid = Me.DiagramPropertyGridDockPanel1
            Me.diagramControl1.Size = New System.Drawing.Size(996, 800)
            Me.diagramControl1.TabIndex = 0
            Me.diagramControl1.Text = "diagramControl1"
            Me.diagramControl1.Toolbox = Me.DiagramToolboxDockPanel1
            '
            'DiagramPropertyGridDockPanel1
            '
            Me.DiagramPropertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DiagramPropertyGridDockPanel1.ID = New System.Guid("b6bd5ba5-94c3-4bb2-b487-dbf331de999d")
            Me.DiagramPropertyGridDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DiagramPropertyGridDockPanel1.Name = "DiagramPropertyGridDockPanel1"
            Me.DiagramPropertyGridDockPanel1.Options.AllowFloating = False
            Me.DiagramPropertyGridDockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            '
            '
            '
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.AutoGenerateRows = True
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.Location = New System.Drawing.Point(0, 0)
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.Name = "propertyGrid"
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.OptionsMenu.EnableContextMenu = True
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.Size = New System.Drawing.Size(200, 100)
            Me.DiagramPropertyGridDockPanel1.PropertyGrid.TabIndex = 6
            Me.DiagramPropertyGridDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DiagramPropertyGridDockPanel1.SavedIndex = 1
            Me.DiagramPropertyGridDockPanel1.Size = New System.Drawing.Size(300, 806)
            Me.DiagramPropertyGridDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DiagramToolboxDockPanel1
            '
            Me.DiagramToolboxDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DiagramToolboxDockPanel1.FloatSize = New System.Drawing.Size(200, 500)
            Me.DiagramToolboxDockPanel1.ID = New System.Guid("443bc0e2-297d-46e8-826f-7c10a23e9a5d")
            Me.DiagramToolboxDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DiagramToolboxDockPanel1.Name = "DiagramToolboxDockPanel1"
            Me.DiagramToolboxDockPanel1.Options.AllowFloating = False
            Me.DiagramToolboxDockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.DiagramToolboxDockPanel1.Size = New System.Drawing.Size(300, 806)
            '
            '
            '
            Me.DiagramToolboxDockPanel1.Toolbox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.DiagramToolboxDockPanel1.Toolbox.Caption = "Shapes"
            Me.DiagramToolboxDockPanel1.Toolbox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DiagramToolboxDockPanel1.Toolbox.Location = New System.Drawing.Point(0, 0)
            Me.DiagramToolboxDockPanel1.Toolbox.Name = ""
            Me.DiagramToolboxDockPanel1.Toolbox.OptionsBehavior.ItemSelectMode = DevExpress.XtraToolbox.ToolboxItemSelectMode.[Single]
            Me.DiagramToolboxDockPanel1.Toolbox.OptionsView.ItemImageSize = New System.Drawing.Size(32, 32)
            Me.DiagramToolboxDockPanel1.Toolbox.OptionsView.MenuButtonCaption = "More Shapes"
            Me.DiagramToolboxDockPanel1.Toolbox.OptionsView.ShowToolboxCaption = True
            Me.DiagramToolboxDockPanel1.Toolbox.SelectedGroupIndex = 1
            Me.DiagramToolboxDockPanel1.Toolbox.Size = New System.Drawing.Size(291, 779)
            Me.DiagramToolboxDockPanel1.Toolbox.TabIndex = 0
            Me.DiagramToolboxDockPanel1.Toolbox.Text = "Shapes"
            '
            'DockManager1
            '
            Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
            Me.DockManager1.Form = Me
            Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DiagramToolboxDockPanel1, Me.DiagramControlDockPanel1})
            Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.DiagramPropertyGridDockPanel1)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(1302, 0)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(19, 806)
            '
            'DiagramControlDockPanel1
            '
            Me.DiagramControlDockPanel1.Controls.Add(Me.ControlContainer1)
            Me.DiagramControlDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.DiagramControlDockPanel1.DockedAsTabbedDocument = True
            Me.DiagramControlDockPanel1.FloatSize = New System.Drawing.Size(300, 200)
            Me.DiagramControlDockPanel1.ID = New System.Guid("343418fa-8001-4b30-930d-6fd71335b642")
            Me.DiagramControlDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DiagramControlDockPanel1.Name = "DiagramControlDockPanel1"
            Me.DiagramControlDockPanel1.Options.ShowCloseButton = False
            Me.DiagramControlDockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.DiagramControlDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DiagramControlDockPanel1.SavedIndex = 1
            Me.DiagramControlDockPanel1.Size = New System.Drawing.Size(996, 800)
            '
            'ControlContainer1
            '
            Me.ControlContainer1.Controls.Add(Me.diagramControl1)
            Me.ControlContainer1.Location = New System.Drawing.Point(0, 0)
            Me.ControlContainer1.Name = "ControlContainer1"
            Me.ControlContainer1.Size = New System.Drawing.Size(996, 800)
            Me.ControlContainer1.TabIndex = 0
            '
            'DocumentManager1
            '
            Me.DocumentManager1.ContainerControl = Me
            Me.DocumentManager1.View = Me.TabbedView1
            Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
            '
            'TabbedView1
            '
            Me.TabbedView1.DocumentGroupProperties.ShowTabHeader = False
            Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
            Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1})
            Me.TabbedView1.RootContainer.Element = Nothing
            DockingContainer1.Element = Me.DocumentGroup1
            Me.TabbedView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {DockingContainer1})
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1321, 806)
            Me.Controls.Add(Me.DiagramToolboxDockPanel1)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.diagramControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DiagramPropertyGridDockPanel1.PropertyGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerRight.ResumeLayout(False)
            Me.DiagramControlDockPanel1.ResumeLayout(False)
            Me.ControlContainer1.ResumeLayout(False)
            CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents diagramControl1 As DevExpress.XtraDiagram.DiagramControl
        Friend WithEvents DiagramPropertyGridDockPanel1 As DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel
        Friend WithEvents DiagramToolboxDockPanel1 As DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel
        Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents DiagramControlDockPanel1 As DevExpress.XtraDiagram.Docking.DiagramControlDockPanel
        Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    End Class
End Namespace

