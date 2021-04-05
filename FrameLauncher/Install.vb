Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO
Imports System.Net
Public Class Install
    Dim NewPoint As Point
    Public WithEvents download As WebClient

    Dim client As WebClient = New WebClient()
    Private Sub Install_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(Application.StartupPath & "\Guna.UI.dll") Then

            'arquivo existe       

        Else
            MsgBox("Não foi possível iniciar o FrameLauncher" + vbNewLine + "Guna.UI.dll não encontrado", MsgBoxStyle.Critical)
            End
        End If


        Try
            System.IO.Directory.Delete(Application.StartupPath & "\FLSettings\Image", True)
        Catch

        End Try



        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Image") = True Then
            'MsgBox("PASTA EXISTE")

        Else
            'MsgBox("PASTA NÃO EXISTE")
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Image")
        End If






        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Path") = True Then
            'MsgBox("PASTA EXISTE")

        Else
            'MsgBox("PASTA NÃO EXISTE")
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Path")
        End If






        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Path\SavePath.txt") = True Then
            '    Form2.ShowDialog()

        Else

            Dim pasta As String = My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Path\SavePath.txt"
            Dim site As String = "http://191.232.198.2/SavePath.txt"
            download = New WebClient
            download.DownloadFileAsync(New Uri(site), pasta)
        End If

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Image\GifImage.gif") = True Then
            '    Form2.ShowDialog()

        Else

            Dim pasta As String = My.Computer.FileSystem.CurrentDirectory + "\FLSettings\Image\GifImage.gif"
            Dim site As String = "http://191.232.198.2/FrameLauncher/Image/GifImage.gif"
            download = New WebClient
            download.DownloadFileAsync(New Uri(site), pasta)
        End If

    End Sub
    Private Sub download_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted
        PathProgress.Value = 0
        'ImageProgress.Value = 0

        If Application.OpenForms.OfType(Of Form1)().Count() > 0 Then

        Else
            Me.Hide()
            Form1.ShowDialog()
        End If

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

        Try
            '  Label1.Text = "Baixado: " & e.BytesReceived / 10000 & " MB / " & e.TotalBytesToReceive / 10000 & " MB "
            PathProgress.Value = e.ProgressPercentage
            '  Label2.Text = "Progresso: " & prgDownload.Value & "%"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        End
    End Sub

    Private Sub FlowLayoutPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseDown
        If MouseButtons <> Windows.Forms.MouseButtons.Left Then Exit Sub
        NewPoint.X = Me.Left - MousePosition.X
        NewPoint.Y = Me.Top - MousePosition.Y
    End Sub

    Private Sub FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseMove
        If MouseButtons <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = NewPoint.X + MousePosition.X
        Me.Top = NewPoint.Y + MousePosition.Y
    End Sub
End Class