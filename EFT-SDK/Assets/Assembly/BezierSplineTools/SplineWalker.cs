using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BezierSplineTools
{
	// Token: 0x02000EF0 RID: 3824
	public class SplineWalker : MonoBehaviour
	{
		// Token: 0x06004FE4 RID: 20452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04005CA6 RID: 23718
		public BezierSpline spline;

		// Token: 0x04005CA7 RID: 23719
		public float duration;

		// Token: 0x04005CA8 RID: 23720
		public bool lookForward;

		// Token: 0x04005CA9 RID: 23721
		public SplineWalkerMode mode;

		// Token: 0x04005CAA RID: 23722
		private float float_0;

		// Token: 0x04005CAB RID: 23723
		private bool bool_0;
	}
}
