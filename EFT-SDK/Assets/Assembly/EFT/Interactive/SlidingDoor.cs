using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002795 RID: 10133
	public class SlidingDoor : Door
	{
		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x0600CADA RID: 51930 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CADB RID: 51931 RVA: 0x00002050 File Offset: 0x00000250
		public override float CurrentAngle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(float value)
		{
			throw null;
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x0600CADD RID: 51933 RVA: 0x00002050 File Offset: 0x00000250
		public override AnimationCurve ProgressCurve
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400CAF0 RID: 51952
		public AnimationCurve CustomProgressCurve;

		// Token: 0x0400CAF1 RID: 51953
		public Vector3 ShutPosition;

		// Token: 0x0400CAF2 RID: 51954
		public Vector3 OpenPosition;
	}
}
