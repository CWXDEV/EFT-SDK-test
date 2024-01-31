using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x0200069D RID: 1693
public class GClass639
{
	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x06002664 RID: 9828 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass639 Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass639.GClass640 CreateContainerForBatch(string batchId)
	{
		throw null;
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteBatch(string batchId)
	{
		throw null;
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManuallyCompleteBatch(string batchId)
	{
		throw null;
	}

	// Token: 0x04002580 RID: 9600
	private readonly Dictionary<string, GClass639.GClass641> dictionary_0;

	// Token: 0x04002581 RID: 9601
	private static GClass639 gclass639_0;

	// Token: 0x0200069E RID: 1694
	public class GClass640
	{
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x00002050 File Offset: 0x00000250
		public RaycastCommand Command
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

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x00002050 File Offset: 0x00000250
		public RaycastHit Result
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

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
		public bool Cocked
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		public bool ResultIsActual
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

		// Token: 0x06002670 RID: 9840 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNewCommand(RaycastCommand newCommand)
		{
			throw null;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetResult(RaycastHit result)
		{
			throw null;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckCompleteBatch()
		{
			throw null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04002582 RID: 9602
		private GClass639.GClass641 gclass641_0;

		// Token: 0x04002583 RID: 9603
		[CompilerGenerated]
		private RaycastCommand raycastCommand_0;

		// Token: 0x04002584 RID: 9604
		[CompilerGenerated]
		private RaycastHit raycastHit_0;

		// Token: 0x04002585 RID: 9605
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04002586 RID: 9606
		[CompilerGenerated]
		private bool bool_1;
	}

	// Token: 0x0200069F RID: 1695
	public class GClass641
	{
		// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterContainer(GClass639.GClass640 container)
		{
			throw null;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterContainer(GClass639.GClass640 container)
		{
			throw null;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteBatch()
		{
			throw null;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckCompleteBatch()
		{
			throw null;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04002587 RID: 9607
		private readonly string string_0;

		// Token: 0x04002588 RID: 9608
		private readonly List<GClass639.GClass640> list_0;

		// Token: 0x04002589 RID: 9609
		private JobHandle jobHandle_0;

		// Token: 0x0400258A RID: 9610
		private NativeArray<RaycastCommand> nativeArray_0;

		// Token: 0x0400258B RID: 9611
		private NativeArray<RaycastHit> nativeArray_1;

		// Token: 0x0400258C RID: 9612
		private bool bool_0;
	}
}
