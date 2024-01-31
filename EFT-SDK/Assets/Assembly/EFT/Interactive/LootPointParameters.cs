using System;
using JsonType;
using Newtonsoft.Json;

namespace EFT.Interactive
{
	// Token: 0x020027B6 RID: 10166
	[Serializable]
	public class LootPointParameters
	{
		// Token: 0x0400CBF0 RID: 52208
		public string Id;

		// Token: 0x0400CBF1 RID: 52209
		public bool Enabled;

		// Token: 0x0400CBF2 RID: 52210
		public bool useGravity;

		// Token: 0x0400CBF3 RID: 52211
		public bool randomRotation;

		// Token: 0x0400CBF4 RID: 52212
		public float ChanceModifier;

		// Token: 0x0400CBF5 RID: 52213
		public bool IsAlwaysSpawn;

		// Token: 0x0400CBF6 RID: 52214
		public bool isAlwaysTrySpawnLoot;

		// Token: 0x0400CBF7 RID: 52215
		public ELootRarity Rarity;

		// Token: 0x0400CBF8 RID: 52216
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] LootSets;

		// Token: 0x0400CBF9 RID: 52217
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] FilterInclusive;

		// Token: 0x0400CBFA RID: 52218
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] FilterExclusive;

		// Token: 0x0400CBFB RID: 52219
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LootableContainerParameters[] FilterExtended;

		// Token: 0x0400CBFC RID: 52220
		public ClassVector3 Position;

		// Token: 0x0400CBFD RID: 52221
		public ClassVector3 Rotation;

		// Token: 0x0400CBFE RID: 52222
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public WeightedLootPointSpawnPosition[] GroupPositions;

		// Token: 0x0400CBFF RID: 52223
		public bool IsStatic;

		// Token: 0x0400CC00 RID: 52224
		public bool IsContainer;

		// Token: 0x0400CC01 RID: 52225
		public byte SpawnChance;

		// Token: 0x0400CC02 RID: 52226
		public string LootableContainersGroupId;
	}
}
