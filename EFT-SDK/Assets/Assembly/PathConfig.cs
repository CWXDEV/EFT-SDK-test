using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000651 RID: 1617
[Serializable]
public class PathConfig
{
	// Token: 0x06002507 RID: 9479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAllPathPoints()
	{
		throw null;
	}

	// Token: 0x04002405 RID: 9221
	public string id;

	// Token: 0x04002406 RID: 9222
	public string enterPoint;

	// Token: 0x04002407 RID: 9223
	public string exitPoint;

	// Token: 0x04002408 RID: 9224
	public List<string> pathPoints;

	// Token: 0x04002409 RID: 9225
	public bool once;

	// Token: 0x0400240A RID: 9226
	public bool flipFlop;

	// Token: 0x0400240B RID: 9227
	public int flipCount;

	// Token: 0x0400240C RID: 9228
	public bool circle;

	// Token: 0x0400240D RID: 9229
	public int circleCount;
}
