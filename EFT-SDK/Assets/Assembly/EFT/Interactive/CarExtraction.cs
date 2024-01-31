using System;
using System.Runtime.CompilerServices;
using BezierSplineTools;

namespace EFT.Interactive
{
	// Token: 0x02002748 RID: 10056
	public class CarExtraction : ExfiltrationSubscriber
	{
		// Token: 0x0600C930 RID: 51504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Play(bool force = false)
		{
			throw null;
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400C93C RID: 51516
		public BezierSpline Spline;

		// Token: 0x0400C93D RID: 51517
		public WheelDrive Driver;

		// Token: 0x0400C93E RID: 51518
		public float _previousT;

		// Token: 0x0400C93F RID: 51519
		public float Step;

		// Token: 0x0400C940 RID: 51520
		private float float_0;

		// Token: 0x0400C941 RID: 51521
		private float float_1;

		// Token: 0x0400C942 RID: 51522
		private const float float_2 = 45f;

		// Token: 0x0400C943 RID: 51523
		private bool bool_0;
	}
}
