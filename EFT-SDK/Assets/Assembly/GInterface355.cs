using System;
using System.Collections.Generic;
using EFT.Ballistics;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200280C RID: 10252
public interface GInterface355
{
	// Token: 0x0600CD1F RID: 52511
	GClass2988 Shoot(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, string playerProfileID, Item item, float speedFactor, int fragmentIndex);

	// Token: 0x0600CD20 RID: 52512
	void ShotMultiProjectileShot(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, float speedFactor, List<GClass2988> preAllocatedShots, string playerProfileID, Item item);

	// Token: 0x0600CD21 RID: 52513
	GClass2988 Shoot(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, int fireIndex, string playerProfileID, Item item, float speedFactor, int fragmentIndex);

	// Token: 0x0600CD22 RID: 52514
	void ManualUpdate(float deltaTime);

	// Token: 0x1700249C RID: 9372
	// (get) Token: 0x0600CD23 RID: 52515
	int ActiveShotsCount { get; }

	// Token: 0x0600CD24 RID: 52516
	GClass2988 GetActiveShot(int shotsIndex);

	// Token: 0x0600CD25 RID: 52517
	void ClearShots();

	// Token: 0x1700249D RID: 9373
	// (get) Token: 0x0600CD26 RID: 52518
	BallisticCollider DefaultHitBody { get; }
}
