using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;

// Token: 0x020006B2 RID: 1714
public class GClass645 : IDisposable
{
	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x060026B9 RID: 9913 RVA: 0x00002050 File Offset: 0x00000250
	public int RegisteredTriggersCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x060026BA RID: 9914 RVA: 0x00002050 File Offset: 0x00000250
	private GStruct25[] GStruct25_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x060026BB RID: 9915 RVA: 0x00002050 File Offset: 0x00000250
	private GStruct27.GClass644 GClass644_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int? RegisterCollider(BoxCollider collider)
	{
		throw null;
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncCollider(int id, BoxCollider collider)
	{
		throw null;
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCollider(BoxCollider collider)
	{
		throw null;
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BoxOverlap(int index, Vector3 center, Vector3 halfExtents, Quaternion orientation, Collider[] result, int mask, QueryTriggerInteraction queryTriggerInteraction, GClass646.GClass650.GClass655 asyncData)
	{
		throw null;
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass645.GStruct28 Schedule()
	{
		throw null;
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WaitScheduleComplete(GClass645.GStruct28 scheduled)
	{
		throw null;
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass642 method_0(int id, BoxCollider collider)
	{
		throw null;
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BoxCollider method_2(int id)
	{
		throw null;
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x040025FC RID: 9724
	public static int PARAMS_INDEX_COUNTER;

	// Token: 0x040025FD RID: 9725
	private const int int_0 = 32;

	// Token: 0x040025FE RID: 9726
	private const int int_1 = 128;

	// Token: 0x040025FF RID: 9727
	private readonly HashSet<BoxCollider> hashSet_0;

	// Token: 0x04002600 RID: 9728
	private readonly Dictionary<int, BoxCollider> dictionary_0;

	// Token: 0x04002601 RID: 9729
	private readonly List<GClass642> list_0;

	// Token: 0x04002602 RID: 9730
	private readonly GStruct25[] gstruct25_0;

	// Token: 0x04002603 RID: 9731
	private readonly GStruct25[] gstruct25_1;

	// Token: 0x04002604 RID: 9732
	private GStruct24[] gstruct24_0;

	// Token: 0x04002605 RID: 9733
	private GStruct24[] gstruct24_1;

	// Token: 0x04002606 RID: 9734
	private int int_2;

	// Token: 0x04002607 RID: 9735
	private readonly int int_3;

	// Token: 0x04002608 RID: 9736
	private int int_4;

	// Token: 0x04002609 RID: 9737
	private bool bool_0;

	// Token: 0x0400260A RID: 9738
	private int int_5;

	// Token: 0x020006B3 RID: 1715
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct28 : IDisposable
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400260B RID: 9739
		public GClass645 Searcher;

		// Token: 0x0400260C RID: 9740
		public int CommandsCount;

		// Token: 0x0400260D RID: 9741
		public GStruct27 Job;

		// Token: 0x0400260E RID: 9742
		public JobHandle Handle;
	}

	// Token: 0x020006B4 RID: 1716
	[CompilerGenerated]
	private sealed class Class363
	{
		// Token: 0x060026C9 RID: 9929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass642 t)
		{
			throw null;
		}

		// Token: 0x0400260F RID: 9743
		public int id;
	}

	// Token: 0x020006B5 RID: 1717
	[CompilerGenerated]
	private sealed class Class364
	{
		// Token: 0x060026CA RID: 9930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<int, BoxCollider> kv)
		{
			throw null;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass642 el)
		{
			throw null;
		}

		// Token: 0x04002610 RID: 9744
		public BoxCollider collider;

		// Token: 0x04002611 RID: 9745
		public int id;
	}
}
