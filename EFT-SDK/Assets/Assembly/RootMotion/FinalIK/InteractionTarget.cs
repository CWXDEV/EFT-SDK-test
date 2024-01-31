using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010DB RID: 4315
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		// Token: 0x06005B22 RID: 23330 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Support Group")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Asset Store Thread")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			throw null;
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetRotation()
		{
			throw null;
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RotateTo(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x04006695 RID: 26261
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		// Token: 0x04006696 RID: 26262
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public InteractionTarget.Multiplier[] multipliers;

		// Token: 0x04006697 RID: 26263
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		// Token: 0x04006698 RID: 26264
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		// Token: 0x04006699 RID: 26265
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		// Token: 0x0400669A RID: 26266
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		// Token: 0x0400669B RID: 26267
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		// Token: 0x0400669C RID: 26268
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		// Token: 0x0400669D RID: 26269
		private Quaternion quaternion_0;

		// Token: 0x0400669E RID: 26270
		private Transform transform_0;

		// Token: 0x020010DC RID: 4316
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0400669F RID: 26271
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x040066A0 RID: 26272
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;
		}
	}
}
