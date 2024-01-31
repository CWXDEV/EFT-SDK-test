using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02002810 RID: 10256
public static class GClass2987
{
	// Token: 0x0600CD41 RID: 52545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static LayerMask smethod_0(string[] layers)
	{
		throw null;
	}

	// Token: 0x0600CD42 RID: 52546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Warmup()
	{
		throw null;
	}

	// Token: 0x0400CD68 RID: 52584
	public const float PENETRATION_RICOCHET_PENALTY = 0.5f;

	// Token: 0x0400CD69 RID: 52585
	public const float DAMAGE_RICOCHET_PENALTY = 0.5f;

	// Token: 0x0400CD6A RID: 52586
	public const float CHANCE_RICOCHET_PENALTY = 0.2f;

	// Token: 0x0400CD6B RID: 52587
	public const float SPEED_RICOCHET_PENALTY = 0.7f;

	// Token: 0x0400CD6C RID: 52588
	public const float PENETRATION_FRAGMENTATION_PENALTY = 0.5f;

	// Token: 0x0400CD6D RID: 52589
	public const float DAMAGE_FRAGMENTATION_PENALTY = 0.5f;

	// Token: 0x0400CD6E RID: 52590
	public const float CHANCE_FRAGMENTATION_PENALTY = 0.2f;

	// Token: 0x0400CD6F RID: 52591
	public const float SPEED_FRAGMENTATION_PENALTY = 0.7f;

	// Token: 0x0400CD70 RID: 52592
	public const float CHANCE_PENETRATION_PENALTY = 0.2f;

	// Token: 0x0400CD71 RID: 52593
	public const float CHANCE_DEVIATION_PENALTY = 0.08f;

	// Token: 0x0400CD72 RID: 52594
	public const float SPEED_PENETRATION_PENALTY = 0.8f;

	// Token: 0x0400CD73 RID: 52595
	private static readonly string[] string_0;

	// Token: 0x0400CD74 RID: 52596
	private static readonly string[] string_1;

	// Token: 0x0400CD75 RID: 52597
	private static readonly string[] string_2;

	// Token: 0x0400CD76 RID: 52598
	private static readonly string[] string_3;

	// Token: 0x0400CD77 RID: 52599
	public static LayerMask StaticObjectsHitMask;

	// Token: 0x0400CD78 RID: 52600
	public static LayerMask HitMask;

	// Token: 0x0400CD79 RID: 52601
	public static LayerMask SpiritHitMask;

	// Token: 0x0400CD7A RID: 52602
	public static LayerMask SpiritHitMaskSecondPass;

	// Token: 0x0400CD7B RID: 52603
	public static LayerMask PlayerLayer;

	// Token: 0x0400CD7C RID: 52604
	public static LayerMask PlayerSpiritAuraLayer;

	// Token: 0x0400CD7D RID: 52605
	public static LayerMask PlayerSpiritAuraLayerMask;

	// Token: 0x0400CD7E RID: 52606
	public static LayerMask PlayerMask;
}
