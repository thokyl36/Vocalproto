<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyboard
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
        Me.btnPeople = New System.Windows.Forms.Button()
        Me.btnEmotions = New System.Windows.Forms.Button()
        Me.btnPronouns = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(175, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Keyboards"
        '
        'btnPeople
        '
        Me.btnPeople.BackColor = System.Drawing.Color.Black
        Me.btnPeople.BackgroundImage = Global.Vocal.My.Resources.Resources.people_folder
        Me.btnPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeople.Location = New System.Drawing.Point(413, 36)
        Me.btnPeople.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPeople.Name = "btnPeople"
        Me.btnPeople.Size = New System.Drawing.Size(111, 109)
        Me.btnPeople.TabIndex = 19
        Me.btnPeople.UseVisualStyleBackColor = False
        '
        'btnEmotions
        '
        Me.btnEmotions.BackColor = System.Drawing.Color.Black
        Me.btnEmotions.BackgroundImage = Global.Vocal.My.Resources.Resources.emotion_folder
        Me.btnEmotions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmotions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmotions.Location = New System.Drawing.Point(145, 36)
        Me.btnEmotions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmotions.Name = "btnEmotions"
        Me.btnEmotions.Size = New System.Drawing.Size(111, 109)
        Me.btnEmotions.TabIndex = 18
        Me.btnEmotions.UseVisualStyleBackColor = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.Color.Black
        Me.btnFood.BackgroundImage = Global.Vocal.My.Resources.Resources.food_folder
        Me.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFood.Location = New System.Drawing.Point(283, 36)
        Me.btnFood.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(111, 109)
        Me.btnFood.TabIndex = 16
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'frmKeyboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(533, 157)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPeople)
        Me.Controls.Add(Me.btnEmotions)
        Me.Controls.Add(Me.btnFood)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmKeyboard"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPeople As Button
    Friend WithEvents btnEmotions As Button
    Friend WithEvents btnPronouns As Button
    Friend WithEvents btnFood As Button
End Class
