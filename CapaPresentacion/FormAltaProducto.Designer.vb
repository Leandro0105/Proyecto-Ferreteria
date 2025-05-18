<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaProducto
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
        Me.btnCerrarr = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSubrubro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioCosto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkProductoActivo = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.btnCerrarr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.btnCerrarr)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(347, 48)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnCerrarr
        '
        Me.btnCerrarr.Image = Global.CapaPresentacion.My.Resources.Resources.cerrar
        Me.btnCerrarr.Location = New System.Drawing.Point(307, 3)
        Me.btnCerrarr.Name = "btnCerrarr"
        Me.btnCerrarr.Size = New System.Drawing.Size(37, 37)
        Me.btnCerrarr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarr.TabIndex = 5
        Me.btnCerrarr.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = Global.CapaPresentacion.My.Resources.Resources.menos
        Me.btnMinimizar.Location = New System.Drawing.Point(264, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 37)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alta Productos"
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProducto.ForeColor = System.Drawing.Color.Black
        Me.lblIdProducto.Location = New System.Drawing.Point(153, 51)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(113, 25)
        Me.lblIdProducto.TabIndex = 6
        Me.lblIdProducto.Text = "Id Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Id Producto:"
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(112, 99)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(203, 21)
        Me.cboProveedor.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(18, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Proveedor:"
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(85, 135)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(230, 21)
        Me.cboMarca.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Marca:"
        '
        'cboRubro
        '
        Me.cboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(85, 170)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(230, 21)
        Me.cboRubro.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Rubro:"
        '
        'cboSubrubro
        '
        Me.cboSubrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubrubro.FormattingEnabled = True
        Me.cboSubrubro.Location = New System.Drawing.Point(102, 205)
        Me.cboSubrubro.Name = "cboSubrubro"
        Me.cboSubrubro.Size = New System.Drawing.Size(213, 21)
        Me.cboSubrubro.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Subrubro:"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(21, 265)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(294, 20)
        Me.txtCodigoBarras.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(18, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Código de Barras:"
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(21, 309)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(294, 20)
        Me.txtCodigoProveedor.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(18, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Código de Proveedor:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(21, 353)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(294, 20)
        Me.txtDescripcion.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(18, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 18)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Descripción:"
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Location = New System.Drawing.Point(21, 397)
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(294, 20)
        Me.txtPrecioCosto.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Precio de Costo:"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(21, 441)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(294, 20)
        Me.txtPrecioVenta.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(18, 420)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Precio de Venta:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(21, 485)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(294, 20)
        Me.txtStock.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(18, 464)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 18)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Stock:"
        '
        'chkProductoActivo
        '
        Me.chkProductoActivo.AutoSize = True
        Me.chkProductoActivo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProductoActivo.Location = New System.Drawing.Point(25, 518)
        Me.chkProductoActivo.Name = "chkProductoActivo"
        Me.chkProductoActivo.Size = New System.Drawing.Size(112, 19)
        Me.chkProductoActivo.TabIndex = 39
        Me.chkProductoActivo.Text = "Producto Activo"
        Me.chkProductoActivo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(51, 554)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 34)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(205, 554)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 34)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormAltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(347, 600)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chkProductoActivo)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPrecioCosto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodigoProveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSubrubro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboRubro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblIdProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAltaProducto"
        Me.Text = "FormAltaProducto"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.btnCerrarr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarr As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSubrubro As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigoProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioCosto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkProductoActivo As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
