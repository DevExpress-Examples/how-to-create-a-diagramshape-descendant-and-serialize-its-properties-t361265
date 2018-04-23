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

        <Browsable(False), XtraSerializableProperty> _
        Public Property DatabaseObjectID() As Integer
    End Class
End Namespace
