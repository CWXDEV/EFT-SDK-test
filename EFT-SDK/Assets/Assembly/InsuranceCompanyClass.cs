using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x02002EBF RID: 11967
public sealed class InsuranceCompanyClass : GInterface104, GInterface105
{
	// Token: 0x1700289B RID: 10395
	// (get) Token: 0x0600EC43 RID: 60483 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3364<ItemClass> ItemsToInsure
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700289C RID: 10396
	// (get) Token: 0x0600EC44 RID: 60484 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3364<ItemClass> InsuredItems
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700289D RID: 10397
	// (get) Token: 0x0600EC45 RID: 60485 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<TraderClass> Insurers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700289E RID: 10398
	// (get) Token: 0x0600EC46 RID: 60486 RVA: 0x00002050 File Offset: 0x00000250
	public TraderClass SelectedInsurer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700289F RID: 10399
	// (get) Token: 0x0600EC47 RID: 60487 RVA: 0x00002050 File Offset: 0x00000250
	public InsuranceCompanyClass.GStruct401 OverallPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028A0 RID: 10400
	// (get) Token: 0x0600EC48 RID: 60488 RVA: 0x00002050 File Offset: 0x00000250
	public List<ItemClass> AllItemsToInsure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600EC49 RID: 60489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearInsuredItems()
	{
		throw null;
	}

	// Token: 0x0600EC4A RID: 60490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterInsuredItems(IEnumerable<InsuredItemClass> insuredItems, IEnumerable<Item> playerItems)
	{
		throw null;
	}

	// Token: 0x0600EC4B RID: 60491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ItemClass method_0(InsuredItemClass preinsuredItem, Item actualItem)
	{
		throw null;
	}

	// Token: 0x0600EC4C RID: 60492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ItemsPrice(List<ItemClass> items)
	{
		throw null;
	}

	// Token: 0x0600EC4D RID: 60493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Item> GetItemChildren(Item item)
	{
		throw null;
	}

	// Token: 0x0600EC4E RID: 60494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ItemClass> GetItemChildren(ItemClass insuredItem)
	{
		throw null;
	}

	// Token: 0x0600EC4F RID: 60495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ItemClass> GetFlattenChildren(ItemClass item)
	{
		throw null;
	}

	// Token: 0x0600EC50 RID: 60496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsureItems(List<ItemClass> items, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600EC51 RID: 60497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItemToInsuranceQueue(Item item, bool addChildren, bool playSound)
	{
		throw null;
	}

	// Token: 0x0600EC52 RID: 60498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItemToInsuranceQueue(ItemClass item, bool addChildren = true, bool playSound = true)
	{
		throw null;
	}

	// Token: 0x0600EC53 RID: 60499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(ItemClass item)
	{
		throw null;
	}

	// Token: 0x0600EC54 RID: 60500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveItemFromInsuranceQueue(Item item, bool removeChildren = true)
	{
		throw null;
	}

	// Token: 0x0600EC55 RID: 60501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveItemFromInsuranceQueue(ItemClass item, bool removeChildren = true)
	{
		throw null;
	}

	// Token: 0x0600EC56 RID: 60502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateInsuranceItemsPrices(IEnumerable<ItemClass> items, Action<ItemClass[]> callback)
	{
		throw null;
	}

	// Token: 0x0600EC57 RID: 60503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetParentsCount(ItemClass item, int count)
	{
		throw null;
	}

	// Token: 0x0600EC58 RID: 60504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ItemTypeAvailableForInsurance(Item item)
	{
		throw null;
	}

	// Token: 0x0600EC59 RID: 60505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ItemTypeAvailableForInsurance(ItemClass item)
	{
		throw null;
	}

	// Token: 0x0600EC5A RID: 60506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(Type itemType)
	{
		throw null;
	}

	// Token: 0x0600EC5B RID: 60507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(ItemClass item)
	{
		throw null;
	}

	// Token: 0x0600EC5C RID: 60508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Insured(string itemId)
	{
		throw null;
	}

	// Token: 0x0600EC5D RID: 60509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InInsuranceQueue(string itemId)
	{
		throw null;
	}

	// Token: 0x0600EC5E RID: 60510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearInsuranceQueue()
	{
		throw null;
	}

	// Token: 0x0600EC5F RID: 60511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetInsurePriceAsync(IEnumerable<ItemClass> items, Action<ItemClass[]> callback)
	{
		throw null;
	}

	// Token: 0x0600EC60 RID: 60512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Dictionary<string, Dictionary<string, int>> traderToPrices, ItemClass item)
	{
		throw null;
	}

	// Token: 0x0600EC61 RID: 60513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnItemAdded(GEventArgs2 arg)
	{
		throw null;
	}

	// Token: 0x0400F149 RID: 61769
	public const string ITEM_CAN_NOT_BE_INSURED = "Item is not available for insurance";

	// Token: 0x0400F14A RID: 61770
	public readonly InsuranceCompanyClass.GClass632 Logger;

	// Token: 0x0400F14B RID: 61771
	public static readonly Dictionary<string, ItemClass> AllInsuredItemsTemplates;

	// Token: 0x0400F14C RID: 61772
	[CompilerGenerated]
	private readonly GClass3364<ItemClass> gclass3364_0;

	// Token: 0x0400F14D RID: 61773
	[CompilerGenerated]
	private readonly GClass3364<ItemClass> gclass3364_1;

	// Token: 0x0400F14E RID: 61774
	private readonly Type[] type_0;

	// Token: 0x0400F14F RID: 61775
	[NonSerialized]
	public readonly GClass3355<ItemClass> OnItemCovered;

	// Token: 0x0400F150 RID: 61776
	[NonSerialized]
	public readonly GClass3355<ItemClass> OnItemUncovered;

	// Token: 0x0400F151 RID: 61777
	[NonSerialized]
	public readonly GClass3355<ItemClass> OnItemInsured;

	// Token: 0x0400F152 RID: 61778
	public string SelectedInsurerId;

	// Token: 0x0400F153 RID: 61779
	private readonly GInterface178 ginterface178_0;

	// Token: 0x0400F154 RID: 61780
	public readonly GClass3178 InsureSummary;

	// Token: 0x0400F155 RID: 61781
	private List<InsuredItemClass> list_0;

	// Token: 0x02002EC0 RID: 11968
	public enum EInsuranceError
	{
		// Token: 0x0400F157 RID: 61783
		NothingToInsure,
		// Token: 0x0400F158 RID: 61784
		NotEnoughMoney,
		// Token: 0x0400F159 RID: 61785
		InvalidItem
	}

	// Token: 0x02002EC1 RID: 11969
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct401
	{
		// Token: 0x0400F15A RID: 61786
		public int Price;

		// Token: 0x0400F15B RID: 61787
		public InsuranceCompanyClass.EInsuranceError? Error;
	}

	// Token: 0x02002EC2 RID: 11970
	public sealed class GClass632 : LoggerClass
	{
	}

	// Token: 0x02002EC3 RID: 11971
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2938
	{
		// Token: 0x0600EC62 RID: 60514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ItemClass> method_0(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_1(Mod x)
		{
			throw null;
		}

		// Token: 0x0600EC64 RID: 60516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_2(IContainer x)
		{
			throw null;
		}

		// Token: 0x0600EC65 RID: 60517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_3(Slot x)
		{
			throw null;
		}

		// Token: 0x0600EC66 RID: 60518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_4(IContainer x)
		{
			throw null;
		}

		// Token: 0x0600EC67 RID: 60519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_5(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0600EC68 RID: 60520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_6(TraderClass x)
		{
			throw null;
		}

		// Token: 0x0600EC69 RID: 60521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_7(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0400F15C RID: 61788
		public static readonly InsuranceCompanyClass.Class2938 class2938_0;

		// Token: 0x0400F15D RID: 61789
		public static Func<ItemClass, IEnumerable<ItemClass>> func_0;

		// Token: 0x0400F15E RID: 61790
		public static Func<Mod, Item> func_1;

		// Token: 0x0400F15F RID: 61791
		public static Func<IContainer, IEnumerable<Item>> func_2;

		// Token: 0x0400F160 RID: 61792
		public static Func<Slot, Item> func_3;

		// Token: 0x0400F161 RID: 61793
		public static Func<IContainer, IEnumerable<Item>> func_4;

		// Token: 0x0400F162 RID: 61794
		public static Func<ItemClass, string> func_5;

		// Token: 0x0400F163 RID: 61795
		public static Func<TraderClass, string> func_6;

		// Token: 0x0400F164 RID: 61796
		public static Func<ItemClass, string> func_7;
	}

	// Token: 0x02002EC4 RID: 11972
	[CompilerGenerated]
	private sealed class Class2939
	{
		// Token: 0x0600EC6A RID: 60522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0400F165 RID: 61797
		public InsuredItemClass item;
	}

	// Token: 0x02002EC5 RID: 11973
	[CompilerGenerated]
	private sealed class Class2940
	{
		// Token: 0x0600EC6B RID: 60523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemClass item)
		{
			throw null;
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(ItemClass item)
		{
			throw null;
		}

		// Token: 0x0400F166 RID: 61798
		public GClass3177 selectedSummary;
	}

	// Token: 0x02002EC6 RID: 11974
	[CompilerGenerated]
	private sealed class Class2941
	{
		// Token: 0x0600EC6D RID: 60525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0400F167 RID: 61799
		public ItemClass item;

		// Token: 0x0400F168 RID: 61800
		public InsuranceCompanyClass gclass3179_0;
	}

	// Token: 0x02002EC7 RID: 11975
	[CompilerGenerated]
	private sealed class Class2942
	{
		// Token: 0x0600EC6E RID: 60526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0600EC6F RID: 60527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0600EC70 RID: 60528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F169 RID: 61801
		public InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F16A RID: 61802
		public ItemClass[] appropriateItems;

		// Token: 0x0400F16B RID: 61803
		public TraderClass insurer;

		// Token: 0x0400F16C RID: 61804
		public Callback callback;
	}

	// Token: 0x02002EC8 RID: 11976
	[CompilerGenerated]
	private sealed class Class2943
	{
		// Token: 0x0600EC71 RID: 60529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Type type)
		{
			throw null;
		}

		// Token: 0x0400F16D RID: 61805
		public Type itemType;
	}

	// Token: 0x02002EC9 RID: 11977
	[CompilerGenerated]
	private sealed class Class2944
	{
		// Token: 0x0600EC72 RID: 60530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0400F16E RID: 61806
		public string itemId;
	}

	// Token: 0x02002ECA RID: 11978
	[CompilerGenerated]
	private sealed class Class2945
	{
		// Token: 0x0600EC73 RID: 60531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemClass x)
		{
			throw null;
		}

		// Token: 0x0400F16F RID: 61807
		public string itemId;
	}

	// Token: 0x02002ECB RID: 11979
	[CompilerGenerated]
	private sealed class Class2946
	{
		// Token: 0x0600EC74 RID: 60532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Dictionary<string, Dictionary<string, int>>> result)
		{
			throw null;
		}

		// Token: 0x0400F170 RID: 61808
		public List<ItemClass> newItems;

		// Token: 0x0400F171 RID: 61809
		public InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F172 RID: 61810
		public Action<ItemClass[]> callback;
	}

	// Token: 0x02002ECC RID: 11980
	[CompilerGenerated]
	private sealed class Class2947
	{
		// Token: 0x0600EC75 RID: 60533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x0400F173 RID: 61811
		public string traderId;
	}

	// Token: 0x02002ECD RID: 11981
	[CompilerGenerated]
	private sealed class Class2948
	{
		// Token: 0x0600EC76 RID: 60534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(InsuredItemClass x)
		{
			throw null;
		}

		// Token: 0x0400F174 RID: 61812
		public Item item;
	}
}
