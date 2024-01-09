<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNovels = New System.Windows.Forms.RadioButton()
        Me.btnScience = New System.Windows.Forms.RadioButton()
        Me.listGenre = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listAuthor = New System.Windows.Forms.ListBox()
        Me.listTitle = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBrowser = New System.Windows.Forms.TabPage()
        Me.imgCover = New System.Windows.Forms.PictureBox()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.saveNovels = New System.Windows.Forms.RadioButton()
        Me.saveScience = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabBrowser.SuspendLayout()
        CType(Me.imgCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Witaj, wybierz bibliotekę:"
        '
        'btnNovels
        '
        Me.btnNovels.AutoSize = True
        Me.btnNovels.Checked = True
        Me.btnNovels.Location = New System.Drawing.Point(197, 6)
        Me.btnNovels.Name = "btnNovels"
        Me.btnNovels.Size = New System.Drawing.Size(120, 24)
        Me.btnNovels.TabIndex = 3
        Me.btnNovels.TabStop = True
        Me.btnNovels.Text = "Beletrystyka"
        Me.btnNovels.UseVisualStyleBackColor = True
        '
        'btnScience
        '
        Me.btnScience.AutoSize = True
        Me.btnScience.Location = New System.Drawing.Point(323, 8)
        Me.btnScience.Name = "btnScience"
        Me.btnScience.Size = New System.Drawing.Size(80, 24)
        Me.btnScience.TabIndex = 4
        Me.btnScience.Text = "Nauka"
        Me.btnScience.UseVisualStyleBackColor = True
        '
        'listGenre
        '
        Me.listGenre.FormattingEnabled = True
        Me.listGenre.ItemHeight = 20
        Me.listGenre.Location = New System.Drawing.Point(11, 74)
        Me.listGenre.Name = "listGenre"
        Me.listGenre.Size = New System.Drawing.Size(165, 304)
        Me.listGenre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kategoria:"
        '
        'listAuthor
        '
        Me.listAuthor.FormattingEnabled = True
        Me.listAuthor.ItemHeight = 20
        Me.listAuthor.Location = New System.Drawing.Point(197, 87)
        Me.listAuthor.Name = "listAuthor"
        Me.listAuthor.Size = New System.Drawing.Size(239, 124)
        Me.listAuthor.TabIndex = 7
        '
        'listTitle
        '
        Me.listTitle.FormattingEnabled = True
        Me.listTitle.ItemHeight = 20
        Me.listTitle.Location = New System.Drawing.Point(197, 254)
        Me.listTitle.Name = "listTitle"
        Me.listTitle.Size = New System.Drawing.Size(239, 124)
        Me.listTitle.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Autor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tytuł:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBrowser)
        Me.TabControl1.Controls.Add(Me.tabEdit)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(923, 698)
        Me.TabControl1.TabIndex = 12
        '
        'tabBrowser
        '
        Me.tabBrowser.Controls.Add(Me.imgCover)
        Me.tabBrowser.Controls.Add(Me.listAuthor)
        Me.tabBrowser.Controls.Add(Me.Label1)
        Me.tabBrowser.Controls.Add(Me.btnNovels)
        Me.tabBrowser.Controls.Add(Me.btnScience)
        Me.tabBrowser.Controls.Add(Me.Label2)
        Me.tabBrowser.Controls.Add(Me.Label4)
        Me.tabBrowser.Controls.Add(Me.listGenre)
        Me.tabBrowser.Controls.Add(Me.Label3)
        Me.tabBrowser.Controls.Add(Me.listTitle)
        Me.tabBrowser.Location = New System.Drawing.Point(4, 29)
        Me.tabBrowser.Name = "tabBrowser"
        Me.tabBrowser.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBrowser.Size = New System.Drawing.Size(915, 665)
        Me.tabBrowser.TabIndex = 0
        Me.tabBrowser.Text = "Przeglądarka"
        Me.tabBrowser.UseVisualStyleBackColor = True
        '
        'imgCover
        '
        Me.imgCover.Location = New System.Drawing.Point(488, 51)
        Me.imgCover.Name = "imgCover"
        Me.imgCover.Size = New System.Drawing.Size(389, 526)
        Me.imgCover.TabIndex = 11
        Me.imgCover.TabStop = False
        '
        'tabEdit
        '
        Me.tabEdit.Controls.Add(Me.Label9)
        Me.tabEdit.Controls.Add(Me.btnDelete)
        Me.tabEdit.Controls.Add(Me.lblid)
        Me.tabEdit.Controls.Add(Me.btnUpdate)
        Me.tabEdit.Controls.Add(Me.Label8)
        Me.tabEdit.Controls.Add(Me.saveNovels)
        Me.tabEdit.Controls.Add(Me.saveScience)
        Me.tabEdit.Controls.Add(Me.btnAdd)
        Me.tabEdit.Controls.Add(Me.btnClear)
        Me.tabEdit.Controls.Add(Me.txtTitle)
        Me.tabEdit.Controls.Add(Me.Label5)
        Me.tabEdit.Controls.Add(Me.Label6)
        Me.tabEdit.Controls.Add(Me.Label7)
        Me.tabEdit.Controls.Add(Me.txtAuthor)
        Me.tabEdit.Controls.Add(Me.txtGenre)
        Me.tabEdit.Location = New System.Drawing.Point(4, 29)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEdit.Size = New System.Drawing.Size(1129, 665)
        Me.tabEdit.TabIndex = 1
        Me.tabEdit.Text = "Edytor"
        Me.tabEdit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "ID rekordu:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.Location = New System.Drawing.Point(305, 195)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 37)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Usuń"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(192, 145)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(34, 20)
        Me.lblid.TabIndex = 21
        Me.lblid.Text = "ID: "
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(163, 195)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(136, 37)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Zapisz zmiany"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Wybierz bibliotekę do zapisu:"
        '
        'saveNovels
        '
        Me.saveNovels.AutoSize = True
        Me.saveNovels.Checked = True
        Me.saveNovels.Location = New System.Drawing.Point(362, 56)
        Me.saveNovels.Name = "saveNovels"
        Me.saveNovels.Size = New System.Drawing.Size(120, 24)
        Me.saveNovels.TabIndex = 18
        Me.saveNovels.TabStop = True
        Me.saveNovels.Text = "Beletrystyka"
        Me.saveNovels.UseVisualStyleBackColor = True
        '
        'saveScience
        '
        Me.saveScience.AutoSize = True
        Me.saveScience.Location = New System.Drawing.Point(362, 86)
        Me.saveScience.Name = "saveScience"
        Me.saveScience.Size = New System.Drawing.Size(80, 24)
        Me.saveScience.TabIndex = 19
        Me.saveScience.Text = "Nauka"
        Me.saveScience.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(362, 128)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 37)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Dodaj pozycję"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(48, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 37)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Wyczyść"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(102, 100)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(212, 26)
        Me.txtTitle.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kategoria:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tytuł:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Autor:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(102, 58)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(212, 26)
        Me.txtAuthor.TabIndex = 1
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(102, 19)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(212, 26)
        Me.txtGenre.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 645)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "Welcome"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBrowser.ResumeLayout(False)
        Me.tabBrowser.PerformLayout()
        CType(Me.imgCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEdit.ResumeLayout(False)
        Me.tabEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNovels As RadioButton
    Friend WithEvents btnScience As RadioButton
    Friend WithEvents listGenre As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents listAuthor As ListBox
    Friend WithEvents listTitle As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBrowser As TabPage
    Friend WithEvents tabEdit As TabPage
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents saveNovels As RadioButton
    Friend WithEvents saveScience As RadioButton
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblid As Label
    Friend WithEvents imgCover As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label9 As Label
End Class
