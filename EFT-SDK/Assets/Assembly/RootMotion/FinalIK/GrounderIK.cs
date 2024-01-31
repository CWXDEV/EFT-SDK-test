using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001098 RID: 4248
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		// Token: 0x060058B9 RID: 22713 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenUserManual()
		{
			throw null;
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenScriptReference()
		{
			throw null;
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetPosition()
		{
			throw null;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2()
		{
			throw null;
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(int index)
		{
			throw null;
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400646F RID: 25711
		public IK[] legs;

		// Token: 0x04006470 RID: 25712
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		// Token: 0x04006471 RID: 25713
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x04006472 RID: 25714
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		// Token: 0x04006473 RID: 25715
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		// Token: 0x04006474 RID: 25716
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		// Token: 0x04006475 RID: 25717
		private Transform[] transform_0;

		// Token: 0x04006476 RID: 25718
		private Quaternion[] quaternion_0;

		// Token: 0x04006477 RID: 25719
		private Vector3 vector3_0;

		// Token: 0x04006478 RID: 25720
		private Vector3 vector3_1;

		// Token: 0x04006479 RID: 25721
		private int int_0;

		// Token: 0x0400647A RID: 25722
		private bool bool_0;

		// Token: 0x0400647B RID: 25723
		private float float_0;
	}
}
