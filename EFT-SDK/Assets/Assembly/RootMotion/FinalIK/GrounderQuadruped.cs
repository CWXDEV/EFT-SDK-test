using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001099 RID: 4249
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderQuadruped : Grounder
	{
		// Token: 0x060058C4 RID: 22724 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenUserManual()
		{
			throw null;
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenScriptReference()
		{
			throw null;
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetPosition()
		{
			throw null;
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2()
		{
			throw null;
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(IK[] ikComponents)
		{
			throw null;
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform[] method_5(IK[] ikComponents, ref GrounderQuadruped.GStruct112[] f, int indexOffset)
		{
			throw null;
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(GrounderQuadruped.GStruct112 foot, float maxOffset)
		{
			throw null;
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(IK[] ikComponents)
		{
			throw null;
		}

		// Token: 0x0400647C RID: 25724
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		// Token: 0x0400647D RID: 25725
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		// Token: 0x0400647E RID: 25726
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		// Token: 0x0400647F RID: 25727
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		// Token: 0x04006480 RID: 25728
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		// Token: 0x04006481 RID: 25729
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		// Token: 0x04006482 RID: 25730
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		// Token: 0x04006483 RID: 25731
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		// Token: 0x04006484 RID: 25732
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x04006485 RID: 25733
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		// Token: 0x04006486 RID: 25734
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		// Token: 0x04006487 RID: 25735
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		// Token: 0x04006488 RID: 25736
		public IK[] legs;

		// Token: 0x04006489 RID: 25737
		public IK[] forelegs;

		// Token: 0x0400648A RID: 25738
		[HideInInspector]
		public Vector3 gravity;

		// Token: 0x0400648B RID: 25739
		private GrounderQuadruped.GStruct112[] gstruct112_0;

		// Token: 0x0400648C RID: 25740
		private Vector3 vector3_0;

		// Token: 0x0400648D RID: 25741
		private Quaternion quaternion_0;

		// Token: 0x0400648E RID: 25742
		private Quaternion quaternion_1;

		// Token: 0x0400648F RID: 25743
		private Vector3 vector3_1;

		// Token: 0x04006490 RID: 25744
		private Quaternion quaternion_2;

		// Token: 0x04006491 RID: 25745
		private Quaternion quaternion_3;

		// Token: 0x04006492 RID: 25746
		private int int_0;

		// Token: 0x04006493 RID: 25747
		private bool bool_0;

		// Token: 0x04006494 RID: 25748
		private float float_0;

		// Token: 0x04006495 RID: 25749
		private Transform transform_0;

		// Token: 0x04006496 RID: 25750
		private Quaternion quaternion_4;

		// Token: 0x04006497 RID: 25751
		private float float_1;

		// Token: 0x0200109A RID: 4250
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct112
		{
			// Token: 0x04006498 RID: 25752
			public IKSolver solver;

			// Token: 0x04006499 RID: 25753
			public Transform transform;

			// Token: 0x0400649A RID: 25754
			public Quaternion rotation;

			// Token: 0x0400649B RID: 25755
			public Grounding.Leg leg;
		}
	}
}
