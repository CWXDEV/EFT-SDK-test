using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020001EE RID: 494
public class DebugCoverResultDrawler : MonoBehaviour
{
	// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos(int stepConstrain, float radiusConstrain, NavGraphContainer container, int coverSelectId)
	{
		throw null;
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x04000964 RID: 2404
	public NavGraphFindDebug Debug;

	// Token: 0x04000965 RID: 2405
	public NavGraphContainer Container;

	// Token: 0x04000966 RID: 2406
	public bool DrawWay;

	// Token: 0x04000967 RID: 2407
	public int stepWayConstrain;

	// Token: 0x04000968 RID: 2408
	public bool DrawCover;

	// Token: 0x04000969 RID: 2409
	public int stepConstrain;

	// Token: 0x0400096A RID: 2410
	public float radiusConstrain;
}
