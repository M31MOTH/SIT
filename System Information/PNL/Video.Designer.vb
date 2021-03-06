﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Video
    Inherits SystemInformation.TaskPanelBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelTitle = New System.Windows.Forms.Label
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox
        Me.LabelControllers = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelNumberControllers = New System.Windows.Forms.Label
        Me.ListViewAdaptors = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.LabelScreenDimensions1 = New System.Windows.Forms.Label
        Me.LabelScreenWorkingArea1 = New System.Windows.Forms.Label
        Me.LabelControllerInfo = New System.Windows.Forms.Label
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTitle.Location = New System.Drawing.Point(80, 28)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(64, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Video"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Video_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelControllers
        '
        Me.LabelControllers.AutoSize = True
        Me.LabelControllers.BackColor = System.Drawing.Color.Transparent
        Me.LabelControllers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControllers.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelControllers.Location = New System.Drawing.Point(80, 72)
        Me.LabelControllers.Name = "LabelControllers"
        Me.LabelControllers.Size = New System.Drawing.Size(76, 17)
        Me.LabelControllers.TabIndex = 15
        Me.LabelControllers.Text = "Controllers"
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(80, 94)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparator.TabIndex = 14
        '
        'LabelNumberControllers
        '
        Me.LabelNumberControllers.AutoSize = True
        Me.LabelNumberControllers.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumberControllers.ForeColor = System.Drawing.Color.Black
        Me.LabelNumberControllers.Location = New System.Drawing.Point(80, 108)
        Me.LabelNumberControllers.Name = "LabelNumberControllers"
        Me.LabelNumberControllers.Size = New System.Drawing.Size(126, 15)
        Me.LabelNumberControllers.TabIndex = 16
        Me.LabelNumberControllers.Text = "Number of Controllers"
        '
        'ListViewAdaptors
        '
        Me.ListViewAdaptors.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewAdaptors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListViewAdaptors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewAdaptors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewAdaptors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewAdaptors.LabelWrap = False
        Me.ListViewAdaptors.Location = New System.Drawing.Point(80, 193)
        Me.ListViewAdaptors.MultiSelect = False
        Me.ListViewAdaptors.Name = "ListViewAdaptors"
        Me.ListViewAdaptors.ShowGroups = False
        Me.ListViewAdaptors.Size = New System.Drawing.Size(420, 227)
        Me.ListViewAdaptors.TabIndex = 17
        Me.ListViewAdaptors.UseCompatibleStateImageBehavior = False
        Me.ListViewAdaptors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 400
        '
        'LabelScreenDimensions1
        '
        Me.LabelScreenDimensions1.AutoSize = True
        Me.LabelScreenDimensions1.BackColor = System.Drawing.Color.Transparent
        Me.LabelScreenDimensions1.ForeColor = System.Drawing.Color.Black
        Me.LabelScreenDimensions1.Location = New System.Drawing.Point(80, 128)
        Me.LabelScreenDimensions1.Name = "LabelScreenDimensions1"
        Me.LabelScreenDimensions1.Size = New System.Drawing.Size(153, 15)
        Me.LabelScreenDimensions1.TabIndex = 18
        Me.LabelScreenDimensions1.Text = "Current Screen Dimensions:"
        '
        'LabelScreenWorkingArea1
        '
        Me.LabelScreenWorkingArea1.AutoSize = True
        Me.LabelScreenWorkingArea1.BackColor = System.Drawing.Color.Transparent
        Me.LabelScreenWorkingArea1.ForeColor = System.Drawing.Color.Black
        Me.LabelScreenWorkingArea1.Location = New System.Drawing.Point(80, 148)
        Me.LabelScreenWorkingArea1.Name = "LabelScreenWorkingArea1"
        Me.LabelScreenWorkingArea1.Size = New System.Drawing.Size(163, 15)
        Me.LabelScreenWorkingArea1.TabIndex = 19
        Me.LabelScreenWorkingArea1.Text = "Current Screen Working Area:"
        '
        'LabelControllerInfo
        '
        Me.LabelControllerInfo.AutoSize = True
        Me.LabelControllerInfo.BackColor = System.Drawing.Color.Transparent
        Me.LabelControllerInfo.ForeColor = System.Drawing.Color.Black
        Me.LabelControllerInfo.Location = New System.Drawing.Point(80, 175)
        Me.LabelControllerInfo.Name = "LabelControllerInfo"
        Me.LabelControllerInfo.Size = New System.Drawing.Size(129, 15)
        Me.LabelControllerInfo.TabIndex = 20
        Me.LabelControllerInfo.Text = "Controller Information:"
        '
        'Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelControllerInfo)
        Me.Controls.Add(Me.LabelScreenWorkingArea1)
        Me.Controls.Add(Me.LabelScreenDimensions1)
        Me.Controls.Add(Me.ListViewAdaptors)
        Me.Controls.Add(Me.LabelNumberControllers)
        Me.Controls.Add(Me.LabelControllers)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Video"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelControllers As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelNumberControllers As System.Windows.Forms.Label
    Private WithEvents ListViewAdaptors As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelScreenDimensions1 As System.Windows.Forms.Label
    Private WithEvents LabelScreenWorkingArea1 As System.Windows.Forms.Label
    Private WithEvents LabelControllerInfo As System.Windows.Forms.Label

End Class
