using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02001F8C RID: 8076
public class GClass2307
{
	// Token: 0x0600A742 RID: 42818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShotMatches(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider)
	{
		throw null;
	}

	// Token: 0x0400AE71 RID: 44657
	public string itemID;

	// Token: 0x0400AE72 RID: 44658
	public EArmorType armorType;

	// Token: 0x0400AE73 RID: 44659
	public float maxDurability;

	// Token: 0x0400AE74 RID: 44660
	public float durability;

	// Token: 0x0400AE75 RID: 44661
	public int templateDurability;

	// Token: 0x0400AE76 RID: 44662
	public List<EBodyPartColliderType> armorColliders;

	// Token: 0x0400AE77 RID: 44663
	public EArmorPlateCollider armorPlateColliderMask;

	// Token: 0x0400AE78 RID: 44664
	public Vector3 ricochetValues;

	// Token: 0x0400AE79 RID: 44665
	public int armorClass;

	// Token: 0x0400AE7A RID: 44666
	public MaterialType material;

	// Token: 0x0400AE7B RID: 44667
	public bool isComposite;

	// Token: 0x0400AE7C RID: 44668
	public bool isToggeldAndOff;
}
