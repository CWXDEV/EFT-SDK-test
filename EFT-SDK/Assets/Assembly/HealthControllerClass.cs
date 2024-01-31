using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02002152 RID: 8530
public class HealthControllerClass : GClass2412<HealthControllerClass.GClass2417>
{
	// Token: 0x0600B05D RID: 45149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateRegenBaseRatesPerSecond(out float health, out float energy, out float hydration)
	{
		throw null;
	}

	// Token: 0x0600B05E RID: 45150 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateRegenRatesPerSecond(out float health, out float energy, out float hydration)
	{
		throw null;
	}

	// Token: 0x0600B05F RID: 45151 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_1(EBonusType bonusType, double value)
	{
		throw null;
	}

	// Token: 0x17001D60 RID: 7520
	// (get) Token: 0x0600B060 RID: 45152 RVA: 0x00002050 File Offset: 0x00000250
	protected static GClass2420 GClass2420_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000269 RID: 617
	// (add) Token: 0x0600B061 RID: 45153 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B062 RID: 45154 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> EffectStartedEvent
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

	// Token: 0x1400026A RID: 618
	// (add) Token: 0x0600B063 RID: 45155 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B064 RID: 45156 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> EffectUpdatedEvent
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

	// Token: 0x1400026B RID: 619
	// (add) Token: 0x0600B065 RID: 45157 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B066 RID: 45158 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> EffectResidualEvent
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

	// Token: 0x1400026C RID: 620
	// (add) Token: 0x0600B067 RID: 45159 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B068 RID: 45160 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> EffectRemovedEvent
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

	// Token: 0x1400026D RID: 621
	// (add) Token: 0x0600B069 RID: 45161 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B06A RID: 45162 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> EffectAddedEvent
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

	// Token: 0x1400026E RID: 622
	// (add) Token: 0x0600B06B RID: 45163 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B06C RID: 45164 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> EffectStatusUpdateEvent
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

	// Token: 0x1400026F RID: 623
	// (add) Token: 0x0600B06D RID: 45165 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B06E RID: 45166 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<EBodyPart, float, DamageInfo> HealthChangedEvent
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

	// Token: 0x14000270 RID: 624
	// (add) Token: 0x0600B06F RID: 45167 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B070 RID: 45168 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<float> EnergyChangedEvent
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

	// Token: 0x14000271 RID: 625
	// (add) Token: 0x0600B071 RID: 45169 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B072 RID: 45170 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<float> HydrationChangedEvent
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

	// Token: 0x14000272 RID: 626
	// (add) Token: 0x0600B073 RID: 45171 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B074 RID: 45172 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<float> TemperatureChangedEvent
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

	// Token: 0x14000273 RID: 627
	// (add) Token: 0x0600B075 RID: 45173 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B076 RID: 45174 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<float> PoisonChangedEvent
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

	// Token: 0x14000274 RID: 628
	// (add) Token: 0x0600B077 RID: 45175 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B078 RID: 45176 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<IEffect> HealerDoneEvent
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

	// Token: 0x14000275 RID: 629
	// (add) Token: 0x0600B079 RID: 45177 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B07A RID: 45178 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<EBodyPart, float, DamageInfo> ApplyDamageEvent
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

	// Token: 0x14000276 RID: 630
	// (add) Token: 0x0600B07B RID: 45179 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B07C RID: 45180 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<EBodyPart, EDamageType> BodyPartDestroyedEvent
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

	// Token: 0x14000277 RID: 631
	// (add) Token: 0x0600B07D RID: 45181 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B07E RID: 45182 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<EBodyPart, ValueStruct> BodyPartRestoredEvent
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

	// Token: 0x14000278 RID: 632
	// (add) Token: 0x0600B07F RID: 45183 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B080 RID: 45184 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<EDamageType> DiedEvent
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

	// Token: 0x14000279 RID: 633
	// (add) Token: 0x0600B081 RID: 45185 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B082 RID: 45186 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override event Action<Vector3, float, float> BurnEyesEvent
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

	// Token: 0x0600B083 RID: 45187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecalculateRegeneration()
	{
		throw null;
	}

	// Token: 0x0600B084 RID: 45188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyRegenerationImmediately()
	{
		throw null;
	}

	// Token: 0x0600B085 RID: 45189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetOverallHealthRegenTime()
	{
		throw null;
	}

	// Token: 0x0600B086 RID: 45190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeHealth(EBodyPart bodyPart, float value, DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x0600B087 RID: 45191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeEnergy(float value)
	{
		throw null;
	}

	// Token: 0x0600B088 RID: 45192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeHydration(float value)
	{
		throw null;
	}

	// Token: 0x0600B089 RID: 45193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoFracture(EBodyPart bodyPart, float duration = -1f)
	{
		throw null;
	}

	// Token: 0x0600B08A RID: 45194 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(float value)
	{
		throw null;
	}

	// Token: 0x0600B08B RID: 45195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(float value)
	{
		throw null;
	}

	// Token: 0x0600B08C RID: 45196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanApplyItem(Item item, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600B08D RID: 45197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool TryGetBodyPartToApply(Item item, EBodyPart bodyPart, out EBodyPart? damagedBodyPart)
	{
		throw null;
	}

	// Token: 0x0600B08E RID: 45198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ApplyItem(Item item, EBodyPart bodyPart, float? amount = null)
	{
		throw null;
	}

	// Token: 0x0600B08F RID: 45199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTreatment(GInterface371 healthObserver)
	{
		throw null;
	}

	// Token: 0x0600B090 RID: 45200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CancelApplyingItem()
	{
		throw null;
	}

	// Token: 0x0600B091 RID: 45201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualEffectUpdate(HealthControllerClass.GClass2417 effect, float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600B092 RID: 45202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Profile.GClass1753 Store(Profile.GClass1753 health = null)
	{
		throw null;
	}

	// Token: 0x0600B093 RID: 45203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateMusclePainEffect(float duration)
	{
		throw null;
	}

	// Token: 0x0600B094 RID: 45204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14<T>(float duration) where T : HealthControllerClass.MusclePain, new()
	{
		throw null;
	}

	// Token: 0x0600B095 RID: 45205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasMildMusclePainEffect()
	{
		throw null;
	}

	// Token: 0x0600B096 RID: 45206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSevereMusclePainEffect()
	{
		throw null;
	}

	// Token: 0x0600B097 RID: 45207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2420.GClass2451 GetMildMusclePainSettings()
	{
		throw null;
	}

	// Token: 0x0600B098 RID: 45208 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2420.GClass2451 GetSevereMusclePainSettings()
	{
		throw null;
	}

	// Token: 0x0400B4F5 RID: 46325
	[CompilerGenerated]
	private Action<IEffect> action_3;

	// Token: 0x0400B4F6 RID: 46326
	[CompilerGenerated]
	private Action<IEffect> action_4;

	// Token: 0x0400B4F7 RID: 46327
	[CompilerGenerated]
	private Action<IEffect> action_5;

	// Token: 0x0400B4F8 RID: 46328
	[CompilerGenerated]
	private Action<IEffect> action_6;

	// Token: 0x0400B4F9 RID: 46329
	[CompilerGenerated]
	private Action<IEffect> action_7;

	// Token: 0x0400B4FA RID: 46330
	[CompilerGenerated]
	private Action<IEffect> action_8;

	// Token: 0x0400B4FB RID: 46331
	[CompilerGenerated]
	private Action<EBodyPart, float, DamageInfo> action_9;

	// Token: 0x0400B4FC RID: 46332
	[CompilerGenerated]
	private Action<float> action_10;

	// Token: 0x0400B4FD RID: 46333
	[CompilerGenerated]
	private Action<float> action_11;

	// Token: 0x0400B4FE RID: 46334
	[CompilerGenerated]
	private Action<float> action_12;

	// Token: 0x0400B4FF RID: 46335
	[CompilerGenerated]
	private Action<float> action_13;

	// Token: 0x0400B500 RID: 46336
	[CompilerGenerated]
	private Action<IEffect> action_14;

	// Token: 0x0400B501 RID: 46337
	[CompilerGenerated]
	private Action<EBodyPart, float, DamageInfo> action_15;

	// Token: 0x0400B502 RID: 46338
	[CompilerGenerated]
	private Action<EBodyPart, EDamageType> action_16;

	// Token: 0x0400B503 RID: 46339
	[CompilerGenerated]
	private Action<EBodyPart, ValueStruct> action_17;

	// Token: 0x0400B504 RID: 46340
	[CompilerGenerated]
	private Action<EDamageType> action_18;

	// Token: 0x0400B505 RID: 46341
	[CompilerGenerated]
	private Action<Vector3, float, float> action_19;

	// Token: 0x0400B506 RID: 46342
	private HealthControllerClass.Regeneration regeneration_0;

	// Token: 0x0400B507 RID: 46343
	public static readonly List<Type> TreatableEffectTypes;

	// Token: 0x02002153 RID: 8531
	protected class Berserk : HealthControllerClass.GClass2417, IEffect, GInterface235, GInterface251
	{
	}

	// Token: 0x02002154 RID: 8532
	protected class HeavyBleeding : HealthControllerClass.Bleeding, GInterface227, GInterface228, IEffect, GInterface234, GInterface241, GInterface242
	{
		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600B099 RID: 45209 RVA: 0x00002050 File Offset: 0x00000250
		protected override GClass2420.GClass2423 BleedingSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002155 RID: 8533
	protected class LightBleeding : HealthControllerClass.Bleeding, GInterface227, GInterface228, IEffect, GInterface234, GInterface240, GInterface242
	{
		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600B09A RID: 45210 RVA: 0x00002050 File Offset: 0x00000250
		protected override GClass2420.GClass2423 BleedingSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002156 RID: 8534
	protected abstract class Bleeding : HealthControllerClass.GClass2417
	{
		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600B09B RID: 45211
		protected abstract GClass2420.GClass2423 BleedingSettings { get; }

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x0600B09C RID: 45212 RVA: 0x00002050 File Offset: 0x00000250
		public int HealExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x0600B09D RID: 45213 RVA: 0x00002050 File Offset: 0x00000250
		public float RemovePrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002157 RID: 8535
	protected class BodyTemperature : HealthControllerClass.GClass2417, IEffect, GInterface235, GInterface252
	{
	}

	// Token: 0x02002158 RID: 8536
	protected class ChronicStaminaFatigue : HealthControllerClass.GClass2417, IEffect, GInterface230, GInterface266
	{
	}

	// Token: 0x02002159 RID: 8537
	protected class Contusion : HealthControllerClass.GClass2417, IEffect, GInterface232, GInterface253
	{
	}

	// Token: 0x0200215A RID: 8538
	protected class DamageModifier : HealthControllerClass.GClass2417, IEffect, GInterface272
	{
	}

	// Token: 0x0200215B RID: 8539
	protected class Dehydration : HealthControllerClass.GClass2417, IEffect, GInterface234, GInterface244
	{
	}

	// Token: 0x0200215C RID: 8540
	protected class Disorientation : HealthControllerClass.GClass2417, IEffect, GInterface254
	{
	}

	// Token: 0x0200215D RID: 8541
	protected class Encumbered : HealthControllerClass.GClass2417, IEffect, GInterface230, GInterface264
	{
	}

	// Token: 0x0200215E RID: 8542
	protected class Endurance : HealthControllerClass.Effect<GStruct341>, IEffect, GInterface274
	{
		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x0600B09E RID: 45214 RVA: 0x00002050 File Offset: 0x00000250
		public bool Absolute
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Started()
		{
			throw null;
		}

		// Token: 0x0600B0A0 RID: 45216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Removed()
		{
			throw null;
		}
	}

	// Token: 0x0200215F RID: 8543
	protected class Exhaustion : HealthControllerClass.GClass2417, IEffect, GInterface234, GInterface245
	{
	}

	// Token: 0x02002160 RID: 8544
	protected class Existence : HealthControllerClass.GClass2417, IEffect, GInterface235, GInterface249
	{
	}

	// Token: 0x02002161 RID: 8545
	protected class Flash : HealthControllerClass.GClass2417, IEffect, GInterface255
	{
	}

	// Token: 0x02002162 RID: 8546
	protected class Fracture : HealthControllerClass.GClass2417, GInterface227, GInterface228, IEffect, GInterface234, GInterface243
	{
		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x0600B0A1 RID: 45217 RVA: 0x00002050 File Offset: 0x00000250
		public int HealExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0600B0A2 RID: 45218 RVA: 0x00002050 File Offset: 0x00000250
		public float RemovePrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002163 RID: 8547
	protected class FullHealthRegenerationEffect : HealthControllerClass.GClass2417, IEffect, GInterface234, GInterface239
	{
	}

	// Token: 0x02002164 RID: 8548
	protected sealed class HalloweenBuff : HealthControllerClass.GClass2417, IEffect, GInterface268
	{
	}

	// Token: 0x02002165 RID: 8549
	protected class HealthBoost : HealthControllerClass.GClass2417, IEffect, GInterface273
	{
		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x00002050 File Offset: 0x00000250
		public int HealExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002166 RID: 8550
	protected sealed class ImmunityPreventedNegativeEffect : HealthControllerClass.GClass2417, IEffect, GInterface230, GInterface267
	{
	}

	// Token: 0x02002167 RID: 8551
	protected class Intoxication : HealthControllerClass.GClass2417, GInterface227, GInterface228, IEffect, GInterface234, GInterface236, GInterface247
	{
		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x00002050 File Offset: 0x00000250
		public int HealExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x00002050 File Offset: 0x00000250
		public float RemovePrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002168 RID: 8552
	protected class LethalIntoxication : HealthControllerClass.GClass2417, GInterface227, GInterface228, IEffect, GInterface230, GInterface234, GInterface248
	{
		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x0600B0A6 RID: 45222 RVA: 0x00002050 File Offset: 0x00000250
		public override bool Critical
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x0600B0A7 RID: 45223 RVA: 0x00002050 File Offset: 0x00000250
		public int HealExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x0600B0A8 RID: 45224 RVA: 0x00002050 File Offset: 0x00000250
		public float RemovePrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002169 RID: 8553
	protected class LowEdgeHealth : HealthControllerClass.GClass2417, IEffect, GInterface256
	{
	}

	// Token: 0x0200216A RID: 8554
	protected class MedEffect : HealthControllerClass.Effect<GStruct342>, IEffect, GInterface231, GInterface232, GInterface235, GInterface275
	{
		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0AA RID: 45226 RVA: 0x00002050 File Offset: 0x00000250
		public Item MedItem
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

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x0600B0AB RID: 45227 RVA: 0x00002050 File Offset: 0x00000250
		public float Amount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x0600B0AC RID: 45228 RVA: 0x00002050 File Offset: 0x00000250
		public bool NoMove
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Added()
		{
			throw null;
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Started()
		{
			throw null;
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RegularUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Item i)
		{
			throw null;
		}

		// Token: 0x0400B508 RID: 46344
		[CompilerGenerated]
		private Item item_0;

		// Token: 0x0400B509 RID: 46345
		private HealthEffectsComponent healthEffectsComponent_0;

		// Token: 0x0400B50A RID: 46346
		private MedKitComponent medKitComponent_0;

		// Token: 0x0400B50B RID: 46347
		private FoodDrinkComponent foodDrinkComponent_0;

		// Token: 0x0400B50C RID: 46348
		private float float_7;
	}

	// Token: 0x0200216B RID: 8555
	protected class MisfireEffect : HealthControllerClass.GClass2417, IEffect, GInterface269
	{
	}

	// Token: 0x0200216C RID: 8556
	protected class MildMusclePain : HealthControllerClass.MusclePain, IEffect, GInterface234, GInterface237, GInterface277, GInterface278
	{
		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x0600B0B1 RID: 45233 RVA: 0x00002050 File Offset: 0x00000250
		protected override GClass2420.GClass2451 Settings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x0200216D RID: 8557
	protected class SevereMusclePain : HealthControllerClass.MusclePain, IEffect, GInterface234, GInterface237, GInterface277, GInterface279
	{
		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x0600B0B2 RID: 45234 RVA: 0x00002050 File Offset: 0x00000250
		protected override GClass2420.GClass2451 Settings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x0200216E RID: 8558
	protected abstract class MusclePain : HealthControllerClass.GClass2417
	{
		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x0600B0B3 RID: 45235
		protected abstract GClass2420.GClass2451 Settings { get; }

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x00002050 File Offset: 0x00000250
		public float GymEffectivity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x0600B0B5 RID: 45237 RVA: 0x00002050 File Offset: 0x00000250
		public float TraumaChance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x0200216F RID: 8559
	protected class OverEncumbered : HealthControllerClass.GClass2417, IEffect, GInterface230, GInterface265
	{
	}

	// Token: 0x02002170 RID: 8560
	protected class Pain : HealthControllerClass.GClass2417, GInterface227, IEffect, GInterface238, GInterface257
	{
		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x0600B0B6 RID: 45238 RVA: 0x00002050 File Offset: 0x00000250
		public int HealExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x00002050 File Offset: 0x00000250
		public Type[] HiddenByTypes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02002171 RID: 8561
	protected class PainKiller : HealthControllerClass.GClass2417, IEffect, GInterface231, GInterface233, GInterface235, GInterface258
	{
		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0B9 RID: 45241 RVA: 0x00002050 File Offset: 0x00000250
		public string ItemTemplateId
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

		// Token: 0x0600B0BA RID: 45242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWithSameOne(float strength)
		{
			throw null;
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StoreValues(string templateId, float duration)
		{
			throw null;
		}

		// Token: 0x0400B50D RID: 46349
		[CompilerGenerated]
		private string string_0;
	}

	// Token: 0x02002172 RID: 8562
	protected class PanicEffect : HealthControllerClass.GClass2417, IEffect, GInterface271
	{
	}

	// Token: 0x02002173 RID: 8563
	protected class RadExposure : HealthControllerClass.GClass2417, IEffect, GInterface234, GInterface246
	{
	}

	// Token: 0x02002174 RID: 8564
	protected class Regeneration : HealthControllerClass.GClass2417, IEffect, GInterface235, GInterface250
	{
		// Token: 0x0600B0BC RID: 45244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalculateRates()
		{
			throw null;
		}

		// Token: 0x0600B0BD RID: 45245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetOverallHealthRegenTime()
		{
			throw null;
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceUpdate()
		{
			throw null;
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Started()
		{
			throw null;
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RegularUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1(EBodyPart bodyPart, float healthToHeal)
		{
			throw null;
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<ValueTuple<float, float>> method_2(EHealthFactorType healthFactor, EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_3(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(EBodyPart bodyPart, out float healthInfluence, out float hydrationInfluence, out float energyInfluence)
		{
			throw null;
		}

		// Token: 0x0400B50E RID: 46350
		private float float_7;

		// Token: 0x0400B50F RID: 46351
		private float float_8;

		// Token: 0x0400B510 RID: 46352
		private float float_9;

		// Token: 0x0400B511 RID: 46353
		private float float_10;

		// Token: 0x02002175 RID: 8565
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1905
		{
			// Token: 0x0600B0C5 RID: 45253 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2412<HealthControllerClass.GClass2417>.BodyPartState s)
			{
				throw null;
			}

			// Token: 0x0600B0C6 RID: 45254 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1( ValueTuple<float, float> influence)
			{
				throw null;
			}

			// Token: 0x0600B0C7 RID: 45255 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ValueTuple<float, float> method_2( ValueTuple<float, float> influence1,  ValueTuple<float, float> influence2)
			{
				throw null;
			}

			// Token: 0x0400B512 RID: 46354
			public static readonly HealthControllerClass.Regeneration.Class1905 class1905_0;

			// Token: 0x0400B513 RID: 46355
			public static Func<GClass2412<HealthControllerClass.GClass2417>.BodyPartState, bool> func_0;

			// Token: 0x0400B514 RID: 46356
			public static Func<ValueTuple<float, float>, bool> func_1;

			// Token: 0x0400B515 RID: 46357
			public static Func<ValueTuple<float, float>, ValueTuple<float, float>, ValueTuple<float, float>> func_2;
		}

		// Token: 0x02002176 RID: 8566
		[CompilerGenerated]
		private sealed class Class1906
		{
			// Token: 0x0600B0C8 RID: 45256 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0( ValueTuple<float, float> influence)
			{
				throw null;
			}

			// Token: 0x0400B516 RID: 46358
			public float shortestTime;
		}

		// Token: 0x02002177 RID: 8567
		[CompilerGenerated]
		private sealed class Class1907
		{
			// Token: 0x0600B0C9 RID: 45257 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(HealthControllerClass.GClass2417 e)
			{
				throw null;
			}

			// Token: 0x0400B517 RID: 46359
			public EBodyPart bodyPart;
		}

		// Token: 0x02002178 RID: 8568
		[CompilerGenerated]
		private sealed class Class1908
		{
			// Token: 0x0600B0CA RID: 45258 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(HealthControllerClass.GClass2417 e)
			{
				throw null;
			}

			// Token: 0x0400B518 RID: 46360
			public EBodyPart bodyPart;
		}
	}

	// Token: 0x02002179 RID: 8569
	protected class SandingScreen : HealthControllerClass.GClass2417, IEffect, GInterface259
	{
	}

	// Token: 0x0200217A RID: 8570
	protected class ScavRegeneration : HealthControllerClass.GClass2417, IEffect, GInterface235, GInterface250
	{
	}

	// Token: 0x0200217B RID: 8571
	protected class StaminaZero : HealthControllerClass.GClass2417, IEffect, GInterface231, GInterface270
	{
		// Token: 0x0600B0CB RID: 45259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Started()
		{
			throw null;
		}
	}

	// Token: 0x0200217C RID: 8572
	protected class Stimulator : HealthControllerClass.Effect<GStruct343>, IEffect, GInterface231, GInterface233, GInterface235, GInterface276
	{
		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x0600B0CC RID: 45260 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0CD RID: 45261 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface226[] ActiveBuffs
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

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x0600B0CE RID: 45262 RVA: 0x00002050 File Offset: 0x00000250
		public override GClass2457[] DisplayableVariations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Added()
		{
			throw null;
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AddWholeTime(float deltaTime)
		{
			throw null;
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x00002050 File Offset: 0x00000250
		public string ItemTemplateId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWithSameOne(float strength = 1f)
		{
			throw null;
		}

		// Token: 0x0400B519 RID: 46361
		[CompilerGenerated]
		private GInterface226[] ginterface226_0;

		// Token: 0x0200217D RID: 8573
		private sealed class Class1909 : GInterface225, GInterface226
		{
			// Token: 0x17001D7D RID: 7549
			// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x00002050 File Offset: 0x00000250
			public bool Active
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D7E RID: 7550
			// (get) Token: 0x0600B0D4 RID: 45268 RVA: 0x00002050 File Offset: 0x00000250
			public float Value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D7F RID: 7551
			// (get) Token: 0x0600B0D5 RID: 45269 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B0D6 RID: 45270 RVA: 0x00002050 File Offset: 0x00000250
			public GClass2420.GClass2445.GClass2446 Settings
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

			// Token: 0x17001D80 RID: 7552
			// (get) Token: 0x0600B0D7 RID: 45271 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B0D8 RID: 45272 RVA: 0x00002050 File Offset: 0x00000250
			public EBodyPart BodyPart
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

			// Token: 0x17001D81 RID: 7553
			// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B0DA RID: 45274 RVA: 0x00002050 File Offset: 0x00000250
			public float WholeTime
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

			// Token: 0x0600B0DB RID: 45275 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void IncreaseBySameBuff(float curStimulatorTime, float strength, SkillManager skillManager)
			{
				throw null;
			}

			// Token: 0x17001D82 RID: 7554
			// (get) Token: 0x0600B0DC RID: 45276 RVA: 0x00002050 File Offset: 0x00000250
			public Type BuffType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D83 RID: 7555
			// (get) Token: 0x0600B0DD RID: 45277 RVA: 0x00002050 File Offset: 0x00000250
			public string BuffName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400B51A RID: 46362
			[CompilerGenerated]
			private GClass2420.GClass2445.GClass2446 gclass2446_0;

			// Token: 0x0400B51B RID: 46363
			[CompilerGenerated]
			private EBodyPart ebodyPart_0;

			// Token: 0x0400B51C RID: 46364
			[CompilerGenerated]
			private float float_0;
		}
	}

	// Token: 0x0200217E RID: 8574
	protected class Stun : HealthControllerClass.GClass2417, IEffect, GInterface260
	{
	}

	// Token: 0x0200217F RID: 8575
	protected class Tremor : HealthControllerClass.GClass2417, IEffect, GInterface232, GInterface261
	{
	}

	// Token: 0x02002180 RID: 8576
	protected class TunnelVision : HealthControllerClass.GClass2417, IEffect, GInterface263
	{
	}

	// Token: 0x02002181 RID: 8577
	protected class Wound : HealthControllerClass.GClass2417, IEffect, GInterface262
	{
	}

	// Token: 0x02002182 RID: 8578
	protected abstract class Effect<TStore> : HealthControllerClass.GClass2417 where TStore : struct
	{
		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x0600B0DE RID: 45278 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0DF RID: 45279 RVA: 0x00002050 File Offset: 0x00000250
		protected override object StoreObj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400B51D RID: 46365
		protected TStore _store;
	}

	// Token: 0x02002183 RID: 8579
	public abstract class GClass2417 : IEffect
	{
		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x0600B0E0 RID: 45280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0E1 RID: 45281 RVA: 0x00002050 File Offset: 0x00000250
		public Type Type
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

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x0600B0E2 RID: 45282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0E3 RID: 45283 RVA: 0x00002050 File Offset: 0x00000250
		public EBodyPart BodyPart
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

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x0600B0E4 RID: 45284 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0E5 RID: 45285 RVA: 0x00002050 File Offset: 0x00000250
		public EEffectState State
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

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x0600B0E6 RID: 45286 RVA: 0x00002050 File Offset: 0x00000250
		public float CurStateTimeLeft
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600B0E7 RID: 45287 RVA: 0x00002050 File Offset: 0x00000250
		public float WorkStateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x0600B0E8 RID: 45288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0E9 RID: 45289 RVA: 0x00002050 File Offset: 0x00000250
		public float WholeTime
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

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentStrength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x0600B0EB RID: 45291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0EC RID: 45292 RVA: 0x00002050 File Offset: 0x00000250
		public float Strength
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

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x0600B0ED RID: 45293 RVA: 0x00002050 File Offset: 0x00000250
		public float TimeLeft
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x0600B0EE RID: 45294 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool Critical
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600B0EF RID: 45295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0F0 RID: 45296 RVA: 0x00002050 File Offset: 0x00000250
		public bool WasPaused
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

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x0600B0F1 RID: 45297 RVA: 0x00002050 File Offset: 0x00000250
		public virtual GClass2457[] DisplayableVariations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x0600B0F2 RID: 45298 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float OverallDuration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0F4 RID: 45300 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
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

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600B0F5 RID: 45301 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0F6 RID: 45302 RVA: 0x00002050 File Offset: 0x00000250
		private HealthControllerClass GClass2415_0
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

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B0F8 RID: 45304 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual object StoreObj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x0600B0F9 RID: 45305 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool Existing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x0600B0FA RID: 45306 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool Active
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x0600B0FB RID: 45307 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool Residual
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Added()
		{
			throw null;
		}

		// Token: 0x0600B0FD RID: 45309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Started()
		{
			throw null;
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RegularUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Removed()
		{
			throw null;
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TEffect Create<TEffect>(HealthControllerClass health, EBodyPart bodyPart, Profile.GClass1753.GClass1754 restoreInfo, int? updateTime) where TEffect : HealthControllerClass.GClass2417, new()
		{
			throw null;
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HealthControllerClass.GClass2417 Create(HealthControllerClass health, string effectType, EBodyPart bodyPart, Profile.GClass1753.GClass1754 restoreInfo, int? updateTime)
		{
			throw null;
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(HealthControllerClass.GClass2417 effect, HealthControllerClass health, EBodyPart bodyPart, Profile.GClass1753.GClass1754 restoreInfo, int? updateTime)
		{
			throw null;
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Propagate()
		{
			throw null;
		}

		// Token: 0x0600B105 RID: 45317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddWholeTime(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B106 RID: 45318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove()
		{
			throw null;
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void method_0(float health, float energy, float hydration, float temperature)
		{
			throw null;
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Profile.GClass1753.GClass1754 Store()
		{
			throw null;
		}

		// Token: 0x0400B51E RID: 46366
		[CompilerGenerated]
		private Type type_0;

		// Token: 0x0400B51F RID: 46367
		[CompilerGenerated]
		private EBodyPart ebodyPart_0;

		// Token: 0x0400B520 RID: 46368
		[CompilerGenerated]
		private EEffectState eeffectState_0;

		// Token: 0x0400B521 RID: 46369
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0400B522 RID: 46370
		[CompilerGenerated]
		private float float_1;

		// Token: 0x0400B523 RID: 46371
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400B524 RID: 46372
		private float float_2;

		// Token: 0x0400B525 RID: 46373
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400B526 RID: 46374
		[CompilerGenerated]
		private HealthControllerClass gclass2415_0;

		// Token: 0x0400B527 RID: 46375
		private float float_3;

		// Token: 0x0400B528 RID: 46376
		private float float_4;

		// Token: 0x0400B529 RID: 46377
		private float float_5;

		// Token: 0x0400B52A RID: 46378
		private float float_6;
	}

	// Token: 0x02002184 RID: 8580
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1910
	{
		// Token: 0x0600B109 RID: 45321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EBodyPart method_1(KeyValuePair<EBodyPart, float> kp)
		{
			throw null;
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(KeyValuePair<EBodyPart, float> kp)
		{
			throw null;
		}

		// Token: 0x0400B52B RID: 46379
		public static readonly HealthControllerClass.Class1910 class1910_0;

		// Token: 0x0400B52C RID: 46380
		public static Func<EBodyPart, float> func_0;

		// Token: 0x0400B52D RID: 46381
		public static Func<KeyValuePair<EBodyPart, float>, EBodyPart> func_1;

		// Token: 0x0400B52E RID: 46382
		public static Func<KeyValuePair<EBodyPart, float>, float> func_2;
	}
}
