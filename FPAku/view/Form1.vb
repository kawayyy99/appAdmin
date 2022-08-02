Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form1
    Dim Conn As New OleDb.OleDbConnection
    Dim dbProvider As String = "Provider = sqlexpress;"
    Dim dbSource As String = "Data Source = PerpusCRUD.sql;"
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim drLogin As SqlDataReader
        Dim CMDLogin As SqlCommand
        Dim SQL As String
        konekDB()
        SQL = "SELECT * FROM BIO " _
        + "WHERE USERNAME = '" & TextBox1.Text & "' " _
        + "And PASS = '" & TextBox2.Text & "'"
        CMDLogin = New SqlCommand
        CMDLogin.CommandType = CommandType.Text
        CMDLogin.Connection = konek
        CMDLogin.CommandText = SQL

        drLogin = CMDLogin.ExecuteReader()
        If drLogin.HasRows Then
            MsgBox("selamat datang Admin")
            'Lakukan sesuatu disini
            'misalnya menampilkan form admin
            Form2.Show()
        Else
            MsgBox("Nama User atau Password salah",
                   +vbCritical, "Password Salah")
        End If
        konek.Close()
        CMDLogin.Dispose()
        drLogin.Close()
    End Sub
End Class
