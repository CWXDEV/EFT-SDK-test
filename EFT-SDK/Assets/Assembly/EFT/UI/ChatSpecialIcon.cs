using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028D9 RID: 10457
	public sealed class ChatSpecialIcon : UIElement
	{
		// Token: 0x0600D0D7 RID: 53463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EMemberCategory category, string playerName = null)
		{
			throw null;
		}

		// Token: 0x0400D1A9 RID: 53673
		[SerializeField]
		private CustomTextMeshProUGUI _specialLabel;

		// Token: 0x0400D1AA RID: 53674
		[SerializeField]
		private Image _icon;

		// Token: 0x0400D1AB RID: 53675
		private ChatSpecialIconSettings chatSpecialIconSettings_0;
	}
}
