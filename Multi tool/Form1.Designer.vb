<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ITalk_ThemeContainer1 = New Multi_tool.iTalk.iTalk_ThemeContainer()
        Me.ITalk_LinkLabel1 = New Multi_tool.iTalk.iTalk_LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ITalk_Button_11 = New Multi_tool.iTalk.iTalk_Button_1()
        Me.ITalk_Label1 = New Multi_tool.iTalk.iTalk_Label()
        Me.ITalk_TextBox_Small1 = New Multi_tool.iTalk.iTalk_TextBox_Small()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ITalk_ThemeContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ITalk_ThemeContainer1
        '
        Me.ITalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ITalk_ThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.GroupBox1)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_LinkLabel1)
        Me.ITalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITalk_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ITalk_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ITalk_ThemeContainer1.Name = "ITalk_ThemeContainer1"
        Me.ITalk_ThemeContainer1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 28)
        Me.ITalk_ThemeContainer1.Sizable = True
        Me.ITalk_ThemeContainer1.Size = New System.Drawing.Size(346, 267)
        Me.ITalk_ThemeContainer1.SmartBounds = False
        Me.ITalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ITalk_ThemeContainer1.TabIndex = 0
        Me.ITalk_ThemeContainer1.Text = ".: HASH DETECTOR :."
        '
        'ITalk_LinkLabel1
        '
        Me.ITalk_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ITalk_LinkLabel1.AutoSize = True
        Me.ITalk_LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ITalk_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ITalk_LinkLabel1.Location = New System.Drawing.Point(9, 245)
        Me.ITalk_LinkLabel1.Name = "ITalk_LinkLabel1"
        Me.ITalk_LinkLabel1.Size = New System.Drawing.Size(167, 13)
        Me.ITalk_LinkLabel1.TabIndex = 0
        Me.ITalk_LinkLabel1.TabStop = True
        Me.ITalk_LinkLabel1.Text = "Hash Detector By @Eawhitehat"
        Me.ITalk_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(202, Byte), Integer))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ITalk_TextBox_Small1)
        Me.GroupBox1.Controls.Add(Me.ITalk_Label1)
        Me.GroupBox1.Controls.Add(Me.ITalk_Button_11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 118)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ITalk_Button_11
        '
        Me.ITalk_Button_11.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ITalk_Button_11.Image = Nothing
        Me.ITalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_11.Location = New System.Drawing.Point(77, 86)
        Me.ITalk_Button_11.Name = "ITalk_Button_11"
        Me.ITalk_Button_11.Size = New System.Drawing.Size(161, 26)
        Me.ITalk_Button_11.TabIndex = 3
        Me.ITalk_Button_11.Text = "Detect Hash"
        Me.ITalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Label1
        '
        Me.ITalk_Label1.AutoSize = True
        Me.ITalk_Label1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_Label1.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label1.Location = New System.Drawing.Point(52, 61)
        Me.ITalk_Label1.Name = "ITalk_Label1"
        Me.ITalk_Label1.Size = New System.Drawing.Size(64, 13)
        Me.ITalk_Label1.TabIndex = 4
        Me.ITalk_Label1.Text = "Hash type :"
        '
        'ITalk_TextBox_Small1
        '
        Me.ITalk_TextBox_Small1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_TextBox_Small1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ITalk_TextBox_Small1.ForeColor = System.Drawing.Color.DimGray
        Me.ITalk_TextBox_Small1.Location = New System.Drawing.Point(6, 21)
        Me.ITalk_TextBox_Small1.MaxLength = 32767
        Me.ITalk_TextBox_Small1.Multiline = False
        Me.ITalk_TextBox_Small1.Name = "ITalk_TextBox_Small1"
        Me.ITalk_TextBox_Small1.ReadOnly = False
        Me.ITalk_TextBox_Small1.Size = New System.Drawing.Size(310, 28)
        Me.ITalk_TextBox_Small1.TabIndex = 5
        Me.ITalk_TextBox_Small1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.ITalk_TextBox_Small1.UseSystemPasswordChar = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 267)
        Me.Controls.Add(Me.ITalk_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(126, 39)
        Me.Name = "Form1"
        Me.Text = ".: HASH DETECTOR :."
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ITalk_ThemeContainer1.ResumeLayout(False)
        Me.ITalk_ThemeContainer1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ITalk_ThemeContainer1 As iTalk.iTalk_ThemeContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ITalk_LinkLabel1 As iTalk.iTalk_LinkLabel
    Friend WithEvents ITalk_Label1 As iTalk.iTalk_Label
    Friend WithEvents ITalk_Button_11 As iTalk.iTalk_Button_1
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ITalk_TextBox_Small1 As iTalk.iTalk_TextBox_Small
End Class
