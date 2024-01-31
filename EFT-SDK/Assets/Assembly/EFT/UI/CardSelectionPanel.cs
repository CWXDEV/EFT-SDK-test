using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A71 RID: 10865
	public sealed class CardSelectionPanel : UIElement
	{
		// Token: 0x0600D7C2 RID: 55234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D7C3 RID: 55235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Item currentSelectedCard, Item[] availableCards, Action<Item> cardSelected)
		{
			throw null;
		}

		// Token: 0x0600D7C4 RID: 55236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Item item)
		{
			throw null;
		}

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector2 size)
		{
			throw null;
		}

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool isOpen)
		{
			throw null;
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Item item, KeyCardItem view)
		{
			throw null;
		}

		// Token: 0x0400DA83 RID: 55939
		[SerializeField]
		private Image _selectedItemIcon;

		// Token: 0x0400DA84 RID: 55940
		[SerializeField]
		private Sprite _emptyIcon;

		// Token: 0x0400DA85 RID: 55941
		[SerializeField]
		private GameObject _noCardTooltip;

		// Token: 0x0400DA86 RID: 55942
		[SerializeField]
		private Button _dropdownButton;

		// Token: 0x0400DA87 RID: 55943
		[SerializeField]
		private Sprite _closeButtonIcon;

		// Token: 0x0400DA88 RID: 55944
		[SerializeField]
		private Sprite _openButtonIcon;

		// Token: 0x0400DA89 RID: 55945
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400DA8A RID: 55946
		[SerializeField]
		private KeyCardItem _cardItemPrefab;

		// Token: 0x0400DA8B RID: 55947
		private Item item_0;

		// Token: 0x0400DA8C RID: 55948
		private Action<Item> action_0;

		// Token: 0x0400DA8D RID: 55949
		private bool bool_0;

		// Token: 0x0400DA8E RID: 55950
		private GClass818 gclass818_0;
	}
}
