Partial Public Class PagePokemonDetails
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PagePokemonDetails_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'InitializeAbilities()
        If IsLaunchedFromPinned Then
            NavigationService.RemoveBackEntry()
        End If
        GenerateSpecificStateInfo(CLng(PokemonInformationShared.lpNumber))
        GenerateEvolutionData(CInt(PokemonInformationShared.lpNumber))
        gridNoEvolution.Visibility = System.Windows.Visibility.Visible
        imgArrow.Visibility = System.Windows.Visibility.Collapsed
        rectImgEvo_Dest.Visibility = System.Windows.Visibility.Collapsed
        imgEvoDest.Visibility = System.Windows.Visibility.Collapsed
        txtName_EVODest.Visibility = System.Windows.Visibility.Collapsed
        txtNum_EVODest.Visibility = System.Windows.Visibility.Collapsed
        lblEvolution.Visibility = System.Windows.Visibility.Collapsed
        Dim imgPokemonMale As Media.Imaging.BitmapImage
        imgPokemonMale = New Imaging.BitmapImage
        Dim imgPokemonFemale As Media.Imaging.BitmapImage
        imgPokemonFemale = New Imaging.BitmapImage
        Dim imgPokemonMegaX As Media.Imaging.BitmapImage
        imgPokemonMegaX = New Imaging.BitmapImage
        Dim imgPokemonMegaY As Media.Imaging.BitmapImage
        imgPokemonMegaY = New Imaging.BitmapImage
        Dim imgPokemonMegaORAS As Media.Imaging.BitmapImage
        imgPokemonMegaORAS = New Imaging.BitmapImage
        Dim imgPokemonOriginal As Media.Imaging.BitmapImage
        imgPokemonOriginal = New Imaging.BitmapImage
        Dim imgPokemonEvolutionBasic As Media.Imaging.BitmapImage
        imgPokemonEvolutionBasic = New Imaging.BitmapImage
        imgPokemonFemale.UriSource = New Uri(PokemonInformationShared.lpImageFemaleUri, UriKind.RelativeOrAbsolute)
        imgPokemonMale.UriSource = New Uri(PokemonInformationShared.lpImageMaleUri, UriKind.RelativeOrAbsolute)
        imgPokemonMegaX.UriSource = New Uri(PokemonInformationShared.lpImageMegaXUri, UriKind.RelativeOrAbsolute)
        imgPokemonMegaY.UriSource = New Uri(PokemonInformationShared.lpImageMegaYUri, UriKind.RelativeOrAbsolute)
        imgPokemonMegaORAS.UriSource = New Uri(PokemonInformationShared.lpImageMegaORASUri, UriKind.RelativeOrAbsolute)
        imgPokemonOriginal.UriSource = New Uri(PokemonInformationShared.lpImageOriginalUri, UriKind.RelativeOrAbsolute)
        imgPokemonEvolutionBasic.UriSource = New Uri("/PokemonsL/" & PokemonInformationShared.lpNumber & ".png", UriKind.RelativeOrAbsolute)
        imgFemale.Source = imgPokemonFemale
        imgMale.Source = imgPokemonMale
        'imgMegaX.Source = imgPokemonMegaX
        'imgMegaY.Source = imgPokemonMegaY
        'imgMegaORAS.Source = imgPokemonMegaORAS
        'imgOriginal.Source = imgPokemonOriginal
        imgEvoBasic.Source = imgPokemonEvolutionBasic
        With ValueHP
            If .IsSystemAccent Then
                prgSVHP.Foreground = prgEXP.Foreground
                'prgSVHP_MORAS.Foreground = prgEXP.Foreground
                'prgSVHP_MX.Foreground = prgEXP.Foreground
                'prgSVHP_MY.Foreground = prgEXP.Foreground
                'prgSVHP_OS.Foreground = prgEXP.Foreground
            Else
                prgSVHP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueAttack
            If .IsSystemAccent Then
                prgSVATK.Foreground = prgEXP.Foreground
                'prgSVATK_MORAS.Foreground = prgEXP.Foreground
                'prgSVATK_MX.Foreground = prgEXP.Foreground
                'prgSVATK_MY.Foreground = prgEXP.Foreground
                'prgSVATK_OS.Foreground = prgEXP.Foreground
            Else
                prgSVATK.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueDefence
            If .IsSystemAccent Then
                prgSVDEF.Foreground = prgEXP.Foreground
                'prgSVDEF_MORAS.Foreground = prgEXP.Foreground
                'prgSVDEF_MX.Foreground = prgEXP.Foreground
                'prgSVDEF_MY.Foreground = prgEXP.Foreground
                'prgSVDEF_OS.Foreground = prgEXP.Foreground
            Else
                prgSVDEF.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpecialAttack
            If .IsSystemAccent Then
                prgSVSA.Foreground = prgEXP.Foreground
                'prgSVSA_MORAS.Foreground = prgEXP.Foreground
                'prgSVSA_MX.Foreground = prgEXP.Foreground
                'prgSVSA_MY.Foreground = prgEXP.Foreground
                'prgSVSA_OS.Foreground = prgEXP.Foreground
            Else
                prgSVSA.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpecialDefence
            If .IsSystemAccent Then
                prgSVSD.Foreground = prgEXP.Foreground
                'prgSVSD_MORAS.Foreground = prgEXP.Foreground
                'prgSVSD_MX.Foreground = prgEXP.Foreground
                'prgSVSD_MY.Foreground = prgEXP.Foreground
                'prgSVSD_OS.Foreground = prgEXP.Foreground
            Else
                prgSVSD.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpeed
            If .IsSystemAccent Then
                prgSVSP.Foreground = prgEXP.Foreground
                'prgSVSP_MORAS.Foreground = prgEXP.Foreground
                'prgSVSP_MX.Foreground = prgEXP.Foreground
                'prgSVSP_MY.Foreground = prgEXP.Foreground
                'prgSVSP_OS.Foreground = prgEXP.Foreground
            Else
                prgSVSP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueTotal
            If .IsSystemAccent Then
                prgSVT.Foreground = prgEXP.Foreground
                'prgSVT_MORAS.Foreground = prgEXP.Foreground
                'prgSVT_MX.Foreground = prgEXP.Foreground
                'prgSVT_MY.Foreground = prgEXP.Foreground
                'prgSVT_OS.Foreground = prgEXP.Foreground
            Else
                prgSVT.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        If PokemonInformationShared.IsNoSex Then
            imgFemale.Visibility = System.Windows.Visibility.Collapsed
            rectImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgMale.Text = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1) & " 的外貌"
        Else
            imgFemale.Visibility = System.Windows.Visibility.Visible
            rectImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgMale.Text = "雄性的外貌"
        End If
        pivotBack.Title = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1)
        GenerateMultiStateList(PokemonInformationShared.lpNumber)
        If States.Count = 0 Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            lstStates.ItemsSource = States
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
        End If
        With PokemonInformationShared
            txtBasicFV.Text = .lpStandardFriendlyRate
            txtCatchRate.Text = .lpCatchRate
            txtType.Text = .lpType
            Dim PMType As TypeData = ParseTypeString(.lpType)
            If PMType.IsType2Available Then
                gridType2.Visibility = System.Windows.Visibility.Visible
                txtType1.Text = PMType.TypeString1
                gridType1.Background = New SolidColorBrush(Color.FromArgb(255, PMType.TypeColor1.Red, PMType.TypeColor1.Green, PMType.TypeColor1.Blue))
                txtType2.Text = PMType.TypeString2
                gridType2.Background = New SolidColorBrush(Color.FromArgb(255, PMType.TypeColor2.Red, PMType.TypeColor2.Green, PMType.TypeColor2.Blue))
            Else
                gridType2.Visibility = System.Windows.Visibility.Collapsed
                txtType1.Text = PMType.TypeString1
                gridType1.Background = New SolidColorBrush(Color.FromArgb(255, PMType.TypeColor1.Red, PMType.TypeColor1.Green, PMType.TypeColor1.Blue))
            End If
            txtDescription.Text = .lpDescription
            txtEgg1.Text = .lpEggGroup1
            txtEgg2.Text = .lpEggGroup2
            txtExpBasic.Text = .lpBasicExpPoint
            txtExpFullLV.Text = .lpFullLevelExpPoint
            txtHatch.Text = .lpBornStepsCount
            txtHeight.Text = .lpHeight
            txtName.Text = CurrentTranslationForCommonUse(CInt(.lpNumber) - 1)
            txtName_EVOBasic.Text = CurrentTranslationForCommonUse(CInt(.lpNumber) - 1)
            txtNum_EVOBasic.Text = "全國圖鑑登錄號 " & .lpNumber
            txtNum.Text = "全國圖鑑登錄號 " & .lpNumber
            txtShelter.Text = .lpSheleter
            txtSexRatio.Text = .lpSexRatio
            txtSVATK.Text = .lpBaseValues.ATTACK.ToString
            txtSVDEF.Text = .lpBaseValues.DEFEND.ToString
            txtSVHP.Text = .lpBaseValues.HP.ToString
            txtSVSA.Text = .lpBaseValues.SPATTACK.ToString
            txtSVSD.Text = .lpBaseValues.SPDEFEND.ToString
            txtSVSP.Text = .lpBaseValues.SPEED
            txtSVT.Text = .lpBaseValues.TOTAL.ToString
            txtClass.Text = .lpClass
            txtWeight.Text = .lpWeight
            If .lpAbility1 <> "---" And .lpAbility1 <> "ERROR" Then
                txtAbility1.Text = CurrentAbility(CInt(.lpAbility1) - 1)
            Else
                txtAbility1.Text = .lpAbility1
            End If
            If .lpAbility2 <> "---" And .lpAbility2 <> "ERROR" Then
                txtAbility2.Text = CurrentAbility(CInt(.lpAbility2) - 1)
            Else
                txtAbility2.Text = .lpAbility2
            End If
            If .lpAbilityHidden <> "---" And .lpAbilityHidden <> "ERROR" Then
                txtAbility3.Text = CurrentAbility(CInt(.lpAbilityHidden) - 1)
            Else
                txtAbility3.Text = .lpAbilityHidden
            End If
            txtROC.Text = .lpNameCHT
            txtPRC.Text = .lpNameCHS
            txtENU.Text = .lpNameENG
            txtJPN.Text = .lpNameJPN
            txtKOR.Text = .lpNameKOR
            txtFRA.Text = .lpNameFRA
            txtGER.Text = .lpNameGER
            txtCHTO.Text = .lpNameCHTO
            txtCHSO.Text = .lpNameCHSO
            Select Case CLng(.lpNumber)
                Case Is <= 151
                    btnRGBY.IsEnabled = True
                    btnGSC.IsEnabled = True
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    Exit Select
                Case Is <= 251
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = True
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    Exit Select
                Case Is <= 386
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    Exit Select
                Case Is <= 493
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    Exit Select
                Case Is <= 649
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    Exit Select
                Case Is <= 721
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    Exit Select
                Case Is <= 809
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = True
                    Exit Select
                Case Else
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = False
                    Exit Select
            End Select
            If .IsMissingNo Then
                btnRGBY.IsEnabled = False
                btnGSC.IsEnabled = False
                btnRSE.IsEnabled = False
                btnDPT.IsEnabled = False
                btnBW.IsEnabled = False
                btnXY.IsEnabled = False
                btnSM.IsEnabled = False
            End If
        End With
        'If PokemonInformationShared.IsOriginalAvailable = False Then
        '    GridNotAvailable_OS.Visibility = System.Windows.Visibility.Visible
        '    'pivotOriginal.Visibility = System.Windows.Visibility.Collapsed
        'ElseIf PokemonInformationShared.IsOriginalAvailable = True Then
        '    'pivotOriginal.Visibility = System.Windows.Visibility.Visible
        '    'GridNotAvailable.Visibility = System.Windows.Visibility.Collapsed
        '    'GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Collapsed
        '    GridNotAvailable_OS.Visibility = System.Windows.Visibility.Collapsed
        '    With PokemonInformationShared.lpOriginalInfo
        '        txtClass_Original.Text = .lpType
        '        txtAbility1_OS.Text = .lpAbility1
        '        txtAbility2_OS.Text = .lpAbility2
        '        txtAbility3_OS.Text = .lpAbilityHidden
        '        txtSVATK_OS.Text = .lpBaseStatsValues.ATTACK
        '        txtSVDEF_OS.Text = .lpBaseStatsValues.DEFEND
        '        txtSVHP_OS.Text = .lpBaseStatsValues.HP
        '        txtSVSA_OS.Text = .lpBaseStatsValues.SPATTACK
        '        txtSVSD_OS.Text = .lpBaseStatsValues.SPDEFEND
        '        txtSVSP_OS.Text = .lpBaseStatsValues.SPEED
        '        txtSVT_OS.Text = .lpBaseStatsValues.TOTAL
        '        With .lpBaseStatsValues
        '            prgSVATK_OS.Value = .ATTACK
        '            prgSVDEF_OS.Value = .DEFEND
        '            prgSVHP_OS.Value = .HP
        '            prgSVSA_OS.Value = .SPATTACK
        '            prgSVSD_OS.Value = .SPDEFEND
        '            prgSVSP_OS.Value = .SPEED
        '            prgSVT_OS.Value = .TOTAL
        '        End With
        '    End With
        'With PokemonInformationShared.lpMegaYInfo
        '    txtAbility1_MY.Text = .lpAbility1
        '    txtAbility2_MY.Text = .lpAbility2
        '    txtAbility3_MY.Text = .lpAbilityHidden
        '    txtSVATK_MY.Text = .lpBaseStatsValues.ATTACK
        '    txtSVDEF_MY.Text = .lpBaseStatsValues.DEFEND
        '    txtSVHP_MY.Text = .lpBaseStatsValues.HP
        '    txtSVSA_MY.Text = .lpBaseStatsValues.SPATTACK
        '    txtSVSD_MY.Text = .lpBaseStatsValues.SPDEFEND
        '    txtSVSP_MY.Text = .lpBaseStatsValues.SPEED
        '    txtSVT_MY.Text = .lpBaseStatsValues.TOTAL
        '    With .lpBaseStatsValues
        '        prgSVATK_MY.Value = .ATTACK
        '        prgSVDEF_MY.Value = .DEFEND
        '        prgSVHP_MY.Value = .HP
        '        prgSVSA_MY.Value = .SPATTACK
        '        prgSVSD_MY.Value = .SPDEFEND
        '        prgSVSP_MY.Value = .SPEED
        '        prgSVT_MY.Value = .TOTAL
        '    End With
        'End With
        'Else
        ''GridNotAvailable.Visibility = System.Windows.Visibility.Visible
        ''GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Visible
        'GridNotAvailable_OS.Visibility = System.Windows.Visibility.Visible
        ''pivotOriginal.Visibility = System.Windows.Visibility.Collapsed
        'End If
        If PokemonInformationShared.IsMegaORASAvailable = False Then
            'GridNotAvailable_MORAS.Visibility = System.Windows.Visibility.Visible
            'pivotMegaORAS.Visibility = System.Windows.Visibility.Collapsed
        ElseIf PokemonInformationShared.IsMegaORASAvailable = True Then
            'GridNotAvailable_MORAS.Visibility = System.Windows.Visibility.Collapsed
            'pivotMegaORAS.Visibility = System.Windows.Visibility.Visible
            'pivotOriginal.Visibility = System.Windows.Visibility.Visible
            'GridNotAvailable.Visibility = System.Windows.Visibility.Collapsed
            'GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Collapsed
            'GridNotAvailable_OS.Visibility = System.Windows.Visibility.Collapsed
            'With PokemonInformationShared.lpMegaORASInfo
            '    txtClass_MORAS.Text = .lpType
            '    txtAbility1_MORAS.Text = .lpAbility1
            '    txtAbility2_MORAS.Text = .lpAbility2
            '    txtAbility3_MORAS.Text = .lpAbilityHidden
            '    If .lpAbility1 <> "---" And .lpAbility1 <> "ERROR" Then
            '        txtAbility1_MORAS.Text = CurrentAbility(CInt(.lpAbility1) - 1)
            '    Else
            '        txtAbility1_MORAS.Text = .lpAbility1
            '    End If
            '    If .lpAbility2 <> "---" And .lpAbility2 <> "ERROR" Then
            '        txtAbility2_MORAS.Text = CurrentAbility(CInt(.lpAbility2) - 1)
            '    Else
            '        txtAbility2_MORAS.Text = .lpAbility2
            '    End If
            '    If .lpAbilityHidden <> "---" And .lpAbilityHidden <> "ERROR" Then
            '        txtAbility3_MORAS.Text = CurrentAbility(CInt(.lpAbilityHidden) - 1)
            '    Else
            '        txtAbility3_MORAS.Text = .lpAbilityHidden
            '    End If
            '    txtSVATK_MORAS.Text = .lpBaseStatsValues.ATTACK
            '    txtSVDEF_MORAS.Text = .lpBaseStatsValues.DEFEND
            '    txtSVHP_MORAS.Text = .lpBaseStatsValues.HP
            '    txtSVSA_MORAS.Text = .lpBaseStatsValues.SPATTACK
            '    txtSVSD_MORAS.Text = .lpBaseStatsValues.SPDEFEND
            '    txtSVSP_MORAS.Text = .lpBaseStatsValues.SPEED
            '    txtSVT_MORAS.Text = .lpBaseStatsValues.TOTAL
            '    With .lpBaseStatsValues
            '        prgSVATK_MORAS.Value = .ATTACK
            '        prgSVDEF_MORAS.Value = .DEFEND
            '        prgSVHP_MORAS.Value = .HP
            '        prgSVSA_MORAS.Value = .SPATTACK
            '        prgSVSD_MORAS.Value = .SPDEFEND
            '        prgSVSP_MORAS.Value = .SPEED
            '        prgSVT_MORAS.Value = .TOTAL
            '    End With
            'End With
            'With PokemonInformationShared.lpMegaYInfo
            '    txtAbility1_MY.Text = .lpAbility1
            '    txtAbility2_MY.Text = .lpAbility2
            '    txtAbility3_MY.Text = .lpAbilityHidden
            '    txtSVATK_MY.Text = .lpBaseStatsValues.ATTACK
            '    txtSVDEF_MY.Text = .lpBaseStatsValues.DEFEND
            '    txtSVHP_MY.Text = .lpBaseStatsValues.HP
            '    txtSVSA_MY.Text = .lpBaseStatsValues.SPATTACK
            '    txtSVSD_MY.Text = .lpBaseStatsValues.SPDEFEND
            '    txtSVSP_MY.Text = .lpBaseStatsValues.SPEED
            '    txtSVT_MY.Text = .lpBaseStatsValues.TOTAL
            '    With .lpBaseStatsValues
            '        prgSVATK_MY.Value = .ATTACK
            '        prgSVDEF_MY.Value = .DEFEND
            '        prgSVHP_MY.Value = .HP
            '        prgSVSA_MY.Value = .SPATTACK
            '        prgSVSD_MY.Value = .SPDEFEND
            '        prgSVSP_MY.Value = .SPEED
            '        prgSVT_MY.Value = .TOTAL
            '    End With
            'End With
        Else
            'GridNotAvailable.Visibility = System.Windows.Visibility.Visible
            'GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Visible
            'GridNotAvailable_OS.Visibility = System.Windows.Visibility.Visible
            'pivotOriginal.Visibility = System.Windows.Visibility.Collapsed
            'GridNotAvailable_MORAS.Visibility = System.Windows.Visibility.Visible
            'pivotMegaORAS.Visibility = System.Windows.Visibility.Collapsed
        End If
        If PokemonInformationShared.IsMegaAvailable = False Then
            'GridNotAvailable.Visibility = System.Windows.Visibility.Visible
            'GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Visible
            'pivotMegaX.Visibility = System.Windows.Visibility.Collapsed
            'pivotMegaY.Visibility = System.Windows.Visibility.Collapsed
        ElseIf PokemonInformationShared.IsMegaAvailable = True Then
            'GridNotAvailable.Visibility = System.Windows.Visibility.Collapsed
            'GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Collapsed
            'pivotMegaX.Visibility = System.Windows.Visibility.Visible
            'pivotMegaY.Visibility = System.Windows.Visibility.Visible
            'With PokemonInformationShared.lpMegaXInfo
            '    txtClass_MX.Text = .lpType
            '    If .lpAbility1 <> "---" And .lpAbility1 <> "ERROR" Then
            '        txtAbility1_MX.Text = CurrentAbility(CInt(.lpAbility1) - 1)
            '    Else
            '        txtAbility1_MX.Text = .lpAbility1
            '    End If
            '    If .lpAbility2 <> "---" And .lpAbility2 <> "ERROR" Then
            '        txtAbility2_MX.Text = CurrentAbility(CInt(.lpAbility2) - 1)
            '    Else
            '        txtAbility2_MX.Text = .lpAbility2
            '    End If
            '    If .lpAbilityHidden <> "---" And .lpAbilityHidden <> "ERROR" Then
            '        txtAbility3_MX.Text = CurrentAbility(CInt(.lpAbilityHidden) - 1)
            '    Else
            '        txtAbility3_MX.Text = .lpAbilityHidden
            '    End If
            '    txtSVATK_MX.Text = .lpBaseStatsValues.ATTACK
            '    txtSVDEF_MX.Text = .lpBaseStatsValues.DEFEND
            '    txtSVHP_MX.Text = .lpBaseStatsValues.HP
            '    txtSVSA_MX.Text = .lpBaseStatsValues.SPATTACK
            '    txtSVSD_MX.Text = .lpBaseStatsValues.SPDEFEND
            '    txtSVSP_MX.Text = .lpBaseStatsValues.SPEED
            '    txtSVT_MX.Text = .lpBaseStatsValues.TOTAL
            '    With .lpBaseStatsValues
            '        prgSVATK_MX.Value = .ATTACK
            '        prgSVDEF_MX.Value = .DEFEND
            '        prgSVHP_MX.Value = .HP
            '        prgSVSA_MX.Value = .SPATTACK
            '        prgSVSD_MX.Value = .SPDEFEND
            '        prgSVSP_MX.Value = .SPEED
            '        prgSVT_MX.Value = .TOTAL
            '    End With
            'End With
            'With PokemonInformationShared.lpMegaYInfo
            '    txtAbility1_MY.Text = .lpAbility1
            '    txtClass_MY.Text = .lpType
            '    txtAbility2_MY.Text = .lpAbility2
            '    txtAbility3_MY.Text = .lpAbilityHidden
            '    If .lpAbility1 <> "---" And .lpAbility1 <> "ERROR" Then
            '        txtAbility1_MY.Text = CurrentAbility(CInt(.lpAbility1) - 1)
            '    Else
            '        txtAbility1_MY.Text = .lpAbility1
            '    End If
            '    If .lpAbility2 <> "---" And .lpAbility2 <> "ERROR" Then
            '        txtAbility2_MY.Text = CurrentAbility(CInt(.lpAbility2) - 1)
            '    Else
            '        txtAbility2_MY.Text = .lpAbility2
            '    End If
            '    If .lpAbilityHidden <> "---" And .lpAbilityHidden <> "ERROR" Then
            '        txtAbility3_MY.Text = CurrentAbility(CInt(.lpAbilityHidden) - 1)
            '    Else
            '        txtAbility3_MY.Text = .lpAbilityHidden
            '    End If
            '    txtSVATK_MY.Text = .lpBaseStatsValues.ATTACK
            '    txtSVDEF_MY.Text = .lpBaseStatsValues.DEFEND
            '    txtSVHP_MY.Text = .lpBaseStatsValues.HP
            '    txtSVSA_MY.Text = .lpBaseStatsValues.SPATTACK
            '    txtSVSD_MY.Text = .lpBaseStatsValues.SPDEFEND
            '    txtSVSP_MY.Text = .lpBaseStatsValues.SPEED
            '    txtSVT_MY.Text = .lpBaseStatsValues.TOTAL
            '    With .lpBaseStatsValues
            '        prgSVATK_MY.Value = .ATTACK
            '        prgSVDEF_MY.Value = .DEFEND
            '        prgSVHP_MY.Value = .HP
            '        prgSVSA_MY.Value = .SPATTACK
            '        prgSVSD_MY.Value = .SPDEFEND
            '        prgSVSP_MY.Value = .SPEED
            '        prgSVT_MY.Value = .TOTAL
            '    End With
            'End With
        Else
            'GridNotAvailable.Visibility = System.Windows.Visibility.Visible
            'GridNotAvailable_Copy.Visibility = System.Windows.Visibility.Visible
            'pivotMegaX.Visibility = System.Windows.Visibility.Collapsed
            'pivotMegaY.Visibility = System.Windows.Visibility.Collapsed
        End If
        With PokemonInformationShared.lpBaseValues
            prgSVATK.Value = .ATTACK
            prgSVDEF.Value = .DEFEND
            prgSVHP.Value = .HP
            prgSVSA.Value = .SPATTACK
            prgSVSD.Value = .SPDEFEND
            prgSVSP.Value = .SPEED
            prgSVT.Value = .TOTAL
        End With
        If PokemonInformationShared.IsNoSex Then
            imgFemale.Visibility = System.Windows.Visibility.Collapsed
            rectImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgMale.Text = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1) & " 的外貌"
        Else
            imgFemale.Visibility = System.Windows.Visibility.Visible
            rectImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgMale.Text = "雄性的外貌"
        End If
        'With webExtra
        '    If PokemonInformationShared.lpExtraInfoURI = "" Then
        '        .NavigateToString("This Page Displays The Extra Information Of The Selected Pokemon." & vbCrLf & "Unfortunately, The Reqiured Local Webpage Seems To Be Unavailable." & vbCrLf & "Please Try To Do A Online Search.")
        '    Else
        '        .Navigate(New Uri(PokemonInformationShared.lpExtraInfoURI, UriKind.RelativeOrAbsolute))
        '    End If
        'End With
        pivotBack.Title = PokemonInformationShared.lpTitle
        txtName.Text = PokemonInformationShared.lpTitle
        If IsEvolutionsAvailable Then
            gridNoEvolution.Visibility = System.Windows.Visibility.Collapsed
            lstEvoRot.ItemsSource = EvolutionRoutins
        Else
            gridNoEvolution.Visibility = System.Windows.Visibility.Visible
        End If
        If PokemonInformationShared.lpMultiStatesURI = "" Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            'webMS.Navigate(New Uri(PokemonInformationShared.lpMultiStatesURI, UriKind.RelativeOrAbsolute))
        End If
        If States.Count = 0 Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            lstStates.ItemsSource = States
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub txtDescription_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.GotFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.Black)
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtDescription_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.LostFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.white)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtDescription.TextChanged
        txtDescription.Text = PokemonInformationShared.lpDescription
    End Sub

    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub

    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtENU_KeyDown(sender As Object, e As KeyEventArgs) Handles txtENU.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtENU_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtENU.TextChanged
        txtENU.Text = PokemonInformationShared.lpNameENG
    End Sub
    Private Sub txtENU_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInput
        e.Handled = True
    End Sub

    Private Sub txtENU_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtJPN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJPN.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtJPN.TextChanged
        txtJPN.Text = PokemonInformationShared.lpNameJPN
    End Sub

    Private Sub txtJPN_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInput
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtPRC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPRC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtPRC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtPRC.TextChanged
        txtPRC.Text = PokemonInformationShared.lpNameCHS
    End Sub

    Private Sub txtPRC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtPRC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtPRC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtPRC.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtROC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtROC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtROC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtROC.TextChanged
        txtROC.Text = PokemonInformationShared.lpNameCHT
    End Sub

    Private Sub txtROC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtROC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtKOR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKOR.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtKOR_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtKOR.TextChanged
        txtKOR.Text = PokemonInformationShared.lpNameKOR
    End Sub

    Private Sub txtKOR_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtKOR.TextInput
        e.Handled = True
    End Sub

    Private Sub txtKOR_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtKOR.TextInputStart
        e.Handled = True
    End Sub

    'Private Sub hypSearch_Tap(sender As Object, e As GestureEventArgs) Handles hypSearch.Tap
    '    NavigationService.Navigate(New Uri("/PageSearchReq.xaml", UriKind.RelativeOrAbsolute))
    '    Exit Sub
    '    If 25 = 245 Then
    '        Dim PokemonOnlineSearch As Microsoft.Phone.Tasks.SearchTask
    '        PokemonOnlineSearch = New Microsoft.Phone.Tasks.SearchTask
    '        With PokemonOnlineSearch
    '            .SearchQuery = PokemonInformationShared.lpNameCHT
    '            .Show()
    '        End With
    '    End If
    'End Sub

    Private Sub txtFRA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFRA.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtFRA_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtFRA.TextChanged
        txtFRA.Text = PokemonInformationShared.lpNameFRA
    End Sub

    Private Sub txtFRA_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtFRA.TextInput
        e.Handled = True
    End Sub

    Private Sub txtFRA_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtFRA.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtGER_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGER.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtGER_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtGER.TextChanged
        txtGER.Text = PokemonInformationShared.lpNameGER
    End Sub

    Private Sub txtGER_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtGER.TextInput
        e.Handled = True
    End Sub

    Private Sub txtGER_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtGER.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtAbility1_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1.Tap
        If txtAbility1.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpAbility1 - 1), txtAbility1.Text, MessageBoxButton.OK)
        Exit Sub
        Dim lpRetTxt As String
        lpRetTxt = ""
        Select Case txtAbility1.Text
            Case "惡臭"
                lpRetTxt = AbilityDescriptions.Item(0)
            Case "毛毛雨"
                lpRetTxt = AbilityDescriptions.Item(1)
            Case "加速"
                lpRetTxt = AbilityDescriptions.Item(2)
            Case "甲蟲盔甲"
                lpRetTxt = AbilityDescriptions.Item(3)
            Case "結實"
                lpRetTxt = AbilityDescriptions.Item(4)
            Case "溼氣"
                lpRetTxt = AbilityDescriptions.Item(5)
            Case "柔軟"
                lpRetTxt = AbilityDescriptions.Item(6)
            Case "沙裡隱身"
                lpRetTxt = AbilityDescriptions.Item(7)
            Case "靜電"
                lpRetTxt = AbilityDescriptions.Item(8)
            Case "蓄電"
                lpRetTxt = AbilityDescriptions.Item(9)
            Case "儲水"
                lpRetTxt = AbilityDescriptions.Item(10)
            Case "遲鈍"
                lpRetTxt = AbilityDescriptions.Item(11)
            Case "樂天"
                lpRetTxt = AbilityDescriptions.Item(12)
            Case "複眼"
                lpRetTxt = AbilityDescriptions.Item(13)
            Case "失眠"
                lpRetTxt = AbilityDescriptions.Item(14)
            Case "變色"
                lpRetTxt = AbilityDescriptions.Item(15)
            Case "免疫"
                lpRetTxt = AbilityDescriptions.Item(16)
            Case "延燒"
                lpRetTxt = AbilityDescriptions.Item(17)
            Case "鱗粉"
                lpRetTxt = AbilityDescriptions.Item(18)
            Case "我行我素"
                lpRetTxt = AbilityDescriptions.Item(19)
            Case "吸盤"
                lpRetTxt = AbilityDescriptions.Item(20)
            Case "威嚇"
                lpRetTxt = AbilityDescriptions.Item(21)
            Case "影子遊戲"
                lpRetTxt = AbilityDescriptions.Item(22)
            Case "蛇皮"
                lpRetTxt = AbilityDescriptions.Item(23)
            Case "奇異守護"
                lpRetTxt = AbilityDescriptions.Item(24)
            Case "漂浮"
                lpRetTxt = AbilityDescriptions.Item(25)
            Case "孢子"
                lpRetTxt = AbilityDescriptions.Item(26)
            Case "同步"
                lpRetTxt = AbilityDescriptions.Item(27)
            Case "透明體"
                lpRetTxt = AbilityDescriptions.Item(28)
            Case "自然恢復"
                lpRetTxt = AbilityDescriptions.Item(29)
            Case "避雷針"
                lpRetTxt = AbilityDescriptions.Item(30)
            Case "天恩"
                lpRetTxt = AbilityDescriptions.Item(31)
            Case "輕快"
                lpRetTxt = AbilityDescriptions.Item(32)
            Case "葉綠素"
                lpRetTxt = AbilityDescriptions.Item(33)
            Case "發光"
                lpRetTxt = AbilityDescriptions.Item(34)
            Case "追蹤"
                lpRetTxt = AbilityDescriptions.Item(35)
            Case "大力士"
                lpRetTxt = AbilityDescriptions.Item(36)
            Case "毒刺特性"
                lpRetTxt = AbilityDescriptions.Item(37)
            Case "精神力"
                lpRetTxt = AbilityDescriptions.Item(38)
            Case "岩漿防護"
                lpRetTxt = AbilityDescriptions.Item(39)
            Case "水幕"
                lpRetTxt = AbilityDescriptions.Item(40)
            Case "磁力"
                lpRetTxt = AbilityDescriptions.Item(41)
            Case "隔音"
                lpRetTxt = AbilityDescriptions.Item(42)
            Case "雨盤"
                lpRetTxt = AbilityDescriptions.Item(43)
            Case "沙流"
                lpRetTxt = AbilityDescriptions.Item(44)
            Case "氣壓"
                lpRetTxt = AbilityDescriptions.Item(45)
            Case "肥脂"
                lpRetTxt = AbilityDescriptions.Item(46)
            Case "早起"
                lpRetTxt = AbilityDescriptions.Item(47)
            Case "火焰體"
                lpRetTxt = AbilityDescriptions.Item(48)
            Case "逃走"
                lpRetTxt = AbilityDescriptions.Item(49)
            Case "銳利目光"
                lpRetTxt = AbilityDescriptions.Item(50)
            Case "怪力剪刀"
                lpRetTxt = AbilityDescriptions.Item(51)
            Case "撿拾"
                lpRetTxt = AbilityDescriptions.Item(52)
            Case "懶惰特性"
                lpRetTxt = AbilityDescriptions.Item(53)
            Case "活力"
                lpRetTxt = AbilityDescriptions.Item(54)
            Case "誘惑身軀"
                lpRetTxt = AbilityDescriptions.Item(55)
            Case "陽性"
                lpRetTxt = AbilityDescriptions.Item(56)
            Case "陰性"
                lpRetTxt = AbilityDescriptions.Item(57)
            Case "天氣預報"
                lpRetTxt = AbilityDescriptions.Item(58)
            Case "黏著"
                lpRetTxt = AbilityDescriptions.Item(59)
            Case "脫皮"
                lpRetTxt = AbilityDescriptions.Item(60)
            Case "毅力"
                lpRetTxt = AbilityDescriptions.Item(61)
            Case "怪鱗"
                lpRetTxt = AbilityDescriptions.Item(62)
            Case "黏液"
                lpRetTxt = AbilityDescriptions.Item(63)
            Case "茂盛"
                lpRetTxt = AbilityDescriptions.Item(64)
            Case "猛火"
                lpRetTxt = AbilityDescriptions.Item(65)
            Case "激流"
                lpRetTxt = AbilityDescriptions.Item(66)
            Case "預感"
                lpRetTxt = AbilityDescriptions.Item(67)
            Case "石頭"
                lpRetTxt = AbilityDescriptions.Item(68)
            Case "旱災"
                lpRetTxt = AbilityDescriptions.Item(69)
            Case "獅蟻"
                lpRetTxt = AbilityDescriptions.Item(70)
            Case "元氣"
                lpRetTxt = AbilityDescriptions.Item(71)
            Case "白霧特性"
                lpRetTxt = AbilityDescriptions.Item(72)
            Case "瑜珈神力"
                lpRetTxt = AbilityDescriptions.Item(73)
            Case "貝殼盔甲"
                lpRetTxt = AbilityDescriptions.Item(74)
            Case "氣閘"
                lpRetTxt = AbilityDescriptions.Item(75)
            Case "蹣跚"
                lpRetTxt = AbilityDescriptions.Item(76)
            Case "電氣引擎"
                lpRetTxt = AbilityDescriptions.Item(77)
            Case "鬥爭心"
                lpRetTxt = AbilityDescriptions.Item(78)
            Case "不屈之心"
                lpRetTxt = AbilityDescriptions.Item(79)
            Case "雪裡隱身"
                lpRetTxt = AbilityDescriptions.Item(80)
            Case "貪吃鬼"
                lpRetTxt = AbilityDescriptions.Item(81)
            Case "憤怒穴道"
                lpRetTxt = AbilityDescriptions.Item(82)
            Case "雜技"
                lpRetTxt = AbilityDescriptions.Item(83)
            Case "耐熱"
                lpRetTxt = AbilityDescriptions.Item(84)
            Case "單純"
                lpRetTxt = AbilityDescriptions.Item(85)
            Case "乾燥皮膚"
                lpRetTxt = AbilityDescriptions.Item(86)
            Case "下載"
                lpRetTxt = AbilityDescriptions.Item(87)
            Case "鐵拳"
                lpRetTxt = AbilityDescriptions.Item(88)
            Case "毒療"
                lpRetTxt = AbilityDescriptions.Item(89)
            Case "適應力"
                lpRetTxt = AbilityDescriptions.Item(90)
            Case "連續攻擊"
                lpRetTxt = AbilityDescriptions.Item(91)
            Case "濕潤身體"
                lpRetTxt = AbilityDescriptions.Item(92)
            Case "太陽能量"
                lpRetTxt = AbilityDescriptions.Item(93)
            Case "飛毛腿"
                lpRetTxt = AbilityDescriptions.Item(94)
            Case "一般皮膚"
                lpRetTxt = AbilityDescriptions.Item(95)
            Case "狙擊手"
                lpRetTxt = AbilityDescriptions.Item(96)
            Case "魔法防禦"
                lpRetTxt = AbilityDescriptions.Item(97)
            Case "無防禦"
                lpRetTxt = AbilityDescriptions.Item(98)
            Case "慢出"
                lpRetTxt = AbilityDescriptions.Item(99)
            Case "技術員"
                lpRetTxt = AbilityDescriptions.Item(100)
            Case "葉片防禦"
                lpRetTxt = AbilityDescriptions.Item(101)
            Case "笨手笨腳"
                lpRetTxt = AbilityDescriptions.Item(102)
            Case "革新"
                lpRetTxt = AbilityDescriptions.Item(103)
            Case "強運"
                lpRetTxt = AbilityDescriptions.Item(104)
            Case "引爆"
                lpRetTxt = AbilityDescriptions.Item(105)
            Case "預知危險"
                lpRetTxt = AbilityDescriptions.Item(106)
            Case "預知夢"
                lpRetTxt = AbilityDescriptions.Item(107)
            Case "後知後覺"
                lpRetTxt = AbilityDescriptions.Item(108)
            Case "有色眼鏡"
                lpRetTxt = AbilityDescriptions.Item(109)
            Case "過濾"
                lpRetTxt = AbilityDescriptions.Item(110)
            Case "錯失先機"
                lpRetTxt = AbilityDescriptions.Item(111)
            Case "膽量"
                lpRetTxt = AbilityDescriptions.Item(112)
            Case "引水"
                lpRetTxt = AbilityDescriptions.Item(113)
            Case "冰凍身體"
                lpRetTxt = AbilityDescriptions.Item(114)
            Case "堅石"
                lpRetTxt = AbilityDescriptions.Item(115)
            Case "降雪"
                lpRetTxt = AbilityDescriptions.Item(116)
            Case "采蜜"
                lpRetTxt = AbilityDescriptions.Item(117)
            Case "看穿"
                lpRetTxt = AbilityDescriptions.Item(118)
            Case "捨身特性"
                lpRetTxt = AbilityDescriptions.Item(119)
            Case "多重屬性"
                lpRetTxt = AbilityDescriptions.Item(120)
            Case "花之禮"
                lpRetTxt = AbilityDescriptions.Item(121)
            Case "噩夢"
                lpRetTxt = AbilityDescriptions.Item(122)
            Case "偷盜惡習"
                lpRetTxt = AbilityDescriptions.Item(123)
            Case "全力攻擊"
                lpRetTxt = AbilityDescriptions.Item(124)
            Case "天邪鬼"
                lpRetTxt = AbilityDescriptions.Item(125)
            Case "緊張感"
                lpRetTxt = AbilityDescriptions.Item(126)
            Case "不服輸"
                lpRetTxt = AbilityDescriptions.Item(127)
            Case "弱氣"
                lpRetTxt = AbilityDescriptions.Item(128)
            Case "詛咒身體"
                lpRetTxt = AbilityDescriptions.Item(129)
            Case "治癒之心"
                lpRetTxt = AbilityDescriptions.Item(130)
            Case "隊友守護"
                lpRetTxt = AbilityDescriptions.Item(131)
            Case "碎甲"
                lpRetTxt = AbilityDescriptions.Item(132)
            Case "重合金"
                lpRetTxt = AbilityDescriptions.Item(133)
            Case "輕合金"
                lpRetTxt = AbilityDescriptions.Item(134)
            Case "多重鱗片"
                lpRetTxt = AbilityDescriptions.Item(135)
            Case "毒暴走"
                lpRetTxt = AbilityDescriptions.Item(136)
            Case "熱暴走"
                lpRetTxt = AbilityDescriptions.Item(137)
            Case "收穫"
                lpRetTxt = AbilityDescriptions.Item(138)
            Case "超感知"
                lpRetTxt = AbilityDescriptions.Item(139)
            Case "心智不定"
                lpRetTxt = AbilityDescriptions.Item(140)
            Case "防塵"
                lpRetTxt = AbilityDescriptions.Item(141)
            Case "毒手"
                lpRetTxt = AbilityDescriptions.Item(142)
            Case "再生力"
                lpRetTxt = AbilityDescriptions.Item(143)
            Case "鴿胸"
                lpRetTxt = AbilityDescriptions.Item(144)
            Case "挖沙"
                lpRetTxt = AbilityDescriptions.Item(145)
            Case "奇蹟皮膚"
                lpRetTxt = AbilityDescriptions.Item(146)
            Case "分析"
                lpRetTxt = AbilityDescriptions.Item(147)
            Case "幻覺"
                lpRetTxt = AbilityDescriptions.Item(148)
            Case "替代品"
                lpRetTxt = AbilityDescriptions.Item(149)
            Case "穿透"
                lpRetTxt = AbilityDescriptions.Item(150)
            Case "木乃伊"
                lpRetTxt = AbilityDescriptions.Item(151)
            Case "自信過剩"
                lpRetTxt = AbilityDescriptions.Item(152)
            Case "正義之心"
                lpRetTxt = AbilityDescriptions.Item(153)
            Case "顫抖"
                lpRetTxt = AbilityDescriptions.Item(154)
            Case "魔法反射"
                lpRetTxt = AbilityDescriptions.Item(155)
            Case "食草"
                lpRetTxt = AbilityDescriptions.Item(156)
            Case "惡作劇之心"
                lpRetTxt = AbilityDescriptions.Item(157)
            Case "沙之力量"
                lpRetTxt = AbilityDescriptions.Item(158)
            Case "鐵刺荊棘"
                lpRetTxt = AbilityDescriptions.Item(159)
            Case "達摩模式"
                lpRetTxt = AbilityDescriptions.Item(160)
            Case "勝利之星"
                lpRetTxt = AbilityDescriptions.Item(161)
            Case "渦輪高溫"
                lpRetTxt = AbilityDescriptions.Item(162)
            Case "兆級電壓"
                lpRetTxt = AbilityDescriptions.Item(163)
            Case "芳香之幕"
                lpRetTxt = AbilityDescriptions.Item(164)
            Case "花幕"
                lpRetTxt = AbilityDescriptions.Item(165)
            Case "頰囊"
                lpRetTxt = AbilityDescriptions.Item(166)
            Case "變換自在"
                lpRetTxt = AbilityDescriptions.Item(167)
            Case "毛皮外衣"
                lpRetTxt = AbilityDescriptions.Item(168)
            Case "術士"
                lpRetTxt = AbilityDescriptions.Item(169)
            Case "防彈"
                lpRetTxt = AbilityDescriptions.Item(170)
            Case "好勝"
                lpRetTxt = AbilityDescriptions.Item(171)
            Case "下顎結實"
                lpRetTxt = AbilityDescriptions.Item(172)
            Case "冰凍皮膚"
                lpRetTxt = AbilityDescriptions.Item(173)
            Case "甜幕"
                lpRetTxt = AbilityDescriptions.Item(174)
            Case "戰鬥切換"
                lpRetTxt = AbilityDescriptions.Item(175)
            Case "疾風之翼"
                lpRetTxt = AbilityDescriptions.Item(176)
            Case "超級噴射"
                lpRetTxt = AbilityDescriptions.Item(177)
            Case "草之毛皮"
                lpRetTxt = AbilityDescriptions.Item(178)
            Case "共生"
                lpRetTxt = AbilityDescriptions.Item(179)
            Case "堅硬爪子"
                lpRetTxt = AbilityDescriptions.Item(180)
            Case "妖精皮膚"
                lpRetTxt = AbilityDescriptions.Item(181)
            Case "滑溜溜"
                lpRetTxt = AbilityDescriptions.Item(182)
            Case "天空皮膚"
                lpRetTxt = AbilityDescriptions.Item(183)
            Case "親子愛"
                lpRetTxt = AbilityDescriptions.Item(184)
            Case "黑暗氣氛"
                lpRetTxt = AbilityDescriptions.Item(185)
            Case "妖精氣氛"
                lpRetTxt = AbilityDescriptions.Item(186)
            Case "氣氛破壞"
                lpRetTxt = AbilityDescriptions.Item(187)
            Case "起始之海"
                lpRetTxt = AbilityDescriptions.Item(188)
            Case "終結大地"
                lpRetTxt = AbilityDescriptions.Item(189)
            Case "變化氣流"
                lpRetTxt = AbilityDescriptions.Item(190)
            Case Else
                Exit Sub
        End Select
        MessageBox.Show(lpRetTxt, txtAbility1.Text, MessageBoxButton.OK)
    End Sub

    'Private Sub txtAbility1_MORAS_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1_MORAS.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaORASInfo.lpAbility1 - 1), txtAbility1_MORAS.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility1_MORAS.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility1_MORAS.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility1_MX_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1_MX.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaXInfo.lpAbility1 - 1), txtAbility1_MX.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility1_MX.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility1_MX.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility1_MY_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1_MY.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaYInfo.lpAbility1 - 1), txtAbility1_MY.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility1_MY.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility1_MY.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility1_OS_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1_OS.Tap
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility1_OS.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility1_OS.Text, MessageBoxButton.OK)
    'End Sub
    'Private Sub txtAbility2_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2.Tap
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility2.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility2.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility2_MORAS_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2_MORAS.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaORASInfo.lpAbility2 - 1), txtAbility2_MORAS.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility2_MORAS.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility2_MORAS.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility2_MX_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2_MX.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaXInfo.lpAbility2 - 1), txtAbility2_MX.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility2_MX.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility2_MX.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility2_MY_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2_MY.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaYInfo.lpAbility2 - 1), txtAbility2_MY.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility2_MY.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility2_MY.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility2_OS_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2_OS.Tap
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility2_OS.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility2_OS.Text, MessageBoxButton.OK)
    'End Sub
    Private Sub txtAbility3_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3.Tap
        If txtAbility3.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpAbilityHidden - 1), txtAbility3.Text, MessageBoxButton.OK)
        Exit Sub
        Dim lpRetTxt As String
        lpRetTxt = ""
        Select Case txtAbility3.Text
            Case "惡臭"
                lpRetTxt = AbilityDescriptions.Item(0)
            Case "毛毛雨"
                lpRetTxt = AbilityDescriptions.Item(1)
            Case "加速"
                lpRetTxt = AbilityDescriptions.Item(2)
            Case "甲蟲盔甲"
                lpRetTxt = AbilityDescriptions.Item(3)
            Case "結實"
                lpRetTxt = AbilityDescriptions.Item(4)
            Case "溼氣"
                lpRetTxt = AbilityDescriptions.Item(5)
            Case "柔軟"
                lpRetTxt = AbilityDescriptions.Item(6)
            Case "沙裡隱身"
                lpRetTxt = AbilityDescriptions.Item(7)
            Case "靜電"
                lpRetTxt = AbilityDescriptions.Item(8)
            Case "蓄電"
                lpRetTxt = AbilityDescriptions.Item(9)
            Case "儲水"
                lpRetTxt = AbilityDescriptions.Item(10)
            Case "遲鈍"
                lpRetTxt = AbilityDescriptions.Item(11)
            Case "樂天"
                lpRetTxt = AbilityDescriptions.Item(12)
            Case "複眼"
                lpRetTxt = AbilityDescriptions.Item(13)
            Case "失眠"
                lpRetTxt = AbilityDescriptions.Item(14)
            Case "變色"
                lpRetTxt = AbilityDescriptions.Item(15)
            Case "免疫"
                lpRetTxt = AbilityDescriptions.Item(16)
            Case "延燒"
                lpRetTxt = AbilityDescriptions.Item(17)
            Case "鱗粉"
                lpRetTxt = AbilityDescriptions.Item(18)
            Case "我行我素"
                lpRetTxt = AbilityDescriptions.Item(19)
            Case "吸盤"
                lpRetTxt = AbilityDescriptions.Item(20)
            Case "威嚇"
                lpRetTxt = AbilityDescriptions.Item(21)
            Case "影子遊戲"
                lpRetTxt = AbilityDescriptions.Item(22)
            Case "蛇皮"
                lpRetTxt = AbilityDescriptions.Item(23)
            Case "奇異守護"
                lpRetTxt = AbilityDescriptions.Item(24)
            Case "漂浮"
                lpRetTxt = AbilityDescriptions.Item(25)
            Case "孢子"
                lpRetTxt = AbilityDescriptions.Item(26)
            Case "同步"
                lpRetTxt = AbilityDescriptions.Item(27)
            Case "透明體"
                lpRetTxt = AbilityDescriptions.Item(28)
            Case "自然恢復"
                lpRetTxt = AbilityDescriptions.Item(29)
            Case "避雷針"
                lpRetTxt = AbilityDescriptions.Item(30)
            Case "天恩"
                lpRetTxt = AbilityDescriptions.Item(31)
            Case "輕快"
                lpRetTxt = AbilityDescriptions.Item(32)
            Case "葉綠素"
                lpRetTxt = AbilityDescriptions.Item(33)
            Case "發光"
                lpRetTxt = AbilityDescriptions.Item(34)
            Case "追蹤"
                lpRetTxt = AbilityDescriptions.Item(35)
            Case "大力士"
                lpRetTxt = AbilityDescriptions.Item(36)
            Case "毒刺特性"
                lpRetTxt = AbilityDescriptions.Item(37)
            Case "精神力"
                lpRetTxt = AbilityDescriptions.Item(38)
            Case "岩漿防護"
                lpRetTxt = AbilityDescriptions.Item(39)
            Case "水幕"
                lpRetTxt = AbilityDescriptions.Item(40)
            Case "磁力"
                lpRetTxt = AbilityDescriptions.Item(41)
            Case "隔音"
                lpRetTxt = AbilityDescriptions.Item(42)
            Case "雨盤"
                lpRetTxt = AbilityDescriptions.Item(43)
            Case "沙流"
                lpRetTxt = AbilityDescriptions.Item(44)
            Case "氣壓"
                lpRetTxt = AbilityDescriptions.Item(45)
            Case "肥脂"
                lpRetTxt = AbilityDescriptions.Item(46)
            Case "早起"
                lpRetTxt = AbilityDescriptions.Item(47)
            Case "火焰體"
                lpRetTxt = AbilityDescriptions.Item(48)
            Case "逃走"
                lpRetTxt = AbilityDescriptions.Item(49)
            Case "銳利目光"
                lpRetTxt = AbilityDescriptions.Item(50)
            Case "怪力剪刀"
                lpRetTxt = AbilityDescriptions.Item(51)
            Case "撿拾"
                lpRetTxt = AbilityDescriptions.Item(52)
            Case "懶惰特性"
                lpRetTxt = AbilityDescriptions.Item(53)
            Case "活力"
                lpRetTxt = AbilityDescriptions.Item(54)
            Case "誘惑身軀"
                lpRetTxt = AbilityDescriptions.Item(55)
            Case "陽性"
                lpRetTxt = AbilityDescriptions.Item(56)
            Case "陰性"
                lpRetTxt = AbilityDescriptions.Item(57)
            Case "天氣預報"
                lpRetTxt = AbilityDescriptions.Item(58)
            Case "黏著"
                lpRetTxt = AbilityDescriptions.Item(59)
            Case "脫皮"
                lpRetTxt = AbilityDescriptions.Item(60)
            Case "毅力"
                lpRetTxt = AbilityDescriptions.Item(61)
            Case "怪鱗"
                lpRetTxt = AbilityDescriptions.Item(62)
            Case "黏液"
                lpRetTxt = AbilityDescriptions.Item(63)
            Case "茂盛"
                lpRetTxt = AbilityDescriptions.Item(64)
            Case "猛火"
                lpRetTxt = AbilityDescriptions.Item(65)
            Case "激流"
                lpRetTxt = AbilityDescriptions.Item(66)
            Case "預感"
                lpRetTxt = AbilityDescriptions.Item(67)
            Case "石頭"
                lpRetTxt = AbilityDescriptions.Item(68)
            Case "旱災"
                lpRetTxt = AbilityDescriptions.Item(69)
            Case "獅蟻"
                lpRetTxt = AbilityDescriptions.Item(70)
            Case "元氣"
                lpRetTxt = AbilityDescriptions.Item(71)
            Case "白霧特性"
                lpRetTxt = AbilityDescriptions.Item(72)
            Case "瑜珈神力"
                lpRetTxt = AbilityDescriptions.Item(73)
            Case "貝殼盔甲"
                lpRetTxt = AbilityDescriptions.Item(74)
            Case "氣閘"
                lpRetTxt = AbilityDescriptions.Item(75)
            Case "蹣跚"
                lpRetTxt = AbilityDescriptions.Item(76)
            Case "電氣引擎"
                lpRetTxt = AbilityDescriptions.Item(77)
            Case "鬥爭心"
                lpRetTxt = AbilityDescriptions.Item(78)
            Case "不屈之心"
                lpRetTxt = AbilityDescriptions.Item(79)
            Case "雪裡隱身"
                lpRetTxt = AbilityDescriptions.Item(80)
            Case "貪吃鬼"
                lpRetTxt = AbilityDescriptions.Item(81)
            Case "憤怒穴道"
                lpRetTxt = AbilityDescriptions.Item(82)
            Case "雜技"
                lpRetTxt = AbilityDescriptions.Item(83)
            Case "耐熱"
                lpRetTxt = AbilityDescriptions.Item(84)
            Case "單純"
                lpRetTxt = AbilityDescriptions.Item(85)
            Case "乾燥皮膚"
                lpRetTxt = AbilityDescriptions.Item(86)
            Case "下載"
                lpRetTxt = AbilityDescriptions.Item(87)
            Case "鐵拳"
                lpRetTxt = AbilityDescriptions.Item(88)
            Case "毒療"
                lpRetTxt = AbilityDescriptions.Item(89)
            Case "適應力"
                lpRetTxt = AbilityDescriptions.Item(90)
            Case "連續攻擊"
                lpRetTxt = AbilityDescriptions.Item(91)
            Case "濕潤身體"
                lpRetTxt = AbilityDescriptions.Item(92)
            Case "太陽能量"
                lpRetTxt = AbilityDescriptions.Item(93)
            Case "飛毛腿"
                lpRetTxt = AbilityDescriptions.Item(94)
            Case "一般皮膚"
                lpRetTxt = AbilityDescriptions.Item(95)
            Case "狙擊手"
                lpRetTxt = AbilityDescriptions.Item(96)
            Case "魔法防禦"
                lpRetTxt = AbilityDescriptions.Item(97)
            Case "無防禦"
                lpRetTxt = AbilityDescriptions.Item(98)
            Case "慢出"
                lpRetTxt = AbilityDescriptions.Item(99)
            Case "技術員"
                lpRetTxt = AbilityDescriptions.Item(100)
            Case "葉片防禦"
                lpRetTxt = AbilityDescriptions.Item(101)
            Case "笨手笨腳"
                lpRetTxt = AbilityDescriptions.Item(102)
            Case "革新"
                lpRetTxt = AbilityDescriptions.Item(103)
            Case "強運"
                lpRetTxt = AbilityDescriptions.Item(104)
            Case "引爆"
                lpRetTxt = AbilityDescriptions.Item(105)
            Case "預知危險"
                lpRetTxt = AbilityDescriptions.Item(106)
            Case "預知夢"
                lpRetTxt = AbilityDescriptions.Item(107)
            Case "後知後覺"
                lpRetTxt = AbilityDescriptions.Item(108)
            Case "有色眼鏡"
                lpRetTxt = AbilityDescriptions.Item(109)
            Case "過濾"
                lpRetTxt = AbilityDescriptions.Item(110)
            Case "錯失先機"
                lpRetTxt = AbilityDescriptions.Item(111)
            Case "膽量"
                lpRetTxt = AbilityDescriptions.Item(112)
            Case "引水"
                lpRetTxt = AbilityDescriptions.Item(113)
            Case "冰凍身體"
                lpRetTxt = AbilityDescriptions.Item(114)
            Case "堅石"
                lpRetTxt = AbilityDescriptions.Item(115)
            Case "降雪"
                lpRetTxt = AbilityDescriptions.Item(116)
            Case "采蜜"
                lpRetTxt = AbilityDescriptions.Item(117)
            Case "看穿"
                lpRetTxt = AbilityDescriptions.Item(118)
            Case "捨身特性"
                lpRetTxt = AbilityDescriptions.Item(119)
            Case "多重屬性"
                lpRetTxt = AbilityDescriptions.Item(120)
            Case "花之禮"
                lpRetTxt = AbilityDescriptions.Item(121)
            Case "噩夢"
                lpRetTxt = AbilityDescriptions.Item(122)
            Case "偷盜惡習"
                lpRetTxt = AbilityDescriptions.Item(123)
            Case "全力攻擊"
                lpRetTxt = AbilityDescriptions.Item(124)
            Case "天邪鬼"
                lpRetTxt = AbilityDescriptions.Item(125)
            Case "緊張感"
                lpRetTxt = AbilityDescriptions.Item(126)
            Case "不服輸"
                lpRetTxt = AbilityDescriptions.Item(127)
            Case "弱氣"
                lpRetTxt = AbilityDescriptions.Item(128)
            Case "詛咒身體"
                lpRetTxt = AbilityDescriptions.Item(129)
            Case "治癒之心"
                lpRetTxt = AbilityDescriptions.Item(130)
            Case "隊友守護"
                lpRetTxt = AbilityDescriptions.Item(131)
            Case "碎甲"
                lpRetTxt = AbilityDescriptions.Item(132)
            Case "重合金"
                lpRetTxt = AbilityDescriptions.Item(133)
            Case "輕合金"
                lpRetTxt = AbilityDescriptions.Item(134)
            Case "多重鱗片"
                lpRetTxt = AbilityDescriptions.Item(135)
            Case "毒暴走"
                lpRetTxt = AbilityDescriptions.Item(136)
            Case "熱暴走"
                lpRetTxt = AbilityDescriptions.Item(137)
            Case "收穫"
                lpRetTxt = AbilityDescriptions.Item(138)
            Case "超感知"
                lpRetTxt = AbilityDescriptions.Item(139)
            Case "心智不定"
                lpRetTxt = AbilityDescriptions.Item(140)
            Case "防塵"
                lpRetTxt = AbilityDescriptions.Item(141)
            Case "毒手"
                lpRetTxt = AbilityDescriptions.Item(142)
            Case "再生力"
                lpRetTxt = AbilityDescriptions.Item(143)
            Case "鴿胸"
                lpRetTxt = AbilityDescriptions.Item(144)
            Case "挖沙"
                lpRetTxt = AbilityDescriptions.Item(145)
            Case "奇蹟皮膚"
                lpRetTxt = AbilityDescriptions.Item(146)
            Case "分析"
                lpRetTxt = AbilityDescriptions.Item(147)
            Case "幻覺"
                lpRetTxt = AbilityDescriptions.Item(148)
            Case "替代品"
                lpRetTxt = AbilityDescriptions.Item(149)
            Case "穿透"
                lpRetTxt = AbilityDescriptions.Item(150)
            Case "木乃伊"
                lpRetTxt = AbilityDescriptions.Item(151)
            Case "自信過剩"
                lpRetTxt = AbilityDescriptions.Item(152)
            Case "正義之心"
                lpRetTxt = AbilityDescriptions.Item(153)
            Case "顫抖"
                lpRetTxt = AbilityDescriptions.Item(154)
            Case "魔法反射"
                lpRetTxt = AbilityDescriptions.Item(155)
            Case "食草"
                lpRetTxt = AbilityDescriptions.Item(156)
            Case "惡作劇之心"
                lpRetTxt = AbilityDescriptions.Item(157)
            Case "沙之力量"
                lpRetTxt = AbilityDescriptions.Item(158)
            Case "鐵刺荊棘"
                lpRetTxt = AbilityDescriptions.Item(159)
            Case "達摩模式"
                lpRetTxt = AbilityDescriptions.Item(160)
            Case "勝利之星"
                lpRetTxt = AbilityDescriptions.Item(161)
            Case "渦輪高溫"
                lpRetTxt = AbilityDescriptions.Item(162)
            Case "兆級電壓"
                lpRetTxt = AbilityDescriptions.Item(163)
            Case "芳香之幕"
                lpRetTxt = AbilityDescriptions.Item(164)
            Case "花幕"
                lpRetTxt = AbilityDescriptions.Item(165)
            Case "頰囊"
                lpRetTxt = AbilityDescriptions.Item(166)
            Case "變換自在"
                lpRetTxt = AbilityDescriptions.Item(167)
            Case "毛皮外衣"
                lpRetTxt = AbilityDescriptions.Item(168)
            Case "術士"
                lpRetTxt = AbilityDescriptions.Item(169)
            Case "防彈"
                lpRetTxt = AbilityDescriptions.Item(170)
            Case "好勝"
                lpRetTxt = AbilityDescriptions.Item(171)
            Case "下顎結實"
                lpRetTxt = AbilityDescriptions.Item(172)
            Case "冰凍皮膚"
                lpRetTxt = AbilityDescriptions.Item(173)
            Case "甜幕"
                lpRetTxt = AbilityDescriptions.Item(174)
            Case "戰鬥切換"
                lpRetTxt = AbilityDescriptions.Item(175)
            Case "疾風之翼"
                lpRetTxt = AbilityDescriptions.Item(176)
            Case "超級噴射"
                lpRetTxt = AbilityDescriptions.Item(177)
            Case "草之毛皮"
                lpRetTxt = AbilityDescriptions.Item(178)
            Case "共生"
                lpRetTxt = AbilityDescriptions.Item(179)
            Case "堅硬爪子"
                lpRetTxt = AbilityDescriptions.Item(180)
            Case "妖精皮膚"
                lpRetTxt = AbilityDescriptions.Item(181)
            Case "滑溜溜"
                lpRetTxt = AbilityDescriptions.Item(182)
            Case "天空皮膚"
                lpRetTxt = AbilityDescriptions.Item(183)
            Case "親子愛"
                lpRetTxt = AbilityDescriptions.Item(184)
            Case "黑暗氣氛"
                lpRetTxt = AbilityDescriptions.Item(185)
            Case "妖精氣氛"
                lpRetTxt = AbilityDescriptions.Item(186)
            Case "氣氛破壞"
                lpRetTxt = AbilityDescriptions.Item(187)
            Case "起始之海"
                lpRetTxt = AbilityDescriptions.Item(188)
            Case "終結大地"
                lpRetTxt = AbilityDescriptions.Item(189)
            Case "變化氣流"
                lpRetTxt = AbilityDescriptions.Item(190)
            Case Else
                Exit Sub
        End Select
        MessageBox.Show(lpRetTxt, txtAbility3.Text, MessageBoxButton.OK)
    End Sub

    'Private Sub txtAbility3_MORAS_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3_MORAS.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaORASInfo.lpAbilityHidden - 1), txtAbility3_MORAS.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility3_MORAS.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility3_MORAS.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility3_MX_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3_MX.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaXInfo.lpAbilityHidden - 1), txtAbility3_MX.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility3_MX.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility3_MX.Text, MessageBoxButton.OK)
    'End Sub

    'Private Sub txtAbility3_MY_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3_MY.Tap
    '    MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpMegaYInfo.lpAbilityHidden - 1), txtAbility3_MY.Text, MessageBoxButton.OK)
    '    Exit Sub
    '    Dim lpRetTxt As String
    '    lpRetTxt = ""
    '    Select Case txtAbility3_MY.Text
    '        Case "惡臭"
    '            lpRetTxt = AbilityDescriptions.Item(0)
    '        Case "毛毛雨"
    '            lpRetTxt = AbilityDescriptions.Item(1)
    '        Case "加速"
    '            lpRetTxt = AbilityDescriptions.Item(2)
    '        Case "甲蟲盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(3)
    '        Case "結實"
    '            lpRetTxt = AbilityDescriptions.Item(4)
    '        Case "溼氣"
    '            lpRetTxt = AbilityDescriptions.Item(5)
    '        Case "柔軟"
    '            lpRetTxt = AbilityDescriptions.Item(6)
    '        Case "沙裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(7)
    '        Case "靜電"
    '            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility3_MY.Text, MessageBoxButton.OK)
    'End Sub

    ''Private Sub txtAbility3_OS_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3_OS.Tap
    ''    Dim lpRetTxt As String
    ''    lpRetTxt = ""
    ''    Select Case txtAbility3_OS.Text
    ''        Case "惡臭"
    ''            lpRetTxt = AbilityDescriptions.Item(0)
    ''        Case "毛毛雨"
    ''            lpRetTxt = AbilityDescriptions.Item(1)
    ''        Case "加速"
    ''            lpRetTxt = AbilityDescriptions.Item(2)
    ''        Case "甲蟲盔甲"
    ''            lpRetTxt = AbilityDescriptions.Item(3)
    ''        Case "結實"
    ''            lpRetTxt = AbilityDescriptions.Item(4)
    ''        Case "溼氣"
    ''            lpRetTxt = AbilityDescriptions.Item(5)
    ''        Case "柔軟"
    ''            lpRetTxt = AbilityDescriptions.Item(6)
    ''        Case "沙裡隱身"
    ''            lpRetTxt = AbilityDescriptions.Item(7)
    ''        Case "靜電"
    ''            lpRetTxt = AbilityDescriptions.Item(8)
    '        Case "蓄電"
    '            lpRetTxt = AbilityDescriptions.Item(9)
    '        Case "儲水"
    '            lpRetTxt = AbilityDescriptions.Item(10)
    '        Case "遲鈍"
    '            lpRetTxt = AbilityDescriptions.Item(11)
    '        Case "樂天"
    '            lpRetTxt = AbilityDescriptions.Item(12)
    '        Case "複眼"
    '            lpRetTxt = AbilityDescriptions.Item(13)
    '        Case "失眠"
    '            lpRetTxt = AbilityDescriptions.Item(14)
    '        Case "變色"
    '            lpRetTxt = AbilityDescriptions.Item(15)
    '        Case "免疫"
    '            lpRetTxt = AbilityDescriptions.Item(16)
    '        Case "延燒"
    '            lpRetTxt = AbilityDescriptions.Item(17)
    '        Case "鱗粉"
    '            lpRetTxt = AbilityDescriptions.Item(18)
    '        Case "我行我素"
    '            lpRetTxt = AbilityDescriptions.Item(19)
    '        Case "吸盤"
    '            lpRetTxt = AbilityDescriptions.Item(20)
    '        Case "威嚇"
    '            lpRetTxt = AbilityDescriptions.Item(21)
    '        Case "影子遊戲"
    '            lpRetTxt = AbilityDescriptions.Item(22)
    '        Case "蛇皮"
    '            lpRetTxt = AbilityDescriptions.Item(23)
    '        Case "奇異守護"
    '            lpRetTxt = AbilityDescriptions.Item(24)
    '        Case "漂浮"
    '            lpRetTxt = AbilityDescriptions.Item(25)
    '        Case "孢子"
    '            lpRetTxt = AbilityDescriptions.Item(26)
    '        Case "同步"
    '            lpRetTxt = AbilityDescriptions.Item(27)
    '        Case "透明體"
    '            lpRetTxt = AbilityDescriptions.Item(28)
    '        Case "自然恢復"
    '            lpRetTxt = AbilityDescriptions.Item(29)
    '        Case "避雷針"
    '            lpRetTxt = AbilityDescriptions.Item(30)
    '        Case "天恩"
    '            lpRetTxt = AbilityDescriptions.Item(31)
    '        Case "輕快"
    '            lpRetTxt = AbilityDescriptions.Item(32)
    '        Case "葉綠素"
    '            lpRetTxt = AbilityDescriptions.Item(33)
    '        Case "發光"
    '            lpRetTxt = AbilityDescriptions.Item(34)
    '        Case "追蹤"
    '            lpRetTxt = AbilityDescriptions.Item(35)
    '        Case "大力士"
    '            lpRetTxt = AbilityDescriptions.Item(36)
    '        Case "毒刺特性"
    '            lpRetTxt = AbilityDescriptions.Item(37)
    '        Case "精神力"
    '            lpRetTxt = AbilityDescriptions.Item(38)
    '        Case "岩漿防護"
    '            lpRetTxt = AbilityDescriptions.Item(39)
    '        Case "水幕"
    '            lpRetTxt = AbilityDescriptions.Item(40)
    '        Case "磁力"
    '            lpRetTxt = AbilityDescriptions.Item(41)
    '        Case "隔音"
    '            lpRetTxt = AbilityDescriptions.Item(42)
    '        Case "雨盤"
    '            lpRetTxt = AbilityDescriptions.Item(43)
    '        Case "沙流"
    '            lpRetTxt = AbilityDescriptions.Item(44)
    '        Case "氣壓"
    '            lpRetTxt = AbilityDescriptions.Item(45)
    '        Case "肥脂"
    '            lpRetTxt = AbilityDescriptions.Item(46)
    '        Case "早起"
    '            lpRetTxt = AbilityDescriptions.Item(47)
    '        Case "火焰體"
    '            lpRetTxt = AbilityDescriptions.Item(48)
    '        Case "逃走"
    '            lpRetTxt = AbilityDescriptions.Item(49)
    '        Case "銳利目光"
    '            lpRetTxt = AbilityDescriptions.Item(50)
    '        Case "怪力剪刀"
    '            lpRetTxt = AbilityDescriptions.Item(51)
    '        Case "撿拾"
    '            lpRetTxt = AbilityDescriptions.Item(52)
    '        Case "懶惰特性"
    '            lpRetTxt = AbilityDescriptions.Item(53)
    '        Case "活力"
    '            lpRetTxt = AbilityDescriptions.Item(54)
    '        Case "誘惑身軀"
    '            lpRetTxt = AbilityDescriptions.Item(55)
    '        Case "陽性"
    '            lpRetTxt = AbilityDescriptions.Item(56)
    '        Case "陰性"
    '            lpRetTxt = AbilityDescriptions.Item(57)
    '        Case "天氣預報"
    '            lpRetTxt = AbilityDescriptions.Item(58)
    '        Case "黏著"
    '            lpRetTxt = AbilityDescriptions.Item(59)
    '        Case "脫皮"
    '            lpRetTxt = AbilityDescriptions.Item(60)
    '        Case "毅力"
    '            lpRetTxt = AbilityDescriptions.Item(61)
    '        Case "怪鱗"
    '            lpRetTxt = AbilityDescriptions.Item(62)
    '        Case "黏液"
    '            lpRetTxt = AbilityDescriptions.Item(63)
    '        Case "茂盛"
    '            lpRetTxt = AbilityDescriptions.Item(64)
    '        Case "猛火"
    '            lpRetTxt = AbilityDescriptions.Item(65)
    '        Case "激流"
    '            lpRetTxt = AbilityDescriptions.Item(66)
    '        Case "預感"
    '            lpRetTxt = AbilityDescriptions.Item(67)
    '        Case "石頭"
    '            lpRetTxt = AbilityDescriptions.Item(68)
    '        Case "旱災"
    '            lpRetTxt = AbilityDescriptions.Item(69)
    '        Case "獅蟻"
    '            lpRetTxt = AbilityDescriptions.Item(70)
    '        Case "元氣"
    '            lpRetTxt = AbilityDescriptions.Item(71)
    '        Case "白霧特性"
    '            lpRetTxt = AbilityDescriptions.Item(72)
    '        Case "瑜珈神力"
    '            lpRetTxt = AbilityDescriptions.Item(73)
    '        Case "貝殼盔甲"
    '            lpRetTxt = AbilityDescriptions.Item(74)
    '        Case "氣閘"
    '            lpRetTxt = AbilityDescriptions.Item(75)
    '        Case "蹣跚"
    '            lpRetTxt = AbilityDescriptions.Item(76)
    '        Case "電氣引擎"
    '            lpRetTxt = AbilityDescriptions.Item(77)
    '        Case "鬥爭心"
    '            lpRetTxt = AbilityDescriptions.Item(78)
    '        Case "不屈之心"
    '            lpRetTxt = AbilityDescriptions.Item(79)
    '        Case "雪裡隱身"
    '            lpRetTxt = AbilityDescriptions.Item(80)
    '        Case "貪吃鬼"
    '            lpRetTxt = AbilityDescriptions.Item(81)
    '        Case "憤怒穴道"
    '            lpRetTxt = AbilityDescriptions.Item(82)
    '        Case "雜技"
    '            lpRetTxt = AbilityDescriptions.Item(83)
    '        Case "耐熱"
    '            lpRetTxt = AbilityDescriptions.Item(84)
    '        Case "單純"
    '            lpRetTxt = AbilityDescriptions.Item(85)
    '        Case "乾燥皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(86)
    '        Case "下載"
    '            lpRetTxt = AbilityDescriptions.Item(87)
    '        Case "鐵拳"
    '            lpRetTxt = AbilityDescriptions.Item(88)
    '        Case "毒療"
    '            lpRetTxt = AbilityDescriptions.Item(89)
    '        Case "適應力"
    '            lpRetTxt = AbilityDescriptions.Item(90)
    '        Case "連續攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(91)
    '        Case "濕潤身體"
    '            lpRetTxt = AbilityDescriptions.Item(92)
    '        Case "太陽能量"
    '            lpRetTxt = AbilityDescriptions.Item(93)
    '        Case "飛毛腿"
    '            lpRetTxt = AbilityDescriptions.Item(94)
    '        Case "一般皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(95)
    '        Case "狙擊手"
    '            lpRetTxt = AbilityDescriptions.Item(96)
    '        Case "魔法防禦"
    '            lpRetTxt = AbilityDescriptions.Item(97)
    '        Case "無防禦"
    '            lpRetTxt = AbilityDescriptions.Item(98)
    '        Case "慢出"
    '            lpRetTxt = AbilityDescriptions.Item(99)
    '        Case "技術員"
    '            lpRetTxt = AbilityDescriptions.Item(100)
    '        Case "葉片防禦"
    '            lpRetTxt = AbilityDescriptions.Item(101)
    '        Case "笨手笨腳"
    '            lpRetTxt = AbilityDescriptions.Item(102)
    '        Case "革新"
    '            lpRetTxt = AbilityDescriptions.Item(103)
    '        Case "強運"
    '            lpRetTxt = AbilityDescriptions.Item(104)
    '        Case "引爆"
    '            lpRetTxt = AbilityDescriptions.Item(105)
    '        Case "預知危險"
    '            lpRetTxt = AbilityDescriptions.Item(106)
    '        Case "預知夢"
    '            lpRetTxt = AbilityDescriptions.Item(107)
    '        Case "後知後覺"
    '            lpRetTxt = AbilityDescriptions.Item(108)
    '        Case "有色眼鏡"
    '            lpRetTxt = AbilityDescriptions.Item(109)
    '        Case "過濾"
    '            lpRetTxt = AbilityDescriptions.Item(110)
    '        Case "錯失先機"
    '            lpRetTxt = AbilityDescriptions.Item(111)
    '        Case "膽量"
    '            lpRetTxt = AbilityDescriptions.Item(112)
    '        Case "引水"
    '            lpRetTxt = AbilityDescriptions.Item(113)
    '        Case "冰凍身體"
    '            lpRetTxt = AbilityDescriptions.Item(114)
    '        Case "堅石"
    '            lpRetTxt = AbilityDescriptions.Item(115)
    '        Case "降雪"
    '            lpRetTxt = AbilityDescriptions.Item(116)
    '        Case "采蜜"
    '            lpRetTxt = AbilityDescriptions.Item(117)
    '        Case "看穿"
    '            lpRetTxt = AbilityDescriptions.Item(118)
    '        Case "捨身特性"
    '            lpRetTxt = AbilityDescriptions.Item(119)
    '        Case "多重屬性"
    '            lpRetTxt = AbilityDescriptions.Item(120)
    '        Case "花之禮"
    '            lpRetTxt = AbilityDescriptions.Item(121)
    '        Case "噩夢"
    '            lpRetTxt = AbilityDescriptions.Item(122)
    '        Case "偷盜惡習"
    '            lpRetTxt = AbilityDescriptions.Item(123)
    '        Case "全力攻擊"
    '            lpRetTxt = AbilityDescriptions.Item(124)
    '        Case "天邪鬼"
    '            lpRetTxt = AbilityDescriptions.Item(125)
    '        Case "緊張感"
    '            lpRetTxt = AbilityDescriptions.Item(126)
    '        Case "不服輸"
    '            lpRetTxt = AbilityDescriptions.Item(127)
    '        Case "弱氣"
    '            lpRetTxt = AbilityDescriptions.Item(128)
    '        Case "詛咒身體"
    '            lpRetTxt = AbilityDescriptions.Item(129)
    '        Case "治癒之心"
    '            lpRetTxt = AbilityDescriptions.Item(130)
    '        Case "隊友守護"
    '            lpRetTxt = AbilityDescriptions.Item(131)
    '        Case "碎甲"
    '            lpRetTxt = AbilityDescriptions.Item(132)
    '        Case "重合金"
    '            lpRetTxt = AbilityDescriptions.Item(133)
    '        Case "輕合金"
    '            lpRetTxt = AbilityDescriptions.Item(134)
    '        Case "多重鱗片"
    '            lpRetTxt = AbilityDescriptions.Item(135)
    '        Case "毒暴走"
    '            lpRetTxt = AbilityDescriptions.Item(136)
    '        Case "熱暴走"
    '            lpRetTxt = AbilityDescriptions.Item(137)
    '        Case "收穫"
    '            lpRetTxt = AbilityDescriptions.Item(138)
    '        Case "超感知"
    '            lpRetTxt = AbilityDescriptions.Item(139)
    '        Case "心智不定"
    '            lpRetTxt = AbilityDescriptions.Item(140)
    '        Case "防塵"
    '            lpRetTxt = AbilityDescriptions.Item(141)
    '        Case "毒手"
    '            lpRetTxt = AbilityDescriptions.Item(142)
    '        Case "再生力"
    '            lpRetTxt = AbilityDescriptions.Item(143)
    '        Case "鴿胸"
    '            lpRetTxt = AbilityDescriptions.Item(144)
    '        Case "挖沙"
    '            lpRetTxt = AbilityDescriptions.Item(145)
    '        Case "奇蹟皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(146)
    '        Case "分析"
    '            lpRetTxt = AbilityDescriptions.Item(147)
    '        Case "幻覺"
    '            lpRetTxt = AbilityDescriptions.Item(148)
    '        Case "替代品"
    '            lpRetTxt = AbilityDescriptions.Item(149)
    '        Case "穿透"
    '            lpRetTxt = AbilityDescriptions.Item(150)
    '        Case "木乃伊"
    '            lpRetTxt = AbilityDescriptions.Item(151)
    '        Case "自信過剩"
    '            lpRetTxt = AbilityDescriptions.Item(152)
    '        Case "正義之心"
    '            lpRetTxt = AbilityDescriptions.Item(153)
    '        Case "顫抖"
    '            lpRetTxt = AbilityDescriptions.Item(154)
    '        Case "魔法反射"
    '            lpRetTxt = AbilityDescriptions.Item(155)
    '        Case "食草"
    '            lpRetTxt = AbilityDescriptions.Item(156)
    '        Case "惡作劇之心"
    '            lpRetTxt = AbilityDescriptions.Item(157)
    '        Case "沙之力量"
    '            lpRetTxt = AbilityDescriptions.Item(158)
    '        Case "鐵刺荊棘"
    '            lpRetTxt = AbilityDescriptions.Item(159)
    '        Case "達摩模式"
    '            lpRetTxt = AbilityDescriptions.Item(160)
    '        Case "勝利之星"
    '            lpRetTxt = AbilityDescriptions.Item(161)
    '        Case "渦輪高溫"
    '            lpRetTxt = AbilityDescriptions.Item(162)
    '        Case "兆級電壓"
    '            lpRetTxt = AbilityDescriptions.Item(163)
    '        Case "芳香之幕"
    '            lpRetTxt = AbilityDescriptions.Item(164)
    '        Case "花幕"
    '            lpRetTxt = AbilityDescriptions.Item(165)
    '        Case "頰囊"
    '            lpRetTxt = AbilityDescriptions.Item(166)
    '        Case "變換自在"
    '            lpRetTxt = AbilityDescriptions.Item(167)
    '        Case "毛皮外衣"
    '            lpRetTxt = AbilityDescriptions.Item(168)
    '        Case "術士"
    '            lpRetTxt = AbilityDescriptions.Item(169)
    '        Case "防彈"
    '            lpRetTxt = AbilityDescriptions.Item(170)
    '        Case "好勝"
    '            lpRetTxt = AbilityDescriptions.Item(171)
    '        Case "下顎結實"
    '            lpRetTxt = AbilityDescriptions.Item(172)
    '        Case "冰凍皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(173)
    '        Case "甜幕"
    '            lpRetTxt = AbilityDescriptions.Item(174)
    '        Case "戰鬥切換"
    '            lpRetTxt = AbilityDescriptions.Item(175)
    '        Case "疾風之翼"
    '            lpRetTxt = AbilityDescriptions.Item(176)
    '        Case "超級噴射"
    '            lpRetTxt = AbilityDescriptions.Item(177)
    '        Case "草之毛皮"
    '            lpRetTxt = AbilityDescriptions.Item(178)
    '        Case "共生"
    '            lpRetTxt = AbilityDescriptions.Item(179)
    '        Case "堅硬爪子"
    '            lpRetTxt = AbilityDescriptions.Item(180)
    '        Case "妖精皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(181)
    '        Case "滑溜溜"
    '            lpRetTxt = AbilityDescriptions.Item(182)
    '        Case "天空皮膚"
    '            lpRetTxt = AbilityDescriptions.Item(183)
    '        Case "親子愛"
    '            lpRetTxt = AbilityDescriptions.Item(184)
    '        Case "黑暗氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(185)
    '        Case "妖精氣氛"
    '            lpRetTxt = AbilityDescriptions.Item(186)
    '        Case "氣氛破壞"
    '            lpRetTxt = AbilityDescriptions.Item(187)
    '        Case "起始之海"
    '            lpRetTxt = AbilityDescriptions.Item(188)
    '        Case "終結大地"
    '            lpRetTxt = AbilityDescriptions.Item(189)
    '        Case "變化氣流"
    '            lpRetTxt = AbilityDescriptions.Item(190)
    '        Case Else
    '            Exit Sub
    '    End Select
    '    MessageBox.Show(lpRetTxt, txtAbility3_OS.Text, MessageBoxButton.OK)
    'End Sub

    Private Sub lstEvoRot_Tap(sender As Object, e As GestureEventArgs) Handles lstEvoRot.Tap
        If lstEvoRot.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim i As Integer
        i = lstEvoRot.SelectedIndex
        If i >= 0 Then
            imgArrow.Visibility = System.Windows.Visibility.Visible
            rectImgEvo_Dest.Visibility = System.Windows.Visibility.Visible
            imgEvoDest.Visibility = System.Windows.Visibility.Visible
            txtName_EVODest.Visibility = System.Windows.Visibility.Visible
            txtNum_EVODest.Visibility = System.Windows.Visibility.Visible
            lblEvolution.Visibility = System.Windows.Visibility.Visible
            lblEvolution.Text = lstEvoRot.SelectedItem
            Dim lpEvoDestNum As Integer
            lpEvoDestNum = CInt(EvoluteToNumers(i))
            Dim imgPokemonEvoDest As Imaging.BitmapImage
            txtName_EVODest.Text = CurrentTranslationForCommonUse(lpEvoDestNum - 1)
            imgPokemonEvoDest = New Imaging.BitmapImage
            imgPokemonEvoDest.UriSource = New Uri("/PokemonsL/" & EvoluteToNumers(i) & ".png", UriKind.RelativeOrAbsolute)
            imgEvoDest.Source = imgPokemonEvoDest
            txtNum_EVODest.Text = "全國圖鑑登錄號 " & EvoluteToNumers(i)
        End If
    End Sub

    Private Sub ApplicationBarMenuItem_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PageSearchReq.xaml", UriKind.RelativeOrAbsolute))
        Exit Sub
        If 25 = 245 Then
            Dim PokemonOnlineSearch As Microsoft.Phone.Tasks.SearchTask
            PokemonOnlineSearch = New Microsoft.Phone.Tasks.SearchTask
            With PokemonOnlineSearch
                .SearchQuery = PokemonInformationShared.lpNameCHT
                .Show()
            End With
        End If
    End Sub

    Private Sub ApplicationBarMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim tile As FlipTileData
        tile = New FlipTileData
        Dim PkMnNum As String
        PkMnNum = PokemonInformationShared.lpNumber
        With tile
            .BackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .SmallBackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .WideBackgroundImage = New Uri("/PokemonsTL/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .Title = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1)
        End With
        ShellTile.Create(New Uri("/PageTileLauncher.xaml?Index=" & currentTileIndex.ToString & "&Num=" & PkMnNum, UriKind.RelativeOrAbsolute), tile, True)
        currentTileIndex = currentTileIndex + 1
        indexManage("Index") = currentTileIndex
    End Sub

    Private Sub ApplicationBarMenuItem_Click_2(sender As Object, e As EventArgs)
        Dim tile As FlipTileData
        tile = New FlipTileData
        Dim PkMnNum As String
        PkMnNum = PokemonInformationShared.lpNumber
        With tile
            .BackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .SmallBackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .WideBackgroundImage = New Uri("/PokemonsTL/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .Title = ""
        End With
        ShellTile.Create(New Uri("/PageTileLauncher.xaml?Index=" & currentTileIndex.ToString & "&Num=" & PkMnNum, UriKind.RelativeOrAbsolute), tile, True)
        currentTileIndex = currentTileIndex + 1
        indexManage("Index") = currentTileIndex
    End Sub

    Private Sub txtAbility2_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2.Tap
        If txtAbility2.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpAbility2 - 1), txtAbility2.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub lstStates_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstStates.DoubleTap
        If lstStates.SelectedIndex >= 0 Then
            SharedStateInformation = StateInformation(lstStates.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedStateInformation.lpImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
            SharedStateInformation.lpStateName = States.Item(lstStates.SelectedIndex)
            NavigationService.Navigate(New Uri("/PageStateInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub lstStates_Tap(sender As Object, e As GestureEventArgs) Handles lstStates.Tap
        If lstStates.SelectedIndex >= 0 Then
            SharedStateInformation = StateInformation(lstStates.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedStateInformation.lpImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
        Else
            Exit Sub
            'NavigationService.Navigate(New Uri("/PageStateInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub btnRGBY_Tap(sender As Object, e As GestureEventArgs) Handles btnRGBY.Tap
        GeneratePokemonMovesIDListByPMID_RGBY(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnGSC_Tap(sender As Object, e As GestureEventArgs) Handles btnGSC.Tap
        GeneratePokemonMovesIDListByPMID_GSC(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnRSE_Tap(sender As Object, e As GestureEventArgs) Handles btnRSE.Tap
        GeneratePokemonMovesIDListByPMID_RSE(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnDPT_Tap(sender As Object, e As GestureEventArgs) Handles btnDPT.Tap
        GeneratePokemonMovesIDListByPMID_DPT(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnBW_Tap(sender As Object, e As GestureEventArgs) Handles btnBW.Tap
        GeneratePokemonMovesIDListByPMID_BW(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnXY_Tap(sender As Object, e As GestureEventArgs) Handles btnXY.Tap
        GeneratePokemonMovesIDListByPMID_XY(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnSM_Tap(sender As Object, e As GestureEventArgs) Handles btnSM.Tap
        If PokemonInformationShared.lpNumber >= 722 And PokemonInformationShared.lpNumber <= 809 Then
            GeneratePokemonMovesIDListByPMID_SM_7(PokemonInformationShared.lpNumber)
        Else
            GeneratePokemonMovesIDListByPMID_SM(PokemonInformationShared.lpNumber)
        End If
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgPokemon_Tap(sender As Object, e As GestureEventArgs) Handles imgPokemon.Tap
        If lstStates.SelectedIndex >= 0 Then
            SharedStateInformation = StateInformation(lstStates.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedStateInformation.lpImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
            SharedStateInformation.lpStateName = States.Item(lstStates.SelectedIndex)
            NavigationService.Navigate(New Uri("/PageStateInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub txtCHTO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTO.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTO_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTO.TextChanged
        txtCHTO.Text = PokemonInformationShared.lpNameCHTO
    End Sub

    Private Sub txtCHTO_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTO.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTO_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTO.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSO.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSO.TextChanged
        txtCHSO.Text = PokemonInformationShared.lpNameCHSO
    End Sub

    Private Sub txtCHSO_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInputStart
        e.Handled = True
    End Sub
End Class
