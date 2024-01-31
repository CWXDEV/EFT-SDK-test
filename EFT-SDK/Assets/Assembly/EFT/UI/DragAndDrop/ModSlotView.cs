using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E06 RID: 11782
	public sealed class ModSlotView : SlotView, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600E7D8 RID: 59352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLocked(KeyValuePair<EModLockedState, ModSlotView.GStruct398> lockedState, Slot slot, Item item)
		{
			throw null;
		}

		// Token: 0x0600E7D9 RID: 59353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveCamora(Item item, EModLockedState lockedState)
		{
			throw null;
		}

		// Token: 0x0600E7DA RID: 59354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(bool value)
		{
			throw null;
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(bool locked, Slot slot)
		{
			throw null;
		}

		// Token: 0x0600E7DC RID: 59356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ItemView CreateItemViewKernel(Item item, IItemOwner itemOwner)
		{
			throw null;
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Slot slot, GClass2809 parentItemContext, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetupItemView(Item item)
		{
			throw null;
		}

		// Token: 0x0600E7DF RID: 59359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_16(out GClass2507 outArmorSlot, out GClass2629 outArmorPlate)
		{
			throw null;
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400ECFF RID: 60671
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400ED00 RID: 60672
		[SerializeField]
		private TextMeshProUGUI _slotName;

		// Token: 0x0400ED01 RID: 60673
		[SerializeField]
		private RectTransform _filtersGroup;

		// Token: 0x0400ED02 RID: 60674
		[SerializeField]
		private Sprite _uncheckedChamberSprite;

		// Token: 0x0400ED03 RID: 60675
		private ModSlotView.GStruct398 gstruct398_0;

		// Token: 0x0400ED04 RID: 60676
		private bool bool_1;

		// Token: 0x02002E07 RID: 11783
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct398
		{
			// Token: 0x0600E7E3 RID: 59363 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0400ED05 RID: 60677
			public string Error;

			// Token: 0x0400ED06 RID: 60678
			public string ItemName;
		}

		// Token: 0x02002E08 RID: 11784
		[CompilerGenerated]
		private sealed class Class2873
		{
			// Token: 0x0600E7E4 RID: 59364 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Type method_0(string node)
			{
				throw null;
			}

			// Token: 0x0600E7E5 RID: 59365 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Type method_1(string node)
			{
				throw null;
			}

			// Token: 0x0600E7E6 RID: 59366 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Type t)
			{
				throw null;
			}

			// Token: 0x0400ED07 RID: 60679
			public GClass1203 itemTemplates;

			// Token: 0x0400ED08 RID: 60680
			public IEnumerable<Type> excludeTypes;
		}

		// Token: 0x02002E09 RID: 11785
		[CompilerGenerated]
		private sealed class Class2874
		{
			// Token: 0x0600E7E7 RID: 59367 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Type excludedType)
			{
				throw null;
			}

			// Token: 0x0400ED09 RID: 60681
			public Type t;
		}

		// Token: 0x02002E0A RID: 11786
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2875
		{
			// Token: 0x0600E7E8 RID: 59368 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<string> method_0(ItemFilter x)
			{
				throw null;
			}

			// Token: 0x0600E7E9 RID: 59369 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemFilter x)
			{
				throw null;
			}

			// Token: 0x0600E7EA RID: 59370 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<string> method_2(ItemFilter x)
			{
				throw null;
			}

			// Token: 0x0600E7EB RID: 59371 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(Sprite sprite)
			{
				throw null;
			}

			// Token: 0x0400ED0A RID: 60682
			public static readonly ModSlotView.Class2875 class2875_0;

			// Token: 0x0400ED0B RID: 60683
			public static Func<ItemFilter, IEnumerable<string>> func_0;

			// Token: 0x0400ED0C RID: 60684
			public static Func<ItemFilter, bool> func_1;

			// Token: 0x0400ED0D RID: 60685
			public static Func<ItemFilter, IEnumerable<string>> func_2;

			// Token: 0x0400ED0E RID: 60686
			public static Func<Sprite, bool> func_3;
		}
	}
}
