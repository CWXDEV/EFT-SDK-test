using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000401 RID: 1025
public class BotGoToPointData : GClass362
{
	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Point
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

	// Token: 0x060018A3 RID: 6307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPoint(Vector3 p)
	{
		throw null;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveTarget()
	{
		throw null;
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateToGo(bool sprint)
	{
		throw null;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCome()
	{
		throw null;
	}

	// Token: 0x0400155B RID: 5467
	private bool _pointhRefreshed;

	// Token: 0x0400155C RID: 5468
	private float _distToPoint;

	// Token: 0x0400155D RID: 5469
	private float _nextPosibleRecalc;

	// Token: 0x0400155F RID: 5471
	private NavMeshPath _path;
}
