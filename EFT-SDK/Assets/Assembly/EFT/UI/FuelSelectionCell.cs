using System;
using System.Runtime.CompilerServices;
using EFT.Hideout;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029AF RID: 10671
	public sealed class FuelSelectionCell : ItemSelectionCell
	{
		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600D44A RID: 54346 RVA: 0x00002050 File Offset: 0x00000250
		protected override EContextPriorDirection Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600D44B RID: 54347 RVA: 0x00002050 File Offset: 0x00000250
		private ResourceComponent ResourceComponent_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D44C RID: 54348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Item currentSelectedItem, GInterface163 consumer, Func<Item, bool> selectionChecker, Action<Item> selectionHandler)
		{
			throw null;
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D44F RID: 54351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProductionState(EProductionState productionState)
		{
			throw null;
		}

		// Token: 0x0600D450 RID: 54352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Item selectedItem)
		{
			throw null;
		}

		// Token: 0x0600D451 RID: 54353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D452 RID: 54354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string GetDetails(Item item)
		{
			throw null;
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_7(ResourceComponent resourceHolderItem)
		{
			throw null;
		}

		// Token: 0x0600D454 RID: 54356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D455 RID: 54357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D456 RID: 54358 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0400D692 RID: 54930
		[SerializeField]
		private TextMeshProUGUI _details;

		// Token: 0x0400D693 RID: 54931
		[SerializeField]
		private Color _defaultDetailsColor;

		// Token: 0x0400D694 RID: 54932
		[SerializeField]
		private Color _lowCountDetailsColor;

		// Token: 0x0400D695 RID: 54933
		[SerializeField]
		private Color _noItemDetailsColor;

		// Token: 0x0400D696 RID: 54934
		[SerializeField]
		private float _lowCountLevel;

		// Token: 0x0400D697 RID: 54935
		[SerializeField]
		private GameObject _noFuelPanel;

		// Token: 0x0400D698 RID: 54936
		[SerializeField]
		private GameObject _timePanel;

		// Token: 0x0400D699 RID: 54937
		[SerializeField]
		private TextMeshProUGUI _timeText;

		// Token: 0x0400D69A RID: 54938
		[SerializeField]
		private Image _lockIcon;

		// Token: 0x0400D69B RID: 54939
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400D69C RID: 54940
		private float float_0;

		// Token: 0x0400D69D RID: 54941
		private GInterface163 ginterface163_0;

		// Token: 0x0400D69E RID: 54942
		private EProductionState eproductionState_0;
	}
}
