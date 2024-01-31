using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200086C RID: 2156
public class CoverSearchDebug : MonoBehaviour
{
	// Token: 0x1700086C RID: 2156
	// (get) Token: 0x060030EA RID: 12522 RVA: 0x00002050 File Offset: 0x00000250
	public List<CoverSearchDebugIteration> CoverSearchIterations
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessAddNearGroups(HashSet<CustomNavigationPoint> nearGroups, int level, Vector3 centerPos, float sqrRadius, string searchLabel)
	{
		throw null;
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResultCover(CustomNavigationPoint point)
	{
		throw null;
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x040031BF RID: 12735
	public static CoverSearchDebug Instance;

	// Token: 0x040031C0 RID: 12736
	[SerializeField]
	private List<CoverSearchDebugIteration> _coverSearchIterations;

	// Token: 0x040031C1 RID: 12737
	private GClass322 gclass322_0;
}
