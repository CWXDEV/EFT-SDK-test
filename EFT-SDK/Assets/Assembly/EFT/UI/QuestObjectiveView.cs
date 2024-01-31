using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.Quests;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B97 RID: 11159
	public sealed class QuestObjectiveView : ObjectiveView<QuestObjectiveView>
	{
		// Token: 0x0600DC3D RID: 56381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1246 quest, Condition condition, AbstractQuestControllerClass questController, GInterface313 controller, [CanBeNull] Sprite icon, bool isNecessary, bool childCondition = false)
		{
			throw null;
		}

		// Token: 0x0600DC3F RID: 56383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateViewList()
		{
			throw null;
		}

		// Token: 0x0600DC40 RID: 56384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool OnConditionChanged(GClass3231 conditionProgressChecker)
		{
			throw null;
		}

		// Token: 0x0600DC41 RID: 56385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DC42 RID: 56386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_2(GClass1246 selectedQuest)
		{
			throw null;
		}

		// Token: 0x0600DC43 RID: 56387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DC44 RID: 56388 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DC45 RID: 56389 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Condition item, QuestObjectiveView view)
		{
			throw null;
		}

		// Token: 0x0400E058 RID: 57432
		[SerializeField]
		private DefaultUIButton _handoverButton;

		// Token: 0x0400E059 RID: 57433
		private HandoverQuestItemsWindow handoverQuestItemsWindow_0;

		// Token: 0x0400E05A RID: 57434
		private GClass1246 gclass1246_0;

		// Token: 0x0400E05B RID: 57435
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400E05C RID: 57436
		private bool bool_0;

		// Token: 0x02002B98 RID: 11160
		[CompilerGenerated]
		private sealed class Class2644
		{
			// Token: 0x0600DC46 RID: 56390 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E05D RID: 57437
			public TaskCompletionSource<Item[]> taskSource;
		}

		// Token: 0x02002B99 RID: 11161
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2645
		{
			// Token: 0x0600DC47 RID: 56391 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0400E05E RID: 57438
			public static readonly QuestObjectiveView.Class2645 class2645_0;

			// Token: 0x0400E05F RID: 57439
			public static Func<Item, bool> func_0;
		}
	}
}
