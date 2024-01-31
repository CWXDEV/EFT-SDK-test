using System;
using System.Runtime.CompilerServices;
using EFT.Quests;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B8B RID: 11147
	public sealed class AchievementsObjectivesView : ConditionalObjectivesView<AchievementObjectiveView>
	{
		// Token: 0x0600DC0F RID: 56335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show<TConditional>(GClass3202<TConditional> controller, GInterface313 itemController, GClass3365 conditions, GInterface381 conditional)
		{
			throw null;
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateViewList(GClass3365 conditions)
		{
			throw null;
		}

		// Token: 0x0400E013 RID: 57363
		[SerializeField]
		private AchievementObjectiveView _objectivePrefab;

		// Token: 0x0400E014 RID: 57364
		private AbstractAchievementControllerClass gclass3207_0;

		// Token: 0x0400E015 RID: 57365
		private GClass1248 gclass1248_0;

		// Token: 0x02002B8C RID: 11148
		[CompilerGenerated]
		private sealed class Class2640
		{
			// Token: 0x0600DC11 RID: 56337 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Condition x)
			{
				throw null;
			}

			// Token: 0x0600DC12 RID: 56338 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Condition condition, AchievementObjectiveView view)
			{
				throw null;
			}

			// Token: 0x0400E016 RID: 57366
			public GClass3365 conditions;

			// Token: 0x0400E017 RID: 57367
			public AchievementsObjectivesView achievementsObjectivesView_0;
		}
	}
}
