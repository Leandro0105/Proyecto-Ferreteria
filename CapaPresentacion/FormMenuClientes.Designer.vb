<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuClientes
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelInfo2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconoHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelInfo3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelInfo1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.dgvListadoClientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInfo2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.IconoHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfo3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelInfo1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.dgvListadoClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.PanelInfo2)
        Me.PanelSuperior.Controls.Add(Me.IconoHome)
        Me.PanelSuperior.Controls.Add(Me.PanelInfo3)
        Me.PanelSuperior.Controls.Add(Me.PanelInfo1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(640, 190)
        Me.PanelSuperior.TabIndex = 1
        '
        'PanelInfo2
        '
        Me.PanelInfo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo2.Controls.Add(Me.Label2)
        Me.PanelInfo2.Controls.Add(Me.Panel4)
        Me.PanelInfo2.Location = New System.Drawing.Point(239, 55)
        Me.PanelInfo2.Name = "PanelInfo2"
        Me.PanelInfo2.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "5"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(162, 29)
        Me.Panel4.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Activos"
        '
        'IconoHome
        '
        Me.IconoHome.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.IconoHome.BackColor = System.Drawing.Color.Transparent
        Me.IconoHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconoHome.InActiveColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.IconoHome.Location = New System.Drawing.Point(5, 5)
        Me.IconoHome.Name = "IconoHome"
        Me.IconoHome.Size = New System.Drawing.Size(46, 40)
        Me.IconoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoHome.TabIndex = 3
        Me.IconoHome.TabStop = False
        '
        'PanelInfo3
        '
        Me.PanelInfo3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelInfo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo3.Controls.Add(Me.Label6)
        Me.PanelInfo3.Controls.Add(Me.Panel3)
        Me.PanelInfo3.Location = New System.Drawing.Point(438, 54)
        Me.PanelInfo3.Name = "PanelInfo3"
        Me.PanelInfo3.Size = New System.Drawing.Size(182, 98)
        Me.PanelInfo3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 64)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Consumidor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 29)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente Mas Frecuente"
        '
        'PanelInfo1
        '
        Me.PanelInfo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo1.Controls.Add(Me.Label4)
        Me.PanelInfo1.Controls.Add(Me.Panel1)
        Me.PanelInfo1.Location = New System.Drawing.Point(41, 55)
        Me.PanelInfo1.Name = "PanelInfo1"
        Me.PanelInfo1.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(71, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total de Clientes"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminarCliente)
        Me.Panel2.Controls.Add(Me.btnModificarCliente)
        Me.Panel2.Controls.Add(Me.btnAgregarCliente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 270)
        Me.Panel2.TabIndex = 2
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEliminarCliente.FlatAppearance.BorderSize = 0
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCliente.Location = New System.Drawing.Point(41, 166)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(122, 36)
        Me.btnEliminarCliente.TabIndex = 2
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnModificarCliente.FlatAppearance.BorderSize = 0
        Me.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.ForeColor = System.Drawing.Color.White
        Me.btnModificarCliente.Location = New System.Drawing.Point(41, 115)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(122, 36)
        Me.btnModificarCliente.TabIndex = 1
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAgregarCliente.FlatAppearance.BorderSize = 0
        Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCliente.Location = New System.Drawing.Point(41, 66)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(122, 36)
        Me.btnAgregarCliente.TabIndex = 0
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.dgvListadoClientes)
        Me.PanelContenedor.Controls.Add(Me.Label7)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(209, 190)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(431, 270)
        Me.PanelContenedor.TabIndex = 3
        '
        'dgvListadoClientes
        '
        Me.dgvListadoClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListadoClientes.Location = New System.Drawing.Point(30, 40)
        Me.dgvListadoClientes.Name = "dgvListadoClientes"
        Me.dgvListadoClientes.RowHeadersVisible = False
        Me.dgvListadoClientes.Size = New System.Drawing.Size(364, 202)
        Me.dgvListadoClientes.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Condicion Fiscal"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Listado de Clientes"
        '
        'FormMenuClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(640, 460)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuClientes"
        Me.Text = "FormMenuClientes"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInfo2.ResumeLayout(False)
        Me.PanelInfo2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IconoHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfo3.ResumeLayout(False)
        Me.PanelInfo3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelInfo1.ResumeLayout(False)
        Me.PanelInfo1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.dgvListadoClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelInfo2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents IconoHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelInfo3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelInfo1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents dgvListadoClientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
