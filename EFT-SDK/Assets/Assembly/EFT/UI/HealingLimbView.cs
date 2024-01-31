using System;
using System.Runtime.CompilerServices;
using EFT.UI.Health;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200289C RID: 10396
	public class HealingLimbView : UIElement
	{
		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x0600CFB4 RID: 53172 RVA: 0x00002050 File Offset: 0x00000250
		public BodyPartView BodyPartView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBackgroundColor(Color color)
		{
			throw null;
		}

		// Token: 0x0400D072 RID: 53362
		[SerializeField]
		private BodyPartView _bodyPartView;

		// Token: 0x0400D073 RID: 53363
		[SerializeField]
		private Image _background;
	}
}
