using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Quests;

// Token: 0x02003072 RID: 12402
public abstract class GClass3227<T> : GClass3223<T> where T : GInterface381
{
	// Token: 0x0600F369 RID: 62313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_17(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F36A RID: 62314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetConditionCurrentValue(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F36B RID: 62315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetConditionCurrentValue(GInterface381 conditional, EQuestStatus status, Condition condition, float value, bool notify = true)
	{
		throw null;
	}

	// Token: 0x0400F9AA RID: 63914
	private readonly Dictionary<GInterface381, Dictionary<EQuestStatus, Dictionary<Condition, float>>> dictionary_2;

	// Token: 0x02003073 RID: 12403
	[CompilerGenerated]
	private sealed class Class3122
	{
		// Token: 0x0600F36C RID: 62316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0400F9AB RID: 63915
		public GClass3227<T> gclass3227_0;

		// Token: 0x0400F9AC RID: 63916
		public GInterface381 conditional;

		// Token: 0x0400F9AD RID: 63917
		public EQuestStatus status;

		// Token: 0x0400F9AE RID: 63918
		public Condition condition;
	}
}
