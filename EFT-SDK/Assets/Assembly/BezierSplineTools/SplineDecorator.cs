using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BezierSplineTools
{
	// Token: 0x02000EEF RID: 3823
	public class SplineDecorator : MonoBehaviour
	{
		// Token: 0x06004FE3 RID: 20451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x04005CA2 RID: 23714
		public BezierSpline spline;

		// Token: 0x04005CA3 RID: 23715
		public int frequency;

		// Token: 0x04005CA4 RID: 23716
		public bool lookForward;

		// Token: 0x04005CA5 RID: 23717
		public Transform[] items;
	}
}
