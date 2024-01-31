using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027F3 RID: 10227
	public sealed class BrokenWindowPieceTemplate : MonoBehaviour
	{
		// Token: 0x0600CCC3 RID: 52419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct387 GetPiece()
		{
			throw null;
		}

		// Token: 0x0400CD0A RID: 52490
		[SerializeField]
		private MeshFilter _meshFilter;

		// Token: 0x0400CD0B RID: 52491
		[SerializeField]
		private MeshRenderer _meshRenderer;

		// Token: 0x0400CD0C RID: 52492
		[SerializeField]
		private MeshCollider _meshCollider;

		// Token: 0x0400CD0D RID: 52493
		[SerializeField]
		private BallisticCollider _ballisticCollider;

		// Token: 0x0400CD0E RID: 52494
		[SerializeField]
		private GameObject _child;

		// Token: 0x0400CD0F RID: 52495
		[SerializeField]
		private BoxCollider _childBoxCollider;

		// Token: 0x0400CD10 RID: 52496
		[SerializeField]
		private BrokenWindowPieceCollider _childFragileGlassCollider;
	}
}
