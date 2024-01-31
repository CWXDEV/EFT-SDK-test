using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001860 RID: 6240
	public class ObjectFollower : MonoBehaviour
	{
		// Token: 0x060085BC RID: 34236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Follow(Vector3 position)
		{
			throw null;
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_0(Vector3 worldPosition)
		{
			throw null;
		}

		// Token: 0x04008CA3 RID: 36003
		[SerializeField]
		private Transform _object;

		// Token: 0x04008CA4 RID: 36004
		[SerializeField]
		private List<ObjectFollower.Line> _lines;

		// Token: 0x02001861 RID: 6241
		[Serializable]
		public struct Line
		{
			// Token: 0x060085BE RID: 34238 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetNearestPointOnLine(Vector3 position)
			{
				throw null;
			}

			// Token: 0x04008CA5 RID: 36005
			public Vector3 Point1;

			// Token: 0x04008CA6 RID: 36006
			public Vector3 Point2;
		}
	}
}
