using System;
using System.Windows.Forms;

namespace Timeline
{
	// Token: 0x0200000F RID: 15
	internal static class Program
	{
		// Token: 0x0600003F RID: 63 RVA: 0x0000427B File Offset: 0x0000247B
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
