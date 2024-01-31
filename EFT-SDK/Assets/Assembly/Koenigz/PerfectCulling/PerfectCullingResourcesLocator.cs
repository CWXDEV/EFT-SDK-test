using System;
using System.Runtime.CompilerServices;
using Koenigz.PerfectCulling.EFT.Autotest;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000D9C RID: 3484
	public class PerfectCullingResourcesLocator : ScriptableObject
	{
		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingResourcesLocator Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040054DE RID: 21726
		private static PerfectCullingResourcesLocator perfectCullingResourcesLocator_0;

		// Token: 0x040054DF RID: 21727
		public Material UnlitTagMaterial;

		// Token: 0x040054E0 RID: 21728
		public PerfectCullingSettings Settings;

		// Token: 0x040054E1 RID: 21729
		public PerfectCullingColorTable ColorTable;

		// Token: 0x040054E2 RID: 21730
		public PerfectCullingVolumeBakeData tempVolumeBakeData;

		// Token: 0x040054E3 RID: 21731
		public Shader[] ExcludeTransparentShaders;

		// Token: 0x040054E4 RID: 21732
		public Shader[] ValidTransparentShaders;

		// Token: 0x040054E5 RID: 21733
		public Material ProxyLightMaterial;

		// Token: 0x040054E6 RID: 21734
		public Material RainbowProxyMaterial;

		// Token: 0x040054E7 RID: 21735
		public GameObject QuadPrefab;

		// Token: 0x040054E8 RID: 21736
		public Mesh[] LightSpheres;

		// Token: 0x040054E9 RID: 21737
		public Material AutotestRendererMaterialOpaque;

		// Token: 0x040054EA RID: 21738
		public Material AutotestRendererMaterialTransparent;

		// Token: 0x040054EB RID: 21739
		public Material AutotestProxyMaterialOpaque;

		// Token: 0x040054EC RID: 21740
		public Material AutotestProxyMaterialTransparent;

		// Token: 0x040054ED RID: 21741
		public PerfectCullingAutoTestCamera AutoTestCameraPrefab;

		// Token: 0x040054EE RID: 21742
		public ComputeShader PointExtractorComputeShader;

		// Token: 0x040054EF RID: 21743
		public GameObject AutotestProxyPrefab;

		// Token: 0x040054F0 RID: 21744
		public Material AutotestTerrainMaterial;
	}
}
