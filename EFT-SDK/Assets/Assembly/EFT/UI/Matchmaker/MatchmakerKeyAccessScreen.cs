using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using EFT.UI.WeaponModding;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DE6 RID: 11750
	public sealed class MatchmakerKeyAccessScreen : MatchmakerEftScreen<GClass3153, MatchmakerKeyAccessScreen>
	{
		// Token: 0x0600E703 RID: 59139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(GClass3153 controller)
		{
			throw null;
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(GInterface313 itemController, string[] requiredKeys)
		{
			throw null;
		}

		// Token: 0x0600E707 RID: 59143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E708 RID: 59144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Item selectedItem)
		{
			throw null;
		}

		// Token: 0x0600E709 RID: 59145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E70A RID: 59146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E70B RID: 59147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E70C RID: 59148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E70D RID: 59149 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600E70E RID: 59150 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600E70F RID: 59151 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400EC29 RID: 60457
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400EC2A RID: 60458
		[SerializeField]
		private GameObject _previewPanel;

		// Token: 0x0400EC2B RID: 60459
		[SerializeField]
		private WeaponPreview _preview;

		// Token: 0x0400EC2C RID: 60460
		[SerializeField]
		private CameraImage _previewImage;

		// Token: 0x0400EC2D RID: 60461
		[SerializeField]
		private float _autoRotationSpeed;

		// Token: 0x0400EC2E RID: 60462
		[SerializeField]
		private CardSelectionPanel _cardSelection;

		// Token: 0x0400EC2F RID: 60463
		[SerializeField]
		private GameObject _noKeycardPanel;

		// Token: 0x0400EC30 RID: 60464
		private bool bool_1;

		// Token: 0x0400EC31 RID: 60465
		private bool bool_2;

		// Token: 0x0400EC32 RID: 60466
		private Item item_0;

		// Token: 0x0400EC33 RID: 60467
		private Item item_1;

		// Token: 0x0400EC34 RID: 60468
		private Item[] item_2;

		// Token: 0x02002DE7 RID: 11751
		[CompilerGenerated]
		private sealed class Class2865
		{
			// Token: 0x0600E710 RID: 59152 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item equippedItem)
			{
				throw null;
			}

			// Token: 0x0400EC35 RID: 60469
			public GInterface313 itemController;

			// Token: 0x0400EC36 RID: 60470
			public string[] requiredKeys;
		}
	}
}
