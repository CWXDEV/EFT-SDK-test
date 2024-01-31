using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x0200307E RID: 12414
public sealed class GClass3206 : GClass3204
{
	// Token: 0x0600F386 RID: 62342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<IResult> AcceptQuest(GClass1246 quest, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F387 RID: 62343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<GStruct413<GStruct373>> FinishQuest(GClass1246 quest, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F388 RID: 62344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<IResult> HandoverItem(GClass1246 quest, ConditionItem condition, Item[] items, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F389 RID: 62345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void QuestConditionValueChanged(int questId, EQuestStatus status, int conditionId, float value, bool notify = true)
	{
		throw null;
	}

	// Token: 0x0600F38A RID: 62346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetConditionalStatus(GInterface381 quest, EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x02003080 RID: 12416
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3126
	{
		// Token: 0x0600F38D RID: 62349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_0(GClass2782 reward)
		{
			throw null;
		}

		// Token: 0x0600F38E RID: 62350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ResourceKey> method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0600F38F RID: 62351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(Item item)
		{
			throw null;
		}

		// Token: 0x0400F9D2 RID: 63954
		public static readonly GClass3206.Class3126 class3126_0;

		// Token: 0x0400F9D3 RID: 63955
		public static Func<GClass2782, IEnumerable<Item>> func_0;

		// Token: 0x0400F9D4 RID: 63956
		public static Func<Item, IEnumerable<ResourceKey>> func_1;

		// Token: 0x0400F9D5 RID: 63957
		public static Func<Item, int> func_2;
	}
}
