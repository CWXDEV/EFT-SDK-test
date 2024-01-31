using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B47 RID: 11079
	public sealed class SkillClassIcon : UIElement
	{
		// Token: 0x0600DB5B RID: 56155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(ESkillClass skillClass)
		{
			throw null;
		}

		// Token: 0x0400DEEF RID: 57071
		[SerializeField]
		private Image _background;

		// Token: 0x0400DEF0 RID: 57072
		[SerializeField]
		private CustomTextMeshProUGUI _symbol;

		// Token: 0x0400DEF1 RID: 57073
		private static readonly Dictionary<ESkillClass, Color> dictionary_0;

		// Token: 0x0400DEF2 RID: 57074
		private static readonly Dictionary<ESkillClass, string> dictionary_1;
	}
}
