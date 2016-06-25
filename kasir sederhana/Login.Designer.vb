<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.user = New System.Windows.Forms.Label()
        Me.ps = New System.Windows.Forms.Label()
        Me.masuk = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(36, 85)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(79, 16)
        Me.user.TabIndex = 0
        Me.user.Text = "Username"
        '
        'ps
        '
        Me.ps.AutoSize = True
        Me.ps.BackColor = System.Drawing.Color.Transparent
        Me.ps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ps.Location = New System.Drawing.Point(36, 120)
        Me.ps.Name = "ps"
        Me.ps.Size = New System.Drawing.Size(76, 16)
        Me.ps.TabIndex = 0
        Me.ps.Text = "Password"
        '
        'masuk
        '
        Me.masuk.BackColor = System.Drawing.Color.Black
        Me.masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masuk.ForeColor = System.Drawing.Color.Red
        Me.masuk.Location = New System.Drawing.Point(237, 181)
        Me.masuk.Name = "masuk"
        Me.masuk.Size = New System.Drawing.Size(75, 23)
        Me.masuk.TabIndex = 3
        Me.masuk.Text = "Masuk"
        Me.masuk.UseVisualStyleBackColor = False
        '
        'batal
        '
        Me.batal.BackColor = System.Drawing.Color.Black
        Me.batal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batal.ForeColor = System.Drawing.Color.Red
        Me.batal.Location = New System.Drawing.Point(148, 181)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(75, 23)
        Me.batal.TabIndex = 4
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.DarkTurquoise
        Me.password.Location = New System.Drawing.Point(148, 116)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.password.Size = New System.Drawing.Size(164, 20)
        Me.password.TabIndex = 2
        Me.password.Text = "triboy"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.DarkTurquoise
        Me.username.Location = New System.Drawing.Point(148, 81)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(164, 20)
        Me.username.TabIndex = 1
        Me.username.Text = "pransisco"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TRIBOY COMPUTER"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.kasir_sederhana.My.Resources.Resources.com
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 230)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.masuk)
        Me.Controls.Add(Me.ps)
        Me.Controls.Add(Me.user)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents ps As System.Windows.Forms.Label
    Friend WithEvents masuk As System.Windows.Forms.Button
    Friend WithEvents batal As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
