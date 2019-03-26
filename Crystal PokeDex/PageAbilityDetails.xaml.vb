﻿Partial Public Class PageAbilityDetails
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageAbilityDetails_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'InitializeAbilities()
        txtName.Text = CurrentAbility.Item(AbilitySelectionNumber - 1)
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
        pivMove.Title = txtName.Text
    End Sub

    Private Sub txtDescription_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.GotFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.Black)
    End Sub
    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtDescription_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.LostFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.White)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtDescription.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub

    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtROC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtROC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtROC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtROC.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtROC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtROC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtJPN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJPN.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtJPN.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtJPN_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInput
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtENU_KeyDown(sender As Object, e As KeyEventArgs) Handles txtENU.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtENU_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtENU.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtENU_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInput
        e.Handled = True
    End Sub

    Private Sub txtENU_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInputStart
        e.Handled = True
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PageAbilityOnlineSearchCfg.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtCHSO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSO.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSO.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtCHSO_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextInputUpdate(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInputUpdate
        e.Handled = True
    End Sub

    Private Sub txtCHTO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTO.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTO_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTO.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtCHTO_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTO.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTO_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTO.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtPRC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPRC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtPRC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtPRC.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtROC.Text = AbilityNamesCHT(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        txtPRC.Text = AbilityNamesCHS(AbilitySelectionNumber - 1)
        txtCHSO.Text = AbilityNamesCHS_Official(AbilitySelectionNumber - 1)
        txtCHTO.Text = AbilityNamesCHT_Official(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtPRC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtPRC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtPRC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtPRC.TextInputStart
        e.Handled = True
    End Sub
End Class
