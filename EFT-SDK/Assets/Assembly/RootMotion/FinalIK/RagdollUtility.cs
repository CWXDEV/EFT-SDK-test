using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010E5 RID: 4325
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		// Token: 0x06005B43 RID: 23363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableRagdoll()
		{
			throw null;
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableRagdoll()
		{
			throw null;
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(float weight)
		{
			throw null;
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x040066BF RID: 26303
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		// Token: 0x040066C0 RID: 26304
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		// Token: 0x040066C1 RID: 26305
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		// Token: 0x040066C2 RID: 26306
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		// Token: 0x040066C3 RID: 26307
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		// Token: 0x040066C4 RID: 26308
		private Animator animator_0;

		// Token: 0x040066C5 RID: 26309
		private RagdollUtility.GClass1269[] gclass1269_0;

		// Token: 0x040066C6 RID: 26310
		private RagdollUtility.GClass1270[] gclass1270_0;

		// Token: 0x040066C7 RID: 26311
		private bool bool_0;

		// Token: 0x040066C8 RID: 26312
		private AnimatorUpdateMode animatorUpdateMode_0;

		// Token: 0x040066C9 RID: 26313
		private IK[] ik_0;

		// Token: 0x040066CA RID: 26314
		private bool[] bool_1;

		// Token: 0x040066CB RID: 26315
		private float float_0;

		// Token: 0x040066CC RID: 26316
		private float float_1;

		// Token: 0x040066CD RID: 26317
		private bool bool_2;

		// Token: 0x040066CE RID: 26318
		private bool[] bool_3;

		// Token: 0x020010E6 RID: 4326
		public class GClass1269
		{
			// Token: 0x06005B54 RID: 23380 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RecordVelocity()
			{
				throw null;
			}

			// Token: 0x06005B55 RID: 23381 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
				throw null;
			}

			// Token: 0x040066CF RID: 26319
			public Rigidbody r;

			// Token: 0x040066D0 RID: 26320
			public Transform t;

			// Token: 0x040066D1 RID: 26321
			public Collider collider;

			// Token: 0x040066D2 RID: 26322
			public Joint joint;

			// Token: 0x040066D3 RID: 26323
			public Rigidbody c;

			// Token: 0x040066D4 RID: 26324
			public bool updateAnchor;

			// Token: 0x040066D5 RID: 26325
			public Vector3 deltaPosition;

			// Token: 0x040066D6 RID: 26326
			public Quaternion deltaRotation;

			// Token: 0x040066D7 RID: 26327
			public float deltaTime;

			// Token: 0x040066D8 RID: 26328
			public Vector3 lastPosition;

			// Token: 0x040066D9 RID: 26329
			public Quaternion lastRotation;
		}

		// Token: 0x020010E7 RID: 4327
		public class GClass1270
		{
			// Token: 0x06005B56 RID: 23382 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixTransform(float weight)
			{
				throw null;
			}

			// Token: 0x06005B57 RID: 23383 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreLocalState()
			{
				throw null;
			}

			// Token: 0x040066DA RID: 26330
			public Transform t;

			// Token: 0x040066DB RID: 26331
			public Vector3 localPosition;

			// Token: 0x040066DC RID: 26332
			public Quaternion localRotation;
		}
	}
}
