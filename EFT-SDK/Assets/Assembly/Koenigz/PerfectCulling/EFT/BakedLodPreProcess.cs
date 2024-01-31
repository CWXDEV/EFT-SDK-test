using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DF4 RID: 3572
	public sealed class BakedLodPreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x00002050 File Offset: 0x00000250
		public GuidReference[] CullingGroups
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrepareRuntimeContent()
		{
			throw null;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingBakeGroup[] GetBakeGroups()
		{
			throw null;
		}

		// Token: 0x0400561A RID: 22042
		[SerializeField]
		private GuidReference[] _cullingGroups;

		// Token: 0x0400561B RID: 22043
		[SerializeField]
		private int _bakeHash;

		// Token: 0x02000DF5 RID: 3573
		[CompilerGenerated]
		[Serializable]
		private sealed class Class707
		{
			// Token: 0x06004AE4 RID: 19172 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(BakedLodContent x, BakedLodContent y)
			{
				throw null;
			}

			// Token: 0x0400561C RID: 22044
			public static readonly BakedLodPreProcess.Class707 class707_0;

			// Token: 0x0400561D RID: 22045
			public static Comparison<BakedLodContent> comparison_0;
		}
	}
}
