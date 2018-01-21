<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perhitungan_Jarak
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.peta = New System.Windows.Forms.TextBox()
        Me.skala = New System.Windows.Forms.TextBox()
        Me.fakskal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ke = New System.Windows.Forms.TextBox()
        Me.dari = New System.Windows.Forms.TextBox()
        Me.Jarakfs = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jarak pada Peta (cm)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penyebut Skala (cm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Faktor Skala"
        '
        'peta
        '
        Me.peta.Location = New System.Drawing.Point(136, 106)
        Me.peta.Name = "peta"
        Me.peta.Size = New System.Drawing.Size(126, 20)
        Me.peta.TabIndex = 3
        '
        'skala
        '
        Me.skala.Location = New System.Drawing.Point(136, 143)
        Me.skala.Name = "skala"
        Me.skala.Size = New System.Drawing.Size(126, 20)
        Me.skala.TabIndex = 4
        '
        'fakskal
        '
        Me.fakskal.Location = New System.Drawing.Point(136, 235)
        Me.fakskal.Name = "fakskal"
        Me.fakskal.Size = New System.Drawing.Size(126, 20)
        Me.fakskal.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Hitung Jarak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ke"
        '
        'ke
        '
        Me.ke.Location = New System.Drawing.Point(136, 67)
        Me.ke.Name = "ke"
        Me.ke.Size = New System.Drawing.Size(126, 20)
        Me.ke.TabIndex = 9
        '
        'dari
        '
        Me.dari.Location = New System.Drawing.Point(136, 29)
        Me.dari.Name = "dari"
        Me.dari.Size = New System.Drawing.Size(126, 20)
        Me.dari.TabIndex = 10
        '
        'Jarakfs
        '
        Me.Jarakfs.Location = New System.Drawing.Point(60, 271)
        Me.Jarakfs.Name = "Jarakfs"
        Me.Jarakfs.Size = New System.Drawing.Size(155, 23)
        Me.Jarakfs.TabIndex = 11
        Me.Jarakfs.Text = "Hitung Jarak "
        Me.Jarakfs.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 9)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "dengan faktor skala"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 9)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "tanpa faktor skala"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Selisih Jarak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(227, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 9)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Oleh Rifki Fauzi"
        '
        'Perhitungan_Jarak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 386)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Jarakfs)
        Me.Controls.Add(Me.dari)
        Me.Controls.Add(Me.ke)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fakskal)
        Me.Controls.Add(Me.skala)
        Me.Controls.Add(Me.peta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Perhitungan_Jarak"
        Me.Text = "Perhitungan Jarak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents peta As System.Windows.Forms.TextBox
    Friend WithEvents skala As System.Windows.Forms.TextBox
    Friend WithEvents fakskal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ke As System.Windows.Forms.TextBox
    Friend WithEvents dari As System.Windows.Forms.TextBox
    Friend WithEvents Jarakfs As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
