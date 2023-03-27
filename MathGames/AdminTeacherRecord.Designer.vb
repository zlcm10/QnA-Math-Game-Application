<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTeacherRecord
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.TeacherTableAdapter = New MathGames.MathUserDataSet1TableAdapters.teacherTableAdapter()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TeaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeaUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeaPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MathUserDataSet1 = New MathGames.MathUserDataSet1()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MathUserDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(489, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 375)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teacher Record"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(23, 204)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(199, 25)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Teacher Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(247, 204)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(173, 30)
        Me.txtPassword.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Location = New System.Drawing.Point(450, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEdit.Location = New System.Drawing.Point(167, 296)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(116, 41)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDelete.Location = New System.Drawing.Point(304, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 41)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAdd.Location = New System.Drawing.Point(28, 296)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 41)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(247, 139)
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
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(23, 142)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(203, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Teacher Username:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(96, 74)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(126, 25)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Teacher ID:"
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'DGV
        '
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeaIDDataGridViewTextBoxColumn, Me.TeaUsernameDataGridViewTextBoxColumn, Me.TeaPasswordDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.TeacherBindingSource1
        Me.DGV.Location = New System.Drawing.Point(12, 76)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(471, 337)
        Me.DGV.TabIndex = 2
        '
        'TeaIDDataGridViewTextBoxColumn
        '
        Me.TeaIDDataGridViewTextBoxColumn.DataPropertyName = "tea_ID"
        Me.TeaIDDataGridViewTextBoxColumn.HeaderText = "Teacher ID"
        Me.TeaIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeaIDDataGridViewTextBoxColumn.Name = "TeaIDDataGridViewTextBoxColumn"
        Me.TeaIDDataGridViewTextBoxColumn.Width = 125
        '
        'TeaUsernameDataGridViewTextBoxColumn
        '
        Me.TeaUsernameDataGridViewTextBoxColumn.DataPropertyName = "tea_Username"
        Me.TeaUsernameDataGridViewTextBoxColumn.HeaderText = "Teacher Username"
        Me.TeaUsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeaUsernameDataGridViewTextBoxColumn.Name = "TeaUsernameDataGridViewTextBoxColumn"
        Me.TeaUsernameDataGridViewTextBoxColumn.Width = 125
        '
        'TeaPasswordDataGridViewTextBoxColumn
        '
        Me.TeaPasswordDataGridViewTextBoxColumn.DataPropertyName = "tea_Password"
        Me.TeaPasswordDataGridViewTextBoxColumn.HeaderText = "Teacher Password"
        Me.TeaPasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeaPasswordDataGridViewTextBoxColumn.Name = "TeaPasswordDataGridViewTextBoxColumn"
        Me.TeaPasswordDataGridViewTextBoxColumn.Width = 125
        '
        'TeacherBindingSource1
        '
        Me.TeacherBindingSource1.DataMember = "teacher"
        Me.TeacherBindingSource1.DataSource = Me.MathUserDataSet1
        '
        'MathUserDataSet1
        '
        Me.MathUserDataSet1.DataSetName = "MathUserDataSet1"
        Me.MathUserDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(12, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(60, 25)
        Me.lblBack.TabIndex = 4
        Me.lblBack.Text = "Back"
        '
        'btnSearchID
        '
        Me.btnSearchID.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSearchID.Location = New System.Drawing.Point(442, 74)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(124, 65)
        Me.btnSearchID.TabIndex = 5
        Me.btnSearchID.Text = "Search ID"
        Me.btnSearchID.UseVisualStyleBackColor = False
        '
        'AdminTeacherRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1072, 429)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "AdminTeacherRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MathUserDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblID As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TeacherTableAdapter As MathGames.MathUserDataSet1TableAdapters.teacherTableAdapter
    Friend WithEvents MathUserDataSet1 As MathUserDataSet1
    Friend WithEvents TeacherBindingSource1 As BindingSource
    Friend WithEvents TeaIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeaUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeaPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblBack As Label
    Friend WithEvents btnSearchID As Button
End Class
