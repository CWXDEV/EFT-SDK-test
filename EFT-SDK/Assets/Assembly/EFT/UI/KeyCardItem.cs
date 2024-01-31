using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A72 RID: 10866
	public class KeyCardItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600D7CC RID: 55244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItem([CanBeNull] Item item, Action<Item> onSelected)
		{
			throw null;
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Vector2 size)
		{
			throw null;
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D7D1 RID: 55249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DA8F RID: 55951
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DA90 RID: 55952
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0400DA91 RID: 55953
		[SerializeField]
		private Image _background;

		// Token: 0x0400DA92 RID: 55954
		private GClass818 gclass818_0;

		// Token: 0x0400DA93 RID: 55955
		private Action<Item> action_0;

		// Token: 0x0400DA94 RID: 55956
		private Item item_0;
	}
}
