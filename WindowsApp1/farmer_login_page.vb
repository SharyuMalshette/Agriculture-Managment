Imports MySqlConnector

Public Class farmer_login_page
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Establish Connection to Localhost Server
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=dcba123;database=myagriculture;persistsecurityinfo=True")
        conn.Open()

        'Make Query
        Dim query As String
        query = " select password from farmers where username='" + TextBox1.Text + "';"

        Dim Command As New MySqlCommand(query, conn)

        'Result is Stored Here
        Dim result As MySqlDataReader
        result = Command.ExecuteReader()

        If (result.Read() = 0) Then
            MessageBox.Show("username OR password not found")
        Else
            If result.GetString(0) = TextBox2.Text Then
                Products.ShowDialog()
            Else
                MessageBox.Show("username OR password not found")
            End If
        End If




        'MsgBox("Data saved Successfully", MsgBoxStyle.MsgBoxRight, "Done")

        conn.Close()
    End Sub

    Private Sub farmer_login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class