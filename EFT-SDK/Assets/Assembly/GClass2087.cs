using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02001D87 RID: 7559
public sealed class GClass2087
{
	// Token: 0x140001E1 RID: 481
	// (add) Token: 0x06009BD6 RID: 39894 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009BD7 RID: 39895 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnSuccessfulRepairChangedEvent
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

	// Token: 0x17001870 RID: 6256
	// (get) Token: 0x06009BD8 RID: 39896 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<TraderClass> TraderRepairers
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001871 RID: 6257
	// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x00002050 File Offset: 0x00000250
	private HideoutClass GClass1904_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009BDA RID: 39898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasEliteNoWearRepair(Item item)
	{
		throw null;
	}

	// Token: 0x06009BDB RID: 39899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Item item, out GClass2087.Class1762 repairParameters)
	{
		throw null;
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRepairUnlocked(Item item)
	{
		throw null;
	}

	// Token: 0x06009BDD RID: 39901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEligibleForBuff(Item item)
	{
		throw null;
	}

	// Token: 0x06009BDE RID: 39902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass799> GetSuitableRepairersCollections(Item itemToRepair)
	{
		throw null;
	}

	// Token: 0x06009BDF RID: 39903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass799> GetSuitableRepairersCollections(IEnumerable<Item> itemsToRepair)
	{
		throw null;
	}

	// Token: 0x06009BE0 RID: 39904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetRepairPrice(RepairKitClass repairKitTemplate, double repairValue, Item itemToRepair)
	{
		throw null;
	}

	// Token: 0x06009BE1 RID: 39905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItem)
	{
		throw null;
	}

	// Token: 0x06009BE2 RID: 39906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetBaseRepairQuality(Item item)
	{
		throw null;
	}

	// Token: 0x06009BE3 RID: 39907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetBaseRepairQualityForDisplay(Item item)
	{
		throw null;
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetBaseRepairPriceCoefficient(Item item)
	{
		throw null;
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEnhancementChance(Item item, float durabilityToRestorePercent, out double enhancementChance)
	{
		throw null;
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass799 CreateRepairKitsCollection(GClass2726 repairKit)
	{
		throw null;
	}

	// Token: 0x06009BE7 RID: 39911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<GClass799> method_1(Predicate<GClass2726> predicate)
	{
		throw null;
	}

	// Token: 0x0400A311 RID: 41745
	private const string string_0 = "5422acb9af1c889c16000029";

	// Token: 0x0400A312 RID: 41746
	private const string string_1 = "57bef4c42459772e8d35a53b";

	// Token: 0x0400A313 RID: 41747
	private const string string_2 = "5448e5284bdc2dcb718b4567";

	// Token: 0x0400A314 RID: 41748
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400A315 RID: 41749
	public static readonly BackendConfigSettingsClass.GlobalSkillsSettings SkillsSettings;

	// Token: 0x0400A316 RID: 41750
	public static readonly float IntellectWearChanceReducePerLevel;

	// Token: 0x0400A317 RID: 41751
	public static readonly float WeaponTreatmentWearChanceReducePerLevel;

	// Token: 0x0400A318 RID: 41752
	public static readonly float MinimumLevelToApplyBuff;

	// Token: 0x0400A319 RID: 41753
	public static readonly float LightVestWearChanceReducePerLevel;

	// Token: 0x0400A31A RID: 41754
	public static readonly float HeavyVestWearChanceReducePerLevel;

	// Token: 0x0400A31B RID: 41755
	private readonly GClass2087.Class1762 class1762_0;

	// Token: 0x0400A31C RID: 41756
	private readonly GClass2087.Class1762 class1762_1;

	// Token: 0x0400A31D RID: 41757
	private readonly GClass2087.Class1762 class1762_2;

	// Token: 0x0400A31E RID: 41758
	private readonly GClass2087.Class1762 class1762_3;

	// Token: 0x0400A31F RID: 41759
	private readonly Profile profile_0;

	// Token: 0x0400A320 RID: 41760
	private readonly Inventory inventory_0;

	// Token: 0x0400A321 RID: 41761
	private readonly Dictionary<string, bool> dictionary_0;

	// Token: 0x0400A322 RID: 41762
	private readonly ISession ginterface145_0;

	// Token: 0x0400A323 RID: 41763
	private SkillManager skillManager_0;

	// Token: 0x0400A324 RID: 41764
	private List<GClass2726> list_0;

	// Token: 0x0400A325 RID: 41765
	[CompilerGenerated]
	private readonly IEnumerable<TraderClass> ienumerable_0;

	// Token: 0x02001D88 RID: 7560
	private sealed class Class1762
	{
		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06009BE8 RID: 39912 RVA: 0x00002050 File Offset: 0x00000250
		public double GetWearReduce
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06009BE9 RID: 39913 RVA: 0x00002050 File Offset: 0x00000250
		public double GetMaxWearReduce
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasBuffs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x00002050 File Offset: 0x00000250
		public int GetSkillLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06009BEC RID: 39916 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasEliteNoWearRepair
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetEnhancementBonus(float durabilityToRestorePercent)
		{
			throw null;
		}

		// Token: 0x06009BEE RID: 39918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private double method_0(float receiveDurabilityMaxPercent, float receiveDurabilityPercent)
		{
			throw null;
		}

		// Token: 0x0400A326 RID: 41766
		public readonly EBonusType UnlockBonus;

		// Token: 0x0400A327 RID: 41767
		public readonly EBonusType EfficiencyBonus;

		// Token: 0x0400A328 RID: 41768
		public readonly ESkillId SkillType;

		// Token: 0x0400A329 RID: 41769
		private readonly SkillManager skillManager_0;

		// Token: 0x0400A32A RID: 41770
		private readonly double double_0;

		// Token: 0x0400A32B RID: 41771
		[CanBeNull]
		private readonly BackendConfigSettingsClass.GClass1342 gclass1342_0;

		// Token: 0x0400A32C RID: 41772
		private readonly SkillManager.GClass1775 gclass1775_0;
	}

	// Token: 0x02001D89 RID: 7561
	[CompilerGenerated]
	private sealed class Class1763
	{
		// Token: 0x06009BEF RID: 39919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2726 repairKit)
		{
			throw null;
		}

		// Token: 0x0400A32D RID: 41773
		public Item itemToRepair;
	}

	// Token: 0x02001D8A RID: 7562
	[CompilerGenerated]
	private sealed class Class1764
	{
		// Token: 0x06009BF0 RID: 39920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2726 repairKit)
		{
			throw null;
		}

		// Token: 0x0400A32E RID: 41774
		public IEnumerable<Item> itemsToRepair;
	}
}
