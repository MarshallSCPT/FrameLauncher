Imports System.IO

Public Class Form1
    Dim NewPoint As Point


    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub
    Public Property CSharpImpl As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        If Leitura.Checked = True Then

            Dim pasta As String = (Application.StartupPath & "\FLSettings\Path\SavePath.txt")

            If System.IO.File.Exists(pasta) = True Then

                Dim ler As New System.IO.StreamReader(pasta)

                GamePath.Text = ler.ReadToEnd

                ler.Close()

            Else

                MsgBox("Pasta não existe!", MsgBoxStyle.Exclamation, "Erro!")
            End If

        End If


        PathAC.Text = (Application.StartupPath & "\FLSettings\Path\SavePath.txt")
        ' (Application.StartupPath & "\FLSettings\Path\SavePath.txt")
        LerArquivoTexto(PathAC.Text)


        Me.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\FLSettings\Image\GifImage.gif")


    End Sub


    Private Sub LerArquivoTexto(ByVal StrArquivo As String)
        Try

            Using sr As StreamReader = New StreamReader(StrArquivo)
                Dim linha As String

                While (CSharpImpl.__Assign(linha, sr.ReadLine())) IsNot Nothing
                    GamePath.Text = linha
                End While
            End Using

        Catch e As Exception
        End Try
    End Sub



    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles StartGame.Click


        If GamePath.Text = "" Then
            MsgBox("Selecione a pasta do jogo antes de iniciar", MsgBoxStyle.Critical, "Path não encontrado")
        Else

            Dim texto As String = GamePath.Text

            Dim esc_texto As New StreamWriter(Application.StartupPath & "\FLSettings\Path\SavePath.txt")

            esc_texto.Write(texto)

            esc_texto.Close()

            If System.IO.File.Exists(String.Concat(GamePath.Text, "\_retail_\Overwatch.exe")) Then

                Dim token As String = ""

                ' Process.Start(Application.StartupPath & "\Overwatch Launcher.exe", token)

                Shell(GamePath.Text + "\_retail_\Overwatch.exe", AppWinStyle.NormalFocus)

            Else
                MsgBox("Não foi possível iniciar o jogo." + vbNewLine + "Código de parada: 1", MsgBoxStyle.Information)

            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim localByName As Process() = Process.GetProcessesByName("Overwatch")

        If (localByName.Length <> 0) Then
            Console.WriteLine("Jogo aberto")
            StartGame.Visible = False
            StopGame.Visible = True

        Else
            Console.WriteLine("Jogo fechado")
            StopGame.Visible = False
            StartGame.Visible = True
        End If
        Console.ReadLine()

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            GamePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub StopGame_Click(sender As Object, e As EventArgs) Handles StopGame.Click
        Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName("Overwatch")

        For Each x As Process In Processos
            x.Kill()
        Next
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

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        End
    End Sub
End Class
