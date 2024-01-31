using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using EFT.Trading;

// Token: 0x02001D1F RID: 7455
public sealed class GClass2044
{
	// Token: 0x140001CE RID: 462
	// (add) Token: 0x06009A4F RID: 39503 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009A50 RID: 39504 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnReadyStatusChanged
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

	// Token: 0x170017F7 RID: 6135
	// (get) Token: 0x06009A51 RID: 39505 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A52 RID: 39506 RVA: 0x00002050 File Offset: 0x00000250
	public bool Ready
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

	// Token: 0x06009A53 RID: 39507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0()
	{
		throw null;
	}

	// Token: 0x06009A54 RID: 39508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> SellItems(IEnumerable<Item> items, int price)
	{
		throw null;
	}

	// Token: 0x0400A18F RID: 41359
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400A190 RID: 41360
	private readonly GInterface178 ginterface178_0;

	// Token: 0x0400A191 RID: 41361
	private TraderClass gclass2046_0;

	// Token: 0x0400A192 RID: 41362
	private TraderAssortmentControllerClass gclass2043_0;

	// Token: 0x0400A193 RID: 41363
	private bool bool_0;

	// Token: 0x02001D20 RID: 7456
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1738
	{
		// Token: 0x06009A55 RID: 39509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TradingItemReference method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0400A194 RID: 41364
		public static readonly GClass2044.Class1738 class1738_0;

		// Token: 0x0400A195 RID: 41365
		public static Func<TraderClass, bool> func_0;

		// Token: 0x0400A196 RID: 41366
		public static Func<Item, TradingItemReference> func_1;
	}

	// Token: 0x02001D22 RID: 7458
	[CompilerGenerated]
	private sealed class Class1739
	{
		// Token: 0x06009A59 RID: 39513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400A19B RID: 41371
		public TaskCompletionSource<bool> source;
	}
}
