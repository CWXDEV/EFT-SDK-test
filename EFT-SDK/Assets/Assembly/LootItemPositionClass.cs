using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02000FCF RID: 4047
public class LootItemPositionClass
{
	// Token: 0x06005529 RID: 21801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LootItemPositionClass Clone()
	{
		throw null;
	}

	// Token: 0x040060AA RID: 24746
	public string Id;

	// Token: 0x040060AB RID: 24747
	public Vector3 Position;

	// Token: 0x040060AC RID: 24748
	public Vector3 Rotation;

	// Token: 0x040060AD RID: 24749
	public Item Item;

	// Token: 0x040060AE RID: 24750
	public string[] ValidProfiles;

	// Token: 0x040060AF RID: 24751
	public bool IsContainer;

	// Token: 0x040060B0 RID: 24752
	public bool useGravity;

	// Token: 0x040060B1 RID: 24753
	public bool randomRotation;

	// Token: 0x040060B2 RID: 24754
	public Vector3 Shift;

	// Token: 0x040060B3 RID: 24755
	public short PlatformId;
}
