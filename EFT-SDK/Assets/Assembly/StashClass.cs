using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x0200254B RID: 9547
public class StashClass : LootItemClass
{
	// Token: 0x17002213 RID: 8723
	// (get) Token: 0x0600BF32 RID: 48946 RVA: 0x00002050 File Offset: 0x00000250
	public override ItemTemplate Template
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002214 RID: 8724
	// (get) Token: 0x0600BF33 RID: 48947 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2495 Grid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BF34 RID: 48948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBonuses(BonusController bonusController)
	{
		throw null;
	}

	// Token: 0x0400C111 RID: 49425
	public const string STASH_ITEM_ID = "hideout";

	// Token: 0x0400C112 RID: 49426
	public const string STASH_TEMPLATE_ID = "566abbc34bdc2d92178b4576";

	// Token: 0x0400C113 RID: 49427
	private GClass2600 gclass2600_0;

	// Token: 0x0400C114 RID: 49428
	private readonly StashClass.Class1968 class1968_0;

	// Token: 0x0200254C RID: 9548
	private sealed class Class1968 : GClass2495
	{
		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x00002050 File Offset: 0x00000250
		public override bool CanStretchVertically
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GStruct415<int> Add(Item item, LocationInGrid location, bool simulate, bool ignoreRestrictions)
		{
			throw null;
		}

		// Token: 0x0600BF37 RID: 48951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Expand(int newHeight)
		{
			throw null;
		}

		// Token: 0x0400C115 RID: 49429
		private readonly bool bool_2;

		// Token: 0x0400C116 RID: 49430
		private bool bool_3;
	}
}
