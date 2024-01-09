Public Class Form1

    Dim username As String
    Dim password As String
    Public admin As Boolean


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim frm As Form = New Form2()

        username = txtUser.Text
        password = txtPassword.Text
        admin = False


        If username = "pracownik" And password = "pracownik" Then
            admin = True
            txtUser.Clear()
            txtPassword.Clear()
            frm.Show()
        ElseIf username = "klient" And password = "klient" Then
            txtUser.Clear()
            txtPassword.Clear()
            frm.Show()
        Else
            MsgBox("Złe dane, spróbuj ponownie", vbExclamation)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imgTitle.Image = Image.FromFile(".\img\bookshelf.jpg")
    End Sub
End Class
