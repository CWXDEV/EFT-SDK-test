using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200029D RID: 669
public class BotBewareGrenade : GClass362
{
	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnAwayFlash(Grenade grenade)
	{
		throw null;
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGrenadeDanger(Vector3 danger, Grenade grenade)
	{
		throw null;
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallRunAway()
	{
		throw null;
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IgnoreGrenadesForSec(float sec)
	{
		throw null;
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateByNode()
	{
		throw null;
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Grenade grenade)
	{
		throw null;
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Grenade grenade, Vector3 danger, bool isMyFlash)
	{
		throw null;
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass498 gdp)
	{
		throw null;
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4()
	{
		throw null;
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_6()
	{
		throw null;
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomNavigationPoint method_7()
	{
		throw null;
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SawGrenadeSoFar(float period)
	{
		throw null;
	}

	// Token: 0x04000D6D RID: 3437
	public GClass498 GrenadeDangerPoint;

	// Token: 0x04000D6E RID: 3438
	public Action<Grenade> OnBewareGrenade;

	// Token: 0x04000D6F RID: 3439
	private float _endPeriodOfIgnore;

	// Token: 0x04000D70 RID: 3440
	private float _nextPosibleRunTime;

	// Token: 0x04000D71 RID: 3441
	private readonly float DELTA_CALC_TIME;

	// Token: 0x04000D72 RID: 3442
	private float deltaGoCheck;

	// Token: 0x0200029E RID: 670
	[CompilerGenerated]
	private sealed class Class155
	{
		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Vector3? method_0()
		{
			throw null;
		}

		// Token: 0x04000D73 RID: 3443
		public Grenade grenade;
	}

	// Token: 0x0200029F RID: 671
	[CompilerGenerated]
	private sealed class Class156
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04000D74 RID: 3444
		public Grenade grenade;

		// Token: 0x04000D75 RID: 3445
		public float distToGrenade;

		// Token: 0x04000D76 RID: 3446
		public BotBewareGrenade botBewareGrenade_0;

		// Token: 0x04000D77 RID: 3447
		public Vector3 danger;

		// Token: 0x04000D78 RID: 3448
		public bool isMyFlash;
	}

	// Token: 0x020002A0 RID: 672
	[CompilerGenerated]
	private sealed class Class157
	{
		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04000D79 RID: 3449
		public BotBewareGrenade botBewareGrenade_0;

		// Token: 0x04000D7A RID: 3450
		public Grenade grenade;

		// Token: 0x04000D7B RID: 3451
		public Vector3 danger;
	}
}
