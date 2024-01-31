using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010FC RID: 4348
	public class Inertia : OffsetModifier
	{
		// Token: 0x06005BB4 RID: 23476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetBodies()
		{
			throw null;
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnModifyOffset()
		{
			throw null;
		}

		// Token: 0x0400672E RID: 26414
		[Tooltip("The array of Bodies")]
		public Inertia.Body[] bodies;

		// Token: 0x0400672F RID: 26415
		[Tooltip("The array of OffsetLimits")]
		public OffsetModifier.OffsetLimits[] limits;

		// Token: 0x020010FD RID: 4349
		[Serializable]
		public class Body
		{
			// Token: 0x06005BB6 RID: 23478 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x06005BB7 RID: 23479 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
				throw null;
			}

			// Token: 0x04006730 RID: 26416
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			// Token: 0x04006731 RID: 26417
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public Inertia.Body.EffectorLink[] effectorLinks;

			// Token: 0x04006732 RID: 26418
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			// Token: 0x04006733 RID: 26419
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			// Token: 0x04006734 RID: 26420
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			// Token: 0x04006735 RID: 26421
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			// Token: 0x04006736 RID: 26422
			private Vector3 delta;

			// Token: 0x04006737 RID: 26423
			private Vector3 lazyPoint;

			// Token: 0x04006738 RID: 26424
			private Vector3 direction;

			// Token: 0x04006739 RID: 26425
			private Vector3 lastPosition;

			// Token: 0x0400673A RID: 26426
			private bool firstUpdate;

			// Token: 0x020010FE RID: 4350
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x0400673B RID: 26427
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400673C RID: 26428
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
