using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020001EF RID: 495
public class DebugCoverSystemTester : MonoBehaviour
{
	// Token: 0x06000905 RID: 2309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<Vector3> CarePositions()
	{
		throw null;
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyInfo GetGoalEnemy()
	{
		throw null;
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoFind()
	{
		throw null;
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintLastInfo()
	{
		throw null;
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(CustomNavigationPoint point, NavGraphFindDebug debug, ESearchCoverEngine coverengine)
	{
		throw null;
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x0400096B RID: 2411
	public float MaxShootDist;

	// Token: 0x0400096C RID: 2412
	public WildSpawnType WildSpawnType;

	// Token: 0x0400096D RID: 2413
	public List<Transform> CarePos;

	// Token: 0x0400096E RID: 2414
	public Transform ShotPos;

	// Token: 0x0400096F RID: 2415
	public bool DrawLast;

	// Token: 0x04000970 RID: 2416
	public ESearchCoverEngine SearchToDraw;

	// Token: 0x04000971 RID: 2417
	public bool UseLineCastToCover;

	// Token: 0x04000972 RID: 2418
	public bool RefreshWayBlockerTester;

	// Token: 0x04000973 RID: 2419
	public int StepConstrain;

	// Token: 0x04000974 RID: 2420
	public float RadiusConstrain;

	// Token: 0x04000975 RID: 2421
	public CoverShootType ShootType;

	// Token: 0x04000976 RID: 2422
	private GClass338 gclass338_0;

	// Token: 0x04000977 RID: 2423
	private readonly Dictionary<ESearchCoverEngine, NavGraphFindDebug> dictionary_0;
}
