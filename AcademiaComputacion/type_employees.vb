'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class type_employees
    Public Property id As Integer
    Public Property description As String
    Public Property state As String
    Public Property created_at As Nullable(Of Date)
    Public Property updated_at As Nullable(Of Date)

    Public Overridable Property employees As ICollection(Of employee) = New HashSet(Of employee)

End Class
