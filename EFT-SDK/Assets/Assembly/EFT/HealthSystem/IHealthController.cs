using System;
using System.Collections.Generic;
using Comfort.Common;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.HealthSystem
{
	// Token: 0x020021F3 RID: 8691
	public interface IHealthController
	{
		// Token: 0x1400027B RID: 635
		// (add) Token: 0x0600B169 RID: 45417
		// (remove) Token: 0x0600B16A RID: 45418
		event Action<IEffect> EffectAddedEvent;

		// Token: 0x1400027C RID: 636
		// (add) Token: 0x0600B16B RID: 45419
		// (remove) Token: 0x0600B16C RID: 45420
		event Action<IEffect> EffectStartedEvent;

		// Token: 0x1400027D RID: 637
		// (add) Token: 0x0600B16D RID: 45421
		// (remove) Token: 0x0600B16E RID: 45422
		event Action<IEffect> EffectUpdatedEvent;

		// Token: 0x1400027E RID: 638
		// (add) Token: 0x0600B16F RID: 45423
		// (remove) Token: 0x0600B170 RID: 45424
		event Action<IEffect> EffectResidualEvent;

		// Token: 0x1400027F RID: 639
		// (add) Token: 0x0600B171 RID: 45425
		// (remove) Token: 0x0600B172 RID: 45426
		event Action<IEffect> EffectRemovedEvent;

		// Token: 0x14000280 RID: 640
		// (add) Token: 0x0600B173 RID: 45427
		// (remove) Token: 0x0600B174 RID: 45428
		event Action<IEffect> EffectStatusUpdateEvent;

		// Token: 0x14000281 RID: 641
		// (add) Token: 0x0600B175 RID: 45429
		// (remove) Token: 0x0600B176 RID: 45430
		event Action<EBodyPart, float, DamageInfo> ApplyDamageEvent;

		// Token: 0x14000282 RID: 642
		// (add) Token: 0x0600B177 RID: 45431
		// (remove) Token: 0x0600B178 RID: 45432
		event Action<EBodyPart, float, DamageInfo> HealthChangedEvent;

		// Token: 0x14000283 RID: 643
		// (add) Token: 0x0600B179 RID: 45433
		// (remove) Token: 0x0600B17A RID: 45434
		event Action<float> EnergyChangedEvent;

		// Token: 0x14000284 RID: 644
		// (add) Token: 0x0600B17B RID: 45435
		// (remove) Token: 0x0600B17C RID: 45436
		event Action<float> HydrationChangedEvent;

		// Token: 0x14000285 RID: 645
		// (add) Token: 0x0600B17D RID: 45437
		// (remove) Token: 0x0600B17E RID: 45438
		event Action<float> TemperatureChangedEvent;

		// Token: 0x14000286 RID: 646
		// (add) Token: 0x0600B17F RID: 45439
		// (remove) Token: 0x0600B180 RID: 45440
		event Action<EBodyPart, EDamageType> BodyPartDestroyedEvent;

		// Token: 0x14000287 RID: 647
		// (add) Token: 0x0600B181 RID: 45441
		// (remove) Token: 0x0600B182 RID: 45442
		event Action<EBodyPart, ValueStruct> BodyPartRestoredEvent;

		// Token: 0x14000288 RID: 648
		// (add) Token: 0x0600B183 RID: 45443
		// (remove) Token: 0x0600B184 RID: 45444
		event Action<EDamageType> DiedEvent;

		// Token: 0x14000289 RID: 649
		// (add) Token: 0x0600B185 RID: 45445
		// (remove) Token: 0x0600B186 RID: 45446
		event Action<IEffect> HealerDoneEvent;

		// Token: 0x1400028A RID: 650
		// (add) Token: 0x0600B187 RID: 45447
		// (remove) Token: 0x0600B188 RID: 45448
		event Action<Vector3, float, float> BurnEyesEvent;

		// Token: 0x1400028B RID: 651
		// (add) Token: 0x0600B189 RID: 45449
		// (remove) Token: 0x0600B18A RID: 45450
		event Action<GInterface226> StimulatorBuffEvent;

		// Token: 0x1400028C RID: 652
		// (add) Token: 0x0600B18B RID: 45451
		// (remove) Token: 0x0600B18C RID: 45452
		event Action<GInterface226> StimulatorBuffActivationEvent;

		// Token: 0x17001DC5 RID: 7621
		// (set) Token: 0x0600B18D RID: 45453
		float FallSafeHeight { set; }

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x0600B18E RID: 45454
		bool IsAlive { get; }

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x0600B18F RID: 45455
		ValueStruct Energy { get; }

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x0600B190 RID: 45456
		ValueStruct Hydration { get; }

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x0600B191 RID: 45457
		ValueStruct Temperature { get; }

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x0600B192 RID: 45458
		ValueStruct Poison { get; }

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x0600B193 RID: 45459
		float HealthRate { get; }

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x0600B194 RID: 45460
		float EnergyRate { get; }

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x0600B195 RID: 45461
		float HydrationRate { get; }

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x0600B196 RID: 45462
		float TemperatureRate { get; }

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x0600B197 RID: 45463
		float DamageCoeff { get; }

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x0600B198 RID: 45464
		float StaminaCoeff { get; }

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x0600B199 RID: 45465
		int UpdateTime { get; }

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x0600B19A RID: 45466
		[CanBeNull]
		Player Player { get; }

		// Token: 0x0600B19B RID: 45467
		ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false);

		// Token: 0x0600B19C RID: 45468
		bool IsBodyPartBroken(EBodyPart bodyPart);

		// Token: 0x0600B19D RID: 45469
		bool IsBodyPartDestroyed(EBodyPart bodyPart);

		// Token: 0x0600B19E RID: 45470
		void GetBodyPartsInCriticalCondition(float threshold, out int all, out int vital);

		// Token: 0x0600B19F RID: 45471
		void SetEncumbered(bool encumbered);

		// Token: 0x0600B1A0 RID: 45472
		void SetOverEncumbered(bool encumbered);

		// Token: 0x0600B1A1 RID: 45473
		void AddFatigue();

		// Token: 0x0600B1A2 RID: 45474
		void AddImmunityNotificationEffect();

		// Token: 0x0600B1A3 RID: 45475
		[CanBeNull]
		TEffect FindExistingEffect<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect;

		// Token: 0x0600B1A4 RID: 45476
		[CanBeNull]
		TEffect FindActiveEffect<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect;

		// Token: 0x0600B1A5 RID: 45477
		IEnumerable<TEffect> FindActiveEffects<TEffect>(EBodyPart bodyPart = EBodyPart.Common) where TEffect : IEffect;

		// Token: 0x0600B1A6 RID: 45478
		IEnumerable<IEffect> GetAllActiveEffects(EBodyPart bodyPart = EBodyPart.Common);

		// Token: 0x0600B1A7 RID: 45479
		IEnumerable<IEffect> GetAllEffects(EBodyPart bodyPart = EBodyPart.Common);

		// Token: 0x0600B1A8 RID: 45480
		IEnumerable<IEffect> GetAllResidualEffects(EBodyPart bodyPart = EBodyPart.Common);

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x0600B1A9 RID: 45481
		HealthEffects BodyPartEffects { get; }

		// Token: 0x0600B1AA RID: 45482
		bool IsItemForHealing(Item item);

		// Token: 0x0600B1AB RID: 45483
		IResult HasPartsToApply(Item item);

		// Token: 0x0600B1AC RID: 45484
		bool CanApplyItem(Item item, EBodyPart bodyPart);

		// Token: 0x0600B1AD RID: 45485
		bool ApplyItem(Item item, EBodyPart bodyPart, float? amount = null);

		// Token: 0x0600B1AE RID: 45486
		void CancelApplyingItem();

		// Token: 0x0600B1AF RID: 45487
		void ManualUpdate(float deltaTime);

		// Token: 0x0600B1B0 RID: 45488
		void PropagateAllEffects();

		// Token: 0x0600B1B1 RID: 45489
		string[] ActiveBuffsNames();

		// Token: 0x0600B1B2 RID: 45490
		void PauseAllEffects();

		// Token: 0x0600B1B3 RID: 45491
		void UnpauseAllEffects();

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x0600B1B4 RID: 45492
		float CarryingWeightAbsoluteModifier { get; }

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x0600B1B5 RID: 45493
		float CarryingWeightRelativeModifier { get; }

		// Token: 0x0600B1B6 RID: 45494
		void DisableMetabolism();
	}
}
