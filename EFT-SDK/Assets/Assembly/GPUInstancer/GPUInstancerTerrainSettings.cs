using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E96 RID: 3734
	public class GPUInstancerTerrainSettings : ScriptableObject
	{
		// Token: 0x06004DB6 RID: 19894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture2D GetHealthyDryNoiseTexture(GPUInstancerDetailPrototype detailPrototype)
		{
			throw null;
		}

		// Token: 0x04005A83 RID: 23171
		public bool isOptic;

		// Token: 0x04005A84 RID: 23172
		public string terrainDataGUID;

		// Token: 0x04005A85 RID: 23173
		public float maxDetailDistance;

		// Token: 0x04005A86 RID: 23174
		public float maxDetailDistanceLegacy;

		// Token: 0x04005A87 RID: 23175
		[Range(0f, 2500f)]
		public float maxTreeDistance;

		// Token: 0x04005A88 RID: 23176
		public Texture2D healthyDryNoiseTexture;

		// Token: 0x04005A89 RID: 23177
		public Texture2D windWaveNormalTexture;

		// Token: 0x04005A8A RID: 23178
		public bool autoSPCellSize;

		// Token: 0x04005A8B RID: 23179
		[Range(25f, 500f)]
		public int preferedSPCellSize;

		// Token: 0x04005A8C RID: 23180
		[Range(0f, 1f)]
		public float detailDensity;

		// Token: 0x04005A8D RID: 23181
		[Range(1f, 10f)]
		public int resizeDensityCount;

		// Token: 0x04005A8E RID: 23182
		public string warningText;

		// Token: 0x04005A8F RID: 23183
		public Color wavingGrassTint;

		// Token: 0x04005A90 RID: 23184
		public float frustumOffset;

		// Token: 0x04005A91 RID: 23185
		public Texture2DArray densityMapArray;
	}
}
