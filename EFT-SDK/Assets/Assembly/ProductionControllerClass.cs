using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Hideout;
using EFT.InventoryLogic;

// Token: 0x02001AFA RID: 6906
public sealed class ProductionControllerClass : GInterface147
{
	// Token: 0x140001B2 RID: 434
	// (add) Token: 0x060091D9 RID: 37337 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060091DA RID: 37338 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1912> OnProductionComplete
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

	// Token: 0x140001B3 RID: 435
	// (add) Token: 0x060091DB RID: 37339 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060091DC RID: 37340 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<ProductionControllerClass> OnProducedItemCountChanged
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

	// Token: 0x140001B4 RID: 436
	// (add) Token: 0x060091DD RID: 37341 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060091DE RID: 37342 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<ProductionControllerClass> OnProductionStatusChanged
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

	// Token: 0x1700162E RID: 5678
	// (get) Token: 0x060091DF RID: 37343 RVA: 0x00002050 File Offset: 0x00000250
	public int TotalProducedItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700162F RID: 5679
	// (get) Token: 0x060091E0 RID: 37344 RVA: 0x00002050 File Offset: 0x00000250
	public int TotalFailedItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060091E1 RID: 37345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass1912> GetProducersWithProducedItem()
	{
		throw null;
	}

	// Token: 0x060091E2 RID: 37346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetProducedItemsCountInArea(EAreaType areaType)
	{
		throw null;
	}

	// Token: 0x060091E3 RID: 37347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060091E4 RID: 37348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060091E5 RID: 37349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnergySupplyChanged(bool isEnergyOn)
	{
		throw null;
	}

	// Token: 0x060091E6 RID: 37350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProducer(AreaData data, GClass1912 producer)
	{
		throw null;
	}

	// Token: 0x060091E7 RID: 37351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060091E8 RID: 37352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1912 GetProducer(AreaData behaviour)
	{
		throw null;
	}

	// Token: 0x060091E9 RID: 37353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateProductions(Dictionary<string, ProductionData> productionDataChanges)
	{
		throw null;
	}

	// Token: 0x060091EA RID: 37354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GInterface165 sender)
	{
		throw null;
	}

	// Token: 0x060091EB RID: 37355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(AreaData data)
	{
		throw null;
	}

	// Token: 0x060091EC RID: 37356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(AreaData data)
	{
		throw null;
	}

	// Token: 0x040098A9 RID: 39081
	[CompilerGenerated]
	private Action<GClass1912> action_0;

	// Token: 0x040098AA RID: 39082
	[CompilerGenerated]
	private Action<ProductionControllerClass> action_1;

	// Token: 0x040098AB RID: 39083
	[CompilerGenerated]
	private Action<ProductionControllerClass> action_2;

	// Token: 0x040098AC RID: 39084
	private readonly float float_0;

	// Token: 0x040098AD RID: 39085
	private readonly Dictionary<AreaData, GClass1912> dictionary_0;

	// Token: 0x040098AE RID: 39086
	private readonly List<Action> list_0;

	// Token: 0x040098AF RID: 39087
	private readonly Dictionary<GClass1924, ProductionControllerClass.Class1628> dictionary_1;

	// Token: 0x02001AFB RID: 6907
	private sealed class Class1628
	{
		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x060091ED RID: 37357 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1912 Producer
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x060091EE RID: 37358 RVA: 0x00002050 File Offset: 0x00000250
		public List<Item> Items
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040098B0 RID: 39088
		[CompilerGenerated]
		private readonly GClass1912 gclass1912_0;

		// Token: 0x040098B1 RID: 39089
		[CompilerGenerated]
		private readonly List<Item> list_0;
	}

	// Token: 0x02001AFC RID: 6908
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1629
	{
		// Token: 0x060091EF RID: 37359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(KeyValuePair<AreaData, GClass1912> x)
		{
			throw null;
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(KeyValuePair<AreaData, GClass1912> x)
		{
			throw null;
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(KeyValuePair<AreaData, GClass1912> x)
		{
			throw null;
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1912 method_3(KeyValuePair<AreaData, GClass1912> x)
		{
			throw null;
		}

		// Token: 0x040098B2 RID: 39090
		public static readonly ProductionControllerClass.Class1629 class1629_0;

		// Token: 0x040098B3 RID: 39091
		public static Func<KeyValuePair<AreaData, GClass1912>, int> func_0;

		// Token: 0x040098B4 RID: 39092
		public static Func<KeyValuePair<AreaData, GClass1912>, int> func_1;

		// Token: 0x040098B5 RID: 39093
		public static Func<KeyValuePair<AreaData, GClass1912>, bool> func_2;

		// Token: 0x040098B6 RID: 39094
		public static Func<KeyValuePair<AreaData, GClass1912>, GClass1912> func_3;
	}

	// Token: 0x02001AFD RID: 6909
	[CompilerGenerated]
	private sealed class Class1630
	{
		// Token: 0x060091F3 RID: 37363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<AreaData, GClass1912> x)
		{
			throw null;
		}

		// Token: 0x040098B7 RID: 39095
		public EAreaType areaType;
	}

	// Token: 0x02001AFE RID: 6910
	[CompilerGenerated]
	private sealed class Class1631
	{
		// Token: 0x060091F4 RID: 37364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Item[] items, GClass1918 producingItem)
		{
			throw null;
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass1918 item)
		{
			throw null;
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3()
		{
			throw null;
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4()
		{
			throw null;
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5()
		{
			throw null;
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_6()
		{
			throw null;
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_7()
		{
			throw null;
		}

		// Token: 0x040098B8 RID: 39096
		public AreaData data;

		// Token: 0x040098B9 RID: 39097
		public ProductionControllerClass gclass1917_0;

		// Token: 0x040098BA RID: 39098
		public GClass1912 producer;
	}
}
