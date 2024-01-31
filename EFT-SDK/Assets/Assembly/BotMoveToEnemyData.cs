using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000402 RID: 1026
public class BotMoveToEnemyData : GClass362
{
	// Token: 0x060018A7 RID: 6311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryMoveToEnemy(Vector3 targetPoint)
	{
		throw null;
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallRecalWay(out Vector3 lastPos)
	{
		throw null;
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Vector3 shootTargetPoint, out Vector3 curTargetPos)
	{
		throw null;
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanMoveTo(Vector3 position)
	{
		throw null;
	}

	// Token: 0x04001560 RID: 5472
	private const float SDIST_TOO_CLOSE = 4f;

	// Token: 0x04001561 RID: 5473
	private const float SMAPLE_DIST = 2.6f;

	// Token: 0x04001562 RID: 5474
	private const float TOOFAR_BASE_PATH_DIST = 2f;

	// Token: 0x04001563 RID: 5475
	private NavMeshPath _path;
}
