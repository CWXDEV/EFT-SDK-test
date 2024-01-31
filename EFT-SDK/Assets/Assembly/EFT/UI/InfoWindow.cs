using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029F7 RID: 10743
	[UsedImplicitly]
	public sealed class InfoWindow : Window<GClass3085>, IEventSystemHandler, IPointerClickHandler, GInterface104, GInterface105, GInterface106, GInterface112
	{
		// Token: 0x0600D574 RID: 54644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2809 itemContext, GInterface313 itemController, TraderClass trader, Action onSelectedAction, ItemUiContext itemUiContext, Action onClosedAction, GClass3021<EItemInfoButton> contextInteractions)
		{
			throw null;
		}

		// Token: 0x0600D575 RID: 54645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D576 RID: 54646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Item item)
		{
			throw null;
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRefreshItem(GEventArgs22 obj)
		{
			throw null;
		}

		// Token: 0x0600D57A RID: 54650 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GEventArgs6 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D57D RID: 54653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_7()
		{
			throw null;
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0400D798 RID: 55192
		private const float float_0 = 40f;

		// Token: 0x0400D799 RID: 55193
		private const float float_1 = 12f;

		// Token: 0x0400D79A RID: 55194
		[SerializeField]
		private ItemSpecificationPanel _itemSpecificationPanel;

		// Token: 0x0400D79B RID: 55195
		[SerializeField]
		private TextMeshProUGUI _tagName;

		// Token: 0x0400D79C RID: 55196
		[SerializeField]
		private Image _tagColor;

		// Token: 0x0400D79D RID: 55197
		private Item item_0;

		// Token: 0x0400D79E RID: 55198
		private GClass2809 gclass2809_0;

		// Token: 0x0400D79F RID: 55199
		private GInterface313 ginterface313_0;

		// Token: 0x0400D7A0 RID: 55200
		private IItemOwner iitemOwner_0;

		// Token: 0x0400D7A1 RID: 55201
		private TraderClass gclass2046_0;

		// Token: 0x0400D7A2 RID: 55202
		private Action action_1;
	}
}
