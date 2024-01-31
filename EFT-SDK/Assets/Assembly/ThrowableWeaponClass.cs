using System;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200243E RID: 9278
public class ThrowableWeaponClass : ItemTemplate
{
	// Token: 0x0400BCFE RID: 48382
	public ThrowWeapType ThrowType;

	// Token: 0x0400BCFF RID: 48383
	public float ExplDelay;

	// Token: 0x0400BD00 RID: 48384
	public float MinExplosionDistance;

	// Token: 0x0400BD01 RID: 48385
	public float MaxExplosionDistance;

	// Token: 0x0400BD02 RID: 48386
	public int FragmentsCount;

	// Token: 0x0400BD03 RID: 48387
	public float MinFragmentDamage;

	// Token: 0x0400BD04 RID: 48388
	public float MaxFragmentDamage;

	// Token: 0x0400BD05 RID: 48389
	public float Strength;

	// Token: 0x0400BD06 RID: 48390
	public string FragmentType;

	// Token: 0x0400BD07 RID: 48391
	public Vector3 Blindness;

	// Token: 0x0400BD08 RID: 48392
	public Vector3 Contusion;

	// Token: 0x0400BD09 RID: 48393
	public int EmitTime;

	// Token: 0x0400BD0A RID: 48394
	public bool CanBeHiddenDuringThrow;

	// Token: 0x0400BD0B RID: 48395
	public Vector3 ArmorDistanceDistanceDamage;

	// Token: 0x0400BD0C RID: 48396
	public float MinTimeToContactExplode;

	// Token: 0x0400BD0D RID: 48397
	public string ExplosionEffectType;
}
