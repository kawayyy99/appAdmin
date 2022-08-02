Imports System.Data.SqlClient

Public Class Form2
    Public DataBaru As Boolean
    Private Sub jalankansql(ByVal sQl As String)
        Dim SQLCmd As New SqlCommand
        konekDB()
        Try
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQl
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
            MsgBox("Data Sudah Disimpan", vbInformation)
        Catch ex As Exception
            MsgBox("Tidak Bisa Menyimpan " _
                   + "data ke Server" & ex.Message)
        End Try
    End Sub

    Sub TampilkanData()
        konekDB()
        Dim dA As SqlDataAdapter = New SqlDataAdapter _
            ("SELECT USERNAME,NAMA_ADMIN,PASS FROM BIO", konek)
        Dim dS As DataSet = New DataSet
        dS.Clear()
        dA.Fill(dS, "BIO")
        DataGridView1.DataSource = (dS.Tables("BIO"))
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub isiTextBox(ByVal x As Integer)
        Try
            TextBox1.Text = DataGridView1.Rows(x).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(x).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(x).Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataBaru = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpusCRUDDataSet.BIO' table. You can move, or remove it, as needed.
        Me.BIOTableAdapter.Fill(Me.PerpusCRUDDataSet.BIO)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataBaru = False
        isiTextBox(e.RowIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String
        Dim simpan As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then Exit Sub
        If DataBaru Then
            pesan = MsgBox("Apakah Anda Yakin Data Akan " _
                           + "ditambahkan ke Database ?",
                           vbYesNo + vbInformation, "Perhatian")
            If pesan = vbYesNo Then
                Exit Sub
            End If
            simpan = "INSERT INTO BIO(USERNAME,NAMA_ADMIN,PASS)" _
            + "VALUES ('" & TextBox1.Text & "'," _
            + "'" & TextBox2.Text & "'," _
            + "'" & TextBox3.Text & "') "
        Else
            pesan = MsgBox("Anda yakin data ini " _
                           + "akan di update ?",
                           vbYesNo + vbInformation, "Perhatian")
            If pesan = vbYesNo Then
                Exit Sub
            End If
            simpan = "UPDATE BIO SET " _
                + "NAMA_ADMIN = '" & TextBox2.Text & "'," _
                + "PASS = '" & TextBox3.Text & "'" _
                + "WHERE USERNAME = '" & TextBox1.Text & "'"
        End If
        jalankansql(simpan)
        Me.Cursor = Cursors.WaitCursor
        TampilkanData()
        isiTextBox(0)
        Me.Cursor = Cursors.Default
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim HapusData As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin " _
                       + "akan menghapus Data pada server .. " _
                       + TextBox2.Text, vbExclamation + vbYesNo,
                       "perhatian")
        If pesan = vbNo Then Exit Sub
        HapusData = "DELETE FROM BIO WHERE USERNAME='" & TextBox1.Text & "'"
        jalankansql(HapusData)
        Me.Cursor = Cursors.WaitCursor
        DataGridView1.Refresh()
        TampilkanData()
        isiTextBox(0)
        Me.Cursor = Cursors.Default
    End Sub
End Class