using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A03 RID: 6659
	public class LegsView : MonoBehaviour
	{
		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06008D7F RID: 36223 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsRightLegHolster
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHolster(PlayerBody playerBody)
		{
			throw null;
		}

		// Token: 0x040093E1 RID: 37857
		[SerializeField]
		private bool _isRightLeg;

		// Token: 0x040093E2 RID: 37858
		[SerializeField]
		private Transform _holster;
	}
}
