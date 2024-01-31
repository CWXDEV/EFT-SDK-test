using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010A3 RID: 4259
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		// Token: 0x06005926 RID: 22822 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenUserManual()
		{
			throw null;
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OpenScriptReference()
		{
			throw null;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Support Group")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Asset Store Thread")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
			throw null;
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver GetIKSolver()
		{
			throw null;
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReferencesError(ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReferencesWarning(ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Reinitiate")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Auto-detect References")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x040064C7 RID: 25799
		public BipedReferences references;

		// Token: 0x040064C8 RID: 25800
		public IKSolverFullBodyBiped solver;
	}
}
