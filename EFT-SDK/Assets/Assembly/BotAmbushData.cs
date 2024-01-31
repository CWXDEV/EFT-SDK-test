using System;
using System.Runtime.CompilerServices;

// Token: 0x02000298 RID: 664
public class BotAmbushData : GClass362
{
	// Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetAmbushPoint(out CustomNavigationPoint ambushPoint)
	{
		throw null;
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCoverAtMiddle(CustomNavigationPoint coverInMiddle)
	{
		throw null;
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoverSearchData GetCoverSearchData()
	{
		throw null;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveCover()
	{
		throw null;
	}

	// Token: 0x04000D57 RID: 3415
	private const int MAX_AMBUSH_DANGER_LEVEL = 1;

	// Token: 0x04000D58 RID: 3416
	private CustomNavigationPoint _coverInMiddle;
}
