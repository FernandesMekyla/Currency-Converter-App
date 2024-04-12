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
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.lblUSD = New System.Windows.Forms.Label()
        Me.lblINR = New System.Windows.Forms.Label()
        Me.lblEUR = New System.Windows.Forms.Label()
        Me.lblYEN = New System.Windows.Forms.Label()
        Me.txtUSD = New System.Windows.Forms.TextBox()
        Me.txtINR = New System.Windows.Forms.TextBox()
        Me.txtEUR = New System.Windows.Forms.TextBox()
        Me.txtYEN = New System.Windows.Forms.TextBox()
        Me.lblGBP = New System.Windows.Forms.Label()
        Me.txtGBP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSAVE
        '
        Me.btnSAVE.Font = New System.Drawing.Font("Georgia Pro Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSAVE.Location = New System.Drawing.Point(510, 211)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(93, 45)
        Me.btnSAVE.TabIndex = 0
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'lblUSD
        '
        Me.lblUSD.AutoSize = True
        Me.lblUSD.Font = New System.Drawing.Font("Georgia Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUSD.Location = New System.Drawing.Point(124, 74)
        Me.lblUSD.Name = "lblUSD"
        Me.lblUSD.Size = New System.Drawing.Size(44, 18)
        Me.lblUSD.TabIndex = 1
        Me.lblUSD.Text = "USD"
        '
        'lblINR
        '
        Me.lblINR.AutoSize = True
        Me.lblINR.Font = New System.Drawing.Font("Georgia Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblINR.Location = New System.Drawing.Point(124, 164)
        Me.lblINR.Name = "lblINR"
        Me.lblINR.Size = New System.Drawing.Size(40, 18)
        Me.lblINR.TabIndex = 2
        Me.lblINR.Text = "INR"
        '
        'lblEUR
        '
        Me.lblEUR.AutoSize = True
        Me.lblEUR.Font = New System.Drawing.Font("Georgia Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEUR.Location = New System.Drawing.Point(124, 257)
        Me.lblEUR.Name = "lblEUR"
        Me.lblEUR.Size = New System.Drawing.Size(44, 18)
        Me.lblEUR.TabIndex = 3
        Me.lblEUR.Text = "EUR"
        '
        'lblYEN
        '
        Me.lblYEN.AutoSize = True
        Me.lblYEN.Font = New System.Drawing.Font("Georgia Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblYEN.Location = New System.Drawing.Point(124, 354)
        Me.lblYEN.Name = "lblYEN"
        Me.lblYEN.Size = New System.Drawing.Size(43, 18)
        Me.lblYEN.TabIndex = 4
        Me.lblYEN.Text = "YEN"
        '
        'txtUSD
        '
        Me.txtUSD.Location = New System.Drawing.Point(233, 66)
        Me.txtUSD.Name = "txtUSD"
        Me.txtUSD.Size = New System.Drawing.Size(100, 23)
        Me.txtUSD.TabIndex = 5
        '
        'txtINR
        '
        Me.txtINR.Location = New System.Drawing.Point(233, 156)
        Me.txtINR.Name = "txtINR"
        Me.txtINR.Size = New System.Drawing.Size(100, 23)
        Me.txtINR.TabIndex = 6
        '
        'txtEUR
        '
        Me.txtEUR.Location = New System.Drawing.Point(233, 249)
        Me.txtEUR.Name = "txtEUR"
        Me.txtEUR.Size = New System.Drawing.Size(100, 23)
        Me.txtEUR.TabIndex = 7
        '
        'txtYEN
        '
        Me.txtYEN.Location = New System.Drawing.Point(233, 346)
        Me.txtYEN.Name = "txtYEN"
        Me.txtYEN.Size = New System.Drawing.Size(100, 23)
        Me.txtYEN.TabIndex = 8
        '
        'lblGBP
        '
        Me.lblGBP.AutoSize = True
        Me.lblGBP.Font = New System.Drawing.Font("Georgia Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGBP.Location = New System.Drawing.Point(124, 451)
        Me.lblGBP.Name = "lblGBP"
        Me.lblGBP.Size = New System.Drawing.Size(41, 18)
        Me.lblGBP.TabIndex = 9
        Me.lblGBP.Text = "GBP"
        '
        'txtGBP
        '
        Me.txtGBP.Location = New System.Drawing.Point(233, 446)
        Me.txtGBP.Name = "txtGBP"
        Me.txtGBP.Size = New System.Drawing.Size(100, 23)
        Me.txtGBP.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 525)
        Me.Controls.Add(Me.txtGBP)
        Me.Controls.Add(Me.lblGBP)
        Me.Controls.Add(Me.txtYEN)
        Me.Controls.Add(Me.txtEUR)
        Me.Controls.Add(Me.txtINR)
        Me.Controls.Add(Me.txtUSD)
        Me.Controls.Add(Me.lblYEN)
        Me.Controls.Add(Me.lblEUR)
        Me.Controls.Add(Me.lblINR)
        Me.Controls.Add(Me.lblUSD)
        Me.Controls.Add(Me.btnSAVE)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSAVE As Button
    Friend WithEvents lblUSD As Label
    Friend WithEvents lblINR As Label
    Friend WithEvents lblEUR As Label
    Friend WithEvents lblYEN As Label
    Friend WithEvents txtUSD As TextBox
    Friend WithEvents txtINR As TextBox
    Friend WithEvents txtEUR As TextBox
    Friend WithEvents txtYEN As TextBox
    Friend WithEvents lblGBP As Label
    Friend WithEvents txtGBP As TextBox
End Class
