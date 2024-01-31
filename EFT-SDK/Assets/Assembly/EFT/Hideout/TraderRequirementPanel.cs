using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001BBF RID: 7103
	public sealed class TraderRequirementPanel : UIElement, IDisposable, GInterface172, IUIView
	{
		// Token: 0x06009525 RID: 38181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment)
		{
			throw null;
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x04009BEE RID: 39918
		private const string string_0 = "Required <b>{0}</b>, level <b>{1}</b>";

		// Token: 0x04009BEF RID: 39919
		private const string string_1 = "Required <b>{0}</b> to be unlocked";

		// Token: 0x04009BF0 RID: 39920
		[SerializeField]
		private TraderRequirementIcon _traderRequirementIcon;

		// Token: 0x04009BF1 RID: 39921
		[SerializeField]
		private RequirementFulfilledStatus _fulfilledStatus;

		// Token: 0x04009BF2 RID: 39922
		private GClass1931 gclass1931_0;

		// Token: 0x04009BF3 RID: 39923
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x02001BC0 RID: 7104
		[CompilerGenerated]
		private sealed class Class1680
		{
			// Token: 0x0600952A RID: 38186 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009BF4 RID: 39924
			public TraderRequirementPanel traderRequirementPanel_0;

			// Token: 0x04009BF5 RID: 39925
			public bool ignoreFulfillment;
		}
	}
}
