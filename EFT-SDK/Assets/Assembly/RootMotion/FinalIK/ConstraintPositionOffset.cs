using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200108D RID: 4237
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		// Token: 0x06005879 RID: 22649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateConstraint()
		{
			throw null;
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006437 RID: 25655
		public Vector3 offset;

		// Token: 0x04006438 RID: 25656
		private Vector3 defaultLocalPosition;

		// Token: 0x04006439 RID: 25657
		private Vector3 lastLocalPosition;

		// Token: 0x0400643A RID: 25658
		private bool initiated;
	}
}
