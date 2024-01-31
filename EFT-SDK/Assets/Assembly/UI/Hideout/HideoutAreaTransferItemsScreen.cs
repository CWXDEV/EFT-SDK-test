using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Hideout;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI;
using EFT.UI.DragAndDrop;
using EFT.UI.Screens;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UI.Hideout
{
	// Token: 0x02000C68 RID: 3176
	public sealed class HideoutAreaTransferItemsScreen : EftScreen<HideoutAreaTransferItemsScreen.GClass3110, HideoutAreaTransferItemsScreen>
	{
		// Token: 0x06004503 RID: 17667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(HideoutAreaTransferItemsScreen.GClass3110 controller)
		{
			throw null;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(AreaData areaData, InventoryControllerClass controller, ISession session)
		{
			throw null;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(AreaData areaData)
		{
			throw null;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(IContainer container, string localizationKey)
		{
			throw null;
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(string localizationKey)
		{
			throw null;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool hide)
		{
			throw null;
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x04004F1E RID: 20254
		[SerializeField]
		private SimpleStashPanel _stashPanel;

		// Token: 0x04004F1F RID: 20255
		[SerializeField]
		private Transform _parent;

		// Token: 0x04004F20 RID: 20256
		[SerializeField]
		private DefaultUIButton _closeButton;

		// Token: 0x04004F21 RID: 20257
		[SerializeField]
		private HandoverHideoutAreaStashItemsWindow _handoverItemsWindow;

		// Token: 0x04004F22 RID: 20258
		[FormerlySerializedAs("_uiVisibilityToggle")]
		[SerializeField]
		private Toggle _uiHiddenToggle;

		// Token: 0x04004F23 RID: 20259
		[SerializeField]
		private CanvasGroup _areaStashCanvasGroup;

		// Token: 0x04004F24 RID: 20260
		[SerializeField]
		private CanvasGroup _inventoryCanvasGroup;

		// Token: 0x04004F25 RID: 20261
		[SerializeField]
		private CanvasGroup _handoverItemsWindowCanvasGroup;

		// Token: 0x04004F26 RID: 20262
		[SerializeField]
		private Tab[] _tabs;

		// Token: 0x04004F27 RID: 20263
		[SerializeField]
		private Transform _tabsRoot;

		// Token: 0x04004F28 RID: 20264
		private GClass3065 gclass3065_0;

		// Token: 0x04004F29 RID: 20265
		private ItemUiContext itemUiContext_0;

		// Token: 0x04004F2A RID: 20266
		private InventoryControllerClass gclass2757_0;

		// Token: 0x04004F2B RID: 20267
		private LootItemClass gclass2625_0;

		// Token: 0x04004F2C RID: 20268
		private LootItemClass gclass2625_1;

		// Token: 0x04004F2D RID: 20269
		private AreaData areaData_0;

		// Token: 0x04004F2E RID: 20270
		private AreaData areaData_1;

		// Token: 0x04004F2F RID: 20271
		private List<AreaData> list_0;

		// Token: 0x04004F30 RID: 20272
		private ContainedGridsView containedGridsView_0;

		// Token: 0x04004F31 RID: 20273
		private GClass3085 gclass3085_0;

		// Token: 0x02000C69 RID: 3177
		public sealed class GClass3110 : GClass3107.GClass3109<HideoutAreaTransferItemsScreen.GClass3110, HideoutAreaTransferItemsScreen>
		{
			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x06004511 RID: 17681 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06004512 RID: 17682 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06004513 RID: 17683 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004514 RID: 17684 RVA: 0x00002050 File Offset: 0x00000250
			public AreaData AreaData
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

			// Token: 0x06004515 RID: 17685 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CloseAction(bool moveForward)
			{
				throw null;
			}

			// Token: 0x04004F32 RID: 20274
			[CompilerGenerated]
			private AreaData areaData_0;

			// Token: 0x04004F33 RID: 20275
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x04004F34 RID: 20276
			public readonly ISession Session;
		}

		// Token: 0x02000C6A RID: 3178
		private sealed class Class2624 : GClass3057
		{
			// Token: 0x06004516 RID: 17686 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x04004F35 RID: 20277
			private readonly HideoutAreaTransferItemsScreen hideoutAreaTransferItemsScreen_0;

			// Token: 0x04004F36 RID: 20278
			private readonly AreaData areaData_0;
		}

		// Token: 0x02000C6B RID: 3179
		[CompilerGenerated]
		private sealed class Class637
		{
			// Token: 0x06004517 RID: 17687 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04004F37 RID: 20279
			public TemplatedGridsView templatedGridsView;

			// Token: 0x04004F38 RID: 20280
			public HideoutAreaTransferItemsScreen hideoutAreaTransferItemsScreen_0;
		}
	}
}
