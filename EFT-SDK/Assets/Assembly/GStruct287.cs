using System;
using System.Runtime.InteropServices;
using EFT;
using UnityEngine;

// Token: 0x02002042 RID: 8258
[StructLayout(LayoutKind.Auto)]
public struct GStruct287
{
	// Token: 0x0400B1E2 RID: 45538
	public Vector3 BodyPosition;

	// Token: 0x0400B1E3 RID: 45539
	public Vector3 HeadRotation;

	// Token: 0x0400B1E4 RID: 45540
	public Vector2 MovementDirection;

	// Token: 0x0400B1E5 RID: 45541
	public Vector3 Velocity;

	// Token: 0x0400B1E6 RID: 45542
	public float Tilt;

	// Token: 0x0400B1E7 RID: 45543
	public int Step;

	// Token: 0x0400B1E8 RID: 45544
	public int BlindFire;

	// Token: 0x0400B1E9 RID: 45545
	public int StateAnimatorIndex;

	// Token: 0x0400B1EA RID: 45546
	public EPlayerState State;

	// Token: 0x0400B1EB RID: 45547
	public EPhysicalCondition PhysicalCondition;

	// Token: 0x0400B1EC RID: 45548
	public float MovementSpeed;

	// Token: 0x0400B1ED RID: 45549
	public float SprintSpeed;

	// Token: 0x0400B1EE RID: 45550
	public float MaxSpeed;

	// Token: 0x0400B1EF RID: 45551
	public EPlayerPose Pose;

	// Token: 0x0400B1F0 RID: 45552
	public float PoseLevel;

	// Token: 0x0400B1F1 RID: 45553
	public float InHandsObjectOverlap;

	// Token: 0x0400B1F2 RID: 45554
	public bool IsGrounded;

	// Token: 0x0400B1F3 RID: 45555
	public float JumpHeight;

	// Token: 0x0400B1F4 RID: 45556
	public float FallHeight;

	// Token: 0x0400B1F5 RID: 45557
	public float FallTime;

	// Token: 0x0400B1F6 RID: 45558
	public float VaultingHeight;

	// Token: 0x0400B1F7 RID: 45559
	public float VaultingLength;

	// Token: 0x0400B1F8 RID: 45560
	public float BehindObstacleHeight;

	// Token: 0x0400B1F9 RID: 45561
	public float AbsoluteForwardVelocity;

	// Token: 0x0400B1FA RID: 45562
	public Vector3 VaultingPoint;

	// Token: 0x0400B1FB RID: 45563
	public float VaultingSpeed;

	// Token: 0x0400B1FC RID: 45564
	public bool LeftStance;

	// Token: 0x0400B1FD RID: 45565
	public float AimRotation;

	// Token: 0x0400B1FE RID: 45566
	public Quaternion FootRotation;
}
