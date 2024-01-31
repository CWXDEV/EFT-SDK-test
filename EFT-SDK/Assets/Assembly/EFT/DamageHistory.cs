using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT
{
	// Token: 0x020015FC RID: 5628
	[Serializable]
	public sealed class DamageHistory
	{
		// Token: 0x06007A76 RID: 31350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x04007F81 RID: 32641
		public EBodyPart LethalDamagePart;

		// Token: 0x04007F82 RID: 32642
		public DamageStats LethalDamage;

		// Token: 0x04007F83 RID: 32643
		public Dictionary<EBodyPart, List<DamageStats>> BodyParts;
	}
}
