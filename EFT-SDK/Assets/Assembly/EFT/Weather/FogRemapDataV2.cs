using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DE9 RID: 7657
	[CreateAssetMenu]
	public class FogRemapDataV2 : ScriptableObject
	{
		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06009DA3 RID: 40355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DA4 RID: 40356 RVA: 0x00002050 File Offset: 0x00000250
		public FogRemapRecordV2 Record
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

		// Token: 0x140001F0 RID: 496
		// (add) Token: 0x06009DA5 RID: 40357 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009DA6 RID: 40358 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnChange
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float RemapFogValue(float fog, float hour, out GStruct252 interpolatedParameters)
		{
			throw null;
		}

		// Token: 0x0400A572 RID: 42354
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400A573 RID: 42355
		[SerializeField]
		private FogRemapRecordV2 _record;
	}
}
