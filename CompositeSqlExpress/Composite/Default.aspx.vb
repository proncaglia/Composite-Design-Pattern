Imports System.Data.SqlClient

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim lista As New List(Of Permiso)

        'Dim p1 As New Permiso
        'p1.Codigo = 1
        'p1.Descripcion = "Permiso 1"

        'For i = 0 To 10
        '    p1 = New Permiso
        '    p1.Codigo = i
        '    p1.Descripcion = "Permiso " & i
        '    lista.Add(p1)
        'Next

        'GridView1.DataSource = SqlDataSource1
        'GridView1.DataSource = lista
        'GridView1.DataBind()

        Dim xmlwriter As New Xml

        Dim archivo As String = "f:\users\pablo\documents\visual studio 2013\Projects\Composite\Composite\permisos.xml"



        Dim ds As New DataSet

        Dim conn As New SqlConnection(SqlDataSource1.ConnectionString)
        Dim adapter As New SqlDataAdapter("SELECT * FROM cliente", conn)
        adapter.Fill(ds, "XD")





        ' ds.ReadXml(archivo)

        'ds.Tables(0).Rows(0).BeginEdit()
        'ds.Tables(0).Rows(0).Delete()
        'ds.Tables(0).Rows(0).EndEdit()

        Dim dt As DataTable
        Dim dr As DataRow
        dt = ds.Tables(0)

        dr = dt.Rows(0)

        'dr.BeginEdit()
        'dr(0) = 200
        'dr.EndEdit()


        ' dr(1) = "Hey"

        ' dt.BeginInit()
        'dt.NewRow.Item(0) = dr
        ' dt.EndInit()

        'ds = dt.NewRow(3)

        'ds.Tables(0).NewRow()

        dr.BeginEdit()
        dr("nombre") = "EH"
        'dr(0) = 800
        'dr(1) = "Valor"
        dr.EndEdit()
        dr.AcceptChanges()

        



        GridView1.DataSource = ds
        GridView1.DataBind()

        'adapter.AcceptChangesDuringUpdate = True
        adapter.Update(ds.Tables(0))
        '  ds.Tables(0).AcceptChanges()

        ' ds.WriteXml(archivo)

    End Sub

End Class
