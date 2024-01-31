using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000305 RID: 773
public class BotCallForHelp : GClass362
{
	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
	private BotGlobalsBossSettings BotGlobalsBossSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FreeSavages(BotOwner target)
	{
		throw null;
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool WantCallForSavages()
	{
		throw null;
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallForSavages()
	{
		throw null;
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_1()
	{
		throw null;
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(BotOwner neutral)
	{
		throw null;
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(BotOwner calledBot)
	{
		throw null;
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(BotOwner neutral)
	{
		throw null;
	}

	// Token: 0x04000F98 RID: 3992
	private const float COMPUTE_PATH_LENGTH_PERIOD = 0.35f;

	// Token: 0x04000F99 RID: 3993
	private const float SAVAGE_CALL_PERIOD = 5f;

	// Token: 0x04000F9A RID: 3994
	private PanicType _originalPanicType;

	// Token: 0x04000F9B RID: 3995
	private float _pathToEnemyLength;

	// Token: 0x04000F9C RID: 3996
	private float _prevComputePathLengthTime;

	// Token: 0x04000F9D RID: 3997
	private float _lastSavageCallTime;

	// Token: 0x04000F9E RID: 3998
	private bool _savagesCalled;

	// Token: 0x04000F9F RID: 3999
	private EnemyInfo _prevTarget;
}
