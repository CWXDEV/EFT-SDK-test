using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020002BC RID: 700
public class BotPlayerFollowData : GClass362
{
	// Token: 0x1700038E RID: 910
	// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveFound
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

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveToFollow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000390 RID: 912
	// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
	public string FollowGroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromNode()
	{
		throw null;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToFollow(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEnoughtDist()
	{
		throw null;
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFollower(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Player person)
	{
		throw null;
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(IPlayer person)
	{
		throw null;
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(IPlayer person)
	{
		throw null;
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(DamageInfo damageInfo, EBodyPart eBodyPart, float val)
	{
		throw null;
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(EDamageType obj)
	{
		throw null;
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000E0A RID: 3594
	private Vector3 _offset;

	// Token: 0x04000E0B RID: 3595
	private Vector3 _lastPlayerConnectionPlace;

	// Token: 0x04000E0C RID: 3596
	private float _lastPlayerConnectionTime;

	// Token: 0x04000E0D RID: 3597
	private float _setSprintTime;

	// Token: 0x04000E0E RID: 3598
	private float _nextRefreshGoTo;

	// Token: 0x04000E0F RID: 3599
	private IPlayer _toFollow;

	// Token: 0x04000E10 RID: 3600
	private bool _sprintNow;

	// Token: 0x04000E11 RID: 3601
	private readonly float SDIST_NOT_TO_FOLLOW;

	// Token: 0x04000E12 RID: 3602
	private readonly float SDIST_CHECK;

	// Token: 0x04000E13 RID: 3603
	private readonly float SDIST_SPRINT;

	// Token: 0x04000E14 RID: 3604
	private readonly float PERIOD_CHECK;
}
