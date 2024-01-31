using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200108E RID: 4238
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		// Token: 0x0600587B RID: 22651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateConstraint()
		{
			throw null;
		}

		// Token: 0x0400643B RID: 25659
		public Quaternion rotation;
	}
}
