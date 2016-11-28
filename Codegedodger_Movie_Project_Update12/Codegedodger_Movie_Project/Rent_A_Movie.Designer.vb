<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rent_A_Movie
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePickerSchedule = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsLogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerSchedule)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rent A Movie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Movie ID"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 125)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "User ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Rent"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePickerSchedule
        '
        Me.DateTimePickerSchedule.Location = New System.Drawing.Point(107, 179)
        Me.DateTimePickerSchedule.Name = "DateTimePickerSchedule"
        Me.DateTimePickerSchedule.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerSchedule.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LetsLogoutToolStripMenuItem, Me.LetsCloseToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(654, 24)
        Me.MenuStrip2.TabIndex = 12
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.MoviesToolStripMenuItem, Me.LetsRentToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Go To"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Main Menu"
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
        Me.LetsLogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.LetsLogoutToolStripMenuItem.Name = "LetsLogoutToolStripMenuItem"
        Me.LetsLogoutToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.LetsLogoutToolStripMenuItem.Text = "Let's Logout"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "Logout"
        '
        'LetsCloseToolStripMenuItem
        '
        Me.LetsCloseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.LetsCloseToolStripMenuItem.Name = "LetsCloseToolStripMenuItem"
        Me.LetsCloseToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.LetsCloseToolStripMenuItem.Text = "Let's Close"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripMenuItem4.Text = "Exit"
        '
        'Rent_A_Movie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 356)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Rent_A_Movie"
        Me.Text = "Rent_A_Movie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePickerSchedule As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MoviesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LetsRentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LetsLogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents LetsCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
