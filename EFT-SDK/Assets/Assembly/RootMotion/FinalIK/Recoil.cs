using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001104 RID: 4356
	public class Recoil : OffsetModifier
	{
		// Token: 0x06005BC9 RID: 23497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
			throw null;
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Fire(float magnitude)
		{
			throw null;
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnModifyOffset()
		{
			throw null;
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06005BCD RID: 23501 RVA: 0x00002050 File Offset: 0x00000250
		private Transform Transform_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x00002050 File Offset: 0x00000250
		private Transform Transform_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04006753 RID: 26451
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		// Token: 0x04006754 RID: 26452
		[Tooltip("Which hand is holding the weapon?")]
		public Recoil.Handedness handedness;

		// Token: 0x04006755 RID: 26453
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		// Token: 0x04006756 RID: 26454
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		// Token: 0x04006757 RID: 26455
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		// Token: 0x04006758 RID: 26456
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		// Token: 0x04006759 RID: 26457
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		// Token: 0x0400675A RID: 26458
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		// Token: 0x0400675B RID: 26459
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public Recoil.RecoilOffset[] offsets;

		// Token: 0x0400675C RID: 26460
		[HideInInspector]
		public Quaternion rotationOffset;

		// Token: 0x0400675D RID: 26461
		private float float_1;

		// Token: 0x0400675E RID: 26462
		private float float_2;

		// Token: 0x0400675F RID: 26463
		private Quaternion quaternion_0;

		// Token: 0x04006760 RID: 26464
		private Quaternion quaternion_1;

		// Token: 0x04006761 RID: 26465
		private Quaternion quaternion_2;

		// Token: 0x04006762 RID: 26466
		private float float_3;

		// Token: 0x04006763 RID: 26467
		private bool bool_0;

		// Token: 0x04006764 RID: 26468
		private float float_4;

		// Token: 0x04006765 RID: 26469
		private float float_5;

		// Token: 0x04006766 RID: 26470
		private Quaternion quaternion_3;

		// Token: 0x04006767 RID: 26471
		private bool bool_1;

		// Token: 0x02001105 RID: 4357
		[Serializable]
		public class RecoilOffset
		{
			// Token: 0x06005BD0 RID: 23504 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Start()
			{
				throw null;
			}

			// Token: 0x06005BD1 RID: 23505 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
				throw null;
			}

			// Token: 0x04006768 RID: 26472
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			// Token: 0x04006769 RID: 26473
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			// Token: 0x0400676A RID: 26474
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			// Token: 0x0400676B RID: 26475
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public Recoil.RecoilOffset.EffectorLink[] effectorLinks;

			// Token: 0x0400676C RID: 26476
			private Vector3 additiveOffset;

			// Token: 0x0400676D RID: 26477
			private Vector3 lastOffset;

			// Token: 0x02001106 RID: 4358
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x0400676E RID: 26478
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400676F RID: 26479
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}

		// Token: 0x02001107 RID: 4359
		[Serializable]
		public enum Handedness
		{
			// Token: 0x04006771 RID: 26481
			Right,
			// Token: 0x04006772 RID: 26482
			Left
		}
	}
}
