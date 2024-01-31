using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

// Token: 0x02002C70 RID: 11376
public class GClass3078<T, U> : GClass3075<T, U> where U : IUIView
{
	// Token: 0x0600E033 RID: 57395 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(IEnumerable<T> items, Func<T, U> itemViewFactory, Func<T, Transform> container, Action<T, U> showAction, bool destroyOnKill)
	{
		throw null;
	}

	// Token: 0x02002C71 RID: 11377
	[CompilerGenerated]
	private sealed class Class2709
	{
		// Token: 0x0600E034 RID: 57396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal U method_0(T item)
		{
			throw null;
		}

		// Token: 0x0400E4BA RID: 58554
		public Func<T, U> templateFactory;

		// Token: 0x0400E4BB RID: 58555
		public GClass3078<T, U> gclass3078_0;
	}

	// Token: 0x02002C72 RID: 11378
	[CompilerGenerated]
	private sealed class Class2710
	{
		// Token: 0x0600E035 RID: 57397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal U method_0(T arg)
		{
			throw null;
		}

		// Token: 0x0600E036 RID: 57398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Transform method_1(T arg)
		{
			throw null;
		}

		// Token: 0x0400E4BC RID: 58556
		public U template;

		// Token: 0x0400E4BD RID: 58557
		public Transform container;
	}

	// Token: 0x02002C73 RID: 11379
	[CompilerGenerated]
	private sealed class Class2711
	{
		// Token: 0x0600E037 RID: 57399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Transform method_0(T arg)
		{
			throw null;
		}

		// Token: 0x0400E4BE RID: 58558
		public Transform container;
	}
}
