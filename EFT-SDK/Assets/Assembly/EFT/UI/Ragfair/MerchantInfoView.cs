using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F83 RID: 12163
	public sealed class MerchantInfoView : UIElement
	{
		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600EFD7 RID: 61399 RVA: 0x00002050 File Offset: 0x00000250
		private Color32 Color32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600EFD8 RID: 61400 RVA: 0x00002050 File Offset: 0x00000250
		private Color32 Color32_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EFD9 RID: 61401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(RagFairClass ragfair, Offer.GClass3191 merchant, bool isMyOffer)
		{
			throw null;
		}

		// Token: 0x0600EFDA RID: 61402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float rating, bool isRatingGrowing)
		{
			throw null;
		}

		// Token: 0x0600EFDB RID: 61403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0600EFDC RID: 61404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1(string path)
		{
			throw null;
		}

		// Token: 0x0600EFDD RID: 61405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_2(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool visible)
		{
			throw null;
		}

		// Token: 0x0600EFDF RID: 61407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetExpandedStatus(bool status)
		{
			throw null;
		}

		// Token: 0x0400F54E RID: 62798
		[SerializeField]
		private Image _avatar;

		// Token: 0x0400F54F RID: 62799
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400F550 RID: 62800
		[SerializeField]
		private Sprite _defaultAvatar;

		// Token: 0x0400F551 RID: 62801
		[SerializeField]
		private ChatSpecialIcon _specialIcon;

		// Token: 0x0400F552 RID: 62802
		[SerializeField]
		private RankPanel _rankPanel;

		// Token: 0x0400F553 RID: 62803
		[SerializeField]
		private GameObject _reputationIcon;

		// Token: 0x0400F554 RID: 62804
		[SerializeField]
		private GameObject _standingIcon;

		// Token: 0x0400F555 RID: 62805
		[SerializeField]
		private TextMeshProUGUI _merchantName;

		// Token: 0x0400F556 RID: 62806
		[SerializeField]
		private TextMeshProUGUI _merchantReputation;

		// Token: 0x0400F557 RID: 62807
		[SerializeField]
		private GameObject _positiveReputation;

		// Token: 0x0400F558 RID: 62808
		[SerializeField]
		private GameObject _negativeReputation;

		// Token: 0x02002F84 RID: 12164
		[CompilerGenerated]
		private sealed class Class3031
		{
			// Token: 0x0600EFE0 RID: 61408 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400F559 RID: 62809
			public RagFairClass ragfair;

			// Token: 0x0400F55A RID: 62810
			public MerchantInfoView merchantInfoView_0;
		}
	}
}
