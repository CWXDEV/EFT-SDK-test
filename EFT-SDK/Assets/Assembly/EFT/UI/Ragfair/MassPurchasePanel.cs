using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F93 RID: 12179
	public sealed class MassPurchasePanel : UIElement
	{
		// Token: 0x0600F050 RID: 61520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F051 RID: 61521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600F052 RID: 61522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Dictionary<string, int> includedItems, RagFairClass ragfair, Action<bool, Dictionary<GInterface151, int>> onPurchaseButtonClicked)
		{
			throw null;
		}

		// Token: 0x0600F053 RID: 61523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EViewListType viewType)
		{
			throw null;
		}

		// Token: 0x0600F054 RID: 61524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Offer offer, bool selected)
		{
			throw null;
		}

		// Token: 0x0600F055 RID: 61525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600F056 RID: 61526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600F057 RID: 61527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600F058 RID: 61528 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600F059 RID: 61529 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600F05A RID: 61530 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600F05B RID: 61531 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_8(Offer offer)
		{
			throw null;
		}

		// Token: 0x0400F5E3 RID: 62947
		[SerializeField]
		private DefaultUIButton _purchaseButtonSpawner;

		// Token: 0x0400F5E4 RID: 62948
		[SerializeField]
		private TextMeshProUGUI _totalPriceLabel;

		// Token: 0x0400F5E5 RID: 62949
		private Dictionary<string, int> dictionary_0;

		// Token: 0x0400F5E6 RID: 62950
		private Dictionary<string, int> dictionary_1;

		// Token: 0x0400F5E7 RID: 62951
		private Dictionary<Offer, int> dictionary_2;

		// Token: 0x0400F5E8 RID: 62952
		private RagFairClass gclass3190_0;

		// Token: 0x0400F5E9 RID: 62953
		private Action<bool, Dictionary<GInterface151, int>> action_0;

		// Token: 0x0400F5EA RID: 62954
		private HashSet<Offer> hashSet_0;

		// Token: 0x02002F94 RID: 12180
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3035
		{
			// Token: 0x0600F05C RID: 61532 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GInterface151 method_0(KeyValuePair<Offer, int> x)
			{
				throw null;
			}

			// Token: 0x0600F05D RID: 61533 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(KeyValuePair<Offer, int> x)
			{
				throw null;
			}

			// Token: 0x0400F5EB RID: 62955
			public static readonly MassPurchasePanel.Class3035 class3035_0;

			// Token: 0x0400F5EC RID: 62956
			public static Func<KeyValuePair<Offer, int>, GInterface151> func_0;

			// Token: 0x0400F5ED RID: 62957
			public static Func<KeyValuePair<Offer, int>, int> func_1;
		}
	}
}
