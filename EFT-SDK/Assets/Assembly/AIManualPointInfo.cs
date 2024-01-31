using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000211 RID: 529
public class AIManualPointInfo : MonoBehaviour
{
	// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(GroupPoint c)
	{
		throw null;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCllidersToTrigers()
	{
		throw null;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAlwaysDraw(bool alwaysDraw)
	{
		throw null;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveByExcutableColiders<T>(List<T> coreList, BoxCollider[] colliders) where T : IPositionPoint
	{
		throw null;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(List<GroupPoint> coreList, List<GroupPoint> mergedList)
	{
		throw null;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x04000AC9 RID: 2761
	public const int MANUAL_ZONE_START_ID = 100000;

	// Token: 0x04000ACA RID: 2762
	public bool _alwaysDraw;

	// Token: 0x04000ACB RID: 2763
	public bool DrawWithEdges;

	// Token: 0x04000ACC RID: 2764
	public bool DrawWithCore;

	// Token: 0x04000ACD RID: 2765
	public float MinDefenceLevelToDraw;

	// Token: 0x04000ACE RID: 2766
	public BoxCollider[] ExcludableColliders;

	// Token: 0x04000ACF RID: 2767
	public List<GroupPoint> Points;
}
