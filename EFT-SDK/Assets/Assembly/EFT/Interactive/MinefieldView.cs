using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027EB RID: 10219
	public sealed class MinefieldView : MonoBehaviour
	{
		// Token: 0x0600CCA3 RID: 52387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CCA4 RID: 52388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GInterface94 player, BorderZone zone, float arg3, bool willHit)
		{
			throw null;
		}

		// Token: 0x0400CCC9 RID: 52425
		private const float float_0 = 3f;

		// Token: 0x0400CCCA RID: 52426
		[SerializeField]
		private Minefield _minefield;

		// Token: 0x0400CCCB RID: 52427
		[SerializeField]
		private string _effectName;

		// Token: 0x0400CCCC RID: 52428
		[SerializeField]
		private float _cameraShakeRange;

		// Token: 0x0400CCCD RID: 52429
		[SerializeField]
		private Vector3 _explosionLocalPosition;

		// Token: 0x0400CCCE RID: 52430
		[SerializeField]
		private bool _raycastToTheGround;

		// Token: 0x0400CCCF RID: 52431
		[SerializeField]
		private LayerMask _raycastMask;
	}
}
