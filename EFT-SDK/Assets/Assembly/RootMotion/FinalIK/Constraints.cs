using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001090 RID: 4240
	[Serializable]
	public class Constraints
	{
		// Token: 0x0600587E RID: 22654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid()
		{
			throw null;
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(Transform transform)
		{
			throw null;
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x04006442 RID: 25666
		public Transform transform;

		// Token: 0x04006443 RID: 25667
		public Vector3 positionOffset;

		// Token: 0x04006444 RID: 25668
		public Vector3 position;

		// Token: 0x04006445 RID: 25669
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04006446 RID: 25670
		public Vector3 rotationOffset;

		// Token: 0x04006447 RID: 25671
		public Vector3 rotation;

		// Token: 0x04006448 RID: 25672
		[Range(0f, 1f)]
		public float rotationWeight;
	}
}
