using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FB7 RID: 12215
	public class RenewOfferWindow : UIElement
	{
		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x0600F121 RID: 61729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F122 RID: 61730 RVA: 0x00002050 File Offset: 0x00000250
		public Offer Offer
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

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x0600F123 RID: 61731 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F124 RID: 61732 RVA: 0x00002050 File Offset: 0x00000250
		public TimeSpan CurrentTime
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

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x0600F125 RID: 61733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F126 RID: 61734 RVA: 0x00002050 File Offset: 0x00000250
		public int HoursCount
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

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x0600F127 RID: 61735 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F128 RID: 61736 RVA: 0x00002050 File Offset: 0x00000250
		public bool Prioritized
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

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x0600F129 RID: 61737 RVA: 0x00002050 File Offset: 0x00000250
		private TimeSpan TimeSpan_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x0600F12A RID: 61738 RVA: 0x00002050 File Offset: 0x00000250
		private TimeSpan TimeSpan_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F12B RID: 61739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F12C RID: 61740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass inventoryController, RagFairClass ragfair, Offer offer, TimeSpan time, Action onRenew)
		{
			throw null;
		}

		// Token: 0x0600F12D RID: 61741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string offerId)
		{
			throw null;
		}

		// Token: 0x0600F12E RID: 61742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F12F RID: 61743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600F130 RID: 61744 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600F131 RID: 61745 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600F132 RID: 61746 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400F724 RID: 63268
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400F725 RID: 63269
		[SerializeField]
		private CustomTextMeshProUGUI _captionLabel;

		// Token: 0x0400F726 RID: 63270
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400F727 RID: 63271
		[SerializeField]
		private CustomTextMeshProUGUI _currentTimeLabel;

		// Token: 0x0400F728 RID: 63272
		[SerializeField]
		private CanvasGroup _minusButtonGroup;

		// Token: 0x0400F729 RID: 63273
		[SerializeField]
		private CanvasGroup _plusButtonGroup;

		// Token: 0x0400F72A RID: 63274
		[SerializeField]
		private Button _minusButton;

		// Token: 0x0400F72B RID: 63275
		[SerializeField]
		private Button _plusButton;

		// Token: 0x0400F72C RID: 63276
		[SerializeField]
		private DefaultUIButton _renewButton;

		// Token: 0x0400F72D RID: 63277
		[SerializeField]
		private CustomTextMeshProUGUI _taxPriceLabel;

		// Token: 0x0400F72E RID: 63278
		[CompilerGenerated]
		private Offer offer_0;

		// Token: 0x0400F72F RID: 63279
		[CompilerGenerated]
		private TimeSpan timeSpan_0;

		// Token: 0x0400F730 RID: 63280
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400F731 RID: 63281
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400F732 RID: 63282
		private Action action_0;

		// Token: 0x0400F733 RID: 63283
		private RagFairClass gclass3190_0;

		// Token: 0x0400F734 RID: 63284
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F735 RID: 63285
		private TimeSpan timeSpan_1;

		// Token: 0x0400F736 RID: 63286
		private TimeSpan timeSpan_2;
	}
}
