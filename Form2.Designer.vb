<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGENDA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGENDA))
        Me.TabControlDatos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDatosPerfil = New System.Windows.Forms.GroupBox()
        Me.PictureBoxFotoPerfil = New System.Windows.Forms.PictureBox()
        Me.GroupBoxDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.ComboBoxNacionalidad = New System.Windows.Forms.ComboBox()
        Me.LabelNacionalidad = New System.Windows.Forms.Label()
        Me.TextBoxApellido2 = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.RadioButtonFemenino = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMasculino = New System.Windows.Forms.RadioButton()
        Me.LabelSexo = New System.Windows.Forms.Label()
        Me.LabelApellido2 = New System.Windows.Forms.Label()
        Me.LabelApellido1 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.BotonGuardar = New System.Windows.Forms.Button()
        Me.BotonNuevo = New System.Windows.Forms.Button()
        Me.ListaPreferencias = New System.Windows.Forms.ListBox()
        Me.EtiquetaPreferencias = New System.Windows.Forms.Label()
        Me.GroupBoxOtrosDatos = New System.Windows.Forms.GroupBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.EtiquetaDescripcion = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.TabControlDatos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxDatosPerfil.SuspendLayout()
        CType(Me.PictureBoxFotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosUsuario.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBoxOtrosDatos.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlDatos
        '
        Me.TabControlDatos.Controls.Add(Me.TabPage1)
        Me.TabControlDatos.Controls.Add(Me.TabPage2)
        Me.TabControlDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlDatos.Location = New System.Drawing.Point(12, 23)
        Me.TabControlDatos.Name = "TabControlDatos"
        Me.TabControlDatos.SelectedIndex = 0
        Me.TabControlDatos.Size = New System.Drawing.Size(643, 294)
        Me.TabControlDatos.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBoxDatosPerfil)
        Me.TabPage1.Controls.Add(Me.GroupBoxDatosUsuario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(635, 263)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBoxDatosPerfil
        '
        Me.GroupBoxDatosPerfil.Controls.Add(Me.PictureBoxFotoPerfil)
        Me.GroupBoxDatosPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosPerfil.Location = New System.Drawing.Point(335, 13)
        Me.GroupBoxDatosPerfil.Name = "GroupBoxDatosPerfil"
        Me.GroupBoxDatosPerfil.Size = New System.Drawing.Size(290, 221)
        Me.GroupBoxDatosPerfil.TabIndex = 1
        Me.GroupBoxDatosPerfil.TabStop = False
        Me.GroupBoxDatosPerfil.Text = "Datos del perfil"
        '
        'PictureBoxFotoPerfil
        '
        Me.PictureBoxFotoPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxFotoPerfil.Image = CType(resources.GetObject("PictureBoxFotoPerfil.Image"), System.Drawing.Image)
        Me.PictureBoxFotoPerfil.Location = New System.Drawing.Point(3, 20)
        Me.PictureBoxFotoPerfil.Name = "PictureBoxFotoPerfil"
        Me.PictureBoxFotoPerfil.Size = New System.Drawing.Size(284, 198)
        Me.PictureBoxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFotoPerfil.TabIndex = 0
        Me.PictureBoxFotoPerfil.TabStop = False
        '
        'GroupBoxDatosUsuario
        '
        Me.GroupBoxDatosUsuario.Controls.Add(Me.ComboBoxNacionalidad)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.LabelNacionalidad)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.TextBoxApellido2)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.TextBoxApellido1)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.TextBoxNombre)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.RadioButtonFemenino)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.RadioButtonMasculino)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.LabelSexo)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.LabelApellido2)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.LabelApellido1)
        Me.GroupBoxDatosUsuario.Controls.Add(Me.LabelNombre)
        Me.GroupBoxDatosUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosUsuario.Location = New System.Drawing.Point(15, 15)
        Me.GroupBoxDatosUsuario.Name = "GroupBoxDatosUsuario"
        Me.GroupBoxDatosUsuario.Size = New System.Drawing.Size(308, 220)
        Me.GroupBoxDatosUsuario.TabIndex = 0
        Me.GroupBoxDatosUsuario.TabStop = False
        Me.GroupBoxDatosUsuario.Text = "Datos del usuario"
        '
        'ComboBoxNacionalidad
        '
        Me.ComboBoxNacionalidad.FormattingEnabled = True
        Me.ComboBoxNacionalidad.Items.AddRange(New Object() {"España", "Francia", "Alemania", "Italia", "Portugal", "Grecia"})
        Me.ComboBoxNacionalidad.Location = New System.Drawing.Point(153, 181)
        Me.ComboBoxNacionalidad.Name = "ComboBoxNacionalidad"
        Me.ComboBoxNacionalidad.Size = New System.Drawing.Size(134, 26)
        Me.ComboBoxNacionalidad.TabIndex = 10
        Me.ComboBoxNacionalidad.Text = "Seleccione Pais"
        '
        'LabelNacionalidad
        '
        Me.LabelNacionalidad.AutoSize = True
        Me.LabelNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNacionalidad.Location = New System.Drawing.Point(22, 187)
        Me.LabelNacionalidad.Name = "LabelNacionalidad"
        Me.LabelNacionalidad.Size = New System.Drawing.Size(93, 18)
        Me.LabelNacionalidad.TabIndex = 9
        Me.LabelNacionalidad.Text = "Nacionalidad"
        '
        'TextBoxApellido2
        '
        Me.TextBoxApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxApellido2.Location = New System.Drawing.Point(153, 96)
        Me.TextBoxApellido2.Name = "TextBoxApellido2"
        Me.TextBoxApellido2.Size = New System.Drawing.Size(134, 24)
        Me.TextBoxApellido2.TabIndex = 8
        '
        'TextBoxApellido1
        '
        Me.TextBoxApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxApellido1.Location = New System.Drawing.Point(153, 68)
        Me.TextBoxApellido1.Name = "TextBoxApellido1"
        Me.TextBoxApellido1.Size = New System.Drawing.Size(134, 24)
        Me.TextBoxApellido1.TabIndex = 7
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNombre.Location = New System.Drawing.Point(153, 41)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(134, 24)
        Me.TextBoxNombre.TabIndex = 6
        '
        'RadioButtonFemenino
        '
        Me.RadioButtonFemenino.AutoSize = True
        Me.RadioButtonFemenino.Location = New System.Drawing.Point(153, 155)
        Me.RadioButtonFemenino.Name = "RadioButtonFemenino"
        Me.RadioButtonFemenino.Size = New System.Drawing.Size(92, 22)
        Me.RadioButtonFemenino.TabIndex = 5
        Me.RadioButtonFemenino.TabStop = True
        Me.RadioButtonFemenino.Text = "Femenino"
        Me.RadioButtonFemenino.UseVisualStyleBackColor = True
        '
        'RadioButtonMasculino
        '
        Me.RadioButtonMasculino.AutoSize = True
        Me.RadioButtonMasculino.Location = New System.Drawing.Point(153, 129)
        Me.RadioButtonMasculino.Name = "RadioButtonMasculino"
        Me.RadioButtonMasculino.Size = New System.Drawing.Size(94, 22)
        Me.RadioButtonMasculino.TabIndex = 4
        Me.RadioButtonMasculino.TabStop = True
        Me.RadioButtonMasculino.Text = "Masculino"
        Me.RadioButtonMasculino.UseVisualStyleBackColor = True
        '
        'LabelSexo
        '
        Me.LabelSexo.AutoSize = True
        Me.LabelSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSexo.Location = New System.Drawing.Point(22, 128)
        Me.LabelSexo.Name = "LabelSexo"
        Me.LabelSexo.Size = New System.Drawing.Size(42, 18)
        Me.LabelSexo.TabIndex = 3
        Me.LabelSexo.Text = "Sexo"
        '
        'LabelApellido2
        '
        Me.LabelApellido2.AutoSize = True
        Me.LabelApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido2.Location = New System.Drawing.Point(22, 97)
        Me.LabelApellido2.Name = "LabelApellido2"
        Me.LabelApellido2.Size = New System.Drawing.Size(122, 18)
        Me.LabelApellido2.TabIndex = 2
        Me.LabelApellido2.Text = "Segundo Apellido"
        '
        'LabelApellido1
        '
        Me.LabelApellido1.AutoSize = True
        Me.LabelApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido1.Location = New System.Drawing.Point(22, 71)
        Me.LabelApellido1.Name = "LabelApellido1"
        Me.LabelApellido1.Size = New System.Drawing.Size(107, 18)
        Me.LabelApellido1.TabIndex = 1
        Me.LabelApellido1.Text = "Primer Apellido"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(22, 44)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 18)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BotonSalir)
        Me.TabPage2.Controls.Add(Me.BotonGuardar)
        Me.TabPage2.Controls.Add(Me.BotonNuevo)
        Me.TabPage2.Controls.Add(Me.ListaPreferencias)
        Me.TabPage2.Controls.Add(Me.EtiquetaPreferencias)
        Me.TabPage2.Controls.Add(Me.GroupBoxOtrosDatos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(635, 263)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Opcionales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BotonSalir
        '
        Me.BotonSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalir.Location = New System.Drawing.Point(528, 190)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(75, 25)
        Me.BotonSalir.TabIndex = 5
        Me.BotonSalir.Text = "Salir"
        Me.BotonSalir.UseVisualStyleBackColor = True
        '
        'BotonGuardar
        '
        Me.BotonGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonGuardar.Location = New System.Drawing.Point(447, 190)
        Me.BotonGuardar.Name = "BotonGuardar"
        Me.BotonGuardar.Size = New System.Drawing.Size(75, 25)
        Me.BotonGuardar.TabIndex = 4
        Me.BotonGuardar.Text = "Guardar"
        Me.BotonGuardar.UseVisualStyleBackColor = True
        '
        'BotonNuevo
        '
        Me.BotonNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonNuevo.Location = New System.Drawing.Point(366, 190)
        Me.BotonNuevo.Name = "BotonNuevo"
        Me.BotonNuevo.Size = New System.Drawing.Size(75, 25)
        Me.BotonNuevo.TabIndex = 3
        Me.BotonNuevo.Text = "Nuevo"
        Me.BotonNuevo.UseVisualStyleBackColor = True
        '
        'ListaPreferencias
        '
        Me.ListaPreferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaPreferencias.FormattingEnabled = True
        Me.ListaPreferencias.ItemHeight = 18
        Me.ListaPreferencias.Items.AddRange(New Object() {"Leer", "Bailar", "Correr"})
        Me.ListaPreferencias.Location = New System.Drawing.Point(418, 86)
        Me.ListaPreferencias.Name = "ListaPreferencias"
        Me.ListaPreferencias.Size = New System.Drawing.Size(127, 76)
        Me.ListaPreferencias.TabIndex = 2
        '
        'EtiquetaPreferencias
        '
        Me.EtiquetaPreferencias.AutoSize = True
        Me.EtiquetaPreferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaPreferencias.Location = New System.Drawing.Point(431, 53)
        Me.EtiquetaPreferencias.Name = "EtiquetaPreferencias"
        Me.EtiquetaPreferencias.Size = New System.Drawing.Size(91, 18)
        Me.EtiquetaPreferencias.TabIndex = 1
        Me.EtiquetaPreferencias.Text = "Preferencias"
        '
        'GroupBoxOtrosDatos
        '
        Me.GroupBoxOtrosDatos.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBoxOtrosDatos.Controls.Add(Me.EtiquetaDescripcion)
        Me.GroupBoxOtrosDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOtrosDatos.Location = New System.Drawing.Point(13, 20)
        Me.GroupBoxOtrosDatos.Name = "GroupBoxOtrosDatos"
        Me.GroupBoxOtrosDatos.Size = New System.Drawing.Size(303, 214)
        Me.GroupBoxOtrosDatos.TabIndex = 0
        Me.GroupBoxOtrosDatos.TabStop = False
        Me.GroupBoxOtrosDatos.Text = "Otros datos"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(117, 33)
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(167, 162)
        Me.TextBoxDescripcion.TabIndex = 1
        '
        'EtiquetaDescripcion
        '
        Me.EtiquetaDescripcion.AutoSize = True
        Me.EtiquetaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaDescripcion.Location = New System.Drawing.Point(24, 36)
        Me.EtiquetaDescripcion.Name = "EtiquetaDescripcion"
        Me.EtiquetaDescripcion.Size = New System.Drawing.Size(87, 18)
        Me.EtiquetaDescripcion.TabIndex = 0
        Me.EtiquetaDescripcion.Text = "Descripción"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(278, 8)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(377, 31)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'AGENDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 330)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.TabControlDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AGENDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENDA NAVIDAD"
        Me.TabControlDatos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBoxDatosPerfil.ResumeLayout(False)
        CType(Me.PictureBoxFotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosUsuario.ResumeLayout(False)
        Me.GroupBoxDatosUsuario.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBoxOtrosDatos.ResumeLayout(False)
        Me.GroupBoxOtrosDatos.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlDatos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBoxDatosPerfil As GroupBox
    Friend WithEvents GroupBoxDatosUsuario As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBoxOtrosDatos As GroupBox
    Friend WithEvents EtiquetaDescripcion As Label
    Friend WithEvents ListaPreferencias As ListBox
    Friend WithEvents EtiquetaPreferencias As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents BotonSalir As Button
    Friend WithEvents BotonGuardar As Button
    Friend WithEvents BotonNuevo As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PictureBoxFotoPerfil As PictureBox
    Friend WithEvents ComboBoxNacionalidad As ComboBox
    Friend WithEvents LabelNacionalidad As Label
    Friend WithEvents TextBoxApellido2 As TextBox
    Friend WithEvents TextBoxApellido1 As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents RadioButtonFemenino As RadioButton
    Friend WithEvents RadioButtonMasculino As RadioButton
    Friend WithEvents LabelSexo As Label
    Friend WithEvents LabelApellido2 As Label
    Friend WithEvents LabelApellido1 As Label
    Friend WithEvents LabelNombre As Label
End Class
