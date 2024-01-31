using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E0A RID: 3594
	public sealed class PortalsPreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06004B2F RID: 19247 RVA: 0x00002050 File Offset: 0x00000250
		public GuidReference[] CullingGroups
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override LODGroup[] GetLODGroups()
		{
			throw null;
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrepareRuntimeContent()
		{
			throw null;
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerfectCullingBakeGroup[] GetBakeGroups()
		{
			throw null;
		}

		// Token: 0x04005643 RID: 22083
		public static readonly LODGroup[] EMPTY_LOD_GROUPS;

		// Token: 0x04005644 RID: 22084
		[SerializeField]
		private int _numBakeGroups;

		// Token: 0x04005645 RID: 22085
		[SerializeField]
		private GuidReference[] _cullingGroups;

		// Token: 0x04005646 RID: 22086
		[SerializeField]
		private int _bakeHash;

		// Token: 0x02000E0B RID: 3595
		[CompilerGenerated]
		[Serializable]
		private sealed class Class712
		{
			// Token: 0x06004B34 RID: 19252 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(CrossSceneContentPortals x, CrossSceneContentPortals y)
			{
				throw null;
			}

			// Token: 0x04005647 RID: 22087
			public static readonly PortalsPreProcess.Class712 class712_0;

			// Token: 0x04005648 RID: 22088
			public static Comparison<CrossSceneContentPortals> comparison_0;
		}
	}
}
