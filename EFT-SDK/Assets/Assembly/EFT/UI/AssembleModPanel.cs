using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x020028A0 RID: 10400
	public sealed class AssembleModPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600CFC0 RID: 53184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2884 node, Item item, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, InsuranceCompanyClass insuranceCompany)
		{
			throw null;
		}

		// Token: 0x0600CFC1 RID: 53185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GEventArgs6 args)
		{
			throw null;
		}

		// Token: 0x0600CFC2 RID: 53186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600CFC4 RID: 53188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600CFC5 RID: 53189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600CFC6 RID: 53190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D087 RID: 53383
		private const int int_0 = 50;

		// Token: 0x0400D088 RID: 53384
		private const int int_1 = 10;

		// Token: 0x0400D089 RID: 53385
		[SerializeField]
		private AssembleBuildItemView _itemView;

		// Token: 0x0400D08A RID: 53386
		[SerializeField]
		private TextMeshProUGUI _itemName;

		// Token: 0x0400D08B RID: 53387
		[SerializeField]
		private TextMeshProUGUI _itemCategory;

		// Token: 0x0400D08C RID: 53388
		private GClass2884 gclass2884_0;

		// Token: 0x0400D08D RID: 53389
		private Item item_0;

		// Token: 0x0400D08E RID: 53390
		private InventoryControllerClass gclass2757_0;

		// Token: 0x020028A1 RID: 10401
		[CompilerGenerated]
		private sealed class Class2359
		{
			// Token: 0x0600CFC7 RID: 53191 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D08F RID: 53391
			public InventoryControllerClass inventoryController;

			// Token: 0x0400D090 RID: 53392
			public AssembleModPanel assembleModPanel_0;
		}

		// Token: 0x020028A2 RID: 10402
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2360
		{
			// Token: 0x0600CFC8 RID: 53192 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string x)
			{
				throw null;
			}

			// Token: 0x0600CFC9 RID: 53193 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1(RepairableComponent x)
			{
				throw null;
			}

			// Token: 0x0600CFCA RID: 53194 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_2(RepairableComponent x)
			{
				throw null;
			}

			// Token: 0x0400D091 RID: 53393
			public static readonly AssembleModPanel.Class2360 class2360_0;

			// Token: 0x0400D092 RID: 53394
			public static Func<string, string> func_0;

			// Token: 0x0400D093 RID: 53395
			public static Func<RepairableComponent, float> func_1;

			// Token: 0x0400D094 RID: 53396
			public static Func<RepairableComponent, float> func_2;
		}
	}
}
