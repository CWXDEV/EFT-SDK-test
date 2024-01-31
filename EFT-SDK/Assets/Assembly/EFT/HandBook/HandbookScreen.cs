using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.UI;
using EFT.UI.Ragfair;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.HandBook
{
	// Token: 0x0200261A RID: 9754
	public sealed class HandbookScreen : EftScreen<HandbookScreen.GClass3111, HandbookScreen>
	{
		// Token: 0x0600C1C3 RID: 49603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C1C4 RID: 49604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(HandbookScreen.GClass3111 controller)
		{
			throw null;
		}

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(InventoryControllerClass inventoryController, ISession session, GClass2881 handbook, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0600C1C6 RID: 49606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(NodeBaseView view, string id)
		{
			throw null;
		}

		// Token: 0x0400C3C8 RID: 50120
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400C3C9 RID: 50121
		[SerializeField]
		private HandbookCategoriesPanel _categoriesPanel;

		// Token: 0x0400C3CA RID: 50122
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400C3CB RID: 50123
		private NodeBaseView nodeBaseView_0;

		// Token: 0x0200261B RID: 9755
		public sealed class GClass3111 : GClass3107.GClass3109<HandbookScreen.GClass3111, HandbookScreen>
		{
			// Token: 0x1700229A RID: 8858
			// (get) Token: 0x0600C1CA RID: 49610 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400C3CC RID: 50124
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400C3CD RID: 50125
			public readonly ISession Session;

			// Token: 0x0400C3CE RID: 50126
			public readonly GClass2881 Handbook;

			// Token: 0x0400C3CF RID: 50127
			public readonly IHealthController HealthController;
		}
	}
}
