using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020023E0 RID: 9184
public class SearchableItemClass : LootItemClass
{
	// Token: 0x17002075 RID: 8309
	// (get) Token: 0x0600B916 RID: 47382 RVA: 0x00002050 File Offset: 0x00000250
	public string SearchSound
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B917 RID: 47383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BindableState<SearchedState> GetSearchState(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B918 RID: 47384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStatus(SearchedState status, string profileId)
	{
		throw null;
	}

	// Token: 0x0600B919 RID: 47385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UncoverAll(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B91A RID: 47386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasUnknownItems(string profileId)
	{
		throw null;
	}

	// Token: 0x17002076 RID: 8310
	// (get) Token: 0x0600B91B RID: 47387 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> ItemInteractionButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B91C RID: 47388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNewSearcher(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B91D RID: 47389 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2498 method_10(GClass2495 x)
	{
		throw null;
	}

	// Token: 0x0600B91E RID: 47390 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<EItemInfoButton> method_11()
	{
		throw null;
	}

	// Token: 0x0400BBDC RID: 48092
	public readonly List<string> _allSearchersIds;

	// Token: 0x0400BBDD RID: 48093
	private GClass2579 gclass2579_0;

	// Token: 0x0400BBDE RID: 48094
	public readonly Dictionary<string, BindableState<SearchedState>> SearchStates;

	// Token: 0x0400BBDF RID: 48095
	public readonly GClass3357<GClass2865> SearchOperations;
}
