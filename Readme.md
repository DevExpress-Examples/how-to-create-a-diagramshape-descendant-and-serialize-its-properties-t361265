<!-- default file list -->
*Files to look at*:

* [DiagramShapeEx.cs](./CS/XtraDiagram.CustomShapeProperties/DiagramShapeEx.cs) (VB: [DiagramShapeEx.vb](./VB/XtraDiagram.CustomShapeProperties/DiagramShapeEx.vb))
* [Form1.cs](./CS/XtraDiagram.CustomShapeProperties/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CustomShapeProperties/Form1.vb))
* [Program.cs](./CS/XtraDiagram.CustomShapeProperties/Program.cs) (VB: [Program.vb](./VB/XtraDiagram.CustomShapeProperties/Program.vb))
<!-- default file list end -->
# How to create a DiagramShape descendant and serialize its properties


This example demonstrates how to serialize custom data using DiagramControl's serialization mechanism. In the example, the Content property of diagram shapes is loaded from data objects every time the diagram is shown. To associate shapes with data objects, the DatabaseObjectID property is added at the DiagramShape descendant level. To serialize this property along with standard DiagramShape properties, perform the following steps:<br><br><strong>Note:</strong><br><em>In certain scenarios, it is easier to use the DiagramShape.Tag property to store custom data without creating DiagramShape descendants. In this case, no further steps are needed as the Tag property is serialized by default.</em><br><br>1) Mark your custom property with the XtraSerializableProperty attribute:<br>


```cs
[XtraSerializableProperty]
public int DatabaseObjectID { get; set; }
```


<br>2) Call the ItemTypeRegistrator.Register method to register your custom shape type for serialization. Custom shape types should be registered at the application start. If the custom shape is used in the Diagram Designer, it is recommended to also register it in the shape type's static constructor.<br>


```cs
DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
```

<p><br> 3) Make sure that your custom item class has a parameterless constructor
    


<p>To edit your custom property in the Property Grid, handle the CustomGetEditableItemProperties event.</p>


```cs
private void diagramControl1_CustomGetEditableItemProperties(object sender, DiagramCustomGetEditableItemPropertiesEventArgs e) {
    if (e.Item is DiagramShapeEx) {
        e.Properties.Add(TypeDescriptor.GetProperties(typeof(DiagramShapeEx))["DatabaseObjectID"]);
    }
}
```



<br/>


