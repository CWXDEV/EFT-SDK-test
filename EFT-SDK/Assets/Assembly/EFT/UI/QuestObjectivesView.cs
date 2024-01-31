using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B9B RID: 11163
	public sealed class QuestObjectivesView : ConditionalObjectivesView<QuestObjectiveView>
	{
		// Token: 0x0600DC4A RID: 56394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show<TConditional>(GClass3202<TConditional> controller, GInterface313 itemController, GClass3365 conditions, GInterface381 conditional)
		{
			throw null;
		}

		// Token: 0x0600DC4B RID: 56395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateViewList(GClass3365 conditions)
		{
			throw null;
		}

		// Token: 0x0600DC4C RID: 56396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400E06A RID: 57450
		[SerializeField]
		private QuestObjectiveView _objectivePrefab;

		// Token: 0x0400E06B RID: 57451
		[SerializeField]
		private GameObject _failtyBlock;

		// Token: 0x0400E06C RID: 57452
		[SerializeField]
		private TextMeshProUGUI _timer;

		// Token: 0x0400E06D RID: 57453
		[SerializeField]
		private Image _penaltyIcon;

		// Token: 0x0400E06E RID: 57454
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400E06F RID: 57455
		private GClass1246 gclass1246_0;

		// Token: 0x0400E070 RID: 57456
		private IEnumerator ienumerator_0;

		// Token: 0x02002B9C RID: 11164
		[CompilerGenerated]
		private sealed class Class2646
		{
			// Token: 0x0600DC4D RID: 56397 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Condition x)
			{
				throw null;
			}

			// Token: 0x0600DC4E RID: 56398 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Condition condition, QuestObjectiveView view)
			{
				throw null;
			}

			// Token: 0x0400E071 RID: 57457
			public GClass3365 conditions;

			// Token: 0x0400E072 RID: 57458
			public QuestObjectivesView questObjectivesView_0;
		}
	}
}
