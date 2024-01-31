using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B31 RID: 11057
	public sealed class DropdownItemSelector : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DB1F RID: 56095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(IEnumerable<Item> items, GInterface313 itemController, GClass2816 itemContext)
		{
			throw null;
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ItemView method_0(GClass2816 sourceContext, Item item, TraderControllerClass itemController, Transform container)
		{
			throw null;
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool isOn)
		{
			throw null;
		}

		// Token: 0x0600DB24 RID: 56100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB27 RID: 56103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB28 RID: 56104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600DB29 RID: 56105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400DEA5 RID: 56997
		[SerializeField]
		private GameObject _container;

		// Token: 0x0400DEA6 RID: 56998
		[SerializeField]
		private GameObject _containerForFirstMap;

		// Token: 0x0400DEA7 RID: 56999
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x0400DEA8 RID: 57000
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400DEA9 RID: 57001
		[SerializeField]
		private Scrollbar _scrollbar;

		// Token: 0x0400DEAA RID: 57002
		private readonly List<ItemView> list_0;

		// Token: 0x0400DEAB RID: 57003
		private ItemView itemView_0;

		// Token: 0x02002B32 RID: 11058
		[CompilerGenerated]
		private sealed class Class2602
		{
			// Token: 0x0600DB2A RID: 56106 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DEAC RID: 57004
			public ItemView itemView;
		}

		// Token: 0x02002B33 RID: 11059
		[CompilerGenerated]
		private sealed class Class2603
		{
			// Token: 0x0600DB2B RID: 56107 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemView view)
			{
				throw null;
			}

			// Token: 0x0400DEAD RID: 57005
			public Item item;
		}
	}
}
