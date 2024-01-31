using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F7B RID: 12155
	[UsedImplicitly]
	public sealed class RagfairFilterWindow : UIElement
	{
		// Token: 0x0600EFBE RID: 61374 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EFBF RID: 61375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(RagFairClass ragfair)
		{
			throw null;
		}

		// Token: 0x0600EFC0 RID: 61376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool status)
		{
			throw null;
		}

		// Token: 0x0600EFC1 RID: 61377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(TMP_InputField currentField, TMP_InputField dependField, RagfairFilterWindow.EManageInputFieldType type)
		{
			throw null;
		}

		// Token: 0x0600EFC2 RID: 61378 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EFC3 RID: 61379 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(int index)
		{
			throw null;
		}

		// Token: 0x0400F51B RID: 62747
		private const string string_0 = "∞";

		// Token: 0x0400F51C RID: 62748
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400F51D RID: 62749
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400F51E RID: 62750
		[SerializeField]
		private DropDownBox _currencyDropdown;

		// Token: 0x0400F51F RID: 62751
		[SerializeField]
		private TMP_InputField _estimatedPriceFrom;

		// Token: 0x0400F520 RID: 62752
		[SerializeField]
		private TMP_InputField _estimatedPriceTo;

		// Token: 0x0400F521 RID: 62753
		[SerializeField]
		private CanvasGroup _priceFromGroup;

		// Token: 0x0400F522 RID: 62754
		[SerializeField]
		private CanvasGroup _priceToGroup;

		// Token: 0x0400F523 RID: 62755
		[SerializeField]
		private TMP_InputField _quantityFrom;

		// Token: 0x0400F524 RID: 62756
		[SerializeField]
		private TMP_InputField _quantityTo;

		// Token: 0x0400F525 RID: 62757
		[SerializeField]
		private TMP_InputField _conditionFrom;

		// Token: 0x0400F526 RID: 62758
		[SerializeField]
		private TMP_InputField _conditionTo;

		// Token: 0x0400F527 RID: 62759
		[SerializeField]
		private Image _currencyImage;

		// Token: 0x0400F528 RID: 62760
		[SerializeField]
		private UpdatableToggle _hourExpiration;

		// Token: 0x0400F529 RID: 62761
		[SerializeField]
		private UpdatableToggle _removeBartering;

		// Token: 0x0400F52A RID: 62762
		[SerializeField]
		private DropDownBox _displayOwnerDropdown;

		// Token: 0x0400F52B RID: 62763
		[SerializeField]
		private UpdatableToggle _onlyFunctional;

		// Token: 0x0400F52C RID: 62764
		[SerializeField]
		private UpdatableToggle _rememberSelected;

		// Token: 0x0400F52D RID: 62765
		[SerializeField]
		private DefaultUIButton _applyButton;

		// Token: 0x0400F52E RID: 62766
		[SerializeField]
		private DefaultUIButton _resetButton;

		// Token: 0x0400F52F RID: 62767
		private RagFairClass gclass3190_0;

		// Token: 0x02002F7C RID: 12156
		private enum EManageInputFieldType
		{
			// Token: 0x0400F531 RID: 62769
			InfinityOverflow,
			// Token: 0x0400F532 RID: 62770
			HundredOverflow,
			// Token: 0x0400F533 RID: 62771
			DependencyClamp
		}

		// Token: 0x02002F7D RID: 12157
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3028
		{
			// Token: 0x0600EFC5 RID: 61381 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string x)
			{
				throw null;
			}

			// Token: 0x0400F534 RID: 62772
			public static readonly RagfairFilterWindow.Class3028 class3028_0;

			// Token: 0x0400F535 RID: 62773
			public static Func<string, string> func_0;
		}

		// Token: 0x02002F7E RID: 12158
		[CompilerGenerated]
		private sealed class Class3029
		{
			// Token: 0x0600EFC6 RID: 61382 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(string arg)
			{
				throw null;
			}

			// Token: 0x0400F536 RID: 62774
			public RagfairFilterWindow.EManageInputFieldType type;

			// Token: 0x0400F537 RID: 62775
			public TMP_InputField currentField;

			// Token: 0x0400F538 RID: 62776
			public TMP_InputField dependField;
		}
	}
}
