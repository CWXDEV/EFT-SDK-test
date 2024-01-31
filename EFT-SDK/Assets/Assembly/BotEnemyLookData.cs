using System;
using System.Runtime.CompilerServices;

// Token: 0x020002B8 RID: 696
public class BotEnemyLookData : GClass362
{
	// Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoCheck()
	{
		throw null;
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEnemyLookAtMeForPeriod(float period)
	{
		throw null;
	}

	// Token: 0x04000DF7 RID: 3575
	private const float CHECK_PERIOD_SAFE = 0.5f;

	// Token: 0x04000DF8 RID: 3576
	private const float DIST_TO_CHECK = 20f;

	// Token: 0x04000DF9 RID: 3577
	private float _prevCheckTime;

	// Token: 0x04000DFA RID: 3578
	private float _nextCheckPeriod;

	// Token: 0x04000DFB RID: 3579
	private float _prevResult;

	// Token: 0x04000DFC RID: 3580
	private readonly float _checkPeriod;

	// Token: 0x04000DFD RID: 3581
	private readonly bool _onlyIfVisible;
}
