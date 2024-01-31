using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000714 RID: 1812
[DisallowMultipleComponent]
public class UsableHandsPrefab : WeaponPrefab
{
	// Token: 0x06002A28 RID: 10792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CacheInternalObjects()
	{
		throw null;
	}

	// Token: 0x0400285B RID: 10331
	[Header("Bone name for item")]
	public string UsableItemBoneName;

	// Token: 0x0400285C RID: 10332
	public Transform ItemSpawnTransform;
}
