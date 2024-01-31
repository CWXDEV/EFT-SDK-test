using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DF7 RID: 3575
	[DisallowMultipleComponent]
	public sealed class CrossSceneCullingGroupPreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x00002050 File Offset: 0x00000250
		public GuidReference[] CullingGroups
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GuidReference[] newCullingGroups)
		{
			throw null;
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEndContentCollect()
		{
			throw null;
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] CollectBakeGroups()
		{
			throw null;
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BakeBatch[] CreateBakeBatches(PerfectCullingBakeGroup[] inputGroups)
		{
			throw null;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BakeBatch[] GetBakeBatches()
		{
			throw null;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrepareRuntimeContent()
		{
			throw null;
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override LODGroup[] GetLODGroups()
		{
			throw null;
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingBakeGroup[] GetBakeGroups()
		{
			throw null;
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override SharedOccluder GenerateSharedOccluder()
		{
			throw null;
		}

		// Token: 0x0400561E RID: 22046
		[SerializeField]
		private int _numBakeGroups;

		// Token: 0x0400561F RID: 22047
		[SerializeField]
		private GuidReference[] _cullingGroups;

		// Token: 0x04005620 RID: 22048
		[SerializeField]
		private int _bakeHash;

		// Token: 0x02000DF8 RID: 3576
		[CompilerGenerated]
		[Serializable]
		private sealed class Class708
		{
			// Token: 0x06004AF1 RID: 19185 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(PerfectCullingCrossSceneContentMeshes x, PerfectCullingCrossSceneContentMeshes y)
			{
				throw null;
			}

			// Token: 0x04005621 RID: 22049
			public static readonly CrossSceneCullingGroupPreProcess.Class708 class708_0;

			// Token: 0x04005622 RID: 22050
			public static Comparison<PerfectCullingCrossSceneContentMeshes> comparison_0;
		}
	}
}
