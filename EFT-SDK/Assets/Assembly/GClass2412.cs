using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Comfort.Common;
using EFT;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002114 RID: 8468
public abstract class GClass2412<T> : IHealthController where T : IEffect
{
	// Token: 0x14000245 RID: 581
	// (add) Token: 0x0600AF10 RID: 44816
	// (remove) Token: 0x0600AF11 RID: 44817
	public abstract event Action<IEffect> EffectStartedEvent;

	// Token: 0x14000246 RID: 582
	// (add) Token: 0x0600AF12 RID: 44818
	// (remove) Token: 0x0600AF13 RID: 44819
	public abstract event Action<IEffect> EffectUpdatedEvent;

	// Token: 0x14000247 RID: 583
	// (add) Token: 0x0600AF14 RID: 44820
	// (remove) Token: 0x0600AF15 RID: 44821
	public abstract event Action<IEffect> EffectResidualEvent;

	// Token: 0x14000248 RID: 584
	// (add) Token: 0x0600AF16 RID: 44822
	// (remove) Token: 0x0600AF17 RID: 44823
	public abstract event Action<IEffect> EffectRemovedEvent;

	// Token: 0x14000249 RID: 585
	// (add) Token: 0x0600AF18 RID: 44824
	// (remove) Token: 0x0600AF19 RID: 44825
	public abstract event Action<IEffect> EffectAddedEvent;

	// Token: 0x1400024A RID: 586
	// (add) Token: 0x0600AF1A RID: 44826
	// (remove) Token: 0x0600AF1B RID: 44827
	public abstract event Action<IEffect> EffectStatusUpdateEvent;

	// Token: 0x1400024B RID: 587
	// (add) Token: 0x0600AF1C RID: 44828
	// (remove) Token: 0x0600AF1D RID: 44829
	public abstract event Action<EBodyPart, float, DamageInfo> ApplyDamageEvent;

	// Token: 0x1400024C RID: 588
	// (add) Token: 0x0600AF1E RID: 44830
	// (remove) Token: 0x0600AF1F RID: 44831
	public abstract event Action<EBodyPart, float, DamageInfo> HealthChangedEvent;

	// Token: 0x1400024D RID: 589
	// (add) Token: 0x0600AF20 RID: 44832
	// (remove) Token: 0x0600AF21 RID: 44833
	public abstract event Action<float> EnergyChangedEvent;

	// Token: 0x1400024E RID: 590
	// (add) Token: 0x0600AF22 RID: 44834
	// (remove) Token: 0x0600AF23 RID: 44835
	public abstract event Action<float> HydrationChangedEvent;

	// Token: 0x1400024F RID: 591
	// (add) Token: 0x0600AF24 RID: 44836
	// (remove) Token: 0x0600AF25 RID: 44837
	public abstract event Action<float> TemperatureChangedEvent;

	// Token: 0x14000250 RID: 592
	// (add) Token: 0x0600AF26 RID: 44838
	// (remove) Token: 0x0600AF27 RID: 44839
	public abstract event Action<float> PoisonChangedEvent;

	// Token: 0x14000251 RID: 593
	// (add) Token: 0x0600AF28 RID: 44840
	// (remove) Token: 0x0600AF29 RID: 44841
	public abstract event Action<EBodyPart, EDamageType> BodyPartDestroyedEvent;

	// Token: 0x14000252 RID: 594
	// (add) Token: 0x0600AF2A RID: 44842
	// (remove) Token: 0x0600AF2B RID: 44843
	public abstract event Action<EBodyPart, ValueStruct> BodyPartRestoredEvent;

	// Token: 0x14000253 RID: 595
	// (add) Token: 0x0600AF2C RID: 44844
	// (remove) Token: 0x0600AF2D RID: 44845
	public abstract event Action<IEffect> HealerDoneEvent;

	// Token: 0x14000254 RID: 596
	// (add) Token: 0x0600AF2E RID: 44846
	// (remove) Token: 0x0600AF2F RID: 44847
	public abstract event Action<EDamageType> DiedEvent;

	// Token: 0x14000255 RID: 597
	// (add) Token: 0x0600AF30 RID: 44848
	// (remove) Token: 0x0600AF31 RID: 44849
	public abstract event Action<Vector3, float, float> BurnEyesEvent;

	// Token: 0x14000256 RID: 598
	// (add) Token: 0x0600AF32 RID: 44850 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600AF33 RID: 44851 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x14000257 RID: 599
	// (add) Token: 0x0600AF34 RID: 44852 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600AF35 RID: 44853 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17001D0F RID: 7439
	// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF37 RID: 44855 RVA: 0x00002050 File Offset: 0x00000250
	public virtual float FallSafeHeight
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

	// Token: 0x17001D10 RID: 7440
	// (get) Token: 0x0600AF38 RID: 44856 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF39 RID: 44857 RVA: 0x00002050 File Offset: 0x00000250
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
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D11 RID: 7441
	// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Energy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D12 RID: 7442
	// (get) Token: 0x0600AF3B RID: 44859 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Hydration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D13 RID: 7443
	// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Temperature
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D14 RID: 7444
	// (get) Token: 0x0600AF3D RID: 44861 RVA: 0x00002050 File Offset: 0x00000250
	public ValueStruct Poison
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D15 RID: 7445
	// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x00002050 File Offset: 0x00000250
	public bool MetabolismDisabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D16 RID: 7446
	// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF40 RID: 44864 RVA: 0x00002050 File Offset: 0x00000250
	public float EnergyRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D17 RID: 7447
	// (get) Token: 0x0600AF41 RID: 44865 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF42 RID: 44866 RVA: 0x00002050 File Offset: 0x00000250
	public float HydrationRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D18 RID: 7448
	// (get) Token: 0x0600AF43 RID: 44867 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF44 RID: 44868 RVA: 0x00002050 File Offset: 0x00000250
	public float TemperatureRate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D19 RID: 7449
	// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF46 RID: 44870 RVA: 0x00002050 File Offset: 0x00000250
	public float DamageCoeff
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D1A RID: 7450
	// (get) Token: 0x0600AF47 RID: 44871 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF48 RID: 44872 RVA: 0x00002050 File Offset: 0x00000250
	public float StaminaCoeff
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D1B RID: 7451
	// (get) Token: 0x0600AF49 RID: 44873 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF4A RID: 44874 RVA: 0x00002050 File Offset: 0x00000250
	public float DamageMultiplier
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D1C RID: 7452
	// (get) Token: 0x0600AF4B RID: 44875 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF4C RID: 44876 RVA: 0x00002050 File Offset: 0x00000250
	public int UpdateTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001D1D RID: 7453
	// (get) Token: 0x0600AF4D RID: 44877 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Player Player
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600AF4E RID: 44878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PauseAllEffects()
	{
		throw null;
	}

	// Token: 0x0600AF4F RID: 44879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnpauseAllEffects()
	{
		throw null;
	}

	// Token: 0x17001D1E RID: 7454
	// (get) Token: 0x0600AF50 RID: 44880 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF51 RID: 44881 RVA: 0x00002050 File Offset: 0x00000250
	public float CarryingWeightAbsoluteModifier
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

	// Token: 0x17001D1F RID: 7455
	// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600AF53 RID: 44883 RVA: 0x00002050 File Offset: 0x00000250
	public float CarryingWeightRelativeModifier
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

	// Token: 0x17001D20 RID: 7456
	// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x00002050 File Offset: 0x00000250
	public float HealthRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D21 RID: 7457
	// (get) Token: 0x0600AF55 RID: 44885 RVA: 0x00002050 File Offset: 0x00000250
	protected static BackendConfigSettingsClass.GClass1357 GClass1357_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D22 RID: 7458
	// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x00002050 File Offset: 0x00000250
	protected IReadOnlyList<T> IReadOnlyList_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001D23 RID: 7459
	// (get) Token: 0x0600AF57 RID: 44887 RVA: 0x00002050 File Offset: 0x00000250
	protected Dictionary<EBodyPart, GClass2412<T>.BodyPartState> Dictionary_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600AF58 RID: 44888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool RemoveEffectFromList(T effect)
	{
		throw null;
	}

	// Token: 0x0600AF59 RID: 44889 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(T effect)
	{
		throw null;
	}

	// Token: 0x0600AF5A RID: 44890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(T effect)
	{
		throw null;
	}

	// Token: 0x0600AF5B RID: 44891 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(EBodyPart bodyPart, GClass2412<T>.BodyPartState bodyState)
	{
		throw null;
	}

	// Token: 0x0600AF5C RID: 44892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddEffectToList(T effect)
	{
		throw null;
	}

	// Token: 0x0600AF5D RID: 44893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3(float oldDelta, float newDelta)
	{
		throw null;
	}

	// Token: 0x0600AF5E RID: 44894 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_4()
	{
		throw null;
	}

	// Token: 0x0600AF5F RID: 44895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false)
	{
		throw null;
	}

	// Token: 0x0600AF60 RID: 44896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBodyPartBroken(EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF61 RID: 44897 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBodyPartDestroyed(EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF62 RID: 44898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetBodyPartsInCriticalCondition(float threshold, out int all, out int vital)
	{
		throw null;
	}

	// Token: 0x0600AF63 RID: 44899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetEncumbered(bool encumbered)
	{
		throw null;
	}

	// Token: 0x0600AF64 RID: 44900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetOverEncumbered(bool encumbered)
	{
		throw null;
	}

	// Token: 0x0600AF65 RID: 44901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddFatigue()
	{
		throw null;
	}

	// Token: 0x0600AF66 RID: 44902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddImmunityNotificationEffect()
	{
		throw null;
	}

	// Token: 0x0600AF67 RID: 44903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TEffect FindExistingEffect<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect
	{
		throw null;
	}

	// Token: 0x0600AF68 RID: 44904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected IEnumerable<U> method_5<U>(EBodyPart bodyPart = EBodyPart.Common) where U : IEffect
	{
		throw null;
	}

	// Token: 0x0600AF69 RID: 44905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TEffect FindActiveEffect<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect
	{
		throw null;
	}

	// Token: 0x0600AF6A RID: 44906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<TEffect> FindActiveEffects<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect
	{
		throw null;
	}

	// Token: 0x0600AF6B RID: 44907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllActiveEffects(EBodyPart bodyPart = EBodyPart.Common)
	{
		throw null;
	}

	// Token: 0x0600AF6C RID: 44908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllEffects(EBodyPart bodyPart = EBodyPart.Common)
	{
		throw null;
	}

	// Token: 0x0600AF6D RID: 44909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllEffects()
	{
		throw null;
	}

	// Token: 0x0600AF6E RID: 44910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IEffect> GetAllResidualEffects(EBodyPart bodyPart = EBodyPart.Common)
	{
		throw null;
	}

	// Token: 0x17001D24 RID: 7460
	// (get) Token: 0x0600AF6F RID: 44911 RVA: 0x00002050 File Offset: 0x00000250
	public HealthEffects BodyPartEffects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600AF70 RID: 44912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsItemForHealing(Item item)
	{
		throw null;
	}

	// Token: 0x0600AF71 RID: 44913
	public abstract bool ApplyItem(Item item, EBodyPart bodyPart, float? amount = null);

	// Token: 0x0600AF72 RID: 44914
	public abstract void CancelApplyingItem();

	// Token: 0x0600AF73 RID: 44915
	protected abstract void ManualEffectUpdate(T effect, float deltaTime);

	// Token: 0x0600AF74 RID: 44916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600AF75 RID: 44917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_6(GInterface226 buff, bool isUpdateCall = true)
	{
		throw null;
	}

	// Token: 0x0600AF76 RID: 44918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PropagateAllEffects()
	{
		throw null;
	}

	// Token: 0x0600AF77 RID: 44919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Profile.GClass1753 Store(Profile.GClass1753 health = null)
	{
		throw null;
	}

	// Token: 0x0600AF78 RID: 44920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string[] ActiveBuffsNames()
	{
		throw null;
	}

	// Token: 0x0600AF79 RID: 44921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IResult HasPartsToApply(Item item)
	{
		throw null;
	}

	// Token: 0x0600AF7A RID: 44922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanApplyItem(Item item, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF7B RID: 44923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool TryGetBodyPartToApply(Item item, EBodyPart bodyPart, out EBodyPart? damagedBodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF7C RID: 44924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(Item item, EBodyPart bodyPart, bool fastSearch, out EBodyPart? damagedBodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF7D RID: 44925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_8(HealthEffectsComponent healthEffects, MedKitComponent medKit, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF7E RID: 44926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private EBodyPart? method_9(HealthEffectsComponent healthEffects, MedKitComponent medKit, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600AF7F RID: 44927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IResult method_10(Item item)
	{
		throw null;
	}

	// Token: 0x0600AF80 RID: 44928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableMetabolism()
	{
		throw null;
	}

	// Token: 0x0600AF81 RID: 44929 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ref float method_11(float value)
	{
		throw null;
	}

	// Token: 0x0600AF82 RID: 44930 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smethod_0(EBodyPart? part, out EBodyPart? result)
	{
		throw null;
	}

	// Token: 0x0400B485 RID: 46213
	private const string string_0 = "Inventory/IncompatibleItem";

	// Token: 0x0400B486 RID: 46214
	[CompilerGenerated]
	private Action<GInterface226> action_0;

	// Token: 0x0400B487 RID: 46215
	[CompilerGenerated]
	private Action<GInterface226> action_1;

	// Token: 0x0400B488 RID: 46216
	[CompilerGenerated]
	private float float_0;

	// Token: 0x0400B489 RID: 46217
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400B48A RID: 46218
	private bool bool_1;

	// Token: 0x0400B48B RID: 46219
	private float float_1;

	// Token: 0x0400B48C RID: 46220
	private float float_2;

	// Token: 0x0400B48D RID: 46221
	[CompilerGenerated]
	private float float_3;

	// Token: 0x0400B48E RID: 46222
	[CompilerGenerated]
	private float float_4;

	// Token: 0x0400B48F RID: 46223
	private float float_5;

	// Token: 0x0400B490 RID: 46224
	[CompilerGenerated]
	private float float_6;

	// Token: 0x0400B491 RID: 46225
	[CompilerGenerated]
	private int int_0;

	// Token: 0x0400B492 RID: 46226
	protected Action action_2;

	// Token: 0x0400B493 RID: 46227
	protected GClass737<GStruct344> gclass737_0;

	// Token: 0x0400B494 RID: 46228
	[CompilerGenerated]
	private float float_7;

	// Token: 0x0400B495 RID: 46229
	[CompilerGenerated]
	private float float_8;

	// Token: 0x0400B496 RID: 46230
	protected readonly GClass2412<T>.HealControllerLogger healControllerLogger_0;

	// Token: 0x0400B497 RID: 46231
	protected HealthValue healthValue_0;

	// Token: 0x0400B498 RID: 46232
	protected HealthValue healthValue_1;

	// Token: 0x0400B499 RID: 46233
	protected HealthValue healthValue_2;

	// Token: 0x0400B49A RID: 46234
	protected HealthValue healthValue_3;

	// Token: 0x0400B49B RID: 46235
	protected InventoryControllerClass gclass2757_0;

	// Token: 0x0400B49C RID: 46236
	protected SkillManager skillManager_0;

	// Token: 0x0400B49D RID: 46237
	protected float float_9;

	// Token: 0x0400B49E RID: 46238
	protected float float_10;

	// Token: 0x0400B49F RID: 46239
	private readonly Dictionary<EBodyPart, GClass2412<T>.BodyPartState> dictionary_0;

	// Token: 0x0400B4A0 RID: 46240
	private readonly Dictionary<EBodyPart, GClass2412<T>.Class1893> dictionary_1;

	// Token: 0x0400B4A1 RID: 46241
	private readonly Dictionary<EBodyPart, Dictionary<string, float>> dictionary_2;

	// Token: 0x0400B4A2 RID: 46242
	private readonly List<GClass2412<T>.Class1893> list_0;

	// Token: 0x0400B4A3 RID: 46243
	protected readonly List<T> list_1;

	// Token: 0x0400B4A4 RID: 46244
	private readonly List<T> list_2;

	// Token: 0x02002115 RID: 8469
	protected sealed class BodyPartState
	{
		// Token: 0x0400B4A5 RID: 46245
		public bool IsDestroyed;

		// Token: 0x0400B4A6 RID: 46246
		public HealthValue Health;
	}

	// Token: 0x02002116 RID: 8470
	private sealed class Class1893 : IComparable<GClass2412<T>.Class1893>
	{
		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x0600AF83 RID: 44931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AF84 RID: 44932 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanBeHealed
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

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x0600AF85 RID: 44933 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600AF86 RID: 44934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEffect(T effect)
		{
			throw null;
		}

		// Token: 0x0600AF87 RID: 44935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveEffect(T effect)
		{
			throw null;
		}

		// Token: 0x0600AF88 RID: 44936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanApply(HealthEffectsComponent healthEffects, [CanBeNull] MedKitComponent medKit)
		{
			throw null;
		}

		// Token: 0x0600AF89 RID: 44937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCache()
		{
			throw null;
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCache(HealthEffectsComponent healthEffects, [CanBeNull] MedKitComponent medKit)
		{
			throw null;
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(GClass2412<T>.Class1893 another)
		{
			throw null;
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool smethod_0(EDamageEffectType effectType, ref GClass2412<T>.Class1893.Struct730 struct730_0)
		{
			throw null;
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EDamageEffectType effectType, ref GClass2412<T>.Class1893.Struct731 struct731_0)
		{
			throw null;
		}

		// Token: 0x0400B4A7 RID: 46247
		private const float float_0 = 0.05f;

		// Token: 0x0400B4A8 RID: 46248
		public readonly EBodyPart BodyPart;

		// Token: 0x0400B4A9 RID: 46249
		private readonly GClass2412<T>.BodyPartState bodyPartState_0;

		// Token: 0x0400B4AA RID: 46250
		private readonly List<T> list_0;

		// Token: 0x0400B4AB RID: 46251
		private readonly List<EDamageEffectType> list_1;

		// Token: 0x0400B4AC RID: 46252
		private readonly Dictionary<EDamageEffectType, GClass1232> dictionary_0;

		// Token: 0x0400B4AD RID: 46253
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x02002118 RID: 8472
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct730
		{
			// Token: 0x0400B4B1 RID: 46257
			public HealthEffectsComponent healthEffects;

			// Token: 0x0400B4B2 RID: 46258
			public MedKitComponent medKit;
		}

		// Token: 0x02002119 RID: 8473
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct731
		{
			// Token: 0x0400B4B3 RID: 46259
			public HealthEffectsComponent healthEffects;

			// Token: 0x0400B4B4 RID: 46260
			public GClass2412<T>.Class1893 class1893_0;
		}
	}

	// Token: 0x0200211A RID: 8474
	protected class HealControllerLogger : LoggerClass
	{
		// Token: 0x0600AF90 RID: 44944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogAddEffectToEffectsCollection(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogRemoveEffectFromEffectsCollection(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogEffectAdded(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogActivateBuff(GInterface226 buff)
		{
			throw null;
		}
	}

	// Token: 0x0200211B RID: 8475
	[CompilerGenerated]
	private sealed class Class1895
	{
		// Token: 0x0600AF94 RID: 44948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T e)
		{
			throw null;
		}

		// Token: 0x0400B4B5 RID: 46261
		public EBodyPart bodyPart;
	}

	// Token: 0x0200211C RID: 8476
	[CompilerGenerated]
	private sealed class Class1896<U> where U : IEffect
	{
		// Token: 0x0600AF95 RID: 44949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(U e)
		{
			throw null;
		}

		// Token: 0x0400B4B6 RID: 46262
		public EBodyPart bodyPart;
	}

	// Token: 0x0200211D RID: 8477
	[CompilerGenerated]
	private sealed class Class1897<U> where U : IEffect
	{
		// Token: 0x0600AF96 RID: 44950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(U e)
		{
			throw null;
		}

		// Token: 0x0400B4B7 RID: 46263
		public EBodyPart bodyPart;
	}

	// Token: 0x0200211E RID: 8478
	[CompilerGenerated]
	private sealed class Class1898
	{
		// Token: 0x0600AF97 RID: 44951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IEffect e)
		{
			throw null;
		}

		// Token: 0x0400B4B8 RID: 46264
		public EBodyPart bodyPart;
	}

	// Token: 0x0200211F RID: 8479
	[CompilerGenerated]
	private sealed class Class1899
	{
		// Token: 0x0600AF98 RID: 44952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IEffect e)
		{
			throw null;
		}

		// Token: 0x0400B4B9 RID: 46265
		public EBodyPart bodyPart;
	}

	// Token: 0x02002120 RID: 8480
	[CompilerGenerated]
	private sealed class Class1900
	{
		// Token: 0x0600AF99 RID: 44953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IEffect e)
		{
			throw null;
		}

		// Token: 0x0400B4BA RID: 46266
		public EBodyPart bodyPart;
	}

	// Token: 0x02002121 RID: 8481
	[CompilerGenerated]
	private sealed class Class1901
	{
		// Token: 0x0600AF9A RID: 44954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2412<T>.Class1893 partHelper)
		{
			throw null;
		}

		// Token: 0x0400B4BB RID: 46267
		public HealthEffectsComponent healthEffects;

		// Token: 0x0400B4BC RID: 46268
		public MedKitComponent medKit;
	}
}
