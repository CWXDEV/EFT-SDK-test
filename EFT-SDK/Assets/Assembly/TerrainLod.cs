using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BD8 RID: 3032
[ExecuteInEditMode]
public class TerrainLod : MonoBehaviour
{
	// Token: 0x06004202 RID: 16898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSettings(bool disableTerrainDraw, bool disableTerrainTreesDraw)
	{
		throw null;
	}

	// Token: 0x17000AC1 RID: 2753
	// (get) Token: 0x06004204 RID: 16900 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004203 RID: 16899 RVA: 0x00002050 File Offset: 0x00000250
	public bool TerrainIsVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyLod()
	{
		throw null;
	}

	// Token: 0x04004B0A RID: 19210
	[SerializeField]
	private Terrain _terrain;

	// Token: 0x04004B0B RID: 19211
	[SerializeField]
	private GameObject _terrainLod;

	// Token: 0x04004B0C RID: 19212
	private bool bool_0;

	// Token: 0x04004B0D RID: 19213
	private bool bool_1;

	// Token: 0x04004B0E RID: 19214
	private bool bool_2;
}
