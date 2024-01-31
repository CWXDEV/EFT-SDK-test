using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x02002249 RID: 8777
	[Serializable]
	public sealed class BackendIdGenerator
	{
		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x0600B2F9 RID: 45817 RVA: 0x00002050 File Offset: 0x00000250
		public MongoID NextId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B2FA RID: 45818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RollBack()
		{
			throw null;
		}

		// Token: 0x0400B76E RID: 46958
		private readonly List<MongoID> _idCache;

		// Token: 0x0400B76F RID: 46959
		private int _idIndex;

		// Token: 0x0400B770 RID: 46960
		private readonly Profile _profile;
	}
}
