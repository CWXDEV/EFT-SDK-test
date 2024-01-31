using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using UnityEngine;

namespace EFT.ProfileEditor.UI
{
	// Token: 0x02001DA6 RID: 7590
	public sealed class EquipmentItemPanel : UIElement
	{
		// Token: 0x06009C6F RID: 40047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string profileName, Item[] items, Action<Item> onItemSelected)
		{
			throw null;
		}

		// Token: 0x0400A3B4 RID: 41908
		[SerializeField]
		private DropDownBox _dropDown;

		// Token: 0x0400A3B5 RID: 41909
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x02001DA7 RID: 7591
		[CompilerGenerated]
		private sealed class Class1773
		{
			// Token: 0x06009C70 RID: 40048 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int selectedIndex)
			{
				throw null;
			}

			// Token: 0x0400A3B6 RID: 41910
			public Action<Item> onItemSelected;

			// Token: 0x0400A3B7 RID: 41911
			public Item[] items;
		}

		// Token: 0x02001DA8 RID: 7592
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1774
		{
			// Token: 0x06009C71 RID: 40049 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(Item x)
			{
				throw null;
			}

			// Token: 0x0400A3B8 RID: 41912
			public static readonly EquipmentItemPanel.Class1774 class1774_0;

			// Token: 0x0400A3B9 RID: 41913
			public static Func<Item, string> func_0;
		}
	}
}
