﻿#ExternalChecksum("E:\WPProjects\Crystal PokeDex - XY&ORAS\Crystal PokeDex\PagePokemonsSearch.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","50F11FBA1B57CB7DE2D5044C49525051")
'------------------------------------------------------------------------------
' <auto-generated>
'     這段程式碼是由工具產生的。
'     執行階段版本:4.0.30319.18408
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
Partial Public Class PagePokemonsSearch
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents rectPokeImg As System.Windows.Shapes.Rectangle
    
    Friend WithEvents imgPokemon As System.Windows.Controls.Image
    
    Friend WithEvents btnGoToNum As System.Windows.Controls.Button
    
    Friend WithEvents gridLST As System.Windows.Controls.Grid
    
    Friend WithEvents lstPokemons As System.Windows.Controls.ListBox
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/Crystal%20PokeDex;component/PagePokemonsSearch.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.rectPokeImg = CType(Me.FindName("rectPokeImg"),System.Windows.Shapes.Rectangle)
        Me.imgPokemon = CType(Me.FindName("imgPokemon"),System.Windows.Controls.Image)
        Me.btnGoToNum = CType(Me.FindName("btnGoToNum"),System.Windows.Controls.Button)
        Me.gridLST = CType(Me.FindName("gridLST"),System.Windows.Controls.Grid)
        Me.lstPokemons = CType(Me.FindName("lstPokemons"),System.Windows.Controls.ListBox)
    End Sub
End Class

