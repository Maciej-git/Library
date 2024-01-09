<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgTitle = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.imgTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(510, 168)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(208, 26)
        Me.txtUser.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(510, 222)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(208, 26)
        Me.txtPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(567, 271)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(87, 38)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Użytkownik:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasło:"
        '
        'imgTitle
        '
        Me.imgTitle.Location = New System.Drawing.Point(53, 80)
        Me.imgTitle.Name = "imgTitle"
        Me.imgTitle.Size = New System.Drawing.Size(352, 298)
        Me.imgTitle.TabIndex = 5
        Me.imgTitle.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(494, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Witaj w Bibliotece!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.imgTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.imgTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imgTitle As PictureBox
    Friend WithEvents Label3 As Label
End Class
