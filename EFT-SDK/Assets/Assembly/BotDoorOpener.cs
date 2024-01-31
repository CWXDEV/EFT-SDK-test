using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020002B7 RID: 695
public class BotDoorOpener
{
	// Token: 0x1400001E RID: 30
	// (add) Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnEndInteract
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x17000387 RID: 903
	// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00002050 File Offset: 0x00000250
	public bool Interacting
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

	// Token: 0x17000389 RID: 905
	// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanOpenDoorNow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Update()
	{
		throw null;
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TraverseDoorLink()
	{
		throw null;
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Interact(Door door, EInteractionType Etype)
	{
		throw null;
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct18? method_0(List<NavMeshDoorLink> list, [CanBeNull] GStruct18? exclude)
	{
		throw null;
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(NavMeshDoorLink link)
	{
		throw null;
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(Vector3 goTo, GStruct18 infoStruct)
	{
		throw null;
	}

	// Token: 0x04000DE3 RID: 3555
	public const float DIR_SIDE_MAX_SQRT = 4f;

	// Token: 0x04000DE4 RID: 3556
	public const float MAX_DIST_SQRT = 4f;

	// Token: 0x04000DE5 RID: 3557
	private const float CHECK_RUN_DIST = 27.039997f;

	// Token: 0x04000DE6 RID: 3558
	private const float INTERACT_PERIOD_BREACH = 2.7f;

	// Token: 0x04000DE7 RID: 3559
	private const float OPEN_DIST = 16f;

	// Token: 0x04000DE8 RID: 3560
	private const float PERIOD_DOOR_OPEN = 3f;

	// Token: 0x04000DE9 RID: 3561
	public bool NearDoor;

	// Token: 0x04000DEA RID: 3562
	public bool _lastFrameLink;

	// Token: 0x04000DEB RID: 3563
	private NavMeshDoorLink _currLink;

	// Token: 0x04000DEC RID: 3564
	private Door _currentDoor;

	// Token: 0x04000DED RID: 3565
	private readonly BotOwner _owner;

	// Token: 0x04000DEE RID: 3566
	private float _nextPosibleDoorOpenTime;

	// Token: 0x04000DEF RID: 3567
	private float _traversingEnd;

	// Token: 0x04000DF0 RID: 3568
	private float _searchCloseDoorTime;

	// Token: 0x04000DF1 RID: 3569
	private float _comeToDoorLast;

	// Token: 0x04000DF2 RID: 3570
	private float _nextWaitInteractedDoor;

	// Token: 0x04000DF3 RID: 3571
	private bool _shallStartInteract;

	// Token: 0x04000DF4 RID: 3572
	private float _refreshWayPeriod;
}
