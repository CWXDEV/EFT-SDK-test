using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.Hideout;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UI.Hideout;

// Token: 0x02001AB7 RID: 6839
public sealed class HideoutClass : GInterface147
{
	// Token: 0x140001A0 RID: 416
	// (add) Token: 0x06009002 RID: 36866 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009003 RID: 36867 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnItemsChanged
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

	// Token: 0x140001A1 RID: 417
	// (add) Token: 0x06009004 RID: 36868 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009005 RID: 36869 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> OnItemChanged
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

	// Token: 0x140001A2 RID: 418
	// (add) Token: 0x06009006 RID: 36870 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009007 RID: 36871 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnAreaUpdated
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

	// Token: 0x140001A3 RID: 419
	// (add) Token: 0x06009008 RID: 36872 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009009 RID: 36873 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1912, string> OnProducedItemsReceived
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

	// Token: 0x140001A4 RID: 420
	// (add) Token: 0x0600900A RID: 36874 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600900B RID: 36875 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnInited
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

	// Token: 0x170015DA RID: 5594
	// (get) Token: 0x0600900C RID: 36876 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<Item> AllStashItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170015DB RID: 5595
	// (get) Token: 0x0600900D RID: 36877 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600900E RID: 36878 RVA: 0x00002050 File Offset: 0x00000250
	public EnergyControllerClass EnergyController
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

	// Token: 0x170015DC RID: 5596
	// (get) Token: 0x0600900F RID: 36879 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009010 RID: 36880 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1920[] ProductionSchemes
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

	// Token: 0x170015DD RID: 5597
	// (get) Token: 0x06009011 RID: 36881 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009012 RID: 36882 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsClientBusy
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

	// Token: 0x170015DE RID: 5598
	// (get) Token: 0x06009013 RID: 36883 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009014 RID: 36884 RVA: 0x00002050 File Offset: 0x00000250
	private GClass1921[] GClass1921_0
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

	// Token: 0x170015DF RID: 5599
	// (get) Token: 0x06009015 RID: 36885 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009016 RID: 36886 RVA: 0x00002050 File Offset: 0x00000250
	public ProductionControllerClass ProductionController
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

	// Token: 0x170015E0 RID: 5600
	// (get) Token: 0x06009017 RID: 36887 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009018 RID: 36888 RVA: 0x00002050 File Offset: 0x00000250
	public ImprovementControllerClass ImprovementController
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

	// Token: 0x170015E1 RID: 5601
	// (get) Token: 0x06009019 RID: 36889 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600901A RID: 36890 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1905 Settings
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

	// Token: 0x170015E2 RID: 5602
	// (get) Token: 0x0600901B RID: 36891 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600901C RID: 36892 RVA: 0x00002050 File Offset: 0x00000250
	private AreaInfo[] AreaInfo_0
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

	// Token: 0x170015E3 RID: 5603
	// (get) Token: 0x0600901D RID: 36893 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600901E RID: 36894 RVA: 0x00002050 File Offset: 0x00000250
	private AreaTemplate[] AreaTemplate_0
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

	// Token: 0x170015E4 RID: 5604
	// (get) Token: 0x0600901F RID: 36895 RVA: 0x00002050 File Offset: 0x00000250
	public List<AreaData> AreaDatas
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170015E5 RID: 5605
	// (get) Token: 0x06009020 RID: 36896 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009021 RID: 36897 RVA: 0x00002050 File Offset: 0x00000250
	public EEventType[] Events
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06009022 RID: 36898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Init(ISession session)
	{
		throw null;
	}

	// Token: 0x06009023 RID: 36899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06009024 RID: 36900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateProduction(Dictionary<string, ProductionData> productionDataChanges)
	{
		throw null;
	}

	// Token: 0x06009025 RID: 36901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateImprovements(Dictionary<string, GClass1910> improvements)
	{
		throw null;
	}

	// Token: 0x06009026 RID: 36902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInventoryController(InventoryControllerClass inventoryController, HealthControllerClass healthController, GClass3205 questController, AbstractAchievementControllerClass achievementsController)
	{
		throw null;
	}

	// Token: 0x06009027 RID: 36903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(AreaData areaData)
	{
		throw null;
	}

	// Token: 0x06009028 RID: 36904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(AreaData areaData)
	{
		throw null;
	}

	// Token: 0x06009029 RID: 36905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(AreaData areaData)
	{
		throw null;
	}

	// Token: 0x0600902A RID: 36906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetMaxBonus(EBonusType bonusType, double input)
	{
		throw null;
	}

	// Token: 0x0600902B RID: 36907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyChanges()
	{
		throw null;
	}

	// Token: 0x0600902C RID: 36908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass1763 skill)
	{
		throw null;
	}

	// Token: 0x0600902D RID: 36909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Profile.TraderInfo traderInfo)
	{
		throw null;
	}

	// Token: 0x0600902E RID: 36910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x0600902F RID: 36911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06009030 RID: 36912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x06009031 RID: 36913 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(Dictionary<int, Stage> stages, AreaTemplate areaTemplate, IEnumerable<QteData> areaQteDatas)
	{
		throw null;
	}

	// Token: 0x06009032 RID: 36914 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(EAreaType type, bool selected)
	{
		throw null;
	}

	// Token: 0x06009033 RID: 36915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(Stage stage, int level, EAreaType type)
	{
		throw null;
	}

	// Token: 0x06009034 RID: 36916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<GClass1919> method_12(EAreaType type)
	{
		throw null;
	}

	// Token: 0x06009035 RID: 36917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(AreaData data, AreaInfo areaInfo, EAreaType type, Profile profile)
	{
		throw null;
	}

	// Token: 0x06009036 RID: 36918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14(bool isPowerOn)
	{
		throw null;
	}

	// Token: 0x06009037 RID: 36919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<GStruct241> method_15(ItemRequirement[] requirements)
	{
		throw null;
	}

	// Token: 0x06009038 RID: 36920 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<GInterface322> method_16(IEnumerable<GStruct241> references)
	{
		throw null;
	}

	// Token: 0x06009039 RID: 36921 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<GInterface322> method_17(IEnumerable<GClass1223> items)
	{
		throw null;
	}

	// Token: 0x0600903A RID: 36922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18()
	{
		throw null;
	}

	// Token: 0x0600903B RID: 36923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19()
	{
		throw null;
	}

	// Token: 0x0600903C RID: 36924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(GEventArgs2 args)
	{
		throw null;
	}

	// Token: 0x0600903D RID: 36925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(GEventArgs3 args)
	{
		throw null;
	}

	// Token: 0x0600903E RID: 36926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22(GEventArgs22 args)
	{
		throw null;
	}

	// Token: 0x0600903F RID: 36927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task UpgradeZone(EAreaType areaType, RelatedRequirements requirements)
	{
		throw null;
	}

	// Token: 0x06009040 RID: 36928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CompleteUpgradeZone(EAreaType areaType)
	{
		throw null;
	}

	// Token: 0x06009041 RID: 36929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<T> GetAvailableItemsByFilter<T>(IEnumerable<string> templateIdFilter = null, Func<Item, bool> predicate = null) where T : Item
	{
		throw null;
	}

	// Token: 0x06009042 RID: 36930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutItemInAreaSlot(EAreaType areaType, int slotIndex, Item item, int count = 1)
	{
		throw null;
	}

	// Token: 0x06009043 RID: 36931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutManyInAreaSlots(EAreaType areaType, Dictionary<int, GStruct241> slotItems, Action onComplete)
	{
		throw null;
	}

	// Token: 0x06009044 RID: 36932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TakeItemsFromAreaSlot(EAreaType areaType, int slotIndex, string itemTemplate, Action onComplete = null)
	{
		throw null;
	}

	// Token: 0x06009045 RID: 36933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RestartProduction(GClass1919 scheme)
	{
		throw null;
	}

	// Token: 0x06009046 RID: 36934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> CancelProduction(GClass1919 scheme)
	{
		throw null;
	}

	// Token: 0x06009047 RID: 36935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task StartSingleProduction(GClass1919 scheme, Action callback)
	{
		throw null;
	}

	// Token: 0x06009048 RID: 36936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task StartScavCaseProduction(string schemeId, ItemRequirement[] requirements)
	{
		throw null;
	}

	// Token: 0x06009049 RID: 36937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> GetProducedItems(GClass1912 producer, string schemeId, bool showItemsListWindow)
	{
		throw null;
	}

	// Token: 0x0600904A RID: 36938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartContinuousProduction(string schemeId)
	{
		throw null;
	}

	// Token: 0x0600904B RID: 36939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600904C RID: 36940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23()
	{
		throw null;
	}

	// Token: 0x0600904D RID: 36941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_24(bool decide)
	{
		throw null;
	}

	// Token: 0x0600904E RID: 36942 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_25(bool decide)
	{
		throw null;
	}

	// Token: 0x0600904F RID: 36943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_26(HealthControllerClass healthController)
	{
		throw null;
	}

	// Token: 0x06009050 RID: 36944 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_27(HealthControllerClass healthController)
	{
		throw null;
	}

	// Token: 0x06009051 RID: 36945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_28(bool decide)
	{
		throw null;
	}

	// Token: 0x06009052 RID: 36946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task StartImprovement(GClass1908 improvement, EAreaType areaType)
	{
		throw null;
	}

	// Token: 0x06009053 RID: 36947 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<IEnumerable<GClass1860>> method_29(ItemRequirement[] requirements)
	{
		throw null;
	}

	// Token: 0x06009054 RID: 36948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_30()
	{
		throw null;
	}

	// Token: 0x06009055 RID: 36949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31()
	{
		throw null;
	}

	// Token: 0x06009056 RID: 36950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateWeapon(HideoutPlayerOwner owner)
	{
		throw null;
	}

	// Token: 0x06009057 RID: 36951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetShootingRangeScore()
	{
		throw null;
	}

	// Token: 0x06009058 RID: 36952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetShootingRangeScore(int value)
	{
		throw null;
	}

	// Token: 0x06009059 RID: 36953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WorkoutOperation(IEnumerable<bool> qtesResult, string qteId)
	{
		throw null;
	}

	// Token: 0x0600905A RID: 36954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InQteRandomChance(float chance)
	{
		throw null;
	}

	// Token: 0x0600905B RID: 36955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int QteRandomNext(int min, int max)
	{
		throw null;
	}

	// Token: 0x0600905C RID: 36956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAreaItemsTransferScreen(EAreaType areaType, Action exitAction = null)
	{
		throw null;
	}

	// Token: 0x0600905D RID: 36957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowInventoryScreen(Action exitAction = null)
	{
		throw null;
	}

	// Token: 0x0600905E RID: 36958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AreaData InitHideoutArea(EAreaType type, HideoutArea area)
	{
		throw null;
	}

	// Token: 0x0600905F RID: 36959 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32(List<Item> itemsBuffer, ItemRequirement requirement)
	{
		throw null;
	}

	// Token: 0x06009060 RID: 36960 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33(IResult result)
	{
		throw null;
	}

	// Token: 0x04009738 RID: 38712
	public const string NO_FREE_SPACE_TITLE = "no_free_space_title";

	// Token: 0x04009739 RID: 38713
	public const string NO_FREE_SPACE_MESSAGE = "no_free_space_message";

	// Token: 0x0400973A RID: 38714
	private const float float_0 = 0.5f;

	// Token: 0x0400973B RID: 38715
	private static readonly GClass3019 gclass3019_0;

	// Token: 0x0400973C RID: 38716
	private static readonly List<Item> list_0;

	// Token: 0x0400973D RID: 38717
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400973E RID: 38718
	[CompilerGenerated]
	private Action<Item> action_1;

	// Token: 0x0400973F RID: 38719
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x04009740 RID: 38720
	[CompilerGenerated]
	private Action<GClass1912, string> action_3;

	// Token: 0x04009741 RID: 38721
	[CompilerGenerated]
	private Action action_4;

	// Token: 0x04009742 RID: 38722
	private AreaTemplate[] areaTemplate_0;

	// Token: 0x04009743 RID: 38723
	private InventoryControllerClass gclass2757_0;

	// Token: 0x04009744 RID: 38724
	private ISession ginterface145_0;

	// Token: 0x04009745 RID: 38725
	private GClass1906 gclass1906_0;

	// Token: 0x04009746 RID: 38726
	private BonusController bonusController_0;

	// Token: 0x04009747 RID: 38727
	private GClass3204 gclass3204_0;

	// Token: 0x04009748 RID: 38728
	private AbstractAchievementControllerClass gclass3207_0;

	// Token: 0x04009749 RID: 38729
	private readonly List<GInterface147> list_1;

	// Token: 0x0400974A RID: 38730
	private readonly List<Item> list_2;

	// Token: 0x0400974B RID: 38731
	private readonly List<Item> list_3;

	// Token: 0x0400974C RID: 38732
	private readonly List<Item> list_4;

	// Token: 0x0400974D RID: 38733
	private readonly GClass763 gclass763_0;

	// Token: 0x0400974E RID: 38734
	private List<Requirement> list_5;

	// Token: 0x0400974F RID: 38735
	private Dictionary<EAreaType, AreaData> dictionary_0;

	// Token: 0x04009750 RID: 38736
	private List<AreaData> list_6;

	// Token: 0x04009751 RID: 38737
	private bool bool_0;

	// Token: 0x04009752 RID: 38738
	private bool bool_1;

	// Token: 0x04009753 RID: 38739
	private AreaInfo areaInfo_0;

	// Token: 0x04009754 RID: 38740
	private AreaData areaData_0;

	// Token: 0x04009755 RID: 38741
	private bool bool_2;

	// Token: 0x04009756 RID: 38742
	private QteData[] qteData_0;

	// Token: 0x04009757 RID: 38743
	private int int_0;

	// Token: 0x04009758 RID: 38744
	private GClass2146 gclass2146_0;

	// Token: 0x04009759 RID: 38745
	[CompilerGenerated]
	private EnergyControllerClass gclass1901_0;

	// Token: 0x0400975A RID: 38746
	[CompilerGenerated]
	private GClass1920[] gclass1920_0;

	// Token: 0x0400975B RID: 38747
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x0400975C RID: 38748
	[CompilerGenerated]
	private GClass1921[] gclass1921_0;

	// Token: 0x0400975D RID: 38749
	[CompilerGenerated]
	private ProductionControllerClass gclass1917_0;

	// Token: 0x0400975E RID: 38750
	[CompilerGenerated]
	private ImprovementControllerClass gclass1909_0;

	// Token: 0x0400975F RID: 38751
	[CompilerGenerated]
	private GClass1905 gclass1905_0;

	// Token: 0x04009760 RID: 38752
	[CompilerGenerated]
	private AreaInfo[] areaInfo_1;

	// Token: 0x04009761 RID: 38753
	[CompilerGenerated]
	private AreaTemplate[] areaTemplate_1;

	// Token: 0x04009762 RID: 38754
	private HealthControllerClass gclass2415_0;

	// Token: 0x04009763 RID: 38755
	private EEventType[] eeventType_0;

	// Token: 0x02001AB8 RID: 6840
	internal sealed class Class348 : LoggerClass
	{
		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06009061 RID: 36961 RVA: 0x00002050 File Offset: 0x00000250
		public static HideoutClass.Class348 Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009764 RID: 38756
		private const string string_0 = "hideout";
	}

	// Token: 0x02001AB9 RID: 6841
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1602
	{
		// Token: 0x06009062 RID: 36962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaInfo x)
		{
			throw null;
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(QteHandleData qteData)
		{
			throw null;
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Requirement[] method_2(GClass1908 v)
		{
			throw null;
		}

		// Token: 0x06009065 RID: 36965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1223 method_3(GStruct241 reference)
		{
			throw null;
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Profile.TraderInfo method_4(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass1860> method_5(GClass1864 x)
		{
			throw null;
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_6(AreaData v)
		{
			throw null;
		}

		// Token: 0x04009765 RID: 38757
		public static readonly HideoutClass.Class1602 class1602_0;

		// Token: 0x04009766 RID: 38758
		public static Func<AreaInfo, bool> func_0;

		// Token: 0x04009767 RID: 38759
		public static Func<QteHandleData, bool> func_1;

		// Token: 0x04009768 RID: 38760
		public static Func<GClass1908, Requirement[]> func_2;

		// Token: 0x04009769 RID: 38761
		public static Func<GStruct241, GClass1223> func_3;

		// Token: 0x0400976A RID: 38762
		public static Func<TraderClass, Profile.TraderInfo> func_4;

		// Token: 0x0400976B RID: 38763
		public static Func<GClass1864, IEnumerable<GClass1860>> func_5;

		// Token: 0x0400976C RID: 38764
		public static Func<AreaData, bool> func_6;
	}

	// Token: 0x02001ABB RID: 6843
	[CompilerGenerated]
	private sealed class Class1603
	{
		// Token: 0x0600906B RID: 36971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x04009777 RID: 38775
		public InventoryControllerClass inventoryController;

		// Token: 0x04009778 RID: 38776
		public HideoutClass gclass1904_0;

		// Token: 0x04009779 RID: 38777
		public Profile profile;

		// Token: 0x0400977A RID: 38778
		public EnergyControllerClass energyController;
	}

	// Token: 0x02001ABC RID: 6844
	[CompilerGenerated]
	private sealed class Class1604
	{
		// Token: 0x0600906D RID: 36973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(AreaInfo info)
		{
			throw null;
		}

		// Token: 0x0400977B RID: 38779
		public HideoutClass gclass1904_0;

		// Token: 0x0400977C RID: 38780
		public AreaData areaData;
	}

	// Token: 0x02001ABD RID: 6845
	[CompilerGenerated]
	private sealed class Class1605
	{
		// Token: 0x0600906F RID: 36975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaData x)
		{
			throw null;
		}

		// Token: 0x0400977D RID: 38781
		public AreaData areaData;
	}

	// Token: 0x02001ABE RID: 6846
	[CompilerGenerated]
	private sealed class Class1606
	{
		// Token: 0x06009070 RID: 36976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Requirement requirement)
		{
			throw null;
		}

		// Token: 0x0400977E RID: 38782
		public AreaData areaData;
	}

	// Token: 0x02001ABF RID: 6847
	[CompilerGenerated]
	private sealed class Class1607
	{
		// Token: 0x06009071 RID: 36977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaTemplate v)
		{
			throw null;
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(QteData qteData)
		{
			throw null;
		}

		// Token: 0x0400977F RID: 38783
		public AreaTemplate areaTemplate;

		// Token: 0x04009780 RID: 38784
		public HideoutClass gclass1904_0;
	}

	// Token: 0x02001AC0 RID: 6848
	[CompilerGenerated]
	private sealed class Class1608
	{
		// Token: 0x06009073 RID: 36979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(bool selected)
		{
			throw null;
		}

		// Token: 0x04009781 RID: 38785
		public AreaData data;

		// Token: 0x04009782 RID: 38786
		public HideoutClass.Class1607 class1607_0;
	}

	// Token: 0x02001AC1 RID: 6849
	[CompilerGenerated]
	private sealed class Class1609
	{
		// Token: 0x06009074 RID: 36980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(QteData qteData)
		{
			throw null;
		}

		// Token: 0x04009783 RID: 38787
		public int level;
	}

	// Token: 0x02001AC2 RID: 6850
	[CompilerGenerated]
	private sealed class Class1610
	{
		// Token: 0x06009075 RID: 36981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1920 scheme)
		{
			throw null;
		}

		// Token: 0x04009784 RID: 38788
		public EAreaType type;
	}

	// Token: 0x02001AC3 RID: 6851
	[CompilerGenerated]
	private sealed class Class1611
	{
		// Token: 0x06009076 RID: 36982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item playerItem)
		{
			throw null;
		}

		// Token: 0x04009785 RID: 38789
		public GClass1223 itemReference;
	}

	// Token: 0x02001AC5 RID: 6853
	[CompilerGenerated]
	private sealed class Class1612
	{
		// Token: 0x06009079 RID: 36985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaInfo a)
		{
			throw null;
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(AreaData data)
		{
			throw null;
		}

		// Token: 0x0400978D RID: 38797
		public int type;

		// Token: 0x0400978E RID: 38798
		public EAreaType areaType;
	}

	// Token: 0x02001AC7 RID: 6855
	[CompilerGenerated]
	private sealed class Class1613<T> where T : Item
	{
		// Token: 0x0600907D RID: 36989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item item)
		{
			throw null;
		}

		// Token: 0x04009795 RID: 38805
		public IEnumerable<string> templateIdFilter;
	}

	// Token: 0x02001AC8 RID: 6856
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1614<T> where T : Item
	{
		// Token: 0x0600907E RID: 36990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item item)
		{
			throw null;
		}

		// Token: 0x04009796 RID: 38806
		public static readonly HideoutClass.Class1614<T> class1614_0;

		// Token: 0x04009797 RID: 38807
		public static Func<Item, string> func_0;

		// Token: 0x04009798 RID: 38808
		public static Func<Item, bool> func_1;
	}

	// Token: 0x02001AC9 RID: 6857
	[CompilerGenerated]
	private sealed class Class1615
	{
		// Token: 0x06009080 RID: 36992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04009799 RID: 38809
		public HideoutClass gclass1904_0;

		// Token: 0x0400979A RID: 38810
		public Item templateItem;

		// Token: 0x0400979B RID: 38811
		public Action onComplete;
	}

	// Token: 0x02001ACE RID: 6862
	[CompilerGenerated]
	private sealed class Class1616
	{
		// Token: 0x06009089 RID: 37001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GEventArgs2 args)
		{
			throw null;
		}

		// Token: 0x040097B4 RID: 38836
		public string stashId;

		// Token: 0x040097B5 RID: 38837
		public List<Item> producedItems;

		// Token: 0x040097B6 RID: 38838
		public GClass1924 behaviour;
	}

	// Token: 0x02001AD3 RID: 6867
	[CompilerGenerated]
	private sealed class Class1617
	{
		// Token: 0x06009092 RID: 37010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaData data)
		{
			throw null;
		}

		// Token: 0x040097CF RID: 38863
		public EAreaType areaType;
	}

	// Token: 0x02001AD4 RID: 6868
	[CompilerGenerated]
	private sealed class Class1618
	{
		// Token: 0x06009093 RID: 37011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AreaData data)
		{
			throw null;
		}

		// Token: 0x040097D0 RID: 38864
		public EAreaType type;
	}
}
