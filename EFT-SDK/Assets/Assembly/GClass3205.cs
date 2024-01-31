using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x02003078 RID: 12408
public sealed class GClass3205 : GClass3204
{
	// Token: 0x0600F37A RID: 62330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<IResult> AcceptQuest(GClass1246 quest, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F37B RID: 62331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<GStruct413<GStruct373>> FinishQuest(GClass1246 quest, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F37C RID: 62332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<IResult> HandoverItem(GClass1246 quest, ConditionItem condition, Item[] items, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F37D RID: 62333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetConditionalStatus(GInterface381 quest, EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x0400F9B3 RID: 63923
	private ISession ginterface145_0;

	// Token: 0x0200307A RID: 12410
	[CompilerGenerated]
	private sealed class Class3124
	{
		// Token: 0x0600F380 RID: 62336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F9BA RID: 63930
		public GClass1246 testQuest;
	}

	// Token: 0x0200307C RID: 12412
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3125
	{
		// Token: 0x0600F383 RID: 62339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(GClass1223 x)
		{
			throw null;
		}

		// Token: 0x0400F9C1 RID: 63937
		public static readonly GClass3205.Class3125 class3125_0;

		// Token: 0x0400F9C2 RID: 63938
		public static Func<GClass1223, int> func_0;
	}
}
