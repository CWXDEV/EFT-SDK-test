using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D35 RID: 3381
	[RequireComponent(typeof(ONSPAudioSource))]
	public sealed class OculusSpatialAudioSource : BaseSpatialAudioSource
	{
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060047EB RID: 18411 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x060047EC RID: 18412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetParameters(AudioGroupPreset preset)
		{
			throw null;
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x040052C4 RID: 21188
		[SerializeField]
		private ONSPAudioSource _oculusAudioSource;
	}
}
