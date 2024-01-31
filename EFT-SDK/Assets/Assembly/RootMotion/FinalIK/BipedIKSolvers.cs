using System;
using System.Runtime.CompilerServices;

namespace RootMotion.FinalIK
{
	// Token: 0x0200108A RID: 4234
	[Serializable]
	public class BipedIKSolvers
	{
		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06005873 RID: 22643 RVA: 0x00002050 File Offset: 0x00000250
		public IKSolverLimb[] limbs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x00002050 File Offset: 0x00000250
		public IKSolver[] ikSolvers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssignReferences(BipedReferences references)
		{
			throw null;
		}

		// Token: 0x0400642A RID: 25642
		public IKSolverLimb leftFoot;

		// Token: 0x0400642B RID: 25643
		public IKSolverLimb rightFoot;

		// Token: 0x0400642C RID: 25644
		public IKSolverLimb leftHand;

		// Token: 0x0400642D RID: 25645
		public IKSolverLimb rightHand;

		// Token: 0x0400642E RID: 25646
		public IKSolverFABRIK spine;

		// Token: 0x0400642F RID: 25647
		public IKSolverLookAt lookAt;

		// Token: 0x04006430 RID: 25648
		public IKSolverAim aim;

		// Token: 0x04006431 RID: 25649
		public Constraints pelvis;

		// Token: 0x04006432 RID: 25650
		private IKSolverLimb[] _limbs;

		// Token: 0x04006433 RID: 25651
		private IKSolver[] _ikSolvers;
	}
}
