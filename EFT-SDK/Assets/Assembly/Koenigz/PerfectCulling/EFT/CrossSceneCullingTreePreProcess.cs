using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DF9 RID: 3577
	public sealed class CrossSceneCullingTreePreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x06004AF2 RID: 19186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrepareRuntimeContent()
		{
			throw null;
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingBakeGroup[] GetBakeGroups()
		{
			throw null;
		}

		// Token: 0x04005623 RID: 22051
		[SerializeField]
		[Header("Content setup")]
		private int _bakeHash;

		// Token: 0x04005624 RID: 22052
		[SerializeField]
		private int _numBakeGroups;

		// Token: 0x04005625 RID: 22053
		[SerializeField]
		private GuidReference[] _cullingGroups;

		// Token: 0x02000DFA RID: 3578
		[CompilerGenerated]
		[Serializable]
		private sealed class Class709
		{
			// Token: 0x06004AF5 RID: 19189 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(PerfectCullingCrossSceneContentTrees x, PerfectCullingCrossSceneContentTrees y)
			{
				throw null;
			}

			// Token: 0x04005626 RID: 22054
			public static readonly CrossSceneCullingTreePreProcess.Class709 class709_0;

			// Token: 0x04005627 RID: 22055
			public static Comparison<PerfectCullingCrossSceneContentTrees> comparison_0;
		}
	}
}
