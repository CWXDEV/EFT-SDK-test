using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AnimationEventSystem
{
	// Token: 0x0200102C RID: 4140
	[Serializable]
	public class LActionSetup
	{
		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600566A RID: 22122 RVA: 0x00002050 File Offset: 0x00000250
		public int StateHash
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400628F RID: 25231
		public float StartThreshold;

		// Token: 0x04006290 RID: 25232
		public AnimationCurve LayerWeight;

		// Token: 0x04006291 RID: 25233
		[SerializeField]
		private int _stateHash;
	}
}
