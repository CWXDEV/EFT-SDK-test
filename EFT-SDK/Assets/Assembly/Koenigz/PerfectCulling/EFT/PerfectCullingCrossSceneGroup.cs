using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E30 RID: 3632
	[RequireComponent(typeof(GuidComponent))]
	public sealed class PerfectCullingCrossSceneGroup : MonoBehaviour
	{
		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x00002050 File Offset: 0x00000250
		public Transform GroupRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06004BBB RID: 19387 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds GroupBoundingBox
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LODGroup[] GetLODGroups()
		{
			throw null;
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetDistanceToNearestRendererSquared(Vector3 point)
		{
			throw null;
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetBakeHashDefault()
		{
			throw null;
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RefreshBakeGroups(PerfectCullingCrossSceneGroup group)
		{
			throw null;
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RefreshSharedOccluders(PerfectCullingCrossSceneGroup group)
		{
			throw null;
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HashSet<Renderer> GetSharedOccluderRenderers()
		{
			throw null;
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HashSet<Renderer> GetGroupRenderers(Transform groupRoot, bool applyTypeFiltering = true, bool includeInactiveRenderers = true)
		{
			throw null;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool RendererFilter(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x00002050 File Offset: 0x00000250
		public ValueTuple<int, int> SwitchStats
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPostLevelLoaded()
		{
			throw null;
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_0(PerfectCullingCrossSceneVolume.GClass1046 a, PerfectCullingCrossSceneVolume.GClass1046 b)
		{
			throw null;
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool UpdateVisibleSetsMT(PerfectCullingCamera cam)
		{
			throw null;
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSwitchQueuesMT()
		{
			throw null;
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5()
		{
			throw null;
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_6()
		{
			throw null;
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_7()
		{
			throw null;
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateRuntimeProxies()
		{
			throw null;
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteRuntimeProxies()
		{
			throw null;
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_8()
		{
			throw null;
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(ushort[] indices, int newCounter)
		{
			throw null;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_10(GClass1013<ushort> visibilityIndices)
		{
			throw null;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_11(CullingGroupData data)
		{
			throw null;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddHiddenIndex(Vector2Int v)
		{
			throw null;
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveHiddenIndex(Vector2Int v)
		{
			throw null;
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_13(ushort index)
		{
			throw null;
		}

		// Token: 0x040056BF RID: 22207
		public static readonly List<PerfectCullingCrossSceneGroup> AllCrossGroups;

		// Token: 0x040056C0 RID: 22208
		[SerializeField]
		[HideInInspector]
		public PerfectCullingBakeGroup[] bakeGroups;

		// Token: 0x040056C1 RID: 22209
		[HideInInspector]
		[SerializeField]
		public GameObject[] sharedOccluders;

		// Token: 0x040056C2 RID: 22210
		[HideInInspector]
		[SerializeField]
		public GameObject[] sharedOccludeeOccluders;

		// Token: 0x040056C3 RID: 22211
		[SerializeField]
		public SharedOccluder sharedOccluder;

		// Token: 0x040056C4 RID: 22212
		[SerializeField]
		public bool debugDrawVisibilityLines;

		// Token: 0x040056C5 RID: 22213
		[SerializeField]
		public bool lightsOnly;

		// Token: 0x040056C6 RID: 22214
		[SerializeField]
		public bool disableOnRuntime;

		// Token: 0x040056C7 RID: 22215
		[SerializeField]
		public BakeBatch[] bakeBatches;

		// Token: 0x040056C8 RID: 22216
		[SerializeField]
		public bool useGroundSuperSampling;

		// Token: 0x040056C9 RID: 22217
		[SerializeField]
		public bool disableGroupOnPointSample;

		// Token: 0x040056CA RID: 22218
		[SerializeField]
		public bool allowGroupCulling;

		// Token: 0x040056CB RID: 22219
		[SerializeField]
		public Transform groupRoot;

		// Token: 0x040056CC RID: 22220
		[SerializeField]
		private Bounds _groupBoundingBox;

		// Token: 0x040056CD RID: 22221
		[SerializeField]
		public bool AllowAdaptiveGridMapping;

		// Token: 0x040056CE RID: 22222
		private GClass1013<ushort> gclass1013_0;

		// Token: 0x040056CF RID: 22223
		private GClass1013<ushort> gclass1013_1;

		// Token: 0x040056D0 RID: 22224
		private ValueTuple<int, int> valueTuple_0;

		// Token: 0x040056D1 RID: 22225
		private volatile int int_0;

		// Token: 0x040056D2 RID: 22226
		public volatile int counterMainThread;

		// Token: 0x040056D3 RID: 22227
		public volatile int counterWorkThread;

		// Token: 0x040056D4 RID: 22228
		public object lockUpdateVisibilityQueues;

		// Token: 0x040056D5 RID: 22229
		public List<PerfectCullingCrossSceneVolume.GClass1046> _runtimeSharedVolumes;

		// Token: 0x040056D6 RID: 22230
		public string runtimeGroupName;

		// Token: 0x040056D7 RID: 22231
		private List<Vector2Int> list_0;

		// Token: 0x02000E31 RID: 3633
		[CompilerGenerated]
		[Serializable]
		private sealed class Class716
		{
			// Token: 0x06004BE2 RID: 19426 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Renderer rend)
			{
				throw null;
			}

			// Token: 0x040056D8 RID: 22232
			public static readonly PerfectCullingCrossSceneGroup.Class716 class716_0;

			// Token: 0x040056D9 RID: 22233
			public static Predicate<Renderer> predicate_0;
		}
	}
}
