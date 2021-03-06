﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPermissions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPermissions))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AllowGods = New System.Windows.Forms.CheckBox()
        Me.GodHelp = New System.Windows.Forms.PictureBox()
        Me.ManagerGod = New System.Windows.Forms.CheckBox()
        Me.RegionGod = New System.Windows.Forms.CheckBox()
        Me.LimitsBox = New System.Windows.Forms.GroupBox()
        Me.EnableMaxPrims = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LSLCheckbox = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Clouds = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GodHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LimitsBox.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.AllowGods)
        Me.GroupBox4.Controls.Add(Me.GodHelp)
        Me.GroupBox4.Controls.Add(Me.ManagerGod)
        Me.GroupBox4.Controls.Add(Me.RegionGod)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 119)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Permissions"
        '
        'AllowGods
        '
        Me.AllowGods.AutoSize = True
        Me.AllowGods.Location = New System.Drawing.Point(15, 35)
        Me.AllowGods.Name = "AllowGods"
        Me.AllowGods.Size = New System.Drawing.Size(85, 17)
        Me.AllowGods.TabIndex = 14
        Me.AllowGods.Text = "Allow Gods?"
        Me.AllowGods.UseVisualStyleBackColor = True
        '
        'GodHelp
        '
        Me.GodHelp.Image = Global.Outworldz.My.Resources.Resources.about
        Me.GodHelp.Location = New System.Drawing.Point(117, 19)
        Me.GodHelp.Name = "GodHelp"
        Me.GodHelp.Size = New System.Drawing.Size(30, 34)
        Me.GodHelp.TabIndex = 1857
        Me.GodHelp.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GodHelp, "Click for Help on God Modes")
        '
        'ManagerGod
        '
        Me.ManagerGod.AutoSize = True
        Me.ManagerGod.Location = New System.Drawing.Point(15, 82)
        Me.ManagerGod.Name = "ManagerGod"
        Me.ManagerGod.Size = New System.Drawing.Size(141, 17)
        Me.ManagerGod.TabIndex = 16
        Me.ManagerGod.Text = "Region manager is god?"
        Me.ManagerGod.UseVisualStyleBackColor = True
        '
        'RegionGod
        '
        Me.RegionGod.AutoSize = True
        Me.RegionGod.Location = New System.Drawing.Point(15, 58)
        Me.RegionGod.Name = "RegionGod"
        Me.RegionGod.Size = New System.Drawing.Size(132, 17)
        Me.RegionGod.TabIndex = 15
        Me.RegionGod.Text = "Region owner is god? "
        Me.RegionGod.UseVisualStyleBackColor = True
        '
        'LimitsBox
        '
        Me.LimitsBox.Controls.Add(Me.EnableMaxPrims)
        Me.LimitsBox.Location = New System.Drawing.Point(12, 137)
        Me.LimitsBox.Name = "LimitsBox"
        Me.LimitsBox.Size = New System.Drawing.Size(189, 56)
        Me.LimitsBox.TabIndex = 1861
        Me.LimitsBox.TabStop = False
        Me.LimitsBox.Text = "Prim Limits"
        '
        'EnableMaxPrims
        '
        Me.EnableMaxPrims.AutoSize = True
        Me.EnableMaxPrims.Location = New System.Drawing.Point(12, 19)
        Me.EnableMaxPrims.Name = "EnableMaxPrims"
        Me.EnableMaxPrims.Size = New System.Drawing.Size(144, 17)
        Me.EnableMaxPrims.TabIndex = 19
        Me.EnableMaxPrims.Text = "Enable MAXPRIMS limits"
        Me.ToolTip1.SetToolTip(Me.EnableMaxPrims, "Maxprims limits the number of prims on a parcel.  if disabled, there are no limit" &
        "s.")
        Me.EnableMaxPrims.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LSLCheckbox)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(189, 48)
        Me.GroupBox8.TabIndex = 1862
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Allow LSL to contact the server"
        '
        'LSLCheckbox
        '
        Me.LSLCheckbox.AutoSize = True
        Me.LSLCheckbox.Location = New System.Drawing.Point(12, 19)
        Me.LSLCheckbox.Name = "LSLCheckbox"
        Me.LSLCheckbox.Size = New System.Drawing.Size(59, 17)
        Me.LSLCheckbox.TabIndex = 210
        Me.LSLCheckbox.Text = "Enable"
        Me.ToolTip1.SetToolTip(Me.LSLCheckbox, "LSL scripts cannot reach your server by default.   If you turn this on, they can " &
        "read web pages on your PC. ")
        Me.LSLCheckbox.UseVisualStyleBackColor = True
        '
        'Clouds
        '
        Me.Clouds.AutoSize = True
        Me.Clouds.Location = New System.Drawing.Point(12, 19)
        Me.Clouds.Name = "Clouds"
        Me.Clouds.Size = New System.Drawing.Size(59, 17)
        Me.Clouds.TabIndex = 17
        Me.Clouds.Text = "Enable"
        Me.ToolTip1.SetToolTip(Me.Clouds, "The original Second Life clouds")
        Me.Clouds.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox7.Controls.Add(Me.Clouds)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(189, 56)
        Me.GroupBox7.TabIndex = 1863
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Clouds"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Items.Add("0%")
        Me.DomainUpDown1.Items.Add("10%")
        Me.DomainUpDown1.Items.Add("20%")
        Me.DomainUpDown1.Items.Add("30%")
        Me.DomainUpDown1.Items.Add("60%")
        Me.DomainUpDown1.Items.Add("40%")
        Me.DomainUpDown1.Items.Add("50%")
        Me.DomainUpDown1.Items.Add("60%")
        Me.DomainUpDown1.Items.Add("70%")
        Me.DomainUpDown1.Items.Add("80%")
        Me.DomainUpDown1.Items.Add("90%")
        Me.DomainUpDown1.Items.Add("100%")
        Me.DomainUpDown1.Location = New System.Drawing.Point(77, 18)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(66, 20)
        Me.DomainUpDown1.TabIndex = 18
        '
        'FormPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 339)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.LimitsBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPermissions"
        Me.Text = "Permissions"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GodHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LimitsBox.ResumeLayout(False)
        Me.LimitsBox.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents AllowGods As CheckBox
    Friend WithEvents GodHelp As PictureBox
    Friend WithEvents ManagerGod As CheckBox
    Friend WithEvents RegionGod As CheckBox
    Friend WithEvents LimitsBox As GroupBox
    Friend WithEvents EnableMaxPrims As CheckBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents LSLCheckbox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents Clouds As CheckBox
End Class
