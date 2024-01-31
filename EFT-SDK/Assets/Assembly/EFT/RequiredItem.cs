using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT
{
	// Token: 0x0200196E RID: 6510
	public class RequiredItem : UIElement
	{
		// Token: 0x06008BA5 RID: 35749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2941 requirement, Func<bool> available, Sprite sprite)
		{
			throw null;
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView()
		{
			throw null;
		}

		// Token: 0x04009141 RID: 37185
		private const string string_0 = " ";

		// Token: 0x04009142 RID: 37186
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04009143 RID: 37187
		[SerializeField]
		private Image _image;

		// Token: 0x04009144 RID: 37188
		[SerializeField]
		private Color _normalColor;

		// Token: 0x04009145 RID: 37189
		[SerializeField]
		private Color _badColor;

		// Token: 0x04009146 RID: 37190
		private NumberFormatInfo numberFormatInfo_0;

		// Token: 0x04009147 RID: 37191
		private GClass2941 gclass2941_0;

		// Token: 0x04009148 RID: 37192
		private Func<bool> func_0;

		// Token: 0x04009149 RID: 37193
		private Sprite sprite_0;
	}
}
