using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02001668 RID: 5736
public abstract class GClass1787 : GClass1786, IStatisticsManager
{
	// Token: 0x14000175 RID: 373
	// (add) Token: 0x06007C3A RID: 31802 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007C3B RID: 31803 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17001398 RID: 5016
	// (get) Token: 0x06007C3C RID: 31804 RVA: 0x00002050 File Offset: 0x00000250
	public TimeSpan CurrentSessionLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007C3D RID: 31805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Player player)
	{
		throw null;
	}

	// Token: 0x06007C3E RID: 31806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_10()
	{
		throw null;
	}

	// Token: 0x06007C3F RID: 31807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeginStatisticsSession()
	{
		throw null;
	}

	// Token: 0x06007C40 RID: 31808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndStatisticsSession(ExitStatus exitStatus, float pastTime)
	{
		throw null;
	}

	// Token: 0x06007C41 RID: 31809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x06007C42 RID: 31810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ForeachItems(Item item, Action<Item, bool> action, bool grab = false)
	{
		throw null;
	}

	// Token: 0x06007C43 RID: 31811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGrabLoot(Item item)
	{
		throw null;
	}

	// Token: 0x06007C44 RID: 31812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool IsNeedWriteLootExperience()
	{
		throw null;
	}

	// Token: 0x06007C45 RID: 31813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(Item item, bool grab)
	{
		throw null;
	}

	// Token: 0x06007C46 RID: 31814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnInteractWithLootContainer(Item item)
	{
		throw null;
	}

	// Token: 0x06007C47 RID: 31815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(Item item)
	{
		throw null;
	}

	// Token: 0x06007C48 RID: 31816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14(GClass2899 invokedEvent)
	{
		throw null;
	}

	// Token: 0x06007C49 RID: 31817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDoorExperience(bool breached)
	{
		throw null;
	}

	// Token: 0x06007C4A RID: 31818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyKill(DamageInfo damage, EDamageType lethalDamageType, EBodyPart bodyPart, EPlayerSide playerSide, WildSpawnType role, string playerAccountId, string playerProfileId, string playerName, string groupId, int level, int killExp, float distance, int hour, List<string> targetEquipment, HealthEffects enemyEffects, List<string> zoneIds, bool isFriendly)
	{
		throw null;
	}

	// Token: 0x06007C4B RID: 31819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyDamage(DamageInfo damage, EBodyPart bodyPart, EPlayerSide playerSide, string role, string groupId, float fullHealth, bool isHeavyDamage, float distance, int hour, List<string> targetEquipment, HealthEffects enemyEffects, List<string> zoneIds)
	{
		throw null;
	}

	// Token: 0x06007C4C RID: 31820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnShot(Weapon weapon, BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x06007C4D RID: 31821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15(Weapon weapon, BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x06007C4E RID: 31822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_16(string id, int experience)
	{
		throw null;
	}

	// Token: 0x06007C4F RID: 31823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17(Player player, IPlayer lastAggressor, DamageInfo damage, EBodyPart part)
	{
		throw null;
	}

	// Token: 0x06007C50 RID: 31824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(int exp, bool grab)
	{
		throw null;
	}

	// Token: 0x06007C51 RID: 31825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<SessionCountersClass.GClass1784, long> method_19()
	{
		throw null;
	}

	// Token: 0x06007C52 RID: 31826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(Inventory inventory)
	{
		throw null;
	}

	// Token: 0x06007C53 RID: 31827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGroupMemberConnected(Inventory inventory)
	{
		throw null;
	}

	// Token: 0x040082DD RID: 33501
	private const int int_0 = 10;

	// Token: 0x040082DE RID: 33502
	private const float float_4 = 1f;

	// Token: 0x040082DF RID: 33503
	private const string string_0 = "Bear";

	// Token: 0x040082E0 RID: 33504
	private const string string_1 = "Usec";

	// Token: 0x040082E1 RID: 33505
	private const string string_2 = "AnyPmc";

	// Token: 0x040082E2 RID: 33506
	private const string string_3 = "Savage";

	// Token: 0x040082E3 RID: 33507
	private const string string_4 = "Any";

	// Token: 0x040082E4 RID: 33508
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x040082E5 RID: 33509
	protected Player player_0;

	// Token: 0x040082E6 RID: 33510
	private readonly HashSet<string> hashSet_0;

	// Token: 0x040082E7 RID: 33511
	private readonly HashSet<string> hashSet_1;

	// Token: 0x040082E8 RID: 33512
	private int int_1;

	// Token: 0x040082E9 RID: 33513
	private float float_5;

	// Token: 0x040082EA RID: 33514
	private float float_6;

	// Token: 0x040082EB RID: 33515
	private float float_7;

	// Token: 0x040082EC RID: 33516
	private DateTime dateTime_0;

	// Token: 0x040082ED RID: 33517
	private int int_2;

	// Token: 0x040082EE RID: 33518
	private int int_3;

	// Token: 0x040082EF RID: 33519
	private Coroutine coroutine_0;

	// Token: 0x040082F0 RID: 33520
	private Dictionary<SessionCountersClass.GClass1784, long> dictionary_0;

	// Token: 0x040082F1 RID: 33521
	private Action action_1;
}
