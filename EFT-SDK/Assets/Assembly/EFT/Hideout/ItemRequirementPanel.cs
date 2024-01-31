using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BB6 RID: 7094
	public sealed class ItemRequirementPanel : UIElement, IDisposable, GInterface172, IUIView
	{
		// Token: 0x06009515 RID: 38165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment)
		{
			throw null;
		}

		// Token: 0x04009BCE RID: 39886
		[SerializeField]
		private HideoutItemViewFactory _itemIconViewFactory;

		// Token: 0x02001BB7 RID: 7095
		[CompilerGenerated]
		private sealed class Class1676
		{
			// Token: 0x06009516 RID: 38166 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009BCF RID: 39887
			public ItemRequirement itemRequirement;

			// Token: 0x04009BD0 RID: 39888
			public ItemRequirementPanel itemRequirementPanel_0;

			// Token: 0x04009BD1 RID: 39889
			public bool ignoreFulfillment;
		}
	}
}
