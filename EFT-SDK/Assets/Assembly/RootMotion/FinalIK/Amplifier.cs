using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010F2 RID: 4338
	public class Amplifier : OffsetModifier
	{
		// Token: 0x06005B95 RID: 23445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnModifyOffset()
		{
			throw null;
		}

		// Token: 0x04006701 RID: 26369
		[Tooltip("The amplified bodies.")]
		public Amplifier.Body[] bodies;

		// Token: 0x020010F3 RID: 4339
		[Serializable]
		public class Body
		{
			// Token: 0x06005B96 RID: 23446 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
				throw null;
			}

			// Token: 0x06005B97 RID: 23447 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static Vector3 smethod_0(Vector3 v1, Vector3 v2)
			{
				throw null;
			}

			// Token: 0x04006702 RID: 26370
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			// Token: 0x04006703 RID: 26371
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			// Token: 0x04006704 RID: 26372
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public Amplifier.Body.EffectorLink[] effectorLinks;

			// Token: 0x04006705 RID: 26373
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			// Token: 0x04006706 RID: 26374
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			// Token: 0x04006707 RID: 26375
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			// Token: 0x04006708 RID: 26376
			private Vector3 lastRelativePos;

			// Token: 0x04006709 RID: 26377
			private Vector3 smoothDelta;

			// Token: 0x0400670A RID: 26378
			private bool firstUpdate;

			// Token: 0x020010F4 RID: 4340
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x0400670B RID: 26379
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400670C RID: 26380
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
