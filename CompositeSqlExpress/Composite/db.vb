Imports System.Data.SqlClient

Public Class db
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Public Sub crearComando(ByVal sql As String)
        Dim strCon As String = ""
        con = New SqlConnection(strCon)
        cmd = New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Connection = con
    End Sub

    Public Function ejecutarTabla() As DataSet
        Dim Tabla As New DataSet
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        adapter.Fill(Tabla)
        Return Tabla
    End Function


End Class
