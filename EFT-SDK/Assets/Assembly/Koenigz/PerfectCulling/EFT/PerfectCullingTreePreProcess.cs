using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E07 RID: 3591
	public sealed class PerfectCullingTreePreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x06004B27 RID: 19239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] CollectBakeGroups()
		{
			throw null;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<Renderer> smethod_0(LODGroup lodGroup)
		{
			throw null;
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrebakeTransform(BakeBatch batch, ICollection<GameObject> tempObjects, out GClass1012.Mode writeMode)
		{
			throw null;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Generate tree proxies")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x04005638 RID: 22072
		[SerializeField]
		private float m_BranchLength;

		// Token: 0x04005639 RID: 22073
		[SerializeField]
		private float m_BranchSize;

		// Token: 0x0400563A RID: 22074
		[SerializeField]
		private float m_CenterSize;

		// Token: 0x0400563B RID: 22075
		[SerializeField]
		private float m_MergeRadius;

		// Token: 0x0400563C RID: 22076
		[SerializeField]
		private int m_MaxCount;

		// Token: 0x0400563D RID: 22077
		[SerializeField]
		[HideInInspector]
		private List<PerfectCullingTreePreProcess.TreeGroup> _treeGroups;

		// Token: 0x02000E08 RID: 3592
		[Serializable]
		public sealed class TreeGroup
		{
			// Token: 0x06004B2B RID: 19243 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddTree(PerfectCullingBakeGroup tree)
			{
				throw null;
			}

			// Token: 0x0400563E RID: 22078
			public List<PerfectCullingBakeGroup> TreeBakeGroups;
		}

		// Token: 0x02000E09 RID: 3593
		[CompilerGenerated]
		[Serializable]
		private sealed class Class711
		{
			// Token: 0x06004B2C RID: 19244 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Renderer x)
			{
				throw null;
			}

			// Token: 0x06004B2D RID: 19245 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(Renderer x, Renderer y)
			{
				throw null;
			}

			// Token: 0x06004B2E RID: 19246 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(Transform t)
			{
				throw null;
			}

			// Token: 0x0400563F RID: 22079
			public static readonly PerfectCullingTreePreProcess.Class711 class711_0;

			// Token: 0x04005640 RID: 22080
			public static Predicate<Renderer> predicate_0;

			// Token: 0x04005641 RID: 22081
			public static Comparison<Renderer> comparison_0;

			// Token: 0x04005642 RID: 22082
			public static Func<Transform, string> func_0;
		}
	}
}
