using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Quests;

// Token: 0x02003070 RID: 12400
public abstract class GClass3224<T> : GClass3223<T> where T : GInterface381
{
	// Token: 0x0600F361 RID: 62305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_17(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F362 RID: 62306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetConditionCurrentValue(GInterface381 conditional, EQuestStatus status, Condition condition, float value, bool notify = true)
	{
		throw null;
	}

	// Token: 0x0600F363 RID: 62307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override int GetFindItemConditionCount(GInterface381 quest, ConditionFindItem condition)
	{
		throw null;
	}

	// Token: 0x02003071 RID: 12401
	[CompilerGenerated]
	private sealed class Class3121
	{
		// Token: 0x0600F364 RID: 62308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaInfo area)
		{
			throw null;
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F366 RID: 62310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(AreaInfo area)
		{
			throw null;
		}

		// Token: 0x0600F367 RID: 62311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F368 RID: 62312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4()
		{
			throw null;
		}

		// Token: 0x0400F9A3 RID: 63907
		public GClass3214 conditionArea;

		// Token: 0x0400F9A4 RID: 63908
		public GClass3224<T> gclass3224_0;

		// Token: 0x0400F9A5 RID: 63909
		public HideoutClass hideout;

		// Token: 0x0400F9A6 RID: 63910
		public GInterface381 conditional;

		// Token: 0x0400F9A7 RID: 63911
		public EQuestStatus status;

		// Token: 0x0400F9A8 RID: 63912
		public Condition condition;

		// Token: 0x0400F9A9 RID: 63913
		public Func<AreaInfo, bool> func_0;
	}
}
