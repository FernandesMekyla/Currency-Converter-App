<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtGBPAmount = New System.Windows.Forms.TextBox()
        Me.txtANYAmount = New System.Windows.Forms.TextBox()
        Me.ComboBoxGBP1 = New System.Windows.Forms.ComboBox()
        Me.lblGBP = New System.Windows.Forms.Label()
        Me.lblANY = New System.Windows.Forms.Label()
        Me.ComboBoxAny1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(119, 62)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(45, 19)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(574, 62)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 19)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To:"
        '
        'txtGBPAmount
        '
        Me.txtGBPAmount.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGBPAmount.Location = New System.Drawing.Point(122, 129)
        Me.txtGBPAmount.Name = "txtGBPAmount"
        Me.txtGBPAmount.Size = New System.Drawing.Size(100, 28)
        Me.txtGBPAmount.TabIndex = 2
        '
        'txtANYAmount
        '
        Me.txtANYAmount.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANYAmount.Location = New System.Drawing.Point(577, 129)
        Me.txtANYAmount.Name = "txtANYAmount"
        Me.txtANYAmount.Size = New System.Drawing.Size(100, 28)
        Me.txtANYAmount.TabIndex = 3
        '
        'ComboBoxGBP1
        '
        Me.ComboBoxGBP1.FormattingEnabled = True
        Me.ComboBoxGBP1.Location = New System.Drawing.Point(122, 165)
        Me.ComboBoxGBP1.Name = "ComboBoxGBP1"
        Me.ComboBoxGBP1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxGBP1.TabIndex = 4
        Me.ComboBoxGBP1.Text = "Choose your currency"
        '
        'lblGBP
        '
        Me.lblGBP.AutoSize = True
        Me.lblGBP.Font = New System.Drawing.Font("Californian FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGBP.Location = New System.Drawing.Point(119, 101)
        Me.lblGBP.Name = "lblGBP"
        Me.lblGBP.Size = New System.Drawing.Size(41, 19)
        Me.lblGBP.TabIndex = 6
        Me.lblGBP.Text = "GBP:"
        '
        'lblANY
        '
        Me.lblANY.AutoSize = True
        Me.lblANY.Font = New System.Drawing.Font("Californian FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANY.Location = New System.Drawing.Point(574, 101)
        Me.lblANY.Name = "lblANY"
        Me.lblANY.Size = New System.Drawing.Size(44, 19)
        Me.lblANY.TabIndex = 7
        Me.lblANY.Text = "ANY:"
        '
        'ComboBoxAny1
        '
        Me.ComboBoxAny1.FormattingEnabled = True
        Me.ComboBoxAny1.Location = New System.Drawing.Point(577, 165)
        Me.ComboBoxAny1.Name = "ComboBoxAny1"
        Me.ComboBoxAny1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxAny1.TabIndex = 9
        Me.ComboBoxAny1.Text = "Choose your currency"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Currency_Converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(348, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(713, 367)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 29)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(713, 406)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 32)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.ComboBoxAny1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblANY)
        Me.Controls.Add(Me.lblGBP)
        Me.Controls.Add(Me.ComboBoxGBP1)
        Me.Controls.Add(Me.txtANYAmount)
        Me.Controls.Add(Me.txtGBPAmount)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents txtGBPAmount As TextBox
    Friend WithEvents txtANYAmount As TextBox
    Friend WithEvents ComboBoxGBP1 As ComboBox
    Friend WithEvents lblGBP As Label
    Friend WithEvents lblANY As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxAny1 As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnQuit As Button
End Class
