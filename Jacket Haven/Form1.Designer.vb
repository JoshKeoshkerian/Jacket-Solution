<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpOrdered = New System.Windows.Forms.GroupBox()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBlack = New System.Windows.Forms.TextBox()
        Me.txtNavy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCard = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalOrdered = New System.Windows.Forms.Label()
        Me.lblMoneySaved = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpOrdered.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOrdered
        '
        Me.grpOrdered.Controls.Add(Me.grpResults)
        Me.grpOrdered.Controls.Add(Me.txtRed)
        Me.grpOrdered.Controls.Add(Me.TextBox2)
        Me.grpOrdered.Controls.Add(Me.Label3)
        Me.grpOrdered.Controls.Add(Me.txtBlack)
        Me.grpOrdered.Controls.Add(Me.txtNavy)
        Me.grpOrdered.Controls.Add(Me.Label2)
        Me.grpOrdered.Controls.Add(Me.Label1)
        Me.grpOrdered.Location = New System.Drawing.Point(12, 12)
        Me.grpOrdered.Name = "grpOrdered"
        Me.grpOrdered.Size = New System.Drawing.Size(111, 124)
        Me.grpOrdered.TabIndex = 0
        Me.grpOrdered.TabStop = False
        Me.grpOrdered.Text = "Ordered"
        '
        'grpResults
        '
        Me.grpResults.Location = New System.Drawing.Point(27, 130)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(362, 54)
        Me.grpResults.TabIndex = 10
        Me.grpResults.TabStop = False
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(46, 81)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(44, 20)
        Me.txtRed.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(63, 138)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(44, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Red"
        '
        'txtBlack
        '
        Me.txtBlack.Location = New System.Drawing.Point(46, 25)
        Me.txtBlack.Multiline = True
        Me.txtBlack.Name = "txtBlack"
        Me.txtBlack.Size = New System.Drawing.Size(44, 20)
        Me.txtBlack.TabIndex = 1
        '
        'txtNavy
        '
        Me.txtNavy.Location = New System.Drawing.Point(46, 53)
        Me.txtNavy.Name = "txtNavy"
        Me.txtNavy.Size = New System.Drawing.Size(44, 20)
        Me.txtNavy.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Navy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Black"
        '
        'chkCard
        '
        Me.chkCard.AutoSize = True
        Me.chkCard.Location = New System.Drawing.Point(296, 23)
        Me.chkCard.Name = "chkCard"
        Me.chkCard.Size = New System.Drawing.Size(113, 17)
        Me.chkCard.TabIndex = 1
        Me.chkCard.Text = "&Jacket Credit Card"
        Me.chkCard.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(319, 60)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(319, 87)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Ordered"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Due"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Money Saved"
        '
        'lblTotalOrdered
        '
        Me.lblTotalOrdered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalOrdered.Location = New System.Drawing.Point(58, 173)
        Me.lblTotalOrdered.Name = "lblTotalOrdered"
        Me.lblTotalOrdered.Size = New System.Drawing.Size(69, 23)
        Me.lblTotalOrdered.TabIndex = 7
        '
        'lblMoneySaved
        '
        Me.lblMoneySaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoneySaved.ForeColor = System.Drawing.Color.Green
        Me.lblMoneySaved.Location = New System.Drawing.Point(324, 173)
        Me.lblMoneySaved.Name = "lblMoneySaved"
        Me.lblMoneySaved.Size = New System.Drawing.Size(69, 23)
        Me.lblMoneySaved.TabIndex = 8
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(191, 173)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(69, 23)
        Me.lblTotalDue.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Jacket_Haven.My.Resources.Resources.Jacket_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(151, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 208)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblMoneySaved)
        Me.Controls.Add(Me.lblTotalOrdered)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.chkCard)
        Me.Controls.Add(Me.grpOrdered)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.grpOrdered.ResumeLayout(False)
        Me.grpOrdered.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOrdered As GroupBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBlack As TextBox
    Friend WithEvents txtNavy As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkCard As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalOrdered As Label
    Friend WithEvents lblMoneySaved As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
