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

Partial Public Class inscripcion
    Public Property id As Integer
    Public Property id_student As Nullable(Of Integer)
    Public Property id_user As Nullable(Of Integer)
    Public Property id_employee As Nullable(Of Integer)
    Public Property id_payment As Nullable(Of Integer)
    Public Property id_group As Nullable(Of Integer)
    Public Property type As String
    Public Property state As String
    Public Property created_at As Nullable(Of Date)
    Public Property updated_at As Nullable(Of Date)

    Public Overridable Property employee As employee
    Public Overridable Property group As group
    Public Overridable Property shares As ICollection(Of share) = New HashSet(Of share)
    Public Overridable Property payment As payment
    Public Overridable Property student As student
    Public Overridable Property user As user

End Class
