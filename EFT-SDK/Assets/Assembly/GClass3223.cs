using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.Quests;

// Token: 0x0200306C RID: 12396
public abstract class GClass3223<T> : QuestControllerClass<T> where T : GInterface381
{
	// Token: 0x1400036E RID: 878
	// (add) Token: 0x0600F357 RID: 62295 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F358 RID: 62296 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<T> OnConditionQuestTimeExpired
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0600F359 RID: 62297
	public abstract void SetConditionCurrentValue(GInterface381 conditional, EQuestStatus status, Condition condition, float value, bool notify = true);

	// Token: 0x0600F35A RID: 62298 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ConnectConditionQuestTime(T conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0400F99A RID: 63898
	[CompilerGenerated]
	private Action<T> action_0;

	// Token: 0x0400F99B RID: 63899
	protected readonly GInterface144 ginterface144_0;

	// Token: 0x0200306D RID: 12397
	[CompilerGenerated]
	private sealed class Class3118
	{
		// Token: 0x0600F35B RID: 62299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F35C RID: 62300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0600F35D RID: 62301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(IResult arg)
		{
			throw null;
		}

		// Token: 0x0400F99C RID: 63900
		public GClass1246 quest;

		// Token: 0x0400F99D RID: 63901
		public GClass3223<T> gclass3223_0;

		// Token: 0x0400F99E RID: 63902
		public Callback callback_0;
	}

	// Token: 0x0200306E RID: 12398
	[CompilerGenerated]
	private sealed class Class3119
	{
		// Token: 0x0600F35E RID: 62302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0400F99F RID: 63903
		public IEnumerator timer;
	}
}
