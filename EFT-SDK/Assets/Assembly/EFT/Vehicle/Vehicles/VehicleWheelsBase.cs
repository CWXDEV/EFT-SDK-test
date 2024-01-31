using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Vehicle.Vehicles
{
	// Token: 0x02002688 RID: 9864
	public class VehicleWheelsBase : MonoBehaviour
	{
		// Token: 0x0600C3A2 RID: 50082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWheelSettings(float diameter, float height, float offset, float heightWheelMax, float heightWheelMin, float snapToSurfaceSpeed, float checkSurfaceForWheelsTimer)
		{
			throw null;
		}

		// Token: 0x0600C3A6 RID: 50086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RotateWheel(bool rotateOn, bool rotateForward, float vehicleSpeed, bool turnOn = false, VehicleWheelsBase linkWheel = null)
		{
			throw null;
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600C3A8 RID: 50088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2(Vector3 newDirection)
		{
			throw null;
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400C58C RID: 50572
		public LayerMask surfaceMask;

		// Token: 0x0400C58D RID: 50573
		public Transform surfaceChecker;

		// Token: 0x0400C58E RID: 50574
		public Transform horizontalAxis;

		// Token: 0x0400C58F RID: 50575
		public float diameterWheel;

		// Token: 0x0400C590 RID: 50576
		public float maxTurnAngle;

		// Token: 0x0400C591 RID: 50577
		public float lerpTurn;

		// Token: 0x0400C592 RID: 50578
		public float turnSpeedTrashHold;

		// Token: 0x0400C593 RID: 50579
		public float heightWheel;

		// Token: 0x0400C594 RID: 50580
		public float heightMaxPosLimit;

		// Token: 0x0400C595 RID: 50581
		public float heightMinPosLimit;

		// Token: 0x0400C596 RID: 50582
		public float heightOffset;

		// Token: 0x0400C597 RID: 50583
		public float snapDeltaThreshold;

		// Token: 0x0400C598 RID: 50584
		private bool bool_0;

		// Token: 0x0400C599 RID: 50585
		private bool bool_1;

		// Token: 0x0400C59A RID: 50586
		private bool bool_2;

		// Token: 0x0400C59B RID: 50587
		private float float_0;

		// Token: 0x0400C59C RID: 50588
		private Vector3 vector3_0;

		// Token: 0x0400C59D RID: 50589
		private Quaternion quaternion_0;

		// Token: 0x0400C59E RID: 50590
		private Vector3 vector3_1;

		// Token: 0x0400C59F RID: 50591
		private int int_0;

		// Token: 0x0400C5A0 RID: 50592
		private int int_1;

		// Token: 0x0400C5A1 RID: 50593
		public float lerpToTargetHeight;

		// Token: 0x0400C5A2 RID: 50594
		public float snapToSurfaceTimer;

		// Token: 0x0400C5A3 RID: 50595
		private float float_1;

		// Token: 0x0400C5A4 RID: 50596
		private float float_2;

		// Token: 0x0400C5A5 RID: 50597
		private float float_3;

		// Token: 0x0400C5A6 RID: 50598
		private Transform transform_0;

		// Token: 0x0400C5A7 RID: 50599
		private RaycastHit[] raycastHit_0;
	}
}
