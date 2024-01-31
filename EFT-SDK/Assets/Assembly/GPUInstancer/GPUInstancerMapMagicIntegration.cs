using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EC9 RID: 3785
	[ExecuteInEditMode]
	public class GPUInstancerMapMagicIntegration : MonoBehaviour
	{
		// Token: 0x06004EF4 RID: 20212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCamera(Camera camera)
		{
			throw null;
		}

		// Token: 0x04005BAC RID: 23468
		public List<GPUInstancerPrototype> detailPrototypes;

		// Token: 0x04005BAD RID: 23469
		public List<GPUInstancerPrototype> treePrototypes;

		// Token: 0x04005BAE RID: 23470
		public List<GPUInstancerPrototype> prefabPrototypes;

		// Token: 0x04005BAF RID: 23471
		public GPUInstancerTerrainSettings terrainSettings;

		// Token: 0x04005BB0 RID: 23472
		public bool importDetails;

		// Token: 0x04005BB1 RID: 23473
		public bool importTrees;

		// Token: 0x04005BB2 RID: 23474
		public bool importObjects;

		// Token: 0x04005BB3 RID: 23475
		private bool bool_0;

		// Token: 0x04005BB4 RID: 23476
		public bool isOpticCamera;

		// Token: 0x04005BB5 RID: 23477
		public GPUInstancerCameraData cameraData;

		// Token: 0x04005BB6 RID: 23478
		public bool isFrustumCulling;

		// Token: 0x04005BB7 RID: 23479
		public bool isOcclusionCulling;

		// Token: 0x04005BB8 RID: 23480
		public float minCullingDistance;

		// Token: 0x04005BB9 RID: 23481
		public int detailLayer;

		// Token: 0x04005BBA RID: 23482
		public bool detailRunInThreads;

		// Token: 0x04005BBB RID: 23483
		public bool useSinglePrefabManager;

		// Token: 0x04005BBC RID: 23484
		public bool disableMeshRenderers;

		// Token: 0x04005BBD RID: 23485
		public bool prefabRunInThreads;

		// Token: 0x04005BBE RID: 23486
		public List<DetailPrototype> terrainDetailPrototypes;

		// Token: 0x04005BBF RID: 23487
		public List<TreePrototype> terrainTreePrototypes;

		// Token: 0x04005BC0 RID: 23488
		public List<GameObject> prefabs;

		// Token: 0x04005BC1 RID: 23489
		public List<GameObject> selectedPrefabs;

		// Token: 0x04005BC2 RID: 23490
		public GPUInstancerPrefabManager prefabManagerInstance;
	}
}
