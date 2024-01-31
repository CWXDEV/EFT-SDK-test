using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200189B RID: 6299
	public class PlayerCameraFovChanger : MonoBehaviour
	{
		// Token: 0x0600876A RID: 34666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeFov(float targetFov, float changeTime)
		{
			throw null;
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeFov(float targetFov)
		{
			throw null;
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnFov(float changeTime)
		{
			throw null;
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0(float from, float to)
		{
			throw null;
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04008DD9 RID: 36313
		[Header("Use only two keys")]
		[SerializeField]
		private AnimationCurve _changeFovCurve;

		// Token: 0x04008DDA RID: 36314
		[SerializeField]
		private float _changingTime;

		// Token: 0x04008DDB RID: 36315
		private float float_0;

		// Token: 0x04008DDC RID: 36316
		private Camera camera_0;

		// Token: 0x04008DDD RID: 36317
		private Coroutine coroutine_0;

		// Token: 0x04008DDE RID: 36318
		private readonly float float_1;
	}
}
