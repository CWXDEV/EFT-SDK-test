using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200196B RID: 6507
	public class ItemRequirementsPanel : UIElement
	{
		// Token: 0x06008BA0 RID: 35744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2495 stashGrid, GClass2941[] requirements, Action<bool> onAvailableChanged)
		{
			throw null;
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView()
		{
			throw null;
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateItemsViews(GClass2495 stashGrid, [CanBeNull] GClass2941[] requirements, [CanBeNull] Action<bool> onAvailableChanged)
		{
			throw null;
		}

		// Token: 0x04009135 RID: 37173
		[SerializeField]
		private RequiredItem _template;

		// Token: 0x04009136 RID: 37174
		[SerializeField]
		private Sprite _rubSprite;

		// Token: 0x04009137 RID: 37175
		[SerializeField]
		private Sprite _euroSprite;

		// Token: 0x04009138 RID: 37176
		[SerializeField]
		private Sprite _dollarSprite;

		// Token: 0x04009139 RID: 37177
		private bool bool_0;

		// Token: 0x0400913A RID: 37178
		private GClass3078<GClass2941, RequiredItem> gclass3078_0;

		// Token: 0x0200196C RID: 6508
		[CompilerGenerated]
		private sealed class Class1522
		{
			// Token: 0x06008BA3 RID: 35747 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass2941 item, RequiredItem view)
			{
				throw null;
			}

			// Token: 0x0400913B RID: 37179
			public GClass2495 stashGrid;

			// Token: 0x0400913C RID: 37180
			public ItemRequirementsPanel itemRequirementsPanel_0;

			// Token: 0x0400913D RID: 37181
			public Action<bool> onAvailableChanged;
		}

		// Token: 0x0200196D RID: 6509
		[CompilerGenerated]
		private sealed class Class1523
		{
			// Token: 0x06008BA4 RID: 35748 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0()
			{
				throw null;
			}

			// Token: 0x0400913E RID: 37182
			public GClass2941 item;

			// Token: 0x0400913F RID: 37183
			public ECurrencyType moneyType;

			// Token: 0x04009140 RID: 37184
			public ItemRequirementsPanel.Class1522 class1522_0;
		}
	}
}
