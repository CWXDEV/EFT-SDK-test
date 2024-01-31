using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029B6 RID: 10678
	public sealed class SelectingItemView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600D478 RID: 54392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItem([CanBeNull] Item item, Action<Item> onSelected)
		{
			throw null;
		}

		// Token: 0x0600D479 RID: 54393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDetails(string details)
		{
			throw null;
		}

		// Token: 0x0600D47A RID: 54394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D47B RID: 54395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Vector2 size)
		{
			throw null;
		}

		// Token: 0x0600D47C RID: 54396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D47E RID: 54398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400D6BA RID: 54970
		private const string string_0 = "EMPTY_SLOT";

		// Token: 0x0400D6BB RID: 54971
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400D6BC RID: 54972
		[SerializeField]
		private CustomTextMeshProUGUI _details;

		// Token: 0x0400D6BD RID: 54973
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0400D6BE RID: 54974
		[SerializeField]
		private Image _background;

		// Token: 0x0400D6BF RID: 54975
		[SerializeField]
		private GameObject _foundInRaid;

		// Token: 0x0400D6C0 RID: 54976
		private GClass818 gclass818_0;

		// Token: 0x0400D6C1 RID: 54977
		private Action<Item> action_0;

		// Token: 0x0400D6C2 RID: 54978
		private Item item_0;
	}
}
