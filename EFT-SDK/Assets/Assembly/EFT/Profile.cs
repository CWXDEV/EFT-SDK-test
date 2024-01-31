using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EFT.Counters;
using EFT.InventoryLogic;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001604 RID: 5636
	[Serializable]
	public class Profile : IProfileDataContainer, GInterface312
	{
		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A8D RID: 31373 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<string, Profile.TraderInfo> TradersInfo
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

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A8F RID: 31375 RVA: 0x00002050 File Offset: 0x00000250
		public BonusController BonusController
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

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x00002050 File Offset: 0x00000250
		public string Nickname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06007A91 RID: 31377 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x00002050 File Offset: 0x00000250
		public IInventoryProfileSkillInfo SkillsInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06007A93 RID: 31379 RVA: 0x00002050 File Offset: 0x00000250
		public Inventory InventoryInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x00002050 File Offset: 0x00000250
		public int Experience
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

		// Token: 0x06007A96 RID: 31382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ForgetInEncyclopedia(string itemId)
		{
			throw null;
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LearnInEncyclopedia(string itemId)
		{
			throw null;
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsCheckedChambers(string weaponId)
		{
			throw null;
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckChamber(string weaponId)
		{
			throw null;
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnCheckChamber(string weaponId)
		{
			throw null;
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsCheckedMagazines(string magazineId)
		{
			throw null;
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckMagazines(string magazineId, int value)
		{
			throw null;
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnCheckMagazines(string magazineId)
		{
			throw null;
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CheckMagazinesValue(string magazineId)
		{
			throw null;
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddSessionCounterLong(int examineExperience, SessionCountersClass.GClass1784 identifier)
		{
			throw null;
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06007AA0 RID: 31392 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06007AA1 RID: 31393 RVA: 0x00002050 File Offset: 0x00000250
		string IProfileDataContainer.ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06007AA2 RID: 31394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007AA3 RID: 31395 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public Profile.FenceTraderInfo FenceInfo
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

		// Token: 0x06007AA4 RID: 31396 RVA: 0x00002050 File Offset: 0x00000250
		[OnDeserialized]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerVisualRepresentation GetVisualEquipmentState(bool clone = true)
		{
			throw null;
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTraderInfo(string traderId, out Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06007AA7 RID: 31399 RVA: 0x00002050 File Offset: 0x00000250
		public int MagDrillsMastering
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400015E RID: 350
		// (add) Token: 0x06007AA8 RID: 31400 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007AA9 RID: 31401 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<string, string> OnItemZoneDropped
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

		// Token: 0x1400015F RID: 351
		// (add) Token: 0x06007AAA RID: 31402 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007AAB RID: 31403 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Profile.TraderInfo> OnTraderStandingChanged
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

		// Token: 0x14000160 RID: 352
		// (add) Token: 0x06007AAC RID: 31404 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007AAD RID: 31405 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Profile.TraderInfo> OnTraderLoyaltyChanged
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

		// Token: 0x06007AAE RID: 31406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetTraderStanding(string traderId)
		{
			throw null;
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTraderLoyalty(string traderId)
		{
			throw null;
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetExfiltrationPrice(int price)
		{
			throw null;
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3218 GetTaskConditionCounter(GInterface381 source, string conditionId)
		{
			throw null;
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06007AB2 RID: 31410 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007AB3 RID: 31411 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public ProfileStats EftStats
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

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CheckedMagazineSkillLevel(string id)
		{
			throw null;
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToCarriedQuestItems(string id)
		{
			throw null;
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00002050 File Offset: 0x00000250
		public ProfileStats.ESurvivorClass SurvivorClass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UncoverAll(string profileId = null)
		{
			throw null;
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Examined(Item item)
		{
			throw null;
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Examined(string templateId)
		{
			throw null;
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LearnAll()
		{
			throw null;
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ItemDroppedAtPlace(string itemId, string zoneId)
		{
			throw null;
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<ResourceKey> GetAllPrefabPaths(bool allCustomization = true)
		{
			throw null;
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpawnedInSession(bool value)
		{
			throw null;
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Profile Clone()
		{
			throw null;
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultFenceInfo()
		{
			throw null;
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Item item)
		{
			throw null;
		}

		// Token: 0x04007FAE RID: 32686
		[JsonProperty("_id")]
		public string Id;

		// Token: 0x04007FAF RID: 32687
		[JsonProperty("aid")]
		public string AccountId;

		// Token: 0x04007FB0 RID: 32688
		[JsonProperty("savage")]
		public string PetId;

		// Token: 0x04007FB1 RID: 32689
		public InfoClass Info;

		// Token: 0x04007FB2 RID: 32690
		public GClass1752 Customization;

		// Token: 0x04007FB3 RID: 32691
		public Dictionary<string, bool> Encyclopedia;

		// Token: 0x04007FB4 RID: 32692
		public Profile.GClass1753 Health;

		// Token: 0x04007FB5 RID: 32693
		public Inventory Inventory;

		// Token: 0x04007FB6 RID: 32694
		public QuestItemClass[] QuestItems;

		// Token: 0x04007FB7 RID: 32695
		public InsuredItemClass[] InsuredItems;

		// Token: 0x04007FB8 RID: 32696
		public SkillManager Skills;

		// Token: 0x04007FB9 RID: 32697
		public GClass2490 Notes;

		// Token: 0x04007FBA RID: 32698
		public Dictionary<string, GClass3218> TaskConditionCounters;

		// Token: 0x04007FBB RID: 32699
		[JsonProperty("Quests")]
		public List<QuestDataClass> QuestsData;

		// Token: 0x04007FBC RID: 32700
		[JsonProperty("Achievements")]
		public Dictionary<string, int> AchievementsData;

		// Token: 0x04007FBE RID: 32702
		[JsonProperty("UnlockedInfo")]
		public Profile.UnlockedInfo UnlockedRecipeInfo;

		// Token: 0x04007FBF RID: 32703
		public GClass1404[] Bonuses;

		// Token: 0x04007FC0 RID: 32704
		public HideoutInfo Hideout;

		// Token: 0x04007FC1 RID: 32705
		public GClass1861 RagfairInfo;

		// Token: 0x04007FC3 RID: 32707
		public string[] WishList;

		// Token: 0x04007FC4 RID: 32708
		private readonly ResourceKey[] _emptyResourceCollection;

		// Token: 0x04007FC9 RID: 32713
		public GClass691 Stats;

		// Token: 0x04007FCA RID: 32714
		public Dictionary<string, int> CheckedMagazines;

		// Token: 0x04007FCB RID: 32715
		public List<string> CheckedChambers;

		// Token: 0x02001605 RID: 5637
		public class GClass1753
		{
			// Token: 0x04007FCC RID: 32716
			public Dictionary<EBodyPart, Profile.GClass1753.GClass1755> BodyParts;

			// Token: 0x04007FCD RID: 32717
			public Profile.GClass1753.ValueInfo Energy;

			// Token: 0x04007FCE RID: 32718
			public Profile.GClass1753.ValueInfo Hydration;

			// Token: 0x04007FCF RID: 32719
			public Profile.GClass1753.ValueInfo Temperature;

			// Token: 0x04007FD0 RID: 32720
			public Profile.GClass1753.ValueInfo Poison;

			// Token: 0x04007FD1 RID: 32721
			public int? UpdateTime;

			// Token: 0x02001606 RID: 5638
			public class ValueInfo
			{
				// Token: 0x04007FD2 RID: 32722
				public float Current;

				// Token: 0x04007FD3 RID: 32723
				public float Minimum;

				// Token: 0x04007FD4 RID: 32724
				public float Maximum;

				// Token: 0x04007FD5 RID: 32725
				public float OverDamageReceivedMultiplier;
			}

			// Token: 0x02001607 RID: 5639
			public class GClass1754
			{
				// Token: 0x04007FD6 RID: 32726
				public float Time;

				// Token: 0x04007FD7 RID: 32727
				[JsonProperty(TypeNameHandling = TypeNameHandling.All)]
				public object ExtraData;
			}

			// Token: 0x02001608 RID: 5640
			public class GClass1755
			{
				// Token: 0x04007FD8 RID: 32728
				public Profile.GClass1753.ValueInfo Health;

				// Token: 0x04007FD9 RID: 32729
				public Dictionary<string, Profile.GClass1753.GClass1754> Effects;
			}
		}

		// Token: 0x02001609 RID: 5641
		public enum ETraderServiceSource
		{
			// Token: 0x04007FDB RID: 32731
			Lightkeeper,
			// Token: 0x04007FDC RID: 32732
			Btr,
			// Token: 0x04007FDD RID: 32733
			None = -1
		}

		// Token: 0x0200160A RID: 5642
		public class TraderInfo : BackendConfigSettingsClass.GInterface95
		{
			// Token: 0x14000161 RID: 353
			// (add) Token: 0x06007AC1 RID: 31425 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007AC2 RID: 31426 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnStandingChanged
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

			// Token: 0x14000162 RID: 354
			// (add) Token: 0x06007AC3 RID: 31427 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007AC4 RID: 31428 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnSalesSumChanged
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

			// Token: 0x14000163 RID: 355
			// (add) Token: 0x06007AC5 RID: 31429 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007AC6 RID: 31430 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnLoyaltyChanged
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

			// Token: 0x14000164 RID: 356
			// (add) Token: 0x06007AC7 RID: 31431 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007AC8 RID: 31432 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnAvailabilityChanged
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

			// Token: 0x14000165 RID: 357
			// (add) Token: 0x06007AC9 RID: 31433 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007ACA RID: 31434 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnResupplyTimeChanged
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

			// Token: 0x14000166 RID: 358
			// (add) Token: 0x06007ACB RID: 31435 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007ACC RID: 31436 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnTraderServicesUpdated
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

			// Token: 0x14000167 RID: 359
			// (add) Token: 0x06007ACD RID: 31437 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06007ACE RID: 31438 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<string, int> OnSoldToTrader
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

			// Token: 0x1700134E RID: 4942
			// (get) Token: 0x06007ACF RID: 31439 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AD0 RID: 31440 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("loyaltyLevel")]
			public int LoyaltyLevel
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

			// Token: 0x1700134F RID: 4943
			// (get) Token: 0x06007AD1 RID: 31441 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AD2 RID: 31442 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("salesSum")]
			public long SalesSum
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

			// Token: 0x17001350 RID: 4944
			// (get) Token: 0x06007AD3 RID: 31443 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AD4 RID: 31444 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("standing")]
			public double Standing
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

			// Token: 0x17001351 RID: 4945
			// (get) Token: 0x06007AD5 RID: 31445 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AD6 RID: 31446 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("nextResupply")]
			public int NextResupply
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

			// Token: 0x17001352 RID: 4946
			// (get) Token: 0x06007AD7 RID: 31447 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AD8 RID: 31448 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("disabled")]
			public bool Disabled
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

			// Token: 0x17001353 RID: 4947
			// (get) Token: 0x06007AD9 RID: 31449 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public bool Available
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001354 RID: 4948
			// (get) Token: 0x06007ADA RID: 31450 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007ADB RID: 31451 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public string Id
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

			// Token: 0x17001355 RID: 4949
			// (get) Token: 0x06007ADC RID: 31452 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public int ProfileLevel
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001356 RID: 4950
			// (get) Token: 0x06007ADD RID: 31453 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007ADE RID: 31454 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public BackendConfigSettingsClass.TraderSettings Settings
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

			// Token: 0x17001357 RID: 4951
			// (get) Token: 0x06007ADF RID: 31455 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AE0 RID: 31456 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public BackendConfigSettingsClass.TraderLoyaltyLevel CurrentLoyalty
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

			// Token: 0x17001358 RID: 4952
			// (get) Token: 0x06007AE1 RID: 31457 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public int MaxLoyaltyLevel
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001359 RID: 4953
			// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public virtual double SellToTraderPriceModifier
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06007AE3 RID: 31459 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetSoldToTraderItem(string templateId, int count)
			{
				throw null;
			}

			// Token: 0x06007AE4 RID: 31460 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual double ApplyPriceModifier(double basePrice)
			{
				throw null;
			}

			// Token: 0x06007AE5 RID: 31461 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Init(string traderId, InfoClass profileInfo)
			{
				throw null;
			}

			// Token: 0x06007AE6 RID: 31462 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsServiceAvailable(ETraderServiceType serviceType)
			{
				throw null;
			}

			// Token: 0x06007AE7 RID: 31463 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsServiceAlreadyPurchased(ETraderServiceType serviceType)
			{
				throw null;
			}

			// Token: 0x06007AE8 RID: 31464 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetServiceAvailability(ETraderServiceType serviceType, bool availabilityState, bool wasPurchasedInRaid)
			{
				throw null;
			}

			// Token: 0x06007AE9 RID: 31465 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CanBuyItem(Item item)
			{
				throw null;
			}

			// Token: 0x06007AEA RID: 31466 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CanBuyItem(ItemTemplate itemTemplate)
			{
				throw null;
			}

			// Token: 0x06007AEB RID: 31467 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CanBuyRootItem(Item item, out IReadOnlyList<Item> unsellableParts)
			{
				throw null;
			}

			// Token: 0x06007AEC RID: 31468 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool TryGetNextLoyalty(out BackendConfigSettingsClass.TraderLoyaltyLevel nextLoyalty)
			{
				throw null;
			}

			// Token: 0x06007AED RID: 31469 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void UpdateLevel()
			{
				throw null;
			}

			// Token: 0x06007AEE RID: 31470 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(EBanType banType = EBanType.Trading)
			{
				throw null;
			}

			// Token: 0x06007AEF RID: 31471 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetStanding(double value)
			{
				throw null;
			}

			// Token: 0x06007AF0 RID: 31472 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetSalesSum(long value)
			{
				throw null;
			}

			// Token: 0x06007AF1 RID: 31473 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetUnlocked(bool unlocked)
			{
				throw null;
			}

			// Token: 0x06007AF2 RID: 31474 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetDisabled(bool disabled)
			{
				throw null;
			}

			// Token: 0x06007AF3 RID: 31475 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetResupplyTime(int resupplyTime)
			{
				throw null;
			}

			// Token: 0x06007AF4 RID: 31476 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1(int _, int __)
			{
				throw null;
			}

			// Token: 0x06007AF5 RID: 31477 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_2(Item subItem)
			{
				throw null;
			}

			// Token: 0x04007FDE RID: 32734
			private const int DEFAULT_MAX_LOYALTY_LEVEL = 4;

			// Token: 0x04007FDF RID: 32735
			public const string LIGHT_KEEPER_TRADER_ID = "638f541a29ffd1183d187f57";

			// Token: 0x04007FE0 RID: 32736
			public const string BTR_TRADER_ID = "656f0f98d80a697f855d34b1";

			// Token: 0x04007FE1 RID: 32737
			public const float LIGHTHOUSE_KEEPER_SERVICES_SCREW_UP_STANDING = 0.01f;

			// Token: 0x04007FE2 RID: 32738
			public static readonly Dictionary<Profile.ETraderServiceSource, string> TraderServiceToId;

			// Token: 0x04007FEA RID: 32746
			[JsonProperty("unlocked")]
			public bool Unlocked;

			// Token: 0x04007FEB RID: 32747
			private InfoClass _profileInfo;

			// Token: 0x04007FEC RID: 32748
			private bool _banned;

			// Token: 0x04007FED RID: 32749
			private readonly HashSet<ETraderServiceType> _availableServices;

			// Token: 0x04007FEE RID: 32750
			private readonly HashSet<ETraderServiceType> _alreadyPurchasedServices;

			// Token: 0x0200160B RID: 5643
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1154
			{
				// Token: 0x06007AF6 RID: 31478 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(Item subItem)
				{
					throw null;
				}

				// Token: 0x04007FEF RID: 32751
				public static readonly Profile.TraderInfo.Class1154 class1154_0;

				// Token: 0x04007FF0 RID: 32752
				public static Func<Item, bool> func_0;
			}
		}

		// Token: 0x0200160C RID: 5644
		public sealed class FenceTraderInfo : Profile.TraderInfo
		{
			// Token: 0x1700135A RID: 4954
			// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007AF8 RID: 31480 RVA: 0x00002050 File Offset: 0x00000250
			[JsonIgnore]
			public BackendConfigSettingsClass.FenceLoyaltyLevel FenceLoyalty
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

			// Token: 0x1700135B RID: 4955
			// (get) Token: 0x06007AF9 RID: 31481 RVA: 0x00002050 File Offset: 0x00000250
			public int AvailableExitsCount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700135C RID: 4956
			// (get) Token: 0x06007AFA RID: 31482 RVA: 0x00002050 File Offset: 0x00000250
			public double FenceLoyaltyPriceModifier
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06007AFB RID: 31483 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override double ApplyPriceModifier(double basePrice)
			{
				throw null;
			}

			// Token: 0x06007AFC RID: 31484 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void UpdateLevel()
			{
				throw null;
			}

			// Token: 0x06007AFD RID: 31485 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int NewExfiltrationPrice(int price)
			{
				throw null;
			}

			// Token: 0x06007AFE RID: 31486 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddStanding(double dif, EFenceStandingSource standingSource)
			{
				throw null;
			}

			// Token: 0x06007AFF RID: 31487 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetStanding(double value)
			{
				throw null;
			}

			// Token: 0x04007FF1 RID: 32753
			private readonly BackendConfigSettingsClass.FenceGlobalSettings _fenceSettings;

			// Token: 0x04007FF2 RID: 32754
			private readonly SessionCountersClass _sessionCounters;

			// Token: 0x04007FF3 RID: 32755
			private readonly float _charismaFenceDiscount;
		}

		// Token: 0x0200160D RID: 5645
		[Serializable]
		public class UnlockedInfo
		{
			// Token: 0x04007FF4 RID: 32756
			[JsonProperty("unlockedProductionRecipe")]
			public List<string> unlockedSchemeList;
		}

		// Token: 0x0200160E RID: 5646
		[CompilerGenerated]
		private sealed class Class1155
		{
			// Token: 0x06007B00 RID: 31488 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Profile.TraderInfo method_0(KeyValuePair<string, Profile.TraderInfo> traderInfo)
			{
				throw null;
			}

			// Token: 0x04007FF5 RID: 32757
			public string fenceId;

			// Token: 0x04007FF6 RID: 32758
			public Profile profile_0;
		}

		// Token: 0x0200160F RID: 5647
		[CompilerGenerated]
		private sealed class Class1156
		{
			// Token: 0x06007B01 RID: 31489 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06007B02 RID: 31490 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04007FF7 RID: 32759
			public Profile.TraderInfo traderInfo;

			// Token: 0x04007FF8 RID: 32760
			public Profile.Class1155 class1155_0;
		}

		// Token: 0x02001610 RID: 5648
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1157
		{
			// Token: 0x06007B03 RID: 31491 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(KeyValuePair<string, Profile.TraderInfo> traderInfo)
			{
				throw null;
			}

			// Token: 0x06007B04 RID: 31492 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<ResourceKey> method_1(Item x)
			{
				throw null;
			}

			// Token: 0x04007FF9 RID: 32761
			public static readonly Profile.Class1157 class1157_0;

			// Token: 0x04007FFA RID: 32762
			public static Func<KeyValuePair<string, Profile.TraderInfo>, string> func_0;

			// Token: 0x04007FFB RID: 32763
			public static Func<Item, IEnumerable<ResourceKey>> func_1;
		}

		// Token: 0x02001611 RID: 5649
		[CompilerGenerated]
		private sealed class Class1158
		{
			// Token: 0x06007B05 RID: 31493 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<EBodyModelPart, string> x)
			{
				throw null;
			}

			// Token: 0x06007B06 RID: 31494 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_1(KeyValuePair<EBodyModelPart, string> x)
			{
				throw null;
			}

			// Token: 0x04007FFC RID: 32764
			public bool allCustomization;

			// Token: 0x04007FFD RID: 32765
			public GClass1441 customizationSolver;
		}
	}
}
