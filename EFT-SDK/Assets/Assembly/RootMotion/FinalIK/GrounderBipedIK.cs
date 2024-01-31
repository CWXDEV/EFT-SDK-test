using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001095 RID: 4245
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderBipedIK : Grounder
	{
		// Token: 0x060058A1 RID: 22689 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenUserManual()
		{
			throw null;
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenScriptReference()
		{
			throw null;
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetPosition()
		{
			throw null;
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2()
		{
			throw null;
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IKSolverLimb limb, int index)
		{
			throw null;
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400645C RID: 25692
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		// Token: 0x0400645D RID: 25693
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		// Token: 0x0400645E RID: 25694
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		// Token: 0x0400645F RID: 25695
		private Transform[] transform_0;

		// Token: 0x04006460 RID: 25696
		private Quaternion[] quaternion_0;

		// Token: 0x04006461 RID: 25697
		private Vector3 vector3_0;

		// Token: 0x04006462 RID: 25698
		private Vector3 vector3_1;

		// Token: 0x04006463 RID: 25699
		private Vector3 vector3_2;

		// Token: 0x04006464 RID: 25700
		private float float_0;
	}
}
