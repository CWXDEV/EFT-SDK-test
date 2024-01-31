using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010CE RID: 4302
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x06005AA1 RID: 23201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitiateSolver()
		{
			throw null;
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateSolver()
		{
			throw null;
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Transform t, bool findInChildren)
		{
			throw null;
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06005AAB RID: 23211 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x04006622 RID: 26146
		[Tooltip("If zero, will update the solver in every LateUpdate(). Use this for chains that are animated. If > 0, will be used as updating frequency so that the solver will reach its target in the same time on all machines.")]
		public float timeStep;

		// Token: 0x04006623 RID: 26147
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		// Token: 0x04006624 RID: 26148
		private float float_0;

		// Token: 0x04006625 RID: 26149
		private Animator animator_0;

		// Token: 0x04006626 RID: 26150
		private Animation animation_0;

		// Token: 0x04006627 RID: 26151
		private bool bool_0;

		// Token: 0x04006628 RID: 26152
		private bool bool_1;

		// Token: 0x04006629 RID: 26153
		private bool bool_2;
	}
}
