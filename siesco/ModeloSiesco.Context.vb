﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property C__MigrationHistory() As DbSet(Of C__MigrationHistory)
    Public Overridable Property Activos() As DbSet(Of Activos)
    Public Overridable Property AspNetRoles() As DbSet(Of AspNetRoles)
    Public Overridable Property AspNetUserClaims() As DbSet(Of AspNetUserClaims)
    Public Overridable Property AspNetUserLogins() As DbSet(Of AspNetUserLogins)
    Public Overridable Property AspNetUsers() As DbSet(Of AspNetUsers)
    Public Overridable Property C__MigrationHistory1() As DbSet(Of C__MigrationHistory1)
    Public Overridable Property Clientes() As DbSet(Of Clientes)
    Public Overridable Property DisponibilidadActivos() As DbSet(Of DisponibilidadActivos)
    Public Overridable Property DisponibilidadEmpleados() As DbSet(Of DisponibilidadEmpleados)
    Public Overridable Property Empleados() As DbSet(Of Empleados)

End Class
