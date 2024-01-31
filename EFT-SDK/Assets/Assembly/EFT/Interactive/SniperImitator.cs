using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027ED RID: 10221
	public class SniperImitator : MonoBehaviour
	{
		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600CCA8 RID: 52392 RVA: 0x00002050 File Offset: 0x00000250
		public Transform GetRandomSniperPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CCA9 RID: 52393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GInterface94 player, BorderZone firingZone, float tMinus, bool willHit)
		{
			throw null;
		}

		// Token: 0x0600CCAB RID: 52395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_1(float tMinus, GInterface94 player, Vector3 sniperPosition, Quaternion sniperRotation, bool willHit)
		{
			throw null;
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400CCD3 RID: 52435
		private static readonly Quaternion quaternion_0;

		// Token: 0x0400CCD4 RID: 52436
		[SerializeField]
		private FirearmsEffects FirearmsEffects;

		// Token: 0x0400CCD5 RID: 52437
		[SerializeField]
		private SniperFiringZone SniperFiringZone;

		// Token: 0x0400CCD6 RID: 52438
		[SerializeField]
		private SoundBank SoundBank;

		// Token: 0x0400CCD7 RID: 52439
		[SerializeField]
		private List<Transform> SniperPositions;

		// Token: 0x0400CCD8 RID: 52440
		[SerializeField]
		private Transform _effectsTransform;

		// Token: 0x0400CCD9 RID: 52441
		private bool bool_0;
	}
}
