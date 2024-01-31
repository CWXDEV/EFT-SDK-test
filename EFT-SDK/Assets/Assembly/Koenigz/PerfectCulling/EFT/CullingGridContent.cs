using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DD8 RID: 3544
	public sealed class CullingGridContent : MonoBehaviour
	{
		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06004A9C RID: 19100 RVA: 0x00002050 File Offset: 0x00000250
		public CullingGridCellContent[] CellContent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040055CC RID: 21964
		[SerializeField]
		private CullingGridCellContent[] _cellContent;
	}
}
