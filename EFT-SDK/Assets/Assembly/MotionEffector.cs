using System;
using System.Runtime.CompilerServices;
using EFT.Animations;
using UnityEngine;

// Token: 0x0200090D RID: 2317
[Serializable]
public class MotionEffector : IEffector
{
	// Token: 0x170008F3 RID: 2291
	// (get) Token: 0x06003469 RID: 13417 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600346A RID: 13418 RVA: 0x00002050 File Offset: 0x00000250
	public Transform Transform
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600346B RID: 13419 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerSpring playerSpring)
	{
		throw null;
	}

	// Token: 0x0600346C RID: 13420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPlatformMovement(Vector3 movement)
	{
		throw null;
	}

	// Token: 0x0600346D RID: 13421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixedTracking(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600346E RID: 13422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 method_0()
	{
		throw null;
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06003470 RID: 13424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugOutput()
	{
		throw null;
	}

	// Token: 0x06003471 RID: 13425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06003472 RID: 13426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x040034FC RID: 13564
	public Vector3 Motion;

	// Token: 0x040034FD RID: 13565
	public Vector3 Velocity;

	// Token: 0x040034FE RID: 13566
	public float RotationInputClamp;

	// Token: 0x040034FF RID: 13567
	private Vector3 _lastPosition;

	// Token: 0x04003500 RID: 13568
	private Vector3 _lastForward;

	// Token: 0x04003501 RID: 13569
	public Vector3 PositionVelocity;

	// Token: 0x04003502 RID: 13570
	public Vector2 RotationVelocity;

	// Token: 0x04003503 RID: 13571
	public Vector3 PositionAcceleration;

	// Token: 0x04003504 RID: 13572
	public Vector2 RotationAcceleration;

	// Token: 0x04003505 RID: 13573
	public Vector3 SwayFactors;

	// Token: 0x04003506 RID: 13574
	private Vector3 _lastPositionVelocity;

	// Token: 0x04003507 RID: 13575
	private Vector2 _lastRotationVelocity;

	// Token: 0x04003508 RID: 13576
	private Vector2 _rotVelSum;

	// Token: 0x04003509 RID: 13577
	private Vector2 _rotAccSum;

	// Token: 0x0400350A RID: 13578
	private Vector3 lastRotation;

	// Token: 0x0400350B RID: 13579
	public float Intensity;

	// Token: 0x0400350C RID: 13580
	private Vector3 _platformMovement;

	// Token: 0x0400350D RID: 13581
	private Vector2 v;

	// Token: 0x0400350E RID: 13582
	private Vector2 v4;

	// Token: 0x0400350F RID: 13583
	private GClass803[] _mouseProcessors;

	// Token: 0x04003510 RID: 13584
	private GClass802[] _movementProcessors;

	// Token: 0x04003511 RID: 13585
	public MotionEffectorParameters MouseParameters;

	// Token: 0x04003512 RID: 13586
	public MotionEffectorParameters MovementParameters;

	// Token: 0x04003513 RID: 13587
	private bool _initialized;

	// Token: 0x04003514 RID: 13588
	private Vector3 v2;

	// Token: 0x04003515 RID: 13589
	private Vector3 v3;

	// Token: 0x04003516 RID: 13590
	private bool _needReset;
}
