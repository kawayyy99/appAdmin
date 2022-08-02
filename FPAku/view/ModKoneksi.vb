Imports System.Data.SqlClient

Module ModKoneksi
    Public konek As SqlConnection
    Sub konekDB()
        Try
            konek = New SqlConnection _
                ("Data Source=KAWAYYY;Initial Catalog=PerpusCRUD;Integrated Security=True")
            konek.Open()
        Catch ex As Exception
            MsgBox("konek Kedatabase Bermasalah, " _
                   + "Periksa koneksi Jaringan Anda")
        End Try
    End Sub
End Module
