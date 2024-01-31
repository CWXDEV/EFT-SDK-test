using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Vehicle;

// Token: 0x0200029C RID: 668
public class BotBewareBTR : GClass362
{
	// Token: 0x1700036A RID: 874
	// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
	private BTRVehicle BTRVehicle_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallRunAway()
	{
		throw null;
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateByNode()
	{
		throw null;
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomNavigationPoint method_1()
	{
		throw null;
	}

	// Token: 0x04000D68 RID: 3432
	public Action<Grenade> OnBewareGrenade;

	// Token: 0x04000D69 RID: 3433
	private float _endPeriodOfIgnore;

	// Token: 0x04000D6A RID: 3434
	private float _nextPossibleRunTime;

	// Token: 0x04000D6B RID: 3435
	private readonly float DELTA_CALC_TIME;

	// Token: 0x04000D6C RID: 3436
	private float deltaGoCheck;
}
