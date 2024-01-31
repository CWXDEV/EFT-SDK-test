using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020003F0 RID: 1008
public class EnemyPartData
{
	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06001834 RID: 6196 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001835 RID: 6197 RVA: 0x00002050 File Offset: 0x00000250
	public bool VisibleBySense
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

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06001836 RID: 6198 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001837 RID: 6199 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanShoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06001838 RID: 6200 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001839 RID: 6201 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsVisible
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

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x0600183A RID: 6202 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
	public float TimeSeen
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

	// Token: 0x0600183C RID: 6204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFullDissapearForShoot(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateVision(float seenCoef, bool canSee, bool onSence, bool onSenceGreen, BotOwner owner, float visibleCoef = 1f)
	{
		throw null;
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float PercentSpotted(out float seenTime)
	{
		throw null;
	}

	// Token: 0x0400150C RID: 5388
	public bool LastCheckVisibleAng;

	// Token: 0x0400150D RID: 5389
	public bool LastCheckAng;

	// Token: 0x0400150E RID: 5390
	public EEnemyPartVisibleType VisionType;

	// Token: 0x0400150F RID: 5391
	public bool LastVisibilityCastSucceed;

	// Token: 0x04001510 RID: 5392
	public Vector3 LastVisibilityCastOffsetLocal;

	// Token: 0x04001511 RID: 5393
	public bool LastShootCastSucceed;

	// Token: 0x04001512 RID: 5394
	public Vector3 LastShootCastOffsetLocal;

	// Token: 0x04001513 RID: 5395
	public bool VisCastForShootIsTried;

	// Token: 0x04001514 RID: 5396
	private bool _canShoot;

	// Token: 0x04001515 RID: 5397
	private float _firstTimeSpotted;

	// Token: 0x04001516 RID: 5398
	private float _lastSeenCoef;

	// Token: 0x04001517 RID: 5399
	private float _lastVisibleTrueTime;

	// Token: 0x04001518 RID: 5400
	private readonly bool _canAimToPart;
}
