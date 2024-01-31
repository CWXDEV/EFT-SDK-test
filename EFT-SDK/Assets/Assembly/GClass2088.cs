using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.LanguageExtensions;
using EFT;
using EFT.InventoryLogic;
using EFT.UI.Ragfair;

// Token: 0x02001D8E RID: 7566
public sealed class GClass2088
{
	// Token: 0x1700187A RID: 6266
	// (get) Token: 0x06009BF6 RID: 39926 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GClass2089> Presets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009BF7 RID: 39927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AmmoTemplate GetAmmoTemplate(MongoID templateId)
	{
		throw null;
	}

	// Token: 0x06009BF8 RID: 39928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BulletClass GetAmmoByTemplate(MongoID templateId)
	{
		throw null;
	}

	// Token: 0x06009BF9 RID: 39929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<BulletClass> GetAvailableAmmo(string caliber)
	{
		throw null;
	}

	// Token: 0x06009BFA RID: 39930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<string> GetAvailableCalibers()
	{
		throw null;
	}

	// Token: 0x06009BFB RID: 39931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2089 CreateNewPreset()
	{
		throw null;
	}

	// Token: 0x06009BFC RID: 39932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDefaultPresetName()
	{
		throw null;
	}

	// Token: 0x06009BFD RID: 39933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryFindPresetByName(string name, out GClass2089 preset)
	{
		throw null;
	}

	// Token: 0x06009BFE RID: 39934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryFindPresetById(MongoID id, out GClass2089 preset)
	{
		throw null;
	}

	// Token: 0x06009BFF RID: 39935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SavePreset(GClass2089 preset, bool rename)
	{
		throw null;
	}

	// Token: 0x06009C00 RID: 39936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> DeletePreset(MongoID presetId)
	{
		throw null;
	}

	// Token: 0x06009C01 RID: 39937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SearchBuildOnRagfair(BuildItemSearchValue buildSearch)
	{
		throw null;
	}

	// Token: 0x06009C02 RID: 39938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct415<Item> TryFindPresetSource(Item selectedItem)
	{
		throw null;
	}

	// Token: 0x06009C03 RID: 39939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCaliberName(string caliber)
	{
		throw null;
	}

	// Token: 0x0400A338 RID: 41784
	public const int MAX_PRESETS_COUNT = 30;

	// Token: 0x0400A339 RID: 41785
	public const int MAX_PRESETS_PER_CALIBER_COUNT = 5;

	// Token: 0x0400A33A RID: 41786
	private const string string_0 = "MAGAZINE LOADOUT";

	// Token: 0x0400A33B RID: 41787
	public Action<GClass2089> OnPresetAdded;

	// Token: 0x0400A33C RID: 41788
	public Action<GClass2089> OnPresetRemoved;

	// Token: 0x0400A33D RID: 41789
	private readonly ISession ginterface145_0;

	// Token: 0x0400A33E RID: 41790
	private readonly List<GClass2089> list_0;

	// Token: 0x0400A33F RID: 41791
	private readonly IReadOnlyDictionary<MongoID, BulletClass> ireadOnlyDictionary_0;

	// Token: 0x0400A340 RID: 41792
	private readonly IReadOnlyDictionary<string, List<BulletClass>> ireadOnlyDictionary_1;

	// Token: 0x0400A341 RID: 41793
	private readonly HashSet<string> hashSet_0;

	// Token: 0x02001D8F RID: 7567
	private sealed class Class3148 : Error
	{
		// Token: 0x06009C04 RID: 39940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400A342 RID: 41794
		private readonly Item item_0;
	}
}
