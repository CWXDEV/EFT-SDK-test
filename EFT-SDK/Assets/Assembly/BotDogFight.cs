using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020002B4 RID: 692
public class BotDogFight : GClass362
{
	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00002050 File Offset: 0x00000250
	public BotDogFightStatus DogFightState
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(out Vector3 trgPos)
	{
		throw null;
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallStartCauseHavePlace()
	{
		throw null;
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fight()
	{
		throw null;
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(NavMeshPath path, float straighDist)
	{
		throw null;
	}

	// Token: 0x04000DD5 RID: 3541
	private const float DIST_TO_BACK = 2f;

	// Token: 0x04000DD6 RID: 3542
	private float _nextRecalc;

	// Token: 0x04000DD7 RID: 3543
	private float _posibleCheckCanGo;

	// Token: 0x04000DD8 RID: 3544
	private bool _pursuitInProgress;

	// Token: 0x04000DD9 RID: 3545
	private readonly NavMeshPath _pathCached;
}
