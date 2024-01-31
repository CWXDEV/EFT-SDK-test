using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000D3D RID: 3389
public static class GClass977
{
	// Token: 0x17000B71 RID: 2929
	// (get) Token: 0x0600481B RID: 18459 RVA: 0x00002050 File Offset: 0x00000250
	public static int HighPolyOcclusionMask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B72 RID: 2930
	// (get) Token: 0x0600481C RID: 18460 RVA: 0x00002050 File Offset: 0x00000250
	public static int LowPolyOcclusionMask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600481D RID: 18461 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsOcclusionTestValid(float effect)
	{
		throw null;
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNeedVerticalOcclusion(Vector3 soundPosition, Vector3 listenerPosition)
	{
		throw null;
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculateVerticalDot(Vector3 soundPosition, Vector3 listenerPosition)
	{
		throw null;
	}

	// Token: 0x06004820 RID: 18464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SimpleOcclusionTest(Vector3 soundPos, Vector3 listenerPos)
	{
		throw null;
	}

	// Token: 0x06004821 RID: 18465 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SimpleOcclusionTest(Vector3 soundPos, Vector3 listenerPos, int mask)
	{
		throw null;
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SimpleOcclusionTest(Vector3 soundPos, Vector3 listenerPos, float distance, int mask)
	{
		throw null;
	}

	// Token: 0x040052E0 RID: 21216
	public const float LOWER_OCCLUSION_FREQUENCY = 450f;

	// Token: 0x040052E1 RID: 21217
	public const float UPPER_OCCLUSION_FREQUENCY = 700f;

	// Token: 0x040052E2 RID: 21218
	public const float WALL_OCCLUSION_FREQUENCY = 1600f;

	// Token: 0x040052E3 RID: 21219
	public const float FULL_OCCLUSION_FREQUENCY = 0f;

	// Token: 0x040052E4 RID: 21220
	public const float DEFAULT_OCCLUSION_FREQUENCY = 5000f;

	// Token: 0x040052E5 RID: 21221
	private const float float_0 = 0.55f;
}
