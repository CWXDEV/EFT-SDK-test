using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;

// Token: 0x02002EDA RID: 11994
public sealed class ItemClass : IUpdatable<ItemClass>
{
	// Token: 0x170028AC RID: 10412
	// (get) Token: 0x0600ECCB RID: 60619 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600ECCC RID: 60620 RVA: 0x00002050 File Offset: 0x00000250
	public ItemClass Parent
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

	// Token: 0x0600ECCD RID: 60621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParent(ItemClass parent)
	{
		throw null;
	}

	// Token: 0x0600ECCE RID: 60622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ItemClass FindOrCreate(Item item)
	{
		throw null;
	}

	// Token: 0x0600ECCF RID: 60623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compare(ItemClass other)
	{
		throw null;
	}

	// Token: 0x0600ECD0 RID: 60624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromAnotherItem(ItemClass other)
	{
		throw null;
	}

	// Token: 0x0400F1C8 RID: 61896
	public readonly string Id;

	// Token: 0x0400F1C9 RID: 61897
	public string TemplateId;

	// Token: 0x0400F1CA RID: 61898
	public string Name;

	// Token: 0x0400F1CB RID: 61899
	public string ShortName;

	// Token: 0x0400F1CC RID: 61900
	public Item Item;

	// Token: 0x0400F1CD RID: 61901
	public readonly GClass3364<ItemClass> ChildrenToInsure;

	// Token: 0x0400F1CE RID: 61902
	[CompilerGenerated]
	private ItemClass gclass3180_0;

	// Token: 0x0400F1CF RID: 61903
	public string InsurerId;

	// Token: 0x0400F1D0 RID: 61904
	public Type Type;
}
