using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010F6 RID: 4342
	public class HitReaction : OffsetModifier
	{
		// Token: 0x06005B9A RID: 23450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnModifyOffset()
		{
			throw null;
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hit(EBodyPartColliderType colliderType, EBodyPart bodyPart, Vector3 force, Vector3 point, bool any = false)
		{
			throw null;
		}

		// Token: 0x04006713 RID: 26387
		public List<HitReaction.HitPoint> Recoil;

		// Token: 0x04006714 RID: 26388
		[SerializeField]
		private HitReaction.HitPointEffector[] effectorHitPointsRecoil;

		// Token: 0x04006715 RID: 26389
		[SerializeField]
		private HitReaction.HitPointBone[] boneHitPointsRecoil;

		// Token: 0x04006716 RID: 26390
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReaction.HitPointEffector[] effectorHitPoints;

		// Token: 0x04006717 RID: 26391
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReaction.HitPointBone[] boneHitPoints;

		// Token: 0x020010F7 RID: 4343
		[Serializable]
		public abstract class HitPoint
		{
			// Token: 0x17000E53 RID: 3667
			// (get) Token: 0x06005B9D RID: 23453 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005B9E RID: 23454 RVA: 0x00002050 File Offset: 0x00000250
			private float crossFader
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000E54 RID: 3668
			// (get) Token: 0x06005B9F RID: 23455 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005BA0 RID: 23456 RVA: 0x00002050 File Offset: 0x00000250
			private float timer
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000E55 RID: 3669
			// (get) Token: 0x06005BA1 RID: 23457 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005BA2 RID: 23458 RVA: 0x00002050 File Offset: 0x00000250
			private Vector3 force
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000E56 RID: 3670
			// (get) Token: 0x06005BA3 RID: 23459 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005BA4 RID: 23460 RVA: 0x00002050 File Offset: 0x00000250
			private Vector3 point
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06005BA5 RID: 23461 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Hit(Vector3 force, Vector3 point)
			{
				throw null;
			}

			// Token: 0x06005BA6 RID: 23462 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
				throw null;
			}

			// Token: 0x06005BA7 RID: 23463
			protected abstract float GetLength();

			// Token: 0x06005BA8 RID: 23464
			protected abstract void CrossFadeStart();

			// Token: 0x06005BA9 RID: 23465
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			// Token: 0x04006718 RID: 26392
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x04006719 RID: 26393
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x0400671A RID: 26394
			public EBodyPartColliderType[] colliderTypes;

			// Token: 0x0400671B RID: 26395
			public EBodyPart[] bodyParts;

			// Token: 0x0400671C RID: 26396
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x0400671D RID: 26397
			private float length;

			// Token: 0x0400671E RID: 26398
			private float crossFadeSpeed;

			// Token: 0x0400671F RID: 26399
			private float lastTime;
		}

		// Token: 0x020010F8 RID: 4344
		[Serializable]
		public class HitPointEffector : HitReaction.HitPoint
		{
			// Token: 0x06005BAA RID: 23466 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override float GetLength()
			{
				throw null;
			}

			// Token: 0x06005BAB RID: 23467 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CrossFadeStart()
			{
				throw null;
			}

			// Token: 0x06005BAC RID: 23468 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
				throw null;
			}

			// Token: 0x04006720 RID: 26400
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			// Token: 0x04006721 RID: 26401
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			// Token: 0x04006722 RID: 26402
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public HitReaction.HitPointEffector.EffectorLink[] effectorLinks;

			// Token: 0x020010F9 RID: 4345
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x06005BAD RID: 23469 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
					throw null;
				}

				// Token: 0x06005BAE RID: 23470 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void CrossFadeStart()
				{
					throw null;
				}

				// Token: 0x04006723 RID: 26403
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				// Token: 0x04006724 RID: 26404
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x04006725 RID: 26405
				private Vector3 lastValue;

				// Token: 0x04006726 RID: 26406
				private Vector3 current;
			}
		}

		// Token: 0x020010FA RID: 4346
		[Serializable]
		public class HitPointBone : HitReaction.HitPoint
		{
			// Token: 0x06005BAF RID: 23471 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override float GetLength()
			{
				throw null;
			}

			// Token: 0x06005BB0 RID: 23472 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CrossFadeStart()
			{
				throw null;
			}

			// Token: 0x06005BB1 RID: 23473 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
				throw null;
			}

			// Token: 0x04006727 RID: 26407
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			// Token: 0x04006728 RID: 26408
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReaction.HitPointBone.BoneLink[] boneLinks;

			// Token: 0x04006729 RID: 26409
			private Rigidbody rigidbody;

			// Token: 0x020010FB RID: 4347
			[Serializable]
			public class BoneLink
			{
				// Token: 0x06005BB2 RID: 23474 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
					throw null;
				}

				// Token: 0x06005BB3 RID: 23475 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void CrossFadeStart()
				{
					throw null;
				}

				// Token: 0x0400672A RID: 26410
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				// Token: 0x0400672B RID: 26411
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				// Token: 0x0400672C RID: 26412
				private Quaternion lastValue;

				// Token: 0x0400672D RID: 26413
				private Quaternion current;
			}
		}
	}
}
