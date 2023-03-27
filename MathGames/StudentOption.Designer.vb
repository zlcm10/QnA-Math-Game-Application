<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentOption
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
        Me.btnAdditionMath = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDivisionScore = New System.Windows.Forms.TextBox()
        Me.txtMultiplicationScore = New System.Windows.Forms.TextBox()
        Me.txtSubtractionScore = New System.Windows.Forms.TextBox()
        Me.txtAdditionScore = New System.Windows.Forms.TextBox()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblMultiplication = New System.Windows.Forms.Label()
        Me.lblSubtraction = New System.Windows.Forms.Label()
        Me.lblAddition = New System.Windows.Forms.Label()
        Me.btnSubtractionMath = New System.Windows.Forms.Button()
        Me.btnMultiplicationMath = New System.Windows.Forms.Button()
        Me.btnDivisionMath = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUserGuide = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdditionMath
        '
        Me.btnAdditionMath.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAdditionMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdditionMath.Location = New System.Drawing.Point(508, 78)
        Me.btnAdditionMath.Name = "btnAdditionMath"
        Me.btnAdditionMath.Size = New System.Drawing.Size(308, 61)
        Me.btnAdditionMath.TabIndex = 0
        Me.btnAdditionMath.Text = "Addition Math"
        Me.btnAdditionMath.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(121, 129)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(110, 25)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 691)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDivisionScore)
        Me.GroupBox1.Controls.Add(Me.txtMultiplicationScore)
        Me.GroupBox1.Controls.Add(Me.txtSubtractionScore)
        Me.GroupBox1.Controls.Add(Me.txtAdditionScore)
        Me.GroupBox1.Controls.Add(Me.lblDivision)
        Me.GroupBox1.Controls.Add(Me.lblMultiplication)
        Me.GroupBox1.Controls.Add(Me.lblSubtraction)
        Me.GroupBox1.Controls.Add(Me.lblAddition)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 322)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Score"
        '
        'txtDivisionScore
        '
        Me.txtDivisionScore.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtDivisionScore.Location = New System.Drawing.Point(162, 232)
        Me.txtDivisionScore.Name = "txtDivisionScore"
        Me.txtDivisionScore.Size = New System.Drawing.Size(100, 27)
        Me.txtDivisionScore.TabIndex = 11
        '
        'txtMultiplicationScore
        '
        Me.txtMultiplicationScore.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtMultiplicationScore.Location = New System.Drawing.Point(162, 172)
        Me.txtMultiplicationScore.Name = "txtMultiplicationScore"
        Me.txtMultiplicationScore.Size = New System.Drawing.Size(100, 27)
        Me.txtMultiplicationScore.TabIndex = 10
        '
        'txtSubtractionScore
        '
        Me.txtSubtractionScore.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtSubtractionScore.Location = New System.Drawing.Point(162, 117)
        Me.txtSubtractionScore.Name = "txtSubtractionScore"
        Me.txtSubtractionScore.Size = New System.Drawing.Size(100, 27)
        Me.txtSubtractionScore.TabIndex = 9
        '
        'txtAdditionScore
        '
        Me.txtAdditionScore.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtAdditionScore.Location = New System.Drawing.Point(162, 60)
        Me.txtAdditionScore.Name = "txtAdditionScore"
        Me.txtAdditionScore.Size = New System.Drawing.Size(100, 27)
        Me.txtAdditionScore.TabIndex = 8
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Location = New System.Drawing.Point(55, 235)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(83, 20)
        Me.lblDivision.TabIndex = 3
        Me.lblDivision.Text = "Division:"
        '
        'lblMultiplication
        '
        Me.lblMultiplication.AutoSize = True
        Me.lblMultiplication.Location = New System.Drawing.Point(18, 175)
        Me.lblMultiplication.Name = "lblMultiplication"
        Me.lblMultiplication.Size = New System.Drawing.Size(127, 20)
        Me.lblMultiplication.TabIndex = 2
        Me.lblMultiplication.Text = "Multiplication:"
        '
        'lblSubtraction
        '
        Me.lblSubtraction.AutoSize = True
        Me.lblSubtraction.Location = New System.Drawing.Point(27, 120)
        Me.lblSubtraction.Name = "lblSubtraction"
        Me.lblSubtraction.Size = New System.Drawing.Size(111, 20)
        Me.lblSubtraction.TabIndex = 1
        Me.lblSubtraction.Text = "Subtraction:"
        '
        'lblAddition
        '
        Me.lblAddition.AutoSize = True
        Me.lblAddition.Location = New System.Drawing.Point(48, 63)
        Me.lblAddition.Name = "lblAddition"
        Me.lblAddition.Size = New System.Drawing.Size(83, 20)
        Me.lblAddition.TabIndex = 0
        Me.lblAddition.Text = "Addition:"
        '
        'btnSubtractionMath
        '
        Me.btnSubtractionMath.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubtractionMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtractionMath.Location = New System.Drawing.Point(508, 188)
        Me.btnSubtractionMath.Name = "btnSubtractionMath"
        Me.btnSubtractionMath.Size = New System.Drawing.Size(308, 61)
        Me.btnSubtractionMath.TabIndex = 7
        Me.btnSubtractionMath.Text = "Subtraction  Math"
        Me.btnSubtractionMath.UseVisualStyleBackColor = False
        '
        'btnMultiplicationMath
        '
        Me.btnMultiplicationMath.BackColor = System.Drawing.Color.SkyBlue
        Me.btnMultiplicationMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicationMath.Location = New System.Drawing.Point(508, 290)
        Me.btnMultiplicationMath.Name = "btnMultiplicationMath"
        Me.btnMultiplicationMath.Size = New System.Drawing.Size(308, 61)
        Me.btnMultiplicationMath.TabIndex = 8
        Me.btnMultiplicationMath.Text = "Multiplication  Math"
        Me.btnMultiplicationMath.UseVisualStyleBackColor = False
        '
        'btnDivisionMath
        '
        Me.btnDivisionMath.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDivisionMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivisionMath.Location = New System.Drawing.Point(508, 393)
        Me.btnDivisionMath.Name = "btnDivisionMath"
        Me.btnDivisionMath.Size = New System.Drawing.Size(308, 61)
        Me.btnDivisionMath.TabIndex = 9
        Me.btnDivisionMath.Text = "Division  Math"
        Me.btnDivisionMath.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(508, 594)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(308, 61)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblUserGuide
        '
        Me.lblUserGuide.AutoSize = True
        Me.lblUserGuide.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserGuide.Location = New System.Drawing.Point(850, 9)
        Me.lblUserGuide.Name = "lblUserGuide"
        Me.lblUserGuide.Size = New System.Drawing.Size(90, 17)
        Me.lblUserGuide.TabIndex = 11
        Me.lblUserGuide.Text = "User Guide"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.SkyBlue
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(508, 493)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(308, 61)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print Score"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'StudentOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(952, 694)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblUserGuide)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDivisionMath)
        Me.Controls.Add(Me.btnMultiplicationMath)
        Me.Controls.Add(Me.btnSubtractionMath)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdditionMath)
        Me.Name = "StudentOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdditionMath As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSubtractionMath As Button
    Friend WithEvents btnMultiplicationMath As Button
    Friend WithEvents btnDivisionMath As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDivision As Label
    Friend WithEvents lblMultiplication As Label
    Friend WithEvents lblSubtraction As Label
    Friend WithEvents lblAddition As Label
    Friend WithEvents lblUserGuide As Label
    Friend WithEvents txtDivisionScore As TextBox
    Friend WithEvents txtMultiplicationScore As TextBox
    Friend WithEvents txtSubtractionScore As TextBox
    Friend WithEvents txtAdditionScore As TextBox
    Friend WithEvents btnPrint As Button
End Class
