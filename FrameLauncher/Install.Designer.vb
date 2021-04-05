<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Install
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Install))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.PathProgress = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel1.Controls.Add(Me.PathProgress)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaControlBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Location = New System.Drawing.Point(1, 12)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(399, 190)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(123, 170)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(153, 13)
        Me.GunaLabel4.TabIndex = 8
        Me.GunaLabel4.Text = "Created by Capetalista#3310"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(70, 123)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(34, 15)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "Path:"
        '
        'PathProgress
        '
        Me.PathProgress.BorderColor = System.Drawing.Color.Black
        Me.PathProgress.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.PathProgress.IdleColor = System.Drawing.Color.Gainsboro
        Me.PathProgress.Location = New System.Drawing.Point(110, 128)
        Me.PathProgress.Name = "PathProgress"
        Me.PathProgress.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PathProgress.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PathProgress.Size = New System.Drawing.Size(218, 10)
        Me.PathProgress.TabIndex = 5
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(123, 87)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(153, 20)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Preparando o sistema"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Gray
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(363, 5)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Gray
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(33, 29)
        Me.GunaControlBox1.TabIndex = 3
        Me.GunaControlBox1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(127, 37)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(144, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "FrameLauncher"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, -3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(399, 14)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.TabStop = True
        '
        'Install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 204)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Install"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Install"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PathProgress As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
