using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E0C RID: 3596
	[ExecuteAlways]
	[RequireComponent(typeof(PerfectCullingBakingBehaviour))]
	[DisallowMultipleComponent]
	public sealed class ExcludeBorderSamplingProvider : SamplingProviderBase
	{
		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x00002050 File Offset: 0x00000250
		public override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeSamplingProvider()
		{
			throw null;
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos)
		{
			throw null;
		}

		// Token: 0x04005649 RID: 22089
		[SerializeField]
		private LevelBorder _border;

		// Token: 0x0400564A RID: 22090
		[NonSerialized]
		private GClass809 gclass809_0;
	}
}
