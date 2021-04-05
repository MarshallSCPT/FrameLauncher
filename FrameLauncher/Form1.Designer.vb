<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Leitura = New System.Windows.Forms.CheckBox()
        Me.PathAC = New Guna.UI.WinForms.GunaTextBox()
        Me.GamePath = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.StartGame = New Guna.UI.WinForms.GunaButton()
        Me.StopGame = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, -3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(813, 14)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.TabStop = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Leitura)
        Me.Panel1.Controls.Add(Me.PathAC)
        Me.Panel1.Controls.Add(Me.GamePath)
        Me.Panel1.Controls.Add(Me.GunaVSeparator1)
        Me.Panel1.Controls.Add(Me.GunaButton2)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.GunaPictureBox2)
        Me.Panel1.Controls.Add(Me.StartGame)
        Me.Panel1.Controls.Add(Me.StopGame)
        Me.Panel1.Location = New System.Drawing.Point(317, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 531)
        Me.Panel1.TabIndex = 2
        '
        'Leitura
        '
        Me.Leitura.AutoSize = True
        Me.Leitura.Checked = True
        Me.Leitura.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Leitura.Location = New System.Drawing.Point(178, 7)
        Me.Leitura.Name = "Leitura"
        Me.Leitura.Size = New System.Drawing.Size(58, 17)
        Me.Leitura.TabIndex = 13
        Me.Leitura.Text = "Leitura"
        Me.Leitura.UseVisualStyleBackColor = True
        Me.Leitura.Visible = False
        '
        'PathAC
        '
        Me.PathAC.BaseColor = System.Drawing.Color.White
        Me.PathAC.BorderColor = System.Drawing.Color.Silver
        Me.PathAC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PathAC.FocusedBaseColor = System.Drawing.Color.White
        Me.PathAC.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PathAC.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.PathAC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PathAC.Location = New System.Drawing.Point(6, 39)
        Me.PathAC.Name = "PathAC"
        Me.PathAC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PathAC.SelectedText = ""
        Me.PathAC.Size = New System.Drawing.Size(166, 30)
        Me.PathAC.TabIndex = 12
        Me.PathAC.Visible = False
        '
        'GamePath
        '
        Me.GamePath.BaseColor = System.Drawing.Color.White
        Me.GamePath.BorderColor = System.Drawing.Color.Silver
        Me.GamePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GamePath.FocusedBaseColor = System.Drawing.Color.White
        Me.GamePath.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GamePath.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GamePath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GamePath.Location = New System.Drawing.Point(6, 7)
        Me.GamePath.Name = "GamePath"
        Me.GamePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GamePath.ReadOnly = True
        Me.GamePath.SelectedText = ""
        Me.GamePath.Size = New System.Drawing.Size(166, 26)
        Me.GamePath.TabIndex = 10
        Me.GamePath.Visible = False
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator1.Location = New System.Drawing.Point(303, 425)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 51)
        Me.GunaVSeparator1.TabIndex = 9
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Global.FrameLauncher.My.Resources.Resources.icons8_procurar_pasta_30__1_
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(313, 425)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(39, 51)
        Me.GunaButton2.TabIndex = 7
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(172, 505)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(153, 13)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Created by Capetalista#3310"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.Location = New System.Drawing.Point(207, 105)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(83, 20)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Overwatch"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.FrameLauncher.My.Resources.Resources.icons8_supervisor_48
        Me.GunaPictureBox1.Location = New System.Drawing.Point(224, 57)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(141, 479)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(84, 15)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Version: 1.0.0.0"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Gray
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(461, 3)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Gray
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(33, 29)
        Me.GunaControlBox1.TabIndex = 2
        Me.GunaControlBox1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.FrameLauncher.My.Resources.Resources.daco_2
        Me.GunaPictureBox2.Location = New System.Drawing.Point(91, 131)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(314, 288)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 6
        Me.GunaPictureBox2.TabStop = False
        '
        'StartGame
        '
        Me.StartGame.Animated = True
        Me.StartGame.AnimationHoverSpeed = 0.07!
        Me.StartGame.AnimationSpeed = 0.03!
        Me.StartGame.BackColor = System.Drawing.Color.Transparent
        Me.StartGame.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StartGame.BorderColor = System.Drawing.Color.Black
        Me.StartGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartGame.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.StartGame.FocusedColor = System.Drawing.Color.Empty
        Me.StartGame.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartGame.ForeColor = System.Drawing.Color.White
        Me.StartGame.Image = Global.FrameLauncher.My.Resources.Resources.icons8_começar_50
        Me.StartGame.ImageSize = New System.Drawing.Size(30, 30)
        Me.StartGame.Location = New System.Drawing.Point(144, 425)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StartGame.OnHoverBorderColor = System.Drawing.Color.Black
        Me.StartGame.OnHoverForeColor = System.Drawing.Color.White
        Me.StartGame.OnHoverImage = Nothing
        Me.StartGame.OnPressedColor = System.Drawing.Color.Black
        Me.StartGame.Size = New System.Drawing.Size(160, 51)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "Start"
        Me.StartGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StopGame
        '
        Me.StopGame.Animated = True
        Me.StopGame.AnimationHoverSpeed = 0.07!
        Me.StopGame.AnimationSpeed = 0.03!
        Me.StopGame.BackColor = System.Drawing.Color.Transparent
        Me.StopGame.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StopGame.BorderColor = System.Drawing.Color.Black
        Me.StopGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopGame.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.StopGame.FocusedColor = System.Drawing.Color.Empty
        Me.StopGame.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopGame.ForeColor = System.Drawing.Color.White
        Me.StopGame.Image = Global.FrameLauncher.My.Resources.Resources.icons8_começar_50
        Me.StopGame.ImageSize = New System.Drawing.Size(30, 30)
        Me.StopGame.Location = New System.Drawing.Point(144, 425)
        Me.StopGame.Name = "StopGame"
        Me.StopGame.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StopGame.OnHoverBorderColor = System.Drawing.Color.Black
        Me.StopGame.OnHoverForeColor = System.Drawing.Color.White
        Me.StopGame.OnHoverImage = Nothing
        Me.StopGame.OnPressedColor = System.Drawing.Color.Black
        Me.StopGame.Size = New System.Drawing.Size(160, 51)
        Me.StopGame.TabIndex = 14
        Me.StopGame.Text = "Stop"
        Me.StopGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 531)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 531)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 541)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrameLauncher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StartGame As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GamePath As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PathAC As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Leitura As CheckBox
    Friend WithEvents StopGame As Guna.UI.WinForms.GunaButton
End Class
