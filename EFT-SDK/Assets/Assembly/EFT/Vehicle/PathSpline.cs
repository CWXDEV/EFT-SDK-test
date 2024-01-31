using System;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x0200267F RID: 9855
	[Serializable]
	public class PathSpline : PathPartBase
	{
		// Token: 0x0600C379 RID: 50041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect(Vector3 destinationPos)
		{
			throw null;
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect2(Vector3 destinationPos)
		{
			throw null;
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disconnect()
		{
			throw null;
		}

		// Token: 0x0400C547 RID: 50503
		public PathSpline.GDelegate71 SplineSelectedEvent;

		// Token: 0x0400C548 RID: 50504
		public BezierSpline spline;

		// Token: 0x0400C549 RID: 50505
		private Vector3 _disconnectFirstCachedPoint;

		// Token: 0x0400C54A RID: 50506
		private Vector3 _disconnectLastCachedPoint;

		// Token: 0x02002680 RID: 9856
		// (Invoke) Token: 0x0600C37C RID: 50044
		public delegate void GDelegate71(PathSpline pathSpline);
	}
}
