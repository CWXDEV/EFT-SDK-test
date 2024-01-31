using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.HealthSystem;
using EFT.InventoryLogic;

// Token: 0x0200166B RID: 5739
public sealed class GClass1785 : IStatisticsManager
{
	// Token: 0x14000176 RID: 374
	// (add) Token: 0x06007C5D RID: 31837 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007C5E RID: 31838 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnUniqueLoot
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1700139B RID: 5019
	// (get) Token: 0x06007C5F RID: 31839 RVA: 0x00002050 File Offset: 0x00000250
	public TimeSpan CurrentSessionLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007C60 RID: 31840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Player player)
	{
		throw null;
	}

	// Token: 0x06007C61 RID: 31841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeginStatisticsSession()
	{
		throw null;
	}

	// Token: 0x06007C62 RID: 31842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndStatisticsSession(ExitStatus exitStatus, float pastTime)
	{
		throw null;
	}

	// Token: 0x06007C63 RID: 31843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGrabLoot(Item item)
	{
		throw null;
	}

	// Token: 0x06007C64 RID: 31844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDoorExperience(bool breached)
	{
		throw null;
	}

	// Token: 0x06007C65 RID: 31845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyKill(DamageInfo damage, EDamageType lethalDamageType, EBodyPart bodyPart, EPlayerSide playerSide, WildSpawnType role, string playerAccountId, string playerProfileId, string playerName, string groupId, int level, int killExp, float distance, int hour, List<string> targetEquipment, HealthEffects enemyEffects, List<string> zoneIds, bool isFriendly)
	{
		throw null;
	}

	// Token: 0x06007C66 RID: 31846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyDamage(DamageInfo damage, EBodyPart bodyPart, EPlayerSide playerSide, string role, string groupId, float fullHealth, bool isHeavyDamage, float distance, int hour, List<string> targetEquipment, HealthEffects enemyEffects, List<string> zoneIds)
	{
		throw null;
	}

	// Token: 0x06007C67 RID: 31847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnShot(Weapon weapon, BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x06007C68 RID: 31848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnInteractWithLootContainer(Item item)
	{
		throw null;
	}

	// Token: 0x06007C69 RID: 31849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGroupMemberConnected(Inventory inventory)
	{
		throw null;
	}

	// Token: 0x040082F7 RID: 33527
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x040082F8 RID: 33528
	private Player player_0;

	// Token: 0x040082F9 RID: 33529
	private readonly HashSet<string> hashSet_0;

	// Token: 0x040082FA RID: 33530
	private DateTime dateTime_0;

	// Token: 0x0200166C RID: 5740
	[CompilerGenerated]
	private sealed class Class1182
	{
		// Token: 0x06007C6A RID: 31850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Item itemInternal, bool b)
		{
			throw null;
		}

		// Token: 0x040082FB RID: 33531
		public GClass1785 gclass1785_0;

		// Token: 0x040082FC RID: 33532
		public Item item;
	}
}
