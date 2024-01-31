using System;
using System.Runtime.CompilerServices;
using EFT.Console.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002891 RID: 10385
	public class ConsoleAutoCompleteItem : MonoBehaviour
	{
		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600CF43 RID: 53059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF44 RID: 53060 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600CF45 RID: 53061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(AutoCompleteItem item)
		{
			throw null;
		}

		// Token: 0x0400D02F RID: 53295
		[SerializeField]
		private Color _activeColor;

		// Token: 0x0400D030 RID: 53296
		[SerializeField]
		private Color _inactiveColor;

		// Token: 0x0400D031 RID: 53297
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x0400D032 RID: 53298
		[SerializeField]
		private Image _background;

		// Token: 0x0400D033 RID: 53299
		private bool bool_0;
	}
}
