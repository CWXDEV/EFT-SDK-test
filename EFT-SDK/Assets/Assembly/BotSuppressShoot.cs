using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200046C RID: 1132
public class BotSuppressShoot : GClass441
{
	// Token: 0x06001B56 RID: 6998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Init(EnemyInfo enemyToSupress, CustomNavigationPoint pos = null)
	{
		throw null;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InitToPoint(Vector3 point, CustomNavigationPoint pos = null)
	{
		throw null;
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InitToPoints(List<Vector3> point, CustomNavigationPoint pos = null)
	{
		throw null;
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x04001759 RID: 5977
	private int _shoots;

	// Token: 0x0400175A RID: 5978
	private bool _canShootLastTime;

	// Token: 0x0400175B RID: 5979
	private float _nextShootTimeCheck;

	// Token: 0x0400175C RID: 5980
	private List<Vector3> _points;

	// Token: 0x0400175D RID: 5981
	private int _shootIndex;

	// Token: 0x0400175E RID: 5982
	private int _limitShots;
}
