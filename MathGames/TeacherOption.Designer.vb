<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherOption
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
        Me.lblShowUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbUsername = New System.Windows.Forms.RadioButton()
        Me.rdbID = New System.Windows.Forms.RadioButton()
        Me.txtDivScore = New System.Windows.Forms.TextBox()
        Me.txtMulScore = New System.Windows.Forms.TextBox()
        Me.txtSubScore = New System.Windows.Forms.TextBox()
        Me.txtAddScore = New System.Windows.Forms.TextBox()
        Me.lblDivScore = New System.Windows.Forms.Label()
        Me.lblMulScore = New System.Windows.Forms.Label()
        Me.lblSubScore = New System.Windows.Forms.Label()
        Me.lblAddScore = New System.Windows.Forms.Label()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblShowUsername
        '
        Me.lblShowUsername.AutoSize = True
        Me.lblShowUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowUsername.Location = New System.Drawing.Point(79, 84)
        Me.lblShowUsername.Name = "lblShowUsername"
        Me.lblShowUsername.Size = New System.Drawing.Size(107, 25)
        Me.lblShowUsername.TabIndex = 3
        Me.lblShowUsername.Text = "username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.lblShowUsername)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 424)
        Me.Panel1.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(911, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 61)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(447, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 30)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(240, 89)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(195, 30)
        Me.txtSearch.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbUsername)
        Me.GroupBox1.Controls.Add(Me.rdbID)
        Me.GroupBox1.Controls.Add(Me.txtDivScore)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtMulScore)
        Me.GroupBox1.Controls.Add(Me.txtSubScore)
        Me.GroupBox1.Controls.Add(Me.txtAddScore)
        Me.GroupBox1.Controls.Add(Me.lblDivScore)
        Me.GroupBox1.Controls.Add(Me.lblMulScore)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.lblSubScore)
        Me.GroupBox1.Controls.Add(Me.lblAddScore)
        Me.GroupBox1.Controls.Add(Me.lblSearchBy)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(311, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 400)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Student Score"
        '
        'rdbUsername
        '
        Me.rdbUsername.AutoSize = True
        Me.rdbUsername.Location = New System.Drawing.Point(312, 138)
        Me.rdbUsername.Name = "rdbUsername"
        Me.rdbUsername.Size = New System.Drawing.Size(123, 29)
        Me.rdbUsername.TabIndex = 16
        Me.rdbUsername.TabStop = True
        Me.rdbUsername.Text = "Username"
        Me.rdbUsername.UseVisualStyleBackColor = True
        '
        'rdbID
        '
        Me.rdbID.AutoSize = True
        Me.rdbID.Location = New System.Drawing.Point(240, 138)
        Me.rdbID.Name = "rdbID"
        Me.rdbID.Size = New System.Drawing.Size(52, 29)
        Me.rdbID.TabIndex = 15
        Me.rdbID.TabStop = True
        Me.rdbID.Text = "ID"
        Me.rdbID.UseVisualStyleBackColor = True
        '
        'txtDivScore
        '
        Me.txtDivScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivScore.Location = New System.Drawing.Point(240, 336)
        Me.txtDivScore.Name = "txtDivScore"
        Me.txtDivScore.ReadOnly = True
        Me.txtDivScore.Size = New System.Drawing.Size(195, 30)
        Me.txtDivScore.TabIndex = 14
        '
        'txtMulScore
        '
        Me.txtMulScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMulScore.Location = New System.Drawing.Point(240, 283)
        Me.txtMulScore.Name = "txtMulScore"
        Me.txtMulScore.ReadOnly = True
        Me.txtMulScore.Size = New System.Drawing.Size(195, 30)
        Me.txtMulScore.TabIndex = 13
        '
        'txtSubScore
        '
        Me.txtSubScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubScore.Location = New System.Drawing.Point(240, 234)
        Me.txtSubScore.Name = "txtSubScore"
        Me.txtSubScore.ReadOnly = True
        Me.txtSubScore.Size = New System.Drawing.Size(195, 30)
        Me.txtSubScore.TabIndex = 12
        '
        'txtAddScore
        '
        Me.txtAddScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddScore.Location = New System.Drawing.Point(240, 188)
        Me.txtAddScore.Name = "txtAddScore"
        Me.txtAddScore.ReadOnly = True
        Me.txtAddScore.Size = New System.Drawing.Size(195, 30)
        Me.txtAddScore.TabIndex = 11
        '
        'lblDivScore
        '
        Me.lblDivScore.AutoSize = True
        Me.lblDivScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivScore.Location = New System.Drawing.Point(56, 336)
        Me.lblDivScore.Name = "lblDivScore"
        Me.lblDivScore.Size = New System.Drawing.Size(158, 25)
        Me.lblDivScore.TabIndex = 9
        Me.lblDivScore.Text = "Division Score:"
        '
        'lblMulScore
        '
        Me.lblMulScore.AutoSize = True
        Me.lblMulScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMulScore.Location = New System.Drawing.Point(6, 283)
        Me.lblMulScore.Name = "lblMulScore"
        Me.lblMulScore.Size = New System.Drawing.Size(208, 25)
        Me.lblMulScore.TabIndex = 8
        Me.lblMulScore.Text = "Multiplication Score:"
        '
        'lblSubScore
        '
        Me.lblSubScore.AutoSize = True
        Me.lblSubScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubScore.Location = New System.Drawing.Point(20, 234)
        Me.lblSubScore.Name = "lblSubScore"
        Me.lblSubScore.Size = New System.Drawing.Size(192, 25)
        Me.lblSubScore.TabIndex = 7
        Me.lblSubScore.Text = "Subtraction Score:"
        '
        'lblAddScore
        '
        Me.lblAddScore.AutoSize = True
        Me.lblAddScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddScore.Location = New System.Drawing.Point(51, 188)
        Me.lblAddScore.Name = "lblAddScore"
        Me.lblAddScore.Size = New System.Drawing.Size(161, 25)
        Me.lblAddScore.TabIndex = 6
        Me.lblAddScore.Text = "Addition Score:"
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.Location = New System.Drawing.Point(95, 138)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(119, 25)
        Me.lblSearchBy.TabIndex = 5
        Me.lblSearchBy.Text = "Search By:"
        '
        'TeacherOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1039, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TeacherOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblShowUsername As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDivScore As TextBox
    Friend WithEvents txtMulScore As TextBox
    Friend WithEvents txtSubScore As TextBox
    Friend WithEvents txtAddScore As TextBox
    Friend WithEvents lblDivScore As Label
    Friend WithEvents lblMulScore As Label
    Friend WithEvents lblSubScore As Label
    Friend WithEvents lblAddScore As Label
    Friend WithEvents lblSearchBy As Label
    Friend WithEvents rdbUsername As RadioButton
    Friend WithEvents rdbID As RadioButton
End Class
