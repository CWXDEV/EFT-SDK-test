using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200040B RID: 1035
public class BotSteering : GClass362
{
	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001912 RID: 6418 RVA: 0x00002050 File Offset: 0x00000250
	public float Speed
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

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x06001913 RID: 6419 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LookDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
	public EBotSteering SteeringMode
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

	// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualFixedUpdate()
	{
		throw null;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetYAngle(float angle)
	{
		throw null;
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToPoint(Vector3 point)
	{
		throw null;
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToPathDestPoint()
	{
		throw null;
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToMovingDirection()
	{
		throw null;
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToPoint(Vector3 point, float rotateSpeed)
	{
		throw null;
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToMovingDirection(float rotateSpeed)
	{
		throw null;
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToDirection(Vector3 dir)
	{
		throw null;
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToDirection(Vector3 dir, float rotateSpeed)
	{
		throw null;
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookToPathDestPoint(float rotateSpeed)
	{
		throw null;
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetYByDir(Vector3 dir)
	{
		throw null;
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float CalcYByDir(Vector3 dir)
	{
		throw null;
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float rotateSpeed)
	{
		throw null;
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(float degPerSec)
	{
		throw null;
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x04001591 RID: 5521
	public float FirstTurnSpeed;

	// Token: 0x04001592 RID: 5522
	public float FirstTurnBigSpeed;

	// Token: 0x04001593 RID: 5523
	public float TurnSpeedSprint;

	// Token: 0x04001594 RID: 5524
	private Vector3 _lookDirection;

	// Token: 0x04001595 RID: 5525
	private readonly Player _player;

	// Token: 0x04001596 RID: 5526
	private Vector3 _customPoint;

	// Token: 0x04001597 RID: 5527
	private Vector3 _customDirection;

	// Token: 0x04001598 RID: 5528
	private readonly BifacialTransform _ownerTransform;

	// Token: 0x04001599 RID: 5529
	private readonly bool _blockSteering;

	// Token: 0x0400159A RID: 5530
	private bool _isErrorLogged;

	// Token: 0x0400159B RID: 5531
	private bool _isErrorDirectionLog;
}
