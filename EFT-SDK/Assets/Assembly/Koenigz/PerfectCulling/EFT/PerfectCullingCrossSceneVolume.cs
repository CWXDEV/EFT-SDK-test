using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Koenigz.PerfectCulling.SamplingProviders;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E3D RID: 3645
	public sealed class PerfectCullingCrossSceneVolume : PerfectCullingBakingBehaviour, GClass775.GInterface29
	{
		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x00002050 File Offset: 0x00000250
		public static IReadOnlyCollection<PerfectCullingCrossSceneVolume> AllCrossSceneVolumes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06004C16 RID: 19478 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFineVolume
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingCrossSceneVolume.BakeDescriptor GetBakeDescriptor(PerfectCullingCrossSceneGroup group)
		{
			throw null;
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingCrossSceneVolume.BakeDescriptor GetBakeDescriptor(GuidReference groupId)
		{
			throw null;
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IReadOnlyCollection<int> GetUniqueBakeCellSizes()
		{
			throw null;
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 ToBakeCellSize(int type)
		{
			throw null;
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingCrossSceneVolume.BakeDescriptor GetBakeDescriptor(string groupId)
		{
			throw null;
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06004C1C RID: 19484 RVA: 0x00002050 File Offset: 0x00000250
		public string VolumeGuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C1E RID: 19486 RVA: 0x00002050 File Offset: 0x00000250
		[SerializeField]
		public Bounds volumeBakeBounds
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

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C20 RID: 19488 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 HandleSized
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

		// Token: 0x06004C21 RID: 19489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingCrossSceneVolume.BakeDescriptor AddBakeDescriptor()
		{
			throw null;
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasGroup(PerfectCullingCrossSceneGroup group)
		{
			throw null;
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixVolumeSize()
		{
			throw null;
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ScheduleBake(List<int> bakeDescriptors, bool forceBakeAllNow = true)
		{
			throw null;
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoteForceBakeSingle(int bakeDescId)
		{
			throw null;
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x00002050 File Offset: 0x00000250
		public float MaxCellSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingCrossSceneVolume.BakeDescriptor ActiveBakeDescriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x00002050 File Offset: 0x00000250
		public override PerfectCullingBakeData BakeData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetBakeData(PerfectCullingBakeData bakeData)
		{
			throw null;
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x00002050 File Offset: 0x00000250
		public override PerfectCullingBakeGroup[] bakeGroups
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

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C2D RID: 19501 RVA: 0x00002050 File Offset: 0x00000250
		public override List<Renderer> additionalOccluders
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

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06004C2E RID: 19502 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingVolumeBakeData volumeBakeData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeBake()
		{
			throw null;
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool PreBake()
		{
			throw null;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PostBake()
		{
			throw null;
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06004C32 RID: 19506 RVA: 0x00002050 File Offset: 0x00000250
		public int CellCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal List<Vector3> method_0(Vector3 overrideBakeCellSize, Space space = Space.World, int maxPoints = 0)
		{
			throw null;
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<Vector3> GetSamplingPositions(Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<Vector3?> GetSamplingPositionsEnum(Vector3 cellSize, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Vector3> GetSamplingPositions(Vector3 cellSize, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetIndexForWorldPos(Vector3 worldPos, out bool isOutOfBounds)
		{
			throw null;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Vector3 GetWorldPositionForIndex(int index)
		{
			throw null;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetSamplingPositionAt(int index, Vector3 cellSize, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetSamplingPositionAt(int index, Vector3 gridSize, Vector3 cellSize, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 GetSamplingPositionAtMT(int index, Vector3 cellSize, Vector3 volumeSize, Vector3 volumePosition, Quaternion volumeRotation, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CullAdditionalOccluders(ref HashSet<Renderer> additionalOccluders)
		{
			throw null;
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PostProcessBakeData(PerfectCullingBakeData data)
		{
			throw null;
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Start()
		{
			throw null;
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReplaceGroups(List<PerfectCullingCrossSceneGroup> newGroups)
		{
			throw null;
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetFrameHashNoOrientation(Vector3 pos, GClass1013<int> runtimeVolumesToUpdate = null, GClass1013<int> runtimeGroupsToUpdate = null)
		{
			throw null;
		}

		// Token: 0x04005719 RID: 22297
		public static readonly float[] BAKE_CELL_SIZES;

		// Token: 0x0400571A RID: 22298
		public static readonly string[] BAKE_CELL_DISPLAY_VALUES;

		// Token: 0x0400571B RID: 22299
		public static readonly string[] BAKE_CELL_DISPLAY_FILTER_VALUES;

		// Token: 0x0400571C RID: 22300
		public static readonly string[] LOAD_MODES;

		// Token: 0x0400571D RID: 22301
		private static readonly Color color_0;

		// Token: 0x0400571E RID: 22302
		public const int MAX_RUNTIME_VOLUMES = 4096;

		// Token: 0x0400571F RID: 22303
		public static readonly List<PerfectCullingCrossSceneVolume.GClass1046> AllRuntimeCrossGroupVolumes;

		// Token: 0x04005720 RID: 22304
		private static readonly List<PerfectCullingCrossSceneVolume> list_0;

		// Token: 0x04005721 RID: 22305
		private static List<int> list_1;

		// Token: 0x04005722 RID: 22306
		private List<PerfectCullingCrossSceneVolume.GClass1046> list_2;

		// Token: 0x04005723 RID: 22307
		[SerializeField]
		private string _volumeGuid;

		// Token: 0x04005724 RID: 22308
		[SerializeField]
		public Vector3 volumeSize;

		// Token: 0x04005725 RID: 22309
		public Bounds runtimeVolumeBounds;

		// Token: 0x04005726 RID: 22310
		[SerializeField]
		public List<PerfectCullingCrossSceneVolume.BakeDescriptor> bakeDescriptors;

		// Token: 0x04005727 RID: 22311
		private static PerfectCullingCrossSceneVolume.BakeDescriptor bakeDescriptor_0;

		// Token: 0x02000E3E RID: 3646
		[Serializable]
		public sealed class BakeDescriptor
		{
			// Token: 0x06004C45 RID: 19525 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PerfectCullingCrossSceneGroup GetGroup()
			{
				throw null;
			}

			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x06004C46 RID: 19526 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 bakeCellSize
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004C47 RID: 19527 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public List<Renderer> GetAdditionalOccluders()
			{
				throw null;
			}

			// Token: 0x06004C48 RID: 19528 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ValidateDescriptor()
			{
				throw null;
			}

			// Token: 0x04005728 RID: 22312
			public GuidReference crossSceneGroup;

			// Token: 0x04005729 RID: 22313
			public int bakeCellSizeType;

			// Token: 0x0400572A RID: 22314
			public int mergeIterations;

			// Token: 0x0400572B RID: 22315
			public StreamingVolumeBakeDataIndex streamingBakeData;

			// Token: 0x0400572C RID: 22316
			[NonSerialized]
			public bool debugSamplingPoints;

			// Token: 0x0400572D RID: 22317
			public PerfectCullingCrossSceneVolume.BakeDescriptor.LoadMode loadMode;

			// Token: 0x02000E3F RID: 3647
			public enum LoadMode
			{
				// Token: 0x0400572F RID: 22319
				Memory,
				// Token: 0x04005730 RID: 22320
				Stream,
				// Token: 0x04005731 RID: 22321
				AdaptiveGrid
			}
		}

		// Token: 0x02000E40 RID: 3648
		public sealed class GClass1046
		{
			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x06004C49 RID: 19529 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsFineVolume
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004C4A RID: 19530 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetSamplingPositionAtMT(int index)
			{
				throw null;
			}

			// Token: 0x06004C4B RID: 19531 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(GClass1013<ushort> indices, int newCounter)
			{
				throw null;
			}

			// Token: 0x06004C4C RID: 19532 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PerfectCullingCrossSceneVolume.GClass1046.EUpdateResult UpdateVisibleRenderersAtPointMT(Vector3 pos, int newCounter)
			{
				throw null;
			}

			// Token: 0x06004C4D RID: 19533 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GClass1013<ushort> GetPrecomputedIndices(int index)
			{
				throw null;
			}

			// Token: 0x06004C4E RID: 19534 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetIndexForWorldPosNoOrientationMT(Vector3 pos, out bool isOutOfBounds)
			{
				throw null;
			}

			// Token: 0x06004C4F RID: 19535 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetIndexForWorldPosMT(Vector3 pos, out bool isOutOfBounds)
			{
				throw null;
			}

			// Token: 0x06004C50 RID: 19536 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetIndexForWorldPosMT(Vector3 pos, Vector3 cellCount, Vector3 cellSize, out bool isOutOfBounds)
			{
				throw null;
			}

			// Token: 0x04005732 RID: 22322
			public PerfectCullingCrossSceneGroup group;

			// Token: 0x04005733 RID: 22323
			public int groupIndex;

			// Token: 0x04005734 RID: 22324
			public StreamingVolumeBakeDataIndex volumeBakeData;

			// Token: 0x04005735 RID: 22325
			public Vector3[] visibilityOffsets;

			// Token: 0x04005736 RID: 22326
			public Vector3 volumeSize;

			// Token: 0x04005737 RID: 22327
			public Vector3 volumePosition;

			// Token: 0x04005738 RID: 22328
			public Quaternion volumeRotation;

			// Token: 0x04005739 RID: 22329
			public string volumeName;

			// Token: 0x0400573A RID: 22330
			public Bounds runtimeBounds;

			// Token: 0x0400573B RID: 22331
			public int lastCellIndex;

			// Token: 0x0400573C RID: 22332
			public float reuseDistance2;

			// Token: 0x0400573D RID: 22333
			public object lockSampleQueue;

			// Token: 0x0400573E RID: 22334
			public object lockRemoveCells;

			// Token: 0x0400573F RID: 22335
			public object lockReuse;

			// Token: 0x04005740 RID: 22336
			public GClass1039 streamer;

			// Token: 0x04005741 RID: 22337
			public ExcludeInnerVolumeSamplingProvider excludeInnerVolumeSamplingProvider;

			// Token: 0x04005742 RID: 22338
			public Dictionary<int, GClass1013<ushort>> syncSamples;

			// Token: 0x04005743 RID: 22339
			public string parentVolumeName;

			// Token: 0x04005744 RID: 22340
			public string groupName;

			// Token: 0x04005745 RID: 22341
			public Vector3 runtimeCellCount;

			// Token: 0x02000E41 RID: 3649
			public enum EUpdateResult
			{
				// Token: 0x04005747 RID: 22343
				OutOfBounds,
				// Token: 0x04005748 RID: 22344
				Ok,
				// Token: 0x04005749 RID: 22345
				NoData
			}
		}

		// Token: 0x02000E42 RID: 3650
		[CompilerGenerated]
		private sealed class Class723
		{
			// Token: 0x06004C51 RID: 19537 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(PerfectCullingCrossSceneVolume.BakeDescriptor x)
			{
				throw null;
			}

			// Token: 0x0400574A RID: 22346
			public GuidReference groupId;
		}

		// Token: 0x02000E43 RID: 3651
		[CompilerGenerated]
		private sealed class Class724
		{
			// Token: 0x06004C52 RID: 19538 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(PerfectCullingCrossSceneVolume.BakeDescriptor x)
			{
				throw null;
			}

			// Token: 0x0400574B RID: 22347
			public string groupId;
		}
	}
}
