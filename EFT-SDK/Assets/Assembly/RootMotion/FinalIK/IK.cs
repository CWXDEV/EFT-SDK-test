using System;
using System.Runtime.CompilerServices;

namespace RootMotion.FinalIK
{
	// Token: 0x020010A4 RID: 4260
	public abstract class IK : SolverManager
	{
		// Token: 0x06005932 RID: 22834
		public abstract IKSolver GetIKSolver();

		// Token: 0x06005933 RID: 22835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateSolver()
		{
			throw null;
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitiateSolver()
		{
			throw null;
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005936 RID: 22838
		protected abstract void OpenUserManual();

		// Token: 0x06005937 RID: 22839
		protected abstract void OpenScriptReference();
	}
}
