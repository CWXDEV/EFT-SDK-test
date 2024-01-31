using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C11 RID: 11281
	[UsedImplicitly]
	public sealed class TransferItemsInRaidScreen : EftScreen<TransferItemsInRaidScreen.GClass3137, TransferItemsInRaidScreen>
	{
		// Token: 0x0600DE5A RID: 56922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TransferItemsInRaidScreen.GClass3137 controller)
		{
			throw null;
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(InventoryControllerClass inventoryController, AbstractQuestControllerClass questController, Profile profile, InsuranceCompanyClass insurance, BTRControllerClass btrController)
		{
			throw null;
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DE5D RID: 56925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600DE5E RID: 56926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600DE5F RID: 56927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600DE60 RID: 56928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DE61 RID: 56929 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400E32B RID: 58155
		private const string string_0 = "TransferScreen/TransferSuccess";

		// Token: 0x0400E32C RID: 58156
		private const string string_1 = "TransferScreen/TransferFailed";

		// Token: 0x0400E32D RID: 58157
		private const string string_2 = "TransferScreen/BtrCaution";

		// Token: 0x0400E32E RID: 58158
		[SerializeField]
		private EquipmentTab _equipmentPanel;

		// Token: 0x0400E32F RID: 58159
		[SerializeField]
		private ContainersPanel _containersPanel;

		// Token: 0x0400E330 RID: 58160
		[SerializeField]
		private TransferItemsPanel _transferItemsPanel;

		// Token: 0x0400E331 RID: 58161
		[SerializeField]
		private DefaultUIButton _closeScreenButton;

		// Token: 0x0400E332 RID: 58162
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E333 RID: 58163
		private Profile profile_0;

		// Token: 0x0400E334 RID: 58164
		private SkillManager skillManager_0;

		// Token: 0x0400E335 RID: 58165
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400E336 RID: 58166
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400E337 RID: 58167
		private Inventory inventory_0;

		// Token: 0x0400E338 RID: 58168
		private bool bool_1;

		// Token: 0x0400E339 RID: 58169
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400E33A RID: 58170
		private StashClass gclass2698_0;

		// Token: 0x0400E33B RID: 58171
		private BTRControllerClass gclass2913_0;

		// Token: 0x02002C12 RID: 11282
		public sealed class GClass3137 : GClass3107.GClass3109<TransferItemsInRaidScreen.GClass3137, TransferItemsInRaidScreen>
		{
			// Token: 0x170026D5 RID: 9941
			// (get) Token: 0x0600DE62 RID: 56930 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D6 RID: 9942
			// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher UnrestrictedFrameRate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D7 RID: 9943
			// (get) Token: 0x0600DE64 RID: 56932 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D8 RID: 9944
			// (get) Token: 0x0600DE65 RID: 56933 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D9 RID: 9945
			// (get) Token: 0x0600DE66 RID: 56934 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026DA RID: 9946
			// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x00002050 File Offset: 0x00000250
			public InsuranceCompanyClass Insurance
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026DB RID: 9947
			// (get) Token: 0x0600DE68 RID: 56936 RVA: 0x00002050 File Offset: 0x00000250
			public Profile Profile
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026DC RID: 9948
			// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x00002050 File Offset: 0x00000250
			public InventoryControllerClass InventoryController
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026DD RID: 9949
			// (get) Token: 0x0600DE6A RID: 56938 RVA: 0x00002050 File Offset: 0x00000250
			public AbstractQuestControllerClass QuestController
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026DE RID: 9950
			// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x00002050 File Offset: 0x00000250
			public BTRControllerClass BtrController
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600DE6C RID: 56940 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600DE6D RID: 56941 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Task CloseForcedAndReturnToRoot()
			{
				throw null;
			}

			// Token: 0x0600DE6E RID: 56942 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_9(bool forced)
			{
				throw null;
			}

			// Token: 0x0600DE6F RID: 56943 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_10(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400E33C RID: 58172
			[CompilerGenerated]
			private readonly InsuranceCompanyClass gclass3179_0;

			// Token: 0x0400E33D RID: 58173
			[CompilerGenerated]
			private readonly Profile profile_0;

			// Token: 0x0400E33E RID: 58174
			[CompilerGenerated]
			private readonly InventoryControllerClass gclass2757_0;

			// Token: 0x0400E33F RID: 58175
			[CompilerGenerated]
			private readonly AbstractQuestControllerClass gclass3203_0;

			// Token: 0x0400E340 RID: 58176
			[CompilerGenerated]
			private readonly BTRControllerClass gclass2913_0;
		}
	}
}
