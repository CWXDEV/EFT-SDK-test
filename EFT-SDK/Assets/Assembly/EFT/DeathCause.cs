using System;

namespace EFT
{
	// Token: 0x020015FD RID: 5629
	[Serializable]
	public sealed class DeathCause
	{
		// Token: 0x04007F84 RID: 32644
		public EDamageType DamageType;

		// Token: 0x04007F85 RID: 32645
		public EPlayerSide Side;

		// Token: 0x04007F86 RID: 32646
		public WildSpawnType Role;

		// Token: 0x04007F87 RID: 32647
		public string WeaponId;
	}
}
