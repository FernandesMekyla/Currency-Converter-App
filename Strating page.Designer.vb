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
        Me.lblWelcometo = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblOption2 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtOption1 = New System.Windows.Forms.TextBox()
        Me.txtOption2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcometo
        '
        Me.lblWelcometo.AutoSize = True
        Me.lblWelcometo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcometo.Location = New System.Drawing.Point(83, 46)
        Me.lblWelcometo.Name = "lblWelcometo"
        Me.lblWelcometo.Size = New System.Drawing.Size(128, 22)
        Me.lblWelcometo.TabIndex = 0
        Me.lblWelcometo.Text = "Welcome To: "
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(93, 161)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(75, 18)
        Me.lblOptions.TabIndex = 1
        Me.lblOptions.Text = "Options:"
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption1.Location = New System.Drawing.Point(94, 203)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(72, 18)
        Me.lblOption1.TabIndex = 2
        Me.lblOption1.Text = "Choose 1:"
        '
        'lblOption2
        '
        Me.lblOption2.AutoSize = True
        Me.lblOption2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption2.Location = New System.Drawing.Point(94, 253)
        Me.lblOption2.Name = "lblOption2"
        Me.lblOption2.Size = New System.Drawing.Size(72, 18)
        Me.lblOption2.TabIndex = 3
        Me.lblOption2.Text = "Choose 2:"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(713, 367)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(713, 404)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 34)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Currency_Converter_App.My.Resources.Resources.logo_for_app
        Me.PictureBox1.Location = New System.Drawing.Point(217, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtOption1
        '
        Me.txtOption1.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOption1.Location = New System.Drawing.Point(201, 203)
        Me.txtOption1.Name = "txtOption1"
        Me.txtOption1.Size = New System.Drawing.Size(368, 25)
        Me.txtOption1.TabIndex = 7
        Me.txtOption1.Text = "Choose Option 1 if you want to convert GBP to ANY."
        '
        'txtOption2
        '
        Me.txtOption2.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOption2.Location = New System.Drawing.Point(201, 251)
        Me.txtOption2.Name = "txtOption2"
        Me.txtOption2.Size = New System.Drawing.Size(368, 25)
        Me.txtOption2.TabIndex = 8
        Me.txtOption2.Text = "Choose Option 1 if you want to convert ANY to ANY."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOption2)
        Me.Controls.Add(Me.txtOption1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblOption2)
        Me.Controls.Add(Me.lblOption1)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblWelcometo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcometo As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents lblOption1 As Label
    Friend WithEvents lblOption2 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtOption1 As TextBox
    Friend WithEvents txtOption2 As TextBox
End Class
