﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelInfo2 = New System.Windows.Forms.Panel()
        Me.lblUsuariosBloqueados = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconoHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelInfo3 = New System.Windows.Forms.Panel()
        Me.lblUsuariosInactivos = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelInfo1 = New System.Windows.Forms.Panel()
        Me.lblTotalUsuarios = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListadoUsuarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgvListadoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSuperior.TabIndex = 0
        '
        'PanelInfo2
        '
        Me.PanelInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo2.Controls.Add(Me.lblUsuariosBloqueados)
        Me.PanelInfo2.Controls.Add(Me.Panel4)
        Me.PanelInfo2.Location = New System.Drawing.Point(239, 55)
        Me.PanelInfo2.Name = "PanelInfo2"
        Me.PanelInfo2.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo2.TabIndex = 4
        '
        'lblUsuariosBloqueados
        '
        Me.lblUsuariosBloqueados.AutoSize = True
        Me.lblUsuariosBloqueados.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuariosBloqueados.ForeColor = System.Drawing.Color.White
        Me.lblUsuariosBloqueados.Location = New System.Drawing.Point(64, 41)
        Me.lblUsuariosBloqueados.Name = "lblUsuariosBloqueados"
        Me.lblUsuariosBloqueados.Size = New System.Drawing.Size(30, 32)
        Me.lblUsuariosBloqueados.TabIndex = 1
        Me.lblUsuariosBloqueados.Text = "5"
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
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bloqueados"
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
        Me.PanelInfo3.Controls.Add(Me.lblUsuariosInactivos)
        Me.PanelInfo3.Controls.Add(Me.Panel3)
        Me.PanelInfo3.Location = New System.Drawing.Point(438, 54)
        Me.PanelInfo3.Name = "PanelInfo3"
        Me.PanelInfo3.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo3.TabIndex = 2
        '
        'lblUsuariosInactivos
        '
        Me.lblUsuariosInactivos.AutoSize = True
        Me.lblUsuariosInactivos.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuariosInactivos.ForeColor = System.Drawing.Color.White
        Me.lblUsuariosInactivos.Location = New System.Drawing.Point(72, 40)
        Me.lblUsuariosInactivos.Name = "lblUsuariosInactivos"
        Me.lblUsuariosInactivos.Size = New System.Drawing.Size(30, 32)
        Me.lblUsuariosInactivos.TabIndex = 2
        Me.lblUsuariosInactivos.Text = "5"
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
        Me.Label3.Location = New System.Drawing.Point(53, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Inactivos"
        '
        'PanelInfo1
        '
        Me.PanelInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInfo1.Controls.Add(Me.lblTotalUsuarios)
        Me.PanelInfo1.Controls.Add(Me.Panel1)
        Me.PanelInfo1.Location = New System.Drawing.Point(41, 57)
        Me.PanelInfo1.Name = "PanelInfo1"
        Me.PanelInfo1.Size = New System.Drawing.Size(162, 98)
        Me.PanelInfo1.TabIndex = 0
        '
        'lblTotalUsuarios
        '
        Me.lblTotalUsuarios.AutoSize = True
        Me.lblTotalUsuarios.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblTotalUsuarios.Location = New System.Drawing.Point(71, 41)
        Me.lblTotalUsuarios.Name = "lblTotalUsuarios"
        Me.lblTotalUsuarios.Size = New System.Drawing.Size(30, 32)
        Me.lblTotalUsuarios.TabIndex = 1
        Me.lblTotalUsuarios.Text = "5"
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
        Me.Label1.Location = New System.Drawing.Point(14, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total de Usuarios"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminarUsuario)
        Me.Panel2.Controls.Add(Me.btnModificarUsuario)
        Me.Panel2.Controls.Add(Me.btnAgregarUsuario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 270)
        Me.Panel2.TabIndex = 1
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEliminarUsuario.FlatAppearance.BorderSize = 0
        Me.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(41, 177)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(150, 36)
        Me.btnEliminarUsuario.TabIndex = 2
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = False
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnModificarUsuario.FlatAppearance.BorderSize = 0
        Me.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnModificarUsuario.Location = New System.Drawing.Point(41, 116)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(150, 36)
        Me.btnModificarUsuario.TabIndex = 1
        Me.btnModificarUsuario.Text = "Modificar"
        Me.btnModificarUsuario.UseVisualStyleBackColor = False
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(41, 59)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(150, 36)
        Me.btnAgregarUsuario.TabIndex = 0
        Me.btnAgregarUsuario.Text = "Agegar"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.Label7)
        Me.PanelContenedor.Controls.Add(Me.dgvListadoUsuarios)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(240, 190)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(400, 270)
        Me.PanelContenedor.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(122, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Listado de Usuarios"
        '
        'dgvListadoUsuarios
        '
        Me.dgvListadoUsuarios.AllowUserToAddRows = False
        Me.dgvListadoUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvListadoUsuarios.Location = New System.Drawing.Point(26, 47)
        Me.dgvListadoUsuarios.MultiSelect = False
        Me.dgvListadoUsuarios.Name = "dgvListadoUsuarios"
        Me.dgvListadoUsuarios.ReadOnly = True
        Me.dgvListadoUsuarios.RowHeadersVisible = False
        Me.dgvListadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoUsuarios.Size = New System.Drawing.Size(352, 191)
        Me.dgvListadoUsuarios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Apellidos"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 175
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Nombres"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 176
        '
        'FormMenuUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(640, 460)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuUsuario"
        Me.Text = "FormMenuUsuario"
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
        CType(Me.dgvListadoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelInfo3 As Panel
    Friend WithEvents lblUsuariosInactivos As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelInfo1 As Panel
    Friend WithEvents lblTotalUsuarios As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconoHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelInfo2 As Panel
    Friend WithEvents lblUsuariosBloqueados As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnModificarUsuario As Button
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvListadoUsuarios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
