using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02002EEA RID: 12010
public sealed class GClass3183
{
	// Token: 0x170028B9 RID: 10425
	// (get) Token: 0x0600ED18 RID: 60696 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600ED19 RID: 60697 RVA: 0x00002050 File Offset: 0x00000250
	public MongoID Id
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

	// Token: 0x170028BA RID: 10426
	// (get) Token: 0x0600ED1A RID: 60698 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600ED1B RID: 60699 RVA: 0x00002050 File Offset: 0x00000250
	public Item Item
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

	// Token: 0x170028BB RID: 10427
	// (get) Token: 0x0600ED1C RID: 60700 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600ED1D RID: 60701 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyCollection<string> IncludedItems
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

	// Token: 0x0600ED1E RID: 60702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400F218 RID: 61976
	[CompilerGenerated]
	private MongoID mongoID_0;

	// Token: 0x0400F219 RID: 61977
	public readonly string ItemIconName;

	// Token: 0x0400F21A RID: 61978
	public readonly string HandbookName;

	// Token: 0x0400F21B RID: 61979
	public readonly bool FromPreset;

	// Token: 0x0400F21C RID: 61980
	private Item item_0;

	// Token: 0x0400F21D RID: 61981
	[CompilerGenerated]
	private IReadOnlyCollection<string> ireadOnlyCollection_0;

	// Token: 0x02002EEB RID: 12011
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2960
	{
		// Token: 0x0600ED1F RID: 60703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0400F21E RID: 61982
		public static readonly GClass3183.Class2960 class2960_0;

		// Token: 0x0400F21F RID: 61983
		public static Func<Item, bool> func_0;

		// Token: 0x0400F220 RID: 61984
		public static Func<Item, string> func_1;
	}
}
