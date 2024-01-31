using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002560 RID: 9568
public sealed class GClass2814 : GClass2809, GInterface333
{
	// Token: 0x17002222 RID: 8738
	// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x00002050 File Offset: 0x00000250
	public override ItemRotation? RotationLock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002223 RID: 8739
	// (get) Token: 0x0600BF66 RID: 48998 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ModificationAvailable
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002224 RID: 8740
	// (get) Token: 0x0600BF67 RID: 48999 RVA: 0x00002050 File Offset: 0x00000250
	GClass1742 GInterface333.FavoriteItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BF68 RID: 49000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GInterface333.ShouldSetFavoriteIcon(Item item, out bool isFavorite)
	{
		throw null;
	}

	// Token: 0x17002225 RID: 8741
	// (get) Token: 0x0600BF69 RID: 49001 RVA: 0x00002050 File Offset: 0x00000250
	public override bool DragAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BF6A RID: 49002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass3021<EItemInfoButton> GetItemContextInteractions(Action closeAction)
	{
		throw null;
	}

	// Token: 0x0600BF6B RID: 49003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanQuickMoveTo(ETargetContainer targetContainer)
	{
		throw null;
	}

	// Token: 0x0600BF6C RID: 49004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass2809 CreateChild(Item item)
	{
		throw null;
	}

	// Token: 0x0400C166 RID: 49510
	private readonly GClass2814.EItemType eitemType_0;

	// Token: 0x0400C167 RID: 49511
	private readonly GClass1742 gclass1742_0;

	// Token: 0x0400C168 RID: 49512
	[CompilerGenerated]
	private readonly bool bool_0;

	// Token: 0x02002561 RID: 9569
	public enum EItemType
	{
		// Token: 0x0400C16A RID: 49514
		Inventory,
		// Token: 0x0400C16B RID: 49515
		AreaStash,
		// Token: 0x0400C16C RID: 49516
		HandoverWindow
	}
}
