using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace UnityEngine.AI
{
	// Token: 0x020030A1 RID: 12449
	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[DefaultExecutionOrder(-102)]
	[ExecuteInEditMode]
	public class NavMeshSurface : MonoBehaviour
	{
		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600F446 RID: 62534 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F447 RID: 62535 RVA: 0x00002050 File Offset: 0x00000250
		public int agentTypeID
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

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600F448 RID: 62536 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F449 RID: 62537 RVA: 0x00002050 File Offset: 0x00000250
		public CollectObjects collectObjects
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

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600F44A RID: 62538 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F44B RID: 62539 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 size
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

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600F44C RID: 62540 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F44D RID: 62541 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 center
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

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0600F44E RID: 62542 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F44F RID: 62543 RVA: 0x00002050 File Offset: 0x00000250
		public LayerMask layerMask
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

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0600F450 RID: 62544 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F451 RID: 62545 RVA: 0x00002050 File Offset: 0x00000250
		public NavMeshCollectGeometry useGeometry
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

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0600F452 RID: 62546 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F453 RID: 62547 RVA: 0x00002050 File Offset: 0x00000250
		public int defaultArea
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

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0600F454 RID: 62548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F455 RID: 62549 RVA: 0x00002050 File Offset: 0x00000250
		public bool ignoreNavMeshAgent
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

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0600F456 RID: 62550 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F457 RID: 62551 RVA: 0x00002050 File Offset: 0x00000250
		public bool ignoreNavMeshObstacle
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

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600F458 RID: 62552 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F459 RID: 62553 RVA: 0x00002050 File Offset: 0x00000250
		public bool overrideTileSize
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

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600F45A RID: 62554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F45B RID: 62555 RVA: 0x00002050 File Offset: 0x00000250
		public int tileSize
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

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0600F45C RID: 62556 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F45D RID: 62557 RVA: 0x00002050 File Offset: 0x00000250
		public bool overrideVoxelSize
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

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600F45E RID: 62558 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F45F RID: 62559 RVA: 0x00002050 File Offset: 0x00000250
		public float voxelSize
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

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600F460 RID: 62560 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F461 RID: 62561 RVA: 0x00002050 File Offset: 0x00000250
		public bool buildHeightMesh
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

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600F462 RID: 62562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F463 RID: 62563 RVA: 0x00002050 File Offset: 0x00000250
		public NavMeshData navMeshData
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

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0600F464 RID: 62564 RVA: 0x00002050 File Offset: 0x00000250
		public static List<NavMeshSurface> activeSurfaces
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F465 RID: 62565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600F466 RID: 62566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600F467 RID: 62567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddData()
		{
			throw null;
		}

		// Token: 0x0600F468 RID: 62568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveData()
		{
			throw null;
		}

		// Token: 0x0600F469 RID: 62569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NavMeshBuildSettings GetBuildSettings()
		{
			throw null;
		}

		// Token: 0x0600F46A RID: 62570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BuildNavMesh()
		{
			throw null;
		}

		// Token: 0x0600F46B RID: 62571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			throw null;
		}

		// Token: 0x0600F46C RID: 62572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(NavMeshSurface surface)
		{
			throw null;
		}

		// Token: 0x0600F46D RID: 62573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(NavMeshSurface surface)
		{
			throw null;
		}

		// Token: 0x0600F46E RID: 62574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2()
		{
			throw null;
		}

		// Token: 0x0600F46F RID: 62575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ref List<NavMeshBuildSource> sources)
		{
			throw null;
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<NavMeshBuildSource> method_1()
		{
			throw null;
		}

		// Token: 0x0600F471 RID: 62577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector3 Abs(Vector3 v)
		{
			throw null;
		}

		// Token: 0x0600F472 RID: 62578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Bounds smethod_3(Matrix4x4 mat, Bounds bounds)
		{
			throw null;
		}

		// Token: 0x0600F473 RID: 62579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Bounds method_2(List<NavMeshBuildSource> sources)
		{
			throw null;
		}

		// Token: 0x0600F474 RID: 62580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3()
		{
			throw null;
		}

		// Token: 0x0600F475 RID: 62581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400FA72 RID: 64114
		[SerializeField]
		private int m_AgentTypeID;

		// Token: 0x0400FA73 RID: 64115
		[SerializeField]
		private CollectObjects m_CollectObjects;

		// Token: 0x0400FA74 RID: 64116
		[SerializeField]
		private Vector3 m_Size;

		// Token: 0x0400FA75 RID: 64117
		[SerializeField]
		private Vector3 m_Center;

		// Token: 0x0400FA76 RID: 64118
		[SerializeField]
		private LayerMask m_LayerMask;

		// Token: 0x0400FA77 RID: 64119
		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry;

		// Token: 0x0400FA78 RID: 64120
		[SerializeField]
		private int m_DefaultArea;

		// Token: 0x0400FA79 RID: 64121
		[SerializeField]
		private bool m_IgnoreNavMeshAgent;

		// Token: 0x0400FA7A RID: 64122
		[SerializeField]
		private bool m_IgnoreNavMeshObstacle;

		// Token: 0x0400FA7B RID: 64123
		[SerializeField]
		private bool m_IgnoreAudio;

		// Token: 0x0400FA7C RID: 64124
		[SerializeField]
		private bool m_IgnoreSpawns;

		// Token: 0x0400FA7D RID: 64125
		[SerializeField]
		private bool m_IgnoreQuests;

		// Token: 0x0400FA7E RID: 64126
		[SerializeField]
		private bool m_OverrideTileSize;

		// Token: 0x0400FA7F RID: 64127
		[SerializeField]
		private int m_TileSize;

		// Token: 0x0400FA80 RID: 64128
		[SerializeField]
		private bool m_OverrideVoxelSize;

		// Token: 0x0400FA81 RID: 64129
		[SerializeField]
		private float m_VoxelSize;

		// Token: 0x0400FA82 RID: 64130
		[SerializeField]
		private bool m_BuildHeightMesh;

		// Token: 0x0400FA83 RID: 64131
		[SerializeField]
		[FormerlySerializedAs("m_BakedNavMeshData")]
		private NavMeshData m_NavMeshData;

		// Token: 0x0400FA84 RID: 64132
		private NavMeshDataInstance navMeshDataInstance_0;

		// Token: 0x0400FA85 RID: 64133
		private Vector3 vector3_0;

		// Token: 0x0400FA86 RID: 64134
		private Quaternion quaternion_0;

		// Token: 0x0400FA87 RID: 64135
		private static readonly List<NavMeshSurface> list_0;

		// Token: 0x020030A2 RID: 12450
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3133
		{
			// Token: 0x0600F476 RID: 62582 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(NavMeshModifierVolume x)
			{
				throw null;
			}

			// Token: 0x0600F477 RID: 62583 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(NavMeshModifier x)
			{
				throw null;
			}

			// Token: 0x0600F478 RID: 62584 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F479 RID: 62585 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F47A RID: 62586 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F47B RID: 62587 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F47C RID: 62588 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F47D RID: 62589 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_7(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F47E RID: 62590 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_8(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0600F47F RID: 62591 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_9(NavMeshBuildSource x)
			{
				throw null;
			}

			// Token: 0x0400FA88 RID: 64136
			public static readonly NavMeshSurface.Class3133 class3133_0;

			// Token: 0x0400FA89 RID: 64137
			public static Predicate<NavMeshModifierVolume> predicate_0;

			// Token: 0x0400FA8A RID: 64138
			public static Predicate<NavMeshModifier> predicate_1;

			// Token: 0x0400FA8B RID: 64139
			public static Predicate<NavMeshBuildSource> predicate_2;

			// Token: 0x0400FA8C RID: 64140
			public static Predicate<NavMeshBuildSource> predicate_3;

			// Token: 0x0400FA8D RID: 64141
			public static Predicate<NavMeshBuildSource> predicate_4;

			// Token: 0x0400FA8E RID: 64142
			public static Predicate<NavMeshBuildSource> predicate_5;

			// Token: 0x0400FA8F RID: 64143
			public static Predicate<NavMeshBuildSource> predicate_6;

			// Token: 0x0400FA90 RID: 64144
			public static Predicate<NavMeshBuildSource> predicate_7;

			// Token: 0x0400FA91 RID: 64145
			public static Predicate<NavMeshBuildSource> predicate_8;

			// Token: 0x0400FA92 RID: 64146
			public static Predicate<NavMeshBuildSource> predicate_9;
		}
	}
}
