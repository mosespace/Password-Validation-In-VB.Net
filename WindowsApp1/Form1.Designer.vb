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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValBtn1 = New System.Windows.Forms.Button()
        Me.PassBox1 = New System.Windows.Forms.TextBox()
        Me.NameBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'ValBtn1
        '
        Me.ValBtn1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValBtn1.Location = New System.Drawing.Point(356, 231)
        Me.ValBtn1.Name = "ValBtn1"
        Me.ValBtn1.Size = New System.Drawing.Size(173, 35)
        Me.ValBtn1.TabIndex = 2
        Me.ValBtn1.Text = "Validate Password"
        Me.ValBtn1.UseVisualStyleBackColor = True
        '
        'PassBox1
        '
        Me.PassBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassBox1.Location = New System.Drawing.Point(356, 205)
        Me.PassBox1.Name = "PassBox1"
        Me.PassBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox1.Size = New System.Drawing.Size(173, 20)
        Me.PassBox1.TabIndex = 3
        '
        'NameBox1
        '
        Me.NameBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox1.Location = New System.Drawing.Point(356, 179)
        Me.NameBox1.Name = "NameBox1"
        Me.NameBox1.Size = New System.Drawing.Size(173, 20)
        Me.NameBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NameBox1)
        Me.Controls.Add(Me.PassBox1)
        Me.Controls.Add(Me.ValBtn1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Password Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ValBtn1 As Button
    Friend WithEvents PassBox1 As TextBox
    Friend WithEvents NameBox1 As TextBox
End Class
