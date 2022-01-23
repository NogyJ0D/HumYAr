Imports System.Data.SqlClient
Public Class FormLeer

    Public Conexion As String = "Data Source=DESKTOP-DMG7JSV\SQLEXPRESS;Initial Catalog=humyar;Integrated Security=True"
    Dim CN As New SqlConnection(Conexion)

    Private Sub FormLeer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarMaterias()
        CmbCondicion.SelectedIndex = 0

    End Sub
    Public Sub ActualizarMaterias()

        CmbMateria.Items.Clear()

        Dim Adaptador As New SqlDataAdapter($"SELECT nombre FROM materias", CN)
        Dim DS As New DataSet
        Adaptador.Fill(DS, "Datos")

        If DS.Tables("Datos").Rows.Count > 0 Then
            Dim Cont As Integer = 0
            For Each Row In DS.Tables("Datos").Rows
                CmbMateria.Items.Add(DS.Tables("Datos").Rows(Cont).Item(0).ToString)
                Cont += 1
            Next
            CmbMateria.SelectedIndex = 0
        End If

    End Sub
    Private Sub CmbMateria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMateria.SelectedIndexChanged

        CmbUnidad.Items.Clear()

        Dim Adaptador As New SqlDataAdapter($"SELECT DISTINCT unidad FROM libros WHERE materia = '{CmbMateria.SelectedItem}'", CN)
        Dim DS As New DataSet
        Adaptador.Fill(DS, "Datos")

        If DS.Tables("Datos").Rows.Count > 0 Then
            Dim Cont As Integer = 0
            For Each Row In DS.Tables("Datos").Rows
                CmbUnidad.Items.Add(DS.Tables("Datos").Rows(Cont).Item(0).ToString)
                Cont += 1
            Next
            CmbUnidad.SelectedIndex = 0
        End If

    End Sub
    Private Sub CmbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUnidad.SelectedIndexChanged

        BuscarLibros()

    End Sub
    Private Sub CmbCondicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCondicion.SelectedIndexChanged

        BuscarLibros()

    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        BuscarLibros()

    End Sub
    Public Sub BuscarLibros()

        Dim Condicion As String = CmbCondicion.SelectedItem

        Dim Adaptador As New SqlDataAdapter($"SELECT * FROM libros WHERE materia = '{CmbMateria.SelectedItem}' and unidad = '{CmbUnidad.SelectedItem}' and condicion = '{CmbCondicion.SelectedItem}'", CN)
        Dim DS As New DataSet
        Adaptador.Fill(DS, "Datos")
        With DGVLibros
            .DataSource = DS.Tables("Datos")
            With .Columns
                .Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Item(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Item(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Item(6).Visible = False
                .Item(7).Visible = False
                .Item(8).Visible = False
            End With
        End With

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        FormLogin.Show()
        Me.Close()

    End Sub

End Class