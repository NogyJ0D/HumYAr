Imports System.Data.SqlClient

Public Class FormEditar

    Dim Conexion As String = "Data Source=DESKTOP-DMG7JSV\SQLEXPRESS;Initial Catalog=humyar;Integrated Security=True"

    Private Sub FormEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarMaterias()
        GroupBox3.Hide()
        DGVLibros.Hide()

    End Sub
    ' Buscar la materia de la lista
    Private Sub CmbMateria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMateria.SelectedIndexChanged
        GroupBox3.Show()
        DGVLibros.Show()
        Label1.Text = CmbMateria.SelectedItem
        ActualizarLibros()
    End Sub
    ' Boton de agregar materia
    Private Sub BtnAMateria_Click(sender As Object, e As EventArgs) Handles BtnAMateria.Click

        Try
            Using CN As New SqlConnection(Conexion)
                CN.Open()
                Dim Adaptador As New SqlCommand($"INSERT INTO materias(nombre) VALUES('{InpAMateria.Text.ToUpper}')", CN)
                Adaptador.ExecuteNonQuery()
                MsgBox("MATERIA AGREGADA")
            End Using
        Catch ex As System.Data.SqlClient.SqlException
            InpAMateria.Text = ""
            MsgBox("La materia ya fue ingresada y no puede ser duplicada.")
        End Try

        InpAMateria.Text = ""
        ActualizarMaterias()

    End Sub
    ' Boton de actualizar lista de materias
    Private Sub BtnBActualizar_Click(sender As Object, e As EventArgs) Handles BtnBActualizar.Click

        ActualizarMaterias()

    End Sub
    ' Actualizar lista de materias
    Public Sub ActualizarMaterias()

        CmbMateria.Items.Clear()
        Using CN As New SqlConnection(Conexion)
            CN.Open()
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
        End Using

    End Sub

    Private Sub BtnALibro_Click(sender As Object, e As EventArgs) Handles BtnALibro.Click

        Dim Condicion As String = ""
        If RdbAmpliatorio.Checked Then
            Condicion = "Ampliatorio"
        ElseIf RdbObligatorio.Checked Then
            Condicion = "Obligatorio"
        End If

        If InpAAutor.Text <> "" And InpATitulo.Text <> "" And Condicion <> "" Then
            'Try
            Using CN As New SqlConnection(Conexion)
                CN.Open()
                Dim Adaptador As New SqlCommand($"INSERT INTO libros VALUES('{InpAAutor.Text}', '{InpATitulo.Text}', '{InpACapitulos.Text}', '{InpAEditorial.Text}', '{InpAAño.Text}', '{InpAPaginas.Text}', '{InpAUnidad.Text}', '{Condicion}','{Label1.Text}')", CN)
                Adaptador.ExecuteNonQuery()
                MsgBox("LIBRO INGRESADO")
                ActualizarLibros()

                InpAAutor.Text = ""
                InpATitulo.Text = ""
                InpACapitulos.Text = ""
                InpAEditorial.Text = ""
                InpAAño.Text = ""
                InpAPaginas.Text = ""
                InpAUnidad.Text = ""
            End Using
            'Catch ex As System.Data.SqlClient.SqlException
            'MsgBox("error")
            'End Try
        Else
            MsgBox("Error: uno de los datos ingresados (autor/título/obligatoriedad) no puede estar vacío.")
        End If

    End Sub
    ' Actualizar el DataGridView
    Public Sub ActualizarLibros()
        Using CN As New SqlConnection(Conexion)
            CN.Open()
            Dim Adaptador As New SqlDataAdapter($"SELECT * FROM libros WHERE Materia = '{Label1.Text}'", CN)
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
                    .Item(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Item(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Item(8).Visible = False
                End With
            End With
        End Using

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        FormLogin.Show()
        Me.Close()

    End Sub
End Class