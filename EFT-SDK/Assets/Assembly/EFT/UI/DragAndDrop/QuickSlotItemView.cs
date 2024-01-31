using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E3C RID: 11836
	[UsedImplicitly]
	public sealed class QuickSlotItemView : ItemView, GInterface104, GInterface105, GInterface106, GInterface112
	{
		// Token: 0x0600E9A3 RID: 59811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static QuickSlotItemView Create(Item item, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool IsInteractable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private QuickSlotItemView method_9(Item item, ItemRotation rotation, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateScale()
		{
			throw null;
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface112.OnRefreshItem(GEventArgs22 args)
		{
			throw null;
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface105.OnItemAdded(GEventArgs2 args)
		{
			throw null;
		}

		// Token: 0x0600E9A9 RID: 59817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface106.OnItemRemoved(GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600E9AA RID: 59818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateInfo()
		{
			throw null;
		}

		// Token: 0x0600E9AB RID: 59819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_3(Item item, out string text)
		{
			throw null;
		}

		// Token: 0x0600E9AC RID: 59820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Kill()
		{
			throw null;
		}

		// Token: 0x0600E9AD RID: 59821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_10(Item item, ItemAddress address)
		{
			throw null;
		}

		// Token: 0x0600E9AE RID: 59822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(bool refreshIcon = true)
		{
			throw null;
		}

		// Token: 0x0400EE41 RID: 60993
		[SerializeField]
		private TextMeshProUGUI _resourceValue;

		// Token: 0x0400EE42 RID: 60994
		private InventoryControllerClass gclass2757_0;
	}
}
