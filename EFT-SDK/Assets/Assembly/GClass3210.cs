using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x02003067 RID: 12391
public sealed class GClass3210 : GClass3208
{
	// Token: 0x0600F350 RID: 62288 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<GStruct413<GStruct372<GClass1248>>> FinishAchievement(GClass1248 achievement, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F351 RID: 62289 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AchievementConditionValueChanged(int questId, EQuestStatus status, int conditionId, float value, bool notify = true)
	{
		throw null;
	}

	// Token: 0x0600F352 RID: 62290 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetConditionalStatus(GInterface381 achievement, EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x02003068 RID: 12392
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3117
	{
		// Token: 0x0600F353 RID: 62291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_0(GClass2782 reward)
		{
			throw null;
		}

		// Token: 0x0600F354 RID: 62292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ResourceKey> method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0400F98F RID: 63887
		public static readonly GClass3210.Class3117 class3117_0;

		// Token: 0x0400F990 RID: 63888
		public static Func<GClass2782, IEnumerable<Item>> func_0;

		// Token: 0x0400F991 RID: 63889
		public static Func<Item, IEnumerable<ResourceKey>> func_1;
	}
}
