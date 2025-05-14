<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaUsuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIdUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkCambiarContraseña = New System.Windows.Forms.CheckBox()
        Me.chkUsuarioActivo = New System.Windows.Forms.CheckBox()
        Me.txtNuevoNombreU = New System.Windows.Forms.TextBox()
        Me.txtNuevoApellidoU = New System.Windows.Forms.TextBox()
        Me.txtNuevoUsuarioU = New System.Windows.Forms.TextBox()
        Me.txtNuevoPasswordU = New System.Windows.Forms.TextBox()
        Me.txtNuevoCorreoU = New System.Windows.Forms.TextBox()
        Me.cboPermiso = New System.Windows.Forms.ComboBox()
        Me.lblCorreoValido = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCerrarr = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.lblUsuarioValido = New System.Windows.Forms.Label()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.btnCerrarr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Controls.Add(Me.btnCerrarr)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 37)
        Me.PanelSuperior.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(332, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alta Usuario"
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 577)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 23)
        Me.PanelInferior.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Usuario:"
        '
        'lblIdUsuario
        '
        Me.lblIdUsuario.AutoSize = True
        Me.lblIdUsuario.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblIdUsuario.Location = New System.Drawing.Point(131, 40)
        Me.lblIdUsuario.Name = "lblIdUsuario"
        Me.lblIdUsuario.Size = New System.Drawing.Size(113, 25)
        Me.lblIdUsuario.TabIndex = 4
        Me.lblIdUsuario.Text = "Id Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido(s):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Correo de Recuperación:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Permiso:"
        '
        'chkCambiarContraseña
        '
        Me.chkCambiarContraseña.AutoSize = True
        Me.chkCambiarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambiarContraseña.Location = New System.Drawing.Point(17, 407)
        Me.chkCambiarContraseña.Name = "chkCambiarContraseña"
        Me.chkCambiarContraseña.Size = New System.Drawing.Size(249, 17)
        Me.chkCambiarContraseña.TabIndex = 11
        Me.chkCambiarContraseña.Text = "Cambiar Contraseña Después de Iniciar"
        Me.chkCambiarContraseña.UseVisualStyleBackColor = True
        '
        'chkUsuarioActivo
        '
        Me.chkUsuarioActivo.AutoSize = True
        Me.chkUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsuarioActivo.Location = New System.Drawing.Point(17, 431)
        Me.chkUsuarioActivo.Name = "chkUsuarioActivo"
        Me.chkUsuarioActivo.Size = New System.Drawing.Size(109, 17)
        Me.chkUsuarioActivo.TabIndex = 12
        Me.chkUsuarioActivo.Text = "Usuario Activo"
        Me.chkUsuarioActivo.UseVisualStyleBackColor = True
        '
        'txtNuevoNombreU
        '
        Me.txtNuevoNombreU.Location = New System.Drawing.Point(17, 98)
        Me.txtNuevoNombreU.Name = "txtNuevoNombreU"
        Me.txtNuevoNombreU.Size = New System.Drawing.Size(277, 20)
        Me.txtNuevoNombreU.TabIndex = 13
        '
        'txtNuevoApellidoU
        '
        Me.txtNuevoApellidoU.Location = New System.Drawing.Point(17, 149)
        Me.txtNuevoApellidoU.Name = "txtNuevoApellidoU"
        Me.txtNuevoApellidoU.Size = New System.Drawing.Size(277, 20)
        Me.txtNuevoApellidoU.TabIndex = 14
        '
        'txtNuevoUsuarioU
        '
        Me.txtNuevoUsuarioU.Location = New System.Drawing.Point(17, 200)
        Me.txtNuevoUsuarioU.Name = "txtNuevoUsuarioU"
        Me.txtNuevoUsuarioU.Size = New System.Drawing.Size(277, 20)
        Me.txtNuevoUsuarioU.TabIndex = 15
        '
        'txtNuevoPasswordU
        '
        Me.txtNuevoPasswordU.Location = New System.Drawing.Point(17, 264)
        Me.txtNuevoPasswordU.Name = "txtNuevoPasswordU"
        Me.txtNuevoPasswordU.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevoPasswordU.Size = New System.Drawing.Size(277, 20)
        Me.txtNuevoPasswordU.TabIndex = 16
        '
        'txtNuevoCorreoU
        '
        Me.txtNuevoCorreoU.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoCorreoU.Location = New System.Drawing.Point(17, 313)
        Me.txtNuevoCorreoU.Name = "txtNuevoCorreoU"
        Me.txtNuevoCorreoU.Size = New System.Drawing.Size(277, 22)
        Me.txtNuevoCorreoU.TabIndex = 17
        '
        'cboPermiso
        '
        Me.cboPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPermiso.FormattingEnabled = True
        Me.cboPermiso.Location = New System.Drawing.Point(91, 377)
        Me.cboPermiso.Name = "cboPermiso"
        Me.cboPermiso.Size = New System.Drawing.Size(203, 21)
        Me.cboPermiso.TabIndex = 18
        '
        'lblCorreoValido
        '
        Me.lblCorreoValido.AutoSize = True
        Me.lblCorreoValido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoValido.ForeColor = System.Drawing.Color.Black
        Me.lblCorreoValido.Location = New System.Drawing.Point(14, 338)
        Me.lblCorreoValido.Name = "lblCorreoValido"
        Me.lblCorreoValido.Size = New System.Drawing.Size(62, 16)
        Me.lblCorreoValido.TabIndex = 19
        Me.lblCorreoValido.Text = "Permiso:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(263, 464)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 29)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(400, 464)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 29)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCerrarr
        '
        Me.btnCerrarr.Image = Global.CapaPresentacion.My.Resources.Resources.cerrar
        Me.btnCerrarr.Location = New System.Drawing.Point(760, 0)
        Me.btnCerrarr.Name = "btnCerrarr"
        Me.btnCerrarr.Size = New System.Drawing.Size(37, 37)
        Me.btnCerrarr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarr.TabIndex = 1
        Me.btnCerrarr.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = Global.CapaPresentacion.My.Resources.Resources.menos
        Me.btnMinimizar.Location = New System.Drawing.Point(717, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 37)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.TabStop = False
        '
        'lblUsuarioValido
        '
        Me.lblUsuarioValido.AutoSize = True
        Me.lblUsuarioValido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioValido.ForeColor = System.Drawing.Color.Black
        Me.lblUsuarioValido.Location = New System.Drawing.Point(14, 223)
        Me.lblUsuarioValido.Name = "lblUsuarioValido"
        Me.lblUsuarioValido.Size = New System.Drawing.Size(62, 16)
        Me.lblUsuarioValido.TabIndex = 22
        Me.lblUsuarioValido.Text = "Permiso:"
        '
        'FormAltaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblUsuarioValido)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblCorreoValido)
        Me.Controls.Add(Me.cboPermiso)
        Me.Controls.Add(Me.txtNuevoCorreoU)
        Me.Controls.Add(Me.txtNuevoPasswordU)
        Me.Controls.Add(Me.txtNuevoUsuarioU)
        Me.Controls.Add(Me.txtNuevoApellidoU)
        Me.Controls.Add(Me.txtNuevoNombreU)
        Me.Controls.Add(Me.chkUsuarioActivo)
        Me.Controls.Add(Me.chkCambiarContraseña)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblIdUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAltaUsuarios"
        Me.Text = "FormAltaUsuarios"
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
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIdUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkCambiarContraseña As CheckBox
    Friend WithEvents chkUsuarioActivo As CheckBox
    Friend WithEvents txtNuevoNombreU As TextBox
    Friend WithEvents txtNuevoApellidoU As TextBox
    Friend WithEvents txtNuevoUsuarioU As TextBox
    Friend WithEvents txtNuevoPasswordU As TextBox
    Friend WithEvents txtNuevoCorreoU As TextBox
    Friend WithEvents cboPermiso As ComboBox
    Friend WithEvents lblCorreoValido As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblUsuarioValido As Label
End Class
