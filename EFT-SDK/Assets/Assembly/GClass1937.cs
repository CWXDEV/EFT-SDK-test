using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.Hideout.ShootingRange;
using UnityEngine;

// Token: 0x02001C1B RID: 7195
public class GClass1937 : GClass1936, GInterface175
{
	// Token: 0x060096EE RID: 38638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroy()
	{
		throw null;
	}

	// Token: 0x060096EF RID: 38639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(PopperTarget target, int segmentTarget)
	{
		throw null;
	}

	// Token: 0x060096F0 RID: 38640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Score()
	{
		throw null;
	}

	// Token: 0x060096F1 RID: 38641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetScore()
	{
		throw null;
	}

	// Token: 0x060096F2 RID: 38642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int segmentTarget)
	{
		throw null;
	}

	// Token: 0x060096F3 RID: 38643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(PopperTarget target)
	{
		throw null;
	}

	// Token: 0x060096F4 RID: 38644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(PopperTarget target)
	{
		throw null;
	}

	// Token: 0x060096F5 RID: 38645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(PopperTarget target)
	{
		throw null;
	}

	// Token: 0x060096F6 RID: 38646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task Start(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096F7 RID: 38647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task Complete(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096F8 RID: 38648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(PopperTarget[] prevTargets, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096F9 RID: 38649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_6(PopperTarget[] prevTargets, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096FA RID: 38650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096FB RID: 38651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int[] method_8(int amount)
	{
		throw null;
	}

	// Token: 0x060096FC RID: 38652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(PopperTarget target, int duration, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096FD RID: 38653 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_10(PopperTarget target)
	{
		throw null;
	}

	// Token: 0x060096FE RID: 38654 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_11(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060096FF RID: 38655 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_12(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x04009DEC RID: 40428
	private PopperTargets popperTargets_0;

	// Token: 0x04009DED RID: 40429
	private GClass1937.Setting setting_0;

	// Token: 0x04009DEE RID: 40430
	private float float_0;

	// Token: 0x04009DEF RID: 40431
	private int int_0;

	// Token: 0x04009DF0 RID: 40432
	private int int_1;

	// Token: 0x02001C1C RID: 7196
	[Serializable]
	public class Setting
	{
		// Token: 0x04009DF1 RID: 40433
		public bool Enabled;

		// Token: 0x04009DF2 RID: 40434
		[Space]
		public int Rows;

		// Token: 0x04009DF3 RID: 40435
		public int Amount;

		// Token: 0x04009DF4 RID: 40436
		[Min(0.1f)]
		public float ShowInterval;

		// Token: 0x04009DF5 RID: 40437
		public float HideDelay;

		// Token: 0x04009DF6 RID: 40438
		[Space]
		public int ShotScore;

		// Token: 0x04009DF7 RID: 40439
		public int FailScore;

		// Token: 0x04009DF8 RID: 40440
		[Space]
		public int RowBonus;

		// Token: 0x04009DF9 RID: 40441
		public GClass1937.TimeBonusSetting TimeBonus;
	}

	// Token: 0x02001C1D RID: 7197
	[Serializable]
	public class TimeBonusSetting
	{
		// Token: 0x04009DFA RID: 40442
		public float Time;

		// Token: 0x04009DFB RID: 40443
		public int Score;

		// Token: 0x04009DFC RID: 40444
		public int MaxScore;
	}

	// Token: 0x02001C1F RID: 7199
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1697
	{
		// Token: 0x06009702 RID: 38658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(PopperTarget target)
		{
			throw null;
		}

		// Token: 0x04009E03 RID: 40451
		public static readonly GClass1937.Class1697 class1697_0;

		// Token: 0x04009E04 RID: 40452
		public static Func<PopperTarget, bool> func_0;
	}

	// Token: 0x02001C22 RID: 7202
	[CompilerGenerated]
	private sealed class Class1698
	{
		// Token: 0x06009707 RID: 38663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_0(PopperTarget target)
		{
			throw null;
		}

		// Token: 0x04009E0F RID: 40463
		public CancellationToken token;
	}
}
