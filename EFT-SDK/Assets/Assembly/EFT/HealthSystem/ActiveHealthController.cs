using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.HealthSystem
{
	// Token: 0x020020DB RID: 8411
	public abstract class ActiveHealthController : GClass2412<ActiveHealthController.GClass2411>
	{
		// Token: 0x14000232 RID: 562
		// (add) Token: 0x0600AD65 RID: 44389 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD66 RID: 44390 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000233 RID: 563
		// (add) Token: 0x0600AD67 RID: 44391 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD68 RID: 44392 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000234 RID: 564
		// (add) Token: 0x0600AD69 RID: 44393 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD6A RID: 44394 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000235 RID: 565
		// (add) Token: 0x0600AD6B RID: 44395 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD6C RID: 44396 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000236 RID: 566
		// (add) Token: 0x0600AD6D RID: 44397 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD6E RID: 44398 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000237 RID: 567
		// (add) Token: 0x0600AD6F RID: 44399 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD70 RID: 44400 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000238 RID: 568
		// (add) Token: 0x0600AD71 RID: 44401 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD72 RID: 44402 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000239 RID: 569
		// (add) Token: 0x0600AD73 RID: 44403 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD74 RID: 44404 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x1400023A RID: 570
		// (add) Token: 0x0600AD75 RID: 44405 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD76 RID: 44406 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x1400023B RID: 571
		// (add) Token: 0x0600AD77 RID: 44407 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD78 RID: 44408 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x1400023C RID: 572
		// (add) Token: 0x0600AD79 RID: 44409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD7A RID: 44410 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x1400023D RID: 573
		// (add) Token: 0x0600AD7B RID: 44411 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD7C RID: 44412 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x1400023E RID: 574
		// (add) Token: 0x0600AD7D RID: 44413 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD7E RID: 44414 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x1400023F RID: 575
		// (add) Token: 0x0600AD7F RID: 44415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD80 RID: 44416 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000240 RID: 576
		// (add) Token: 0x0600AD81 RID: 44417 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD82 RID: 44418 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000241 RID: 577
		// (add) Token: 0x0600AD83 RID: 44419 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD84 RID: 44420 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000242 RID: 578
		// (add) Token: 0x0600AD85 RID: 44421 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD86 RID: 44422 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000243 RID: 579
		// (add) Token: 0x0600AD87 RID: 44423 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AD88 RID: 44424 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float, float> HandleFallEvent
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

		// Token: 0x17001C98 RID: 7320
		// (set) Token: 0x0600AD89 RID: 44425 RVA: 0x00002050 File Offset: 0x00000250
		public override float FallSafeHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600AD8A RID: 44426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEncumbered(bool encumbered)
		{
			throw null;
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetOverEncumbered(bool encumbered)
		{
			throw null;
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private T method_12<T>(EBodyPart bodyPart, Item effectSourceItem, float? strength = null, float? delay = null, float? duration = null, float? residueTime = null, Action<T> initCallback = null) where T : ActiveHealthController.GClass2411, GInterface233, new()
		{
			throw null;
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TEffect AddEffect<TEffect>(EBodyPart bodyPart, float? delayTime = null, float? workTime = null, float? residueTime = null, float? strength = null, Action<TEffect> initCallback = null) where TEffect : ActiveHealthController.GClass2411, new()
		{
			throw null;
		}

		// Token: 0x0600AD8E RID: 44430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PauseAllEffects()
		{
			throw null;
		}

		// Token: 0x0600AD8F RID: 44431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TryApplyStartupBuff()
		{
			throw null;
		}

		// Token: 0x0600AD90 RID: 44432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoExternalBuff(string buffName)
		{
			throw null;
		}

		// Token: 0x0600AD91 RID: 44433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoPainKiller()
		{
			throw null;
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoScavRegeneration(float regenerationPerMin)
		{
			throw null;
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestoreFullHealth()
		{
			throw null;
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private T method_13<T>(EBodyPart bodyPart) where T : ActiveHealthController.GClass2411
		{
			throw null;
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private T method_14<T>(EBodyPart bodyPart) where T : ActiveHealthController.GClass2411
		{
			throw null;
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveNegativeEffects(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveMedEffect()
		{
			throw null;
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(EBodyPart bodyPart, Func<ActiveHealthController.GClass2411, bool> predicate)
		{
			throw null;
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDamageCoeff(float value)
		{
			throw null;
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStaminaCoeff(float value)
		{
			throw null;
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddDamageMultiplier(float value)
		{
			throw null;
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryApplySideEffects(DamageInfo damage, EBodyPart bodyPart, out SideEffectComponent sideEffectComponent)
		{
			throw null;
		}

		// Token: 0x14000244 RID: 580
		// (add) Token: 0x0600AD9F RID: 44447 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600ADA0 RID: 44448 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Player, IPlayer> OnApplyDamageByPlayer
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

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_18(EStimulatorBuffType buffType)
		{
			throw null;
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_19()
		{
			throw null;
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string[] ActiveBuffsNames()
		{
			throw null;
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyBodyPart(EBodyPart bodyPart, EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20(EBodyPart bodyPart, EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Heal(EBodyPart bodyPart, float value)
		{
			throw null;
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RestoreBodyPart(EBodyPart bodyPart, float healthPenalty)
		{
			throw null;
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool FullRestoreBodyPart(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Kill(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeHealth(EBodyPart bodyPart, float value, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeEnergy(float value)
		{
			throw null;
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeHydration(float value)
		{
			throw null;
		}

		// Token: 0x0600ADAE RID: 44462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(float value)
		{
			throw null;
		}

		// Token: 0x0600ADAF RID: 44463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22(float value)
		{
			throw null;
		}

		// Token: 0x0600ADB0 RID: 44464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoEventEffect()
		{
			throw null;
		}

		// Token: 0x0600ADB1 RID: 44465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddMisfireEffect(float? workTime = null, bool reapply = true)
		{
			throw null;
		}

		// Token: 0x0600ADB2 RID: 44466 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStaminaZeroffect(float? workTime = null)
		{
			throw null;
		}

		// Token: 0x0600ADB3 RID: 44467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveMisfireEffect()
		{
			throw null;
		}

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(EBodyPart bodyPart, float delayTime, float workTime, float residueTime, float? strength = null)
		{
			throw null;
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void DoBleed<TBleedType>(EBodyPart bodyPart) where TBleedType : ActiveHealthController.Bleeding, new()
		{
			throw null;
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActiveHealthController.GClass2411 DoIntoxication()
		{
			throw null;
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActiveHealthController.GClass2411 DoLethalIntoxication(float delay, float duration)
		{
			throw null;
		}

		// Token: 0x0600ADB8 RID: 44472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoRadExposure()
		{
			throw null;
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoStun(float maxTime, float normalizedStrength)
		{
			throw null;
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoPermanentHealthBoost(float bodyPartHpPerSecond)
		{
			throw null;
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoFracture(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AddFatigue()
		{
			throw null;
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AddImmunityNotificationEffect()
		{
			throw null;
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoSandingScreen(float applyTime)
		{
			throw null;
		}

		// Token: 0x0600ADBF RID: 44479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoDisorientation(float applyTime)
		{
			throw null;
		}

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoContusion(float applyTime, float strength)
		{
			throw null;
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BluntContusion(EBodyPart bodyPartType, float absorbed)
		{
			throw null;
		}

		// Token: 0x0600ADC2 RID: 44482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoShootOnArmor(float damage)
		{
			throw null;
		}

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoWoundRelapse(float relapseValue, EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoBurnEyes(Vector3 position, float distanceStrength, float normalTime, float maxTime)
		{
			throw null;
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEffect DoMedEffect(Item item, EBodyPart bodyPart, float? amount = null)
		{
			throw null;
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFall(float height)
		{
			throw null;
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Profile.GClass1753 Store(Profile.GClass1753 health = null)
		{
			throw null;
		}

		// Token: 0x0600ADC8 RID: 44488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ManualEffectUpdate(ActiveHealthController.GClass2411 effect, float deltaTime)
		{
			throw null;
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x0600ADCA RID: 44490 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool _sendNetworkSyncPackets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SendNetworkSyncPacket(GStruct345 packet)
		{
			throw null;
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24(ActiveHealthController.GClass2411 effect)
		{
			throw null;
		}

		// Token: 0x0600ADCD RID: 44493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25(ActiveHealthController.GClass2411 effect)
		{
			throw null;
		}

		// Token: 0x0600ADCE RID: 44494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(ActiveHealthController.GClass2411 effect)
		{
			throw null;
		}

		// Token: 0x0600ADCF RID: 44495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27(ActiveHealthController.GClass2411 effect)
		{
			throw null;
		}

		// Token: 0x0600ADD0 RID: 44496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_28(ActiveHealthController.GClass2411 effect)
		{
			throw null;
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_29(ActiveHealthController.GClass2411 effect, float resource)
		{
			throw null;
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30(ActiveHealthController.GClass2411 effect, int buffIndex, bool buffActivate, float buffValue, float buffDuration, float buffDelay)
		{
			throw null;
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_33()
		{
			throw null;
		}

		// Token: 0x0600ADD6 RID: 44502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x0600ADD7 RID: 44503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_35()
		{
			throw null;
		}

		// Token: 0x0600ADD8 RID: 44504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_36()
		{
			throw null;
		}

		// Token: 0x0600ADD9 RID: 44505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_37()
		{
			throw null;
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_38()
		{
			throw null;
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_39(EBodyPart bodyPart, float damage, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_40(EBodyPart bodyPart, EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600ADDD RID: 44509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_41()
		{
			throw null;
		}

		// Token: 0x0600ADDE RID: 44510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_42(ActiveHealthController.GClass2411 effect)
		{
			throw null;
		}

		// Token: 0x0600ADDF RID: 44511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_43(Vector3 position, float distanceStrength, float normalTime)
		{
			throw null;
		}

		// Token: 0x0600ADE0 RID: 44512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] SerializeState()
		{
			throw null;
		}

		// Token: 0x0400B404 RID: 46084
		private ActiveHealthController.GClass2411 _encumberedEffect;

		// Token: 0x0400B405 RID: 46085
		private ActiveHealthController.GClass2411 _overEncumberedEffect;

		// Token: 0x0400B406 RID: 46086
		private float _fallSafeHeight;

		// Token: 0x0400B407 RID: 46087
		private int _effectIdCounter;

		// Token: 0x0400B409 RID: 46089
		public static readonly Type[] PAIN_HIDDEN_BY;

		// Token: 0x020020DC RID: 8412
		protected abstract class Effect<TStore> : ActiveHealthController.GClass2411 where TStore : struct
		{
			// Token: 0x17001C9A RID: 7322
			// (get) Token: 0x0600ADE1 RID: 44513 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADE2 RID: 44514 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x0600ADE3 RID: 44515 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void NetworkSync(out TStore data)
			{
				throw null;
			}

			// Token: 0x0400B40A RID: 46090
			protected TStore _store;
		}

		// Token: 0x020020DD RID: 8413
		public abstract class GClass2411 : IEffect
		{
			// Token: 0x17001C9B RID: 7323
			// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADE5 RID: 44517 RVA: 0x00002050 File Offset: 0x00000250
			public int Id
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

			// Token: 0x17001C9C RID: 7324
			// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADE7 RID: 44519 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001C9D RID: 7325
			// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADE9 RID: 44521 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001C9E RID: 7326
			// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADEB RID: 44523 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001C9F RID: 7327
			// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADED RID: 44525 RVA: 0x00002050 File Offset: 0x00000250
			public float CurrentStrength
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

			// Token: 0x17001CA0 RID: 7328
			// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADEF RID: 44527 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CA1 RID: 7329
			// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x00002050 File Offset: 0x00000250
			public float TimeLeft
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA2 RID: 7330
			// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x00002050 File Offset: 0x00000250
			public virtual GClass2457[] DisplayableVariations
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA3 RID: 7331
			// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x00002050 File Offset: 0x00000250
			public virtual float OverallDuration
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA4 RID: 7332
			// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool Existing
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA5 RID: 7333
			// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool Active
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA6 RID: 7334
			// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool Residual
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA7 RID: 7335
			// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool Critical
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA8 RID: 7336
			// (get) Token: 0x0600ADF7 RID: 44535 RVA: 0x00002050 File Offset: 0x00000250
			public float CurStateTimeLeft
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CA9 RID: 7337
			// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADF9 RID: 44537 RVA: 0x00002050 File Offset: 0x00000250
			public float DelayTime
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

			// Token: 0x17001CAA RID: 7338
			// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x00002050 File Offset: 0x00000250
			public float BuildUpTime
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

			// Token: 0x17001CAB RID: 7339
			// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADFD RID: 44541 RVA: 0x00002050 File Offset: 0x00000250
			public float WorkStateTime
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

			// Token: 0x17001CAC RID: 7340
			// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ADFF RID: 44543 RVA: 0x00002050 File Offset: 0x00000250
			public float ResidueStateTime
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

			// Token: 0x17001CAD RID: 7341
			// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE01 RID: 44545 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CAE RID: 7342
			// (get) Token: 0x0600AE02 RID: 44546 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE03 RID: 44547 RVA: 0x00002050 File Offset: 0x00000250
			public bool ForceRemoved
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

			// Token: 0x17001CAF RID: 7343
			// (get) Token: 0x0600AE04 RID: 44548 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE05 RID: 44549 RVA: 0x00002050 File Offset: 0x00000250
			private float Single_0
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

			// Token: 0x17001CB0 RID: 7344
			// (get) Token: 0x0600AE06 RID: 44550 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE07 RID: 44551 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CB1 RID: 7345
			// (get) Token: 0x0600AE08 RID: 44552 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE09 RID: 44553 RVA: 0x00002050 File Offset: 0x00000250
			public ActiveHealthController HealthController
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

			// Token: 0x17001CB2 RID: 7346
			// (get) Token: 0x0600AE0A RID: 44554 RVA: 0x00002050 File Offset: 0x00000250
			public float StateTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CB3 RID: 7347
			// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE0C RID: 44556 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CB4 RID: 7348
			// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x00002050 File Offset: 0x00000250
			protected static GClass2420 GClass2420_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CB5 RID: 7349
			// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CB6 RID: 7350
			// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual float DefaultBuildUpTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CB7 RID: 7351
			// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual float DefaultWorkTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CB8 RID: 7352
			// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CB9 RID: 7353
			// (get) Token: 0x0600AE12 RID: 44562 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AE13 RID: 44563 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x0600AE14 RID: 44564 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Serialize(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x0600AE15 RID: 44565 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Restored()
			{
				throw null;
			}

			// Token: 0x0600AE16 RID: 44566 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Added()
			{
				throw null;
			}

			// Token: 0x0600AE17 RID: 44567 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Started()
			{
				throw null;
			}

			// Token: 0x0600AE18 RID: 44568 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Residue()
			{
				throw null;
			}

			// Token: 0x0600AE19 RID: 44569 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE1A RID: 44570 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void ResidualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE1B RID: 44571 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Removed()
			{
				throw null;
			}

			// Token: 0x0600AE1C RID: 44572 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static TEffect Create<TEffect>(ActiveHealthController health, EBodyPart bodyPart, float? delayTime, float? workTime, float? residueTime, float? strength, int? updateTime, Action<ActiveHealthController.GClass2411> initCallback) where TEffect : ActiveHealthController.GClass2411, new()
			{
				throw null;
			}

			// Token: 0x0600AE1D RID: 44573 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static ActiveHealthController.GClass2411 Create(ActiveHealthController health, string effectType, EBodyPart bodyPart, Profile.GClass1753.GClass1754 restoreInfo)
			{
				throw null;
			}

			// Token: 0x0600AE1E RID: 44574 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Init(ActiveHealthController health, EBodyPart bodyPart, float? delayTime, float? workTime, float? residueTime, float strength, int? updateTime)
			{
				throw null;
			}

			// Token: 0x0600AE1F RID: 44575 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetEffectInfo(int id, IHealthController hController, Type type, EBodyPart bodyPart, float strength, float currentStrength, float delayTime, float stateTime, float workStateTime, float buildUpTime, float residueStateTime, int updateTime, EEffectState state)
			{
				throw null;
			}

			// Token: 0x0600AE20 RID: 44576 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void PauseEffect()
			{
				throw null;
			}

			// Token: 0x0600AE21 RID: 44577 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ManualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE22 RID: 44578 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Propagate()
			{
				throw null;
			}

			// Token: 0x0600AE23 RID: 44579 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void AddWholeTime(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE24 RID: 44580 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ForceResidue()
			{
				throw null;
			}

			// Token: 0x0600AE25 RID: 44581 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ForceRemove()
			{
				throw null;
			}

			// Token: 0x0600AE26 RID: 44582 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void UnPauseEffect()
			{
				throw null;
			}

			// Token: 0x0600AE27 RID: 44583 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x0600AE28 RID: 44584 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddWorkTime(float? time, bool reset)
			{
				throw null;
			}

			// Token: 0x0600AE29 RID: 44585 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetResidueTime(float time)
			{
				throw null;
			}

			// Token: 0x0600AE2A RID: 44586 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetStrength(float strength)
			{
				throw null;
			}

			// Token: 0x0600AE2B RID: 44587 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_1<T>(EBodyPart bodyPart, float? delayTime = null, float? workTime = null, float? residueTime = null, float? strength = null) where T : ActiveHealthController.GClass2411, new()
			{
				throw null;
			}

			// Token: 0x0600AE2C RID: 44588 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x0600AE2D RID: 44589 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature)
			{
				throw null;
			}

			// Token: 0x0600AE2E RID: 44590 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void CalculateCurrentStrength(float deltaTime = 0f)
			{
				throw null;
			}

			// Token: 0x0600AE2F RID: 44591 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual Profile.GClass1753.GClass1754 Store()
			{
				throw null;
			}

			// Token: 0x0600AE30 RID: 44592 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SerializeState(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x0600AE31 RID: 44593 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3()
			{
				throw null;
			}

			// Token: 0x0600AE32 RID: 44594 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4()
			{
				throw null;
			}

			// Token: 0x0400B40B RID: 46091
			[CompilerGenerated]
			private int int_0;

			// Token: 0x0400B40C RID: 46092
			[CompilerGenerated]
			private Type type_0;

			// Token: 0x0400B40D RID: 46093
			[CompilerGenerated]
			private EBodyPart ebodyPart_0;

			// Token: 0x0400B40E RID: 46094
			[CompilerGenerated]
			private EEffectState eeffectState_0;

			// Token: 0x0400B40F RID: 46095
			[CompilerGenerated]
			private float float_0;

			// Token: 0x0400B410 RID: 46096
			[CompilerGenerated]
			private float float_1;

			// Token: 0x0400B411 RID: 46097
			[CompilerGenerated]
			private float float_2;

			// Token: 0x0400B412 RID: 46098
			[CompilerGenerated]
			private float float_3;

			// Token: 0x0400B413 RID: 46099
			[CompilerGenerated]
			private float float_4;

			// Token: 0x0400B414 RID: 46100
			[CompilerGenerated]
			private float float_5;

			// Token: 0x0400B415 RID: 46101
			[CompilerGenerated]
			private float float_6;

			// Token: 0x0400B416 RID: 46102
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x0400B417 RID: 46103
			[CompilerGenerated]
			private float float_7;

			// Token: 0x0400B418 RID: 46104
			[CompilerGenerated]
			private bool bool_1;

			// Token: 0x0400B419 RID: 46105
			[CompilerGenerated]
			private ActiveHealthController activeHealthController_0;

			// Token: 0x0400B41A RID: 46106
			[CompilerGenerated]
			private int int_1;

			// Token: 0x0400B41B RID: 46107
			private ActiveHealthController.GClass2411 gclass2411_0;

			// Token: 0x0400B41C RID: 46108
			private float float_8;

			// Token: 0x0400B41D RID: 46109
			private float float_9;

			// Token: 0x0400B41E RID: 46110
			private float float_10;

			// Token: 0x0400B41F RID: 46111
			private float float_11;

			// Token: 0x0400B420 RID: 46112
			private float float_12;

			// Token: 0x0400B421 RID: 46113
			protected float float_13;

			// Token: 0x0400B422 RID: 46114
			protected float float_14;
		}

		// Token: 0x020020DE RID: 8414
		protected class Berserk : ActiveHealthController.GClass2411, IEffect, GInterface235, GInterface251
		{
			// Token: 0x17001CBA RID: 7354
			// (get) Token: 0x0600AE33 RID: 44595 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CBB RID: 7355
			// (get) Token: 0x0600AE34 RID: 44596 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultWorkTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CBC RID: 7356
			// (get) Token: 0x0600AE35 RID: 44597 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x020020DF RID: 8415
		protected class LightBleeding : ActiveHealthController.Bleeding, GInterface227, GInterface228, IEffect, GInterface234, GInterface240, GInterface242
		{
			// Token: 0x17001CBD RID: 7357
			// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x00002050 File Offset: 0x00000250
			protected override GClass2420.GClass2423 Settings
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CBE RID: 7358
			// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x00002050 File Offset: 0x00000250
			protected override DamageInfo DamageInfo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x020020E0 RID: 8416
		protected class HeavyBleeding : ActiveHealthController.Bleeding, GInterface227, GInterface228, IEffect, GInterface234, GInterface241, GInterface242
		{
			// Token: 0x17001CBF RID: 7359
			// (get) Token: 0x0600AE38 RID: 44600 RVA: 0x00002050 File Offset: 0x00000250
			protected override GClass2420.GClass2423 Settings
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC0 RID: 7360
			// (get) Token: 0x0600AE39 RID: 44601 RVA: 0x00002050 File Offset: 0x00000250
			protected override DamageInfo DamageInfo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE3A RID: 44602 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Removed()
			{
				throw null;
			}
		}

		// Token: 0x020020E1 RID: 8417
		protected abstract class Bleeding : ActiveHealthController.GClass2411
		{
			// Token: 0x17001CC1 RID: 7361
			// (get) Token: 0x0600AE3B RID: 44603
			protected abstract GClass2420.GClass2423 Settings { get; }

			// Token: 0x17001CC2 RID: 7362
			// (get) Token: 0x0600AE3C RID: 44604 RVA: 0x00002050 File Offset: 0x00000250
			protected float DamageEnergy
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC3 RID: 7363
			// (get) Token: 0x0600AE3D RID: 44605 RVA: 0x00002050 File Offset: 0x00000250
			protected float EnergyLoopTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC4 RID: 7364
			// (get) Token: 0x0600AE3E RID: 44606
			protected abstract DamageInfo DamageInfo { get; }

			// Token: 0x17001CC5 RID: 7365
			// (get) Token: 0x0600AE3F RID: 44607 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC6 RID: 7366
			// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC7 RID: 7367
			// (get) Token: 0x0600AE41 RID: 44609 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultWorkTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC8 RID: 7368
			// (get) Token: 0x0600AE42 RID: 44610 RVA: 0x00002050 File Offset: 0x00000250
			public int HealExperience
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CC9 RID: 7369
			// (get) Token: 0x0600AE43 RID: 44611 RVA: 0x00002050 File Offset: 0x00000250
			public float RemovePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE44 RID: 44612 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ResetParameters(bool hasDehydration)
			{
				throw null;
			}

			// Token: 0x0600AE45 RID: 44613 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE46 RID: 44614 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE47 RID: 44615 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature)
			{
				throw null;
			}

			// Token: 0x0600AE48 RID: 44616 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5()
			{
				throw null;
			}

			// Token: 0x0600AE49 RID: 44617 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6()
			{
				throw null;
			}

			// Token: 0x0400B423 RID: 46115
			private float float_15;

			// Token: 0x0400B424 RID: 46116
			private float float_16;

			// Token: 0x0400B425 RID: 46117
			private float float_17;

			// Token: 0x0400B426 RID: 46118
			private float float_18;

			// Token: 0x0400B427 RID: 46119
			private float float_19;

			// Token: 0x0400B428 RID: 46120
			private float float_20;
		}

		// Token: 0x020020E2 RID: 8418
		protected class BodyTemperature : ActiveHealthController.GClass2411, IEffect, GInterface235, GInterface252
		{
			// Token: 0x17001CCA RID: 7370
			// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultBuildUpTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CCB RID: 7371
			// (get) Token: 0x0600AE4B RID: 44619 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE4C RID: 44620 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE4D RID: 44621 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Residue()
			{
				throw null;
			}

			// Token: 0x0600AE4E RID: 44622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Removed()
			{
				throw null;
			}

			// Token: 0x0600AE4F RID: 44623 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ResidualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE50 RID: 44624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0400B429 RID: 46121
			private float float_15;

			// Token: 0x0400B42A RID: 46122
			private float float_16;

			// Token: 0x0400B42B RID: 46123
			private float float_17;
		}

		// Token: 0x020020E3 RID: 8419
		protected class ChronicStaminaFatigue : ActiveHealthController.GClass2411, IEffect, GInterface230, GInterface266
		{
			// Token: 0x17001CCC RID: 7372
			// (get) Token: 0x0600AE51 RID: 44625 RVA: 0x00002050 File Offset: 0x00000250
			public override GClass2457[] DisplayableVariations
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CCD RID: 7373
			// (get) Token: 0x0600AE52 RID: 44626 RVA: 0x00002050 File Offset: 0x00000250
			private float Single_1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE53 RID: 44627 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GClass2457[] CustomVariation(IEffect effect, bool exactTime)
			{
				throw null;
			}

			// Token: 0x0600AE54 RID: 44628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private List<GClass2455> method_5()
			{
				throw null;
			}

			// Token: 0x0600AE55 RID: 44629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private string method_6()
			{
				throw null;
			}

			// Token: 0x0600AE56 RID: 44630 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE57 RID: 44631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE58 RID: 44632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetStrength(float strength)
			{
				throw null;
			}

			// Token: 0x0600AE59 RID: 44633 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_7()
			{
				throw null;
			}

			// Token: 0x0400B42C RID: 46124
			private float float_15;

			// Token: 0x0400B42D RID: 46125
			private GClass2457 gclass2457_0;

			// Token: 0x0400B42E RID: 46126
			private List<GClass2455> list_0;
		}

		// Token: 0x020020E4 RID: 8420
		protected class Contusion : ActiveHealthController.GClass2411, IEffect, GInterface232, GInterface253
		{
			// Token: 0x0600AE5A RID: 44634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ForceResidue()
			{
				throw null;
			}

			// Token: 0x0400B42F RID: 46127
			private const float float_15 = 2f;
		}

		// Token: 0x020020E5 RID: 8421
		protected class DamageModifier : ActiveHealthController.GClass2411, IEffect, GInterface272
		{
			// Token: 0x17001CCE RID: 7374
			// (get) Token: 0x0600AE5B RID: 44635 RVA: 0x00002050 File Offset: 0x00000250
			private float Single_1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE5C RID: 44636 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE5D RID: 44637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Residue()
			{
				throw null;
			}
		}

		// Token: 0x020020E6 RID: 8422
		protected class Dehydration : ActiveHealthController.GClass2411, IEffect, GInterface234, GInterface244
		{
			// Token: 0x17001CCF RID: 7375
			// (get) Token: 0x0600AE5E RID: 44638 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CD0 RID: 7376
			// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CD1 RID: 7377
			// (get) Token: 0x0600AE60 RID: 44640 RVA: 0x00002050 File Offset: 0x00000250
			private float Single_1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE61 RID: 44641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Added()
			{
				throw null;
			}

			// Token: 0x0600AE62 RID: 44642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE63 RID: 44643 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE64 RID: 44644 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Residue()
			{
				throw null;
			}

			// Token: 0x0400B430 RID: 46128
			private float float_15;

			// Token: 0x0400B431 RID: 46129
			private float float_16;
		}

		// Token: 0x020020E7 RID: 8423
		protected class Disorientation : ActiveHealthController.GClass2411, IEffect, GInterface254
		{
			// Token: 0x0600AE65 RID: 44645 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ResidualUpdate(float deltaTime)
			{
				throw null;
			}
		}

		// Token: 0x020020E8 RID: 8424
		protected class Encumbered : ActiveHealthController.GClass2411, IEffect, GInterface230, GInterface264
		{
			// Token: 0x17001CD2 RID: 7378
			// (get) Token: 0x0600AE66 RID: 44646 RVA: 0x00002050 File Offset: 0x00000250
			public override GClass2457[] DisplayableVariations
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE67 RID: 44647 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GClass2457[] GetDisplayVariations(IEffect effect, bool exactTime)
			{
				throw null;
			}

			// Token: 0x0600AE68 RID: 44648 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void UpdateDebuffs()
			{
				throw null;
			}

			// Token: 0x0600AE69 RID: 44649 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Removed()
			{
				throw null;
			}

			// Token: 0x0600AE6A RID: 44650 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5()
			{
				throw null;
			}

			// Token: 0x0600AE6B RID: 44651 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6()
			{
				throw null;
			}

			// Token: 0x0400B432 RID: 46130
			private readonly List<GClass2455> list_0;

			// Token: 0x0400B433 RID: 46131
			private Action action_0;

			// Token: 0x0400B434 RID: 46132
			private GClass2457 gclass2457_0;
		}

		// Token: 0x020020E9 RID: 8425
		protected class Endurance : ActiveHealthController.Effect<GStruct341>, IEffect, GInterface274
		{
			// Token: 0x17001CD3 RID: 7379
			// (get) Token: 0x0600AE6C RID: 44652 RVA: 0x00002050 File Offset: 0x00000250
			public bool Absolute
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE6D RID: 44653 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Init(bool absolute)
			{
				throw null;
			}

			// Token: 0x0600AE6E RID: 44654 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Serialize(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x0600AE6F RID: 44655 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE70 RID: 44656 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Residue()
			{
				throw null;
			}
		}

		// Token: 0x020020EA RID: 8426
		protected class Exhaustion : ActiveHealthController.GClass2411, IEffect, GInterface234, GInterface245
		{
			// Token: 0x17001CD4 RID: 7380
			// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CD5 RID: 7381
			// (get) Token: 0x0600AE72 RID: 44658 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CD6 RID: 7382
			// (get) Token: 0x0600AE73 RID: 44659 RVA: 0x00002050 File Offset: 0x00000250
			private float Single_1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE74 RID: 44660 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE75 RID: 44661 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0400B435 RID: 46133
			private float float_15;

			// Token: 0x0400B436 RID: 46134
			private float float_16;
		}

		// Token: 0x020020EB RID: 8427
		protected class Existence : ActiveHealthController.GClass2411, IEffect, GInterface235, GInterface249
		{
			// Token: 0x0600AE76 RID: 44662 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE77 RID: 44663 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE78 RID: 44664 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_5()
			{
				throw null;
			}

			// Token: 0x0600AE79 RID: 44665 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_6()
			{
				throw null;
			}

			// Token: 0x0400B437 RID: 46135
			private float float_15;

			// Token: 0x0400B438 RID: 46136
			private float float_16;

			// Token: 0x0400B439 RID: 46137
			private float float_17;

			// Token: 0x0400B43A RID: 46138
			private float float_18;

			// Token: 0x0400B43B RID: 46139
			private bool bool_2;
		}

		// Token: 0x020020EC RID: 8428
		protected class Flash : ActiveHealthController.GClass2411, IEffect, GInterface255
		{
		}

		// Token: 0x020020ED RID: 8429
		protected class Fracture : ActiveHealthController.GClass2411, GInterface227, GInterface228, IEffect, GInterface234, GInterface243
		{
			// Token: 0x17001CD7 RID: 7383
			// (get) Token: 0x0600AE7A RID: 44666 RVA: 0x00002050 File Offset: 0x00000250
			protected GClass2420.GClass2424 FractureSettings
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CD8 RID: 7384
			// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CD9 RID: 7385
			// (get) Token: 0x0600AE7C RID: 44668 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CDA RID: 7386
			// (get) Token: 0x0600AE7D RID: 44669 RVA: 0x00002050 File Offset: 0x00000250
			public int HealExperience
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CDB RID: 7387
			// (get) Token: 0x0600AE7E RID: 44670 RVA: 0x00002050 File Offset: 0x00000250
			public float RemovePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE7F RID: 44671 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}
		}

		// Token: 0x020020EE RID: 8430
		protected class FullHealthRegenerationEffect : ActiveHealthController.GClass2411, IEffect, GInterface234, GInterface239
		{
			// Token: 0x0600AE80 RID: 44672 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}
		}

		// Token: 0x020020EF RID: 8431
		protected sealed class HalloweenBuff : ActiveHealthController.GClass2411, IEffect, GInterface268
		{
		}

		// Token: 0x020020F0 RID: 8432
		protected class HealthBoost : ActiveHealthController.GClass2411, IEffect, GInterface273
		{
			// Token: 0x0600AE81 RID: 44673 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE82 RID: 44674 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0400B43C RID: 46140
			private float float_15;

			// Token: 0x0400B43D RID: 46141
			private float float_16;

			// Token: 0x0400B43E RID: 46142
			private float float_17;
		}

		// Token: 0x020020F1 RID: 8433
		protected sealed class ImmunityPreventedNegativeEffect : ActiveHealthController.GClass2411, IEffect, GInterface230, GInterface267
		{
			// Token: 0x17001CDC RID: 7388
			// (get) Token: 0x0600AE83 RID: 44675 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CDD RID: 7389
			// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultWorkTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x020020F2 RID: 8434
		protected class Intoxication : ActiveHealthController.GClass2411, GInterface227, GInterface228, IEffect, GInterface234, GInterface236, GInterface247
		{
			// Token: 0x17001CDE RID: 7390
			// (get) Token: 0x0600AE85 RID: 44677 RVA: 0x00002050 File Offset: 0x00000250
			public static EBodyPart DefaultBodyPart
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CDF RID: 7391
			// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x00002050 File Offset: 0x00000250
			protected GClass2420.GClass2431 Settings
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE0 RID: 7392
			// (get) Token: 0x0600AE87 RID: 44679 RVA: 0x00002050 File Offset: 0x00000250
			protected DamageInfo DamageInfo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE1 RID: 7393
			// (get) Token: 0x0600AE88 RID: 44680 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE2 RID: 7394
			// (get) Token: 0x0600AE89 RID: 44681 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE3 RID: 7395
			// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultWorkTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE4 RID: 7396
			// (get) Token: 0x0600AE8B RID: 44683 RVA: 0x00002050 File Offset: 0x00000250
			public int HealExperience
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE5 RID: 7397
			// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x00002050 File Offset: 0x00000250
			public float RemovePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE8D RID: 44685 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE8E RID: 44686 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AE8F RID: 44687 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature)
			{
				throw null;
			}

			// Token: 0x0600AE90 RID: 44688 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5()
			{
				throw null;
			}

			// Token: 0x0400B43F RID: 46143
			private float float_15;

			// Token: 0x0400B440 RID: 46144
			private float float_16;

			// Token: 0x0400B441 RID: 46145
			private float float_17;

			// Token: 0x0400B442 RID: 46146
			private float float_18;
		}

		// Token: 0x020020F3 RID: 8435
		protected sealed class LethalIntoxication : ActiveHealthController.GClass2411, GInterface227, GInterface228, IEffect, GInterface230, GInterface234, GInterface248
		{
			// Token: 0x17001CE6 RID: 7398
			// (get) Token: 0x0600AE91 RID: 44689 RVA: 0x00002050 File Offset: 0x00000250
			public static EBodyPart DefaultBodyPart
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE7 RID: 7399
			// (get) Token: 0x0600AE92 RID: 44690 RVA: 0x00002050 File Offset: 0x00000250
			public override bool Critical
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE8 RID: 7400
			// (get) Token: 0x0600AE93 RID: 44691 RVA: 0x00002050 File Offset: 0x00000250
			private DamageInfo GStruct390_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CE9 RID: 7401
			// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x00002050 File Offset: 0x00000250
			private GClass2420.GClass2432 GClass2432_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CEA RID: 7402
			// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CEB RID: 7403
			// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CEC RID: 7404
			// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x00002050 File Offset: 0x00000250
			public int HealExperience
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CED RID: 7405
			// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x00002050 File Offset: 0x00000250
			public float RemovePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE99 RID: 44697 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE9A RID: 44698 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Removed()
			{
				throw null;
			}
		}

		// Token: 0x020020F4 RID: 8436
		protected class LowEdgeHealth : ActiveHealthController.GClass2411, IEffect, GInterface256
		{
			// Token: 0x17001CEE RID: 7406
			// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CEF RID: 7407
			// (get) Token: 0x0600AE9C RID: 44700 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AE9D RID: 44701 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AE9E RID: 44702 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}
		}

		// Token: 0x020020F5 RID: 8437
		protected class MedEffect : ActiveHealthController.Effect<GStruct342>, IEffect, GInterface231, GInterface232, GInterface235, GInterface275
		{
			// Token: 0x17001CF0 RID: 7408
			// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AEA0 RID: 44704 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CF1 RID: 7409
			// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AEA2 RID: 44706 RVA: 0x00002050 File Offset: 0x00000250
			public float Amount
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

			// Token: 0x17001CF2 RID: 7410
			// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x00002050 File Offset: 0x00000250
			public bool NoMove
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AEA4 RID: 44708 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Init(Item item, float amount)
			{
				throw null;
			}

			// Token: 0x0600AEA5 RID: 44709 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Serialize(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x0600AEA6 RID: 44710 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Restored()
			{
				throw null;
			}

			// Token: 0x0600AEA7 RID: 44711 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Added()
			{
				throw null;
			}

			// Token: 0x0600AEA8 RID: 44712 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AEA9 RID: 44713 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5(GEventArgs1 eventArgs)
			{
				throw null;
			}

			// Token: 0x0600AEAA RID: 44714 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AEAB RID: 44715 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Residue()
			{
				throw null;
			}

			// Token: 0x0600AEAC RID: 44716 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ForceResidue()
			{
				throw null;
			}

			// Token: 0x0600AEAD RID: 44717 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ForceRemove()
			{
				throw null;
			}

			// Token: 0x0600AEAE RID: 44718 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_6()
			{
				throw null;
			}

			// Token: 0x0600AEAF RID: 44719 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_7(Item i)
			{
				throw null;
			}

			// Token: 0x0600AEB0 RID: 44720 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_8(ActiveHealthController.Stimulator e)
			{
				throw null;
			}

			// Token: 0x0400B443 RID: 46147
			[CompilerGenerated]
			private Item item_0;

			// Token: 0x0400B444 RID: 46148
			[CompilerGenerated]
			private float float_15;

			// Token: 0x0400B445 RID: 46149
			private HealthEffectsComponent healthEffectsComponent_0;

			// Token: 0x0400B446 RID: 46150
			private MedKitComponent medKitComponent_0;

			// Token: 0x0400B447 RID: 46151
			private FoodDrinkComponent foodDrinkComponent_0;

			// Token: 0x0400B448 RID: 46152
			private float float_16;

			// Token: 0x0400B449 RID: 46153
			private float float_17;

			// Token: 0x0400B44A RID: 46154
			private float float_18;

			// Token: 0x0400B44B RID: 46155
			private float float_19;

			// Token: 0x0400B44C RID: 46156
			private bool bool_2;

			// Token: 0x020020F6 RID: 8438
			[CompilerGenerated]
			private sealed class Class1881
			{
				// Token: 0x0600AEB1 RID: 44721 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(ActiveHealthController.PainKiller x)
				{
					throw null;
				}

				// Token: 0x0400B44D RID: 46157
				public GClass1232 damageEffect;

				// Token: 0x0400B44E RID: 46158
				public ActiveHealthController.MedEffect medEffect_0;
			}
		}

		// Token: 0x020020F7 RID: 8439
		protected class MisfireEffect : ActiveHealthController.GClass2411, IEffect, GInterface269
		{
		}

		// Token: 0x020020F8 RID: 8440
		protected class MildMusclePain : ActiveHealthController.MusclePain, IEffect, GInterface234, GInterface237, GInterface277, GInterface278
		{
		}

		// Token: 0x020020F9 RID: 8441
		protected class SevereMusclePain : ActiveHealthController.MusclePain, IEffect, GInterface234, GInterface237, GInterface277, GInterface279
		{
		}

		// Token: 0x020020FA RID: 8442
		protected abstract class MusclePain : ActiveHealthController.GClass2411
		{
			// Token: 0x0600AEB2 RID: 44722 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override Profile.GClass1753.GClass1754 Store()
			{
				throw null;
			}
		}

		// Token: 0x020020FB RID: 8443
		protected class OverEncumbered : ActiveHealthController.GClass2411, IEffect, GInterface230, GInterface265
		{
			// Token: 0x17001CF3 RID: 7411
			// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x00002050 File Offset: 0x00000250
			public override GClass2457[] DisplayableVariations
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AEB4 RID: 44724 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GClass2457[] GetDisplayVariations(IEffect effect, bool exactTime)
			{
				throw null;
			}

			// Token: 0x0600AEB5 RID: 44725 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void UpdateDebuffs()
			{
				throw null;
			}

			// Token: 0x0400B44F RID: 46159
			private readonly List<GClass2455> list_0;

			// Token: 0x0400B450 RID: 46160
			private GClass2457 gclass2457_0;
		}

		// Token: 0x020020FC RID: 8444
		protected class Pain : ActiveHealthController.GClass2411, GInterface227, IEffect, GInterface238, GInterface257
		{
			// Token: 0x17001CF4 RID: 7412
			// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x00002050 File Offset: 0x00000250
			public static float DefaultResidue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CF5 RID: 7413
			// (get) Token: 0x0600AEB7 RID: 44727 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultBuildUpTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CF6 RID: 7414
			// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CF7 RID: 7415
			// (get) Token: 0x0600AEB9 RID: 44729 RVA: 0x00002050 File Offset: 0x00000250
			public int HealExperience
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CF8 RID: 7416
			// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x00002050 File Offset: 0x00000250
			public Type[] HiddenByTypes
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AEBB RID: 44731 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Init(ActiveHealthController health, EBodyPart bodyPart, float? delayTime, float? workTime, float? residueTime, float strength, int? updateTime)
			{
				throw null;
			}

			// Token: 0x0600AEBC RID: 44732 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AEBD RID: 44733 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AEBE RID: 44734 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ForceResidue()
			{
				throw null;
			}

			// Token: 0x0400B451 RID: 46161
			private const float float_15 = 2f;

			// Token: 0x0400B452 RID: 46162
			private float? nullable_0;
		}

		// Token: 0x020020FD RID: 8445
		protected class PainKiller : ActiveHealthController.GClass2411, IEffect, GInterface231, GInterface233, GInterface235, GInterface258
		{
			// Token: 0x17001CF9 RID: 7417
			// (get) Token: 0x0600AEBF RID: 44735 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AEC0 RID: 44736 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CFA RID: 7418
			// (get) Token: 0x0600AEC1 RID: 44737 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AEC2 RID: 44738 RVA: 0x00002050 File Offset: 0x00000250
			public float MaxDuration
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

			// Token: 0x0600AEC3 RID: 44739 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateWithSameOne(float strength)
			{
				throw null;
			}

			// Token: 0x0600AEC4 RID: 44740 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreValues(string templateId, float duration)
			{
				throw null;
			}

			// Token: 0x0400B453 RID: 46163
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400B454 RID: 46164
			[CompilerGenerated]
			private float float_15;
		}

		// Token: 0x020020FE RID: 8446
		protected class PanicEffect : ActiveHealthController.GClass2411, IEffect, GInterface271
		{
		}

		// Token: 0x020020FF RID: 8447
		protected class RadExposure : ActiveHealthController.GClass2411, IEffect, GInterface234, GInterface246
		{
			// Token: 0x0600AEC5 RID: 44741 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AEC6 RID: 44742 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0400B455 RID: 46165
			private float float_15;
		}

		// Token: 0x02002100 RID: 8448
		protected class Regeneration : ActiveHealthController.GClass2411, IEffect, GInterface235, GInterface250
		{
		}

		// Token: 0x02002101 RID: 8449
		protected class SandingScreen : ActiveHealthController.GClass2411, IEffect, GInterface259
		{
		}

		// Token: 0x02002102 RID: 8450
		protected class ScavRegeneration : ActiveHealthController.GClass2411, IEffect, GInterface235, GInterface250
		{
			// Token: 0x0600AEC7 RID: 44743 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AEC8 RID: 44744 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0400B456 RID: 46166
			private const float float_15 = 3f;

			// Token: 0x0400B457 RID: 46167
			private float float_16;

			// Token: 0x0400B458 RID: 46168
			private float float_17;

			// Token: 0x0400B459 RID: 46169
			private IEnumerable<EBodyPart> ienumerable_0;
		}

		// Token: 0x02002103 RID: 8451
		protected sealed class StaminaZero : ActiveHealthController.GClass2411, IEffect, GInterface231, GInterface270
		{
			// Token: 0x0600AEC9 RID: 44745 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}
		}

		// Token: 0x02002104 RID: 8452
		protected class Stimulator : ActiveHealthController.Effect<GStruct343>, IEffect, GInterface231, GInterface233, GInterface235, GInterface276
		{
			// Token: 0x17001CFB RID: 7419
			// (get) Token: 0x0600AECA RID: 44746 RVA: 0x00002050 File Offset: 0x00000250
			public override GClass2457[] DisplayableVariations
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CFC RID: 7420
			// (get) Token: 0x0600AECB RID: 44747 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AECC RID: 44748 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x17001CFD RID: 7421
			// (get) Token: 0x0600AECD RID: 44749 RVA: 0x00002050 File Offset: 0x00000250
			public string ItemTemplateId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001CFE RID: 7422
			// (get) Token: 0x0600AECE RID: 44750 RVA: 0x00002050 File Offset: 0x00000250
			public string Name
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AECF RID: 44751 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_5(ActiveHealthController.Stimulator.Class1882 buff)
			{
				throw null;
			}

			// Token: 0x17001CFF RID: 7423
			// (get) Token: 0x0600AED0 RID: 44752 RVA: 0x00002050 File Offset: 0x00000250
			private ActiveHealthController.Stimulator.Class1882[] Class1882_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AED1 RID: 44753 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateWithSameOne(float strength = 1f)
			{
				throw null;
			}

			// Token: 0x0600AED2 RID: 44754 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreValues(string buffsName, string templateId, EBodyPart appliedTo)
			{
				throw null;
			}

			// Token: 0x0600AED3 RID: 44755 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Serialize(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x0600AED4 RID: 44756 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Added()
			{
				throw null;
			}

			// Token: 0x0600AED5 RID: 44757 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Started()
			{
				throw null;
			}

			// Token: 0x0600AED6 RID: 44758 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void RegularUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AED7 RID: 44759 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Residue()
			{
				throw null;
			}

			// Token: 0x0600AED8 RID: 44760 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Removed()
			{
				throw null;
			}

			// Token: 0x0600AED9 RID: 44761 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6(ActiveHealthController.Stimulator.Class1882 buff, bool activate)
			{
				throw null;
			}

			// Token: 0x0600AEDA RID: 44762 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_7(GInterface226 buff, float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600AEDB RID: 44763 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static float smethod_0(GClass2420.GClass2445.GClass2446 buffSettings, float refValue, Vector2? limits = null)
			{
				throw null;
			}

			// Token: 0x0600AEDC RID: 44764 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_8()
			{
				throw null;
			}

			// Token: 0x0600AEDD RID: 44765 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void AddWholeTime(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0400B45A RID: 46170
			[CompilerGenerated]
			private GInterface226[] ginterface226_0;

			// Token: 0x0400B45B RID: 46171
			private float float_15;

			// Token: 0x0400B45C RID: 46172
			private float float_16;

			// Token: 0x02002105 RID: 8453
			private sealed class Class1882 : GInterface225, GInterface226
			{
				// Token: 0x17001D00 RID: 7424
				// (get) Token: 0x0600AEDE RID: 44766 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600AEDF RID: 44767 RVA: 0x00002050 File Offset: 0x00000250
				public bool Active
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

				// Token: 0x17001D01 RID: 7425
				// (get) Token: 0x0600AEE0 RID: 44768 RVA: 0x00002050 File Offset: 0x00000250
				public float Value
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001D02 RID: 7426
				// (get) Token: 0x0600AEE1 RID: 44769 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600AEE2 RID: 44770 RVA: 0x00002050 File Offset: 0x00000250
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

				// Token: 0x17001D03 RID: 7427
				// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600AEE4 RID: 44772 RVA: 0x00002050 File Offset: 0x00000250
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

				// Token: 0x17001D04 RID: 7428
				// (get) Token: 0x0600AEE5 RID: 44773 RVA: 0x00002050 File Offset: 0x00000250
				public Type BuffType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001D05 RID: 7429
				// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x00002050 File Offset: 0x00000250
				public string BuffName
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001D06 RID: 7430
				// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600AEE8 RID: 44776 RVA: 0x00002050 File Offset: 0x00000250
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

				// Token: 0x0600AEE9 RID: 44777 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void IncreaseBySameBuff(float curStimulatorTime, float strength, SkillManager skillManager)
				{
					throw null;
				}

				// Token: 0x0600AEEA RID: 44778 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private float method_0(float duration, bool isBuff, SkillManager skillManager)
				{
					throw null;
				}

				// Token: 0x0600AEEB RID: 44779 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					throw null;
				}

				// Token: 0x0400B45D RID: 46173
				[CompilerGenerated]
				private bool bool_0;

				// Token: 0x0400B45E RID: 46174
				public GClass2420.GClass2445.GClass2446 OriginalSettings;

				// Token: 0x0400B45F RID: 46175
				[CompilerGenerated]
				private GClass2420.GClass2445.GClass2446 gclass2446_0;

				// Token: 0x0400B460 RID: 46176
				[CompilerGenerated]
				private EBodyPart ebodyPart_0;

				// Token: 0x0400B461 RID: 46177
				public bool Processed;

				// Token: 0x0400B462 RID: 46178
				public object ValueObj;

				// Token: 0x0400B463 RID: 46179
				[CompilerGenerated]
				private float float_0;
			}

			// Token: 0x02002106 RID: 8454
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1883
			{
				// Token: 0x0600AEEC RID: 44780 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal ActiveHealthController.Stimulator.Class1882 method_0(GInterface226 x)
				{
					throw null;
				}

				// Token: 0x0600AEED RID: 44781 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0600AEEE RID: 44782 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2(ActiveHealthController.Stimulator.Class1882 b)
				{
					throw null;
				}

				// Token: 0x0600AEEF RID: 44783 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_3(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0600AEF0 RID: 44784 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_4(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0600AEF1 RID: 44785 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_5(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0600AEF2 RID: 44786 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_6(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0600AEF3 RID: 44787 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_7(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0600AEF4 RID: 44788 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_8(GInterface226 b)
				{
					throw null;
				}

				// Token: 0x0400B464 RID: 46180
				public static readonly ActiveHealthController.Stimulator.Class1883 class1883_0;

				// Token: 0x0400B465 RID: 46181
				public static Converter<GInterface226, ActiveHealthController.Stimulator.Class1882> converter_0;

				// Token: 0x0400B466 RID: 46182
				public static Func<GInterface226, bool> func_0;

				// Token: 0x0400B467 RID: 46183
				public static Func<ActiveHealthController.Stimulator.Class1882, bool> func_1;

				// Token: 0x0400B468 RID: 46184
				public static Func<GInterface226, bool> func_2;

				// Token: 0x0400B469 RID: 46185
				public static Func<GInterface226, float> func_3;

				// Token: 0x0400B46A RID: 46186
				public static Func<GInterface226, bool> func_4;

				// Token: 0x0400B46B RID: 46187
				public static Func<GInterface226, float> func_5;

				// Token: 0x0400B46C RID: 46188
				public static Func<GInterface226, bool> func_6;

				// Token: 0x0400B46D RID: 46189
				public static Func<GInterface226, float> func_7;
			}

			// Token: 0x02002107 RID: 8455
			[CompilerGenerated]
			private sealed class Class1884
			{
				// Token: 0x0600AEF5 RID: 44789 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(GClass1765 s)
				{
					throw null;
				}

				// Token: 0x0600AEF6 RID: 44790 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1(ActiveHealthController.GClass2411 effect)
				{
					throw null;
				}

				// Token: 0x0400B46E RID: 46190
				public ActiveHealthController.Stimulator.Class1882 buff;

				// Token: 0x0400B46F RID: 46191
				public ActiveHealthController.Stimulator stimulator_0;

				// Token: 0x0400B470 RID: 46192
				public Func<ActiveHealthController.GClass2411, bool> func_0;
			}
		}

		// Token: 0x02002108 RID: 8456
		protected class Stun : ActiveHealthController.GClass2411, IEffect, GInterface260
		{
			// Token: 0x17001D07 RID: 7431
			// (get) Token: 0x0600AEF7 RID: 44791 RVA: 0x00002050 File Offset: 0x00000250
			public static float StunBuildUpTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D08 RID: 7432
			// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultBuildUpTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D09 RID: 7433
			// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AEFA RID: 44794 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CalculateCurrentStrength(float deltaTime = 0f)
			{
				throw null;
			}
		}

		// Token: 0x02002109 RID: 8457
		protected class Tremor : ActiveHealthController.GClass2411, IEffect, GInterface232, GInterface261
		{
			// Token: 0x17001D0A RID: 7434
			// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultDelayTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D0B RID: 7435
			// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x0200210A RID: 8458
		protected class TunnelVision : ActiveHealthController.GClass2411, IEffect, GInterface263
		{
			// Token: 0x17001D0C RID: 7436
			// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultBuildUpTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001D0D RID: 7437
			// (get) Token: 0x0600AEFE RID: 44798 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultResidueTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x0200210B RID: 8459
		protected class Wound : ActiveHealthController.GClass2411, IEffect, GInterface262
		{
			// Token: 0x17001D0E RID: 7438
			// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x00002050 File Offset: 0x00000250
			protected override float DefaultWorkTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600AF00 RID: 44800 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Added()
			{
				throw null;
			}

			// Token: 0x0600AF01 RID: 44801 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void BuildUp(float value)
			{
				throw null;
			}

			// Token: 0x0400B471 RID: 46193
			private float float_15;

			// Token: 0x0400B472 RID: 46194
			private float float_16;
		}

		// Token: 0x0200210C RID: 8460
		[CompilerGenerated]
		private sealed class Class1885<T> where T : ActiveHealthController.GClass2411, GInterface233, new()
		{
			// Token: 0x0600AF02 RID: 44802 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(T e)
			{
				throw null;
			}

			// Token: 0x0400B473 RID: 46195
			public Item effectSourceItem;
		}

		// Token: 0x0200210D RID: 8461
		[CompilerGenerated]
		private sealed class Class1886<T> where T : ActiveHealthController.GClass2411, new()
		{
			// Token: 0x0600AF03 RID: 44803 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ActiveHealthController.GClass2411 e)
			{
				throw null;
			}

			// Token: 0x0600AF04 RID: 44804 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(ActiveHealthController.GClass2411 e)
			{
				throw null;
			}

			// Token: 0x0400B474 RID: 46196
			public EBodyPart bodyPart;

			// Token: 0x0400B475 RID: 46197
			public Action<T> initCallback;
		}

		// Token: 0x0200210E RID: 8462
		[CompilerGenerated]
		private sealed class Class1887
		{
			// Token: 0x0600AF05 RID: 44805 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400B476 RID: 46198
			public List<ActiveHealthController.GClass2411> pausedEffects;

			// Token: 0x0400B477 RID: 46199
			public List<GStruct344> _pausedEffectsInfo;

			// Token: 0x0400B478 RID: 46200
			public ActiveHealthController activeHealthController_0;
		}

		// Token: 0x0200210F RID: 8463
		[CompilerGenerated]
		private sealed class Class1888
		{
			// Token: 0x0600AF06 RID: 44806 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ActiveHealthController.Stimulator e)
			{
				throw null;
			}

			// Token: 0x0400B479 RID: 46201
			public string buffName;
		}

		// Token: 0x02002110 RID: 8464
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1889
		{
			// Token: 0x0600AF07 RID: 44807 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ActiveHealthController.GClass2411 effect)
			{
				throw null;
			}

			// Token: 0x0600AF08 RID: 44808 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ActiveHealthController.GClass2411 effect)
			{
				throw null;
			}

			// Token: 0x0600AF09 RID: 44809 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(ActiveHealthController.GClass2411 effect)
			{
				throw null;
			}

			// Token: 0x0600AF0A RID: 44810 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(ActiveHealthController.Stimulator stimulator)
			{
				throw null;
			}

			// Token: 0x0400B47A RID: 46202
			public static readonly ActiveHealthController.Class1889 class1889_0;

			// Token: 0x0400B47B RID: 46203
			public static Func<ActiveHealthController.GClass2411, bool> func_0;

			// Token: 0x0400B47C RID: 46204
			public static Func<ActiveHealthController.GClass2411, bool> func_1;

			// Token: 0x0400B47D RID: 46205
			public static Func<ActiveHealthController.GClass2411, bool> func_2;

			// Token: 0x0400B47E RID: 46206
			public static Func<ActiveHealthController.Stimulator, string> func_3;
		}

		// Token: 0x02002111 RID: 8465
		[CompilerGenerated]
		private sealed class Class1890
		{
			// Token: 0x0600AF0B RID: 44811 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ActiveHealthController.Stimulator e)
			{
				throw null;
			}

			// Token: 0x0400B47F RID: 46207
			public SideEffectComponent sideEffect;

			// Token: 0x0400B480 RID: 46208
			public Item weapon;

			// Token: 0x0400B481 RID: 46209
			public EBodyPart bodyPart;
		}

		// Token: 0x02002112 RID: 8466
		[CompilerGenerated]
		private sealed class Class1891
		{
			// Token: 0x0600AF0C RID: 44812 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ActiveHealthController.Stimulator s)
			{
				throw null;
			}

			// Token: 0x0600AF0D RID: 44813 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GInterface226 b)
			{
				throw null;
			}

			// Token: 0x0400B482 RID: 46210
			public EStimulatorBuffType buffType;

			// Token: 0x0400B483 RID: 46211
			public Func<GInterface226, bool> func_0;
		}

		// Token: 0x02002113 RID: 8467
		[CompilerGenerated]
		private sealed class Class1892
		{
			// Token: 0x0600AF0E RID: 44814 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ActiveHealthController.MedEffect e)
			{
				throw null;
			}

			// Token: 0x0600AF0F RID: 44815 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(ActiveHealthController.MedEffect e)
			{
				throw null;
			}

			// Token: 0x0400B484 RID: 46212
			public float actualAmount;
		}
	}
}
