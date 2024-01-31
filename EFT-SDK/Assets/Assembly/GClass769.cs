using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020007FC RID: 2044
public static class GClass769
{
	// Token: 0x17000834 RID: 2100
	// (get) Token: 0x06002F33 RID: 12083 RVA: 0x00002050 File Offset: 0x00000250
	private static float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000835 RID: 2101
	// (get) Token: 0x06002F34 RID: 12084 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002F35 RID: 12085 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass769.MemoryManagementSettings Settings
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x06002F36 RID: 12086 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00002050 File Offset: 0x00000250
	public static bool GCEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06002F38 RID: 12088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init(GClass769.MemoryManagementSettings settings)
	{
		throw null;
	}

	// Token: 0x06002F39 RID: 12089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EmptyWorkingSet()
	{
		throw null;
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float Collect(bool force = false)
	{
		throw null;
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float Collect(int generation, GCCollectionMode gcMode, bool isBlocking, bool compacting, bool force)
	{
		throw null;
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task CollectAsync()
	{
		throw null;
	}

	// Token: 0x06002F3D RID: 12093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetTotalAllocatedMemoryGB()
	{
		throw null;
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RunHeapPreAllocation()
	{
		throw null;
	}

	// Token: 0x06002F3F RID: 12095
	[DllImport("psapi.dll", EntryPoint = "EmptyWorkingSet")]
	private static extern bool EmptyWorkingSet_1(IntPtr hProcess);

	// Token: 0x04002E47 RID: 11847
	private const float float_0 = 600f;

	// Token: 0x04002E48 RID: 11848
	private static float float_1;

	// Token: 0x04002E49 RID: 11849
	[CompilerGenerated]
	private static GClass769.MemoryManagementSettings memoryManagementSettings_0;

	// Token: 0x04002E4A RID: 11850
	public static Action<string> Logger;

	// Token: 0x020007FD RID: 2045
	[Serializable]
	public struct MemoryManagementSettings
	{
		// Token: 0x04002E4B RID: 11851
		public static readonly GClass769.MemoryManagementSettings Default;

		// Token: 0x04002E4C RID: 11852
		public bool HeapPreAllocationEnabled;

		// Token: 0x04002E4D RID: 11853
		public int HeapPreAllocationMB;

		// Token: 0x04002E4E RID: 11854
		public bool OverrideRamCleanerSettings;

		// Token: 0x04002E4F RID: 11855
		public bool RamCleanerEnabled;

		// Token: 0x04002E50 RID: 11856
		public int GigabytesRequiredToDisableGCDuringRaid;

		// Token: 0x04002E51 RID: 11857
		public bool AggressiveGC;
	}

	// Token: 0x020007FF RID: 2047
	[CompilerGenerated]
	[Serializable]
	private sealed class Class418
	{
		// Token: 0x06002F42 RID: 12098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string s)
		{
			throw null;
		}

		// Token: 0x04002E58 RID: 11864
		public static readonly GClass769.Class418 class418_0;
	}
}
