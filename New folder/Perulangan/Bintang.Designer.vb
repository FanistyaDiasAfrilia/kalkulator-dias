<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.Lbl_pola = New System.Windows.Forms.Label()
        Me.Lbl_baris = New System.Windows.Forms.Label()
        Me.textboxbaris = New System.Windows.Forms.TextBox()
        Me.buttonhasil = New System.Windows.Forms.Button()
        Me.textboxhasil = New System.Windows.Forms.TextBox()
        Me.combopola = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lbl_pola
        '
        Me.Lbl_pola.AutoSize = True
        Me.Lbl_pola.Location = New System.Drawing.Point(13, 19)
        Me.Lbl_pola.Name = "Lbl_pola"
        Me.Lbl_pola.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_pola.TabIndex = 1
        Me.Lbl_pola.Text = "Pola :"
        '
        'Lbl_baris
        '
        Me.Lbl_baris.AutoSize = True
        Me.Lbl_baris.Location = New System.Drawing.Point(13, 65)
        Me.Lbl_baris.Name = "Lbl_baris"
        Me.Lbl_baris.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_baris.TabIndex = 2
        Me.Lbl_baris.Text = "Baris :"
        '
        'textboxbaris
        '
        Me.textboxbaris.Location = New System.Drawing.Point(53, 62)
        Me.textboxbaris.Name = "textboxbaris"
        Me.textboxbaris.Size = New System.Drawing.Size(266, 20)
        Me.textboxbaris.TabIndex = 3
        '
        'buttonhasil
        '
        Me.buttonhasil.Location = New System.Drawing.Point(325, 60)
        Me.buttonhasil.Name = "buttonhasil"
        Me.buttonhasil.Size = New System.Drawing.Size(114, 23)
        Me.buttonhasil.TabIndex = 4
        Me.buttonhasil.Text = "hasil"
        Me.buttonhasil.UseVisualStyleBackColor = True
        '
        'textboxhasil
        '
        Me.textboxhasil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxhasil.Location = New System.Drawing.Point(16, 108)
        Me.textboxhasil.Multiline = True
        Me.textboxhasil.Name = "textboxhasil"
        Me.textboxhasil.Size = New System.Drawing.Size(423, 305)
        Me.textboxhasil.TabIndex = 5
        '
        'combopola
        '
        Me.combopola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combopola.FormattingEnabled = True
        Me.combopola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.combopola.Location = New System.Drawing.Point(53, 15)
        Me.combopola.Name = "combopola"
        Me.combopola.Size = New System.Drawing.Size(386, 21)
        Me.combopola.TabIndex = 2
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.combopola)
        Me.Controls.Add(Me.textboxhasil)
        Me.Controls.Add(Me.buttonhasil)
        Me.Controls.Add(Me.textboxbaris)
        Me.Controls.Add(Me.Lbl_baris)
        Me.Controls.Add(Me.Lbl_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_pola As System.Windows.Forms.Label
    Friend WithEvents Lbl_baris As System.Windows.Forms.Label
    Friend WithEvents textboxbaris As System.Windows.Forms.TextBox
    Friend WithEvents buttonhasil As System.Windows.Forms.Button
    Friend WithEvents textboxhasil As System.Windows.Forms.TextBox
    Friend WithEvents combopola As System.Windows.Forms.ComboBox
End Class
