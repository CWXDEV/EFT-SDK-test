using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006F9 RID: 1785
[DisallowMultipleComponent]
public class GrenadePrefab : WeaponPrefab
{
	// Token: 0x060029C6 RID: 10694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReturnToPool()
	{
		throw null;
	}

	// Token: 0x040027E1 RID: 10209
	[Header("Element 0 defines grenade initial position!")]
	public string[] ThrowingParts;

	// Token: 0x040027E2 RID: 10210
	public GrenadeSettings GrenadeItself;
}
