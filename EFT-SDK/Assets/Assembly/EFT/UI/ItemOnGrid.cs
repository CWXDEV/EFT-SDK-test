using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B85 RID: 11141
	public class ItemOnGrid : UIElement
	{
		// Token: 0x0600DC01 RID: 56321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Item item, bool correctSize = true, bool examined = true)
		{
			throw null;
		}

		// Token: 0x0400DFFD RID: 57341
		[SerializeField]
		protected Image Icon;

		// Token: 0x02002B86 RID: 11142
		[CompilerGenerated]
		private sealed class Class2638
		{
			// Token: 0x0600DC02 RID: 56322 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DFFE RID: 57342
			public ItemOnGrid itemOnGrid_0;

			// Token: 0x0400DFFF RID: 57343
			public GClass818 itemIcon;

			// Token: 0x0400E000 RID: 57344
			public bool examined;
		}
	}
}
