using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001BDF RID: 7135
	public sealed class HideoutProductionRequirementView : UIElement
	{
		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x060095DE RID: 38366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060095DF RID: 38367 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFulfilled
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060095E0 RID: 38368 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, ItemRequirement requirement, GClass1919 scheme, IEnumerable<Item> allItems, bool isProducing)
		{
			throw null;
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool isTool)
		{
			throw null;
		}

		// Token: 0x04009C95 RID: 40085
		[SerializeField]
		private HideoutItemViewFactory _itemViewFactory;

		// Token: 0x04009C96 RID: 40086
		[SerializeField]
		private Image _toolMarker;

		// Token: 0x04009C97 RID: 40087
		[SerializeField]
		private Color _fullFilledColor;

		// Token: 0x04009C98 RID: 40088
		[SerializeField]
		private Color _notFilledColor;

		// Token: 0x04009C99 RID: 40089
		[CompilerGenerated]
		private bool bool_0;
	}
}
