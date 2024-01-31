using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F62 RID: 12130
	public sealed class HandoverRagfairMoneyWindow : MessageWindow
	{
		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x0600EF61 RID: 61281 RVA: 0x00002050 File Offset: 0x00000250
		private TimeSpan TimeSpan_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EF62 RID: 61282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600EF63 RID: 61283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Inventory inventory, bool displayInputField, Dictionary<GInterface151, int> goods, Action<CustomizationClass> acceptAction, Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600EF64 RID: 61284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Item[] playerItems)
		{
			throw null;
		}

		// Token: 0x0600EF65 RID: 61285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_5(ECurrencyType moneyType)
		{
			throw null;
		}

		// Token: 0x0600EF66 RID: 61286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600EF67 RID: 61287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EF68 RID: 61288 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(string arg)
		{
			throw null;
		}

		// Token: 0x0600EF69 RID: 61289 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600EF6A RID: 61290 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400F49D RID: 62621
		private const string string_3 = "ragfair/You don't have enough money for the transaction";

		// Token: 0x0400F49E RID: 62622
		private const string string_4 = "ragfair/Are you sure you want to buy {0} ({1}) for {2}?";

		// Token: 0x0400F49F RID: 62623
		private const string string_5 = "Are you sure you want to buy selected items for {0}?";

		// Token: 0x0400F4A0 RID: 62624
		private const string string_6 = "ragfair/Item purchase";

		// Token: 0x0400F4A1 RID: 62625
		[SerializeField]
		private GameObject _countPanel;

		// Token: 0x0400F4A2 RID: 62626
		[SerializeField]
		private MessageWindow _notEnoughMoneyWindow;

		// Token: 0x0400F4A3 RID: 62627
		[SerializeField]
		private TMP_InputField _inputField;

		// Token: 0x0400F4A4 RID: 62628
		[SerializeField]
		private CustomTextMeshProUGUI _maxCountLabel;

		// Token: 0x0400F4A5 RID: 62629
		[SerializeField]
		private Button _allItemsButton;

		// Token: 0x0400F4A6 RID: 62630
		[NonSerialized]
		public Dictionary<GInterface151, int> Goods;

		// Token: 0x0400F4A7 RID: 62631
		private CustomizationClass gclass1865_0;

		// Token: 0x0400F4A8 RID: 62632
		private Item[] item_0;

		// Token: 0x0400F4A9 RID: 62633
		private Action<CustomizationClass> action_2;

		// Token: 0x0400F4AA RID: 62634
		private Action action_3;

		// Token: 0x0400F4AB RID: 62635
		private DateTime dateTime_0;

		// Token: 0x0400F4AC RID: 62636
		private EMemberCategory ememberCategory_0;

		// Token: 0x0400F4AD RID: 62637
		private IEnumerator ienumerator_0;

		// Token: 0x02002F63 RID: 12131
		[CompilerGenerated]
		private sealed class Class3016
		{
			// Token: 0x0600EF6B RID: 61291 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(KeyValuePair<GInterface151, int> offer)
			{
				throw null;
			}

			// Token: 0x0400F4AE RID: 62638
			public int newCount;
		}

		// Token: 0x02002F64 RID: 12132
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3017
		{
			// Token: 0x0600EF6C RID: 61292 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(KeyValuePair<GInterface151, int> x)
			{
				throw null;
			}

			// Token: 0x0600EF6D RID: 61293 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GInterface151 method_1(KeyValuePair<GInterface151, int> offer)
			{
				throw null;
			}

			// Token: 0x0600EF6E RID: 61294 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(KeyValuePair<GInterface151, int> x)
			{
				throw null;
			}

			// Token: 0x0600EF6F RID: 61295 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DateTime method_3(KeyValuePair<GInterface151, int> x)
			{
				throw null;
			}

			// Token: 0x0600EF70 RID: 61296 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_4(KeyValuePair<GInterface151, int> x)
			{
				throw null;
			}

			// Token: 0x0600EF71 RID: 61297 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(KeyValuePair<GInterface151, int> x)
			{
				throw null;
			}

			// Token: 0x0600EF72 RID: 61298 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_6(GClass1860 x)
			{
				throw null;
			}

			// Token: 0x0600EF73 RID: 61299 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_7(GClass1860 y)
			{
				throw null;
			}

			// Token: 0x0600EF74 RID: 61300 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_8(GClass1860 y)
			{
				throw null;
			}

			// Token: 0x0600EF75 RID: 61301 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_9(GClass2733 x)
			{
				throw null;
			}

			// Token: 0x0600EF76 RID: 61302 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_10(KeyValuePair<ECurrencyType, int> x)
			{
				throw null;
			}

			// Token: 0x0600EF77 RID: 61303 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_11(GClass1864 x)
			{
				throw null;
			}

			// Token: 0x0400F4AF RID: 62639
			public static readonly HandoverRagfairMoneyWindow.Class3017 class3017_0;

			// Token: 0x0400F4B0 RID: 62640
			public static Func<KeyValuePair<GInterface151, int>, int> func_0;

			// Token: 0x0400F4B1 RID: 62641
			public static Func<KeyValuePair<GInterface151, int>, GInterface151> func_1;

			// Token: 0x0400F4B2 RID: 62642
			public static Func<KeyValuePair<GInterface151, int>, bool> func_2;

			// Token: 0x0400F4B3 RID: 62643
			public static Func<KeyValuePair<GInterface151, int>, DateTime> func_3;

			// Token: 0x0400F4B4 RID: 62644
			public static Func<KeyValuePair<GInterface151, int>, int> func_4;

			// Token: 0x0400F4B5 RID: 62645
			public static Func<KeyValuePair<GInterface151, int>, bool> func_5;

			// Token: 0x0400F4B6 RID: 62646
			public static Func<GClass1860, int> func_6;

			// Token: 0x0400F4B7 RID: 62647
			public static Func<GClass1860, int> func_7;

			// Token: 0x0400F4B8 RID: 62648
			public static Func<GClass1860, int> func_8;

			// Token: 0x0400F4B9 RID: 62649
			public static Func<GClass2733, int> func_9;

			// Token: 0x0400F4BA RID: 62650
			public static Func<KeyValuePair<ECurrencyType, int>, bool> func_10;

			// Token: 0x0400F4BB RID: 62651
			public static Func<GClass1864, int> func_11;
		}

		// Token: 0x02002F65 RID: 12133
		[CompilerGenerated]
		private sealed class Class3018
		{
			// Token: 0x0600EF78 RID: 61304 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400F4BC RID: 62652
			public Dictionary<ECurrencyType, int> neededAmount;

			// Token: 0x0400F4BD RID: 62653
			public Dictionary<ECurrencyType, int> existingAmount;

			// Token: 0x0400F4BE RID: 62654
			public HandoverRagfairMoneyWindow handoverRagfairMoneyWindow_0;
		}

		// Token: 0x02002F66 RID: 12134
		[CompilerGenerated]
		private sealed class Class3019
		{
			// Token: 0x0600EF79 RID: 61305 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1860 x)
			{
				throw null;
			}

			// Token: 0x0400F4BF RID: 62655
			public ECurrencyType moneyType;
		}

		// Token: 0x02002F67 RID: 12135
		[CompilerGenerated]
		private sealed class Class3020
		{
			// Token: 0x0600EF7A RID: 61306 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1860 x)
			{
				throw null;
			}

			// Token: 0x0400F4C0 RID: 62656
			public Item item;
		}

		// Token: 0x02002F68 RID: 12136
		[CompilerGenerated]
		private sealed class Class3021
		{
			// Token: 0x0600EF7B RID: 61307 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2733 x)
			{
				throw null;
			}

			// Token: 0x0400F4C1 RID: 62657
			public GClass2513.GClass2514 currencyData;
		}
	}
}
