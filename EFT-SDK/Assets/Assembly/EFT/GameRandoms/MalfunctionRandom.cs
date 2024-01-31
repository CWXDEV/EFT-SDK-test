using System;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace EFT.GameRandoms
{
	// Token: 0x020027FD RID: 10237
	public class MalfunctionRandom
	{
		// Token: 0x0600CCF9 RID: 52473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetRandomFloat()
		{
			throw null;
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetNextRandom()
		{
			throw null;
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0400CD34 RID: 52532
		private int _seed;

		// Token: 0x0400CD35 RID: 52533
		private int _nextSeed;
	}
}
