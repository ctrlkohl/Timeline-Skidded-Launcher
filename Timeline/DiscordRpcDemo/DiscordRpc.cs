using System;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	// Token: 0x02000003 RID: 3
	public class DiscordRpc
	{
		// Token: 0x06000009 RID: 9
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x0600000A RID: 10
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x0600000B RID: 11
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x0600000C RID: 12
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x0600000D RID: 13 RVA: 0x000021E2 File Offset: 0x000003E2
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
			throw new NotImplementedException();
		}

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000010 RID: 16
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000014 RID: 20
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x02000006 RID: 6
		public struct EventHandlers
		{
			// Token: 0x04000004 RID: 4
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x04000005 RID: 5
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x04000006 RID: 6
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000018 RID: 24
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x02000008 RID: 8
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x04000007 RID: 7
			public string state;

			// Token: 0x04000008 RID: 8
			public string details;

			// Token: 0x04000009 RID: 9
			public long startTimestamp;

			// Token: 0x0400000A RID: 10
			public long endTimestamp;

			// Token: 0x0400000B RID: 11
			public string largeImageKey;

			// Token: 0x0400000C RID: 12
			public string largeImageText;

			// Token: 0x0400000D RID: 13
			public string smallImageKey;

			// Token: 0x0400000E RID: 14
			public string smallImageText;

			// Token: 0x0400000F RID: 15
			public string partyId;

			// Token: 0x04000010 RID: 16
			public int partySize;

			// Token: 0x04000011 RID: 17
			public int partyMax;

			// Token: 0x04000012 RID: 18
			public string matchSecret;

			// Token: 0x04000013 RID: 19
			public string joinSecret;

			// Token: 0x04000014 RID: 20
			public string spectateSecret;

			// Token: 0x04000015 RID: 21
			public bool instance;
		}
	}
}
