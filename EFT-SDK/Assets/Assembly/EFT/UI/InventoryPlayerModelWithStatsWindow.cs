using System;
using System.Runtime.CompilerServices;
using EFT.Utilities;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C8C RID: 11404
	public class InventoryPlayerModelWithStatsWindow : UIElement
	{
		// Token: 0x1400031A RID: 794
		// (add) Token: 0x0600E0B7 RID: 57527 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E0B8 RID: 57528 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass2934> OnCustomizationChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600E0B9 RID: 57529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, [CanBeNull] InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600E0BA RID: 57530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IProfileDataContainer profileDataContainer, int experience, EMemberCategory memberCategory, ProfileStats stats, PlayerVisualRepresentation playerVisualRepresentation, [CanBeNull] InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ProfileStats stats)
		{
			throw null;
		}

		// Token: 0x0600E0BC RID: 57532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EPlayerSide side)
		{
			throw null;
		}

		// Token: 0x0600E0BD RID: 57533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PlayerVisualRepresentation playerVisualRepresentation, InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PlayerVisualRepresentation playerVisualRepresentation, InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600E0BF RID: 57535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(long seconds)
		{
			throw null;
		}

		// Token: 0x0600E0C0 RID: 57536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600E0C1 RID: 57537 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400E566 RID: 58726
		[SerializeField]
		private CustomTextMeshProUGUI _nicknameLabel;

		// Token: 0x0400E567 RID: 58727
		[SerializeField]
		private ChatSpecialIcon _specialIcon;

		// Token: 0x0400E568 RID: 58728
		[SerializeField]
		private CustomTextMeshProUGUI _experienceLabel;

		// Token: 0x0400E569 RID: 58729
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400E56A RID: 58730
		[SerializeField]
		private XCoordRotation _rotator;

		// Token: 0x0400E56B RID: 58731
		[SerializeField]
		private PlayerLevelPanel _playerLevelPanel;

		// Token: 0x0400E56C RID: 58732
		[SerializeField]
		private ShortStatsPanel _shortStatsPanel;

		// Token: 0x0400E56D RID: 58733
		[SerializeField]
		private Image _sideImage;

		// Token: 0x0400E56E RID: 58734
		[SerializeField]
		private Sprite _bearSprite;

		// Token: 0x0400E56F RID: 58735
		[SerializeField]
		private Sprite _usecSprite;

		// Token: 0x0400E570 RID: 58736
		[SerializeField]
		private DragTrigger _dragTrigger;

		// Token: 0x0400E571 RID: 58737
		[SerializeField]
		private InventoryClothingSelectionPanel _clothingPanel;

		// Token: 0x0400E572 RID: 58738
		[CompilerGenerated]
		private Action<GClass2934> action_0;

		// Token: 0x02002C8D RID: 11405
		[CompilerGenerated]
		private sealed class Class2716
		{
			// Token: 0x0600E0C3 RID: 57539 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass2934 suite)
			{
				throw null;
			}

			// Token: 0x0400E573 RID: 58739
			public PlayerVisualRepresentation playerVisualRepresentation;

			// Token: 0x0400E574 RID: 58740
			public InventoryPlayerModelWithStatsWindow inventoryPlayerModelWithStatsWindow_0;

			// Token: 0x0400E575 RID: 58741
			public InventoryControllerClass inventoryController;
		}
	}
}
