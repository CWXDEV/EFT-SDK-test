using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000DA0 RID: 3488
	[CreateAssetMenu(menuName = "Perfect Culling/PerfectCullingSettings")]
	public class PerfectCullingSettings : ScriptableObject
	{
		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060049B2 RID: 18866 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingSettings Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x00002050 File Offset: 0x00000250
		public int bakeCameraResolutionWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x00002050 File Offset: 0x00000250
		public int bakeCameraResolutionHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040054FD RID: 21757
		[Tooltip("Resolution for the actual rendering of a single camera perspective (1 out of 6). Increase this if you are experiencing distant object popping. Decrease this if you are memory constrained on your baking system.")]
		[Range(16f, 2048f)]
		public int bakeCameraResolution;

		// Token: 0x040054FE RID: 21758
		public bool debugBakeMode;

		// Token: 0x040054FF RID: 21759
		public bool outputPixelData;

		// Token: 0x04005500 RID: 21760
		public bool supportOldDataFormat;

		// Token: 0x04005501 RID: 21761
		public Material proxyTransparentMaterial;

		// Token: 0x04005502 RID: 21762
		public Material sharedOccluderMaterial;

		// Token: 0x04005503 RID: 21763
		public float minCullingOccluderSize;

		// Token: 0x04005504 RID: 21764
		public int numActivationsPerVolume;

		// Token: 0x04005505 RID: 21765
		public bool saveRawBakeData;
	}
}
