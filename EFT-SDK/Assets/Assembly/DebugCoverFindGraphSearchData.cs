using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000127 RID: 295
public class DebugCoverFindGraphSearchData
{
	// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStep(GClass311 point, GClass300<GClass311> list)
	{
		throw null;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPrintLogs(CustomNavigationPoint result)
	{
		throw null;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GizmosDrawBySteps(int debugLastCoverDrawSteps)
	{
		throw null;
	}

	// Token: 0x04000712 RID: 1810
	private readonly CoverSearchData _data;

	// Token: 0x04000713 RID: 1811
	private int lastStep;

	// Token: 0x04000714 RID: 1812
	private readonly NavGraphVoxelSimple _startVoxel;

	// Token: 0x04000715 RID: 1813
	private readonly List<GClass311> _checked;

	// Token: 0x04000716 RID: 1814
	private readonly List<List<GClass311>> pointsAtSteps;

	// Token: 0x04000717 RID: 1815
	private readonly bool _doLog;
}
