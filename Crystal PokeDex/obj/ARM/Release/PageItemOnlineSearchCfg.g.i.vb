﻿#ExternalChecksum("D:\WPProjects\Crystal PokeDex\Crystal PokeDex\PageItemOnlineSearchCfg.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","7EEC65BCCFF01290026DF4002B0D2A25")
'------------------------------------------------------------------------------
' <auto-generated>
'     這段程式碼是由工具產生的。
'     執行階段版本:4.0.30319.42000
'
'     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
'     變更將會遺失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class PageItemOnlineSearchCfg
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents rdCHT As System.Windows.Controls.RadioButton
    
    Friend WithEvents rdENG As System.Windows.Controls.RadioButton
    
    Friend WithEvents rdJPN As System.Windows.Controls.RadioButton
    
    Friend WithEvents btnSearch As System.Windows.Controls.Button
    
    Friend WithEvents btnCancel As System.Windows.Controls.Button
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/Crystal%20PokeDex;component/PageItemOnlineSearchCfg.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.rdCHT = CType(Me.FindName("rdCHT"),System.Windows.Controls.RadioButton)
        Me.rdENG = CType(Me.FindName("rdENG"),System.Windows.Controls.RadioButton)
        Me.rdJPN = CType(Me.FindName("rdJPN"),System.Windows.Controls.RadioButton)
        Me.btnSearch = CType(Me.FindName("btnSearch"),System.Windows.Controls.Button)
        Me.btnCancel = CType(Me.FindName("btnCancel"),System.Windows.Controls.Button)
    End Sub
End Class

