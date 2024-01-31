using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200108F RID: 4239
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		// Token: 0x0600587C RID: 22652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateConstraint()
		{
			throw null;
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600587D RID: 22653 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400643C RID: 25660
		public Quaternion offset;

		// Token: 0x0400643D RID: 25661
		private Quaternion defaultRotation;

		// Token: 0x0400643E RID: 25662
		private Quaternion defaultLocalRotation;

		// Token: 0x0400643F RID: 25663
		private Quaternion lastLocalRotation;

		// Token: 0x04006440 RID: 25664
		private Quaternion defaultTargetLocalRotation;

		// Token: 0x04006441 RID: 25665
		private bool initiated;
	}
}
