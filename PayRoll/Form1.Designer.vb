<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUname = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnCnsl = New System.Windows.Forms.Button()
        Me.txtLUName = New System.Windows.Forms.TextBox()
        Me.txtLPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUname.Location = New System.Drawing.Point(25, 28)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(69, 13)
        Me.lblUname.TabIndex = 0
        Me.lblUname.Text = "User Name"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPass.Location = New System.Drawing.Point(25, 67)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 13)
        Me.lblPass.TabIndex = 0
        Me.lblPass.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPass.Location = New System.Drawing.Point(134, 64)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(147, 20)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.Visible = False
        '
        'txtUname
        '
        Me.txtUname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUname.Location = New System.Drawing.Point(134, 25)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(147, 20)
        Me.txtUname.TabIndex = 1
        Me.txtUname.Visible = False
        '
        'btnLog
        '
        Me.btnLog.AutoEllipsis = True
        Me.btnLog.BackColor = System.Drawing.Color.DimGray
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLog.FlatAppearance.BorderSize = 0
        Me.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLog.Location = New System.Drawing.Point(28, 122)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "LOGIN"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'btnCnsl
        '
        Me.btnCnsl.AutoEllipsis = True
        Me.btnCnsl.BackColor = System.Drawing.Color.DimGray
        Me.btnCnsl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCnsl.FlatAppearance.BorderSize = 0
        Me.btnCnsl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnCnsl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCnsl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCnsl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCnsl.Location = New System.Drawing.Point(206, 122)
        Me.btnCnsl.Name = "btnCnsl"
        Me.btnCnsl.Size = New System.Drawing.Size(75, 23)
        Me.btnCnsl.TabIndex = 4
        Me.btnCnsl.Text = "CANCEL"
        Me.btnCnsl.UseVisualStyleBackColor = False
        '
        'txtLUName
        '
        Me.txtLUName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLUName.ForeColor = System.Drawing.Color.DimGray
        Me.txtLUName.Location = New System.Drawing.Point(134, 25)
        Me.txtLUName.Name = "txtLUName"
        Me.txtLUName.Size = New System.Drawing.Size(147, 20)
        Me.txtLUName.TabIndex = 5
        Me.txtLUName.TabStop = False
        Me.txtLUName.Text = "Enter User Name"
        '
        'txtLPass
        '
        Me.txtLPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtLPass.Location = New System.Drawing.Point(134, 64)
        Me.txtLPass.Name = "txtLPass"
        Me.txtLPass.Size = New System.Drawing.Size(147, 20)
        Me.txtLPass.TabIndex = 6
        Me.txtLPass.TabStop = False
        Me.txtLPass.Text = "Enter Password"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(307, 169)
        Me.Controls.Add(Me.txtLUName)
        Me.Controls.Add(Me.txtLPass)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.btnCnsl)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUname)
        Me.Controls.Add(Me.txtPass)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(323, 208)
        Me.MinimumSize = New System.Drawing.Size(323, 208)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUname As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnCnsl As System.Windows.Forms.Button
    Friend WithEvents txtLUName As System.Windows.Forms.TextBox
    Friend WithEvents txtLPass As System.Windows.Forms.TextBox

End Class
