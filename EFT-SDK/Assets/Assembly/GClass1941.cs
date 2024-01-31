using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.Hideout.ShootingRange;
using UnityEngine;

// Token: 0x02001C30 RID: 7216
public class GClass1941 : GClass1936, GInterface175
{
	// Token: 0x06009724 RID: 38692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroy()
	{
		throw null;
	}

	// Token: 0x06009725 RID: 38693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(RailTarget target, TargetColliderType targetColliderType, int ring)
	{
		throw null;
	}

	// Token: 0x06009726 RID: 38694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Score()
	{
		throw null;
	}

	// Token: 0x06009727 RID: 38695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetScore()
	{
		throw null;
	}

	// Token: 0x06009728 RID: 38696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(TargetColliderType targetColliderType, int shotRing)
	{
		throw null;
	}

	// Token: 0x06009729 RID: 38697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(RailTarget target)
	{
		throw null;
	}

	// Token: 0x0600972A RID: 38698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(RailTarget target)
	{
		throw null;
	}

	// Token: 0x0600972B RID: 38699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task Start(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600972C RID: 38700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task Complete(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600972D RID: 38701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_4(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600972E RID: 38702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600972F RID: 38703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(RailTarget target, int duration, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x06009730 RID: 38704 RVA: 0x00002050 File Offset: 0x00000250
	[DebuggerHidden]
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x06009731 RID: 38705 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_8(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x04009E4A RID: 40522
	private RailTargets railTargets_0;

	// Token: 0x04009E4B RID: 40523
	private GClass1941.Setting setting_0;

	// Token: 0x04009E4C RID: 40524
	private float float_0;

	// Token: 0x04009E4D RID: 40525
	private int int_0;

	// Token: 0x04009E4E RID: 40526
	private int int_1;

	// Token: 0x02001C31 RID: 7217
	[Serializable]
	public class Setting
	{
		// Token: 0x04009E4F RID: 40527
		public bool Enabled;

		// Token: 0x04009E50 RID: 40528
		[Space]
		public int Rows;

		// Token: 0x04009E51 RID: 40529
		[Min(0.1f)]
		public float ShowInterval;

		// Token: 0x04009E52 RID: 40530
		public float HideDelay;

		// Token: 0x04009E53 RID: 40531
		[Space]
		public RailTarget.MovementSpeed[] Speeds;

		// Token: 0x04009E54 RID: 40532
		public float MinSpeedDuration;

		// Token: 0x04009E55 RID: 40533
		public float MaxSpeedDuration;

		// Token: 0x04009E56 RID: 40534
		[Space]
		public int HeadShotScore;

		// Token: 0x04009E57 RID: 40535
		public int FailScore;

		// Token: 0x04009E58 RID: 40536
		[Space]
		public GClass1941.RowBonusSetting RowBonus;
	}

	// Token: 0x02001C32 RID: 7218
	[Serializable]
	public class RowBonusSetting
	{
		// Token: 0x04009E59 RID: 40537
		public int Score;

		// Token: 0x04009E5A RID: 40538
		public int MaxScore;
	}
}
