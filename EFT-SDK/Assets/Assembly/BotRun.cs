using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020002D3 RID: 723
public class BotRun : GClass362
{
	// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CalcPathToMoveZigZagAndGo(Vector3 targetPoint1, BotOwner bot, EZigZAgType type)
	{
		throw null;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Vector3[] corners, BotOwner bot, EZigZAgType type)
	{
		throw null;
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run(CoverShootType shootType, ShootPointClass shootPos, float deltaCalcTime, bool notOpeningDoor, bool checkRecalc, bool zigZag)
	{
		throw null;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RunAwayGrenade(float reachDist = -1f)
	{
		throw null;
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Run(Vector3 point, bool notOpeningDoor, float reachDist = -1f)
	{
		throw null;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndMove()
	{
		throw null;
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckRunByShoots()
	{
		throw null;
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunFor(float sec)
	{
		throw null;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopRunAnyway()
	{
		throw null;
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallRunAnyway()
	{
		throw null;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsCoverGoodForRun(CustomNavigationPoint point)
	{
		throw null;
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(CoverShootType shootType, float deltaCalcTime, bool cantChangeCover, bool zigZag)
	{
		throw null;
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(CustomNavigationPoint target, bool withZIgZag)
	{
		throw null;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(Vector3 point)
	{
		throw null;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(bool notOpeningDoor, float reachDist)
	{
		throw null;
	}

	// Token: 0x04000EA7 RID: 3751
	private static NavMeshPath _cachePath;

	// Token: 0x04000EA8 RID: 3752
	private float _nextPosibleRunTime;

	// Token: 0x04000EA9 RID: 3753
	private float _tryRunUntil;

	// Token: 0x04000EAA RID: 3754
	private bool _tryRunUntilVal;

	// Token: 0x04000EAB RID: 3755
	private bool _going;

	// Token: 0x04000EAC RID: 3756
	private float _nextTimeHeckRun;

	// Token: 0x04000EAD RID: 3757
	private float _nextRecalcMove;

	// Token: 0x04000EAE RID: 3758
	private readonly bool _canRunByManyShoots;

	// Token: 0x020002D4 RID: 724
	[CompilerGenerated]
	private sealed class Class164
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(CustomNavigationPoint navigationPoint)
		{
			throw null;
		}

		// Token: 0x04000EAF RID: 3759
		public BotRun botRun_0;

		// Token: 0x04000EB0 RID: 3760
		public bool zigZag;
	}
}
