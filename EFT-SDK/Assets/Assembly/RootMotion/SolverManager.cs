using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02001077 RID: 4215
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x0600580C RID: 22540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitiateSolver()
		{
			throw null;
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateSolver()
		{
			throw null;
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Transform t, bool findInChildren)
		{
			throw null;
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSolverExternal()
		{
			throw null;
		}

		// Token: 0x040063A7 RID: 25511
		[Tooltip("If zero, will update the solver in every LateUpdate(). Use this for chains that are animated. If > 0, will be used as updating frequency so that the solver will reach its target in the same time on all machines.")]
		public float timeStep;

		// Token: 0x040063A8 RID: 25512
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		// Token: 0x040063A9 RID: 25513
		private float float_0;

		// Token: 0x040063AA RID: 25514
		private Animator animator_0;

		// Token: 0x040063AB RID: 25515
		private Animation animation_0;

		// Token: 0x040063AC RID: 25516
		private bool bool_0;

		// Token: 0x040063AD RID: 25517
		private bool bool_1;

		// Token: 0x040063AE RID: 25518
		private bool bool_2;
	}
}
