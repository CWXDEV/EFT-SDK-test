using System;

namespace EFT
{
	// Token: 0x020015AA RID: 5546
	[Flags]
	public enum EPhysicalCondition
	{
		// Token: 0x04007D11 RID: 32017
		None = 0,
		// Token: 0x04007D12 RID: 32018
		OnPainkillers = 1,
		// Token: 0x04007D13 RID: 32019
		LeftLegDamaged = 2,
		// Token: 0x04007D14 RID: 32020
		RightLegDamaged = 4,
		// Token: 0x04007D15 RID: 32021
		ProneDisabled = 8,
		// Token: 0x04007D16 RID: 32022
		LeftArmDamaged = 16,
		// Token: 0x04007D17 RID: 32023
		RightArmDamaged = 32,
		// Token: 0x04007D18 RID: 32024
		Tremor = 64,
		// Token: 0x04007D19 RID: 32025
		UsingMeds = 128,
		// Token: 0x04007D1A RID: 32026
		HealingLegs = 256,
		// Token: 0x04007D1B RID: 32027
		JumpDisabled = 512,
		// Token: 0x04007D1C RID: 32028
		SprintDisabled = 1024,
		// Token: 0x04007D1D RID: 32029
		ProneMovementDisabled = 2048,
		// Token: 0x04007D1E RID: 32030
		Panic = 4096
	}
}
