﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuVentas
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
        Me.btnCondionesComerciales = New System.Windows.Forms.Button()
        Me.btnFormasdePago = New System.Windows.Forms.Button()
        Me.btnCobranzas = New System.Windows.Forms.Button()
        Me.btnDevoluciones = New System.Windows.Forms.Button()
        Me.btnArqueoCaja = New System.Windows.Forms.Button()
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListadoCondCom = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgvListadoCondCom, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSuperior.Size = New System.Drawing.Size(640, 144)
        Me.PanelSuperior.TabIndex = 2
        '
        'PanelInfo2
        '
        Me.PanelInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo2.Controls.Add(Me.Label2)
        Me.PanelInfo2.Controls.Add(Me.Panel4)
        Me.PanelInfo2.Location = New System.Drawing.Point(234, 43)
        Me.PanelInfo2.Name = "PanelInfo2"
        Me.PanelInfo2.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "13"
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
        Me.Label5.Location = New System.Drawing.Point(39, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Anuladas"
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
        Me.PanelInfo3.Controls.Add(Me.Label6)
        Me.PanelInfo3.Controls.Add(Me.Panel3)
        Me.PanelInfo3.Location = New System.Drawing.Point(427, 42)
        Me.PanelInfo3.Name = "PanelInfo3"
        Me.PanelInfo3.Size = New System.Drawing.Size(183, 98)
        Me.PanelInfo3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(63, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 32)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "13"
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
        Me.Label3.Location = New System.Drawing.Point(8, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ventas Ultimos 7 Dias"
        '
        'PanelInfo1
        '
        Me.PanelInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo1.Controls.Add(Me.Label4)
        Me.PanelInfo1.Controls.Add(Me.Panel1)
        Me.PanelInfo1.Location = New System.Drawing.Point(30, 44)
        Me.PanelInfo1.Name = "PanelInfo1"
        Me.PanelInfo1.Size = New System.Drawing.Size(177, 98)
        Me.PanelInfo1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(63, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "50"
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
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventas Realizadas"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCondionesComerciales)
        Me.Panel2.Controls.Add(Me.btnFormasdePago)
        Me.Panel2.Controls.Add(Me.btnCobranzas)
        Me.Panel2.Controls.Add(Me.btnDevoluciones)
        Me.Panel2.Controls.Add(Me.btnArqueoCaja)
        Me.Panel2.Controls.Add(Me.btnPresupuesto)
        Me.Panel2.Controls.Add(Me.btnNuevaVenta)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 316)
        Me.Panel2.TabIndex = 3
        '
        'btnCondionesComerciales
        '
        Me.btnCondionesComerciales.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCondionesComerciales.FlatAppearance.BorderSize = 0
        Me.btnCondionesComerciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCondionesComerciales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondionesComerciales.ForeColor = System.Drawing.Color.White
        Me.btnCondionesComerciales.Location = New System.Drawing.Point(28, 264)
        Me.btnCondionesComerciales.Name = "btnCondionesComerciales"
        Me.btnCondionesComerciales.Size = New System.Drawing.Size(152, 49)
        Me.btnCondionesComerciales.TabIndex = 8
        Me.btnCondionesComerciales.Text = "Condiciones Comerciales"
        Me.btnCondionesComerciales.UseVisualStyleBackColor = False
        '
        'btnFormasdePago
        '
        Me.btnFormasdePago.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFormasdePago.FlatAppearance.BorderSize = 0
        Me.btnFormasdePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormasdePago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormasdePago.ForeColor = System.Drawing.Color.White
        Me.btnFormasdePago.Location = New System.Drawing.Point(28, 222)
        Me.btnFormasdePago.Name = "btnFormasdePago"
        Me.btnFormasdePago.Size = New System.Drawing.Size(152, 36)
        Me.btnFormasdePago.TabIndex = 7
        Me.btnFormasdePago.Text = "Formas de Pago"
        Me.btnFormasdePago.UseVisualStyleBackColor = False
        '
        'btnCobranzas
        '
        Me.btnCobranzas.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCobranzas.FlatAppearance.BorderSize = 0
        Me.btnCobranzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobranzas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobranzas.ForeColor = System.Drawing.Color.White
        Me.btnCobranzas.Location = New System.Drawing.Point(28, 180)
        Me.btnCobranzas.Name = "btnCobranzas"
        Me.btnCobranzas.Size = New System.Drawing.Size(152, 36)
        Me.btnCobranzas.TabIndex = 6
        Me.btnCobranzas.Text = "Cobranzas"
        Me.btnCobranzas.UseVisualStyleBackColor = False
        '
        'btnDevoluciones
        '
        Me.btnDevoluciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnDevoluciones.FlatAppearance.BorderSize = 0
        Me.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevoluciones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevoluciones.ForeColor = System.Drawing.Color.White
        Me.btnDevoluciones.Location = New System.Drawing.Point(28, 138)
        Me.btnDevoluciones.Name = "btnDevoluciones"
        Me.btnDevoluciones.Size = New System.Drawing.Size(152, 36)
        Me.btnDevoluciones.TabIndex = 5
        Me.btnDevoluciones.Text = "Devoluciones"
        Me.btnDevoluciones.UseVisualStyleBackColor = False
        '
        'btnArqueoCaja
        '
        Me.btnArqueoCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnArqueoCaja.FlatAppearance.BorderSize = 0
        Me.btnArqueoCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArqueoCaja.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArqueoCaja.ForeColor = System.Drawing.Color.White
        Me.btnArqueoCaja.Location = New System.Drawing.Point(28, 96)
        Me.btnArqueoCaja.Name = "btnArqueoCaja"
        Me.btnArqueoCaja.Size = New System.Drawing.Size(152, 36)
        Me.btnArqueoCaja.TabIndex = 4
        Me.btnArqueoCaja.Text = "Arqueo de Caja"
        Me.btnArqueoCaja.UseVisualStyleBackColor = False
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPresupuesto.FlatAppearance.BorderSize = 0
        Me.btnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresupuesto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuesto.ForeColor = System.Drawing.Color.White
        Me.btnPresupuesto.Location = New System.Drawing.Point(28, 54)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(152, 36)
        Me.btnPresupuesto.TabIndex = 3
        Me.btnPresupuesto.Text = "Presupuesto"
        Me.btnPresupuesto.UseVisualStyleBackColor = False
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnNuevaVenta.FlatAppearance.BorderSize = 0
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaVenta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaVenta.Location = New System.Drawing.Point(28, 12)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(152, 36)
        Me.btnNuevaVenta.TabIndex = 2
        Me.btnNuevaVenta.Text = "Nueva Venta"
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.Label7)
        Me.PanelContenedor.Controls.Add(Me.dgvListadoCondCom)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(209, 144)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(431, 316)
        Me.PanelContenedor.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Listado de Condiciones Comerciales"
        '
        'dgvListadoCondCom
        '
        Me.dgvListadoCondCom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoCondCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCondCom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListadoCondCom.Location = New System.Drawing.Point(37, 50)
        Me.dgvListadoCondCom.Name = "dgvListadoCondCom"
        Me.dgvListadoCondCom.RowHeadersVisible = False
        Me.dgvListadoCondCom.Size = New System.Drawing.Size(358, 223)
        Me.dgvListadoCondCom.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Descripcion"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Vigente desde"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Vigente Hasta"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'FormMenuVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(640, 460)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuVentas"
        Me.Text = "FormMenuVentas"
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
        CType(Me.dgvListadoCondCom, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnCondionesComerciales As Button
    Friend WithEvents btnFormasdePago As Button
    Friend WithEvents btnCobranzas As Button
    Friend WithEvents btnDevoluciones As Button
    Friend WithEvents btnArqueoCaja As Button
    Friend WithEvents btnPresupuesto As Button
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvListadoCondCom As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
