using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.WeaponModding
{
	// Token: 0x02002D1A RID: 11546
	public sealed class ModdingItem : MonoBehaviour
	{
		// Token: 0x1400032B RID: 811
		// (add) Token: 0x0600E306 RID: 58118 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E307 RID: 58119 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Item> ItemSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E309 RID: 58121 RVA: 0x00002050 File Offset: 0x00000250
		public Item Item
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600E30A RID: 58122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItem(Item item, bool unexamined, [CanBeNull] InventoryError inventoryError, ItemUiContext itemUiContext, TraderControllerClass itemController, bool isInEquipment = true)
		{
			throw null;
		}

		// Token: 0x0600E30B RID: 58123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyItem()
		{
			throw null;
		}

		// Token: 0x0600E30C RID: 58124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool value)
		{
			throw null;
		}

		// Token: 0x0600E30D RID: 58125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E30E RID: 58126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Item slotItem)
		{
			throw null;
		}

		// Token: 0x0600E30F RID: 58127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E310 RID: 58128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0400E7C9 RID: 59337
		[SerializeField]
		private TextMeshProUGUI _name;

		// Token: 0x0400E7CA RID: 59338
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x0400E7CB RID: 59339
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0400E7CC RID: 59340
		[SerializeField]
		private Image _background;

		// Token: 0x0400E7CD RID: 59341
		[SerializeField]
		private GameObject _missingInEquipment;

		// Token: 0x0400E7CE RID: 59342
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x0400E7CF RID: 59343
		[SerializeField]
		private Sprite _unexaminedSprite;

		// Token: 0x0400E7D0 RID: 59344
		[SerializeField]
		private Sprite _defaultSprite;

		// Token: 0x0400E7D1 RID: 59345
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400E7D2 RID: 59346
		[CompilerGenerated]
		private Action<Item> action_0;

		// Token: 0x0400E7D3 RID: 59347
		[CompilerGenerated]
		private Item item_0;

		// Token: 0x0400E7D4 RID: 59348
		private GClass818 gclass818_0;

		// Token: 0x0400E7D5 RID: 59349
		private ItemView itemView_0;

		// Token: 0x0400E7D6 RID: 59350
		private Color color_0;

		// Token: 0x0400E7D7 RID: 59351
		private InventoryError inventoryError_0;

		// Token: 0x0400E7D8 RID: 59352
		private TraderControllerClass gclass2754_0;

		// Token: 0x0400E7D9 RID: 59353
		private ItemUiContext itemUiContext_0;
	}
}
