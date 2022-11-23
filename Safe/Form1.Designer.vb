<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.botoniniciarsesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.etiquetasafe = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botoniniciarsesion
        '
        Me.botoniniciarsesion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botoniniciarsesion.ForeColor = System.Drawing.Color.DarkBlue
        Me.botoniniciarsesion.Location = New System.Drawing.Point(303, 291)
        Me.botoniniciarsesion.Name = "botoniniciarsesion"
        Me.botoniniciarsesion.Size = New System.Drawing.Size(180, 82)
        Me.botoniniciarsesion.TabIndex = 0
        Me.botoniniciarsesion.Text = "BIENVENIDO"
        Me.botoniniciarsesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(274, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'etiquetasafe
        '
        Me.etiquetasafe.AutoSize = True
        Me.etiquetasafe.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasafe.Location = New System.Drawing.Point(355, 186)
        Me.etiquetasafe.Name = "etiquetasafe"
        Me.etiquetasafe.Size = New System.Drawing.Size(80, 33)
        Me.etiquetasafe.TabIndex = 2
        Me.etiquetasafe.Text = "SAFE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.etiquetasafe)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.botoniniciarsesion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "INICIO DE SESIÓN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botoniniciarsesion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents etiquetasafe As Label
End Class
