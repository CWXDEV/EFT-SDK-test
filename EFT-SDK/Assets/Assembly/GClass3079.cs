using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

// Token: 0x02002C31 RID: 11313
public class GClass3079<T, U> : GClass3078<T, U> where U : IUIView
{
	// Token: 0x1400030C RID: 780
	// (add) Token: 0x0600DEF6 RID: 57078 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600DEF7 RID: 57079 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<T> OnRemove
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

	// Token: 0x0600DEF8 RID: 57080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddItem(T item)
	{
		throw null;
	}

	// Token: 0x0600DEF9 RID: 57081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RemoveItem(T item)
	{
		throw null;
	}

	// Token: 0x0600DEFA RID: 57082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddItems(IEnumerable<T> items)
	{
		throw null;
	}

	// Token: 0x0600DEFB RID: 57083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RemoveAllItems()
	{
		throw null;
	}

	// Token: 0x0600DEFC RID: 57084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400E3DA RID: 58330
	[CompilerGenerated]
	private Action<T> action_2;

	// Token: 0x0400E3DB RID: 58331
	private readonly GInterface390<T> ginterface390_0;

	// Token: 0x02002C32 RID: 11314
	[CompilerGenerated]
	private sealed class Class2694
	{
		// Token: 0x0600DEFD RID: 57085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal U method_0(T arg)
		{
			throw null;
		}

		// Token: 0x0600DEFE RID: 57086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Transform method_1(T arg)
		{
			throw null;
		}

		// Token: 0x0400E3DC RID: 58332
		public U template;

		// Token: 0x0400E3DD RID: 58333
		public Transform container;
	}
}
