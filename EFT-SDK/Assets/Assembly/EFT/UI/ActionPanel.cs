using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028DF RID: 10463
	public sealed class ActionPanel : UIInputNode
	{
		// Token: 0x0600D0E0 RID: 53472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Show(GamePlayerOwner owner)
		{
			throw null;
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0([CanBeNull] GClass3008 interactionState)
		{
			throw null;
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool isAiming)
		{
			throw null;
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool isDefaultPosition)
		{
			throw null;
		}

		// Token: 0x0600D0E5 RID: 53477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D0E6 RID: 53478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D0E8 RID: 53480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPointer(bool b)
		{
			throw null;
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D0EC RID: 53484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Player.AbstractHandsController oldValue, Player.AbstractHandsController newValue)
		{
			throw null;
		}

		// Token: 0x0600D0EF RID: 53487 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0400D1C7 RID: 53703
		private const float float_0 = 5f;

		// Token: 0x0400D1C8 RID: 53704
		[SerializeField]
		private TextMeshProUGUI _itemName;

		// Token: 0x0400D1C9 RID: 53705
		[SerializeField]
		private GameObject _itemPanel;

		// Token: 0x0400D1CA RID: 53706
		[SerializeField]
		private GameObject _errorPanel;

		// Token: 0x0400D1CB RID: 53707
		[SerializeField]
		private TextMeshProUGUI _errorText;

		// Token: 0x0400D1CC RID: 53708
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0400D1CD RID: 53709
		[SerializeField]
		private UIPointer _pointer;

		// Token: 0x0400D1CE RID: 53710
		[SerializeField]
		private InteractionButton _interactionButtonTemplate;

		// Token: 0x0400D1CF RID: 53711
		[SerializeField]
		private RectTransform _interactionButtonsContainer;

		// Token: 0x0400D1D0 RID: 53712
		[SerializeField]
		private Vector2 _aimingShift;

		// Token: 0x0400D1D1 RID: 53713
		private Vector2 vector2_0;

		// Token: 0x0400D1D2 RID: 53714
		private GClass3078<GClass3007, InteractionButton> gclass3078_0;

		// Token: 0x0400D1D3 RID: 53715
		private GamePlayerOwner gamePlayerOwner_0;

		// Token: 0x0400D1D4 RID: 53716
		private bool bool_0;

		// Token: 0x0400D1D5 RID: 53717
		private bool bool_1;

		// Token: 0x0400D1D6 RID: 53718
		private float float_1;

		// Token: 0x0400D1D7 RID: 53719
		private float float_2;

		// Token: 0x0400D1D8 RID: 53720
		private bool bool_2;

		// Token: 0x020028E0 RID: 10464
		[CompilerGenerated]
		private sealed class Class2379
		{
			// Token: 0x0600D0F0 RID: 53488 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal InteractionButton method_0(GClass3007 arg)
			{
				throw null;
			}

			// Token: 0x0600D0F1 RID: 53489 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_1(GClass3007 arg)
			{
				throw null;
			}

			// Token: 0x0600D0F2 RID: 53490 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass3007 model, InteractionButton view)
			{
				throw null;
			}

			// Token: 0x0400D1D9 RID: 53721
			public ActionPanel actionPanel_0;

			// Token: 0x0400D1DA RID: 53722
			public GClass3008 interactionState;
		}
	}
}
