using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.Quests;
using JetBrains.Annotations;

// Token: 0x02002FC4 RID: 12228
public abstract class GClass3202<T> : IDisposable where T : GInterface381
{
	// Token: 0x14000365 RID: 869
	// (add) Token: 0x0600F16C RID: 61804 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F16D RID: 61805 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnConditionalStatusChanged
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

	// Token: 0x14000366 RID: 870
	// (add) Token: 0x0600F16E RID: 61806 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F16F RID: 61807 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnTraderAssortmentChanged
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

	// Token: 0x0600F170 RID: 61808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		throw null;
	}

	// Token: 0x0600F171 RID: 61809
	public abstract void Run();

	// Token: 0x0600F172 RID: 61810
	protected abstract void TryNotifyConditionalStatusChanged(T conditional);

	// Token: 0x0600F173 RID: 61811
	protected abstract void TryNotifyConditionChanged(T achievement);

	// Token: 0x0600F174 RID: 61812
	protected abstract void TryToInstantComplete(GInterface381 conditional);

	// Token: 0x0600F175 RID: 61813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnConditionChangedHandler(T conditional)
	{
		throw null;
	}

	// Token: 0x0600F176 RID: 61814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void CreateConditionalList()
	{
		throw null;
	}

	// Token: 0x0600F177 RID: 61815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FailConditional(GInterface381 conditional)
	{
		throw null;
	}

	// Token: 0x0600F178 RID: 61816
	public abstract void SetConditionalStatus(GInterface381 conditional, EQuestStatus status);

	// Token: 0x0600F179 RID: 61817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item[] GetItemsForCondition(Inventory inventory, ConditionItem condition)
	{
		throw null;
	}

	// Token: 0x0600F17A RID: 61818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item[] GetItemsForCondition(ConditionItem condition)
	{
		throw null;
	}

	// Token: 0x0600F17B RID: 61819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnConditionalStatusChangedEvent(T conditional, bool notify)
	{
		throw null;
	}

	// Token: 0x0600F17C RID: 61820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnConditionValueChanged(GInterface381 conditional, EQuestStatus status, Condition condition, bool notify = true)
	{
		throw null;
	}

	// Token: 0x0600F17D RID: 61821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(Dictionary<EQuestStatus, List<GClass3244>> allRewards, EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x0600F17E RID: 61822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCurrentNullableCounters()
	{
		throw null;
	}

	// Token: 0x0600F17F RID: 61823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(string traderId, string templateId, int count)
	{
		throw null;
	}

	// Token: 0x0600F180 RID: 61824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckExitConditionCounters(ExitStatus exitStatus, float pastTime, string locationId, string exitName, HealthEffects effects, List<string> zoneIds)
	{
		throw null;
	}

	// Token: 0x0600F181 RID: 61825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckTriggerConditionCounter(string target, HealthEffects effects, string locationId)
	{
		throw null;
	}

	// Token: 0x0600F182 RID: 61826 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass3212 method_2(string target, List<string> targetEquipment, [CanBeNull] Item weapon, EBodyPart bodyPart, float distance, string role, int hour, HealthEffects enemyEffects)
	{
		throw null;
	}

	// Token: 0x0600F183 RID: 61827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckKillConditionCounter(string target, List<string> targetEquipment, [CanBeNull] Item weapon, EBodyPart bodyPart, string locationId, float distance, string role, int hour, HealthEffects enemyEffects, HealthEffects effects, List<string> zoneIds, string[] buffs)
	{
		throw null;
	}

	// Token: 0x0600F184 RID: 61828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckShotConditionCounter(string target, List<string> targetEquipment, [CanBeNull] Item weapon, EBodyPart bodyPart, string locationId, float distance, string role, int hour, HealthEffects enemyEffects, HealthEffects effects, List<string> zoneIds, string[] buffs)
	{
		throw null;
	}

	// Token: 0x0600F185 RID: 61829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckHealthEffectsCounter(HealthEffects effects, string locationId, List<string> zoneIds)
	{
		throw null;
	}

	// Token: 0x0600F186 RID: 61830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckUseItemCounter(string target, float count, string locationId, List<string> zoneIds)
	{
		throw null;
	}

	// Token: 0x0600F187 RID: 61831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckShootFlareCounter(string zoneID)
	{
		throw null;
	}

	// Token: 0x0600F188 RID: 61832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ManageConditional(T conditional)
	{
		throw null;
	}

	// Token: 0x0600F189 RID: 61833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3(QuestClass<T> conditional)
	{
		throw null;
	}

	// Token: 0x0600F18A RID: 61834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x0400F78A RID: 63370
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400F78B RID: 63371
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400F78C RID: 63372
	public readonly Profile Profile;

	// Token: 0x0400F78D RID: 63373
	protected readonly InventoryControllerClass gclass2757_0;

	// Token: 0x0400F78E RID: 63374
	protected QuestControllerClass<T> gclass3222_0;

	// Token: 0x0400F78F RID: 63375
	protected GClass3358<T> gclass3358_0;

	// Token: 0x0400F790 RID: 63376
	protected bool bool_0;

	// Token: 0x0400F791 RID: 63377
	private readonly GClass763 gclass763_0;

	// Token: 0x02002FC5 RID: 12229
	[CompilerGenerated]
	private sealed class Class3052
	{
		// Token: 0x0600F18B RID: 61835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string templateId, int count)
		{
			throw null;
		}

		// Token: 0x0600F18C RID: 61836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400F792 RID: 63378
		public Profile.TraderInfo traderInfo;

		// Token: 0x0400F793 RID: 63379
		public GClass3202<T> gclass3202_0;
	}
}
