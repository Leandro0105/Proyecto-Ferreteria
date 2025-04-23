<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuPrincipal))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.IconIndex = New FontAwesome.Sharp.IconPictureBox()
        Me.lblPermiso = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelLateralIzquierdo = New System.Windows.Forms.Panel()
        Me.btnReportes = New FontAwesome.Sharp.IconButton()
        Me.btnVentas = New FontAwesome.Sharp.IconButton()
        Me.btnCompras = New FontAwesome.Sharp.IconButton()
        Me.btnProductos = New FontAwesome.Sharp.IconButton()
        Me.btnProveedores = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.IconIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLateralIzquierdo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.lblIndex)
        Me.PanelSuperior.Controls.Add(Me.IconIndex)
        Me.PanelSuperior.Controls.Add(Me.lblPermiso)
        Me.PanelSuperior.Controls.Add(Me.lblNombreUsuario)
        Me.PanelSuperior.Controls.Add(Me.PictureBox1)
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(900, 45)
        Me.PanelSuperior.TabIndex = 0
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndex.ForeColor = System.Drawing.Color.White
        Me.lblIndex.Location = New System.Drawing.Point(320, 15)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(51, 16)
        Me.lblIndex.TabIndex = 8
        Me.lblIndex.Text = "Label1"
        '
        'IconIndex
        '
        Me.IconIndex.ActiveColor = System.Drawing.Color.Black
        Me.IconIndex.BackColor = System.Drawing.Color.Transparent
        Me.IconIndex.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconIndex.InActiveColor = System.Drawing.Color.White
        Me.IconIndex.Location = New System.Drawing.Point(260, 0)
        Me.IconIndex.Name = "IconIndex"
        Me.IconIndex.Size = New System.Drawing.Size(54, 45)
        Me.IconIndex.TabIndex = 7
        Me.IconIndex.TabStop = False
        '
        'lblPermiso
        '
        Me.lblPermiso.AutoSize = True
        Me.lblPermiso.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermiso.ForeColor = System.Drawing.Color.White
        Me.lblPermiso.Location = New System.Drawing.Point(50, 24)
        Me.lblPermiso.Name = "lblPermiso"
        Me.lblPermiso.Size = New System.Drawing.Size(42, 15)
        Me.lblPermiso.TabIndex = 6
        Me.lblPermiso.Text = "Label1"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombreUsuario.Location = New System.Drawing.Point(50, 4)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(42, 15)
        Me.lblNombreUsuario.TabIndex = 5
        Me.lblNombreUsuario.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = Global.CapaPresentacion.My.Resources.Resources.actualizar_flecha
        Me.btnRestaurar.Location = New System.Drawing.Point(812, 3)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(38, 38)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = Global.CapaPresentacion.My.Resources.Resources.maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(812, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(38, 38)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.CapaPresentacion.My.Resources.Resources.menos
        Me.btnMinimizar.Location = New System.Drawing.Point(769, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(38, 38)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = Global.CapaPresentacion.My.Resources.Resources.cerrar
        Me.btnCerrar.Location = New System.Drawing.Point(854, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(38, 38)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.btnCerrarSesion)
        Me.PanelInferior.Controls.Add(Me.PictureBox2)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 505)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(900, 45)
        Me.PanelInferior.TabIndex = 1
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Location = New System.Drawing.Point(53, 0)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(207, 45)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CapaPresentacion.My.Resources.Resources.poder
        Me.PictureBox2.Location = New System.Drawing.Point(4, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelLateralIzquierdo
        '
        Me.PanelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnReportes)
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnVentas)
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnCompras)
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnProductos)
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnProveedores)
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnClientes)
        Me.PanelLateralIzquierdo.Controls.Add(Me.btnUsuarios)
        Me.PanelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralIzquierdo.Location = New System.Drawing.Point(0, 45)
        Me.PanelLateralIzquierdo.Name = "PanelLateralIzquierdo"
        Me.PanelLateralIzquierdo.Size = New System.Drawing.Size(260, 460)
        Me.PanelLateralIzquierdo.TabIndex = 2
        '
        'btnReportes
        '
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Icon = FontAwesome.Sharp.IconChar.FilePdfO
        Me.btnReportes.IconColor = System.Drawing.Color.White
        Me.btnReportes.IconSize = 40
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 393)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(260, 65)
        Me.btnReportes.TabIndex = 6
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Icon = FontAwesome.Sharp.IconChar.Tags
        Me.btnVentas.IconColor = System.Drawing.Color.White
        Me.btnVentas.IconSize = 40
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 328)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(260, 65)
        Me.btnVentas.TabIndex = 5
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Icon = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnCompras.IconColor = System.Drawing.Color.White
        Me.btnCompras.IconSize = 40
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 263)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(260, 65)
        Me.btnCompras.TabIndex = 4
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Icon = FontAwesome.Sharp.IconChar.Cubes
        Me.btnProductos.IconColor = System.Drawing.Color.White
        Me.btnProductos.IconSize = 40
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 198)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(260, 65)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Icon = FontAwesome.Sharp.IconChar.Truck
        Me.btnProveedores.IconColor = System.Drawing.Color.White
        Me.btnProveedores.IconSize = 40
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 133)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(260, 65)
        Me.btnProveedores.TabIndex = 2
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Icon = FontAwesome.Sharp.IconChar.Users
        Me.btnClientes.IconColor = System.Drawing.Color.White
        Me.btnClientes.IconSize = 40
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 66)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(260, 65)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Icon = FontAwesome.Sharp.IconChar.User
        Me.btnUsuarios.IconColor = System.Drawing.Color.White
        Me.btnUsuarios.IconSize = 40
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(260, 65)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBoxLogo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(260, 45)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(640, 460)
        Me.PanelContenedor.TabIndex = 3
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLogo.Image = Global.CapaPresentacion.My.Resources.Resources.logo_sistema
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(640, 460)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelLateralIzquierdo)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.IconIndex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLateralIzquierdo.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents PanelLateralIzquierdo As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPermiso As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents btnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCompras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProveedores As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents lblIndex As Label
    Friend WithEvents IconIndex As FontAwesome.Sharp.IconPictureBox
End Class
