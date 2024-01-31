using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D34 RID: 3380
	[RequireComponent(typeof(MetaXRAudioSource), typeof(MetaXRAudioSourceExperimentalFeatures))]
	public sealed class MetaSpatialAudioSource : BaseSpatialAudioSource
	{
		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060047E6 RID: 18406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060047E7 RID: 18407 RVA: 0x00002050 File Offset: 0x00000250
		public override bool EnableSpatialization
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetParameters(AudioGroupPreset preset)
		{
			throw null;
		}

		// Token: 0x040052C2 RID: 21186
		[SerializeField]
		private MetaXRAudioSource _metaXRAudioSource;

		// Token: 0x040052C3 RID: 21187
		[SerializeField]
		private MetaXRAudioSourceExperimentalFeatures _metaXRAudioSourceExperimental;
	}
}
