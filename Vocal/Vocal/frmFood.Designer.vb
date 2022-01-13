<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFood
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPizza = New System.Windows.Forms.Button()
        Me.btnMilk = New System.Windows.Forms.Button()
        Me.btnChicken = New System.Windows.Forms.Button()
        Me.btnPasta = New System.Windows.Forms.Button()
        Me.btnChips = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(703, 91)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 38)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(703, 49)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 38)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(703, 7)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(86, 38)
        Me.btnGo.TabIndex = 31
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSentence.ForeColor = System.Drawing.Color.White
        Me.lblSentence.Location = New System.Drawing.Point(8, 15)
        Me.lblSentence.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(0, 39)
        Me.lblSentence.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(604, 260)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 25)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Back to Keyboards"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPizza
        '
        Me.btnPizza.BackColor = System.Drawing.Color.Black
        Me.btnPizza.BackgroundImage = Global.Vocal.My.Resources.Resources.Pizza
        Me.btnPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPizza.ForeColor = System.Drawing.Color.White
        Me.btnPizza.Location = New System.Drawing.Point(15, 133)
        Me.btnPizza.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPizza.Name = "btnPizza"
        Me.btnPizza.Size = New System.Drawing.Size(140, 105)
        Me.btnPizza.TabIndex = 25
        Me.btnPizza.Text = "Pizza"
        Me.btnPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPizza.UseVisualStyleBackColor = False
        '
        'btnMilk
        '
        Me.btnMilk.BackColor = System.Drawing.Color.Black
        Me.btnMilk.BackgroundImage = Global.Vocal.My.Resources.Resources.IMG_08251
        Me.btnMilk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMilk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMilk.ForeColor = System.Drawing.Color.White
        Me.btnMilk.Location = New System.Drawing.Point(175, 133)
        Me.btnMilk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMilk.Name = "btnMilk"
        Me.btnMilk.Size = New System.Drawing.Size(140, 105)
        Me.btnMilk.TabIndex = 27
        Me.btnMilk.Text = "Milk"
        Me.btnMilk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMilk.UseVisualStyleBackColor = False
        '
        'btnChicken
        '
        Me.btnChicken.BackColor = System.Drawing.Color.Black
        Me.btnChicken.BackgroundImage = Global.Vocal.My.Resources.Resources.IMG_0821
        Me.btnChicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChicken.ForeColor = System.Drawing.Color.White
        Me.btnChicken.Location = New System.Drawing.Point(329, 133)
        Me.btnChicken.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnChicken.Name = "btnChicken"
        Me.btnChicken.Size = New System.Drawing.Size(140, 105)
        Me.btnChicken.TabIndex = 26
        Me.btnChicken.Text = "Chicken"
        Me.btnChicken.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChicken.UseVisualStyleBackColor = False
        '
        'btnPasta
        '
        Me.btnPasta.BackgroundImage = Global.Vocal.My.Resources.Resources.IMG_0826
        Me.btnPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasta.ForeColor = System.Drawing.Color.White
        Me.btnPasta.Location = New System.Drawing.Point(483, 133)
        Me.btnPasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Size = New System.Drawing.Size(140, 105)
        Me.btnPasta.TabIndex = 28
        Me.btnPasta.Text = "Pasta"
        Me.btnPasta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPasta.UseVisualStyleBackColor = True
        '
        'btnChips
        '
        Me.btnChips.BackgroundImage = Global.Vocal.My.Resources.Resources.IMG_0823
        Me.btnChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChips.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChips.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChips.ForeColor = System.Drawing.Color.White
        Me.btnChips.Location = New System.Drawing.Point(644, 133)
        Me.btnChips.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnChips.Name = "btnChips"
        Me.btnChips.Size = New System.Drawing.Size(140, 105)
        Me.btnChips.TabIndex = 30
        Me.btnChips.Text = "Chips"
        Me.btnChips.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChips.UseVisualStyleBackColor = True
        '
        'frmFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 296)
        Me.Controls.Add(Me.btnPizza)
        Me.Controls.Add(Me.btnMilk)
        Me.Controls.Add(Me.btnChicken)
        Me.Controls.Add(Me.btnPasta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.btnChips)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmFood"
        Me.Text = "Food Keyboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents btnChips As Button
    Friend WithEvents lblSentence As Label
    Friend WithEvents btnPasta As Button
    Friend WithEvents btnMilk As Button
    Friend WithEvents btnChicken As Button
    Friend WithEvents btnPizza As Button
    Friend WithEvents Button1 As Button
End Class
