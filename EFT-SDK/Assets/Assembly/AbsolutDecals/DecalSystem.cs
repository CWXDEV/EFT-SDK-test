using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

namespace AbsolutDecals
{
	// Token: 0x02000C4C RID: 3148
	[ExecuteInEditMode]
	[Serializable]
	public class DecalSystem : MonoBehaviourSingleton<DecalSystem>
	{
		// Token: 0x06004492 RID: 17554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSkinnedMeshSceneData()
		{
			throw null;
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateNonStaticSceneData()
		{
			throw null;
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSceneData(bool updateStatic)
		{
			throw null;
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStaticSceneData()
		{
			throw null;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Renderer currentRenderer, bool forStatic)
		{
			throw null;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterRenderer(GameObject go)
		{
			throw null;
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BakeAndSaveAll()
		{
			throw null;
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecalSystem.SingleDecal GetDecal(MaterialType typeOfMaterial)
		{
			throw null;
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool BakeUniqueDecal(DecalProjector projector)
		{
			throw null;
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecalSystem.BakeResult BakeDecal(DecalProjector projector, bool bakeToReusableMesh)
		{
			throw null;
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DecalSystem.BakeResult method_2(Material projectorMaterial, GClass907 projectorHelper, DecalProjector projector)
		{
			throw null;
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecalSystem.BakeResult BakeToSkinnedMesh(DecalMeshClass meshToBake, DecalProjector projector)
		{
			throw null;
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetRelativeTransform(SkinnedMeshRenderer doll, out bool success)
		{
			throw null;
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private SkinnedMeshRenderer method_3(SkinnedMeshRenderer doll)
		{
			throw null;
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DecalSystem.BakeResult method_4(Material projectorMaterial, GClass907 projectorHelper, DecalProjector projector)
		{
			throw null;
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass907 projectorHelper, MeshFilter filter, Mesh mesh, DecalMeshClass tmpMesh)
		{
			throw null;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(DecalProjector projector, string namePrefix, Material projectorMaterial, GClass907 projectorHelper, out MeshFilter resultFilter, DecalMeshClass tmpMeshPrecalc = null)
		{
			throw null;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnbakeDecal(DecalProjector projector)
		{
			throw null;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecalMeshClass GetDecalMesh(DecalProjector projector, bool inProjectorSpace)
		{
			throw null;
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearStaticLists()
		{
			throw null;
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy(bool destroyProjectors)
		{
			throw null;
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(GClass907 projector, Dictionary<DecalProjector, GClass907> projectorHelpers)
		{
			throw null;
		}

		// Token: 0x04004E80 RID: 20096
		public DecalSystem.SingleDecal DefaultMaterial;

		// Token: 0x04004E81 RID: 20097
		public DecalSystem.SingleDecal BloodOnWallsMaterial;

		// Token: 0x04004E82 RID: 20098
		public DecalSystem.SingleDecal[] Decals;

		// Token: 0x04004E83 RID: 20099
		private List<Renderer> _renderers;

		// Token: 0x04004E84 RID: 20100
		private List<Mesh> _meshes;

		// Token: 0x04004E85 RID: 20101
		private List<DecalMeshClass> _tmpMeshes;

		// Token: 0x04004E86 RID: 20102
		private List<Transform> _transforms;

		// Token: 0x04004E87 RID: 20103
		[SerializeField]
		private List<Renderer> _staticRenderers;

		// Token: 0x04004E88 RID: 20104
		[SerializeField]
		private List<Mesh> _staticMeshes;

		// Token: 0x04004E89 RID: 20105
		[SerializeField]
		private List<DecalMeshClass> _staticTmpMeshes;

		// Token: 0x04004E8A RID: 20106
		[SerializeField]
		private List<Transform> _staticTransforms;

		// Token: 0x04004E8B RID: 20107
		public int count;

		// Token: 0x04004E8C RID: 20108
		private static List<SkinnedMeshRenderer> _skinnedMeshRenderers;

		// Token: 0x04004E8D RID: 20109
		private static List<BoneWeight[]> _skinnedMeshBoneWeights;

		// Token: 0x04004E8E RID: 20110
		private static List<Transform> _skinnedMeshTransforms;

		// Token: 0x04004E8F RID: 20111
		[SerializeField]
		private float _offset;

		// Token: 0x04004E90 RID: 20112
		[SerializeField]
		private string[] _ignoreProjectorTags;

		// Token: 0x04004E91 RID: 20113
		[SerializeField]
		private LayerMask _ingoreDecalsLayers;

		// Token: 0x04004E92 RID: 20114
		[SerializeField]
		private int _maxDecalsOnSkinMesh;

		// Token: 0x04004E93 RID: 20115
		private const string IgnoreProjectorTag = "DecalIgnore";

		// Token: 0x04004E94 RID: 20116
		private static DecalMeshClass _terrainMesh;

		// Token: 0x04004E95 RID: 20117
		private const int _maxUniqueDecalQueueCapasity = 20;

		// Token: 0x04004E96 RID: 20118
		private static GameObject _decalsParent;

		// Token: 0x04004E97 RID: 20119
		[SerializeField]
		private int MaxMeshVerticies;

		// Token: 0x04004E98 RID: 20120
		[SerializeField]
		private bool _includeTerrain;

		// Token: 0x04004E99 RID: 20121
		private static Dictionary<Material, List<MeshFilter>> _bakedMeshes;

		// Token: 0x04004E9A RID: 20122
		private static Dictionary<Material, MeshFilter> _bakedReusableMeshes;

		// Token: 0x04004E9B RID: 20123
		private static Dictionary<MeshFilter, List<GClass907>> _reusableMeshesProjectors;

		// Token: 0x04004E9C RID: 20124
		private static Dictionary<DecalProjector, GClass907> _projectors;

		// Token: 0x04004E9D RID: 20125
		private static Dictionary<DecalProjector, GameObject> _uniqueMeshes;

		// Token: 0x04004E9E RID: 20126
		private static Queue<GameObject> _uniqueMeshObjects;

		// Token: 0x04004E9F RID: 20127
		private static Dictionary<SkinnedMeshRenderer, List<SkinnedMeshRenderer>> _skinnedDecals;

		// Token: 0x04004EA0 RID: 20128
		private static int _currentIndex;

		// Token: 0x04004EA1 RID: 20129
		public Action<List<Mesh>> OnAssetsReadyToSave;

		// Token: 0x04004EA2 RID: 20130
		public static Action CallProjectors;

		// Token: 0x04004EA4 RID: 20132
		private List<Mesh> _skinnedMeshes;

		// Token: 0x02000C4D RID: 3149
		public enum BakeResult
		{
			// Token: 0x04004EA6 RID: 20134
			Unsuccess,
			// Token: 0x04004EA7 RID: 20135
			BakedToSkinnedMesh,
			// Token: 0x04004EA8 RID: 20136
			BakedToMesh
		}

		// Token: 0x02000C4E RID: 3150
		[Serializable]
		public class SingleDecal
		{
			// Token: 0x060044AF RID: 17583 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetScale()
			{
				throw null;
			}

			// Token: 0x060044B0 RID: 17584 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector2[] GetUv()
			{
				throw null;
			}

			// Token: 0x060044B1 RID: 17585 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x04004EA9 RID: 20137
			public Material DecalMaterial;

			// Token: 0x04004EAA RID: 20138
			public int TileSheetRows;

			// Token: 0x04004EAB RID: 20139
			public int TileSheetColumns;

			// Token: 0x04004EAC RID: 20140
			public bool UseRandomScale;

			// Token: 0x04004EAD RID: 20141
			public Vector3 MaxScale;

			// Token: 0x04004EAE RID: 20142
			public Vector3 MinScale;

			// Token: 0x04004EAF RID: 20143
			public bool CanRotate;

			// Token: 0x04004EB0 RID: 20144
			public MaterialType TypeOfMaterial;

			// Token: 0x04004EB1 RID: 20145
			private bool _isPrecalculated;

			// Token: 0x04004EB2 RID: 20146
			private Vector2[][] uvSet;
		}
	}
}
