Imports System.Configuration
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=root;database=movies;persistsecurityinfo=True")
        conn.Open()
        Dim query As String
        query = " show databases; "
        Dim Command As New MySqlCommand(query, conn)
        Dim rd As MySqlDataReader
        rd = Command.ExecuteReader()
        MsgBox("Data saved Successfully", MsgBoxStyle.MsgBoxRight, "Done")
        conn.Close()
    End Sub
End Class
