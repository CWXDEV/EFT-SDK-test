using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.Quests;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020029AB RID: 10667
	public sealed class HandoverQuestItemsWindow : HandoverSelectItemsWindow
	{
		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600D432 RID: 54322 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Condition condition, double currentValue, Item[] items, Profile profile, InventoryControllerClass controller, Action<Item[]> acceptAction, Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsSelected(Item item)
		{
			throw null;
		}

		// Token: 0x0600D435 RID: 54325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsActive(Item item, out string tooltip)
		{
			throw null;
		}

		// Token: 0x0600D436 RID: 54326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Accept()
		{
			throw null;
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TrySelectItemToHandover(Item item)
		{
			throw null;
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ClearSelectedList()
		{
			throw null;
		}

		// Token: 0x0400D687 RID: 54919
		[SerializeField]
		private TextMeshProUGUI _count;

		// Token: 0x0400D688 RID: 54920
		private float float_1;

		// Token: 0x0400D689 RID: 54921
		private Action<Item[]> action_3;

		// Token: 0x0400D68A RID: 54922
		private Condition condition_0;

		// Token: 0x020029AC RID: 10668
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2451
		{
			// Token: 0x0600D439 RID: 54329 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(Item x)
			{
				throw null;
			}

			// Token: 0x0400D68B RID: 54923
			public static readonly HandoverQuestItemsWindow.Class2451 class2451_0;

			// Token: 0x0400D68C RID: 54924
			public static Func<Item, int> func_0;
		}
	}
}
