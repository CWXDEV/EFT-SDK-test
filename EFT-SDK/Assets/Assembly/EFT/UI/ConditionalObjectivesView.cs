using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Quests;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B8D RID: 11149
	public abstract class ConditionalObjectivesView<TObjectiveView> : UIElement, GInterface369 where TObjectiveView : ObjectiveView<TObjectiveView>
	{
		// Token: 0x0600DC13 RID: 56339
		protected abstract void CreateViewList(GClass3365 conditions);

		// Token: 0x0600DC14 RID: 56340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show<TConditional>(GClass3202<TConditional> controller, GInterface313 itemController, GClass3365 conditions, GInterface381 conditional) where TConditional : GInterface381
		{
			throw null;
		}

		// Token: 0x0600DC15 RID: 56341 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DC16 RID: 56342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass3231 obj)
		{
			throw null;
		}

		// Token: 0x0600DC17 RID: 56343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass3365 conditions)
		{
			throw null;
		}

		// Token: 0x0600DC18 RID: 56344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static GClass3364<Condition> GetChildConditions(GClass3365 questConditions)
		{
			throw null;
		}

		// Token: 0x0600DC19 RID: 56345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseView()
		{
			throw null;
		}

		// Token: 0x0600DC1A RID: 56346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E018 RID: 57368
		[SerializeField]
		protected RectTransform _container;

		// Token: 0x0400E019 RID: 57369
		private GInterface381 ginterface381_0;

		// Token: 0x0400E01A RID: 57370
		private GClass3365 gclass3365_0;

		// Token: 0x0400E01B RID: 57371
		private readonly List<Action> list_0;

		// Token: 0x0400E01C RID: 57372
		protected GInterface313 ItemController;

		// Token: 0x0400E01D RID: 57373
		protected GClass3078<Condition, TObjectiveView> ViewList;

		// Token: 0x02002B8E RID: 11150
		[CompilerGenerated]
		private sealed class Class2641
		{
			// Token: 0x0600DC1B RID: 56347 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E01E RID: 57374
			public GClass3231 condition;
		}

		// Token: 0x02002B8F RID: 11151
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2642
		{
			// Token: 0x0600DC1C RID: 56348 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass3364<Condition> method_0(Condition x)
			{
				throw null;
			}

			// Token: 0x0400E020 RID: 57376
			public static readonly ConditionalObjectivesView<TObjectiveView>.Class2642 class2642_0;

			// Token: 0x0400E021 RID: 57377
			public static Func<Condition, GClass3364<Condition>> func_0;
		}
	}
}
