using System;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200124C RID: 4684
public interface GInterface96
{
	// Token: 0x06006234 RID: 25140
	GInterface355 CreateBallisticCalculator(int seed);

	// Token: 0x06006235 RID: 25141
	void RemoveBallisticCalculator(Item weapon);

	// Token: 0x06006236 RID: 25142
	void RegisterGrenade(Throwable grenade);

	// Token: 0x06006237 RID: 25143
	void UnregisterGrenade(string id);

	// Token: 0x17000FA2 RID: 4002
	// (get) Token: 0x06006238 RID: 25144
	GClass673 GrenadeFactory { get; }

	// Token: 0x06006239 RID: 25145
	LootItem ThrowItem(Item item, IPlayer player, Vector3? fwd);

	// Token: 0x0600623A RID: 25146
	LootItem SetupItem(Item item, IPlayer player, Vector3 position, Quaternion rotation);

	// Token: 0x0600623B RID: 25147
	void DestroyLoot(string id);

	// Token: 0x14000113 RID: 275
	// (add) Token: 0x0600623C RID: 25148
	// (remove) Token: 0x0600623D RID: 25149
	event Action<GInterface12> OnLootItemDestroyed;
}
