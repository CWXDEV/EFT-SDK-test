using System;
using System.Runtime.CompilerServices;
using EFT.Quests;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B93 RID: 11155
	public abstract class ObjectiveView<TObjectiveView> : UIElement where TObjectiveView : ObjectiveView<TObjectiveView>
	{
		// Token: 0x0600DC27 RID: 56359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowObjective(GInterface381 conditional, Condition condition, Profile profile, GInterface313 controller, [CanBeNull] Sprite icon, bool isNecessary, bool childCondition = false)
		{
			throw null;
		}

		// Token: 0x0600DC29 RID: 56361
		protected abstract void CreateViewList();

		// Token: 0x0600DC2A RID: 56362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass3231 conditionProgressChecker)
		{
			throw null;
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool OnConditionChanged(GClass3231 conditionProgressChecker)
		{
			throw null;
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E02D RID: 57389
		[SerializeField]
		private Image _icon;

		// Token: 0x0400E02E RID: 57390
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400E02F RID: 57391
		[SerializeField]
		private Image _progress;

		// Token: 0x0400E030 RID: 57392
		[SerializeField]
		private GameObject _progressBlock;

		// Token: 0x0400E031 RID: 57393
		[SerializeField]
		private Image _doneIcon;

		// Token: 0x0400E032 RID: 57394
		[SerializeField]
		private TextMeshProUGUI _counter;

		// Token: 0x0400E033 RID: 57395
		[SerializeField]
		private Image _back;

		// Token: 0x0400E034 RID: 57396
		[SerializeField]
		private ColorMap _backColors;

		// Token: 0x0400E035 RID: 57397
		[SerializeField]
		protected TObjectiveView _childObjectivePrefab;

		// Token: 0x0400E036 RID: 57398
		[SerializeField]
		protected RectTransform _container;

		// Token: 0x0400E037 RID: 57399
		protected GClass3079<Condition, TObjectiveView> ViewList;

		// Token: 0x0400E038 RID: 57400
		private GInterface381 ginterface381_0;

		// Token: 0x0400E039 RID: 57401
		protected Condition Condition;

		// Token: 0x0400E03A RID: 57402
		protected GClass3231 ConditionProgressChecker;

		// Token: 0x0400E03B RID: 57403
		protected Profile Profile;

		// Token: 0x0400E03C RID: 57404
		protected GInterface313 Controller;
	}
}
