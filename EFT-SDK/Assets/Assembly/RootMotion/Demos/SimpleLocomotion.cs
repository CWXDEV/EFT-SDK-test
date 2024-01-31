using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02001083 RID: 4227
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x0600584D RID: 22605 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600584E RID: 22606 RVA: 0x00002050 File Offset: 0x00000250
		public bool isGrounded
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

		// Token: 0x0600584F RID: 22607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2()
		{
			throw null;
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_3()
		{
			throw null;
		}

		// Token: 0x04006408 RID: 25608
		[SerializeField]
		[Tooltip("The component that updates the camera.")]
		private CameraController cameraController;

		// Token: 0x04006409 RID: 25609
		[Tooltip("Acceleration of movement.")]
		[SerializeField]
		private float accelerationTime;

		// Token: 0x0400640A RID: 25610
		[SerializeField]
		[Tooltip("Turning speed.")]
		private float turnTime;

		// Token: 0x0400640B RID: 25611
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault;

		// Token: 0x0400640C RID: 25612
		[SerializeField]
		[Tooltip("Smooth or linear rotation.")]
		private SimpleLocomotion.RotationMode rotationMode;

		// Token: 0x0400640D RID: 25613
		[Tooltip("Procedural motion speed (if not using root motion).")]
		[SerializeField]
		private float moveSpeed;

		// Token: 0x0400640E RID: 25614
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400640F RID: 25615
		private Animator animator_0;

		// Token: 0x04006410 RID: 25616
		private float float_0;

		// Token: 0x04006411 RID: 25617
		private float float_1;

		// Token: 0x04006412 RID: 25618
		private float float_2;

		// Token: 0x04006413 RID: 25619
		private Vector3 vector3_0;

		// Token: 0x04006414 RID: 25620
		private CharacterController characterController_0;

		// Token: 0x02001084 RID: 4228
		[Serializable]
		public enum RotationMode
		{
			// Token: 0x04006416 RID: 25622
			Smooth,
			// Token: 0x04006417 RID: 25623
			Linear
		}
	}
}
