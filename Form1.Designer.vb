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
        Me.save_btn = New System.Windows.Forms.Button()
        Me.namee = New System.Windows.Forms.TextBox()
        Me.fave_num = New System.Windows.Forms.TextBox()
        Me.recieved = New System.Windows.Forms.Label()
        Me.name_out = New System.Windows.Forms.Label()
        Me.fave_num_out = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your Favorite Number:"
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(109, 128)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 2
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'namee
        '
        Me.namee.Location = New System.Drawing.Point(159, 43)
        Me.namee.Name = "namee"
        Me.namee.Size = New System.Drawing.Size(146, 20)
        Me.namee.TabIndex = 3
        '
        'fave_num
        '
        Me.fave_num.Location = New System.Drawing.Point(159, 81)
        Me.fave_num.Name = "fave_num"
        Me.fave_num.Size = New System.Drawing.Size(146, 20)
        Me.fave_num.TabIndex = 4
        '
        'recieved
        '
        Me.recieved.AutoSize = True
        Me.recieved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recieved.Location = New System.Drawing.Point(0, 154)
        Me.recieved.Name = "recieved"
        Me.recieved.Size = New System.Drawing.Size(11, 13)
        Me.recieved.TabIndex = 5
        Me.recieved.Text = ":"
        '
        'name_out
        '
        Me.name_out.AutoSize = True
        Me.name_out.Location = New System.Drawing.Point(0, 183)
        Me.name_out.Name = "name_out"
        Me.name_out.Size = New System.Drawing.Size(10, 13)
        Me.name_out.TabIndex = 6
        Me.name_out.Text = ":"
        '
        'fave_num_out
        '
        Me.fave_num_out.AutoSize = True
        Me.fave_num_out.Location = New System.Drawing.Point(0, 214)
        Me.fave_num_out.Name = "fave_num_out"
        Me.fave_num_out.Size = New System.Drawing.Size(10, 13)
        Me.fave_num_out.TabIndex = 7
        Me.fave_num_out.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 236)
        Me.Controls.Add(Me.fave_num_out)
        Me.Controls.Add(Me.name_out)
        Me.Controls.Add(Me.recieved)
        Me.Controls.Add(Me.fave_num)
        Me.Controls.Add(Me.namee)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "vbpMod10_Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents namee As TextBox
    Friend WithEvents fave_num As TextBox
    Friend WithEvents recieved As Label
    Friend WithEvents name_out As Label
    Friend WithEvents fave_num_out As Label
End Class
