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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.BotonGuardar = New System.Windows.Forms.Button()
        Me.BotonNuevo = New System.Windows.Forms.Button()
        Me.ListaPreferencias = New System.Windows.Forms.ListBox()
        Me.EtiquetaPreferencias = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EtiquetaDescripcion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(643, 294)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(635, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(335, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 221)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del perfil"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del usuario"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BotonSalir)
        Me.TabPage2.Controls.Add(Me.BotonGuardar)
        Me.TabPage2.Controls.Add(Me.BotonNuevo)
        Me.TabPage2.Controls.Add(Me.ListaPreferencias)
        Me.TabPage2.Controls.Add(Me.EtiquetaPreferencias)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(635, 265)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Opcionales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BotonSalir
        '
        Me.BotonSalir.Location = New System.Drawing.Point(544, 198)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(75, 23)
        Me.BotonSalir.TabIndex = 5
        Me.BotonSalir.Text = "Salir"
        Me.BotonSalir.UseVisualStyleBackColor = True
        '
        'BotonGuardar
        '
        Me.BotonGuardar.Location = New System.Drawing.Point(451, 198)
        Me.BotonGuardar.Name = "BotonGuardar"
        Me.BotonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BotonGuardar.TabIndex = 4
        Me.BotonGuardar.Text = "Guardar"
        Me.BotonGuardar.UseVisualStyleBackColor = True
        '
        'BotonNuevo
        '
        Me.BotonNuevo.Location = New System.Drawing.Point(357, 198)
        Me.BotonNuevo.Name = "BotonNuevo"
        Me.BotonNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BotonNuevo.TabIndex = 3
        Me.BotonNuevo.Text = "Nuevo"
        Me.BotonNuevo.UseVisualStyleBackColor = True
        '
        'ListaPreferencias
        '
        Me.ListaPreferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaPreferencias.FormattingEnabled = True
        Me.ListaPreferencias.ItemHeight = 16
        Me.ListaPreferencias.Items.AddRange(New Object() {"Leer", "Bailar", "Correr"})
        Me.ListaPreferencias.Location = New System.Drawing.Point(419, 78)
        Me.ListaPreferencias.Name = "ListaPreferencias"
        Me.ListaPreferencias.Size = New System.Drawing.Size(116, 68)
        Me.ListaPreferencias.TabIndex = 2
        '
        'EtiquetaPreferencias
        '
        Me.EtiquetaPreferencias.AutoSize = True
        Me.EtiquetaPreferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaPreferencias.Location = New System.Drawing.Point(438, 53)
        Me.EtiquetaPreferencias.Name = "EtiquetaPreferencias"
        Me.EtiquetaPreferencias.Size = New System.Drawing.Size(84, 16)
        Me.EtiquetaPreferencias.TabIndex = 1
        Me.EtiquetaPreferencias.Text = "Preferencias"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.EtiquetaDescripcion)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 214)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Otros datos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 33)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 162)
        Me.TextBox1.TabIndex = 1
        '
        'EtiquetaDescripcion
        '
        Me.EtiquetaDescripcion.AutoSize = True
        Me.EtiquetaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaDescripcion.Location = New System.Drawing.Point(24, 36)
        Me.EtiquetaDescripcion.Name = "EtiquetaDescripcion"
        Me.EtiquetaDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.EtiquetaDescripcion.TabIndex = 0
        Me.EtiquetaDescripcion.Text = "Descripción"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(253, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(402, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'AGENDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 330)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AGENDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENDA NAVIDAD"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EtiquetaDescripcion As Label
    Friend WithEvents ListaPreferencias As ListBox
    Friend WithEvents EtiquetaPreferencias As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BotonSalir As Button
    Friend WithEvents BotonGuardar As Button
    Friend WithEvents BotonNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
