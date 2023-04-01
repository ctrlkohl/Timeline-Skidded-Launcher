namespace Timeline
{
	// Token: 0x0200000B RID: 11
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002828 File Offset: 0x00000A28
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002860 File Offset: 0x00000A60
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Timeline.Form1));
			this.siticoneTabControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.siticonePictureBox1 = new global::Siticone.Desktop.UI.WinForms.SiticonePictureBox();
			this.siticoneVSeparator1 = new global::Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.pass = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.path = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.email = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2GradientButton6 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton5 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton4 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.siticoneVSeparator2 = new global::Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.siticoneVSeparator3 = new global::Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.siticoneAnimateWindow1 = new global::Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.siticoneTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			//this.siticonePictureBox1.BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			base.SuspendLayout();
			this.siticoneTabControl1.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.siticoneTabControl1.Controls.Add(this.tabPage1);
			this.siticoneTabControl1.Controls.Add(this.tabPage2);
			this.siticoneTabControl1.Controls.Add(this.tabPage3);
			this.siticoneTabControl1.HotTrack = true;
			this.siticoneTabControl1.ItemSize = new global::System.Drawing.Size(180, 40);
			this.siticoneTabControl1.Location = new global::System.Drawing.Point(-1, -4);
			this.siticoneTabControl1.Name = "siticoneTabControl1";
			this.siticoneTabControl1.SelectedIndex = 0;
			this.siticoneTabControl1.Size = new global::System.Drawing.Size(905, 478);
			this.siticoneTabControl1.TabButtonHoverState.BorderColor = global::System.Drawing.Color.Empty;
			this.siticoneTabControl1.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(40, 52, 70);
			this.siticoneTabControl1.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.siticoneTabControl1.TabButtonHoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneTabControl1.TabButtonHoverState.InnerColor = global::System.Drawing.Color.FromArgb(40, 52, 70);
			this.siticoneTabControl1.TabButtonIdleState.BorderColor = global::System.Drawing.Color.Empty;
			this.siticoneTabControl1.TabButtonIdleState.FillColor = global::System.Drawing.Color.FromArgb(33, 42, 57);
			this.siticoneTabControl1.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.siticoneTabControl1.TabButtonIdleState.ForeColor = global::System.Drawing.Color.FromArgb(156, 160, 167);
			this.siticoneTabControl1.TabButtonIdleState.InnerColor = global::System.Drawing.Color.FromArgb(33, 42, 57);
			this.siticoneTabControl1.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.Empty;
			this.siticoneTabControl1.TabButtonSelectedState.FillColor = global::System.Drawing.Color.FromArgb(29, 37, 49);
			this.siticoneTabControl1.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.siticoneTabControl1.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneTabControl1.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.FromArgb(76, 132, 255);
			this.siticoneTabControl1.TabButtonSize = new global::System.Drawing.Size(180, 40);
			this.siticoneTabControl1.TabIndex = 0;
			this.siticoneTabControl1.TabMenuBackColor = global::System.Drawing.Color.FromArgb(29, 31, 31);
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(29, 31, 31);
			this.tabPage1.Controls.Add(this.guna2GradientButton1);
			this.tabPage1.Controls.Add(this.siticonePictureBox1);
			this.tabPage1.Controls.Add(this.siticoneVSeparator1);
			this.tabPage1.ForeColor = global::System.Drawing.Color.White;
			this.tabPage1.Location = new global::System.Drawing.Point(184, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(717, 470);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Home";
			this.guna2GradientButton1.Animated = true;
			this.guna2GradientButton1.BorderColor = global::System.Drawing.Color.White;
			this.guna2GradientButton1.BorderRadius = 9;
			this.guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton1.FillColor2 = global::System.Drawing.Color.FromArgb(134, 203, 241);
			this.guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton1.IndicateFocus = true;
			this.guna2GradientButton1.Location = new global::System.Drawing.Point(267, 247);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new global::System.Drawing.Size(187, 45);
			this.guna2GradientButton1.TabIndex = 3;
			this.guna2GradientButton1.Text = "Launch";
			this.guna2GradientButton1.Click += new global::System.EventHandler(this.guna2GradientButton1_Click);
			this.siticonePictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticonePictureBox1.FillColor = global::System.Drawing.Color.Transparent;
			//this.siticonePictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticonePictureBox1.Image");
			this.siticonePictureBox1.ImageRotate = 0f;
			this.siticonePictureBox1.Location = new global::System.Drawing.Point(-138, -70);
			this.siticonePictureBox1.Name = "siticonePictureBox1";
			this.siticonePictureBox1.Size = new global::System.Drawing.Size(994, 526);
			this.siticonePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox1.TabIndex = 1;
			this.siticonePictureBox1.TabStop = false;
			this.siticonePictureBox1.UseTransparentBackground = true;
			this.siticoneVSeparator1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneVSeparator1.FillThickness = 2;
			this.siticoneVSeparator1.Location = new global::System.Drawing.Point(-5, -18);
			this.siticoneVSeparator1.Name = "siticoneVSeparator1";
			this.siticoneVSeparator1.Size = new global::System.Drawing.Size(10, 556);
			this.siticoneVSeparator1.TabIndex = 0;
			this.siticoneVSeparator1.UseTransparentBackground = true;
			this.tabPage2.BackColor = global::System.Drawing.Color.FromArgb(29, 31, 31);
			this.tabPage2.Controls.Add(this.pass);
			this.tabPage2.Controls.Add(this.path);
			this.tabPage2.Controls.Add(this.email);
			this.tabPage2.Controls.Add(this.guna2GradientButton6);
			this.tabPage2.Controls.Add(this.guna2GradientButton5);
			this.tabPage2.Controls.Add(this.guna2GradientButton4);
			this.tabPage2.Controls.Add(this.siticoneVSeparator2);
			this.tabPage2.ForeColor = global::System.Drawing.Color.White;
			this.tabPage2.Location = new global::System.Drawing.Point(184, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(721, 471);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Settings";
			this.tabPage2.Click += new global::System.EventHandler(this.tabPage2_Click);
			this.pass.Animated = true;
			this.pass.BorderColor = global::System.Drawing.Color.Black;
			this.pass.BorderRadius = 5;
			this.pass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.pass.DefaultText = "";
			this.pass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.pass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.pass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.pass.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.pass.ForeColor = global::System.Drawing.Color.Black;
			this.pass.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.pass.Location = new global::System.Drawing.Point(11, 54);
			this.pass.Name = "pass";
			this.pass.PasswordChar = '\0';
			this.pass.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.pass.PlaceholderText = "Password";
			this.pass.SelectedText = "";
			this.pass.Size = new global::System.Drawing.Size(331, 36);
			this.pass.TabIndex = 11;
			this.path.Animated = true;
			this.path.BorderColor = global::System.Drawing.Color.Black;
			this.path.BorderRadius = 5;
			this.path.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.path.DefaultText = "";
			this.path.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.path.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.path.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.path.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.path.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.path.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.path.ForeColor = global::System.Drawing.Color.Black;
			this.path.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.path.Location = new global::System.Drawing.Point(11, 96);
			this.path.Name = "path";
			this.path.PasswordChar = '\0';
			this.path.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.path.PlaceholderText = "Fortnite Path";
			this.path.SelectedText = "";
			this.path.Size = new global::System.Drawing.Size(331, 36);
			this.path.TabIndex = 10;
			this.path.TextChanged += new global::System.EventHandler(this.path_TextChanged);
			this.email.Animated = true;
			this.email.BorderColor = global::System.Drawing.Color.Black;
			this.email.BorderRadius = 5;
			this.email.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.email.DefaultText = "";
			this.email.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.email.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.email.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.email.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.email.ForeColor = global::System.Drawing.Color.Black;
			this.email.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.email.Location = new global::System.Drawing.Point(11, 12);
			this.email.Name = "email";
			this.email.PasswordChar = '\0';
			this.email.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.email.PlaceholderText = "Email";
			this.email.SelectedText = "";
			this.email.Size = new global::System.Drawing.Size(331, 36);
			this.email.TabIndex = 9;
			this.email.TextChanged += new global::System.EventHandler(this.guna2TextBox1_TextChanged);
			this.guna2GradientButton6.Animated = true;
			this.guna2GradientButton6.BorderColor = global::System.Drawing.Color.White;
			this.guna2GradientButton6.BorderRadius = 9;
			this.guna2GradientButton6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton6.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton6.FillColor2 = global::System.Drawing.Color.FromArgb(134, 203, 241);
			this.guna2GradientButton6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton6.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton6.IndicateFocus = true;
			this.guna2GradientButton6.Location = new global::System.Drawing.Point(518, 409);
			this.guna2GradientButton6.Name = "guna2GradientButton6";
			this.guna2GradientButton6.Size = new global::System.Drawing.Size(187, 45);
			this.guna2GradientButton6.TabIndex = 8;
			this.guna2GradientButton6.Text = "EasyInstaller";
			this.guna2GradientButton6.Click += new global::System.EventHandler(this.guna2GradientButton6_Click);
			this.guna2GradientButton5.Animated = true;
			this.guna2GradientButton5.BorderColor = global::System.Drawing.Color.White;
			this.guna2GradientButton5.BorderRadius = 9;
			this.guna2GradientButton5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton5.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton5.FillColor2 = global::System.Drawing.Color.FromArgb(134, 203, 241);
			this.guna2GradientButton5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton5.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton5.IndicateFocus = true;
			this.guna2GradientButton5.Location = new global::System.Drawing.Point(348, 96);
			this.guna2GradientButton5.Name = "guna2GradientButton5";
			this.guna2GradientButton5.Size = new global::System.Drawing.Size(67, 36);
			this.guna2GradientButton5.TabIndex = 7;
			this.guna2GradientButton5.Text = "...";
			this.guna2GradientButton5.Click += new global::System.EventHandler(this.guna2GradientButton5_Click);
			this.guna2GradientButton4.Animated = true;
			this.guna2GradientButton4.BorderColor = global::System.Drawing.Color.White;
			this.guna2GradientButton4.BorderRadius = 9;
			this.guna2GradientButton4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton4.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton4.FillColor2 = global::System.Drawing.Color.FromArgb(134, 203, 241);
			this.guna2GradientButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton4.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton4.IndicateFocus = true;
			this.guna2GradientButton4.Location = new global::System.Drawing.Point(518, 358);
			this.guna2GradientButton4.Name = "guna2GradientButton4";
			this.guna2GradientButton4.Size = new global::System.Drawing.Size(187, 45);
			this.guna2GradientButton4.TabIndex = 6;
			this.guna2GradientButton4.Text = "Save Config";
			this.guna2GradientButton4.Click += new global::System.EventHandler(this.guna2GradientButton4_Click);
			this.siticoneVSeparator2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneVSeparator2.FillThickness = 2;
			this.siticoneVSeparator2.Location = new global::System.Drawing.Point(-5, -60);
			this.siticoneVSeparator2.Name = "siticoneVSeparator2";
			this.siticoneVSeparator2.Size = new global::System.Drawing.Size(10, 556);
			this.siticoneVSeparator2.TabIndex = 1;
			this.siticoneVSeparator2.UseTransparentBackground = true;
			this.tabPage3.BackColor = global::System.Drawing.Color.FromArgb(29, 31, 31);
			this.tabPage3.Controls.Add(this.richTextBox1);
			this.tabPage3.Controls.Add(this.siticoneVSeparator3);
			this.tabPage3.ForeColor = global::System.Drawing.Color.White;
			this.tabPage3.Location = new global::System.Drawing.Point(184, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new global::System.Drawing.Size(721, 471);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Credits";
			this.siticoneVSeparator3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneVSeparator3.FillThickness = 2;
			this.siticoneVSeparator3.Location = new global::System.Drawing.Point(-5, -55);
			this.siticoneVSeparator3.Name = "siticoneVSeparator3";
			this.siticoneVSeparator3.Size = new global::System.Drawing.Size(10, 556);
			this.siticoneVSeparator3.TabIndex = 1;
			this.siticoneVSeparator3.UseTransparentBackground = true;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.siticoneBorderlessForm1.BorderRadius = 5;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.siticoneBorderlessForm1.DragStartTransparencyValue = 1.0;
			this.siticoneBorderlessForm1.ResizeForm = false;
			this.siticoneBorderlessForm1.TransparentWhileDrag = true;
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(29, 31, 31);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new global::System.Drawing.Font("SF UI Text", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.richTextBox1.HideSelection = false;
			this.richTextBox1.Location = new global::System.Drawing.Point(11, 12);
			this.richTextBox1.MaxLength = 0;
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(457, 259);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "Project Nova - Inspiration\nMilxnor & Twin1 - Skins from locker in-game\nLawin - Discord Bot & XMPP\nSSH - Launcher & Backend & Native DLL\nZaspex - Text Replacements\nEthan - Server Moderation";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(29, 31, 31);
			base.ClientSize = new global::System.Drawing.Size(900, 466);
			base.Controls.Add(this.siticoneTabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.siticoneTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			//this.siticonePictureBox1.EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000023 RID: 35
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000024 RID: 36
		private global::Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000028 RID: 40
		private global::Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;

		// Token: 0x04000029 RID: 41
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x0400002B RID: 43
		private global::Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;

		// Token: 0x0400002C RID: 44
		private global::Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator2;

		// Token: 0x0400002D RID: 45
		private global::Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator3;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;

		// Token: 0x0400002F RID: 47
		private global::Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;

		// Token: 0x04000030 RID: 48
		private global::Guna.UI2.WinForms.Guna2TextBox path;

		// Token: 0x04000031 RID: 49
		private global::Guna.UI2.WinForms.Guna2TextBox email;

		// Token: 0x04000032 RID: 50
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;

		// Token: 0x04000033 RID: 51
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;

		// Token: 0x04000034 RID: 52
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;

		// Token: 0x04000035 RID: 53
		private global::Guna.UI2.WinForms.Guna2TextBox pass;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.RichTextBox richTextBox1;
	}
}
