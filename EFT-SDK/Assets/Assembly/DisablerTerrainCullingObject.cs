using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BC2 RID: 3010
[ExecuteInEditMode]
public class DisablerTerrainCullingObject : DisablerCullingObjectBase
{
	// Token: 0x0600418E RID: 16782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Awake()
	{
		throw null;
	}

	// Token: 0x0600418F RID: 16783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SetComponentsEnabled(bool hasEntered)
	{
		throw null;
	}

	// Token: 0x04004AA4 RID: 19108
	public Terrain Terrain;

	// Token: 0x04004AA5 RID: 19109
	public TerrainLod TerrainLod;

	// Token: 0x04004AA6 RID: 19110
	public bool IsDisableTerrainDraw;

	// Token: 0x04004AA7 RID: 19111
	public bool IsDisableTerrainTreesDraw;
}
