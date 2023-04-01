using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Timeline.Properties
{
	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004308 File Offset: 0x00002508
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000040 RID: 64
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
