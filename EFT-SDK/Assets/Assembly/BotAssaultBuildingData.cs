using System;
using System.Runtime.CompilerServices;

// Token: 0x02000299 RID: 665
public class BotAssaultBuildingData : GClass362
{
	// Token: 0x17000365 RID: 869
	// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartFor(float period)
	{
		throw null;
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PeriodCheckStart()
	{
		throw null;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000D59 RID: 3417
	private bool _isActive;

	// Token: 0x04000D5A RID: 3418
	private GClass551.GInterface13 _timer;

	// Token: 0x04000D5B RID: 3419
	private int _taskId;

	// Token: 0x04000D5C RID: 3420
	private float _wantAssault;

	// Token: 0x04000D5D RID: 3421
	private const float ATTACK_PERIOD = 60f;

	// Token: 0x04000D5E RID: 3422
	private const float SDIST_TO_START_ATTACK = 625f;
}
