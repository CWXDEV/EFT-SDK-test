using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BBE RID: 11198
	public class DynamicReparentScroll : DynamicScroll
	{
		// Token: 0x0600DCB6 RID: 56502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Enable(DynamicScrollElement scrollElement, EArrangement arrangement)
		{
			throw null;
		}

		// Token: 0x0600DCB7 RID: 56503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Disable(DynamicScrollElement scrollElement, EArrangement arrangement)
		{
			throw null;
		}

		// Token: 0x0400E120 RID: 57632
		[SerializeField]
		private RectTransform _temporaryContainer;

		// Token: 0x0400E121 RID: 57633
		[SerializeField]
		private RectTransform _originalContainer;
	}
}
