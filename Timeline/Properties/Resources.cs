using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Timeline.Properties
{
	// Token: 0x02000010 RID: 16
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00004296 File Offset: 0x00002496
		internal Resources()
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000042A0 File Offset: 0x000024A0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Timeline.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000042E8 File Offset: 0x000024E8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000042FF File Offset: 0x000024FF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400003E RID: 62
		private static ResourceManager resourceMan;

		// Token: 0x0400003F RID: 63
		private static CultureInfo resourceCulture;
	}
}
