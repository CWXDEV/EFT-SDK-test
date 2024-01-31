using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animals
{
	// Token: 0x02002FB9 RID: 12217
	public class Bird : MonoBehaviour
	{
		// Token: 0x0600F13D RID: 61757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDirection(Vector3 direction, float commonSpeedMult)
		{
			throw null;
		}

		// Token: 0x0400F73F RID: 63295
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400F740 RID: 63296
		[SerializeField]
		public Transform Carina;

		// Token: 0x0400F741 RID: 63297
		[SerializeField]
		private float _shaftAngleSmooth;

		// Token: 0x0400F742 RID: 63298
		[SerializeField]
		private float _directionChangeSensitivity;

		// Token: 0x0400F743 RID: 63299
		[SerializeField]
		private float _switchToSoarPoint;

		// Token: 0x0400F744 RID: 63300
		[SerializeField]
		private float _speedToFlap;

		// Token: 0x0400F745 RID: 63301
		[SerializeField]
		private float _directionToFlap;

		// Token: 0x0400F746 RID: 63302
		private Vector3 vector3_0;

		// Token: 0x0400F747 RID: 63303
		private float float_0;

		// Token: 0x0400F748 RID: 63304
		private float float_1;

		// Token: 0x0400F749 RID: 63305
		private static readonly int int_0;

		// Token: 0x0400F74A RID: 63306
		private static readonly int int_1;

		// Token: 0x0400F74B RID: 63307
		private static readonly int int_2;
	}
}
