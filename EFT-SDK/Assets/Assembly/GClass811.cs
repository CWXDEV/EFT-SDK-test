using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.HealthSystem;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x0200095C RID: 2396
public class GClass811 : IHealthController
{
	// Token: 0x17000931 RID: 2353
	// (get) Token: 0x060035C0 RID: 13760 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060035C1 RID: 13761 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAlive
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000932 RID: 2354
	// (get) Token: 0x060035C2 RID: 13762 RVA: 0x00002050 File Offset: 0x00000250
	public ObservedCorpse PlayerCorpse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140000AF RID: 175
	// (add) Token: 0x060035C3 RID: 13763 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035C4 RID: 13764 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EPhysicalCondition, EPhysicalCondition> OnPhysicalConditionChanged
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

	// Token: 0x060035C5 RID: 13765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PhysicalConditionContainsAny(EPhysicalCondition c)
	{
		throw null;
	}

	// Token: 0x060035C6 RID: 13766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PhysicalConditionIs(EPhysicalCondition c)
	{
		throw null;
	}

	// Token: 0x060035C7 RID: 13767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(EPhysicalCondition c)
	{
		throw null;
	}

	// Token: 0x060035C8 RID: 13768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveMedEffectWithID(string ID)
	{
		throw null;
	}

	// Token: 0x060035C9 RID: 13769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply(GStruct287 model)
	{
		throw null;
	}

	// Token: 0x060035CA RID: 13770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x060035CB RID: 13771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass2220 command)
	{
		throw null;
	}

	// Token: 0x060035CC RID: 13772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass2235 medEffectStatusCommandMessage)
	{
		throw null;
	}

	// Token: 0x060035CD RID: 13773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GClass2254 temperatureCommandMessage)
	{
		throw null;
	}

	// Token: 0x060035CE RID: 13774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass2227 effectOnPlayerStatusCommandMessage)
	{
		throw null;
	}

	// Token: 0x060035CF RID: 13775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GClass2231 healthStatusCommandMessage)
	{
		throw null;
	}

	// Token: 0x060035D0 RID: 13776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GClass2223 deathCommand)
	{
		throw null;
	}

	// Token: 0x060035D1 RID: 13777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ObservedCorpse method_7(Vector3 overallVelocity, bool simulateCorpse)
	{
		throw null;
	}

	// Token: 0x060035D2 RID: 13778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(Item item, GameObject prefab, Vector3 velocity)
	{
		throw null;
	}

	// Token: 0x060035D3 RID: 13779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(RigidbodySpawner spawner)
	{
		throw null;
	}

	// Token: 0x060035D4 RID: 13780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x060035D5 RID: 13781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(EBodyPartColliderType bodyPartColliderType, Vector3 direction, Vector3 point, float force)
	{
		throw null;
	}

	// Token: 0x140000B0 RID: 176
	// (add) Token: 0x060035D6 RID: 13782 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035D7 RID: 13783 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> EffectAddedEvent
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

	// Token: 0x140000B1 RID: 177
	// (add) Token: 0x060035D8 RID: 13784 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035D9 RID: 13785 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> EffectStartedEvent
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

	// Token: 0x140000B2 RID: 178
	// (add) Token: 0x060035DA RID: 13786 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035DB RID: 13787 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> EffectUpdatedEvent
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

	// Token: 0x140000B3 RID: 179
	// (add) Token: 0x060035DC RID: 13788 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035DD RID: 13789 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> EffectResidualEvent
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

	// Token: 0x140000B4 RID: 180
	// (add) Token: 0x060035DE RID: 13790 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035DF RID: 13791 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> EffectRemovedEvent
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

	// Token: 0x140000B5 RID: 181
	// (add) Token: 0x060035E0 RID: 13792 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035E1 RID: 13793 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> EffectStatusUpdateEvent
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

	// Token: 0x140000B6 RID: 182
	// (add) Token: 0x060035E2 RID: 13794 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035E3 RID: 13795 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBodyPart, float, DamageInfo> ApplyDamageEvent
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

	// Token: 0x140000B7 RID: 183
	// (add) Token: 0x060035E4 RID: 13796 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035E5 RID: 13797 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBodyPart, float, DamageInfo> HealthChangedEvent
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

	// Token: 0x140000B8 RID: 184
	// (add) Token: 0x060035E6 RID: 13798 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035E7 RID: 13799 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> EnergyChangedEvent
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

	// Token: 0x140000B9 RID: 185
	// (add) Token: 0x060035E8 RID: 13800 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035E9 RID: 13801 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> HydrationChangedEvent
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

	// Token: 0x140000BA RID: 186
	// (add) Token: 0x060035EA RID: 13802 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035EB RID: 13803 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> TemperatureChangedEvent
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

	// Token: 0x140000BB RID: 187
	// (add) Token: 0x060035EC RID: 13804 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035ED RID: 13805 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBodyPart, EDamageType> BodyPartDestroyedEvent
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

	// Token: 0x140000BC RID: 188
	// (add) Token: 0x060035EE RID: 13806 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035EF RID: 13807 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBodyPart, ValueStruct> BodyPartRestoredEvent
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

	// Token: 0x140000BD RID: 189
	// (add) Token: 0x060035F0 RID: 13808 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035F1 RID: 13809 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EDamageType> DiedEvent
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

	// Token: 0x140000BE RID: 190
	// (add) Token: 0x060035F2 RID: 13810 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035F3 RID: 13811 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEffect> HealerDoneEvent
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

	// Token: 0x140000BF RID: 191
	// (add) Token: 0x060035F4 RID: 13812 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035F5 RID: 13813 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Vector3, float, float> BurnEyesEvent
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

	// Token: 0x140000C0 RID: 192
	// (add) Token: 0x060035F6 RID: 13814 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035F7 RID: 13815 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GInterface226> StimulatorBuffEvent
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

	// Token: 0x140000C1 RID: 193
	// (add) Token: 0x060035F8 RID: 13816 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060035F9 RID: 13817 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GInterface226> StimulatorBuffActivationEvent
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

	// Token: 0x17000933 RID: 2355
	// (get) Token: 0x060035FA RID: 13818 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060035FB RID: 13819 RVA: 0x00002050 File Offset: 0x00000250
	public float FallSafeHeight
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000934 RID: 2356
	// (get) Token: 0x060035FC RID: 13820 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Energy
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000935 RID: 2357
	// (get) Token: 0x060035FD RID: 13821 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Hydration
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000936 RID: 2358
	// (get) Token: 0x060035FE RID: 13822 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Temperature
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000937 RID: 2359
	// (get) Token: 0x060035FF RID: 13823 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Poison
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000938 RID: 2360
	// (get) Token: 0x06003600 RID: 13824 RVA: 0x00002050 File Offset: 0x00000250
	public float HealthRate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000939 RID: 2361
	// (get) Token: 0x06003601 RID: 13825 RVA: 0x00002050 File Offset: 0x00000250
	public float EnergyRate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700093A RID: 2362
	// (get) Token: 0x06003602 RID: 13826 RVA: 0x00002050 File Offset: 0x00000250
	public float HydrationRate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700093B RID: 2363
	// (get) Token: 0x06003603 RID: 13827 RVA: 0x00002050 File Offset: 0x00000250
	public float TemperatureRate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700093C RID: 2364
	// (get) Token: 0x06003604 RID: 13828 RVA: 0x00002050 File Offset: 0x00000250
	public float DamageCoeff
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700093D RID: 2365
	// (get) Token: 0x06003605 RID: 13829 RVA: 0x00002050 File Offset: 0x00000250
	public float StaminaCoeff
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700093E RID: 2366
	// (get) Token: 0x06003606 RID: 13830 RVA: 0x00002050 File Offset: 0x00000250
	public int UpdateTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700093F RID: 2367
	// (get) Token: 0x06003607 RID: 13831 RVA: 0x00002050 File Offset: 0x00000250
	public Player Player
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003608 RID: 13832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false)
	{
		throw null;
	}

	// Token: 0x06003609 RID: 13833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBodyPartBroken(EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600360A RID: 13834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBodyPartDestroyed(EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600360B RID: 13835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetBodyPartsInCriticalCondition(float threshold, out int all, out int vital)
	{
		throw null;
	}

	// Token: 0x0600360C RID: 13836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEncumbered(bool encumbered)
	{
		throw null;
	}

	// Token: 0x0600360D RID: 13837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOverEncumbered(bool encumbered)
	{
		throw null;
	}

	// Token: 0x0600360E RID: 13838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddFatigue()
	{
		throw null;
	}

	// Token: 0x0600360F RID: 13839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddImmunityNotificationEffect()
	{
		throw null;
	}

	// Token: 0x06003610 RID: 13840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TEffect FindExistingEffect<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect
	{
		throw null;
	}

	// Token: 0x06003611 RID: 13841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TEffect FindActiveEffect<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect
	{
		throw null;
	}

	// Token: 0x06003612 RID: 13842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<TEffect> FindActiveEffects<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect
	{
		throw null;
	}

	// Token: 0x06003613 RID: 13843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllActiveEffects(EBodyPart bodyPart = EBodyPart.Common)
	{
		throw null;
	}

	// Token: 0x06003614 RID: 13844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllEffects(EBodyPart bodyPart = EBodyPart.Common)
	{
		throw null;
	}

	// Token: 0x06003615 RID: 13845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllResidualEffects(EBodyPart bodyPart = EBodyPart.Common)
	{
		throw null;
	}

	// Token: 0x17000940 RID: 2368
	// (get) Token: 0x06003616 RID: 13846 RVA: 0x00002050 File Offset: 0x00000250
	public HealthEffects BodyPartEffects
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003617 RID: 13847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsItemForHealing(Item item)
	{
		throw null;
	}

	// Token: 0x06003618 RID: 13848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IResult HasPartsToApply(Item item)
	{
		throw null;
	}

	// Token: 0x06003619 RID: 13849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanApplyItem(Item item, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600361A RID: 13850 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ApplyItem(Item item, EBodyPart bodyPart, float? amount = null)
	{
		throw null;
	}

	// Token: 0x0600361B RID: 13851 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelApplyingItem()
	{
		throw null;
	}

	// Token: 0x0600361C RID: 13852 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600361D RID: 13853 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PropagateAllEffects()
	{
		throw null;
	}

	// Token: 0x0600361E RID: 13854 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] ActiveBuffsNames()
	{
		throw null;
	}

	// Token: 0x0600361F RID: 13855 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PauseAllEffects()
	{
		throw null;
	}

	// Token: 0x06003620 RID: 13856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnpauseAllEffects()
	{
		throw null;
	}

	// Token: 0x17000941 RID: 2369
	// (get) Token: 0x06003621 RID: 13857 RVA: 0x00002050 File Offset: 0x00000250
	public float CarryingWeightAbsoluteModifier
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000942 RID: 2370
	// (get) Token: 0x06003622 RID: 13858 RVA: 0x00002050 File Offset: 0x00000250
	public float CarryingWeightRelativeModifier
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003623 RID: 13859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_12(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_13(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_14(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_15(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003627 RID: 13863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_16(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003628 RID: 13864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_17(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003629 RID: 13865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_18(EBodyPart eBodyPart, float damage, DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x0600362A RID: 13866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_19(EBodyPart eBodyPart, float damage, DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x0600362B RID: 13867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_20(float delta)
	{
		throw null;
	}

	// Token: 0x0600362C RID: 13868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_21(float delta)
	{
		throw null;
	}

	// Token: 0x0600362D RID: 13869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_22(float delta)
	{
		throw null;
	}

	// Token: 0x0600362E RID: 13870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_23(EBodyPart eBodyPart, EDamageType eDamageType)
	{
		throw null;
	}

	// Token: 0x0600362F RID: 13871 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_24(EBodyPart eBodyPart, ValueStruct value)
	{
		throw null;
	}

	// Token: 0x06003630 RID: 13872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_25(EDamageType eDamageType)
	{
		throw null;
	}

	// Token: 0x06003631 RID: 13873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_26(IEffect iHealthEffect)
	{
		throw null;
	}

	// Token: 0x06003632 RID: 13874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_27(Vector3 position, float str, float time)
	{
		throw null;
	}

	// Token: 0x06003633 RID: 13875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_28(GInterface226 stimulatorBuff)
	{
		throw null;
	}

	// Token: 0x06003634 RID: 13876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_29(GInterface226 stimulatorBuff)
	{
		throw null;
	}

	// Token: 0x06003635 RID: 13877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableMetabolism()
	{
		throw null;
	}

	// Token: 0x04003709 RID: 14089
	public ETagStatus HealthStatus;

	// Token: 0x0400370A RID: 14090
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400370B RID: 14091
	private ObservedPlayerView observedPlayerView_0;

	// Token: 0x0400370C RID: 14092
	private ObservedCorpse observedCorpse_0;

	// Token: 0x0400370D RID: 14093
	private Player.GClass1572 gclass1572_0;

	// Token: 0x0400370E RID: 14094
	private EPhysicalCondition ephysicalCondition_0;

	// Token: 0x0400370F RID: 14095
	private HashSet<string> hashSet_0;

	// Token: 0x04003710 RID: 14096
	[CompilerGenerated]
	private Action<EPhysicalCondition, EPhysicalCondition> action_0;

	// Token: 0x04003711 RID: 14097
	[CompilerGenerated]
	private Action<IEffect> action_1;

	// Token: 0x04003712 RID: 14098
	[CompilerGenerated]
	private Action<IEffect> action_2;

	// Token: 0x04003713 RID: 14099
	[CompilerGenerated]
	private Action<IEffect> action_3;

	// Token: 0x04003714 RID: 14100
	[CompilerGenerated]
	private Action<IEffect> action_4;

	// Token: 0x04003715 RID: 14101
	[CompilerGenerated]
	private Action<IEffect> action_5;

	// Token: 0x04003716 RID: 14102
	[CompilerGenerated]
	private Action<IEffect> action_6;

	// Token: 0x04003717 RID: 14103
	[CompilerGenerated]
	private Action<EBodyPart, float, DamageInfo> action_7;

	// Token: 0x04003718 RID: 14104
	[CompilerGenerated]
	private Action<EBodyPart, float, DamageInfo> action_8;

	// Token: 0x04003719 RID: 14105
	[CompilerGenerated]
	private Action<float> action_9;

	// Token: 0x0400371A RID: 14106
	[CompilerGenerated]
	private Action<float> action_10;

	// Token: 0x0400371B RID: 14107
	[CompilerGenerated]
	private Action<float> action_11;

	// Token: 0x0400371C RID: 14108
	[CompilerGenerated]
	private Action<EBodyPart, EDamageType> action_12;

	// Token: 0x0400371D RID: 14109
	[CompilerGenerated]
	private Action<EBodyPart, ValueStruct> action_13;

	// Token: 0x0400371E RID: 14110
	[CompilerGenerated]
	private Action<EDamageType> action_14;

	// Token: 0x0400371F RID: 14111
	[CompilerGenerated]
	private Action<IEffect> action_15;

	// Token: 0x04003720 RID: 14112
	[CompilerGenerated]
	private Action<Vector3, float, float> action_16;

	// Token: 0x04003721 RID: 14113
	[CompilerGenerated]
	private Action<GInterface226> action_17;

	// Token: 0x04003722 RID: 14114
	[CompilerGenerated]
	private Action<GInterface226> action_18;

	// Token: 0x04003723 RID: 14115
	[CompilerGenerated]
	private float float_0;

	// Token: 0x04003724 RID: 14116
	[CompilerGenerated]
	private readonly ValueStruct valueStruct_0;

	// Token: 0x04003725 RID: 14117
	[CompilerGenerated]
	private readonly ValueStruct valueStruct_1;

	// Token: 0x04003726 RID: 14118
	[CompilerGenerated]
	private readonly ValueStruct valueStruct_2;

	// Token: 0x04003727 RID: 14119
	[CompilerGenerated]
	private readonly ValueStruct valueStruct_3;

	// Token: 0x04003728 RID: 14120
	[CompilerGenerated]
	private readonly float float_1;

	// Token: 0x04003729 RID: 14121
	[CompilerGenerated]
	private readonly float float_2;

	// Token: 0x0400372A RID: 14122
	[CompilerGenerated]
	private readonly float float_3;

	// Token: 0x0400372B RID: 14123
	[CompilerGenerated]
	private readonly float float_4;

	// Token: 0x0400372C RID: 14124
	[CompilerGenerated]
	private readonly float float_5;

	// Token: 0x0400372D RID: 14125
	[CompilerGenerated]
	private readonly float float_6;

	// Token: 0x0400372E RID: 14126
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x0400372F RID: 14127
	[CompilerGenerated]
	private readonly Player player_0;

	// Token: 0x04003730 RID: 14128
	[CompilerGenerated]
	private readonly HealthEffects healthEffects_0;

	// Token: 0x04003731 RID: 14129
	[CompilerGenerated]
	private readonly float float_7;

	// Token: 0x04003732 RID: 14130
	[CompilerGenerated]
	private readonly float float_8;
}
