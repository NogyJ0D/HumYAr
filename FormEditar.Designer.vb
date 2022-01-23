<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbMateria = New System.Windows.Forms.ComboBox()
        Me.InpAMateria = New System.Windows.Forms.TextBox()
        Me.BtnAMateria = New System.Windows.Forms.Button()
        Me.BtnBActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RdbAmpliatorio = New System.Windows.Forms.RadioButton()
        Me.RdbObligatorio = New System.Windows.Forms.RadioButton()
        Me.BtnALibro = New System.Windows.Forms.Button()
        Me.InpAUnidad = New System.Windows.Forms.TextBox()
        Me.InpAPaginas = New System.Windows.Forms.TextBox()
        Me.InpAAño = New System.Windows.Forms.TextBox()
        Me.InpAEditorial = New System.Windows.Forms.TextBox()
        Me.InpACapitulos = New System.Windows.Forms.TextBox()
        Me.InpATitulo = New System.Windows.Forms.TextBox()
        Me.InpAAutor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVLibros = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbMateria
        '
        Me.CmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMateria.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.CmbMateria.FormattingEnabled = True
        Me.CmbMateria.Location = New System.Drawing.Point(8, 64)
        Me.CmbMateria.Name = "CmbMateria"
        Me.CmbMateria.Size = New System.Drawing.Size(312, 29)
        Me.CmbMateria.TabIndex = 1
        '
        'InpAMateria
        '
        Me.InpAMateria.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.InpAMateria.Location = New System.Drawing.Point(8, 24)
        Me.InpAMateria.MaxLength = 50
        Me.InpAMateria.Name = "InpAMateria"
        Me.InpAMateria.Size = New System.Drawing.Size(208, 29)
        Me.InpAMateria.TabIndex = 2
        '
        'BtnAMateria
        '
        Me.BtnAMateria.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.BtnAMateria.Location = New System.Drawing.Point(224, 24)
        Me.BtnAMateria.Name = "BtnAMateria"
        Me.BtnAMateria.Size = New System.Drawing.Size(152, 32)
        Me.BtnAMateria.TabIndex = 3
        Me.BtnAMateria.Text = "Agregar Materia"
        Me.BtnAMateria.UseVisualStyleBackColor = True
        '
        'BtnBActualizar
        '
        Me.BtnBActualizar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.BtnBActualizar.Location = New System.Drawing.Point(328, 64)
        Me.BtnBActualizar.Name = "BtnBActualizar"
        Me.BtnBActualizar.Size = New System.Drawing.Size(48, 32)
        Me.BtnBActualizar.TabIndex = 4
        Me.BtnBActualizar.Text = "Act"
        Me.BtnBActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InpAMateria)
        Me.GroupBox1.Controls.Add(Me.BtnBActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnAMateria)
        Me.GroupBox1.Controls.Add(Me.CmbMateria)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdbAmpliatorio)
        Me.GroupBox3.Controls.Add(Me.RdbObligatorio)
        Me.GroupBox3.Controls.Add(Me.BtnALibro)
        Me.GroupBox3.Controls.Add(Me.InpAUnidad)
        Me.GroupBox3.Controls.Add(Me.InpAPaginas)
        Me.GroupBox3.Controls.Add(Me.InpAAño)
        Me.GroupBox3.Controls.Add(Me.InpAEditorial)
        Me.GroupBox3.Controls.Add(Me.InpACapitulos)
        Me.GroupBox3.Controls.Add(Me.InpATitulo)
        Me.GroupBox3.Controls.Add(Me.InpAAutor)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 312)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'RdbAmpliatorio
        '
        Me.RdbAmpliatorio.AutoSize = True
        Me.RdbAmpliatorio.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAmpliatorio.Location = New System.Drawing.Point(240, 144)
        Me.RdbAmpliatorio.Name = "RdbAmpliatorio"
        Me.RdbAmpliatorio.Size = New System.Drawing.Size(115, 25)
        Me.RdbAmpliatorio.TabIndex = 18
        Me.RdbAmpliatorio.TabStop = True
        Me.RdbAmpliatorio.Text = "Ampliatorio"
        Me.RdbAmpliatorio.UseVisualStyleBackColor = True
        '
        'RdbObligatorio
        '
        Me.RdbObligatorio.AutoSize = True
        Me.RdbObligatorio.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbObligatorio.Location = New System.Drawing.Point(128, 144)
        Me.RdbObligatorio.Name = "RdbObligatorio"
        Me.RdbObligatorio.Size = New System.Drawing.Size(112, 25)
        Me.RdbObligatorio.TabIndex = 17
        Me.RdbObligatorio.TabStop = True
        Me.RdbObligatorio.Text = "Obligatorio"
        Me.RdbObligatorio.UseVisualStyleBackColor = True
        '
        'BtnALibro
        '
        Me.BtnALibro.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.BtnALibro.Location = New System.Drawing.Point(248, 272)
        Me.BtnALibro.Name = "BtnALibro"
        Me.BtnALibro.Size = New System.Drawing.Size(136, 32)
        Me.BtnALibro.TabIndex = 5
        Me.BtnALibro.Text = "Agregar libro"
        Me.BtnALibro.UseVisualStyleBackColor = True
        '
        'InpAUnidad
        '
        Me.InpAUnidad.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpAUnidad.Location = New System.Drawing.Point(96, 272)
        Me.InpAUnidad.MaxLength = 10
        Me.InpAUnidad.Name = "InpAUnidad"
        Me.InpAUnidad.Size = New System.Drawing.Size(144, 27)
        Me.InpAUnidad.TabIndex = 16
        '
        'InpAPaginas
        '
        Me.InpAPaginas.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpAPaginas.Location = New System.Drawing.Point(96, 240)
        Me.InpAPaginas.MaxLength = 20
        Me.InpAPaginas.Name = "InpAPaginas"
        Me.InpAPaginas.Size = New System.Drawing.Size(288, 27)
        Me.InpAPaginas.TabIndex = 15
        '
        'InpAAño
        '
        Me.InpAAño.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpAAño.Location = New System.Drawing.Point(96, 208)
        Me.InpAAño.MaxLength = 10
        Me.InpAAño.Name = "InpAAño"
        Me.InpAAño.Size = New System.Drawing.Size(288, 27)
        Me.InpAAño.TabIndex = 14
        '
        'InpAEditorial
        '
        Me.InpAEditorial.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpAEditorial.Location = New System.Drawing.Point(96, 176)
        Me.InpAEditorial.MaxLength = 70
        Me.InpAEditorial.Name = "InpAEditorial"
        Me.InpAEditorial.Size = New System.Drawing.Size(288, 27)
        Me.InpAEditorial.TabIndex = 13
        '
        'InpACapitulos
        '
        Me.InpACapitulos.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpACapitulos.Location = New System.Drawing.Point(96, 112)
        Me.InpACapitulos.MaxLength = 100
        Me.InpACapitulos.Name = "InpACapitulos"
        Me.InpACapitulos.Size = New System.Drawing.Size(288, 27)
        Me.InpACapitulos.TabIndex = 12
        '
        'InpATitulo
        '
        Me.InpATitulo.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpATitulo.Location = New System.Drawing.Point(96, 80)
        Me.InpATitulo.MaxLength = 100
        Me.InpATitulo.Name = "InpATitulo"
        Me.InpATitulo.Size = New System.Drawing.Size(288, 27)
        Me.InpATitulo.TabIndex = 11
        '
        'InpAAutor
        '
        Me.InpAAutor.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!)
        Me.InpAAutor.Location = New System.Drawing.Point(96, 48)
        Me.InpAAutor.MaxLength = 60
        Me.InpAAutor.Name = "InpAAutor"
        Me.InpAAutor.Size = New System.Drawing.Size(288, 27)
        Me.InpAAutor.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Unidad (I/VI)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Páginas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Editorial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Capítulos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Título"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Autor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MATERIA"
        '
        'DGVLibros
        '
        Me.DGVLibros.AllowUserToAddRows = False
        Me.DGVLibros.AllowUserToDeleteRows = False
        Me.DGVLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLibros.Location = New System.Drawing.Point(400, 0)
        Me.DGVLibros.Name = "DGVLibros"
        Me.DGVLibros.RowHeadersVisible = False
        Me.DGVLibros.Size = New System.Drawing.Size(818, 487)
        Me.DGVLibros.TabIndex = 8
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(0, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(72, 24)
        Me.BtnSalir.TabIndex = 9
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FormEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 489)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DGVLibros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(1166, 481)
        Me.Name = "FormEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbMateria As ComboBox
    Friend WithEvents InpAMateria As TextBox
    Friend WithEvents BtnAMateria As Button
    Friend WithEvents BtnBActualizar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnALibro As Button
    Friend WithEvents InpAUnidad As TextBox
    Friend WithEvents InpAPaginas As TextBox
    Friend WithEvents InpAAño As TextBox
    Friend WithEvents InpAEditorial As TextBox
    Friend WithEvents InpACapitulos As TextBox
    Friend WithEvents InpATitulo As TextBox
    Friend WithEvents InpAAutor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVLibros As DataGridView
    Friend WithEvents BtnSalir As Button
    Friend WithEvents RdbAmpliatorio As RadioButton
    Friend WithEvents RdbObligatorio As RadioButton
End Class
