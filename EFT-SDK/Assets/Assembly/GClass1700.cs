using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020015A3 RID: 5539
public class GClass1700 : MovementState
{
	// Token: 0x060076DA RID: 30426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter(bool isFromSameState)
	{
		throw null;
	}

	// Token: 0x060076DB RID: 30427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Exit(bool toSameState)
	{
		throw null;
	}

	// Token: 0x060076DC RID: 30428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualAnimatorMoveUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060076DD RID: 30429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060076DE RID: 30430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ApplyMovementAndRotation(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060076DF RID: 30431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableSprint(bool enable, bool isToggle = false)
	{
		throw null;
	}

	// Token: 0x060076E0 RID: 30432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060076E1 RID: 30433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Move(Vector2 direction)
	{
		throw null;
	}

	// Token: 0x060076E2 RID: 30434 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetTilt(float tilt)
	{
		throw null;
	}

	// Token: 0x04007CC4 RID: 31940
	private Vector2 vector2_0;

	// Token: 0x04007CC5 RID: 31941
	protected Vector3 vector3_0;

	// Token: 0x04007CC6 RID: 31942
	private float float_0;

	// Token: 0x04007CC7 RID: 31943
	private float float_1;

	// Token: 0x04007CC8 RID: 31944
	protected Vector3 vector3_1;

	// Token: 0x04007CC9 RID: 31945
	protected bool bool_0;

	// Token: 0x04007CCA RID: 31946
	private float float_2;

	// Token: 0x04007CCB RID: 31947
	private float float_3;

	// Token: 0x04007CCC RID: 31948
	protected GClass1700.EJumpState ejumpState_0;

	// Token: 0x04007CCD RID: 31949
	private float float_4;

	// Token: 0x04007CCE RID: 31950
	private float float_5;

	// Token: 0x04007CCF RID: 31951
	private int int_0;

	// Token: 0x04007CD0 RID: 31952
	private const float float_6 = 0.1f;

	// Token: 0x04007CD1 RID: 31953
	private const int int_1 = 3;

	// Token: 0x04007CD2 RID: 31954
	private LayerMask layerMask_0;

	// Token: 0x04007CD3 RID: 31955
	private float float_7;

	// Token: 0x04007CD4 RID: 31956
	private float float_8;

	// Token: 0x04007CD5 RID: 31957
	private bool bool_1;

	// Token: 0x04007CD6 RID: 31958
	private float float_9;

	// Token: 0x04007CD7 RID: 31959
	private float float_10;

	// Token: 0x04007CD8 RID: 31960
	private Vector3 vector3_2;

	// Token: 0x020015A4 RID: 5540
	protected enum EJumpState
	{
		// Token: 0x04007CDA RID: 31962
		PushingFromTheGround,
		// Token: 0x04007CDB RID: 31963
		Jump,
		// Token: 0x04007CDC RID: 31964
		Bumbped
	}
}
