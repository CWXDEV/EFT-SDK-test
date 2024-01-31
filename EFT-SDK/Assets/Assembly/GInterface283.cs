using System;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200226A RID: 8810
public interface GInterface283 : IItemTemplate
{
	// Token: 0x17001E39 RID: 7737
	// (get) Token: 0x0600B39A RID: 45978
	float FuzeArmTimeSec { get; }

	// Token: 0x17001E3A RID: 7738
	// (get) Token: 0x0600B39B RID: 45979
	float MinExplosionDistance { get; }

	// Token: 0x17001E3B RID: 7739
	// (get) Token: 0x0600B39C RID: 45980
	float MaxExplosionDistance { get; }

	// Token: 0x17001E3C RID: 7740
	// (get) Token: 0x0600B39D RID: 45981
	int FragmentsCount { get; }

	// Token: 0x17001E3D RID: 7741
	// (get) Token: 0x0600B39E RID: 45982
	string FragmentType { get; }

	// Token: 0x17001E3E RID: 7742
	// (get) Token: 0x0600B39F RID: 45983
	string ExplosionType { get; }

	// Token: 0x17001E3F RID: 7743
	// (get) Token: 0x0600B3A0 RID: 45984
	float ExplosionStrength { get; }

	// Token: 0x17001E40 RID: 7744
	// (get) Token: 0x0600B3A1 RID: 45985
	bool ShowHitEffectOnExplode { get; }

	// Token: 0x17001E41 RID: 7745
	// (get) Token: 0x0600B3A2 RID: 45986
	Vector3 ArmorDistanceDistanceDamage { get; }

	// Token: 0x17001E42 RID: 7746
	// (get) Token: 0x0600B3A3 RID: 45987
	Vector3 Contusion { get; }

	// Token: 0x17001E43 RID: 7747
	// (get) Token: 0x0600B3A4 RID: 45988
	Vector3 Blindness { get; }

	// Token: 0x17001E44 RID: 7748
	// (get) Token: 0x0600B3A5 RID: 45989
	bool GrenadeComponentIsDummy { get; }
}
