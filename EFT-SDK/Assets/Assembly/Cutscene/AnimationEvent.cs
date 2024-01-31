using System;
using System.Runtime.CompilerServices;

namespace Cutscene
{
	// Token: 0x02000C9B RID: 3227
	[Serializable]
	public class AnimationEvent
	{
		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x00002050 File Offset: 0x00000250
		public float duration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00002050 File Offset: 0x00000250
		public string hint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400502A RID: 20522
		public int stateHash;

		// Token: 0x0400502B RID: 20523
		public float time;

		// Token: 0x0400502C RID: 20524
		public AnimationTrack fire;
	}
}
