using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Timeline
{
	// Token: 0x0200000E RID: 14
	internal class ProcessHelper
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004084 File Offset: 0x00002284
		public static Process StartProcess(string path, bool shouldFreeze, string extraArgs = "")
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = path,
					Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=2725i0h34666525d51b022h3 " + extraArgs
				}
			};
			process.Start();
			if (shouldFreeze)
			{
				foreach (object obj in process.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					ProcessHelper.SuspendThread(ProcessHelper.OpenThread(2, false, processThread.Id));
				}
			}
			return process;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004138 File Offset: 0x00002338
		public static Process StartCustomProcess(string path, bool shouldFreeze, string extraArgs = "")
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = path,
					Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=" + Account.CustomFLToken + " " + extraArgs
				}
			};
			process.Start();
			if (shouldFreeze)
			{
				foreach (object obj in process.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					ProcessHelper.SuspendThread(ProcessHelper.OpenThread(2, false, processThread.Id));
				}
			}
			return process;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000041F4 File Offset: 0x000023F4
		public static void InjectDll(int processId, string path)
		{
			IntPtr hProcess = ProcessHelper.OpenProcess(1082, false, processId);
			IntPtr procAddress = ProcessHelper.GetProcAddress(ProcessHelper.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			uint num = (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char)));
			IntPtr intPtr = ProcessHelper.VirtualAllocEx(hProcess, IntPtr.Zero, num, 12288U, 4U);
			UIntPtr uintPtr;
			ProcessHelper.WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(path), num, out uintPtr);
			ProcessHelper.CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
		}

		// Token: 0x06000034 RID: 52
		[DllImport("kernel32.dll")]
		public static extern int SuspendThread(IntPtr hThread);

		// Token: 0x06000035 RID: 53
		[DllImport("kernel32.dll")]
		public static extern int ResumeThread(IntPtr hThread);

		// Token: 0x06000036 RID: 54
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);

		// Token: 0x06000037 RID: 55
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hHandle);

		// Token: 0x06000038 RID: 56
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x06000039 RID: 57
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x0600003D RID: 61
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
	}
}
