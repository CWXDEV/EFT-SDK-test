using System;
using System.Runtime.InteropServices;
using EFT;
using EFT.NetworkPackets;

// Token: 0x020020A5 RID: 8357
[StructLayout(LayoutKind.Auto)]
public struct GStruct316
{
	// Token: 0x0400B347 RID: 45895
	public EDamageType DamageType;

	// Token: 0x0400B348 RID: 45896
	public int Damage;

	// Token: 0x0400B349 RID: 45897
	public int Absorbed;

	// Token: 0x0400B34A RID: 45898
	public EBodyPart Part;

	// Token: 0x0400B34B RID: 45899
	public EHitSpecial Special;

	// Token: 0x0400B34C RID: 45900
	public int StaminaLoss;
}
