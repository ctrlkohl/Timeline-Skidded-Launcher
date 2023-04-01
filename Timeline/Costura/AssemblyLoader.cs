using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x02000012 RID: 18
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000433E File Offset: 0x0000253E
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004350 File Offset: 0x00002550
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000043C0 File Offset: 0x000025C0
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000043F4 File Offset: 0x000025F4
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004478 File Offset: 0x00002678
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004498 File Offset: 0x00002698
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000044C0 File Offset: 0x000026C0
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004580 File Offset: 0x00002780
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				object obj2 = AssemblyLoader.nullCacheLock;
				lock (obj2)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004658 File Offset: 0x00002858
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("bunifu.licensing", "costura.bunifu.licensing.dll.compressed");
			AssemblyLoader.symbolNames.Add("bunifu.licensing", "costura.bunifu.licensing.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("bunifu.ui.winforms.1.5.3", "costura.bunifu.ui.winforms.1.5.3.dll.compressed");
			AssemblyLoader.assemblyNames.Add("bunifu.ui.winforms", "costura.bunifu.ui.winforms.dll.compressed");
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("guna.ui2", "costura.guna.ui2.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.registry.accesscontrol", "costura.microsoft.win32.registry.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.registry", "costura.microsoft.win32.registry.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.systemevents", "costura.microsoft.win32.systemevents.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.windowsapicodepack", "costura.microsoft.windowsapicodepack.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.windowsapicodepack.shell", "costura.microsoft.windowsapicodepack.shell.dll.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("restsharp", "costura.restsharp.dll.compressed");
			AssemblyLoader.assemblyNames.Add("siticone.desktop.ui", "costura.siticone.desktop.ui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.codedom", "costura.system.codedom.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.collections.immutable", "costura.system.collections.immutable.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.configuration.configurationmanager", "costura.system.configuration.configurationmanager.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.data.odbc", "costura.system.data.odbc.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.data.oledb", "costura.system.data.oledb.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.data.sqlclient", "costura.system.data.sqlclient.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.eventlog", "costura.system.diagnostics.eventlog.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.performancecounter", "costura.system.diagnostics.performancecounter.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.drawing.common", "costura.system.drawing.common.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.filesystem.accesscontrol", "costura.system.io.filesystem.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.packaging", "costura.system.io.packaging.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.pipes.accesscontrol", "costura.system.io.pipes.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.ports", "costura.system.io.ports.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.accesscontrol", "costura.system.security.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.cng", "costura.system.security.cryptography.cng.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.pkcs", "costura.system.security.cryptography.pkcs.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.protecteddata", "costura.system.security.cryptography.protecteddata.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.xml", "costura.system.security.cryptography.xml.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.permissions", "costura.system.security.permissions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.principal.windows", "costura.system.security.principal.windows.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.duplex", "costura.system.servicemodel.duplex.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.duplex", "costura.system.servicemodel.duplex.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.http", "costura.system.servicemodel.http.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.http", "costura.system.servicemodel.http.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.nettcp", "costura.system.servicemodel.nettcp.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.nettcp", "costura.system.servicemodel.nettcp.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.primitives", "costura.system.servicemodel.primitives.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.primitives", "costura.system.servicemodel.primitives.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.security", "costura.system.servicemodel.security.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.security", "costura.system.servicemodel.security.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.syndication", "costura.system.servicemodel.syndication.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.serviceprocess.servicecontroller", "costura.system.serviceprocess.servicecontroller.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.encoding.codepages", "costura.system.text.encoding.codepages.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.threading.accesscontrol", "costura.system.threading.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.web.services.description", "costura.system.web.services.description.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.web.services.description", "costura.system.web.services.description.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("uno.diagnostics.eventing", "costura.uno.diagnostics.eventing.dll.compressed");
			AssemblyLoader.symbolNames.Add("uno.diagnostics.eventing", "costura.uno.diagnostics.eventing.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("uno", "costura.uno.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.fonts.fluent", "costura.uno.fonts.fluent.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.foundation", "costura.uno.foundation.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.foundation.logging", "costura.uno.foundation.logging.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui.composition", "costura.uno.ui.composition.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui.dispatching", "costura.uno.ui.dispatching.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui", "costura.uno.ui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui.fluenttheme", "costura.uno.ui.fluenttheme.dll.compressed");
			AssemblyLoader.symbolNames.Add("uno.ui.fluenttheme", "costura.uno.ui.fluenttheme.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui.fluenttheme.v1", "costura.uno.ui.fluenttheme.v1.dll.compressed");
			AssemblyLoader.symbolNames.Add("uno.ui.fluenttheme.v1", "costura.uno.ui.fluenttheme.v1.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui.fluenttheme.v2", "costura.uno.ui.fluenttheme.v2.dll.compressed");
			AssemblyLoader.symbolNames.Add("uno.ui.fluenttheme.v2", "costura.uno.ui.fluenttheme.v2.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("uno.ui.toolkit", "costura.uno.ui.toolkit.dll.compressed");
			AssemblyLoader.symbolNames.Add("uno.ui.toolkit", "costura.uno.ui.toolkit.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("uno.xaml", "costura.uno.xaml.dll.compressed");
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004C58 File Offset: 0x00002E58
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x04000041 RID: 65
		private static object nullCacheLock = new object();

		// Token: 0x04000042 RID: 66
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x04000043 RID: 67
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x04000044 RID: 68
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x04000045 RID: 69
		private static int isAttached;
	}
}
