<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblThankyou = New System.Windows.Forms.Label()
        Me.lblThankyouforusingWorldMoney = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Currency_Converter_App.My.Resources.Resources.logo_for_app
        Me.PictureBox1.Location = New System.Drawing.Point(272, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lblThankyou
        '
        Me.lblThankyou.AutoSize = True
        Me.lblThankyou.Font = New System.Drawing.Font("Felix Titling", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThankyou.Location = New System.Drawing.Point(233, 249)
        Me.lblThankyou.Name = "lblThankyou"
        Me.lblThankyou.Size = New System.Drawing.Size(148, 24)
        Me.lblThankyou.TabIndex = 8
        Me.lblThankyou.Text = "THANKYOU!!!!"
        '
        'lblThankyouforusingWorldMoney
        '
        Me.lblThankyouforusingWorldMoney.AutoSize = True
        Me.lblThankyouforusingWorldMoney.Font = New System.Drawing.Font("Felix Titling", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThankyouforusingWorldMoney.Location = New System.Drawing.Point(151, 318)
        Me.lblThankyouforusingWorldMoney.Name = "lblThankyouforusingWorldMoney"
        Me.lblThankyouforusingWorldMoney.Size = New System.Drawing.Size(514, 23)
        Me.lblThankyouforusingWorldMoney.TabIndex = 9
        Me.lblThankyouforusingWorldMoney.Text = "Successful, Thankyou for using World Money "
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(713, 406)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 32)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblThankyouforusingWorldMoney)
        Me.Controls.Add(Me.lblThankyou)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblThankyou As Label
    Friend WithEvents lblThankyouforusingWorldMoney As Label
    Friend WithEvents btnQuit As Button
End Class
