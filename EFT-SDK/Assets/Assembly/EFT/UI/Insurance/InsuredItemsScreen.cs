using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI.Insurance
{
	// Token: 0x02002EDC RID: 11996
	public class InsuredItemsScreen : UIElement
	{
		// Token: 0x0600ECD2 RID: 60626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600ECD3 RID: 60627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400F1D4 RID: 61908
		[SerializeField]
		private TextMeshProUGUI _insuredItemsCount;

		// Token: 0x0400F1D5 RID: 61909
		[SerializeField]
		private InsuredItemPanel _insuredItemPanel;

		// Token: 0x0400F1D6 RID: 61910
		[SerializeField]
		private RectTransform _insuredItemsContainer;

		// Token: 0x0400F1D7 RID: 61911
		private GClass3079<ItemClass, InsuredItemPanel> gclass3079_0;

		// Token: 0x0400F1D8 RID: 61912
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x02002EDD RID: 11997
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2953
		{
			// Token: 0x0600ECD4 RID: 60628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ItemClass item, InsuredItemPanel view)
			{
				throw null;
			}

			// Token: 0x0400F1D9 RID: 61913
			public static readonly InsuredItemsScreen.Class2953 class2953_0;

			// Token: 0x0400F1DA RID: 61914
			public static Action<ItemClass, InsuredItemPanel> action_0;
		}
	}
}
