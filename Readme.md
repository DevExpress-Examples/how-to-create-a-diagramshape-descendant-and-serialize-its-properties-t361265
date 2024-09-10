<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585357/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T361265)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DiagramShapeEx.cs](./CS/XtraDiagram.CustomShapeProperties/DiagramShapeEx.cs) (VB: [DiagramShapeEx.vb](./VB/XtraDiagram.CustomShapeProperties/DiagramShapeEx.vb))
* [Form1.cs](./CS/XtraDiagram.CustomShapeProperties/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CustomShapeProperties/Form1.vb))
* [Program.cs](./CS/XtraDiagram.CustomShapeProperties/Program.cs) (VB: [Program.vb](./VB/XtraDiagram.CustomShapeProperties/Program.vb))
<!-- default file list end -->
# How to create a DiagramShape descendant and serialize its properties


This example demonstrates how to serialize custom data using DiagramControl's serialization mechanism. In the example, the Content property of diagram shapes is loaded from data objects every time the diagram is shown. To associate shapes with data objects, the DatabaseObjectID property is added at the DiagramShape descendant level. To serialize this property along with standard DiagramShape properties, perform the following steps:<br><br><strong>Note:</strong><br><em>In certain scenarios, it is easier to use the DiagramShape.Tag property to store custom data without creating DiagramShape descendants. In this case, no further steps are needed as the Tag property is serialized by default.</em><br><br>1) Mark your custom property with the <strong>XtraSerializableProperty</strong> attribute:<br>


```cs
[XtraSerializableProperty]
public int DatabaseObjectID { get; set; }
```


<br>2) Call the <strong>ItemTypeRegistrator.Register</strong> method to register your custom shape type for serialization. Custom shape types should be registered at the application start. If the custom shape is used in the Diagram Designer, it is recommended to also register it in the shape type's static constructor.<br>


```cs
DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
```

<p><br> 3) Make sure that your custom item class has a parameterless constructor
    
<br>

<p>To edit your custom property in the Property Grid, handle the CustomGetEditableItemProperties event.</p>


```cs
private void diagramControl1_CustomGetEditableItemProperties(object sender, DiagramCustomGetEditableItemPropertiesEventArgs e) {
    if (e.Item is DiagramShapeEx) {
        e.Properties.Add(TypeDescriptor.GetProperties(typeof(DiagramShapeEx))["DatabaseObjectID"]);
    }
}
```



<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-a-diagramshape-descendant-and-serialize-its-properties-t361265&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-a-diagramshape-descendant-and-serialize-its-properties-t361265&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
