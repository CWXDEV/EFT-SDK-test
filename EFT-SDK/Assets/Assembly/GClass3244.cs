using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using EFT.Quests;
using JetBrains.Annotations;

// Token: 0x0200304F RID: 12367
public sealed class GClass3244
{
	// Token: 0x0600F325 RID: 62245 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetItem()
	{
		throw null;
	}

	// Token: 0x0600F326 RID: 62246 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAddStandingToAccumulator(ref Dictionary<string, float> standingsAccumulator)
	{
		throw null;
	}

	// Token: 0x0600F327 RID: 62247 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplyStandingsFromAccumulator(Dictionary<string, float> standingsAccumulator, Profile profile)
	{
		throw null;
	}

	// Token: 0x0600F328 RID: 62248 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 TryAppendClaimResults(TraderControllerClass itemController, List<GClass2782> results, out int clonedCount)
	{
		throw null;
	}

	// Token: 0x0400F91E RID: 63774
	public ERewardType type;

	// Token: 0x0400F91F RID: 63775
	public string target;

	// Token: 0x0400F920 RID: 63776
	public string traderId;

	// Token: 0x0400F921 RID: 63777
	public int loyaltyLevel;

	// Token: 0x0400F922 RID: 63778
	public float value;

	// Token: 0x0400F923 RID: 63779
	public bool findInRaid;

	// Token: 0x0400F924 RID: 63780
	public GClass1186[] items;

	// Token: 0x0400F925 RID: 63781
	public bool unknown;

	// Token: 0x02003050 RID: 12368
	[CompilerGenerated]
	private sealed class Class3111
	{
		// Token: 0x0600F329 RID: 62249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1186 method_0(GClass1186 flatItem)
		{
			throw null;
		}

		// Token: 0x0400F926 RID: 63782
		public StashClass fakeStash;

		// Token: 0x0400F927 RID: 63783
		public Dictionary<string, string> idCache;

		// Token: 0x0400F928 RID: 63784
		public GClass2495 grid;
	}
}
