using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200293E RID: 10558
	public class RequiredSkillOrLevel : UIElement
	{
		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x0600D2B1 RID: 53937 RVA: 0x00002050 File Offset: 0x00000250
		public TMP_Text Text
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D2B2 RID: 53938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string text, bool available, Sprite icon = null, float textWidth = -1f)
		{
			throw null;
		}

		// Token: 0x0400D431 RID: 54321
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x0400D432 RID: 54322
		[SerializeField]
		private Image _icon;

		// Token: 0x0400D433 RID: 54323
		[SerializeField]
		private Color _goodColor;

		// Token: 0x0400D434 RID: 54324
		[SerializeField]
		private Color _badColor;
	}
}
