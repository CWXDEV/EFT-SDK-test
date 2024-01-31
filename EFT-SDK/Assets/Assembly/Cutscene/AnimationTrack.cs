using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using uLipSync;

namespace Cutscene
{
	// Token: 0x02000C9C RID: 3228
	[Serializable]
	public class AnimationTrack
	{
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x00002050 File Offset: 0x00000250
		public bool HaveData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00002050 File Offset: 0x00000250
		public float duration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x00002050 File Offset: 0x00000250
		public string hint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakedData GetBackedDataForPlay()
		{
			throw null;
		}

		// Token: 0x0400502D RID: 20525
		public BakedData lipSyncBackedData;

		// Token: 0x0400502E RID: 20526
		public LipSyncBackedDataRandomVariants lipSyncBackedDataRandomRange;

		// Token: 0x0400502F RID: 20527
		private List<BakedData> randomLipSyncData;

		// Token: 0x04005030 RID: 20528
		private BakedData selectedLipSyncData;
	}
}
