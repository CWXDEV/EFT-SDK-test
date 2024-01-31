using System;
using System.Runtime.CompilerServices;
using uLipSync;
using UnityEngine;

namespace Cutscene
{
	// Token: 0x02000CA3 RID: 3235
	[CreateAssetMenu(menuName = "uLipSync/Backed data with random variants")]
	public class LipSyncBackedDataRandomVariants : ScriptableObject
	{
		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x00002050 File Offset: 0x00000250
		public BakedData[] BakedData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04005044 RID: 20548
		[SerializeField]
		private BakedData[] bakedData;
	}
}
