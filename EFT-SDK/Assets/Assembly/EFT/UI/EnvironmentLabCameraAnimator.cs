using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x0200295E RID: 10590
	public sealed class EnvironmentLabCameraAnimator : MonoBehaviour
	{
		// Token: 0x0600D2EC RID: 53996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600D2ED RID: 53997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600D2EE RID: 53998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D2EF RID: 53999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D2F0 RID: 54000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3()
		{
			throw null;
		}

		// Token: 0x0400D4A5 RID: 54437
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400D4A6 RID: 54438
		[SerializeField]
		private Transform _horizontalJoint;

		// Token: 0x0400D4A7 RID: 54439
		[SerializeField]
		private Transform _verticalJoint;

		// Token: 0x0400D4A8 RID: 54440
		[SerializeField]
		private Transform _lens;

		// Token: 0x0400D4A9 RID: 54441
		[SerializeField]
		private Vector3 _steadyVerticalPosition;

		// Token: 0x0400D4AA RID: 54442
		[SerializeField]
		private float _autoDegreesPerSecond;

		// Token: 0x0400D4AB RID: 54443
		[SerializeField]
		private EnvironmentLabCameraAnimator.RangeFloat _autoRotationRate;

		// Token: 0x0400D4AC RID: 54444
		[SerializeField]
		private Vector3 _leftHorizontalPosition;

		// Token: 0x0400D4AD RID: 54445
		[SerializeField]
		private Vector3 _rightHorizontalPosition;

		// Token: 0x0400D4AE RID: 54446
		[SerializeField]
		private float _followDegreesPerSecond;

		// Token: 0x0400D4AF RID: 54447
		[SerializeField]
		private float _followDelay;

		// Token: 0x0400D4B0 RID: 54448
		[SerializeField]
		private Vector3 _horizontalFollowDelta;

		// Token: 0x0400D4B1 RID: 54449
		[SerializeField]
		private Vector3 _verticalFollowDelta;

		// Token: 0x0400D4B2 RID: 54450
		[SerializeField]
		private float _lensSpeed;

		// Token: 0x0400D4B3 RID: 54451
		[SerializeField]
		private Vector3 _lensClosePosition;

		// Token: 0x0400D4B4 RID: 54452
		[SerializeField]
		private Vector3 _lensFarPosition;

		// Token: 0x0400D4B5 RID: 54453
		[SerializeField]
		private float _blinkInterval;

		// Token: 0x0400D4B6 RID: 54454
		[SerializeField]
		private GameObject _redLight;

		// Token: 0x0400D4B7 RID: 54455
		private Stopwatch stopwatch_0;

		// Token: 0x0400D4B8 RID: 54456
		private float float_0;

		// Token: 0x0400D4B9 RID: 54457
		private Vector3 vector3_0;

		// Token: 0x0400D4BA RID: 54458
		private Vector3 vector3_1;

		// Token: 0x0400D4BB RID: 54459
		private Vector3 vector3_2;

		// Token: 0x0400D4BC RID: 54460
		private Vector3 vector3_3;

		// Token: 0x0400D4BD RID: 54461
		private bool bool_0;

		// Token: 0x0200295F RID: 10591
		[Serializable]
		public struct RangeFloat
		{
			// Token: 0x0600D2F2 RID: 54002 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetRandomValue()
			{
				throw null;
			}

			// Token: 0x0400D4BE RID: 54462
			public float MinValue;

			// Token: 0x0400D4BF RID: 54463
			public float MaxValue;
		}
	}
}
