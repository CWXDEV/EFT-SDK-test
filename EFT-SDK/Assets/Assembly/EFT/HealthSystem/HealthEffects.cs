using System;
using System.Collections.Generic;

namespace EFT.HealthSystem
{
	// Token: 0x020021C1 RID: 8641
	public sealed class HealthEffects
	{
		// Token: 0x0400B619 RID: 46617
		public Dictionary<EBodyPart, Dictionary<string, float>> Effects;

		// Token: 0x0400B61A RID: 46618
		public float Hydration;

		// Token: 0x0400B61B RID: 46619
		public float Energy;
	}
}
