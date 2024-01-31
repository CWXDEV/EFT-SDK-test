using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FAB RID: 12203
	public class PageButton : UIElement
	{
		// Token: 0x0600F0E6 RID: 61670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F0E7 RID: 61671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(bool pageSelected, int page, Action<int> onClick)
		{
			throw null;
		}

		// Token: 0x0600F0E8 RID: 61672 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400F6C8 RID: 63176
		[SerializeField]
		private Image _buttonImage;

		// Token: 0x0400F6C9 RID: 63177
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0400F6CA RID: 63178
		[SerializeField]
		private Color _nonSelectedColor;

		// Token: 0x0400F6CB RID: 63179
		[SerializeField]
		private Button _button;

		// Token: 0x0400F6CC RID: 63180
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400F6CD RID: 63181
		private bool bool_0;

		// Token: 0x0400F6CE RID: 63182
		private int int_0;

		// Token: 0x0400F6CF RID: 63183
		private Action<int> action_0;
	}
}
