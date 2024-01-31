using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02001068 RID: 4200
	[Serializable]
	public class BipedLimbOrientations
	{
		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x00002050 File Offset: 0x00000250
		public static BipedLimbOrientations UMA
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x00002050 File Offset: 0x00000250
		public static BipedLimbOrientations MaxBiped
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400634D RID: 25421
		public BipedLimbOrientations.LimbOrientation leftArm;

		// Token: 0x0400634E RID: 25422
		public BipedLimbOrientations.LimbOrientation rightArm;

		// Token: 0x0400634F RID: 25423
		public BipedLimbOrientations.LimbOrientation leftLeg;

		// Token: 0x04006350 RID: 25424
		public BipedLimbOrientations.LimbOrientation rightLeg;

		// Token: 0x02001069 RID: 4201
		[Serializable]
		public class LimbOrientation
		{
			// Token: 0x04006351 RID: 25425
			public Vector3 upperBoneForwardAxis;

			// Token: 0x04006352 RID: 25426
			public Vector3 lowerBoneForwardAxis;

			// Token: 0x04006353 RID: 25427
			public Vector3 lastBoneLeftAxis;
		}
	}
}
