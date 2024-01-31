using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using Diz.LanguageExtensions;
using EFT.Quests;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x02002456 RID: 9302
	public class Inventory
	{
		// Token: 0x0600BAEB RID: 47851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTotalWeight(EventArgs args = null)
		{
			throw null;
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<Item> GetAllItemByTemplate(string templateId)
		{
			throw null;
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600BAED RID: 47853 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<Item> AllRealPlayerItems
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x00002050 File Offset: 0x00000250
		public List<string> EquippedInSlotsTemplateIds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CreateInventoryHashSum(EquipmentSlot[] excludedSLots = null)
		{
			throw null;
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<Item> GetPlayerItems(EPlayerItems itemsMask = EPlayerItems.All)
		{
			throw null;
		}

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct338 CreateDetailedInventoryHashSum(EquipmentSlot[] excludedSLots = null)
		{
			throw null;
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<Item> GetItemsInSlots(EquipmentSlot[] slots)
		{
			throw null;
		}

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPutOnArmorsNonAlloc([NotNull] List<ArmorComponent> armorComponents)
		{
			throw null;
		}

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_0(ArmorComponent first, ArmorComponent second)
		{
			throw null;
		}

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_1(ArmorComponent armorComponent)
		{
			throw null;
		}

		// Token: 0x0600BAF6 RID: 47862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EquipmentPenaltyComponent GetPutOnBackpack()
		{
			throw null;
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<ArmorComponent> GetPutOnArmors()
		{
			throw null;
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<Item> GetWeaponAssembly(IEnumerable<Item> collection, ConditionWeaponAssembly condition, bool displayLog = false)
		{
			throw null;
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsWeaponFitsCondition(Weapon weapon, ConditionWeaponAssembly condition, bool displayLog = false)
		{
			throw null;
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_2(LootItemClass weapon, [CanBeNull] string[] types)
		{
			throw null;
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_3(LootItemClass weapon, [CanBeNull] string[] itemIds)
		{
			throw null;
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_4(float current, GClass3219 parameter, Weapon weapon, string name, bool displayLog)
		{
			throw null;
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1()
		{
			throw null;
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Item method_2(EquipmentSlot x)
		{
			throw null;
		}

		// Token: 0x0400BD6A RID: 48490
		public EquipmentClass Equipment;

		// Token: 0x0400BD6B RID: 48491
		public StashClass Stash;

		// Token: 0x0400BD6C RID: 48492
		public StashClass QuestRaidItems;

		// Token: 0x0400BD6D RID: 48493
		public StashClass QuestStashItems;

		// Token: 0x0400BD6E RID: 48494
		public Dictionary<EAreaType, LootItemClass> HideoutAreaStashes;

		// Token: 0x0400BD6F RID: 48495
		public SortingTableClass SortingTable;

		// Token: 0x0400BD70 RID: 48496
		public GClass2515 FastAccess;

		// Token: 0x0400BD71 RID: 48497
		public GClass751<float> TotalWeight;

		// Token: 0x0400BD72 RID: 48498
		public GClass751<float> TotalWeightEliteSkill;

		// Token: 0x0400BD73 RID: 48499
		public List<Error> DeserializationErrors;

		// Token: 0x0400BD74 RID: 48500
		public Dictionary<string, int> DiscardLimits;

		// Token: 0x0400BD75 RID: 48501
		private readonly List<Slot> _preallocatedSlotsList;

		// Token: 0x0400BD76 RID: 48502
		public GClass1742 FavoriteItemsStorage;

		// Token: 0x0400BD77 RID: 48503
		public LootItemClass CurrentActiveHideoutAreaStash;

		// Token: 0x0400BD78 RID: 48504
		public Action<EAreaType> OnAreaStashUpdate;

		// Token: 0x0400BD79 RID: 48505
		[NonSerialized]
		public BindableEvent OnWeightUpdated;

		// Token: 0x0400BD7A RID: 48506
		public static readonly EquipmentSlot[] BindAvailableSlotsExtended;

		// Token: 0x0400BD7B RID: 48507
		public static readonly EquipmentSlot[] ArmorSlots;

		// Token: 0x0400BD7C RID: 48508
		public static readonly EquipmentSlot[] FastAccessSlots;

		// Token: 0x02002457 RID: 9303
		[CompilerGenerated]
		private sealed class Class2052
		{
			// Token: 0x0600BB00 RID: 47872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item x)
			{
				throw null;
			}

			// Token: 0x0400BD7D RID: 48509
			public string templateId;
		}

		// Token: 0x02002458 RID: 9304
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2053
		{
			// Token: 0x0600BB01 RID: 47873 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0600BB02 RID: 47874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BB03 RID: 47875 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BB04 RID: 47876 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(Weapon x)
			{
				throw null;
			}

			// Token: 0x0600BB05 RID: 47877 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Type method_4(string cat)
			{
				throw null;
			}

			// Token: 0x0600BB06 RID: 47878 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(Slot slot)
			{
				throw null;
			}

			// Token: 0x0600BB07 RID: 47879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BB08 RID: 47880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_7(Slot x)
			{
				throw null;
			}

			// Token: 0x0400BD7E RID: 48510
			public static readonly Inventory.Class2053 class2053_0;

			// Token: 0x0400BD7F RID: 48511
			public static Func<Item, bool> func_0;

			// Token: 0x0400BD80 RID: 48512
			public static Func<Slot, bool> func_1;

			// Token: 0x0400BD81 RID: 48513
			public static Func<Slot, string> func_2;

			// Token: 0x0400BD82 RID: 48514
			public static Func<Weapon, bool> func_3;

			// Token: 0x0400BD83 RID: 48515
			public static Func<string, Type> func_4;

			// Token: 0x0400BD84 RID: 48516
			public static Func<Slot, bool> func_5;

			// Token: 0x0400BD85 RID: 48517
			public static Func<Slot, bool> func_6;

			// Token: 0x0400BD86 RID: 48518
			public static Func<Slot, string> func_7;
		}

		// Token: 0x02002459 RID: 9305
		[CompilerGenerated]
		private sealed class Class2054
		{
			// Token: 0x0600BB09 RID: 47881 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Weapon x)
			{
				throw null;
			}

			// Token: 0x0600BB0A RID: 47882 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x0400BD87 RID: 48519
			public ConditionWeaponAssembly condition;

			// Token: 0x0400BD88 RID: 48520
			public bool displayLog;
		}

		// Token: 0x0200245A RID: 9306
		[CompilerGenerated]
		private sealed class Class2055
		{
			// Token: 0x0600BB0B RID: 47883 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Slot slot)
			{
				throw null;
			}

			// Token: 0x0400BD89 RID: 48521
			public Type type;
		}

		// Token: 0x0200245B RID: 9307
		[CompilerGenerated]
		private sealed class Class2056
		{
			// Token: 0x0600BB0C RID: 47884 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(string itemId)
			{
				throw null;
			}

			// Token: 0x0400BD8A RID: 48522
			public string[] slots;
		}
	}
}
