﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funcionalidad para autoguardar de My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("127.0.0.1")>  _
        Public Property db_servidor() As String
            Get
                Return CType(Me("db_servidor"),String)
            End Get
            Set
                Me("db_servidor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("root")>  _
        Public Property db_username() As String
            Get
                Return CType(Me("db_username"),String)
            End Get
            Set
                Me("db_username") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property db_password() As String
            Get
                Return CType(Me("db_password"),String)
            End Get
            Set
                Me("db_password") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("CltaEstacionamiento")>  _
        Public Property db_nameDB() As String
            Get
                Return CType(Me("db_nameDB"),String)
            End Get
            Set
                Me("db_nameDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3306")>  _
        Public Property db_puerto() As String
            Get
                Return CType(Me("db_puerto"),String)
            End Get
            Set
                Me("db_puerto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property login_username() As String
            Get
                Return CType(Me("login_username"),String)
            End Get
            Set
                Me("login_username") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property login_password() As String
            Get
                Return CType(Me("login_password"),String)
            End Get
            Set
                Me("login_password") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\ISC\Dropbox\Walpapers\8e0CP4E.jpg")>  _
        Public Property DesktopBackgroundImage() As String
            Get
                Return CType(Me("DesktopBackgroundImage"),String)
            End Get
            Set
                Me("DesktopBackgroundImage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Silver")>  _
        Public Property datagridview_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("datagridview_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("datagridview_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("64, 64, 64")>  _
        Public Property datagridview_selectrow() As Global.System.Drawing.Color
            Get
                Return CType(Me("datagridview_selectrow"),Global.System.Drawing.Color)
            End Get
            Set
                Me("datagridview_selectrow") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ActiveCaption")>  _
        Public Property Menu_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("Menu_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Menu_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Segoe UI, 13pt")>  _
        Public Property Menu_font() As Global.System.Drawing.Font
            Get
                Return CType(Me("Menu_font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Menu_font") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Segoe UI, 12pt")>  _
        Public Property text_font() As Global.System.Drawing.Font
            Get
                Return CType(Me("text_font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("text_font") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\clta_estacionamiento_data")>  _
        Public Property data_url() As String
            Get
                Return CType(Me("data_url"),String)
            End Get
            Set
                Me("data_url") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MXN")>  _
        Public Property moneda() As String
            Get
                Return CType(Me("moneda"),String)
            End Get
            Set
                Me("moneda") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property form_windowstate() As Integer
            Get
                Return CType(Me("form_windowstate"),Integer)
            End Get
            Set
                Me("form_windowstate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("210")>  _
        Public Property Height_Button() As Integer
            Get
                Return CType(Me("Height_Button"),Integer)
            End Get
            Set
                Me("Height_Button") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("180")>  _
        Public Property Width_Button() As Integer
            Get
                Return CType(Me("Width_Button"),Integer)
            End Get
            Set
                Me("Width_Button") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property Space_button() As Long
            Get
                Return CType(Me("Space_button"),Long)
            End Get
            Set
                Me("Space_button") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property ItemsXFilas() As String
            Get
                Return CType(Me("ItemsXFilas"),String)
            End Get
            Set
                Me("ItemsXFilas") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ActiveBorder")>  _
        Public Property button_colorSelect() As Global.System.Drawing.Color
            Get
                Return CType(Me("button_colorSelect"),Global.System.Drawing.Color)
            End Get
            Set
                Me("button_colorSelect") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Control")>  _
        Public Property button_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("button_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("button_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property id_publicoGeneral() As Integer
            Get
                Return CType(Me("id_publicoGeneral"),Integer)
            End Get
            Set
                Me("id_publicoGeneral") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3X9XI")>  _
        Public Property id_relevador() As String
            Get
                Return CType(Me("id_relevador"),String)
            End Get
            Set
                Me("id_relevador") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1000")>  _
        Public Property relevador_milisegundos() As Integer
            Get
                Return CType(Me("relevador_milisegundos"),Integer)
            End Get
            Set
                Me("relevador_milisegundos") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property rele_entrada() As Integer
            Get
                Return CType(Me("rele_entrada"),Integer)
            End Get
            Set
                Me("rele_entrada") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property rele_salida() As Integer
            Get
                Return CType(Me("rele_salida"),Integer)
            End Get
            Set
                Me("rele_salida") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("EMPRESA INVALIDA")>  _
        Public Property local_nombre() As String
            Get
                Return CType(Me("local_nombre"),String)
            End Get
            Set
                Me("local_nombre") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DIRECCION FICTICIA")>  _
        Public Property local_direccion() As String
            Get
                Return CType(Me("local_direccion"),String)
            End Get
            Set
                Me("local_direccion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0180000000")>  _
        Public Property local_telefono() As String
            Get
                Return CType(Me("local_telefono"),String)
            End Get
            Set
                Me("local_telefono") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("XXOXXXOA")>  _
        Public Property local_rfc() As String
            Get
                Return CType(Me("local_rfc"),String)
            End Get
            Set
                Me("local_rfc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PDFCreator")>  _
        Public Property ticket_impresora() As String
            Get
                Return CType(Me("ticket_impresora"),String)
            End Get
            Set
                Me("ticket_impresora") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ticket_mostrar_cliente() As Boolean
            Get
                Return CType(Me("ticket_mostrar_cliente"),Boolean)
            End Get
            Set
                Me("ticket_mostrar_cliente") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ticke_mostar_venderor() As Boolean
            Get
                Return CType(Me("ticke_mostar_venderor"),Boolean)
            End Get
            Set
                Me("ticke_mostar_venderor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ticket_mostrar_hote_impresion() As Boolean
            Get
                Return CType(Me("ticket_mostrar_hote_impresion"),Boolean)
            End Get
            Set
                Me("ticket_mostrar_hote_impresion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ticket_mostrar_pie_depagina() As Boolean
            Get
                Return CType(Me("ticket_mostrar_pie_depagina"),Boolean)
            End Get
            Set
                Me("ticket_mostrar_pie_depagina") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("www.cyberchoapas.com")>  _
        Public Property ticket_pie_de_pagina() As String
            Get
                Return CType(Me("ticket_pie_de_pagina"),String)
            End Get
            Set
                Me("ticket_pie_de_pagina") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Lucida Console, 8.25pt")>  _
        Public Property ticket_font() As Global.System.Drawing.Font
            Get
                Return CType(Me("ticket_font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("ticket_font") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.CLTA_Estacionamiento.My.MySettings
            Get
                Return Global.CLTA_Estacionamiento.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
