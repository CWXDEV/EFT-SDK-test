using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02001085 RID: 4229
	public class UserControlAI : UserControlThirdPerson
	{
		// Token: 0x06005856 RID: 22614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x04006418 RID: 25624
		public Transform moveTarget;

		// Token: 0x04006419 RID: 25625
		public float stoppingDistance;

		// Token: 0x0400641A RID: 25626
		public float stoppingThreshold;
	}
}
