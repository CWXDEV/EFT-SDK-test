using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020004A2 RID: 1186
public class ArtilleryDangerPlace : GClass362
{
	// Token: 0x06001CC3 RID: 7363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallEnd()
	{
		throw null;
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallRunAway()
	{
		throw null;
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Vector3 point, float radius, float duration)
	{
		throw null;
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400186B RID: 6251
	private const float SDIST_TO_IGNORE = 100f;

	// Token: 0x0400186C RID: 6252
	public float EndTime;

	// Token: 0x0400186D RID: 6253
	public Vector3 Point;

	// Token: 0x0400186E RID: 6254
	public float Radius;

	// Token: 0x0400186F RID: 6255
	public float sRadius;

	// Token: 0x04001870 RID: 6256
	private bool _isActive;

	// Token: 0x04001871 RID: 6257
	private readonly List<CustomNavigationPoint> _posibleCovers;

	// Token: 0x04001872 RID: 6258
	private float _settedTime;
}
