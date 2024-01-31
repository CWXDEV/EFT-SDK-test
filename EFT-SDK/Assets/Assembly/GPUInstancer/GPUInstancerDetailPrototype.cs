using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E80 RID: 3712
	[Serializable]
	public class GPUInstancerDetailPrototype : GPUInstancerPrototype
	{
		// Token: 0x06004D7D RID: 19837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture2DArray CreateTextureArray(Texture2D[] textureList)
		{
			throw null;
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float[] CreateAlphaMaskArray()
		{
			throw null;
		}

		// Token: 0x040059D8 RID: 23000
		public int prototypeIndex;

		// Token: 0x040059D9 RID: 23001
		public DetailRenderMode detailRenderMode;

		// Token: 0x040059DA RID: 23002
		public bool usePrototypeMesh;

		// Token: 0x040059DB RID: 23003
		public Texture2D prototypeTexture;

		// Token: 0x040059DC RID: 23004
		public Texture2D bumpMap;

		// Token: 0x040059DD RID: 23005
		public bool useCustomMaterialForTextureDetail;

		// Token: 0x040059DE RID: 23006
		public Material textureDetailCustomMaterial;

		// Token: 0x040059DF RID: 23007
		public int detailResolution;

		// Token: 0x040059E0 RID: 23008
		[Range(0f, 1f)]
		public float detailDensity;

		// Token: 0x040059E1 RID: 23009
		[Range(0f, 1f)]
		public float detailGrowDirection;

		// Token: 0x040059E2 RID: 23010
		public bool useCrossQuads;

		// Token: 0x040059E3 RID: 23011
		[Range(1f, 4f)]
		public int quadCount;

		// Token: 0x040059E4 RID: 23012
		public bool isBillboard;

		// Token: 0x040059E5 RID: 23013
		[Range(0.5f, 1f)]
		public float billboardDistance;

		// Token: 0x040059E6 RID: 23014
		public bool billboardDistanceDebug;

		// Token: 0x040059E7 RID: 23015
		public Color billboardDistanceDebugColor;

		// Token: 0x040059E8 RID: 23016
		public bool billboardFaceCamPos;

		// Token: 0x040059E9 RID: 23017
		public Color detailHealthyColor;

		// Token: 0x040059EA RID: 23018
		public Color detailDryColor;

		// Token: 0x040059EB RID: 23019
		public float noiseSpread;

		// Token: 0x040059EC RID: 23020
		[Range(0f, 1f)]
		public float ambientOcclusion;

		// Token: 0x040059ED RID: 23021
		[Range(0f, 1f)]
		public float gradientPower;

		// Token: 0x040059EE RID: 23022
		public Color windWaveTintColor;

		// Token: 0x040059EF RID: 23023
		[Range(0f, 1f)]
		public float windIdleSway;

		// Token: 0x040059F0 RID: 23024
		public bool windWavesOn;

		// Token: 0x040059F1 RID: 23025
		[Range(0f, 1f)]
		public float windWaveTint;

		// Token: 0x040059F2 RID: 23026
		[Range(0f, 1f)]
		public float windWaveSway;

		// Token: 0x040059F3 RID: 23027
		public Vector4 detailScale;

		// Token: 0x040059F4 RID: 23028
		public int[] cachedDensityMapForInstance;

		// Token: 0x040059F5 RID: 23029
		public float densityFadeFactor;

		// Token: 0x040059F6 RID: 23030
		public int densityMapIndex;

		// Token: 0x040059F7 RID: 23031
		public Vector4 densityChanelMask;

		// Token: 0x040059F8 RID: 23032
		public Vector2 densityMinMax;

		// Token: 0x040059F9 RID: 23033
		public bool useDensityMask;

		// Token: 0x040059FA RID: 23034
		public bool useCustomHealthyDryNoiseTexture;

		// Token: 0x040059FB RID: 23035
		public Texture2D healthyDryNoiseTexture;

		// Token: 0x040059FC RID: 23036
		public List<Vector4> alphaChannelMask;

		// Token: 0x040059FD RID: 23037
		public bool useAlphaMask;

		// Token: 0x040059FE RID: 23038
		public bool useVertexFit;

		// Token: 0x040059FF RID: 23039
		public bool useTerrainNormal;

		// Token: 0x04005A00 RID: 23040
		[Range(0f, 5f)]
		public float gradientNormalHeight;
	}
}
