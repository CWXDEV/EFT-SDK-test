using System;
using EFT.InventoryLogic;

// Token: 0x020024CE RID: 9422
public interface GInterface320
{
	// Token: 0x17002199 RID: 8601
	// (get) Token: 0x0600BCAE RID: 48302
	float Weight { get; }

	// Token: 0x1700219A RID: 8602
	// (get) Token: 0x0600BCAF RID: 48303
	float RecoilForceBack { get; }

	// Token: 0x1700219B RID: 8603
	// (get) Token: 0x0600BCB0 RID: 48304
	float RecoilBase { get; }

	// Token: 0x1700219C RID: 8604
	// (get) Token: 0x0600BCB1 RID: 48305
	float SpeedFactor { get; }

	// Token: 0x1700219D RID: 8605
	// (get) Token: 0x0600BCB2 RID: 48306
	bool IsUnderbarrelWeapon { get; }

	// Token: 0x1700219E RID: 8606
	// (get) Token: 0x0600BCB3 RID: 48307
	float RecoilDelta { get; }

	// Token: 0x1700219F RID: 8607
	// (get) Token: 0x0600BCB4 RID: 48308
	Weapon.GClass2738 MalfState { get; }

	// Token: 0x0600BCB5 RID: 48309
	int GetCurrentMagazineCount();

	// Token: 0x170021A0 RID: 8608
	// (get) Token: 0x0600BCB6 RID: 48310
	Item Item { get; }

	// Token: 0x170021A1 RID: 8609
	// (get) Token: 0x0600BCB7 RID: 48311
	WeaponTemplate WeaponTemplate { get; }

	// Token: 0x170021A2 RID: 8610
	// (get) Token: 0x0600BCB8 RID: 48312
	Slot[] Chambers { get; }
}
