using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Koenigz.PerfectCulling.EFT;
using UnityEngine;

// Token: 0x02000DDE RID: 3550
public sealed class GClass1030 : IDisposable
{
	// Token: 0x17000BE3 RID: 3043
	// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004AB8 RID: 19128 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass1030 Instance
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

	// Token: 0x140000E7 RID: 231
	// (add) Token: 0x06004AB9 RID: 19129 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06004ABA RID: 19130 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action OnCullingGridCreated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x17000BE4 RID: 3044
	// (get) Token: 0x06004ABB RID: 19131 RVA: 0x00002050 File Offset: 0x00000250
	public CullingGridPreProcess PreProc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BE5 RID: 3045
	// (get) Token: 0x06004ABC RID: 19132 RVA: 0x00002050 File Offset: 0x00000250
	public Bounds[] VisibilityCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BE6 RID: 3046
	// (get) Token: 0x06004ABD RID: 19133 RVA: 0x00002050 File Offset: 0x00000250
	public int GroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004ABE RID: 19134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06004ABF RID: 19135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06004AC0 RID: 19136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct76 Query(Vector3 point)
	{
		throw null;
	}

	// Token: 0x040055E2 RID: 21986
	[CompilerGenerated]
	private static GClass1030 gclass1030_0;

	// Token: 0x040055E3 RID: 21987
	[CompilerGenerated]
	private static Action action_0;

	// Token: 0x040055E4 RID: 21988
	private PerfectCullingAdaptiveGrid perfectCullingAdaptiveGrid_0;

	// Token: 0x040055E5 RID: 21989
	private int int_0;

	// Token: 0x040055E6 RID: 21990
	private GClass1042.GClass1043 gclass1043_0;

	// Token: 0x040055E7 RID: 21991
	private CullingGridPreProcess cullingGridPreProcess_0;

	// Token: 0x040055E8 RID: 21992
	private GClass1013<ushort> gclass1013_0;

	// Token: 0x02000DDF RID: 3551
	[StructLayout(LayoutKind.Auto)]
	public struct Struct160
	{
		// Token: 0x06004AC1 RID: 19137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DecompressCallback(GStruct78 cd)
		{
			throw null;
		}

		// Token: 0x040055E9 RID: 21993
		public GClass1013<ushort> Indices;
	}
}
