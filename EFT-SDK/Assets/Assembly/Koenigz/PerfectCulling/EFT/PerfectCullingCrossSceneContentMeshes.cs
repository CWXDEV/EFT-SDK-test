using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DFF RID: 3583
	[DisallowMultipleComponent]
	public sealed class PerfectCullingCrossSceneContentMeshes : PerfectCullingCrossSceneContent
	{
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x00002050 File Offset: 0x00000250
		public Renderer[] Windows
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FillWindows()
		{
			throw null;
		}

		// Token: 0x04005631 RID: 22065
		[SerializeField]
		private Renderer[] _windows;
	}
}
