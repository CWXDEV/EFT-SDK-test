using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002782 RID: 10114
	[DisallowMultipleComponent]
	public class LootableContainersGroup : MonoBehaviour
	{
		// Token: 0x0600CAA4 RID: 51876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0400CABB RID: 51899
		public string Id;

		// Token: 0x0400CABC RID: 51900
		public int Min;

		// Token: 0x0400CABD RID: 51901
		public int Max;
	}
}
