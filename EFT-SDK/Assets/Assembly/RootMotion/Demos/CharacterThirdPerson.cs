using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02001080 RID: 4224
	public class CharacterThirdPerson : CharacterBase
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x0600583D RID: 22589 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600583E RID: 22590 RVA: 0x00002050 File Offset: 0x00000250
		public bool onGround
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

		// Token: 0x0600583F RID: 22591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAnimatorMove()
		{
			throw null;
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Move(Vector3 deltaPosition)
		{
			throw null;
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector3 deltaPosition)
		{
			throw null;
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2()
		{
			throw null;
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_3()
		{
			throw null;
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Rotate()
		{
			throw null;
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_4()
		{
			throw null;
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool Jump()
		{
			throw null;
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x040063D1 RID: 25553
		[SerializeField]
		[Header("References")]
		private CharacterAnimationBase characterAnimation;

		// Token: 0x040063D2 RID: 25554
		[SerializeField]
		private UserControlThirdPerson userControl;

		// Token: 0x040063D3 RID: 25555
		[SerializeField]
		private CameraController cam;

		// Token: 0x040063D4 RID: 25556
		[Header("Movement")]
		public CharacterThirdPerson.MoveMode moveMode;

		// Token: 0x040063D5 RID: 25557
		public bool smoothPhysics;

		// Token: 0x040063D6 RID: 25558
		public float smoothAccelerationTime;

		// Token: 0x040063D7 RID: 25559
		public float linearAccelerationSpeed;

		// Token: 0x040063D8 RID: 25560
		public float platformFriction;

		// Token: 0x040063D9 RID: 25561
		public float groundStickyEffect;

		// Token: 0x040063DA RID: 25562
		public float maxVerticalVelocityOnGround;

		// Token: 0x040063DB RID: 25563
		public float velocityToGroundTangentWeight;

		// Token: 0x040063DC RID: 25564
		[Header("Rotation")]
		public bool lookInCameraDirection;

		// Token: 0x040063DD RID: 25565
		public float turnSpeed;

		// Token: 0x040063DE RID: 25566
		public float stationaryTurnSpeedMlp;

		// Token: 0x040063DF RID: 25567
		[Header("Jumping and Falling")]
		public float airSpeed;

		// Token: 0x040063E0 RID: 25568
		public float airControl;

		// Token: 0x040063E1 RID: 25569
		public float jumpPower;

		// Token: 0x040063E2 RID: 25570
		public float jumpRepeatDelayTime;

		// Token: 0x040063E3 RID: 25571
		[SerializeField]
		[Header("Wall Running")]
		private LayerMask wallRunLayers;

		// Token: 0x040063E4 RID: 25572
		public float wallRunMaxLength;

		// Token: 0x040063E5 RID: 25573
		public float wallRunMinMoveMag;

		// Token: 0x040063E6 RID: 25574
		public float wallRunMinVelocityY;

		// Token: 0x040063E7 RID: 25575
		public float wallRunRotationSpeed;

		// Token: 0x040063E8 RID: 25576
		public float wallRunMaxRotationAngle;

		// Token: 0x040063E9 RID: 25577
		public float wallRunWeightSpeed;

		// Token: 0x040063EA RID: 25578
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		// Token: 0x040063EB RID: 25579
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040063EC RID: 25580
		public CharacterThirdPerson.GStruct110 animState;

		// Token: 0x040063ED RID: 25581
		private Vector3 vector3_0;

		// Token: 0x040063EE RID: 25582
		private Animator animator_0;

		// Token: 0x040063EF RID: 25583
		private Vector3 vector3_1;

		// Token: 0x040063F0 RID: 25584
		private Vector3 vector3_2;

		// Token: 0x040063F1 RID: 25585
		private RaycastHit raycastHit_0;

		// Token: 0x040063F2 RID: 25586
		private float float_0;

		// Token: 0x040063F3 RID: 25587
		private float float_1;

		// Token: 0x040063F4 RID: 25588
		private float float_2;

		// Token: 0x040063F5 RID: 25589
		private float float_3;

		// Token: 0x040063F6 RID: 25590
		private float float_4;

		// Token: 0x040063F7 RID: 25591
		private float float_5;

		// Token: 0x040063F8 RID: 25592
		private Vector3 vector3_3;

		// Token: 0x040063F9 RID: 25593
		private Vector3 vector3_4;

		// Token: 0x040063FA RID: 25594
		private float float_6;

		// Token: 0x040063FB RID: 25595
		private float float_7;

		// Token: 0x040063FC RID: 25596
		private Vector3 vector3_5;

		// Token: 0x040063FD RID: 25597
		private bool bool_1;

		// Token: 0x040063FE RID: 25598
		private float float_8;

		// Token: 0x02001081 RID: 4225
		[Serializable]
		public enum MoveMode
		{
			// Token: 0x04006400 RID: 25600
			Directional,
			// Token: 0x04006401 RID: 25601
			Strafe
		}

		// Token: 0x02001082 RID: 4226
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct110
		{
			// Token: 0x04006402 RID: 25602
			public Vector3 moveDirection;

			// Token: 0x04006403 RID: 25603
			public bool jump;

			// Token: 0x04006404 RID: 25604
			public bool crouch;

			// Token: 0x04006405 RID: 25605
			public bool onGround;

			// Token: 0x04006406 RID: 25606
			public bool isStrafing;

			// Token: 0x04006407 RID: 25607
			public float yVelocity;
		}
	}
}
