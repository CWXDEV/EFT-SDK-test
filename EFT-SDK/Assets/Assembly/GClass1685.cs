using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using UnityEngine;

// Token: 0x02001598 RID: 5528
public class GClass1685 : MovementState
{
	// Token: 0x060076AF RID: 30383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter(bool isFromSameState)
	{
		throw null;
	}

	// Token: 0x060076B0 RID: 30384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Exit(bool toSameState)
	{
		throw null;
	}

	// Token: 0x060076B1 RID: 30385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualAnimatorMoveUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060076B2 RID: 30386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ExecuteDoorInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback, Player user)
	{
		throw null;
	}

	// Token: 0x04007CA7 RID: 31911
	[Range(0f, 1f)]
	public float KickTime;

	// Token: 0x04007CA8 RID: 31912
	protected Door door_0;

	// Token: 0x04007CA9 RID: 31913
	protected bool bool_0;

	// Token: 0x04007CAA RID: 31914
	private EDoorState edoorState_0;
}
