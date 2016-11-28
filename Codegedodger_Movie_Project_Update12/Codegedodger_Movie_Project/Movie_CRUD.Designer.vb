<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie_CRUD
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.MoviesdbDataSet = New Codegedodger_Movie_Project.MoviesdbDataSet()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New Codegedodger_Movie_Project.MoviesdbDataSetTableAdapters.MoviesTableAdapter()
        Me.TableAdapterManager = New Codegedodger_Movie_Project.MoviesdbDataSetTableAdapters.TableAdapterManager()
        Me.MoviesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsLogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MoviesdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(53, 210)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(161, 210)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(267, 210)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(161, 156)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(172, 20)
        Me.txtRating.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(161, 112)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(172, 20)
        Me.txtType.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(161, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 20)
        Me.txtName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rating"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.btnCreate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRating)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 264)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movies"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(161, 38)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(172, 20)
        Me.txtId.TabIndex = 9
        '
        'MoviesdbDataSet
        '
        Me.MoviesdbDataSet.DataSetName = "MoviesdbDataSet"
        Me.MoviesdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.MoviesdbDataSet
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MoviesTableAdapter = Me.MoviesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Codegedodger_Movie_Project.MoviesdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'MoviesDataGridView
        '
        Me.MoviesDataGridView.AutoGenerateColumns = False
        Me.MoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MoviesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MoviesDataGridView.DataSource = Me.MoviesBindingSource
        Me.MoviesDataGridView.Location = New System.Drawing.Point(472, 34)
        Me.MoviesDataGridView.Name = "MoviesDataGridView"
        Me.MoviesDataGridView.Size = New System.Drawing.Size(508, 272)
        Me.MoviesDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Rating"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Rating"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToToolStripMenuItem, Me.LetsLogoutToolStripMenuItem, Me.LetsCloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.MoviesToolStripMenuItem, Me.LetsRentToolStripMenuItem})
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GoToToolStripMenuItem.Text = "Go To"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'MoviesToolStripMenuItem
        '
        Me.MoviesToolStripMenuItem.Name = "MoviesToolStripMenuItem"
        Me.MoviesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MoviesToolStripMenuItem.Text = "Movies"
        '
        'LetsRentToolStripMenuItem
        '
        Me.LetsRentToolStripMenuItem.Name = "LetsRentToolStripMenuItem"
        Me.LetsRentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LetsRentToolStripMenuItem.Text = "Let's Rent"
        '
        'LetsLogoutToolStripMenuItem
        '
        Me.LetsLogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.LetsLogoutToolStripMenuItem.Name = "LetsLogoutToolStripMenuItem"
        Me.LetsLogoutToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.LetsLogoutToolStripMenuItem.Text = "Let's Logout"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'LetsCloseToolStripMenuItem
        '
        Me.LetsCloseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.LetsCloseToolStripMenuItem.Name = "LetsCloseToolStripMenuItem"
        Me.LetsCloseToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.LetsCloseToolStripMenuItem.Text = "Let's Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Movie_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 422)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MoviesDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Movie_CRUD"
        Me.Text = "Movie_CRUD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MoviesdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtRating As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents MoviesdbDataSet As MoviesdbDataSet
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As MoviesdbDataSetTableAdapters.MoviesTableAdapter
    Friend WithEvents TableAdapterManager As MoviesdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MoviesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoviesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LetsRentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LetsLogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LetsCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
