using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraDiagram;
using System.IO;
using DevExpress.Diagram.Core;

namespace XtraDiagram.CustomShapeProperties {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        const string diagramName = "diagram.xml";
        List<DataObject> DataObjects = new List<DataObject>();
        public Form1() {
            InitializeComponent();
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
            DataObjects.Add(new DataObject { ID = 0, Content = "Start" });
            DataObjects.Add(new DataObject { ID = 1, ParentID = 0, Content = "Node 1" });
            DataObjects.Add(new DataObject { ID = 2, ParentID = 1, Content = "Node 1_1" });
            DataObjects.Add(new DataObject { ID = 3, ParentID = 0, Content = "Node 2" });
            DataObjects.Add(new DataObject { ID = 4, ParentID = 3, Content = "Node 2_1" });
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (!File.Exists(diagramName))
                CreateDiagram();
            else
                LoadDiagram();
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            diagramControl1.SaveDocument(diagramName);
        }

        private void LoadDiagram() {
            try {
                diagramControl1.LoadDocument(diagramName);
                foreach (var item in diagramControl1.Items) {
                    var shape = item as DiagramShapeEx;
                    DataObject dataObject;
                    if (shape != null)
                        shape.Content = (dataObject = DataObjects.FirstOrDefault(x => x.ID == shape.DatabaseObjectID)) == null ? null : dataObject.Content;
                }
            }
            catch (Exception e) {
                CreateDiagram();
            }
        }
        private void CreateDiagram() {
            foreach (var dataObject in DataObjects) {
                var shape = new DiagramShapeEx {
                    Shape = BasicShapes.Rectangle,
                    Size = new Size(150, 100),
                    DatabaseObjectID = dataObject.ID,
                    Content = dataObject.Content
                };
                diagramControl1.Items.Add(shape);
                if (dataObject.ParentID != dataObject.ID)
                    diagramControl1.Items.Add(new DiagramConnector {
                        BeginItem = diagramControl1.Items.First(x => x is DiagramShapeEx && ((DiagramShapeEx)x).DatabaseObjectID == dataObject.ParentID),
                        EndItem = shape
                    });
            }
            diagramControl1.LayoutTreeDiagram(Direction.Right);
        }
        private void OnShowingEditor(object sender, DiagramShowingEditorEventArgs e) {
            e.Cancel = true;
        }
    }
    public class DataObject {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Content { get; set; }
    }
}