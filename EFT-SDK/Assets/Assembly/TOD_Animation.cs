using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200009A RID: 154
public class TOD_Animation : MonoBehaviour
{
	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
	public Vector4 CloudUV
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
	public Vector4 OffsetUV
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Start()
	{
		throw null;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Update()
	{
		throw null;
	}

	// Token: 0x0400033A RID: 826
	[Tooltip("Wind direction in degrees.")]
	public float WindDegrees;

	// Token: 0x0400033B RID: 827
	[Tooltip("Speed of the wind that is acting on the clouds.")]
	public float WindSpeed;

	// Token: 0x0400033C RID: 828
	[Tooltip("Adjust the cloud coordinates when the sky dome moves.")]
	public bool WorldSpaceCloudUV;

	// Token: 0x0400033D RID: 829
	[Tooltip("Randomize the cloud coordinates at startup.")]
	public bool RandomInitialCloudUV;

	// Token: 0x0400033E RID: 830
	[CompilerGenerated]
	private Vector4 vector4_0;

	// Token: 0x0400033F RID: 831
	public Vector2 CloudPosition;

	// Token: 0x04000340 RID: 832
	private TOD_Sky tod_Sky_0;
}
