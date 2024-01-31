using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001096 RID: 4246
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		// Token: 0x060058AC RID: 22700 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenUserManual()
		{
			throw null;
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenScriptReference()
		{
			throw null;
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetPosition()
		{
			throw null;
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3()
		{
			throw null;
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate()
		{
			throw null;
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IKEffector effector, Grounding.Leg leg)
		{
			throw null;
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04006465 RID: 25701
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		// Token: 0x04006466 RID: 25702
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		// Token: 0x04006467 RID: 25703
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		// Token: 0x04006468 RID: 25704
		public GrounderFBBIK.SpineEffector[] spine;

		// Token: 0x04006469 RID: 25705
		private Transform[] transform_0;

		// Token: 0x0400646A RID: 25706
		private Vector3 vector3_0;

		// Token: 0x0400646B RID: 25707
		private bool bool_0;

		// Token: 0x02001097 RID: 4247
		[Serializable]
		public class SpineEffector
		{
			// Token: 0x0400646C RID: 25708
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400646D RID: 25709
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			// Token: 0x0400646E RID: 25710
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;
		}
	}
}
