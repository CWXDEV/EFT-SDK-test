using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027C4 RID: 10180
	public sealed class LootPoint_LEGACY : MonoBehaviour
	{
		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600CC1A RID: 52250 RVA: 0x00002050 File Offset: 0x00000250
		public List<LootPoint_LEGACY.WeightedSpawnPosition> GroupPositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Convert()
		{
			throw null;
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootPointParameters AsLootPointParameters()
		{
			throw null;
		}

		// Token: 0x0400CC36 RID: 52278
		[SerializeField]
		private List<LootPoint_LEGACY.WeightedSpawnPosition> _groupPositions;

		// Token: 0x0400CC37 RID: 52279
		public LootPointParameters Settings;

		// Token: 0x020027C5 RID: 10181
		[Serializable]
		public sealed class WeightedSpawnPosition
		{
			// Token: 0x0400CC38 RID: 52280
			public Transform Transform;

			// Token: 0x0400CC39 RID: 52281
			public float Weight;
		}

		// Token: 0x020027C6 RID: 10182
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2302
		{
			// Token: 0x0600CC1E RID: 52254 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal WeightedLootPointSpawnPosition method_0(LootPoint_LEGACY.WeightedSpawnPosition x)
			{
				throw null;
			}

			// Token: 0x0400CC3A RID: 52282
			public static readonly LootPoint_LEGACY.Class2302 class2302_0;

			// Token: 0x0400CC3B RID: 52283
			public static Func<LootPoint_LEGACY.WeightedSpawnPosition, WeightedLootPointSpawnPosition> func_0;
		}
	}
}
