using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Communications;
using EFT.Hideout;
using EFT.InventoryLogic;

// Token: 0x02001AEF RID: 6895
public abstract class GClass1912 : GInterface147
{
	// Token: 0x170015FF RID: 5631
	// (get) Token: 0x0600911A RID: 37146 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600911B RID: 37147 RVA: 0x00002050 File Offset: 0x00000250
	public EAreaType AreaType
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

	// Token: 0x17001600 RID: 5632
	// (get) Token: 0x0600911C RID: 37148 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600911D RID: 37149 RVA: 0x00002050 File Offset: 0x00000250
	public string LastRecipe
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

	// Token: 0x17001601 RID: 5633
	// (get) Token: 0x0600911E RID: 37150 RVA: 0x00002050 File Offset: 0x00000250
	protected EnergyControllerClass GClass1901_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140001A8 RID: 424
	// (add) Token: 0x0600911F RID: 37151 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009120 RID: 37152 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnProductionSpeedChanged
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

	// Token: 0x140001A9 RID: 425
	// (add) Token: 0x06009121 RID: 37153 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009122 RID: 37154 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnWorkingStatusChanged
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

	// Token: 0x140001AA RID: 426
	// (add) Token: 0x06009123 RID: 37155 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009124 RID: 37156 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnProduceStatusChanged
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

	// Token: 0x140001AB RID: 427
	// (add) Token: 0x06009125 RID: 37157 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009126 RID: 37158 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1918> OnProductionStarted
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

	// Token: 0x140001AC RID: 428
	// (add) Token: 0x06009127 RID: 37159 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009128 RID: 37160 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item[], GClass1918> OnProductionComplete
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

	// Token: 0x140001AD RID: 429
	// (add) Token: 0x06009129 RID: 37161 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600912A RID: 37162 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<Item>> OnGetProducedItems
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

	// Token: 0x140001AE RID: 430
	// (add) Token: 0x0600912B RID: 37163 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600912C RID: 37164 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnDataChanged
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

	// Token: 0x140001AF RID: 431
	// (add) Token: 0x0600912D RID: 37165 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600912E RID: 37166 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17001602 RID: 5634
	// (get) Token: 0x0600912F RID: 37167 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009130 RID: 37168 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1919[] ProductionSchemes
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

	// Token: 0x17001603 RID: 5635
	// (get) Token: 0x06009131 RID: 37169 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009132 RID: 37170 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<string, GClass1919> Schemes
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

	// Token: 0x17001604 RID: 5636
	// (get) Token: 0x06009133 RID: 37171 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<string, GClass1918> ProducingItems
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009134 RID: 37172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetErrorsCount()
	{
		throw null;
	}

	// Token: 0x06009135 RID: 37173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetErrorsCountRaw()
	{
		throw null;
	}

	// Token: 0x06009136 RID: 37174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetErrorsChecked()
	{
		throw null;
	}

	// Token: 0x06009137 RID: 37175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EProductionState GetProductionState(string schemeId)
	{
		throw null;
	}

	// Token: 0x17001605 RID: 5637
	// (get) Token: 0x06009138 RID: 37176 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1918 ClosestToEndProducingItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001606 RID: 5638
	// (get) Token: 0x06009139 RID: 37177 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool IsWorking
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001607 RID: 5639
	// (get) Token: 0x0600913A RID: 37178 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600913B RID: 37179 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFulfilled
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

	// Token: 0x17001608 RID: 5640
	// (get) Token: 0x0600913C RID: 37180 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600913D RID: 37181 RVA: 0x00002050 File Offset: 0x00000250
	protected int Int32_0
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

	// Token: 0x17001609 RID: 5641
	// (get) Token: 0x0600913E RID: 37182 RVA: 0x00002050 File Offset: 0x00000250
	public virtual GInterface165 CompleteItemsStorage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700160A RID: 5642
	// (get) Token: 0x0600913F RID: 37183 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009140 RID: 37184 RVA: 0x00002050 File Offset: 0x00000250
	private AreaData AreaData_0
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

	// Token: 0x1700160B RID: 5643
	// (get) Token: 0x06009141 RID: 37185 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009142 RID: 37186 RVA: 0x00002050 File Offset: 0x00000250
	public virtual float ProductionSpeedCoefficient
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

	// Token: 0x1700160C RID: 5644
	// (get) Token: 0x06009143 RID: 37187 RVA: 0x00002050 File Offset: 0x00000250
	public virtual float ReductionCoefficient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700160D RID: 5645
	// (get) Token: 0x06009144 RID: 37188 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009145 RID: 37189 RVA: 0x00002050 File Offset: 0x00000250
	public float TimeReduction
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

	// Token: 0x1700160E RID: 5646
	// (get) Token: 0x06009146 RID: 37190 RVA: 0x00002050 File Offset: 0x00000250
	protected HideoutClass GClass1904_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700160F RID: 5647
	// (get) Token: 0x06009147 RID: 37191 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool CanStartByProductionCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001610 RID: 5648
	// (get) Token: 0x06009148 RID: 37192 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009149 RID: 37193 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool CanStart
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

	// Token: 0x17001611 RID: 5649
	// (get) Token: 0x0600914A RID: 37194 RVA: 0x00002050 File Offset: 0x00000250
	public virtual EHideoutNotificationType NotificationType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600914B RID: 37195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1912 GetProducer(AreaData data, AreaInfo areaInfo, List<ProductionData> productionData, IEnumerable<GClass1919> schemes, SkillManager skillManager, Profile.FenceTraderInfo fenceInfo)
	{
		throw null;
	}

	// Token: 0x0600914C RID: 37196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanStartScheme(GClass1920 scheme)
	{
		throw null;
	}

	// Token: 0x0600914D RID: 37197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitInfo(AreaInfo areaInfo)
	{
		throw null;
	}

	// Token: 0x0600914E RID: 37198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitProduction(List<ProductionData> productions)
	{
		throw null;
	}

	// Token: 0x0600914F RID: 37199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool ShouldCreateProductionItemOnInit(ProductionData productionData, GClass1919 activeScheme)
	{
		throw null;
	}

	// Token: 0x06009150 RID: 37200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(ProductionData productionData, GClass1919 activeScheme)
	{
		throw null;
	}

	// Token: 0x06009151 RID: 37201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(ProductionData productionData, GClass1919 activeScheme)
	{
		throw null;
	}

	// Token: 0x06009152 RID: 37202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(ProductionData productionData)
	{
		throw null;
	}

	// Token: 0x06009153 RID: 37203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartProducing(GClass1919 scheme)
	{
		throw null;
	}

	// Token: 0x06009154 RID: 37204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryUpdateProduction(string schemeId, ProductionData productionData)
	{
		throw null;
	}

	// Token: 0x06009155 RID: 37205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetItems(string schemeId)
	{
		throw null;
	}

	// Token: 0x06009156 RID: 37206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitDetails(AreaData data)
	{
		throw null;
	}

	// Token: 0x06009157 RID: 37207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAreaDataEarly(AreaData data)
	{
		throw null;
	}

	// Token: 0x06009158 RID: 37208 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAreaDataLate(AreaData data)
	{
		throw null;
	}

	// Token: 0x06009159 RID: 37209 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ApplySkillsAndBuffsOnInit(SkillManager skillManager)
	{
		throw null;
	}

	// Token: 0x0600915A RID: 37210 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool PreUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600915B RID: 37211 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateProductionTimeReduction(float value)
	{
		throw null;
	}

	// Token: 0x0600915C RID: 37212 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double CalculateProductionTime(GClass1919 scheme)
	{
		throw null;
	}

	// Token: 0x0600915D RID: 37213 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3()
	{
		throw null;
	}

	// Token: 0x0600915E RID: 37214 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600915F RID: 37215 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnError()
	{
		throw null;
	}

	// Token: 0x06009160 RID: 37216 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06009161 RID: 37217 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Item CreateCompleteItem(GClass1919 scheme)
	{
		throw null;
	}

	// Token: 0x06009162 RID: 37218 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void BeforeProductionComplete(string doneItemId)
	{
		throw null;
	}

	// Token: 0x06009163 RID: 37219 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5()
	{
		throw null;
	}

	// Token: 0x06009164 RID: 37220 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_6(Item[] items)
	{
		throw null;
	}

	// Token: 0x06009165 RID: 37221 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_7(GClass1918 producingItem)
	{
		throw null;
	}

	// Token: 0x06009166 RID: 37222 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_8()
	{
		throw null;
	}

	// Token: 0x06009167 RID: 37223 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_9(Item item)
	{
		throw null;
	}

	// Token: 0x06009168 RID: 37224 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_10()
	{
		throw null;
	}

	// Token: 0x06009169 RID: 37225 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_11()
	{
		throw null;
	}

	// Token: 0x0600916A RID: 37226 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SetDetailsData()
	{
		throw null;
	}

	// Token: 0x0600916B RID: 37227 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddProducingItem(GClass1918 item)
	{
		throw null;
	}

	// Token: 0x04009846 RID: 38982
	[CompilerGenerated]
	private EAreaType eareaType_0;

	// Token: 0x04009847 RID: 38983
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04009848 RID: 38984
	protected GClass1925 gclass1925_0;

	// Token: 0x04009849 RID: 38985
	protected GClass1925 gclass1925_1;

	// Token: 0x0400984A RID: 38986
	protected GClass1926 gclass1926_0;

	// Token: 0x0400984B RID: 38987
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400984C RID: 38988
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400984D RID: 38989
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400984E RID: 38990
	[CompilerGenerated]
	private Action<GClass1918> action_3;

	// Token: 0x0400984F RID: 38991
	[CompilerGenerated]
	private Action<Item[], GClass1918> action_4;

	// Token: 0x04009850 RID: 38992
	[CompilerGenerated]
	private Action<IEnumerable<Item>> action_5;

	// Token: 0x04009851 RID: 38993
	[CompilerGenerated]
	private Action action_6;

	// Token: 0x04009852 RID: 38994
	[CompilerGenerated]
	private Action<Item> action_7;

	// Token: 0x04009853 RID: 38995
	[CompilerGenerated]
	private GClass1919[] gclass1919_0;

	// Token: 0x04009854 RID: 38996
	[CompilerGenerated]
	private Dictionary<string, GClass1919> dictionary_0;

	// Token: 0x04009855 RID: 38997
	protected readonly Dictionary<string, GClass1918> dictionary_1;

	// Token: 0x04009856 RID: 38998
	protected readonly Dictionary<string, GClass1918> dictionary_2;

	// Token: 0x04009857 RID: 38999
	[CompilerGenerated]
	private readonly Dictionary<string, GClass1918> dictionary_3;

	// Token: 0x04009858 RID: 39000
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04009859 RID: 39001
	[CompilerGenerated]
	private int int_0;

	// Token: 0x0400985A RID: 39002
	protected GInterface165 ginterface165_0;

	// Token: 0x0400985B RID: 39003
	[CompilerGenerated]
	private AreaData areaData_0;

	// Token: 0x0400985C RID: 39004
	protected float float_0;

	// Token: 0x0400985D RID: 39005
	private EnergyControllerClass gclass1901_0;

	// Token: 0x0400985E RID: 39006
	[CompilerGenerated]
	private float float_1;

	// Token: 0x0400985F RID: 39007
	[CompilerGenerated]
	private readonly HideoutClass gclass1904_0;

	// Token: 0x04009860 RID: 39008
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x02001AF0 RID: 6896
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1625
	{
		// Token: 0x0600916C RID: 37228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<string, GClass1918> item)
		{
			throw null;
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass1919 scheme)
		{
			throw null;
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(GClass1919 scheme)
		{
			throw null;
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1919 method_3(GClass1919 scheme)
		{
			throw null;
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_4(KeyValuePair<string, GClass1918> x)
		{
			throw null;
		}

		// Token: 0x04009861 RID: 39009
		public static readonly GClass1912.Class1625 class1625_0;

		// Token: 0x04009862 RID: 39010
		public static Func<KeyValuePair<string, GClass1918>, bool> func_0;

		// Token: 0x04009863 RID: 39011
		public static Func<GClass1919, bool> func_1;

		// Token: 0x04009864 RID: 39012
		public static Func<GClass1919, string> func_2;

		// Token: 0x04009865 RID: 39013
		public static Func<GClass1919, GClass1919> func_3;

		// Token: 0x04009866 RID: 39014
		public static Func<KeyValuePair<string, GClass1918>, int> func_4;
	}
}
