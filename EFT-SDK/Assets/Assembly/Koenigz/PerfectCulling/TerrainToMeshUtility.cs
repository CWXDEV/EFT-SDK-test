using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000DA8 RID: 3496
	[RequireComponent(typeof(Terrain))]
	public class TerrainToMeshUtility : MonoBehaviour
	{
		// Token: 0x060049D9 RID: 18905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateOrUpdateMesh()
		{
			throw null;
		}

		// Token: 0x04005517 RID: 21783
		private readonly string string_0;

		// Token: 0x04005518 RID: 21784
		[Range(1f, 512f)]
		public int MeshResolutionX;

		// Token: 0x04005519 RID: 21785
		[Range(1f, 512f)]
		public int MeshResolutionZ;

		// Token: 0x0400551A RID: 21786
		public MeshRenderer meshRendererReference;
	}
}
