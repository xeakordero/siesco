'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class AspNetUsers
    Public Property Id As String
    Public Property Email As String
    Public Property EmailConfirmed As Boolean
    Public Property PasswordHash As String
    Public Property SecurityStamp As String
    Public Property PhoneNumber As String
    Public Property PhoneNumberConfirmed As Boolean
    Public Property TwoFactorEnabled As Boolean
    Public Property LockoutEndDateUtc As Nullable(Of Date)
    Public Property LockoutEnabled As Boolean
    Public Property AccessFailedCount As Integer
    Public Property UserName As String

    Public Overridable Property AspNetUserClaims As ICollection(Of AspNetUserClaims) = New HashSet(Of AspNetUserClaims)
    Public Overridable Property AspNetUserLogins As ICollection(Of AspNetUserLogins) = New HashSet(Of AspNetUserLogins)
    Public Overridable Property Empleados As ICollection(Of Empleados) = New HashSet(Of Empleados)
    Public Overridable Property AspNetRoles As ICollection(Of AspNetRoles) = New HashSet(Of AspNetRoles)

End Class
