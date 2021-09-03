<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.insta = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.twitter = New System.Windows.Forms.Button()
        Me.ma_chaine = New System.Windows.Forms.Button()
        Me.twitch = New System.Windows.Forms.Button()
        Me.discord = New System.Windows.Forms.Button()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Gamma = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insta
        '
        Me.insta.Location = New System.Drawing.Point(12, 309)
        Me.insta.Name = "insta"
        Me.insta.Size = New System.Drawing.Size(183, 23)
        Me.insta.TabIndex = 0
        Me.insta.Text = "Mon instagram : nicolas__tr"
        Me.insta.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 338)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1066, 251)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'twitter
        '
        Me.twitter.Location = New System.Drawing.Point(201, 309)
        Me.twitter.Name = "twitter"
        Me.twitter.Size = New System.Drawing.Size(183, 23)
        Me.twitter.TabIndex = 2
        Me.twitter.Text = "Mon twitter : nt_games_yt"
        Me.twitter.UseVisualStyleBackColor = True
        '
        'ma_chaine
        '
        Me.ma_chaine.Location = New System.Drawing.Point(390, 309)
        Me.ma_chaine.Name = "ma_chaine"
        Me.ma_chaine.Size = New System.Drawing.Size(310, 23)
        Me.ma_chaine.TabIndex = 3
        Me.ma_chaine.Text = "Ma chaine : nt games"
        Me.ma_chaine.UseVisualStyleBackColor = True
        '
        'twitch
        '
        Me.twitch.Location = New System.Drawing.Point(706, 309)
        Me.twitch.Name = "twitch"
        Me.twitch.Size = New System.Drawing.Size(183, 23)
        Me.twitch.TabIndex = 4
        Me.twitch.Text = "Ma chaine twitch : nt_games_ytb"
        Me.twitch.UseVisualStyleBackColor = True
        '
        'discord
        '
        Me.discord.Location = New System.Drawing.Point(895, 309)
        Me.discord.Name = "discord"
        Me.discord.Size = New System.Drawing.Size(183, 23)
        Me.discord.TabIndex = 5
        Me.discord.Text = "Mon discord : nt games#0375"
        Me.discord.UseVisualStyleBackColor = True
        '
        'IP
        '
        Me.IP.Location = New System.Drawing.Point(12, 268)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(688, 20)
        Me.IP.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(706, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 20)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "connect"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(895, 268)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 20)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "disconnect"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Fly"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox2.Location = New System.Drawing.Point(12, 85)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Kill Aura"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox3.Location = New System.Drawing.Point(12, 49)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox3.TabIndex = 12
        Me.CheckBox3.Text = "Aimbot"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox4.Location = New System.Drawing.Point(12, 153)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox4.TabIndex = 13
        Me.CheckBox4.Text = "Auto tools"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox5.Location = New System.Drawing.Point(12, 119)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox5.TabIndex = 14
        Me.CheckBox5.Text = "Kill Aura"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox6.Location = New System.Drawing.Point(12, 185)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox6.TabIndex = 15
        Me.CheckBox6.Text = "Auto chest"
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox7.Location = New System.Drawing.Point(95, 12)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox7.TabIndex = 16
        Me.CheckBox7.Text = "Auto potion"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox8.Location = New System.Drawing.Point(12, 219)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox8.TabIndex = 17
        Me.CheckBox8.Text = "Auto soup"
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox9.Location = New System.Drawing.Point(95, 49)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox9.TabIndex = 18
        Me.CheckBox9.Text = "Auto régénération"
        Me.CheckBox9.UseVisualStyleBackColor = False
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox10.Location = New System.Drawing.Point(95, 85)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox10.TabIndex = 19
        Me.CheckBox10.Text = "Auto Blocks"
        Me.CheckBox10.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(978, 218)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(100, 20)
        Me.NumericUpDown1.TabIndex = 20
        '
        'Gamma
        '
        Me.Gamma.AutoSize = True
        Me.Gamma.BackColor = System.Drawing.Color.Chartreuse
        Me.Gamma.Location = New System.Drawing.Point(895, 219)
        Me.Gamma.Name = "Gamma"
        Me.Gamma.Size = New System.Drawing.Size(77, 17)
        Me.Gamma.TabIndex = 21
        Me.Gamma.Text = "Gamma ++"
        Me.Gamma.UseVisualStyleBackColor = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(959, 184)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(119, 20)
        Me.NumericUpDown2.TabIndex = 22
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox11.Location = New System.Drawing.Point(895, 185)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox11.TabIndex = 23
        Me.CheckBox11.Text = "Reach"
        Me.CheckBox11.UseVisualStyleBackColor = False
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.BackColor = System.Drawing.Color.Chartreuse
        Me.CheckBox12.Location = New System.Drawing.Point(895, 153)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox12.TabIndex = 24
        Me.CheckBox12.Text = "Speed ++"
        Me.CheckBox12.UseVisualStyleBackColor = False
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(973, 152)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(105, 20)
        Me.NumericUpDown3.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "IP :"
        '
        'Form1
        '
        Me.AccessibleDescription = "MamiesMod cheat minecrft wii u pour PvP "
        Me.AccessibleName = "MamiesMod cheat minecraft wii u by nt games"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.MamiesMod_by_nt_games.My.Resources.Resources.fond_d_ecran_7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1090, 601)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Gamma)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.discord)
        Me.Controls.Add(Me.twitch)
        Me.Controls.Add(Me.ma_chaine)
        Me.Controls.Add(Me.twitter)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.insta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MamiesMod by nt games"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insta As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents twitter As System.Windows.Forms.Button
    Friend WithEvents ma_chaine As System.Windows.Forms.Button
    Friend WithEvents twitch As System.Windows.Forms.Button
    Friend WithEvents discord As System.Windows.Forms.Button
    Friend WithEvents IP As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Gamma As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
