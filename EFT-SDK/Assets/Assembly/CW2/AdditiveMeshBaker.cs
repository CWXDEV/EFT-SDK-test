using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CW2
{
	// Token: 0x02000C81 RID: 3201
	public class AdditiveMeshBaker : MonoBehaviour
	{
		// Token: 0x06004543 RID: 17731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x04004FAC RID: 20396
		public bool SaveCollider;

		// Token: 0x04004FAD RID: 20397
		public bool DontDesttroyComponents;

		// Token: 0x04004FAE RID: 20398
		[HideInInspector]
		public Rigidbody Rigidbody;
	}
}
