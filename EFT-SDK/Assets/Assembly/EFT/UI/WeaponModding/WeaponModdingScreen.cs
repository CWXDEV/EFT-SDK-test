using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.WeaponModding
{
	// Token: 0x02002D20 RID: 11552
	public sealed class WeaponModdingScreen : ItemObserveScreen<WeaponModdingScreen.GClass3158, WeaponModdingScreen>
	{
		// Token: 0x0600E333 RID: 58163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600E334 RID: 58164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(WeaponModdingScreen.GClass3158 controller)
		{
			throw null;
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Item item, InventoryControllerClass inventoryController, LootItemClass[] collections)
		{
			throw null;
		}

		// Token: 0x0600E336 RID: 58166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass2825 CreateBuildManipulation()
		{
			throw null;
		}

		// Token: 0x0600E337 RID: 58167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ToggleChangedHandler()
		{
			throw null;
		}

		// Token: 0x0600E338 RID: 58168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CheckForVitalParts()
		{
			throw null;
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E33A RID: 58170 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(bool x)
		{
			throw null;
		}

		// Token: 0x0400E802 RID: 59394
		[SerializeField]
		private CustomTextMeshProUGUI _headerLabel;

		// Token: 0x0400E803 RID: 59395
		[SerializeField]
		private Toggle _allClassesToggle;

		// Token: 0x0400E804 RID: 59396
		[SerializeField]
		private GameObject _warningPanel;

		// Token: 0x0400E805 RID: 59397
		[SerializeField]
		private LocalizedText _warningLabel;

		// Token: 0x0400E806 RID: 59398
		private LootItemClass[] gclass2625_0;

		// Token: 0x02002D21 RID: 11553
		public sealed class GClass3158 : GClass3107.GClass3109<WeaponModdingScreen.GClass3158, WeaponModdingScreen>
		{
			// Token: 0x170027B7 RID: 10167
			// (get) Token: 0x0600E33B RID: 58171 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027B8 RID: 10168
			// (get) Token: 0x0600E33C RID: 58172 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400E807 RID: 59399
			public readonly Item Item;

			// Token: 0x0400E808 RID: 59400
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400E809 RID: 59401
			public readonly LootItemClass[] Collections;
		}
	}
}
