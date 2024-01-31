using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000ACD RID: 2765
public class MuzzleFume : MuzzleEffect
{
	// Token: 0x06003C6A RID: 15466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003C6B RID: 15467 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateValues()
	{
		throw null;
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Emit(GInterface40 emitter)
	{
		throw null;
	}

	// Token: 0x0400421C RID: 16924
	public float StartPos;

	// Token: 0x0400421D RID: 16925
	public float EmitterRadius;

	// Token: 0x0400421E RID: 16926
	public float ConusSize;

	// Token: 0x0400421F RID: 16927
	public AnimationCurve Sizes;

	// Token: 0x04004220 RID: 16928
	public AnimationCurve Speeds;

	// Token: 0x04004221 RID: 16929
	public AnimationCurve LifeTimes;

	// Token: 0x04004222 RID: 16930
	public float SizesRnd;

	// Token: 0x04004223 RID: 16931
	public float Size;

	// Token: 0x04004224 RID: 16932
	public float Speed;

	// Token: 0x04004225 RID: 16933
	public float LifeTime;

	// Token: 0x04004226 RID: 16934
	public Gradient Color;

	// Token: 0x04004227 RID: 16935
	public int CountMin;

	// Token: 0x04004228 RID: 16936
	public int CountRange;

	// Token: 0x04004229 RID: 16937
	private Vector3 vector3_0;

	// Token: 0x0400422A RID: 16938
	private Transform transform_0;
}
