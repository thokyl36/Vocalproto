<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmotions
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
        Me.components = New System.ComponentModel.Container()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.btnAngry = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.btnScared = New System.Windows.Forms.Button()
        Me.btnExcited = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGo.ForeColor = System.Drawing.Color.Black
        Me.btnGo.Location = New System.Drawing.Point(621, 11)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(86, 38)
        Me.btnGo.TabIndex = 42
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(621, 53)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 38)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Location = New System.Drawing.Point(620, 95)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 38)
        Me.btnClear.TabIndex = 44
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Cyan
        Me.btnBack.Location = New System.Drawing.Point(522, 250)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(185, 25)
        Me.btnBack.TabIndex = 45
        Me.btnBack.Text = "Back to Keyboards"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnHappy
        '
        Me.btnHappy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHappy.Location = New System.Drawing.Point(12, 138)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(129, 99)
        Me.btnHappy.TabIndex = 46
        Me.btnHappy.Text = "Happy"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.BackColor = System.Drawing.Color.Black
        Me.lblSentence.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSentence.ForeColor = System.Drawing.Color.White
        Me.lblSentence.Location = New System.Drawing.Point(11, 11)
        Me.lblSentence.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(0, 39)
        Me.lblSentence.TabIndex = 49
        '
        'btnAngry
        '
        Me.btnAngry.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAngry.Location = New System.Drawing.Point(158, 138)
        Me.btnAngry.Name = "btnAngry"
        Me.btnAngry.Size = New System.Drawing.Size(126, 99)
        Me.btnAngry.TabIndex = 50
        Me.btnAngry.Text = "Angry"
        Me.btnAngry.UseVisualStyleBackColor = True
        '
        'btnSad
        '
        Me.btnSad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSad.Location = New System.Drawing.Point(302, 138)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(122, 99)
        Me.btnSad.TabIndex = 51
        Me.btnSad.Text = "Sad"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'btnScared
        '
        Me.btnScared.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScared.Location = New System.Drawing.Point(439, 138)
        Me.btnScared.Name = "btnScared"
        Me.btnScared.Size = New System.Drawing.Size(127, 99)
        Me.btnScared.TabIndex = 52
        Me.btnScared.Text = "Scared"
        Me.btnScared.UseVisualStyleBackColor = True
        '
        'btnExcited
        '
        Me.btnExcited.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcited.Location = New System.Drawing.Point(582, 138)
        Me.btnExcited.Name = "btnExcited"
        Me.btnExcited.Size = New System.Drawing.Size(124, 99)
        Me.btnExcited.TabIndex = 53
        Me.btnExcited.Text = "Excited"
        Me.btnExcited.UseVisualStyleBackColor = True
        '
        'frmEmotions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(718, 286)
        Me.Controls.Add(Me.btnExcited)
        Me.Controls.Add(Me.btnScared)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnAngry)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.btnHappy)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmEmotions"
        Me.Text = "frmEmotions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnHappy As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblSentence As Label
    Friend WithEvents btnAngry As Button
    Friend WithEvents btnSad As Button
    Friend WithEvents btnScared As Button
    Friend WithEvents btnExcited As Button
End Class
