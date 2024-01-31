using System;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200156F RID: 5487
	public interface IExplosiveItem
	{
		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060075AD RID: 30125
		Vector3 Blindness { get; }

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060075AE RID: 30126
		Vector3 Contusion { get; }

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060075AF RID: 30127
		Vector3 ArmorDistanceDistanceDamage { get; }

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060075B0 RID: 30128
		float MinExplosionDistance { get; }

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060075B1 RID: 30129
		float MaxExplosionDistance { get; }

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060075B2 RID: 30130
		int FragmentsCount { get; }

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060075B3 RID: 30131
		float GetStrength { get; }

		// Token: 0x060075B4 RID: 30132
		BulletClass CreateFragment();

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060075B5 RID: 30133
		bool IsDummy { get; }
	}
}
