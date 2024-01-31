using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Communications;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.Quests;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x0200294B RID: 10571
	[Serializable]
	public sealed class StaticIcons : ScriptableObject
	{
		// Token: 0x0600D2E0 RID: 53984 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetItemTypeIcon(EItemType type)
		{
			throw null;
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetSmallCurrencySign(string templateId, bool nullable = false)
		{
			throw null;
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetBigCurrencySign(string templateId)
		{
			throw null;
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetSmallCurrencySign(ECurrencyType currency)
		{
			throw null;
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetQuestIcon(Condition condition)
		{
			throw null;
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetAttributeIcon(Enum id)
		{
			throw null;
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetStatGroupIcon(EStatGroupId groupId)
		{
			throw null;
		}

		// Token: 0x0400D471 RID: 54385
		public StaticIcons.ItemTypeToSpriteDictionary ItemTypeSprites;

		// Token: 0x0400D472 RID: 54386
		public StaticIcons.QuestTypeToSpriteDictionary QuestTypeSprites;

		// Token: 0x0400D473 RID: 54387
		public StaticIcons.QuestIconTypeToSpriteDictionary QuestIconTypeSprites;

		// Token: 0x0400D474 RID: 54388
		public StaticIcons.BuffIdToSpriteDictionary BuffIdSprites;

		// Token: 0x0400D475 RID: 54389
		public StaticIcons.SkillIdToSpriteDictionary SkillIdSprites;

		// Token: 0x0400D476 RID: 54390
		public StaticIcons.StatGroupIdToSpriteDictionary StatGroupSprites;

		// Token: 0x0400D477 RID: 54391
		public StaticIcons.DamageResultToSpriteDictionary DamageResultSprites;

		// Token: 0x0400D478 RID: 54392
		public StaticIcons.NotificationIconTypeToSpriteDictionary NotificationSprites;

		// Token: 0x0400D479 RID: 54393
		public StaticIcons.GestureToSpriteDictionary GestureSprites;

		// Token: 0x0400D47A RID: 54394
		public StaticIcons.TraderDialogLineSpriteDictionary DialogLineSprites;

		// Token: 0x0400D47B RID: 54395
		[Header("Attributes")]
		public StaticIcons.ItemAttributeIdToSpriteDictionary ItemAttributeSprites;

		// Token: 0x0400D47C RID: 54396
		public StaticIcons.HealthFactorTypeToSpriteDictionary HealEffectSprites;

		// Token: 0x0400D47D RID: 54397
		public StaticIcons.DamageEffectTypeToSpriteDictionary DamageEffectSprites;

		// Token: 0x0400D47E RID: 54398
		public StaticIcons.StimulatorBuffTypeToSpriteDictionary StimulatorBuffSprites;

		// Token: 0x0400D47F RID: 54399
		[Header("Currencies")]
		public StaticIcons.CurrencyTypeToSpriteDictionary CurrencyTypeSmallSprites;

		// Token: 0x0400D480 RID: 54400
		public StaticIcons.CurrencyTypeToSpriteDictionary CurrencyTypeBigSprites;

		// Token: 0x0400D481 RID: 54401
		public Sprite BarterSign;

		// Token: 0x0400D482 RID: 54402
		[Header("Misc")]
		public Sprite YesCheck;

		// Token: 0x0400D483 RID: 54403
		public Sprite NoCheck;

		// Token: 0x0400D484 RID: 54404
		public Sprite TogglableOn;

		// Token: 0x0400D485 RID: 54405
		public Sprite TogglableOff;

		// Token: 0x0400D486 RID: 54406
		[Header("Health Effects")]
		public StaticIcons.EffectSprites EffectIcons;

		// Token: 0x0200294C RID: 10572
		[Serializable]
		public sealed class ItemTypeToSpriteDictionary : SerializableEnumDictionary<EItemType, Sprite>
		{
		}

		// Token: 0x0200294D RID: 10573
		[Serializable]
		public sealed class QuestTypeToSpriteDictionary : SerializableEnumDictionary<RawQuestClass.EQuestType, Sprite>
		{
		}

		// Token: 0x0200294E RID: 10574
		[Serializable]
		public sealed class QuestIconTypeToSpriteDictionary : SerializableEnumDictionary<EQuestIconType, Sprite>
		{
		}

		// Token: 0x0200294F RID: 10575
		[Serializable]
		public sealed class BuffIdToSpriteDictionary : SerializableEnumDictionary<EBuffId, Sprite>
		{
		}

		// Token: 0x02002950 RID: 10576
		[Serializable]
		public sealed class SkillIdToSpriteDictionary : SerializableEnumDictionary<ESkillId, Sprite>
		{
		}

		// Token: 0x02002951 RID: 10577
		[Serializable]
		public sealed class StatGroupIdToSpriteDictionary : SerializableEnumDictionary<EStatGroupId, Sprite>
		{
		}

		// Token: 0x02002952 RID: 10578
		[Serializable]
		public sealed class DamageResultToSpriteDictionary : SerializableEnumDictionary<DamageStats.EDamageResult, Sprite>
		{
		}

		// Token: 0x02002953 RID: 10579
		[Serializable]
		public sealed class NotificationIconTypeToSpriteDictionary : SerializableEnumDictionary<ENotificationIconType, Sprite>
		{
		}

		// Token: 0x02002954 RID: 10580
		[Serializable]
		public sealed class GestureToSpriteDictionary : SerializableEnumDictionary<EGesture, Sprite>
		{
		}

		// Token: 0x02002955 RID: 10581
		[Serializable]
		public sealed class ItemAttributeIdToSpriteDictionary : SerializableEnumDictionary<EItemAttributeId, Sprite>
		{
		}

		// Token: 0x02002956 RID: 10582
		[Serializable]
		public sealed class HealthFactorTypeToSpriteDictionary : SerializableEnumDictionary<EHealthFactorType, Sprite>
		{
		}

		// Token: 0x02002957 RID: 10583
		[Serializable]
		public sealed class DamageEffectTypeToSpriteDictionary : SerializableEnumDictionary<EDamageEffectType, Sprite>
		{
		}

		// Token: 0x02002958 RID: 10584
		[Serializable]
		public sealed class StimulatorBuffTypeToSpriteDictionary : SerializableEnumDictionary<EStimulatorBuffType, Sprite>
		{
		}

		// Token: 0x02002959 RID: 10585
		[Serializable]
		public sealed class CurrencyTypeToSpriteDictionary : SerializableEnumDictionary<ECurrencyType, Sprite>
		{
		}

		// Token: 0x0200295A RID: 10586
		[Serializable]
		public sealed class TraderDialogLineSpriteDictionary : SerializableEnumDictionary<GStruct246.EDialogLiteIconType, Sprite>
		{
		}

		// Token: 0x0200295B RID: 10587
		[Serializable]
		public sealed class EffectSprites : ISerializationCallbackReceiver
		{
			// Token: 0x0600D2E7 RID: 53991 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
				throw null;
			}

			// Token: 0x0600D2E8 RID: 53992 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
				throw null;
			}

			// Token: 0x0400D487 RID: 54407
			public Sprite Painkiller;

			// Token: 0x0400D488 RID: 54408
			public Sprite Tremor;

			// Token: 0x0400D489 RID: 54409
			public Sprite Fracture;

			// Token: 0x0400D48A RID: 54410
			public Sprite Exhaustion;

			// Token: 0x0400D48B RID: 54411
			public Sprite TunnelVision;

			// Token: 0x0400D48C RID: 54412
			public Sprite Dehydration;

			// Token: 0x0400D48D RID: 54413
			public Sprite Contusion;

			// Token: 0x0400D48E RID: 54414
			public Sprite Wound;

			// Token: 0x0400D48F RID: 54415
			public Sprite LightBleeding;

			// Token: 0x0400D490 RID: 54416
			public Sprite HeavyBleeding;

			// Token: 0x0400D491 RID: 54417
			public Sprite Pain;

			// Token: 0x0400D492 RID: 54418
			public Sprite Berserk;

			// Token: 0x0400D493 RID: 54419
			public Sprite Stun;

			// Token: 0x0400D494 RID: 54420
			public Sprite StimulatorBuff;

			// Token: 0x0400D495 RID: 54421
			public Sprite StimulatorDebuff;

			// Token: 0x0400D496 RID: 54422
			public Sprite ChronicStaminaFatigue;

			// Token: 0x0400D497 RID: 54423
			public Sprite Encumbered;

			// Token: 0x0400D498 RID: 54424
			public Sprite OverEncumbered;

			// Token: 0x0400D499 RID: 54425
			public Sprite Intoxication;

			// Token: 0x0400D49A RID: 54426
			public Sprite LethalIntoxication;

			// Token: 0x0400D49B RID: 54427
			public Sprite ImmunityPreventedContamination;

			// Token: 0x0400D49C RID: 54428
			public Sprite HalloweenBuff;

			// Token: 0x0400D49D RID: 54429
			public Sprite MisfireEffect;

			// Token: 0x0400D49E RID: 54430
			public Sprite PanicEffect;

			// Token: 0x0400D49F RID: 54431
			public Sprite MildMusclePain;

			// Token: 0x0400D4A0 RID: 54432
			public Sprite SevereMusclePain;

			// Token: 0x0400D4A1 RID: 54433
			[NonSerialized]
			public readonly Dictionary<Type, Sprite> EffectIcons;
		}
	}
}
