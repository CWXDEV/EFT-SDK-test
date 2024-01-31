using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001092 RID: 4242
	public class FingerRig : SolverManager
	{
		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x0600588B RID: 22667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600588C RID: 22668 RVA: 0x00002050 File Offset: 0x00000250
		public bool initiated
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Auto-detect")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AutoDetect()
		{
			throw null;
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null)
		{
			throw null;
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFinger(int index)
		{
			throw null;
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Transform parent, ref Transform[] array)
		{
			throw null;
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitiateSolver()
		{
			throw null;
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFingerSolvers()
		{
			throw null;
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixFingerTransforms()
		{
			throw null;
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateSolver()
		{
			throw null;
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x04006454 RID: 25684
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04006455 RID: 25685
		public Finger[] fingers;

		// Token: 0x04006456 RID: 25686
		[CompilerGenerated]
		private bool bool_3;
	}
}
