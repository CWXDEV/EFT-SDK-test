using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C84 RID: 3204
public class GClass916
{
	// Token: 0x06004547 RID: 17735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadState(int state)
	{
		throw null;
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int WriteState()
	{
		throw null;
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool write, ref int state)
	{
		throw null;
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(bool write, ref int state, ref int position, ref bool value)
	{
		throw null;
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(bool write, ref int state, ref int position, ref int value, int length)
	{
		throw null;
	}

	// Token: 0x04004FB5 RID: 20405
	public GClass916.ActionState Action;

	// Token: 0x04004FB6 RID: 20406
	public bool Aim;

	// Token: 0x04004FB7 RID: 20407
	public int EquipedItem;

	// Token: 0x04004FB8 RID: 20408
	public int Ammo;

	// Token: 0x04004FB9 RID: 20409
	public bool Forvard;

	// Token: 0x04004FBA RID: 20410
	public bool Backward;

	// Token: 0x04004FBB RID: 20411
	public bool Right;

	// Token: 0x04004FBC RID: 20412
	public bool Left;

	// Token: 0x04004FBD RID: 20413
	public GClass916.PoseState Pose;

	// Token: 0x04004FBE RID: 20414
	public GClass916.SpeedState Speed;

	// Token: 0x04004FBF RID: 20415
	public bool IsHit;

	// Token: 0x02000C85 RID: 3205
	public enum ActionState
	{
		// Token: 0x04004FC1 RID: 20417
		Idle,
		// Token: 0x04004FC2 RID: 20418
		Fire,
		// Token: 0x04004FC3 RID: 20419
		Reload,
		// Token: 0x04004FC4 RID: 20420
		GetPistol,
		// Token: 0x04004FC5 RID: 20421
		GetRifle,
		// Token: 0x04004FC6 RID: 20422
		Misfire
	}

	// Token: 0x02000C86 RID: 3206
	public enum PoseState
	{
		// Token: 0x04004FC8 RID: 20424
		Stay,
		// Token: 0x04004FC9 RID: 20425
		Sit,
		// Token: 0x04004FCA RID: 20426
		Lay,
		// Token: 0x04004FCB RID: 20427
		Jump
	}

	// Token: 0x02000C87 RID: 3207
	public enum SpeedState
	{
		// Token: 0x04004FCD RID: 20429
		Walk,
		// Token: 0x04004FCE RID: 20430
		Run,
		// Token: 0x04004FCF RID: 20431
		Sprint
	}
}
