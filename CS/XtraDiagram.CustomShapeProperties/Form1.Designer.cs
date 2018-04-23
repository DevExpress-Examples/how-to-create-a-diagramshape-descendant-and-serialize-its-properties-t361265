namespace XtraDiagram.CustomShapeProperties {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.AutoSize;
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.DocumentSource = null;
            this.diagramControl1.FileDialogFilter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Collapsed;
            this.diagramControl1.OptionsView.FitToDrawingMargin = new System.Windows.Forms.Padding(10);
            this.diagramControl1.OptionsView.PageSize = new System.Drawing.SizeF(800F, 600F);
            this.diagramControl1.OptionsView.ShowGrid = true;
            this.diagramControl1.OptionsView.ShowRulers = true;
            this.diagramControl1.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.Size = new System.Drawing.Size(1321, 806);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            this.diagramControl1.ShowingEditor += new System.EventHandler<DevExpress.XtraDiagram.DiagramShowingEditorEventArgs>(this.OnShowingEditor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 806);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
    }
}

