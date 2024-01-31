using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E2E RID: 3630
	[CreateAssetMenu(fileName = "New grid data", menuName = "Perfect Culling/Adaptive grid data", order = 1)]
	[PreferBinarySerialization]
	[Serializable]
	public sealed class PerfectCullingAdaptiveGridData : ScriptableObject
	{
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x00002050 File Offset: 0x00000250
		public int NumCells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadFromFile(string filePath, CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetGroupIndex(GuidReference groupGuid)
		{
			throw null;
		}

		// Token: 0x040056BC RID: 22204
		[SerializeField]
		public List<CullingCellData> CellData;

		// Token: 0x040056BD RID: 22205
		[SerializeField]
		public List<GuidReference> GroupMapping;

		// Token: 0x040056BE RID: 22206
		public const int INVALID_GROUP_INDEX = -1;
	}
}
