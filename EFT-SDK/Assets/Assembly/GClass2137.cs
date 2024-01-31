using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001E27 RID: 7719
public static class GClass2137
{
	// Token: 0x06009EA4 RID: 40612
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool GetLogicalProcessorInformation(IntPtr buffer, ref uint returnLength);

	// Token: 0x06009EA5 RID: 40613
	[DllImport("kernel32.dll")]
	private static extern bool SetProcessAffinityMask(IntPtr hProcess, UIntPtr dwProcessAffinityMask);

	// Token: 0x06009EA6 RID: 40614
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int GetProcessAffinityMask(int hProcess, ref int lpProcessAffinityMask, ref int systemAffinityMask);

	// Token: 0x06009EA7 RID: 40615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetAffinityToLogicalCoresEnabled(bool enabled)
	{
		throw null;
	}

	// Token: 0x06009EA8 RID: 40616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass2137.Struct653[] smethod_0()
	{
		throw null;
	}

	// Token: 0x0400A6F1 RID: 42737
	private const int int_0 = 122;

	// Token: 0x02001E28 RID: 7720
	[StructLayout(LayoutKind.Auto)]
	public struct Struct649
	{
		// Token: 0x0400A6F2 RID: 42738
		public byte Flags;
	}

	// Token: 0x02001E29 RID: 7721
	[StructLayout(LayoutKind.Auto)]
	public struct Struct650
	{
		// Token: 0x0400A6F3 RID: 42739
		public uint NodeNumber;
	}

	// Token: 0x02001E2A RID: 7722
	public enum PROCESSOR_CACHE_TYPE
	{
		// Token: 0x0400A6F5 RID: 42741
		CacheUnified,
		// Token: 0x0400A6F6 RID: 42742
		CacheInstruction,
		// Token: 0x0400A6F7 RID: 42743
		CacheData,
		// Token: 0x0400A6F8 RID: 42744
		CacheTrace
	}

	// Token: 0x02001E2B RID: 7723
	[StructLayout(LayoutKind.Auto)]
	public struct Struct651
	{
		// Token: 0x0400A6F9 RID: 42745
		public byte Level;

		// Token: 0x0400A6FA RID: 42746
		public byte Associativity;

		// Token: 0x0400A6FB RID: 42747
		public ushort LineSize;

		// Token: 0x0400A6FC RID: 42748
		public uint Size;

		// Token: 0x0400A6FD RID: 42749
		public GClass2137.PROCESSOR_CACHE_TYPE Type;
	}

	// Token: 0x02001E2C RID: 7724
	[StructLayout(LayoutKind.Auto)]
	public struct Struct652
	{
		// Token: 0x0400A6FE RID: 42750
		public GClass2137.Struct649 ProcessorCore;

		// Token: 0x0400A6FF RID: 42751
		public GClass2137.Struct650 NumaNode;

		// Token: 0x0400A700 RID: 42752
		public GClass2137.Struct651 Cache;

		// Token: 0x0400A701 RID: 42753
		private ulong ulong_0;

		// Token: 0x0400A702 RID: 42754
		private ulong ulong_1;
	}

	// Token: 0x02001E2D RID: 7725
	public enum LOGICAL_PROCESSOR_RELATIONSHIP
	{
		// Token: 0x0400A704 RID: 42756
		RelationProcessorCore,
		// Token: 0x0400A705 RID: 42757
		RelationNumaNode,
		// Token: 0x0400A706 RID: 42758
		RelationCache,
		// Token: 0x0400A707 RID: 42759
		RelationProcessorPackage,
		// Token: 0x0400A708 RID: 42760
		RelationGroup,
		// Token: 0x0400A709 RID: 42761
		RelationAll = 65535
	}

	// Token: 0x02001E2E RID: 7726
	[StructLayout(LayoutKind.Auto)]
	public struct Struct653
	{
		// Token: 0x0400A70A RID: 42762
		public UIntPtr ProcessorMask;

		// Token: 0x0400A70B RID: 42763
		public GClass2137.LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

		// Token: 0x0400A70C RID: 42764
		public GClass2137.Struct652 ProcessorInformation;
	}

	// Token: 0x02001E2F RID: 7727
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1802
	{
		// Token: 0x06009EA9 RID: 40617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2137.Struct653 information)
		{
			throw null;
		}

		// Token: 0x0400A70D RID: 42765
		public static readonly GClass2137.Class1802 class1802_0;

		// Token: 0x0400A70E RID: 42766
		public static Func<GClass2137.Struct653, bool> func_0;
	}
}
