using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;

// Token: 0x02000466 RID: 1126
public class BotSecondWeaponData : GClass362
{
	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveSecondWeapon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDo(GClass346 closest)
	{
		throw null;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActions()
	{
		throw null;
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply()
	{
		throw null;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Result<GInterface123> x)
	{
		throw null;
	}

	// Token: 0x04001742 RID: 5954
	private const float START_TIME_OFFSET = 90f;

	// Token: 0x04001743 RID: 5955
	private const float DELAY_BEFORE_ACTION = 1f;

	// Token: 0x04001744 RID: 5956
	private const float DELAY_ACTION_TIME = 2f;

	// Token: 0x04001745 RID: 5957
	private float _nextPossibleUseTime;

	// Token: 0x04001746 RID: 5958
	private bool _shallStart;

	// Token: 0x04001747 RID: 5959
	private float _ammoActionTime;

	// Token: 0x04001748 RID: 5960
	private float _returnToMainTime;

	// Token: 0x04001749 RID: 5961
	private IPlayer _lookTo;

	// Token: 0x0400174A RID: 5962
	private bool _canUse;
}
