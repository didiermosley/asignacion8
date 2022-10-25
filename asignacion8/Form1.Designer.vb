<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbProf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCarrera = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnActu = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos"
        '
        'tbCedula
        '
        Me.tbCedula.Location = New System.Drawing.Point(126, 137)
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(100, 20)
        Me.tbCedula.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(126, 208)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(126, 276)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(100, 20)
        Me.tbApellido.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido"
        '
        'tbProf
        '
        Me.tbProf.Location = New System.Drawing.Point(488, 137)
        Me.tbProf.Name = "tbProf"
        Me.tbProf.Size = New System.Drawing.Size(100, 20)
        Me.tbProf.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Profesion"
        '
        'tbCarrera
        '
        Me.tbCarrera.Location = New System.Drawing.Point(488, 208)
        Me.tbCarrera.Name = "tbCarrera"
        Me.tbCarrera.Size = New System.Drawing.Size(100, 20)
        Me.tbCarrera.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(485, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Carrera"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(488, 261)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(112, 35)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Insertar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnActu
        '
        Me.btnActu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActu.Location = New System.Drawing.Point(181, 357)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(112, 35)
        Me.btnActu.TabIndex = 12
        Me.btnActu.Text = "Actualizar"
        Me.btnActu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnActu.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(339, 357)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnConsul
        '
        Me.btnConsul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.Location = New System.Drawing.Point(500, 357)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.Size = New System.Drawing.Size(112, 35)
        Me.btnConsul.TabIndex = 14
        Me.btnConsul.Text = "Consultar"
        Me.btnConsul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnConsul.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(252, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 39)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Para eliminar o consultar solo use el campo de la cédula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (también funciona para" &
    " actualizar)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnConsul)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCarrera)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbProf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCedula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbCedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbProf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCarrera As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnActu As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConsul As Button
    Friend WithEvents Label7 As Label
End Class
