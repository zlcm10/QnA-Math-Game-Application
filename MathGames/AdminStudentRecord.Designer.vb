<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminStudentRecord
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.StuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuAddMathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuSubMathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuMulMathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuDivMathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MathUserDataSet = New MathGames.MathUserDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtDivScore = New System.Windows.Forms.TextBox()
        Me.txtMulScore = New System.Windows.Forms.TextBox()
        Me.txtSubScore = New System.Windows.Forms.TextBox()
        Me.txtAddScore = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDivScore = New System.Windows.Forms.Label()
        Me.lblMulScore = New System.Windows.Forms.Label()
        Me.lblSubScore = New System.Windows.Forms.Label()
        Me.lblAddScore = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.StudentTableAdapter = New MathGames.MathUserDataSetTableAdapters.studentTableAdapter()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MathUserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StuIDDataGridViewTextBoxColumn, Me.StuUsernameDataGridViewTextBoxColumn, Me.StuPasswordDataGridViewTextBoxColumn, Me.StuAddMathDataGridViewTextBoxColumn, Me.StuSubMathDataGridViewTextBoxColumn, Me.StuMulMathDataGridViewTextBoxColumn, Me.StuDivMathDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.StudentBindingSource
        Me.DGV.Location = New System.Drawing.Point(12, 62)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(825, 518)
        Me.DGV.TabIndex = 0
        '
        'StuIDDataGridViewTextBoxColumn
        '
        Me.StuIDDataGridViewTextBoxColumn.DataPropertyName = "stu_ID"
        Me.StuIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StuIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuIDDataGridViewTextBoxColumn.Name = "StuIDDataGridViewTextBoxColumn"
        Me.StuIDDataGridViewTextBoxColumn.Width = 125
        '
        'StuUsernameDataGridViewTextBoxColumn
        '
        Me.StuUsernameDataGridViewTextBoxColumn.DataPropertyName = "stu_Username"
        Me.StuUsernameDataGridViewTextBoxColumn.HeaderText = "Student Username"
        Me.StuUsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuUsernameDataGridViewTextBoxColumn.Name = "StuUsernameDataGridViewTextBoxColumn"
        Me.StuUsernameDataGridViewTextBoxColumn.Width = 125
        '
        'StuPasswordDataGridViewTextBoxColumn
        '
        Me.StuPasswordDataGridViewTextBoxColumn.DataPropertyName = "stu_Password"
        Me.StuPasswordDataGridViewTextBoxColumn.HeaderText = "Student Password"
        Me.StuPasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuPasswordDataGridViewTextBoxColumn.Name = "StuPasswordDataGridViewTextBoxColumn"
        Me.StuPasswordDataGridViewTextBoxColumn.Width = 125
        '
        'StuAddMathDataGridViewTextBoxColumn
        '
        Me.StuAddMathDataGridViewTextBoxColumn.DataPropertyName = "stu_AddMath"
        Me.StuAddMathDataGridViewTextBoxColumn.HeaderText = "Student Additon Score"
        Me.StuAddMathDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuAddMathDataGridViewTextBoxColumn.Name = "StuAddMathDataGridViewTextBoxColumn"
        Me.StuAddMathDataGridViewTextBoxColumn.Width = 125
        '
        'StuSubMathDataGridViewTextBoxColumn
        '
        Me.StuSubMathDataGridViewTextBoxColumn.DataPropertyName = "stu_SubMath"
        Me.StuSubMathDataGridViewTextBoxColumn.HeaderText = "Student Subtraction Score"
        Me.StuSubMathDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuSubMathDataGridViewTextBoxColumn.Name = "StuSubMathDataGridViewTextBoxColumn"
        Me.StuSubMathDataGridViewTextBoxColumn.Width = 125
        '
        'StuMulMathDataGridViewTextBoxColumn
        '
        Me.StuMulMathDataGridViewTextBoxColumn.DataPropertyName = "stu_MulMath"
        Me.StuMulMathDataGridViewTextBoxColumn.HeaderText = "Student Multiplication Score"
        Me.StuMulMathDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuMulMathDataGridViewTextBoxColumn.Name = "StuMulMathDataGridViewTextBoxColumn"
        Me.StuMulMathDataGridViewTextBoxColumn.Width = 125
        '
        'StuDivMathDataGridViewTextBoxColumn
        '
        Me.StuDivMathDataGridViewTextBoxColumn.DataPropertyName = "stu_DivMath"
        Me.StuDivMathDataGridViewTextBoxColumn.HeaderText = "Student Division Score"
        Me.StuDivMathDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StuDivMathDataGridViewTextBoxColumn.Name = "StuDivMathDataGridViewTextBoxColumn"
        Me.StuDivMathDataGridViewTextBoxColumn.Width = 125
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.MathUserDataSet
        '
        'MathUserDataSet
        '
        Me.MathUserDataSet.DataSetName = "MathUserDataSet"
        Me.MathUserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchID)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtDivScore)
        Me.GroupBox1.Controls.Add(Me.txtMulScore)
        Me.GroupBox1.Controls.Add(Me.txtSubScore)
        Me.GroupBox1.Controls.Add(Me.txtAddScore)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblDivScore)
        Me.GroupBox1.Controls.Add(Me.lblMulScore)
        Me.GroupBox1.Controls.Add(Me.lblSubScore)
        Me.GroupBox1.Controls.Add(Me.lblAddScore)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(844, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 568)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Record"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(27, 184)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(194, 25)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Student Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(247, 184)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(173, 30)
        Me.txtPassword.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Location = New System.Drawing.Point(450, 492)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEdit.Location = New System.Drawing.Point(165, 492)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(116, 41)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDelete.Location = New System.Drawing.Point(304, 492)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 41)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAdd.Location = New System.Drawing.Point(18, 492)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 41)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtDivScore
        '
        Me.txtDivScore.Location = New System.Drawing.Point(247, 412)
        Me.txtDivScore.Name = "txtDivScore"
        Me.txtDivScore.Size = New System.Drawing.Size(173, 30)
        Me.txtDivScore.TabIndex = 6
        '
        'txtMulScore
        '
        Me.txtMulScore.Location = New System.Drawing.Point(247, 358)
        Me.txtMulScore.Name = "txtMulScore"
        Me.txtMulScore.Size = New System.Drawing.Size(173, 30)
        Me.txtMulScore.TabIndex = 5
        '
        'txtSubScore
        '
        Me.txtSubScore.Location = New System.Drawing.Point(247, 301)
        Me.txtSubScore.Name = "txtSubScore"
        Me.txtSubScore.Size = New System.Drawing.Size(173, 30)
        Me.txtSubScore.TabIndex = 4
        '
        'txtAddScore
        '
        Me.txtAddScore.Location = New System.Drawing.Point(247, 243)
        Me.txtAddScore.Name = "txtAddScore"
        Me.txtAddScore.Size = New System.Drawing.Size(173, 30)
        Me.txtAddScore.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(247, 127)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(173, 30)
        Me.txtUsername.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(247, 74)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(173, 30)
        Me.txtID.TabIndex = 0
        '
        'lblDivScore
        '
        Me.lblDivScore.AutoSize = True
        Me.lblDivScore.Location = New System.Drawing.Point(57, 412)
        Me.lblDivScore.Name = "lblDivScore"
        Me.lblDivScore.Size = New System.Drawing.Size(158, 25)
        Me.lblDivScore.TabIndex = 5
        Me.lblDivScore.Text = "Division Score:"
        '
        'lblMulScore
        '
        Me.lblMulScore.AutoSize = True
        Me.lblMulScore.Location = New System.Drawing.Point(6, 358)
        Me.lblMulScore.Name = "lblMulScore"
        Me.lblMulScore.Size = New System.Drawing.Size(208, 25)
        Me.lblMulScore.TabIndex = 4
        Me.lblMulScore.Text = "Multiplication Score:"
        '
        'lblSubScore
        '
        Me.lblSubScore.AutoSize = True
        Me.lblSubScore.Location = New System.Drawing.Point(13, 301)
        Me.lblSubScore.Name = "lblSubScore"
        Me.lblSubScore.Size = New System.Drawing.Size(203, 25)
        Me.lblSubScore.TabIndex = 3
        Me.lblSubScore.Text = "Substraction Score:"
        '
        'lblAddScore
        '
        Me.lblAddScore.AutoSize = True
        Me.lblAddScore.Location = New System.Drawing.Point(57, 243)
        Me.lblAddScore.Name = "lblAddScore"
        Me.lblAddScore.Size = New System.Drawing.Size(161, 25)
        Me.lblAddScore.TabIndex = 2
        Me.lblAddScore.Text = "Addition Score:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(23, 127)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(198, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Student Username:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(100, 74)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(121, 25)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Student ID:"
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(12, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(60, 25)
        Me.lblBack.TabIndex = 2
        Me.lblBack.Text = "Back"
        '
        'btnSearchID
        '
        Me.btnSearchID.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSearchID.Location = New System.Drawing.Point(442, 74)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(124, 83)
        Me.btnSearchID.TabIndex = 3
        Me.btnSearchID.Text = "Search ID"
        Me.btnSearchID.UseVisualStyleBackColor = False
        '
        'AdminStudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1440, 584)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "AdminStudentRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Record"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MathUserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtDivScore As TextBox
    Friend WithEvents txtMulScore As TextBox
    Friend WithEvents txtSubScore As TextBox
    Friend WithEvents txtAddScore As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblDivScore As Label
    Friend WithEvents lblMulScore As Label
    Friend WithEvents lblSubScore As Label
    Friend WithEvents lblAddScore As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents MathUserDataSet As MathUserDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As MathUserDataSetTableAdapters.studentTableAdapter
    Friend WithEvents StuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuAddMathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuSubMathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuMulMathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuDivMathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblBack As Label
    Friend WithEvents btnSearchID As Button
End Class
