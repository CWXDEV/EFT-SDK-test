using System;
using System.Collections.Generic;
using EFT.HealthSystem;
using EFT.InventoryLogic;

namespace EFT
{
	// Token: 0x0200166E RID: 5742
	public interface IStatisticsManager
	{
		// Token: 0x06007C88 RID: 31880
		void Init(Player player);

		// Token: 0x06007C89 RID: 31881
		void BeginStatisticsSession();

		// Token: 0x06007C8A RID: 31882
		void EndStatisticsSession(ExitStatus exitStatus, float pastTime);

		// Token: 0x06007C8B RID: 31883
		void OnGrabLoot(Item item);

		// Token: 0x06007C8C RID: 31884
		void AddDoorExperience(bool breached);

		// Token: 0x06007C8D RID: 31885
		void OnEnemyKill(DamageInfo damage, EDamageType lethalDamageType, EBodyPart bodyPart, EPlayerSide playerSide, WildSpawnType role, string playerAccountId, string playerProfileId, string playerName, string groupId, int level, int killExp, float distance, int hour, List<string> targetEquipment, HealthEffects enemyEffects, List<string> zoneIds, bool isFriendly);

		// Token: 0x06007C8E RID: 31886
		void OnEnemyDamage(DamageInfo damage, EBodyPart bodyPart, EPlayerSide playerSide, string role, string groupId, float fullHealth, bool isHeavyDamage, float distance, int hour, List<string> targetEquipment, HealthEffects enemyEffects, List<string> zoneIds);

		// Token: 0x06007C8F RID: 31887
		void OnInteractWithLootContainer(Item item);

		// Token: 0x06007C90 RID: 31888
		void OnShot(Weapon weapon, BulletClass ammo);

		// Token: 0x06007C91 RID: 31889
		void OnGroupMemberConnected(Inventory inventory);

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06007C92 RID: 31890
		TimeSpan CurrentSessionLength { get; }

		// Token: 0x14000177 RID: 375
		// (add) Token: 0x06007C93 RID: 31891
		// (remove) Token: 0x06007C94 RID: 31892
		event Action OnUniqueLoot;
	}
}
