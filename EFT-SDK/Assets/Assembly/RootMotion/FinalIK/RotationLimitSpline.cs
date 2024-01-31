using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010EF RID: 4335
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		// Token: 0x06005B8A RID: 23434 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Support Group")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Asset Store Thread")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpline(Keyframe[] keyframes)
		{
			throw null;
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x040066F7 RID: 26359
		[Range(0f, 180f)]
		public float twistLimit;

		// Token: 0x040066F8 RID: 26360
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;
	}
}
