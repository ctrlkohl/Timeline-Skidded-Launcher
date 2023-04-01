using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Timeline
{
	// Token: 0x0200000D RID: 13
	public class Play : UserControl
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003FD8 File Offset: 0x000021D8
		public Play()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002526 File Offset: 0x00000726
		private void Play_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003FF0 File Offset: 0x000021F0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004028 File Offset: 0x00002228
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "Play";
			base.Load += this.Play_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x0400003D RID: 61
		private IContainer components = null;
	}
}
