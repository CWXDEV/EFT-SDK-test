using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;

// Token: 0x0200159A RID: 5530
public class GClass1687 : MovementState
{
	// Token: 0x060076B3 RID: 30387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter(bool isFromSameState)
	{
		throw null;
	}

	// Token: 0x060076B4 RID: 30388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Exit(bool toSameState)
	{
		throw null;
	}

	// Token: 0x060076B5 RID: 30389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartInteractionAnimation()
	{
		throw null;
	}

	// Token: 0x060076B6 RID: 30390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExecuteInteraction()
	{
		throw null;
	}

	// Token: 0x060076B7 RID: 30391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ExecuteDoorInteraction(WorldInteractiveObject door, InteractionResult interactionResult, Action callback, Player user)
	{
		throw null;
	}

	// Token: 0x060076B8 RID: 30392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopInteractionAnimation()
	{
		throw null;
	}

	// Token: 0x060076B9 RID: 30393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BaseUpdate()
	{
		throw null;
	}

	// Token: 0x060076BA RID: 30394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartStates()
	{
		throw null;
	}

	// Token: 0x060076BB RID: 30395 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualAnimatorMoveUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x04007CAB RID: 31915
	private float float_0;

	// Token: 0x04007CAC RID: 31916
	public WorldInteractiveObject Door;

	// Token: 0x04007CAD RID: 31917
	private GripPose gripPose_0;

	// Token: 0x04007CAE RID: 31918
	private EDoorState edoorState_0;

	// Token: 0x04007CAF RID: 31919
	private SmartGrip smartGrip_0;

	// Token: 0x04007CB0 RID: 31920
	private bool bool_0;

	// Token: 0x04007CB1 RID: 31921
	private bool bool_1;

	// Token: 0x04007CB2 RID: 31922
	private float float_1;

	// Token: 0x04007CB3 RID: 31923
	private int int_0;

	// Token: 0x04007CB4 RID: 31924
	private const float float_2 = 1f;

	// Token: 0x04007CB5 RID: 31925
	private GClass1679 gclass1679_0;

	// Token: 0x0200159B RID: 5531
	[CompilerGenerated]
	private sealed class Class1141
	{
		// Token: 0x060076BC RID: 30396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1679 method_0()
		{
			throw null;
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1679 method_1()
		{
			throw null;
		}

		// Token: 0x04007CB6 RID: 31926
		public GClass1687 gclass1687_0;

		// Token: 0x04007CB7 RID: 31927
		public GClass1681 endState;
	}
}
