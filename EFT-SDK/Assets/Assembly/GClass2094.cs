using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02001DA0 RID: 7584
public class GClass2094
{
	// Token: 0x140001E7 RID: 487
	// (add) Token: 0x06009C5C RID: 40028 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C5D RID: 40029 RVA: 0x00002050 File Offset: 0x00000250
	public event Action SearchStarted
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

	// Token: 0x140001E8 RID: 488
	// (add) Token: 0x06009C5E RID: 40030 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C5F RID: 40031 RVA: 0x00002050 File Offset: 0x00000250
	public event Action SearchStopped
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

	// Token: 0x140001E9 RID: 489
	// (add) Token: 0x06009C60 RID: 40032 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C61 RID: 40033 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<LootItemClass> SearchComplete
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

	// Token: 0x1700188E RID: 6286
	// (get) Token: 0x06009C62 RID: 40034 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C63 RID: 40035 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSearching
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700188F RID: 6287
	// (get) Token: 0x06009C64 RID: 40036 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C65 RID: 40037 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSearchActive
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

	// Token: 0x06009C66 RID: 40038 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Search(string searchText)
	{
		throw null;
	}

	// Token: 0x06009C67 RID: 40039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop(bool silent = false)
	{
		throw null;
	}

	// Token: 0x0400A398 RID: 41880
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400A399 RID: 41881
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400A39A RID: 41882
	[CompilerGenerated]
	private Action<LootItemClass> action_2;

	// Token: 0x0400A39B RID: 41883
	private ItemFactory gclass1483_0;

	// Token: 0x0400A39C RID: 41884
	private GameObject gameObject_0;

	// Token: 0x0400A39D RID: 41885
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400A39E RID: 41886
	private readonly List<Item> list_0;

	// Token: 0x0400A39F RID: 41887
	private StashClass gclass2698_0;

	// Token: 0x0400A3A0 RID: 41888
	private bool bool_0;

	// Token: 0x0400A3A1 RID: 41889
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x02001DA1 RID: 7585
	[CompilerGenerated]
	private sealed class Class1770
	{
		// Token: 0x06009C68 RID: 40040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0400A3A2 RID: 41890
		public GClass2094 gclass2094_0;

		// Token: 0x0400A3A3 RID: 41891
		public string searchLower;

		// Token: 0x0400A3A4 RID: 41892
		public CancellationToken token;

		// Token: 0x0400A3A5 RID: 41893
		public Func<Item, bool> func_0;
	}
}
