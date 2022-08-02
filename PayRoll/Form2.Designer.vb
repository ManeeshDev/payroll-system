<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalary))
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.lblBslry = New System.Windows.Forms.Label()
        Me.lblOTR = New System.Windows.Forms.Label()
        Me.lblOTH = New System.Windows.Forms.Label()
        Me.lblOTA = New System.Windows.Forms.Label()
        Me.lblSadv = New System.Windows.Forms.Label()
        Me.lblNtSley = New System.Windows.Forms.Label()
        Me.btnPrces = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtBSal = New System.Windows.Forms.TextBox()
        Me.txtOtR = New System.Windows.Forms.TextBox()
        Me.txtOtH = New System.Windows.Forms.TextBox()
        Me.txtOtA = New System.Windows.Forms.TextBox()
        Me.txtSalAdvnc = New System.Windows.Forms.TextBox()
        Me.txtNtSalary = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmpNo.Location = New System.Drawing.Point(25, 29)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(78, 13)
        Me.lblEmpNo.TabIndex = 0
        Me.lblEmpNo.Text = "Employee ID"
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmpName.Location = New System.Drawing.Point(25, 63)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(97, 13)
        Me.lblEmpName.TabIndex = 0
        Me.lblEmpName.Text = "Employee Name"
        '
        'lblBslry
        '
        Me.lblBslry.AutoSize = True
        Me.lblBslry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBslry.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBslry.Location = New System.Drawing.Point(25, 97)
        Me.lblBslry.Name = "lblBslry"
        Me.lblBslry.Size = New System.Drawing.Size(77, 13)
        Me.lblBslry.TabIndex = 0
        Me.lblBslry.Text = "Basic Salary"
        '
        'lblOTR
        '
        Me.lblOTR.AutoSize = True
        Me.lblOTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOTR.Location = New System.Drawing.Point(25, 199)
        Me.lblOTR.Name = "lblOTR"
        Me.lblOTR.Size = New System.Drawing.Size(96, 13)
        Me.lblOTR.TabIndex = 0
        Me.lblOTR.Text = "Over Time Rate"
        '
        'lblOTH
        '
        Me.lblOTH.AutoSize = True
        Me.lblOTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTH.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOTH.Location = New System.Drawing.Point(25, 165)
        Me.lblOTH.Name = "lblOTH"
        Me.lblOTH.Size = New System.Drawing.Size(102, 13)
        Me.lblOTH.TabIndex = 0
        Me.lblOTH.Text = "Over Time Hours"
        '
        'lblOTA
        '
        Me.lblOTA.AutoSize = True
        Me.lblOTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOTA.Location = New System.Drawing.Point(25, 234)
        Me.lblOTA.Name = "lblOTA"
        Me.lblOTA.Size = New System.Drawing.Size(111, 13)
        Me.lblOTA.TabIndex = 0
        Me.lblOTA.Text = "Over Time Amount"
        '
        'lblSadv
        '
        Me.lblSadv.AutoSize = True
        Me.lblSadv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSadv.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSadv.Location = New System.Drawing.Point(25, 131)
        Me.lblSadv.Name = "lblSadv"
        Me.lblSadv.Size = New System.Drawing.Size(96, 13)
        Me.lblSadv.TabIndex = 0
        Me.lblSadv.Text = "Salary Advance"
        '
        'lblNtSley
        '
        Me.lblNtSley.AutoSize = True
        Me.lblNtSley.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNtSley.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNtSley.Location = New System.Drawing.Point(25, 269)
        Me.lblNtSley.Name = "lblNtSley"
        Me.lblNtSley.Size = New System.Drawing.Size(66, 13)
        Me.lblNtSley.TabIndex = 0
        Me.lblNtSley.Text = "Net Salary"
        '
        'btnPrces
        '
        Me.btnPrces.BackColor = System.Drawing.Color.DimGray
        Me.btnPrces.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrces.FlatAppearance.BorderSize = 0
        Me.btnPrces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnPrces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrces.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrces.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrces.Location = New System.Drawing.Point(25, 315)
        Me.btnPrces.Name = "btnPrces"
        Me.btnPrces.Size = New System.Drawing.Size(92, 27)
        Me.btnPrces.TabIndex = 6
        Me.btnPrces.Text = "PROCESS"
        Me.btnPrces.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(191, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtEmpId
        '
        Me.txtEmpId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Location = New System.Drawing.Point(160, 25)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(123, 20)
        Me.txtEmpId.TabIndex = 1
        '
        'txtEmpName
        '
        Me.txtEmpName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Location = New System.Drawing.Point(160, 59)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(123, 20)
        Me.txtEmpName.TabIndex = 2
        '
        'txtBSal
        '
        Me.txtBSal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBSal.Location = New System.Drawing.Point(160, 93)
        Me.txtBSal.Name = "txtBSal"
        Me.txtBSal.Size = New System.Drawing.Size(123, 20)
        Me.txtBSal.TabIndex = 3
        '
        'txtOtR
        '
        Me.txtOtR.BackColor = System.Drawing.Color.DimGray
        Me.txtOtR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtR.Cursor = System.Windows.Forms.Cursors.No
        Me.txtOtR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOtR.Location = New System.Drawing.Point(160, 195)
        Me.txtOtR.Name = "txtOtR"
        Me.txtOtR.Size = New System.Drawing.Size(123, 20)
        Me.txtOtR.TabIndex = 0
        Me.txtOtR.TabStop = False
        '
        'txtOtH
        '
        Me.txtOtH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOtH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtH.Location = New System.Drawing.Point(160, 161)
        Me.txtOtH.Name = "txtOtH"
        Me.txtOtH.Size = New System.Drawing.Size(123, 20)
        Me.txtOtH.TabIndex = 5
        '
        'txtOtA
        '
        Me.txtOtA.BackColor = System.Drawing.Color.DimGray
        Me.txtOtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtA.Cursor = System.Windows.Forms.Cursors.No
        Me.txtOtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOtA.Location = New System.Drawing.Point(160, 230)
        Me.txtOtA.Name = "txtOtA"
        Me.txtOtA.Size = New System.Drawing.Size(123, 20)
        Me.txtOtA.TabIndex = 0
        Me.txtOtA.TabStop = False
        '
        'txtSalAdvnc
        '
        Me.txtSalAdvnc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSalAdvnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalAdvnc.Location = New System.Drawing.Point(160, 127)
        Me.txtSalAdvnc.Name = "txtSalAdvnc"
        Me.txtSalAdvnc.Size = New System.Drawing.Size(123, 20)
        Me.txtSalAdvnc.TabIndex = 4
        '
        'txtNtSalary
        '
        Me.txtNtSalary.BackColor = System.Drawing.Color.DimGray
        Me.txtNtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNtSalary.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNtSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNtSalary.Location = New System.Drawing.Point(160, 265)
        Me.txtNtSalary.Name = "txtNtSalary"
        Me.txtNtSalary.Size = New System.Drawing.Size(123, 20)
        Me.txtNtSalary.TabIndex = 0
        Me.txtNtSalary.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.Location = New System.Drawing.Point(236, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(47, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(309, 371)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtNtSalary)
        Me.Controls.Add(Me.txtSalAdvnc)
        Me.Controls.Add(Me.txtOtA)
        Me.Controls.Add(Me.txtOtH)
        Me.Controls.Add(Me.txtOtR)
        Me.Controls.Add(Me.txtBSal)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrces)
        Me.Controls.Add(Me.lblNtSley)
        Me.Controls.Add(Me.lblSadv)
        Me.Controls.Add(Me.lblOTA)
        Me.Controls.Add(Me.lblOTH)
        Me.Controls.Add(Me.lblOTR)
        Me.Controls.Add(Me.lblBslry)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(325, 410)
        Me.MinimumSize = New System.Drawing.Size(325, 410)
        Me.Name = "frmSalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpNo As System.Windows.Forms.Label
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents lblBslry As System.Windows.Forms.Label
    Friend WithEvents lblOTR As System.Windows.Forms.Label
    Friend WithEvents lblOTH As System.Windows.Forms.Label
    Friend WithEvents lblOTA As System.Windows.Forms.Label
    Friend WithEvents lblSadv As System.Windows.Forms.Label
    Friend WithEvents lblNtSley As System.Windows.Forms.Label
    Friend WithEvents btnPrces As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtBSal As System.Windows.Forms.TextBox
    Friend WithEvents txtOtR As System.Windows.Forms.TextBox
    Friend WithEvents txtOtH As System.Windows.Forms.TextBox
    Friend WithEvents txtOtA As System.Windows.Forms.TextBox
    Friend WithEvents txtSalAdvnc As System.Windows.Forms.TextBox
    Friend WithEvents txtNtSalary As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As Button
End Class
