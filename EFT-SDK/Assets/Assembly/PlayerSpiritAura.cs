using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200074E RID: 1870
public class PlayerSpiritAura : MonoBehaviour
{
	// Token: 0x06002C32 RID: 11314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBounds(Bounds localBounds)
	{
		throw null;
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Collider GetCollider()
	{
		throw null;
	}

	// Token: 0x04002AAF RID: 10927
	[SerializeField]
	private BoxCollider _collider;

	// Token: 0x04002AB0 RID: 10928
	[SerializeField]
	private float _boundsExpand;
}
