using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x02002684 RID: 9860
	public class BTRTurretServer : MonoBehaviour
	{
		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x0600C387 RID: 50055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C388 RID: 50056 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsCanShoot
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600C389 RID: 50057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C38A RID: 50058 RVA: 0x00002050 File Offset: 0x00000250
		public float MachineGunAngleToTarget
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600C38B RID: 50059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600C38C RID: 50060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableAiming()
		{
			throw null;
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableAimingPosition(Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableAimingObject(Transform targetObject)
		{
			throw null;
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckPositionInAimingZone(Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2()
		{
			throw null;
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600C396 RID: 50070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool rotateUp)
		{
			throw null;
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(bool rotateRight)
		{
			throw null;
		}

		// Token: 0x0600C398 RID: 50072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_7()
		{
			throw null;
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_8(float value)
		{
			throw null;
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_9(float value)
		{
			throw null;
		}

		// Token: 0x0400C55F RID: 50527
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400C560 RID: 50528
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0400C561 RID: 50529
		public Transform gunsBlockRoot;

		// Token: 0x0400C562 RID: 50530
		public Transform machineGunRoot;

		// Token: 0x0400C563 RID: 50531
		public Transform machineGunLaunchPoint;

		// Token: 0x0400C564 RID: 50532
		public Transform targetTransform;

		// Token: 0x0400C565 RID: 50533
		public float horizontalRotateSpeed;

		// Token: 0x0400C566 RID: 50534
		public float verticalRotateSpeed;

		// Token: 0x0400C567 RID: 50535
		public Vector3 defaultAimingPosition;

		// Token: 0x0400C568 RID: 50536
		public Vector3 targetPosition;

		// Token: 0x0400C569 RID: 50537
		public Vector2 verticalRotateLimits;

		// Token: 0x0400C56A RID: 50538
		private bool bool_1;

		// Token: 0x0400C56B RID: 50539
		private bool bool_2;

		// Token: 0x0400C56C RID: 50540
		private bool bool_3;

		// Token: 0x0400C56D RID: 50541
		private float float_1;

		// Token: 0x0400C56E RID: 50542
		[SerializeField]
		private Transform defaultTargetTransform;

		// Token: 0x0400C56F RID: 50543
		private const float float_2 = 0.02f;

		// Token: 0x0400C570 RID: 50544
		private const float float_3 = 0.02f;

		// Token: 0x0400C571 RID: 50545
		private const float float_4 = 100f;

		// Token: 0x0400C572 RID: 50546
		private const float float_5 = 1.5f;
	}
}
