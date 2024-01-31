using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D31 RID: 3377
	[RequireComponent(typeof(AudioSource))]
	public abstract class BaseSpatialAudioSource : MonoBehaviour
	{
		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060047DB RID: 18395 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060047DC RID: 18396 RVA: 0x00002050 File Offset: 0x00000250
		private AudioSource ParentSource
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060047DD RID: 18397
		// (set) Token: 0x060047DE RID: 18398
		public abstract bool EnableSpatialization { get; set; }

		// Token: 0x060047DF RID: 18399
		public abstract void SetParameters(AudioGroupPreset preset);

		// Token: 0x060047E0 RID: 18400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x040052C0 RID: 21184
		[CompilerGenerated]
		private AudioSource audioSource_0;
	}
}
