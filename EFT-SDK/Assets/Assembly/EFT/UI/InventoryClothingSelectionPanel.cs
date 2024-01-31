using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A24 RID: 10788
	[UsedImplicitly]
	public class InventoryClothingSelectionPanel : UIElement
	{
		// Token: 0x0600D663 RID: 54883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(List<GClass2934> upperSuites, GClass2934 selectedUpperSuite, List<GClass2934> lowerSuites, GClass2934 selectedLowerSuite, Action<GClass2934> onSuiteSelected)
		{
			throw null;
		}

		// Token: 0x0600D664 RID: 54884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(DropDownBox dropdownBox, List<GClass2934> suites, GClass2934 currentSuite)
		{
			throw null;
		}

		// Token: 0x0400D8C9 RID: 55497
		[SerializeField]
		private DropDownBox _upperButtonDropDown;

		// Token: 0x0400D8CA RID: 55498
		[SerializeField]
		private DropDownBox _lowerButtonDropDown;

		// Token: 0x0400D8CB RID: 55499
		private Action<GClass2934> action_0;

		// Token: 0x02002A25 RID: 10789
		[CompilerGenerated]
		private sealed class Class2494
		{
			// Token: 0x0600D665 RID: 54885 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0400D8CC RID: 55500
			public InventoryClothingSelectionPanel inventoryClothingSelectionPanel_0;

			// Token: 0x0400D8CD RID: 55501
			public List<GClass2934> suites;
		}

		// Token: 0x02002A26 RID: 10790
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2495
		{
			// Token: 0x0600D666 RID: 54886 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(GClass2934 x)
			{
				throw null;
			}

			// Token: 0x0400D8CE RID: 55502
			public static readonly InventoryClothingSelectionPanel.Class2495 class2495_0;

			// Token: 0x0400D8CF RID: 55503
			public static Func<GClass2934, string> func_0;
		}
	}
}
