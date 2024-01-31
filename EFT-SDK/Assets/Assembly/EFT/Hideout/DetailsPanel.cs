using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001BA2 RID: 7074
	public class DetailsPanel : UIElement
	{
		// Token: 0x060094D3 RID: 38099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIcon(Sprite icon)
		{
			throw null;
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBackgroundColor(Color color)
		{
			throw null;
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetText(string text)
		{
			throw null;
		}

		// Token: 0x04009BA4 RID: 39844
		[SerializeField]
		private Image _colorPanel;

		// Token: 0x04009BA5 RID: 39845
		[SerializeField]
		private Image _detailsIcon;

		// Token: 0x04009BA6 RID: 39846
		[SerializeField]
		private TextMeshProUGUI _detailsStatus;
	}
}
