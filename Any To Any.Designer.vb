<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtANYAmount1 = New System.Windows.Forms.TextBox()
        Me.txtANYAmount2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxANY2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxANY3 = New System.Windows.Forms.ComboBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAny2 = New System.Windows.Forms.TextBox()
        Me.txtAny1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(100, 68)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(45, 19)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(622, 68)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 19)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Currency_Converter_App.My.Resources.Resources.reverse_arrows
        Me.PictureBox1.Location = New System.Drawing.Point(355, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtANYAmount1
        '
        Me.txtANYAmount1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANYAmount1.Location = New System.Drawing.Point(104, 152)
        Me.txtANYAmount1.Name = "txtANYAmount1"
        Me.txtANYAmount1.Size = New System.Drawing.Size(100, 28)
        Me.txtANYAmount1.TabIndex = 12
        '
        'txtANYAmount2
        '
        Me.txtANYAmount2.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANYAmount2.Location = New System.Drawing.Point(626, 152)
        Me.txtANYAmount2.Name = "txtANYAmount2"
        Me.txtANYAmount2.Size = New System.Drawing.Size(100, 28)
        Me.txtANYAmount2.TabIndex = 13
        '
        'ComboBoxANY2
        '
        Me.ComboBoxANY2.FormattingEnabled = True
        Me.ComboBoxANY2.Location = New System.Drawing.Point(104, 209)
        Me.ComboBoxANY2.Name = "ComboBoxANY2"
        Me.ComboBoxANY2.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxANY2.TabIndex = 14
        Me.ComboBoxANY2.Text = "Choose your currency"
        '
        'ComboBoxANY3
        '
        Me.ComboBoxANY3.FormattingEnabled = True
        Me.ComboBoxANY3.Location = New System.Drawing.Point(626, 209)
        Me.ComboBoxANY3.Name = "ComboBoxANY3"
        Me.ComboBoxANY3.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxANY3.TabIndex = 15
        Me.ComboBoxANY3.Text = "Choose your currency"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(713, 406)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 32)
        Me.btnQuit.TabIndex = 16
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(713, 371)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 29)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtAny2
        '
        Me.txtAny2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAny2.Location = New System.Drawing.Point(626, 114)
        Me.txtAny2.Name = "txtAny2"
        Me.txtAny2.Size = New System.Drawing.Size(100, 24)
        Me.txtAny2.TabIndex = 20
        Me.txtAny2.Text = "ANY:"
        '
        'txtAny1
        '
        Me.txtAny1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAny1.Location = New System.Drawing.Point(104, 114)
        Me.txtAny1.Name = "txtAny1"
        Me.txtAny1.Size = New System.Drawing.Size(100, 24)
        Me.txtAny1.TabIndex = 21
        Me.txtAny1.Text = "ANY:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAny1)
        Me.Controls.Add(Me.txtAny2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.ComboBoxANY3)
        Me.Controls.Add(Me.ComboBoxANY2)
        Me.Controls.Add(Me.txtANYAmount2)
        Me.Controls.Add(Me.txtANYAmount1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtANYAmount1 As TextBox
    Friend WithEvents txtANYAmount2 As TextBox
    Friend WithEvents ComboBoxANY2 As ComboBox
    Friend WithEvents ComboBoxANY3 As ComboBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtAny2 As TextBox
    Friend WithEvents txtAny1 As TextBox
End Class
