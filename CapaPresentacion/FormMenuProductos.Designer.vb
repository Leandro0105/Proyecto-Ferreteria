<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelInfo2 = New System.Windows.Forms.Panel()
        Me.lblProductosInactivos = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconoHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelInfo3 = New System.Windows.Forms.Panel()
        Me.lblProductoMasVendido = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelInfo1 = New System.Windows.Forms.Panel()
        Me.lblTotalProductos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnActualizarListaPrecios = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnActualizarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListadoProductos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgvListadoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSuperior.TabIndex = 2
        '
        'PanelInfo2
        '
        Me.PanelInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo2.Controls.Add(Me.lblProductosInactivos)
        Me.PanelInfo2.Controls.Add(Me.Panel4)
        Me.PanelInfo2.Location = New System.Drawing.Point(226, 55)
        Me.PanelInfo2.Name = "PanelInfo2"
        Me.PanelInfo2.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo2.TabIndex = 4
        '
        'lblProductosInactivos
        '
        Me.lblProductosInactivos.AutoSize = True
        Me.lblProductosInactivos.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductosInactivos.ForeColor = System.Drawing.Color.White
        Me.lblProductosInactivos.Location = New System.Drawing.Point(64, 41)
        Me.lblProductosInactivos.Name = "lblProductosInactivos"
        Me.lblProductosInactivos.Size = New System.Drawing.Size(30, 32)
        Me.lblProductosInactivos.TabIndex = 1
        Me.lblProductosInactivos.Text = "5"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 29)
        Me.Panel4.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Inactivos"
        '
        'IconoHome
        '
        Me.IconoHome.ActiveColor = System.Drawing.Color.Black
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
        Me.PanelInfo3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelInfo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo3.Controls.Add(Me.lblProductoMasVendido)
        Me.PanelInfo3.Controls.Add(Me.Panel3)
        Me.PanelInfo3.Location = New System.Drawing.Point(410, 54)
        Me.PanelInfo3.Name = "PanelInfo3"
        Me.PanelInfo3.Size = New System.Drawing.Size(205, 98)
        Me.PanelInfo3.TabIndex = 2
        '
        'lblProductoMasVendido
        '
        Me.lblProductoMasVendido.AutoSize = True
        Me.lblProductoMasVendido.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoMasVendido.ForeColor = System.Drawing.Color.White
        Me.lblProductoMasVendido.Location = New System.Drawing.Point(17, 37)
        Me.lblProductoMasVendido.Name = "lblProductoMasVendido"
        Me.lblProductoMasVendido.Size = New System.Drawing.Size(173, 46)
        Me.lblProductoMasVendido.TabIndex = 2
        Me.lblProductoMasVendido.Text = "CEMENTO X 50KG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   LOMA NEGRA"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(205, 29)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Producto Mas Vendido"
        '
        'PanelInfo1
        '
        Me.PanelInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo1.Controls.Add(Me.lblTotalProductos)
        Me.PanelInfo1.Controls.Add(Me.Panel1)
        Me.PanelInfo1.Location = New System.Drawing.Point(26, 57)
        Me.PanelInfo1.Name = "PanelInfo1"
        Me.PanelInfo1.Size = New System.Drawing.Size(177, 98)
        Me.PanelInfo1.TabIndex = 0
        '
        'lblTotalProductos
        '
        Me.lblTotalProductos.AutoSize = True
        Me.lblTotalProductos.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProductos.ForeColor = System.Drawing.Color.White
        Me.lblTotalProductos.Location = New System.Drawing.Point(71, 41)
        Me.lblTotalProductos.Name = "lblTotalProductos"
        Me.lblTotalProductos.Size = New System.Drawing.Size(30, 32)
        Me.lblTotalProductos.TabIndex = 1
        Me.lblTotalProductos.Text = "5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total de Productos"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnActualizarListaPrecios)
        Me.Panel2.Controls.Add(Me.btnInventario)
        Me.Panel2.Controls.Add(Me.btnEliminarProducto)
        Me.Panel2.Controls.Add(Me.btnActualizarProducto)
        Me.Panel2.Controls.Add(Me.btnAgregarProducto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 270)
        Me.Panel2.TabIndex = 3
        '
        'btnActualizarListaPrecios
        '
        Me.btnActualizarListaPrecios.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnActualizarListaPrecios.FlatAppearance.BorderSize = 0
        Me.btnActualizarListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarListaPrecios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarListaPrecios.ForeColor = System.Drawing.Color.White
        Me.btnActualizarListaPrecios.Location = New System.Drawing.Point(29, 220)
        Me.btnActualizarListaPrecios.Name = "btnActualizarListaPrecios"
        Me.btnActualizarListaPrecios.Size = New System.Drawing.Size(159, 41)
        Me.btnActualizarListaPrecios.TabIndex = 5
        Me.btnActualizarListaPrecios.Text = "Actualizar con Lista de Precios"
        Me.btnActualizarListaPrecios.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Location = New System.Drawing.Point(29, 178)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(159, 36)
        Me.btnInventario.TabIndex = 4
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = False
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarProducto.Location = New System.Drawing.Point(29, 136)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(159, 36)
        Me.btnEliminarProducto.TabIndex = 3
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = False
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnActualizarProducto.FlatAppearance.BorderSize = 0
        Me.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProducto.ForeColor = System.Drawing.Color.White
        Me.btnActualizarProducto.Location = New System.Drawing.Point(29, 94)
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(159, 36)
        Me.btnActualizarProducto.TabIndex = 2
        Me.btnActualizarProducto.Text = "Actualizar"
        Me.btnActualizarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProducto.Location = New System.Drawing.Point(29, 52)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(159, 36)
        Me.btnAgregarProducto.TabIndex = 1
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.Label7)
        Me.PanelContenedor.Controls.Add(Me.dgvListadoProductos)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(228, 190)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(412, 270)
        Me.PanelContenedor.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(184, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Listado de Productos"
        '
        'dgvListadoProductos
        '
        Me.dgvListadoProductos.AllowUserToAddRows = False
        Me.dgvListadoProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvListadoProductos.Location = New System.Drawing.Point(16, 54)
        Me.dgvListadoProductos.Name = "dgvListadoProductos"
        Me.dgvListadoProductos.RowHeadersVisible = False
        Me.dgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoProductos.Size = New System.Drawing.Size(384, 204)
        Me.dgvListadoProductos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Costo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Venta"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'FormMenuProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(640, 460)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuProductos"
        Me.Text = "FormMenuProductos"
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
        CType(Me.dgvListadoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelInfo2 As Panel
    Friend WithEvents lblProductosInactivos As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents IconoHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelInfo3 As Panel
    Friend WithEvents lblProductoMasVendido As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelInfo1 As Panel
    Friend WithEvents lblTotalProductos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnActualizarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvListadoProductos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnActualizarListaPrecios As Button
    Friend WithEvents btnInventario As Button
End Class
