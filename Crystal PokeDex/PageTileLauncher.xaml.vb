Partial Public Class PageTileLauncher
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
        InitalizeList()
        InitalizeMainList()
        IsSimplifiedChineseEnabled = IsoSettingsLib.Item("IsCHS")
        IsOfficialTranslationEnabled = IsoSettingsLib.Item("IsOfficial")
        GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
        SetCurrentDisplay()
    End Sub

    Private Sub PageTileLauncher_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        IsLaunchedFromPinned = True
        'IsoSettingsLib = IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings
        'Do
        'MessageBox.Show(IsoSettingsLib.Keys.Count)
        'Loop Until 1 = 2
        'Thread.Sleep(TimeSpan.FromSeconds(5))
        'If IsoSettingsLib.Keys.Count = 0 Then
        '   NavigationService.Navigate(New Uri("/PageBlank.xaml", UriKind.RelativeOrAbsolute))
        'End If
        'NavigationService.GoBack()
        'NavigationService.RemoveBackEntry()
        If IsoSettingsLib.Keys.Count = 0 Then
            IsoSettingsLib.Add("IsCHS", False)
            IsoSettingsLib.Add("IsOfficial", False)
            'InitFirstLaunch()
            'With IsoSettingsLib
            '    .Add("ColorHP", ValueHP)
            '    .Add("ColorATK", ValueAttack)
            '    .Add("ColorDEF", ValueDefence)
            '    .Add("ColorSATK", ValueSpecialAttack)
            '    .Add("ColorSDEF", ValueSpecialDefence)
            '    .Add("ColorSPD", ValueSpeed)
            '    .Add("ColorTotal", ValueTotal)
            'End With
        End If
        If IsoSettingsLib.Keys.Count = 1 Then
            IsoSettingsLib.Add("IsOfficial", False)
            'InitFirstLaunch()
            'With IsoSettingsLib
            '    .Add("ColorHP", ValueHP)
            '    .Add("ColorATK", ValueAttack)
            '    .Add("ColorDEF", ValueDefence)
            '    .Add("ColorSATK", ValueSpecialAttack)
            '    .Add("ColorSDEF", ValueSpecialDefence)
            '    .Add("ColorSPD", ValueSpeed)
            '    .Add("ColorTotal", ValueTotal)
            'End With
        End If
        'If IsoSettingsLib.Keys.Count = 2 Then
        '    InitFirstLaunch()
        '    With IsoSettingsLib
        '        .Add("ColorHP", ValueHP)
        '        .Add("ColorATK", ValueAttack)
        '        .Add("ColorDEF", ValueDefence)
        '        .Add("ColorSATK", ValueSpecialAttack)
        '        .Add("ColorSDEF", ValueSpecialDefence)
        '        .Add("ColorSPD", ValueSpeed)
        '        .Add("ColorTotal", ValueTotal)
        '    End With
        'End If
        'InitColors()
        InitColorStorage()

        'IsChineseNames = IsoSettingsLib.Item("IsCHS")
        'If IsChineseNames Then
        '    chkUseCHS.IsChecked = True
        'Else
        '    chkUseCHS.IsChecked = False
        'End If
        InitalizeTileIndexServer()
        Dim comm As Integer
        'navig()
        Dim nums As String
        nums = ""
        comm = 0
        'nums = comm.Chars(comm.Length - 2) & comm.Chars(comm.Length - 1) & comm.Chars(comm.Length)
        If NavigationContext.QueryString.Keys.Contains("Num") Then
            NavigationContext.QueryString.TryGetValue("Num", nums)
        End If
        comm = CInt(nums)
        PokemonInformationShared = GetPokemonInformation(CInt(nums))
        NavigationService.Navigate(New System.Uri("/PagePokemonDetails.xaml", UriKind.RelativeOrAbsolute))
        'MessageBox.Show(nums)
    End Sub
End Class
