Public Class Form2

    Dim dbConnect As System.Data.SqlClient.SqlConnection
    Dim data As New DataSet("books")
    Dim noRecord As Integer = 0
    Dim table As DataTable
    Dim row As DataRow
    Dim dbName As String
    Dim tableName As String
    Dim id As String


    Private Sub connect_to_db(dbName As String)
        Dim strConnect As String

        strConnect = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\" & dbName & ".mdf;Integrated Security=True"

        dbConnect = New System.Data.SqlClient.SqlConnection(strConnect)

        Try
            dbConnect.Open()
        Catch ex As Exception
            MessageBox.Show("Brak połączenia z bazą danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNovels_CheckedChanged(sender As Object, e As EventArgs) Handles btnNovels.CheckedChanged
        If btnNovels.Checked Then
            dbName = "Beletrystyka"
            connect_to_db(dbName)

            Dim strSQL As String

            data.Clear()

            strSQL = "SELECT genre FROM novels"

            Dim querySQL As New System.Data.SqlClient.SqlDataAdapter(strSQL, dbConnect)

            If dbConnect.State = ConnectionState.Open Then
                Try
                    querySQL.Fill(data, "books")
                    table = data.Tables("books")

                    listGenre.Items.Clear()
                    listAuthor.Items.Clear()
                    listTitle.Items.Clear()

                    For Each row As DataRow In table.Rows
                        If Not listGenre.Items.Contains(row.Field(Of String)(0)) Then
                            listGenre.Items.Add(row.Field(Of String)(0))
                        End If
                    Next

                Catch ex As Exception
                    MessageBox.Show("Błąd odczytu z bazy danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If

    End Sub

    Private Sub listGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listGenre.SelectedIndexChanged

        txtGenre.Text = listGenre.SelectedItem


        Dim strSQL As String

        data.Clear()

        If dbName = "Beletrystyka" Then
            tableName = "novels"
        Else
            tableName = "science"
        End If

        strSQL = "SELECT author FROM " & tableName & " WHERE genre='" & listGenre.SelectedItem & "'"

        Dim querySQL As New System.Data.SqlClient.SqlDataAdapter(strSQL, dbConnect)

        If dbConnect.State = ConnectionState.Open Then
            Try
                querySQL.Fill(data, "books")
                table = data.Tables("books")

                listAuthor.Items.Clear()
                listTitle.Items.Clear()

                For Each row As DataRow In table.Rows
                    listAuthor.Items.Add(row.Field(Of String)(1))
                Next

            Catch ex As Exception
                MessageBox.Show("Błąd odczytu z bazy danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub listAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listAuthor.SelectedIndexChanged

        txtAuthor.Text = listAuthor.SelectedItem
        Dim strSQL As String

        data.Clear()

        If dbName = "Beletrystyka" Then
            tableName = "novels"
        Else
            tableName = "science"
        End If

        strSQL = "SELECT title FROM " & tableName & " WHERE author='" & listAuthor.SelectedItem & "'"

        Dim querySQL As New System.Data.SqlClient.SqlDataAdapter(strSQL, dbConnect)

        If dbConnect.State = ConnectionState.Open Then
            Try
                querySQL.Fill(data, "books")
                table = data.Tables("books")

                listTitle.Items.Clear()

                For Each row As DataRow In table.Rows
                    If Not listTitle.Items.Contains(row.Field(Of String)(2)) Then
                        listTitle.Items.Add(row.Field(Of String)(2))
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show("Błąd odczytu z bazy danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub btnScience_CheckedChanged(sender As Object, e As EventArgs) Handles btnScience.CheckedChanged
        If btnScience.Checked Then
            dbName = "Science"
            connect_to_db(dbName)

            Dim strSQL As String

            data.Clear()

            strSQL = "SELECT genre FROM science"

            Dim querySQL As New System.Data.SqlClient.SqlDataAdapter(strSQL, dbConnect)

            If dbConnect.State = ConnectionState.Open Then
                Try
                    querySQL.Fill(data, "books")
                    table = data.Tables("books")

                    listGenre.Items.Clear()
                    listAuthor.Items.Clear()
                    listTitle.Items.Clear()

                    For Each row As DataRow In table.Rows
                        If Not listGenre.Items.Contains(row.Field(Of String)(0)) Then
                            listGenre.Items.Add(row.Field(Of String)(0))
                        End If
                    Next

                Catch ex As Exception
                    MessageBox.Show("Błąd odczytu z bazy danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.admin = True Then
            tabEdit.Enabled = True
        Else
            tabEdit.Enabled = False
        End If
    End Sub

    Private Sub listTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTitle.SelectedIndexChanged

        txtTitle.Text = listTitle.SelectedItem

        Try
            imgCover.Image = Image.FromFile(".\img\" & listTitle.SelectedItem & ".jpg")
        Catch ex As Exception
            imgCover.Image = Image.FromFile(".\img\brak.jpg")
        End Try

        Dim strSQL As String

        data.Clear()

        If dbName = "Beletrystyka" Then
            tableName = "novels"
        Else
            tableName = "science"
        End If

        strSQL = "SELECT id FROM " & tableName & " WHERE title='" & listTitle.SelectedItem & "'"
        Dim querySQL As New System.Data.SqlClient.SqlDataAdapter(strSQL, dbConnect)

        If dbConnect.State = ConnectionState.Open Then
            Try
                querySQL.Fill(data, "books")
                table = data.Tables("books")

                id = table.Rows(0)("id").ToString
                lblid.Text = id

            Catch ex As Exception
                lblid.Text = "Brak id"
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGenre.Clear()
        txtAuthor.Clear()
        txtTitle.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strRecord As String

        If txtGenre.Text.Length = 0 Then
            MessageBox.Show("Proszę uzupełnić brakujace dane", "Brak danych",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGenre.Focus()
            Exit Sub
        End If

        If txtAuthor.Text.Length = 0 Then
            MessageBox.Show("Proszę uzupełnić brakujace dane", "Brak danych",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAuthor.Focus()
            Exit Sub
        End If

        If txtTitle.Text.Length = 0 Then
            MessageBox.Show("Proszę uzupełnić brakujace dane", "Brak danych",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTitle.Focus()
            Exit Sub
        End If

        If saveNovels.Checked Then
            dbName = "Beletrystyka"
            tableName = "novels"
        ElseIf saveScience.Checked Then
            dbName = "Science"
            tableName = "science"
        End If

        strRecord = "INSERT INTO " & tableName & " (genre, author, title) VALUES ('" & txtGenre.Text & "','" & txtAuthor.Text & "','" & txtTitle.Text & "')"

        connect_to_db(dbName)

        Dim querySQL As New System.Data.SqlClient.SqlCommand(strRecord, dbConnect)

        If dbConnect.State = ConnectionState.Open Then
            Try
                querySQL.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Błąd podczas wpisywania danych", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                dbConnect.Close()
            End Try
            clearBrowser()
            txtTitle.Clear()
            txtAuthor.Clear()
            MessageBox.Show("Dane zostały wpisane do bazy", "Wpis udany",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strRecord As String

        If txtGenre.Text.Length = 0 Then
            MessageBox.Show("Proszę uzupełnić brakujace dane", "Brak danych",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGenre.Focus()
            Exit Sub
        End If

        If txtAuthor.Text.Length = 0 Then
            MessageBox.Show("Proszę uzupełnić brakujace dane", "Brak danych",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAuthor.Focus()
            Exit Sub
        End If

        If txtTitle.Text.Length = 0 Then
            MessageBox.Show("Proszę uzupełnić brakujace dane", "Brak danych",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTitle.Focus()
            Exit Sub
        End If

        If btnNovels.Checked Then
            dbName = "Beletrystyka"
            tableName = "novels"
        ElseIf btnScience.Checked Then
            dbName = "Science"
            tableName = "science"
        End If

        Dim recordID As Integer
        Try
            recordID = CInt(lblid.Text)
            strRecord = "UPDATE " & tableName & " SET genre='" & txtGenre.Text & "', author='" & txtAuthor.Text & "', title='" & txtTitle.Text & "' WHERE id=" & recordID
        Catch ex As Exception
            MessageBox.Show("Brak ID rekordu", "Błąd",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


        connect_to_db(dbName)

        Dim querySQL As New System.Data.SqlClient.SqlCommand(strRecord, dbConnect)

        If dbConnect.State = ConnectionState.Open Then
            Try
                querySQL.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Błąd podczas wpisywania danych", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                dbConnect.Close()
            End Try
            clearBrowser()
            MessageBox.Show("Wprowadzone zmiany zostały zapisane", "Wpis udany",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strRecord As String

        If btnNovels.Checked Then
            dbName = "Beletrystyka"
            tableName = "novels"
        ElseIf btnScience.Checked Then
            dbName = "Science"
            tableName = "science"
        End If

        Dim recordID As Integer
        Try
            recordID = CInt(lblid.Text)
            strRecord = "DELETE FROM " & tableName & " WHERE id=" & recordID
        Catch ex As Exception
            MessageBox.Show("Brak ID rekordu", "Błąd",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


        connect_to_db(dbName)

        Dim querySQL As New System.Data.SqlClient.SqlCommand(strRecord, dbConnect)

        If dbConnect.State = ConnectionState.Open Then
            Try
                querySQL.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Błąd podczas obsługi bazy danych", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                dbConnect.Close()
            End Try
            clearBrowser()
            MessageBox.Show("Rekord został usunięty", "Sukces",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub clearBrowser()
        btnNovels.Checked = False
        btnScience.Checked = False
        listGenre.Items.Clear()
        listAuthor.Items.Clear()
        listTitle.Items.Clear()
        imgCover.Image = Image.FromFile(".\img\bookshelf.jpg")
    End Sub

    'Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    '
    'End Sub
End Class