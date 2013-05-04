﻿Public Class Form3
    Dim AngkaSalah As Integer = 0
    Dim Kalimat As String = ""
    Dim Kata As String = ""
    Dim Database As String = "senjata.txt"
    Dim Time As Decimal = 0
    Public Kataarray() As String
    Public Ditemukan() As String
    Dim buttonhuruf As Char
    Dim buttonhurufslh(10) As Char

    Private Sub GetKata()
        Randomize()
        img_man.ImageLocation = AngkaSalah & ".png"
        Dim kalimatterpilih As Integer
        kalimatterpilih = Math.Round((Rnd() * 17), 0)
        Dim i As Integer = 0
        If System.IO.File.Exists(Database) = True Then
            Dim objReader As New System.IO.StreamReader(Database)
            Do While objReader.Peek() <> -1
                Kalimat = objReader.ReadLine()
                If i = kalimatterpilih Then
                    Kata = Kalimat
                End If
                i = i + 1
            Loop
        Else
            MsgBox("You have an error in your file location")
            Application.Exit()
        End If
        Kata = Kata.ToUpper
        ReDim Kataarray((Len(Kata) - 1))
        ReDim Ditemukan((Len(Kata) - 1))
        For k = 0 To (Len(Kata) - 1)
            Kataarray(k) = Kata.Chars(k)
        Next k
        For j = 0 To (Len(Kata) - 1)
            Ditemukan(j) = "_"
        Next j
        For l = 1 To 10
            buttonhurufslh(l) = ""
        Next l
        Time = 0
        TampilkanKata()
        EnableAll()
        ClearAll()
    End Sub

    Private Sub TampilkanKata()
        Dim output As String = " "
        For i = 0 To UBound(Ditemukan)
            output = output & Ditemukan(i) & " "
        Next i
        txtkata.Text = output
        txtkata.DeselectAll()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetKata()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Time = Time + 0.1
        Dim seconds As Decimal = Time
        Dim mins As Decimal = Time / 60
        mins = Math.Floor(mins)
        seconds = Time - (mins * 60)
        lbltimer.Text = mins & ":" & FormatNumber(seconds, 1)
    End Sub

    Private Sub TekanHuruf()
        Dim found As Boolean = False
        Dim KataDitemukan As Boolean = False
        For i = 0 To UBound(Ditemukan)
            If buttonhuruf = Kataarray(i) Then
                Ditemukan(i) = Kataarray(i)
                found = True
            End If
        Next i
        If found = False Then
            If AngkaSalah <> 5 Then
                AngkaSalah = AngkaSalah + 1
                img_man.ImageLocation = AngkaSalah & ".png"
                buttonhurufslh(AngkaSalah) = buttonhuruf
            Else
                img_man.ImageLocation = "6.png"
                MsgBox("Anda kalah dalam permainan ini, kata yang tepat adalah " & Kata)
                EnableAll()
                AngkaSalah = 0
                GetKata()
            End If
        End If
        For j = 0 To UBound(Ditemukan)
            If Ditemukan(j) = "_" Then
                Exit For
            Else
                If j = UBound(Ditemukan) Then
                    TampilkanKata()
                    MsgBox("Selamat! anda memecahkan kata tersebut !" & vbCrLf & "tekan OK untuk memulai permainan baru")
                    AngkaSalah = 0
                    EnableAll()
                    ClearAll()
                    GetKata()
                    Time = 0
                End If
            End If
        Next
        Select Case AngkaSalah
            Case 1
                l1.Text = buttonhurufslh(1).ToString
            Case 2
                l2.Text = buttonhurufslh(2).ToString
            Case 3
                l3.Text = buttonhurufslh(3).ToString
            Case 4
                l4.Text = buttonhurufslh(4).ToString
            Case 5
                l5.Text = buttonhurufslh(5).ToString
            Case 6
                l6.Text = buttonhurufslh(6).ToString
            Case 7
                l7.Text = buttonhurufslh(7).ToString
            Case 8
                l8.Text = buttonhurufslh(8).ToString
            Case 9
                l9.Text = buttonhurufslh(9).ToString
        End Select
        TampilkanKata()
    End Sub

    Private Sub cmdA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdA.Click
        buttonhuruf = "A"
        cmdA.Enabled = False
        TekanHuruf()
    End Sub

    Private Sub cmdB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdB.Click
        buttonhuruf = "B"
        cmdB.Enabled = False
        TekanHuruf()
    End Sub

    Private Sub cmdC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdC.Click
        buttonhuruf = "C"
        cmdC.Enabled = False
        TekanHuruf()
    End Sub

    Private Sub cmdD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdD.Click
        buttonhuruf = "D"
        cmdD.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdE.Click
        buttonhuruf = "E"
        cmdE.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdF.Click
        buttonhuruf = "F"
        cmdF.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdG.Click
        buttonhuruf = "G"
        cmdG.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdH.Click
        buttonhuruf = "H"
        cmdH.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdI.Click
        buttonhuruf = "I"
        cmdI.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdJ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdJ.Click
        buttonhuruf = "J"
        cmdJ.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdK.Click
        buttonhuruf = "K"
        cmdK.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdL.Click
        buttonhuruf = "L"
        cmdL.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdM.Click
        buttonhuruf = "M"
        cmdM.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdN.Click
        buttonhuruf = "N"
        cmdN.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdO.Click
        buttonhuruf = "O"
        cmdO.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdP.Click
        buttonhuruf = "P"
        cmdP.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdQ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdQ.Click
        buttonhuruf = "Q"
        cmdQ.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdR.Click
        buttonhuruf = "R"
        cmdR.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdS.Click
        buttonhuruf = "S"
        cmdS.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdT.Click
        buttonhuruf = "T"
        cmdT.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdU.Click
        buttonhuruf = "U"
        cmdU.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdV.Click
        buttonhuruf = "V"
        cmdV.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdW_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdW.Click
        buttonhuruf = "W"
        cmdW.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdX.Click
        buttonhuruf = "X"
        cmdX.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdY.Click
        buttonhuruf = "Y"
        cmdY.Enabled = False
        TekanHuruf()
    End Sub
    Private Sub cmdZ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdZ.Click
        buttonhuruf = "Z"
        cmdZ.Enabled = False
        TekanHuruf()
    End Sub

    Private Sub EnableAll()
        cmdA.Enabled = True
        cmdB.Enabled = True
        cmdC.Enabled = True
        cmdD.Enabled = True
        cmdE.Enabled = True
        cmdF.Enabled = True
        cmdG.Enabled = True
        cmdH.Enabled = True
        cmdI.Enabled = True
        cmdJ.Enabled = True
        cmdK.Enabled = True
        cmdL.Enabled = True
        cmdM.Enabled = True
        cmdN.Enabled = True
        cmdO.Enabled = True
        cmdP.Enabled = True
        cmdQ.Enabled = True
        cmdR.Enabled = True
        cmdS.Enabled = True
        cmdT.Enabled = True
        cmdU.Enabled = True
        cmdV.Enabled = True
        cmdW.Enabled = True
        cmdX.Enabled = True
        cmdY.Enabled = True
        cmdZ.Enabled = True

    End Sub

    Private Sub ClearAll()
        l1.Text = ""
        l2.Text = ""
        l3.Text = ""
        l4.Text = ""
        l5.Text = ""
        l6.Text = ""
        l7.Text = ""
        l8.Text = ""
        l9.Text = ""
    End Sub

    Private Sub cmdnew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        AngkaSalah = 0
        GetKata()
        Time = 0
    End Sub

    Private Sub cmdexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
        Home.Show()
    End Sub


    Private Sub cmdpause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpause.Click
        Timer1.Stop()
        MsgBox("Tekan OK untuk melanjutkan...")
        Timer1.Start()
    End Sub

    Private Sub cmdhelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdhelp.Click
        MsgBox("Pilih new game untuk memulai permainan baru!" & vbCrLf & "Garis bawah menunjukkan kata yang anda tebak" & vbCrLf & "Cobalah untuk menebak kata tersebut dengan " & vbCrLf & "Klik pada tombol huruf untuk meebak atau" & vbCrLf & "Klik OK untuk memulai permainan baru")
        AngkaSalah = 0
        GetKata()
        Time = 0
    End Sub
End Class