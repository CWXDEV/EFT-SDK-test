using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Builds
{
	// Token: 0x02002EF4 RID: 12020
	[UsedImplicitly]
	public sealed class AmmoPresetView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, ItemSelectionCell.GInterface361
	{
		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0600ED3C RID: 60732 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<GClass2089.GClass2090> OnItemSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600ED3D RID: 60733 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<GClass2089.GClass2090> OnCountChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600ED3E RID: 60734 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface386 OnMoveUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600ED3F RID: 60735 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface386 OnMoveDown
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ED40 RID: 60736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2089 preset, int ammoIndex, GClass2088 storage, IEnumerable<Item> availableAmmo)
		{
			throw null;
		}

		// Token: 0x0600ED41 RID: 60737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass2089.GClass2090 item)
		{
			throw null;
		}

		// Token: 0x0600ED42 RID: 60738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600ED43 RID: 60739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600ED44 RID: 60740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600ED45 RID: 60741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool hover)
		{
			throw null;
		}

		// Token: 0x0600ED46 RID: 60742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ED47 RID: 60743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ED48 RID: 60744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ED49 RID: 60745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ED4A RID: 60746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600ED4C RID: 60748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ItemSelectionCell.GInterface361.CanSelect(Item item)
		{
			throw null;
		}

		// Token: 0x0600ED4D RID: 60749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ItemSelectionCell.GInterface361.ItemSelectionHandler(Item selectedItem)
		{
			throw null;
		}

		// Token: 0x0600ED4E RID: 60750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerable<Item> ItemSelectionCell.GInterface361.GetAvailableItems()
		{
			throw null;
		}

		// Token: 0x0600ED4F RID: 60751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(string newCountText)
		{
			throw null;
		}

		// Token: 0x0600ED50 RID: 60752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600ED51 RID: 60753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600ED52 RID: 60754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(int newCount)
		{
			throw null;
		}

		// Token: 0x0600ED53 RID: 60755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600ED54 RID: 60756 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400F237 RID: 62007
		private readonly GClass3355<GClass2089.GClass2090> gclass3355_0;

		// Token: 0x0400F238 RID: 62008
		private readonly GClass3355<GClass2089.GClass2090> gclass3355_1;

		// Token: 0x0400F239 RID: 62009
		private readonly BindableEvent bindableEvent_0;

		// Token: 0x0400F23A RID: 62010
		private readonly BindableEvent bindableEvent_1;

		// Token: 0x0400F23B RID: 62011
		[SerializeField]
		private Sprite _topIcon;

		// Token: 0x0400F23C RID: 62012
		[SerializeField]
		private Sprite _loopIcon;

		// Token: 0x0400F23D RID: 62013
		[SerializeField]
		private Sprite _bottomIcon;

		// Token: 0x0400F23E RID: 62014
		[SerializeField]
		private Image _compositionImage;

		// Token: 0x0400F23F RID: 62015
		[SerializeField]
		private GameObject _hoverObject;

		// Token: 0x0400F240 RID: 62016
		[SerializeField]
		private GameObject _ammoSelectedBack;

		// Token: 0x0400F241 RID: 62017
		[SerializeField]
		private TMP_InputField _countInputField;

		// Token: 0x0400F242 RID: 62018
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x0400F243 RID: 62019
		[SerializeField]
		private CanvasGroup _decrementLocker;

		// Token: 0x0400F244 RID: 62020
		[SerializeField]
		private Button _incrementButton;

		// Token: 0x0400F245 RID: 62021
		[SerializeField]
		private CanvasGroup _incrementLocker;

		// Token: 0x0400F246 RID: 62022
		[SerializeField]
		private ItemSelectionCell _ammoSelector;

		// Token: 0x0400F247 RID: 62023
		[SerializeField]
		private TMP_Text _ammoName;

		// Token: 0x0400F248 RID: 62024
		[SerializeField]
		private CanvasGroup _countContainer;

		// Token: 0x0400F249 RID: 62025
		[SerializeField]
		private Button _moveUpButton;

		// Token: 0x0400F24A RID: 62026
		[SerializeField]
		private CanvasGroup _moveUpLocker;

		// Token: 0x0400F24B RID: 62027
		[SerializeField]
		private Button _moveDownButton;

		// Token: 0x0400F24C RID: 62028
		[SerializeField]
		private CanvasGroup _moveDownLocker;

		// Token: 0x0400F24D RID: 62029
		[CanBeNull]
		private GClass2089.GClass2090 gclass2090_0;

		// Token: 0x0400F24E RID: 62030
		[CanBeNull]
		private Item item_0;

		// Token: 0x0400F24F RID: 62031
		private IEnumerable<Item> ienumerable_0;

		// Token: 0x0400F250 RID: 62032
		private bool bool_0;

		// Token: 0x0400F251 RID: 62033
		private GClass763 gclass763_0;
	}
}
