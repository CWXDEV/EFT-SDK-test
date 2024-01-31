using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JsonType;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027BA RID: 10170
	[DisallowMultipleComponent]
	[RequireComponent(typeof(LootPointViewer))]
	public sealed class LootPoint : MonoBehaviour
	{
		// Token: 0x0600CBE7 RID: 52199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GenerateGUID()
		{
			throw null;
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0()
		{
			throw null;
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x0600CBEA RID: 52202 RVA: 0x00002050 File Offset: 0x00000250
		public string[] SelectedFilters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600CBEB RID: 52203 RVA: 0x00002050 File Offset: 0x00000250
		public List<GroupLootPoint> GroupPositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600CBEC RID: 52204 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsGroupPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600CBED RID: 52205 RVA: 0x00002050 File Offset: 0x00000250
		private string[] String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CBEE RID: 52206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootPointParameters AsLootPointParameters()
		{
			throw null;
		}

		// Token: 0x0600CBEF RID: 52207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyLootPointParameters(LootPointParameters parameters)
		{
			throw null;
		}

		// Token: 0x0600CBF0 RID: 52208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsLootSetSelected(string id)
		{
			throw null;
		}

		// Token: 0x0600CBF1 RID: 52209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLootSet(string id)
		{
			throw null;
		}

		// Token: 0x0600CBF2 RID: 52210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveLootSet(string id)
		{
			throw null;
		}

		// Token: 0x0600CBF3 RID: 52211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearLootSets()
		{
			throw null;
		}

		// Token: 0x0600CBF4 RID: 52212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedFilters(string[] selectedFilters)
		{
			throw null;
		}

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddGroupPoint()
		{
			throw null;
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GroupLootPoint method_1()
		{
			throw null;
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveGroupPoint(GroupLootPoint point)
		{
			throw null;
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomizeRotation()
		{
			throw null;
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0400CC0B RID: 52235
		public LootPointMode Mode;

		// Token: 0x0400CC0C RID: 52236
		public string Id;

		// Token: 0x0400CC0D RID: 52237
		public bool Enabled;

		// Token: 0x0400CC0E RID: 52238
		public bool UseGravity;

		// Token: 0x0400CC0F RID: 52239
		public bool RandomRotation;

		// Token: 0x0400CC10 RID: 52240
		public float ChanceModifier;

		// Token: 0x0400CC11 RID: 52241
		public bool IsAlwaysSpawn;

		// Token: 0x0400CC12 RID: 52242
		public ELootRarity Rarity;

		// Token: 0x0400CC13 RID: 52243
		[SerializeField]
		private List<string> _lootSets;

		// Token: 0x0400CC14 RID: 52244
		[SerializeField]
		private string[] _filterInclusive;

		// Token: 0x0400CC15 RID: 52245
		[SerializeField]
		private List<GroupLootPoint> _groupPositions;

		// Token: 0x020027BB RID: 10171
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2298
		{
			// Token: 0x0600CBFB RID: 52219 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<string> method_0(string lootSet)
			{
				throw null;
			}

			// Token: 0x0600CBFC RID: 52220 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal WeightedLootPointSpawnPosition method_1(GroupLootPoint position)
			{
				throw null;
			}

			// Token: 0x0400CC16 RID: 52246
			public static readonly LootPoint.Class2298 class2298_0;

			// Token: 0x0400CC17 RID: 52247
			public static Func<string, IEnumerable<string>> func_0;

			// Token: 0x0400CC18 RID: 52248
			public static Func<GroupLootPoint, WeightedLootPointSpawnPosition> func_1;
		}
	}
}
