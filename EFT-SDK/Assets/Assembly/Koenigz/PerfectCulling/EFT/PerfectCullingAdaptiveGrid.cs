using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E28 RID: 3624
	public sealed class PerfectCullingAdaptiveGrid : MonoBehaviour
	{
		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06004B9C RID: 19356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004B9D RID: 19357 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingAdaptiveGrid Instance
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06004B9E RID: 19358 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingAdaptiveGridData GridData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x00002050 File Offset: 0x00000250
		public string GridHash
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06004BA0 RID: 19360 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1024 RuntimeBVH
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x00002050 File Offset: 0x00000250
		public List<PerfectCullingCrossSceneGroup> RuntimeGroupMapping
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1042 PackedData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetGroupIndex(GuidReference reference)
		{
			throw null;
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x00002050 File Offset: 0x00000250
		public List<CullingCellData> AdaptiveCells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1042.GClass1043 IndexDecompressor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_0(CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1(CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_4(CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1024 InitializeSpatialTreeFromGridData(CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass1024 method_5(CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x0400569C RID: 22172
		[CompilerGenerated]
		private static PerfectCullingAdaptiveGrid perfectCullingAdaptiveGrid_0;

		// Token: 0x0400569D RID: 22173
		[SerializeField]
		private PerfectCullingAdaptiveGridData _gridData;

		// Token: 0x0400569E RID: 22174
		[SerializeField]
		private string _gridHash;

		// Token: 0x0400569F RID: 22175
		private GClass1024 gclass1024_0;

		// Token: 0x040056A0 RID: 22176
		private List<PerfectCullingCrossSceneGroup> list_0;

		// Token: 0x040056A1 RID: 22177
		private GClass1042 gclass1042_0;

		// Token: 0x040056A2 RID: 22178
		private List<OrientedBounds> list_1;

		// Token: 0x040056A3 RID: 22179
		private List<OrientedPoint> list_2;

		// Token: 0x040056A4 RID: 22180
		private GClass1042.GClass1043 gclass1043_0;

		// Token: 0x02000E2A RID: 3626
		[CompilerGenerated]
		private sealed class Class714
		{
			// Token: 0x06004BB1 RID: 19377 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040056AB RID: 22187
			public string filePath;

			// Token: 0x040056AC RID: 22188
			public PerfectCullingAdaptiveGrid perfectCullingAdaptiveGrid_0;
		}

		// Token: 0x02000E2C RID: 3628
		[CompilerGenerated]
		private sealed class Class715
		{
			// Token: 0x06004BB4 RID: 19380 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040056B3 RID: 22195
			public PerfectCullingAdaptiveGrid perfectCullingAdaptiveGrid_0;

			// Token: 0x040056B4 RID: 22196
			public CancellationToken token;

			// Token: 0x040056B5 RID: 22197
			public IProgress<float> progress;
		}
	}
}
