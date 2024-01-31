using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000884 RID: 2180
public class BrokenDoor : MonoBehaviour
{
	// Token: 0x06003126 RID: 12582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BreachQuick()
	{
		throw null;
	}

	// Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Breach(Vector3 playerPosition)
	{
		throw null;
	}

	// Token: 0x0600312A RID: 12586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0()
	{
		throw null;
	}

	// Token: 0x04003241 RID: 12865
	public Rigidbody[] Splinters;

	// Token: 0x04003242 RID: 12866
	public Vector3 ExplosionCenter;

	// Token: 0x04003243 RID: 12867
	public ParticleSystem VFX;

	// Token: 0x04003244 RID: 12868
	[Header("Turned ON when breaking door")]
	public GameObject[] On;

	// Token: 0x04003245 RID: 12869
	[Header("Turned OFF when breaking door")]
	public GameObject[] Off;

	// Token: 0x04003246 RID: 12870
	public Collider[] IgnoreColliders;
}
