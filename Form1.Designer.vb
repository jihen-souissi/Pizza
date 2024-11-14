<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lsttaille = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Rdproposition1 = New RadioButton()
        Rdproposition2 = New RadioButton()
        Rdproposition3 = New RadioButton()
        Chk1 = New CheckBox()
        Chk2 = New CheckBox()
        Chk3 = New CheckBox()
        Chk4 = New CheckBox()
        Label3 = New Label()
        Label4 = New Label()
        Btn = New Button()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' lsttaille
        ' 
        lsttaille.FormattingEnabled = True
        lsttaille.Items.AddRange(New Object() {"Petite", "Moyenne", "Grande"})
        lsttaille.Location = New Point(199, 48)
        lsttaille.Name = "lsttaille"
        lsttaille.Size = New Size(151, 28)
        lsttaille.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(49, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 1
        Label1.Text = "Taille de la pizza  :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(49, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 2
        Label2.Text = "Type de croute : "
        ' 
        ' Rdproposition1
        ' 
        Rdproposition1.AutoSize = True
        Rdproposition1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Rdproposition1.Location = New Point(199, 115)
        Rdproposition1.Name = "Rdproposition1"
        Rdproposition1.Size = New Size(105, 24)
        Rdproposition1.TabIndex = 3
        Rdproposition1.TabStop = True
        Rdproposition1.Text = "Croute Fine"
        Rdproposition1.UseVisualStyleBackColor = False
        ' 
        ' Rdproposition2
        ' 
        Rdproposition2.AutoSize = True
        Rdproposition2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Rdproposition2.Location = New Point(368, 113)
        Rdproposition2.Name = "Rdproposition2"
        Rdproposition2.Size = New Size(140, 24)
        Rdproposition2.TabIndex = 4
        Rdproposition2.TabStop = True
        Rdproposition2.Text = "Croute Classique"
        Rdproposition2.UseVisualStyleBackColor = False
        ' 
        ' Rdproposition3
        ' 
        Rdproposition3.AutoSize = True
        Rdproposition3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Rdproposition3.Location = New Point(564, 113)
        Rdproposition3.Name = "Rdproposition3"
        Rdproposition3.Size = New Size(127, 24)
        Rdproposition3.TabIndex = 5
        Rdproposition3.TabStop = True
        Rdproposition3.Text = "Croute épaisse"
        Rdproposition3.UseVisualStyleBackColor = False
        ' 
        ' Chk1
        ' 
        Chk1.AutoSize = True
        Chk1.BackColor = Color.White
        Chk1.Location = New Point(309, 191)
        Chk1.Name = "Chk1"
        Chk1.Size = New Size(122, 24)
        Chk1.TabIndex = 6
        Chk1.Text = "Champignons"
        Chk1.UseVisualStyleBackColor = False
        ' 
        ' Chk2
        ' 
        Chk2.AutoSize = True
        Chk2.BackColor = Color.OliveDrab
        Chk2.ForeColor = SystemColors.ButtonFace
        Chk2.Location = New Point(468, 191)
        Chk2.Name = "Chk2"
        Chk2.Size = New Size(71, 24)
        Chk2.TabIndex = 7
        Chk2.Text = "Olives"
        Chk2.UseVisualStyleBackColor = False
        ' 
        ' Chk3
        ' 
        Chk3.AutoSize = True
        Chk3.BackColor = Color.Green
        Chk3.ForeColor = SystemColors.ButtonFace
        Chk3.Location = New Point(309, 242)
        Chk3.Name = "Chk3"
        Chk3.Size = New Size(86, 24)
        Chk3.TabIndex = 8
        Chk3.Text = "Poivrons"
        Chk3.UseVisualStyleBackColor = False
        ' 
        ' Chk4
        ' 
        Chk4.AutoSize = True
        Chk4.BackColor = Color.Gold
        Chk4.Location = New Point(465, 242)
        Chk4.Name = "Chk4"
        Chk4.Size = New Size(210, 24)
        Chk4.TabIndex = 9
        Chk4.Text = "Frommage supplémentaire"
        Chk4.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(49, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(232, 20)
        Label3.TabIndex = 10
        Label3.Text = "Les ingrédients supplémentaires : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(49, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 20)
        Label4.TabIndex = 11
        Label4.Text = "Le récapitulatif : "
        ' 
        ' Btn
        ' 
        Btn.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Btn.Location = New Point(222, 335)
        Btn.Name = "Btn"
        Btn.Size = New Size(71, 59)
        Btn.TabIndex = 12
        Btn.Text = "Afficher"
        Btn.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        RichTextBox1.Location = New Point(368, 335)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(307, 120)
        RichTextBox1.TabIndex = 14
        RichTextBox1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(975, 544)
        Controls.Add(RichTextBox1)
        Controls.Add(Btn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Chk4)
        Controls.Add(Chk3)
        Controls.Add(Chk2)
        Controls.Add(Chk1)
        Controls.Add(Rdproposition3)
        Controls.Add(Rdproposition2)
        Controls.Add(Rdproposition1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lsttaille)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsttaille As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Rdproposition1 As RadioButton
    Friend WithEvents Rdproposition2 As RadioButton
    Friend WithEvents Rdproposition3 As RadioButton
    Friend WithEvents Chk1 As CheckBox
    Friend WithEvents Chk2 As CheckBox
    Friend WithEvents Chk3 As CheckBox
    Friend WithEvents Chk4 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn As Button
    Friend WithEvents RichTextBox1 As RichTextBox

End Class
