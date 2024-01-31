using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001093 RID: 4243
	public abstract class Grounder : MonoBehaviour
	{
		// Token: 0x06005897 RID: 22679
		public abstract void ResetPosition();

		// Token: 0x06005898 RID: 22680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Vector3 GetSpineOffsetTarget()
		{
			throw null;
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void LogWarning(string message)
		{
			throw null;
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_0(Grounding.Leg leg)
		{
			throw null;
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(Grounding.Leg leg)
		{
			throw null;
		}

		// Token: 0x0600589C RID: 22684
		protected abstract void OpenUserManual();

		// Token: 0x0600589D RID: 22685
		protected abstract void OpenScriptReference();

		// Token: 0x04006457 RID: 25687
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04006458 RID: 25688
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		// Token: 0x04006459 RID: 25689
		public Grounder.GDelegate38 OnPreGrounder;

		// Token: 0x0400645A RID: 25690
		public Grounder.GDelegate38 OnPostGrounder;

		// Token: 0x0400645B RID: 25691
		protected bool initiated;

		// Token: 0x02001094 RID: 4244
		// (Invoke) Token: 0x0600589E RID: 22686
		public delegate void GDelegate38();
	}
}
