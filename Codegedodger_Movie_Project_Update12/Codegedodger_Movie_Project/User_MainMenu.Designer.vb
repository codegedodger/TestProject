<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsLogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Main Menu User"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search Movies"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Rent A Movie"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToToolStripMenuItem, Me.LetsLogoutToolStripMenuItem, Me.LetsCloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 4
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
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'MoviesToolStripMenuItem
        '
        Me.MoviesToolStripMenuItem.Name = "MoviesToolStripMenuItem"
        Me.MoviesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MoviesToolStripMenuItem.Text = "Movies"
        '
        'LetsRentToolStripMenuItem
        '
        Me.LetsRentToolStripMenuItem.Name = "LetsRentToolStripMenuItem"
        Me.LetsRentToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
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
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'User_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 299)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "User_MainMenu"
        Me.Text = "User_MainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
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
