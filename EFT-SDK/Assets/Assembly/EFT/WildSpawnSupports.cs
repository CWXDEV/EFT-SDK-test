using System;
using System.Runtime.CompilerServices;

namespace EFT
{
	// Token: 0x020015EB RID: 5611
	[Serializable]
	public class WildSpawnSupports
	{
		// Token: 0x06007A6B RID: 31339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WildSpawnSupports Copy()
		{
			throw null;
		}

		// Token: 0x04007F0A RID: 32522
		public WildSpawnType BossEscortType;

		// Token: 0x04007F0B RID: 32523
		public int BossEscortAmount;

		// Token: 0x04007F0C RID: 32524
		public string[] BossEscortDifficult;
	}
}
