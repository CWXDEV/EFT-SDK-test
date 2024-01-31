using System;
using System.Runtime.CompilerServices;
using Koenigz.PerfectCulling.EFT;
using UnityEngine;

namespace Koenigz.PerfectCulling.SamplingProviders
{
	// Token: 0x02000DC4 RID: 3524
	[DisallowMultipleComponent]
	[RequireComponent(typeof(PerfectCullingBakingBehaviour))]
	[ExecuteAlways]
	public sealed class ExcludeInnerVolumeSamplingProvider : SamplingProviderBase
	{
		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06004A46 RID: 19014 RVA: 0x00002050 File Offset: 0x00000250
		public override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeSamplingProvider()
		{
			throw null;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshInnerVolumes()
		{
			throw null;
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos)
		{
			throw null;
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSamplingPositionActiveMT(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos)
		{
			throw null;
		}

		// Token: 0x04005576 RID: 21878
		[SerializeField]
		private PerfectCullingCrossSceneVolume[] _innerCrossVolumes;
	}
}
