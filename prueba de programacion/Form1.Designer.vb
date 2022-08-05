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
        Me.BtnRed = New System.Windows.Forms.Button()
        Me.BtnGreen = New System.Windows.Forms.Button()
        Me.BtnPurple = New System.Windows.Forms.Button()
        Me.BtnBlue = New System.Windows.Forms.Button()
        Me.BtnPink = New System.Windows.Forms.Button()
        Me.TextColor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRed
        '
        Me.BtnRed.Location = New System.Drawing.Point(33, 12)
        Me.BtnRed.Name = "BtnRed"
        Me.BtnRed.Size = New System.Drawing.Size(136, 45)
        Me.BtnRed.TabIndex = 0
        Me.BtnRed.Text = "Rojo"
        Me.BtnRed.UseVisualStyleBackColor = True
        '
        'BtnGreen
        '
        Me.BtnGreen.Location = New System.Drawing.Point(33, 78)
        Me.BtnGreen.Name = "BtnGreen"
        Me.BtnGreen.Size = New System.Drawing.Size(140, 43)
        Me.BtnGreen.TabIndex = 1
        Me.BtnGreen.Text = "Verde "
        Me.BtnGreen.UseVisualStyleBackColor = True
        '
        'BtnPurple
        '
        Me.BtnPurple.Location = New System.Drawing.Point(33, 154)
        Me.BtnPurple.Name = "BtnPurple"
        Me.BtnPurple.Size = New System.Drawing.Size(136, 44)
        Me.BtnPurple.TabIndex = 2
        Me.BtnPurple.Text = "Morado"
        Me.BtnPurple.UseVisualStyleBackColor = True
        '
        'BtnBlue
        '
        Me.BtnBlue.Location = New System.Drawing.Point(33, 214)
        Me.BtnBlue.Name = "BtnBlue"
        Me.BtnBlue.Size = New System.Drawing.Size(136, 42)
        Me.BtnBlue.TabIndex = 3
        Me.BtnBlue.Text = "Azul"
        Me.BtnBlue.UseVisualStyleBackColor = True
        '
        'BtnPink
        '
        Me.BtnPink.Location = New System.Drawing.Point(33, 275)
        Me.BtnPink.Name = "BtnPink"
        Me.BtnPink.Size = New System.Drawing.Size(136, 40)
        Me.BtnPink.TabIndex = 4
        Me.BtnPink.Text = "Rosado"
        Me.BtnPink.UseVisualStyleBackColor = True
        '
        'TextColor
        '
        Me.TextColor.Location = New System.Drawing.Point(212, 25)
        Me.TextColor.Multiline = True
        Me.TextColor.Name = "TextColor"
        Me.TextColor.Size = New System.Drawing.Size(400, 290)
        Me.TextColor.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(334, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ricardo R.Z"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextColor)
        Me.Controls.Add(Me.BtnPink)
        Me.Controls.Add(Me.BtnBlue)
        Me.Controls.Add(Me.BtnPurple)
        Me.Controls.Add(Me.BtnGreen)
        Me.Controls.Add(Me.BtnRed)
        Me.Name = "Form1"
        Me.Text = "frmColores "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRed As Button
    Friend WithEvents BtnGreen As Button
    Friend WithEvents BtnPurple As Button
    Friend WithEvents BtnBlue As Button
    Friend WithEvents BtnPink As Button
    Friend WithEvents TextColor As TextBox
    Friend WithEvents Label1 As Label
End Class
