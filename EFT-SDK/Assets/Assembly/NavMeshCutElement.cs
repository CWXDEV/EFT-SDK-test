using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200052E RID: 1326
public class NavMeshCutElement : MonoBehaviour
{
	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryCut()
	{
		throw null;
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveFreeToCut()
	{
		throw null;
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInside(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUncutTime()
	{
		throw null;
	}

	// Token: 0x04001EDD RID: 7901
	public NavMeshCutGroup Group;

	// Token: 0x04001EDE RID: 7902
	public NavMeshObstacle Obstacle;

	// Token: 0x04001EDF RID: 7903
	public BoxCollider Collider;

	// Token: 0x04001EE0 RID: 7904
	private float float_0;

	// Token: 0x04001EE1 RID: 7905
	public float CutPeriodSec;
}
