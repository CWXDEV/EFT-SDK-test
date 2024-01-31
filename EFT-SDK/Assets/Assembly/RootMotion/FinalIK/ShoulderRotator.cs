using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001108 RID: 4360
	public class ShoulderRotator : MonoBehaviour
	{
		// Token: 0x06005BD2 RID: 23506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(FullBodyBipedChain chain, float weight, float offset)
		{
			throw null;
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IKMapping.BoneMap method_2(FullBodyBipedChain chain)
		{
			throw null;
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04006773 RID: 26483
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		// Token: 0x04006774 RID: 26484
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		// Token: 0x04006775 RID: 26485
		private FullBodyBipedIK fullBodyBipedIK_0;

		// Token: 0x04006776 RID: 26486
		private bool bool_0;
	}
}
