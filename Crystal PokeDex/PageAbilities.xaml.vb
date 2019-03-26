﻿Imports Coding4Fun.Toolkit.Controls

Partial Public Class PageAblities
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ApplicationBarIconButton_Click_1(sender As Object, e As EventArgs)
        Dim InputBoxEx As InputPrompt
        InputBoxEx = New InputPrompt
        If 245 = 25 Then
            Dim InputScopeNumber As InputScope
            InputScopeNumber = New InputScope
            Dim InputScopeNumberName As InputScopeName
            InputScopeNumberName = New InputScopeName
            With InputScopeNumberName
                .NameValue = InputScopeNameValue.Search
            End With
            With InputScopeNumber
                .Names.Add(InputScopeNumberName)
            End With
        End If
        Dim InputScopeSearch As InputScope
        InputScopeSearch = New InputScope
        Dim InputScopeSearchName As InputScopeName
        InputScopeSearchName = New InputScopeName
        With InputScopeSearchName
            .NameValue = InputScopeNameValue.Search
        End With
        With InputScopeSearch
            .Names.Add(InputScopeSearchName)
        End With
        With InputBoxEx
            AddHandler .Completed, AddressOf SearchRequest_Completed
            .Title = "搜尋"
            .InputScope = InputScopeSearch
            .Message = "請輸入您需要的特性名稱的全部或者部分內容。"
            .Show()
        End With
    End Sub
    Sub InputPrompt_Completed(lpSender As Object, e As PopUpEventArgs(Of String, PopUpResult))
        If e.PopUpResult = PopUpResult.Ok Then
            Dim lpNum As String
            Dim lpNumInt As Long
            lpNum = e.Result
            If IsNumber(lpNum) = 0 Then
                MessageBox.Show("請輸入有效的數值。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
            lpNumInt = CLng(lpNum)
            If (1 <= lpNumInt) And (lpNumInt <= lstItems.Items.Count) Then
                lstItems.SelectedIndex = lpNumInt - 1
            Else
                MessageBox.Show("輸入的編號超出允許的範圍。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
            'MessageBox.Show(Me.lstPokemons.SelectedItems.Item(0))
        Else
            Exit Sub
        End If
    End Sub
    Sub SearchRequest_Completed(lpSender As Object, e As PopUpEventArgs(Of String, PopUpResult))
        If 25 = 245 Then
            If e.PopUpResult = PopUpResult.Ok Then
                Dim lpNum As String
                Dim lpNumInt As Long
                lpNum = e.Result
                lpNumInt = CLng(lpNum)
                If (1 <= lpNumInt) And (lpNumInt <= 721) Then
                    lstItems.SelectedIndex = lpNumInt - 1
                Else
                    MessageBox.Show("輸入的編號超出允許的範圍。", "錯誤", MessageBoxButton.OK)
                    Exit Sub
                End If
                'MessageBox.Show(Me.lstPokemons.SelectedItems.Item(0))
                Dim imgSelPkMn As Media.Imaging.BitmapImage
                imgSelPkMn = New Imaging.BitmapImage
                Dim strSel As String
                strSel = lstItems.SelectedItems.Item(0).ToString
                strSel = strSel.Chars(0) & strSel.Chars(1) & strSel.Chars(2)
                If 25 = 245 Then
                    MessageBox.Show(strSel)
                End If
                imgSelPkMn.UriSource = New Uri("/PokemonsL/" & strSel & ".png", UriKind.RelativeOrAbsolute)
                'imgPokemon.Source = imgSelPkMn

            Else
                Exit Sub
            End If
        End If
        If e.PopUpResult = PopUpResult.Ok Then
            Dim lpIPBSearchRequest As String
            lpIPBSearchRequest = e.Result.Trim
            If lpIPBSearchRequest = "" Then
                MessageBox.Show("請不要嘗試搜尋空白內容或者純空白字符。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
            lpSearchRequest = lpIPBSearchRequest
            'NavigationService
            NavigationService.Navigate(New Uri("/PageAbilitySearch.xaml", UriKind.RelativeOrAbsolute))
        Else
            Exit Sub
        End If
    End Sub
    Private Sub PageAblities_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Select Case UIAbilityChineseDisplayConfig
            Case ChineseDisplayConfig.DefaultConfig
                lstItems.ItemsSource = ListAbilityCHT_Official
            Case ChineseDisplayConfig.InformalChineseSimplified
                lstItems.ItemsSource = ListAbilityCHS
            Case ChineseDisplayConfig.InformalChineseTraditional
                lstItems.ItemsSource = ListAbilityCHT
            Case ChineseDisplayConfig.OfficialChineseSimplified
                lstItems.ItemsSource = ListAbilityCHS_Official
            Case ChineseDisplayConfig.OfficialChineseTraditional
                lstItems.ItemsSource = ListAbilityCHT_Official
        End Select
        Exit Sub
        Dim ItemAbilities As New List(Of String)
        With ItemAbilities
            .Clear()
            .Add("001     惡臭")
            .Add("002     毛毛雨")
            .Add("003     加速")
            .Add("004     甲蟲盔甲")
            .Add("005     結實")
            .Add("006     溼氣")
            .Add("007     柔軟")
            .Add("008     沙裡隱身")
            .Add("009     靜電")
            .Add("010     蓄電")
            .Add("011     儲水")
            .Add("012     遲鈍")
            .Add("013     樂天")
            .Add("014     複眼")
            .Add("015     失眠")
            .Add("016     變色")
            .Add("017     免疫")
            .Add("018     延燒")
            .Add("019     鱗粉")
            .Add("020     我行我素")
            .Add("021     吸盤")
            .Add("022     威嚇")
            .Add("023     影子遊戲")
            .Add("024     蛇皮")
            .Add("025     奇異守護")
            .Add("026     漂浮")
            .Add("027     孢子")
            .Add("028     同步")
            .Add("029     透明體")
            .Add("030     自然恢復")
            .Add("031     避雷針")
            .Add("032     天恩")
            .Add("033     輕快")
            .Add("034     葉綠素")
            .Add("035     發光")
            .Add("036     追蹤")
            .Add("037     大力士")
            .Add("038     毒刺特性")
            .Add("039     精神力")
            .Add("040     岩漿防護")
            .Add("041     水幕")
            .Add("042     磁力")
            .Add("043     隔音")
            .Add("044     雨盤")
            .Add("045     沙流")
            .Add("046     氣壓")
            .Add("047     肥脂")
            .Add("048     早起")
            .Add("049     火焰體")
            .Add("050     逃走")
            .Add("051     銳利目光")
            .Add("052     怪力剪刀")
            .Add("053     撿拾")
            .Add("054     懶惰特性")
            .Add("055     活力")
            .Add("056     誘惑身軀")
            .Add("057     陽性")
            .Add("058     陰性")
            .Add("059     天氣預報")
            .Add("060     黏著")
            .Add("061     脫皮")
            .Add("062     毅力")
            .Add("063     怪鱗")
            .Add("064     黏液")
            .Add("065     茂盛")
            .Add("066     猛火")
            .Add("067     激流")
            .Add("068     預感")
            .Add("069     石頭")
            .Add("070     旱災")
            .Add("071     獅蟻")
            .Add("072     元氣")
            .Add("073     白霧特性")
            .Add("074     瑜珈神力")
            .Add("075     貝殼盔甲")
            .Add("076     氣閘")
            .Add("077     蹣跚")
            .Add("078     電氣引擎")
            .Add("079     鬥爭心")
            .Add("080     不屈之心")
            .Add("081     雪裡隱身")
            .Add("082     貪吃鬼")
            .Add("083     憤怒穴道")
            .Add("084     雜技")
            .Add("085     耐熱")
            .Add("086     單純")
            .Add("087     乾燥皮膚")
            .Add("088     下載")
            .Add("089     鐵拳")
            .Add("090     毒療")
            .Add("091     適應力")
            .Add("092     連續攻擊")
            .Add("093     濕潤身體")
            .Add("094     太陽能量")
            .Add("095     飛毛腿")
            .Add("096     一般皮膚")
            .Add("097     狙擊手")
            .Add("098     魔法防禦")
            .Add("099     無防禦")
            .Add("100     慢出")
            .Add("101     技術員")
            .Add("102     葉片防禦")
            .Add("103     笨手笨腳")
            .Add("104     革新")
            .Add("105     強運")
            .Add("106     引爆")
            .Add("107     預知危險")
            .Add("108     預知夢")
            .Add("109     後知後覺")
            .Add("110     有色眼鏡")
            .Add("111     過濾")
            .Add("112     錯失先機")
            .Add("113     膽量")
            .Add("114     引水")
            .Add("115     冰凍身體")
            .Add("116     堅石")
            .Add("117     降雪")
            .Add("118     采蜜")
            .Add("119     看穿")
            .Add("120     捨身特性")
            .Add("121     多重屬性")
            .Add("122     花之禮")
            .Add("123     噩夢")
            .Add("124     偷盜惡習")
            .Add("125     全力攻擊")
            .Add("126     天邪鬼")
            .Add("127     緊張感")
            .Add("128     不服輸")
            .Add("129     弱氣")
            .Add("130     詛咒身體")
            .Add("131     治癒之心")
            .Add("132     隊友守護")
            .Add("133     碎甲")
            .Add("134     重合金")
            .Add("135     輕合金")
            .Add("136     多重鱗片")
            .Add("137     毒暴走")
            .Add("138     熱暴走")
            .Add("139     收穫")
            .Add("140     超感知")
            .Add("141     心智不定")
            .Add("142     防塵")
            .Add("143     毒手")
            .Add("144     再生力")
            .Add("145     鴿胸")
            .Add("146     挖沙")
            .Add("147     奇蹟皮膚")
            .Add("148     分析")
            .Add("149     幻覺")
            .Add("150     替代品")
            .Add("151     穿透")
            .Add("152     木乃伊")
            .Add("153     自信過剩")
            .Add("154     正義之心")
            .Add("155     顫抖")
            .Add("156     魔法反射")
            .Add("157     食草")
            .Add("158     惡作劇之心")
            .Add("159     沙之力量")
            .Add("160     鐵刺荊棘")
            .Add("161     達摩模式")
            .Add("162     勝利之星")
            .Add("163     渦輪高溫")
            .Add("164     兆級電壓")
            .Add("165     芳香之幕")
            .Add("166     花幕")
            .Add("167     頰囊")
            .Add("168     變換自在")
            .Add("169     毛皮外衣")
            .Add("170     術士")
            .Add("171     防彈")
            .Add("172     好勝")
            .Add("173     下顎結實")
            .Add("174     冰凍皮膚")
            .Add("175     甜幕")
            .Add("176     戰鬥切換")
            .Add("177     疾風之翼")
            .Add("178     超級噴射")
            .Add("179     草之毛皮")
            .Add("180     共生")
            .Add("181     堅硬爪子")
            .Add("182     妖精皮膚")
            .Add("183     滑溜溜")
            .Add("184     天空皮膚")
            .Add("185     親子愛")
            .Add("186     黑暗氣氛")
            .Add("187     妖精氣氛")
            .Add("188     氣氛破壞")
            .Add("189     起始之海")
            .Add("190     終結大地")
            .Add("191     變化氣流")
        End With
        lstItems.ItemsSource = ItemAbilities
    End Sub
    Private Sub ApplicationBarIconButton_Click_2(sender As Object, e As EventArgs)
        lstItems.SelectedIndex = 0
    End Sub

    Private Sub ApplicationBarIconButton_Click_3(sender As Object, e As EventArgs)
        lstItems.SelectedIndex = lstItems.Items.Count - 1
    End Sub

    Private Sub lstItems_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstItems.DoubleTap
        If lstItems.SelectedIndex < 0 Then
            Exit Sub
        End If
        If lstItems.SelectedIndex < 0 Or lstItems.SelectedIndex > lstItems.Items.Count - 1 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstItems.SelectedItems.Item(0).ToString
        strSel = strSel.Chars(0) & strSel.Chars(1) & strSel.Chars(2)
        AbilitySelectionNumber = strSel
        NavigationService.Navigate(New Uri("/PageAbilityDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstItems_Tap(sender As Object, e As GestureEventArgs) Handles lstItems.Tap
        If lstItems.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstItems.SelectedItems.Item(0).ToString
        strSel = strSel.Chars(0) & strSel.Chars(1) & strSel.Chars(2)
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim InputBoxEx As InputPrompt
        InputBoxEx = New InputPrompt
        Dim InputScopeNumber As InputScope
        InputScopeNumber = New InputScope
        Dim InputScopeNumberName As InputScopeName
        InputScopeNumberName = New InputScopeName
        With InputScopeNumberName
            .NameValue = InputScopeNameValue.Number
        End With
        With InputScopeNumber
            .Names.Add(InputScopeNumberName)
        End With
        With InputBoxEx
            AddHandler .Completed, AddressOf InputPrompt_Completed
            .Title = "定位到編號"
            .Message = "請輸入您需要的特性的編號。" & vbCrLf & "範圍: 001-" & lstItems.Items.Count
            .InputScope = InputScopeNumber
            .Show()
        End With
    End Sub
End Class