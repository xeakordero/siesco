﻿Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.js"))
        bundles.Add(New ScriptBundle("~/bundles/calendar").Include(
                  "~/Scripts/Calendar/fullcalendar.min.js"))
        bundles.Add(New ScriptBundle("~/bundles/moment").Include(
                  "~/Scripts/moment.js"))
        bundles.Add(New ScriptBundle("~/bundles/datatables").Include(
                  "~/Scripts/DataTables/jquery.dataTables.js"))


        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css"))

        bundles.Add(New StyleBundle("~/Content/calendar").Include(
                  "~/Content/Calendar/fullcalendar.css"))
        bundles.Add(New StyleBundle("~/Content/datatables").Include(
                  "~/Content/DataTables/css/jquery.dataTables.css"))
    End Sub
End Module

