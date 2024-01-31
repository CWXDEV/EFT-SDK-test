using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B1A RID: 11034
	public class MasteringPanel : UIElement
	{
		// Token: 0x0600DADD RID: 56029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(KeyValuePair<string, GClass1764> skill)
		{
			throw null;
		}

		// Token: 0x0400DE1C RID: 56860
		[SerializeField]
		private CustomTextMeshProUGUI _level;

		// Token: 0x0400DE1D RID: 56861
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DE1E RID: 56862
		[SerializeField]
		private CustomTextMeshProUGUI _type;

		// Token: 0x0400DE1F RID: 56863
		[SerializeField]
		private Image _initialProgressFill;

		// Token: 0x0400DE20 RID: 56864
		[SerializeField]
		private MasteringIcon _masteringIcon;

		// Token: 0x0400DE21 RID: 56865
		[SerializeField]
		private Sprite _masteringFillSprite;

		// Token: 0x02002B1B RID: 11035
		[CompilerGenerated]
		private sealed class Class2590
		{
			// Token: 0x0600DADE RID: 56030 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DE22 RID: 56866
			public MasteringPanel masteringPanel_0;

			// Token: 0x0400DE23 RID: 56867
			public KeyValuePair<string, GClass1764> skill;
		}
	}
}
