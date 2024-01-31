using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using UnityEngine;

// Token: 0x020015C4 RID: 5572
public class GClass1697 : GClass1689
{
	// Token: 0x17001319 RID: 4889
	// (get) Token: 0x06007961 RID: 31073 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool OutOfOperationRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007962 RID: 31074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter(bool isFromSameState)
	{
		throw null;
	}

	// Token: 0x06007963 RID: 31075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Player.AbstractHandsController arg1, Player.AbstractHandsController newContoller)
	{
		throw null;
	}

	// Token: 0x06007964 RID: 31076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnInteraction()
	{
		throw null;
	}

	// Token: 0x06007965 RID: 31077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06007966 RID: 31078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Player.AbstractHandsController arg1, Player.AbstractHandsController arg2)
	{
		throw null;
	}

	// Token: 0x06007967 RID: 31079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DropStationary()
	{
		throw null;
	}

	// Token: 0x06007968 RID: 31080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Rotate(Vector2 deltaRotation, bool ignoreClamp = false)
	{
		throw null;
	}

	// Token: 0x06007969 RID: 31081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualAnimatorMoveUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600796A RID: 31082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Exit(bool toSameState)
	{
		throw null;
	}

	// Token: 0x0600796B RID: 31083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Jump()
	{
		throw null;
	}

	// Token: 0x0600796C RID: 31084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableBreath(bool enable)
	{
		throw null;
	}

	// Token: 0x0600796D RID: 31085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableSprint(bool enable, bool isToggle = false)
	{
		throw null;
	}

	// Token: 0x0600796E RID: 31086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Prone()
	{
		throw null;
	}

	// Token: 0x0600796F RID: 31087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BlindFire(int b)
	{
		throw null;
	}

	// Token: 0x06007970 RID: 31088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeSpeed(float speedDelta)
	{
		throw null;
	}

	// Token: 0x06007971 RID: 31089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangePose(float poseDelta)
	{
		throw null;
	}

	// Token: 0x04007E25 RID: 32293
	private const float float_1 = 0.5f;

	// Token: 0x04007E26 RID: 32294
	private const float float_2 = 0.1f;

	// Token: 0x04007E27 RID: 32295
	public GClass1697.EStationaryStage Stage;

	// Token: 0x04007E28 RID: 32296
	public StationaryWeapon StationaryWeapon;

	// Token: 0x04007E29 RID: 32297
	private Vector2 vector2_0;

	// Token: 0x04007E2A RID: 32298
	private Vector2 vector2_1;

	// Token: 0x04007E2B RID: 32299
	private float float_3;

	// Token: 0x04007E2C RID: 32300
	private float float_4;

	// Token: 0x04007E2D RID: 32301
	private float float_5;

	// Token: 0x04007E2E RID: 32302
	private Transform transform_0;

	// Token: 0x04007E2F RID: 32303
	private bool bool_2;

	// Token: 0x04007E30 RID: 32304
	private Action action_0;

	// Token: 0x04007E31 RID: 32305
	private Action action_1;

	// Token: 0x020015C5 RID: 5573
	public enum EStationaryStage
	{
		// Token: 0x04007E33 RID: 32307
		In,
		// Token: 0x04007E34 RID: 32308
		Main,
		// Token: 0x04007E35 RID: 32309
		Out
	}

	// Token: 0x020015C6 RID: 5574
	[CompilerGenerated]
	private sealed class Class1147
	{
		// Token: 0x06007972 RID: 31090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x04007E36 RID: 32310
		public Player.FirearmController firearm;

		// Token: 0x04007E37 RID: 32311
		public GClass1697 gclass1697_0;
	}
}
