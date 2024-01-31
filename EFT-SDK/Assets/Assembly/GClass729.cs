using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020007A5 RID: 1957
public static class GClass729
{
	// Token: 0x06002D73 RID: 11635
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	// Token: 0x06002D74 RID: 11636
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out GClass729.GStruct43 counters, uint size);

	// Token: 0x06002D75 RID: 11637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass729.GStruct43 smethod_0()
	{
		throw null;
	}

	// Token: 0x06002D76 RID: 11638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass729.GStruct43 GetCounters()
	{
		throw null;
	}

	// Token: 0x020007A6 RID: 1958
	[StructLayout(LayoutKind.Auto, Size = 72)]
	public struct GStruct43
	{
		// Token: 0x06002D77 RID: 11639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04002BF7 RID: 11255
		public uint cb;

		// Token: 0x04002BF8 RID: 11256
		public uint PageFaultCount;

		// Token: 0x04002BF9 RID: 11257
		public ulong PeakWorkingSetSize;

		// Token: 0x04002BFA RID: 11258
		public ulong WorkingSetSize;

		// Token: 0x04002BFB RID: 11259
		public ulong QuotaPeakPagedPoolUsage;

		// Token: 0x04002BFC RID: 11260
		public ulong QuotaPagedPoolUsage;

		// Token: 0x04002BFD RID: 11261
		public ulong QuotaPeakNonPagedPoolUsage;

		// Token: 0x04002BFE RID: 11262
		public ulong QuotaNonPagedPoolUsage;

		// Token: 0x04002BFF RID: 11263
		public ulong PagefileUsage;

		// Token: 0x04002C00 RID: 11264
		public ulong PeakPagefileUsage;
	}
}
