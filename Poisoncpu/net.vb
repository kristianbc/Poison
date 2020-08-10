Imports System.Net
Imports System.Text
Public Class net
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub net_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strHostName As String
        Dim strIpAdress As String
        strHostName = System.Net.Dns.GetHostName()
        strIpAdress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Label2.Text = ("" & strIpAdress)
        Dim wc As New WebClient
        Label5.Text = ("" & wc.DownloadString("https://icanhazip.com"))
        Label7.Text = My.Computer.Network.IsAvailable
        Label9.Text = My.Computer.Network.GetHashCode


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class