using System;
using EFT.Ballistics;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200224C RID: 8780
public interface GInterface280 : GInterface282
{
	// Token: 0x17001E03 RID: 7683
	// (get) Token: 0x0600B2FD RID: 45821
	EBodyPartColliderType[] ArmorColliders { get; }

	// Token: 0x17001E04 RID: 7684
	// (get) Token: 0x0600B2FE RID: 45822
	EArmorPlateCollider ArmorPlateColliders { get; }

	// Token: 0x17001E05 RID: 7685
	// (get) Token: 0x0600B2FF RID: 45823
	int ArmorClass { get; }

	// Token: 0x17001E06 RID: 7686
	// (get) Token: 0x0600B300 RID: 45824
	MaterialType Material { get; }

	// Token: 0x17001E07 RID: 7687
	// (get) Token: 0x0600B301 RID: 45825
	EDeafStrength Deaf { get; }

	// Token: 0x17001E08 RID: 7688
	// (get) Token: 0x0600B302 RID: 45826
	float BluntThroughput { get; }

	// Token: 0x17001E09 RID: 7689
	// (get) Token: 0x0600B303 RID: 45827
	Vector3 RicochetVals { get; }

	// Token: 0x17001E0A RID: 7690
	// (get) Token: 0x0600B304 RID: 45828
	EArmorMaterial ArmorMaterial { get; }

	// Token: 0x17001E0B RID: 7691
	// (get) Token: 0x0600B305 RID: 45829
	EArmorType ArmorType { get; }
}
