using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BD3 RID: 11219
	public sealed class RankPanel : UIElement
	{
		// Token: 0x0600DD34 RID: 56628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int rankLevel, int maxRank)
		{
			throw null;
		}

		// Token: 0x0400E193 RID: 57747
		[SerializeField]
		private CustomTextMeshProUGUI _rank;

		// Token: 0x0400E194 RID: 57748
		[SerializeField]
		private GameObject _eliteRank;
	}
}
