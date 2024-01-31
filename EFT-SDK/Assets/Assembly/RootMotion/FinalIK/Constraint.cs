using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200108B RID: 4235
	[Serializable]
	public abstract class Constraint
	{
		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06005876 RID: 22646 RVA: 0x00002050 File Offset: 0x00000250
		public bool isValid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005877 RID: 22647
		public abstract void UpdateConstraint();

		// Token: 0x04006434 RID: 25652
		public Transform transform;

		// Token: 0x04006435 RID: 25653
		public float weight;
	}
}
