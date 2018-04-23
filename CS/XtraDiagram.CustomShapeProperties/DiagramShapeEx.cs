using DevExpress.Diagram.Core;
using DevExpress.Utils.Serializing;
using DevExpress.XtraDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XtraDiagram.CustomShapeProperties {
    public class DiagramShapeEx : DiagramShape {
        [XtraSerializableProperty]
        public int DatabaseObjectID { get; set; }
        static DiagramShapeEx() {
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
        }
    }
}
