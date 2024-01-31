using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002A1E RID: 10782
	public sealed class InteractionButtonsContainer : UIElement, IEventSystemHandler, IPointerExitHandler, IBallisticsCalculator
	{
		// Token: 0x0600D64D RID: 54861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600D64E RID: 54862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show<T>(GClass3021<T> contextInteractions, IReadOnlyDictionary<T, string> names = null, List<T> prohibitedInteractions = null, Item item = null, IReadOnlyDictionary<T, Sprite> icons = null, bool autoClose = true) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600D650 RID: 54864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private SimpleContextMenuButton method_0<T>(T key, string caption, [CanBeNull] Sprite sprite, [CanBeNull] Action onButtonClicked, [CanBeNull] Action onMouseHover = null, bool subMenu = false, bool autoClose = true) where T : Enum
		{
			throw null;
		}

		// Token: 0x0600D651 RID: 54865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private SimpleContextMenuButton method_1(string key, string caption, SimpleContextMenuButton template, RectTransform container, [CanBeNull] Sprite sprite, [CanBeNull] Action onButtonClicked, [CanBeNull] Action onMouseHover, bool subMenu = false, bool autoClose = true)
		{
			throw null;
		}

		// Token: 0x0600D652 RID: 54866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2<T>(T interaction, GClass3021<T> contextInteractions, string caption, [CanBeNull] Sprite sprite, bool autoClose) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass3020 interaction)
		{
			throw null;
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSubInteractions<T>(GClass3021<T> contextInteractions) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D657 RID: 54871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(SimpleContextMenuButton button)
		{
			throw null;
		}

		// Token: 0x0400D8AA RID: 55466
		private const string string_0 = "Characteristics/Icons/";

		// Token: 0x0400D8AB RID: 55467
		[SerializeField]
		public SimpleContextMenu SubMenuTemplate;

		// Token: 0x0400D8AC RID: 55468
		[SerializeField]
		public Transform SubMenuContainer;

		// Token: 0x0400D8AD RID: 55469
		[SerializeField]
		private SimpleContextMenuButton _buttonTemplate;

		// Token: 0x0400D8AE RID: 55470
		[SerializeField]
		private RectTransform _buttonsContainer;

		// Token: 0x0400D8AF RID: 55471
		[SerializeField]
		private GameObject _background;

		// Token: 0x0400D8B0 RID: 55472
		[SerializeField]
		private SpecifiedContextButtons _specifiedButtons;

		// Token: 0x0400D8B1 RID: 55473
		private GClass764 gclass764_0;

		// Token: 0x0400D8B2 RID: 55474
		private GClass764 gclass764_1;

		// Token: 0x0400D8B3 RID: 55475
		private bool bool_0;

		// Token: 0x0400D8B4 RID: 55476
		private SimpleContextMenu simpleContextMenu_0;

		// Token: 0x0400D8B5 RID: 55477
		private SimpleContextMenuButton simpleContextMenuButton_0;

		// Token: 0x0400D8B6 RID: 55478
		private bool bool_1;

		// Token: 0x02002A1F RID: 10783
		[CompilerGenerated]
		private sealed class Class2489<T> where T : struct, Enum
		{
			// Token: 0x0600D658 RID: 54872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D659 RID: 54873 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IEnumerable<string> templateIds)
			{
				throw null;
			}

			// Token: 0x0600D65A RID: 54874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(bool locked)
			{
				throw null;
			}

			// Token: 0x0600D65B RID: 54875 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(IEffect effect)
			{
				throw null;
			}

			// Token: 0x0600D65C RID: 54876 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0400D8B7 RID: 55479
			public InteractionButtonsContainer interactionButtonsContainer_0;

			// Token: 0x0400D8B8 RID: 55480
			public GClass3021<T> contextInteractions;

			// Token: 0x0400D8B9 RID: 55481
			public List<T> prohibitedInteractions;

			// Token: 0x0400D8BA RID: 55482
			public IReadOnlyDictionary<T, string> names;

			// Token: 0x0400D8BB RID: 55483
			public IReadOnlyDictionary<T, Sprite> icons;

			// Token: 0x0400D8BC RID: 55484
			public bool autoClose;

			// Token: 0x0400D8BD RID: 55485
			public Item item;
		}

		// Token: 0x02002A20 RID: 10784
		[CompilerGenerated]
		private sealed class Class2490
		{
			// Token: 0x0600D65D RID: 54877 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D65E RID: 54878 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400D8BE RID: 55486
			public bool autoClose;

			// Token: 0x0400D8BF RID: 55487
			public InteractionButtonsContainer interactionButtonsContainer_0;

			// Token: 0x0400D8C0 RID: 55488
			public Action onButtonClicked;

			// Token: 0x0400D8C1 RID: 55489
			public Action onMouseHover;
		}

		// Token: 0x02002A21 RID: 10785
		[CompilerGenerated]
		private sealed class Class2491<T> where T : struct, Enum
		{
			// Token: 0x0600D65F RID: 54879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D660 RID: 54880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400D8C2 RID: 55490
			public InteractionButtonsContainer interactionButtonsContainer_0;

			// Token: 0x0400D8C3 RID: 55491
			public SimpleContextMenuButton button;

			// Token: 0x0400D8C4 RID: 55492
			public GClass3021<T> contextInteractions;

			// Token: 0x0400D8C5 RID: 55493
			public T interaction;
		}

		// Token: 0x02002A22 RID: 10786
		[CompilerGenerated]
		private sealed class Class2492<T> where T : struct, Enum
		{
			// Token: 0x0600D661 RID: 54881 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D8C6 RID: 55494
			public SimpleContextMenuButton subMenuButton;

			// Token: 0x0400D8C7 RID: 55495
			public InteractionButtonsContainer interactionButtonsContainer_0;
		}

		// Token: 0x02002A23 RID: 10787
		[CompilerGenerated]
		private sealed class Class2493
		{
			// Token: 0x0600D662 RID: 54882 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D8C8 RID: 55496
			public SimpleContextMenuButton button;
		}
	}
}
