<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLeer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmbMateria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbUnidad = New System.Windows.Forms.ComboBox()
        Me.DGVLibros = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbCondicion = New System.Windows.Forms.ComboBox()
        CType(Me.DGVLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbMateria
        '
        Me.CmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMateria.FormattingEnabled = True
        Me.CmbMateria.Location = New System.Drawing.Point(80, 8)
        Me.CmbMateria.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CmbMateria.Name = "CmbMateria"
        Me.CmbMateria.Size = New System.Drawing.Size(248, 29)
        Me.CmbMateria.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Materia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unidad"
        '
        'CmbUnidad
        '
        Me.CmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUnidad.FormattingEnabled = True
        Me.CmbUnidad.Location = New System.Drawing.Point(408, 8)
        Me.CmbUnidad.Margin = New System.Windows.Forms.Padding(5)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.Size = New System.Drawing.Size(136, 29)
        Me.CmbUnidad.TabIndex = 2
        '
        'DGVLibros
        '
        Me.DGVLibros.AllowUserToAddRows = False
        Me.DGVLibros.AllowUserToDeleteRows = False
        Me.DGVLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLibros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVLibros.Location = New System.Drawing.Point(0, 48)
        Me.DGVLibros.Name = "DGVLibros"
        Me.DGVLibros.RowHeadersVisible = False
        Me.DGVLibros.Size = New System.Drawing.Size(976, 348)
        Me.DGVLibros.TabIndex = 9
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(904, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(72, 24)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(800, 8)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(80, 32)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Condición"
        '
        'CmbCondicion
        '
        Me.CmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCondicion.FormattingEnabled = True
        Me.CmbCondicion.Items.AddRange(New Object() {"Obligatorio", "Ampliatorio"})
        Me.CmbCondicion.Location = New System.Drawing.Point(640, 8)
        Me.CmbCondicion.Margin = New System.Windows.Forms.Padding(5)
        Me.CmbCondicion.Name = "CmbCondicion"
        Me.CmbCondicion.Size = New System.Drawing.Size(152, 29)
        Me.CmbCondicion.TabIndex = 12
        '
        'FormLeer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 396)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbCondicion)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DGVLibros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbUnidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbMateria)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "FormLeer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leer Programa"
        CType(Me.DGVLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbMateria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbUnidad As ComboBox
    Friend WithEvents DGVLibros As DataGridView
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbCondicion As ComboBox
End Class
