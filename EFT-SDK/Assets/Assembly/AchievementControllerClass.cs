using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Quests;

// Token: 0x02003064 RID: 12388
public sealed class AchievementControllerClass : GClass3208
{
	// Token: 0x0600F34B RID: 62283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<GStruct413<GStruct372<GClass1248>>> FinishAchievement(GClass1248 quest, bool runNetworkTransaction)
	{
		throw null;
	}

	// Token: 0x0600F34C RID: 62284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetConditionalStatus(GInterface381 achievement, EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x0400F987 RID: 63879
	private readonly ISession ginterface145_0;

	// Token: 0x02003065 RID: 12389
	[CompilerGenerated]
	private sealed class Class3116
	{
		// Token: 0x0600F34D RID: 62285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F988 RID: 63880
		public GClass1248 testAchievement;
	}
}
