using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010A9 RID: 4265
	[Serializable]
	public class FABRIKChain
	{
		// Token: 0x06005949 RID: 22857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate()
		{
			throw null;
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stage1(FABRIKChain[] chain)
		{
			throw null;
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
			throw null;
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_0(FABRIKChain[] chain)
		{
			throw null;
		}

		// Token: 0x040064CD RID: 25805
		public FABRIK ik;

		// Token: 0x040064CE RID: 25806
		[Range(0f, 1f)]
		public float pull;

		// Token: 0x040064CF RID: 25807
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x040064D0 RID: 25808
		public int[] children;
	}
}
