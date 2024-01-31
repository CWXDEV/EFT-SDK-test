using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x02000C64 RID: 3172
	public class LocalizedFilterButton : UIElement
	{
		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x00002050 File Offset: 0x00000250
		public string LocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x00002050 File Offset: 0x00000250
		public Button.ButtonClickedEvent OnClick
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04004F10 RID: 20240
		[SerializeField]
		private Button _button;

		// Token: 0x04004F11 RID: 20241
		[SerializeField]
		private string _localizationKey;
	}
}
