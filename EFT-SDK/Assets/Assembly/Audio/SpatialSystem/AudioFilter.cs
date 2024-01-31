using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D26 RID: 3366
	public abstract class AudioFilter : MonoBehaviour
	{
		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060047A2 RID: 18338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060047A3 RID: 18339 RVA: 0x00002050 File Offset: 0x00000250
		public float FilterLevel
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x060047A4 RID: 18340
		public abstract void ResetFilter();

		// Token: 0x060047A5 RID: 18341
		public abstract void SetFilterParams(float value, bool applyImmediately = false, ESoundOcclusionType occlusionType = ESoundOcclusionType.FullOcclusion);

		// Token: 0x0400528A RID: 21130
		[CompilerGenerated]
		private float float_0;
	}
}
