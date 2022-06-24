Imports MySqlConnector

Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Establish Connection to Localhost Server
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=dcba123;database=myagriculture;persistsecurityinfo=True")
        conn.Open()

        'Make Query
        Dim query As String
        query = " select product_name,product_expirydate, product_price from products;"

        Dim Command As New MySqlCommand(query, conn)

        'Result is Stored Here
        Dim result As MySqlDataReader
        result = Command.ExecuteReader()

        Do While result.Read()
            Dim newL As New Label
            newL.Name = "tbNew"
            newL.Text = result.GetString(0)
            newL.Visible = True
            newL.AutoSize = True
            'Set location, size and so on if you like
            Me.TableLayoutPanel1.Controls.Add(newL)

            Dim newL2 As New Label
            newL2.Name = "tbNew"
            newL2.Text = result.GetString(1)
            newL2.Visible = True
            newL2.AutoSize = True
            'Set location, size and so on if you like
            Me.TableLayoutPanel1.Controls.Add(newL2)

            Dim newL3 As New Label
            newL3.Name = "tbNew"
            newL3.Text = result.GetString(2)
            newL3.Visible = True
            newL3.AutoSize = True
            'Set location, size and so on if you like
            Me.TableLayoutPanel1.Controls.Add(newL3)

            ComboBox1.Items.Add(newL.Text)
        Loop
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Establish Connection to Localhost Server
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=dcba123;database=myagriculture;persistsecurityinfo=True")
        conn.Open()

        'Make Query
        Dim query As String
        query = "delete from products where product_name = '" + ComboBox1.Text + "';"

        Dim Command As New MySqlCommand(query, conn)

        'Result is Stored Here
        Dim result As MySqlDataReader
        result = Command.ExecuteReader()

        MessageBox.Show("Product removed succesfully!")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Establish Connection to Localhost Server
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=dcba123;database=myagriculture;persistsecurityinfo=True")
        conn.Open()

        'Make Query
        Dim query As String
        query = "insert into products values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "');"


        Dim Command As New MySqlCommand(query, conn)

        'Result is Stored Here
        Dim result As MySqlDataReader
        result = Command.ExecuteReader()




        MessageBox.Show("Added Successfully!")
    End Sub
End Class