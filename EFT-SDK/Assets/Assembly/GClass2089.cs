using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using EFT;
using EFT.Builds;
using EFT.InventoryLogic;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x02001D93 RID: 7571
public sealed class GClass2089 : GInterface183
{
	// Token: 0x140001E2 RID: 482
	// (add) Token: 0x06009C0F RID: 39951 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C10 RID: 39952 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int> OnItemChanged
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

	// Token: 0x140001E3 RID: 483
	// (add) Token: 0x06009C11 RID: 39953 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C12 RID: 39954 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnNameChanged
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

	// Token: 0x140001E4 RID: 484
	// (add) Token: 0x06009C13 RID: 39955 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C14 RID: 39956 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnCaliberChanged
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

	// Token: 0x140001E5 RID: 485
	// (add) Token: 0x06009C15 RID: 39957 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009C16 RID: 39958 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnCompositionChanged
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

	// Token: 0x1700187D RID: 6269
	// (get) Token: 0x06009C17 RID: 39959 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("Id")]
	public MongoID Id
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700187E RID: 6270
	// (get) Token: 0x06009C18 RID: 39960 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C19 RID: 39961 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("Name")]
	public string Name
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

	// Token: 0x1700187F RID: 6271
	// (get) Token: 0x06009C1A RID: 39962 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C1B RID: 39963 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("Caliber")]
	public string Caliber
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

	// Token: 0x17001880 RID: 6272
	// (get) Token: 0x06009C1C RID: 39964 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C1D RID: 39965 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public EEquipmentBuildType BuildType
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

	// Token: 0x17001881 RID: 6273
	// (get) Token: 0x06009C1E RID: 39966 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("Items")]
	public IReadOnlyList<GClass2089.GClass2090> Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001882 RID: 6274
	// (get) Token: 0x06009C1F RID: 39967 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public IEnumerable<GClass2089.GClass2090> Bottom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001883 RID: 6275
	// (get) Token: 0x06009C20 RID: 39968 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public IEnumerable<GClass2089.GClass2090> Loop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001884 RID: 6276
	// (get) Token: 0x06009C21 RID: 39969 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public IEnumerable<GClass2089.GClass2090> Top
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001885 RID: 6277
	// (get) Token: 0x06009C22 RID: 39970 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C23 RID: 39971 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("TopCount")]
	public int TopCount
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

	// Token: 0x17001886 RID: 6278
	// (get) Token: 0x06009C24 RID: 39972 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009C25 RID: 39973 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("BottomCount")]
	public int BottomCount
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

	// Token: 0x06009C26 RID: 39974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItem(AmmoTemplate template, ushort count, int index)
	{
		throw null;
	}

	// Token: 0x06009C27 RID: 39975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveItem(int index)
	{
		throw null;
	}

	// Token: 0x06009C28 RID: 39976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCaliber(string caliber)
	{
		throw null;
	}

	// Token: 0x06009C29 RID: 39977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct414 SetName(string name, bool forced = false)
	{
		throw null;
	}

	// Token: 0x06009C2A RID: 39978 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x06009C2B RID: 39979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GStruct414> Apply(IReadOnlyCollection<MagazineClass> magazines, InventoryControllerClass inventoryController)
	{
		throw null;
	}

	// Token: 0x06009C2C RID: 39980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IReadOnlyDictionary<MongoID, int> FindMissingItems(IReadOnlyCollection<MagazineClass> magazines, Inventory inventory)
	{
		throw null;
	}

	// Token: 0x06009C2D RID: 39981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<GClass2089.GClass2090> method_1(MagazineClass magazine)
	{
		throw null;
	}

	// Token: 0x06009C2E RID: 39982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<LootItemClass> smethod_0(Inventory inventory)
	{
		throw null;
	}

	// Token: 0x06009C2F RID: 39983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<MongoID, List<Item>> method_2(IEnumerable<MagazineClass> magazines, IEnumerable<LootItemClass> containers, out Dictionary<MongoID, int> missingItems)
	{
		throw null;
	}

	// Token: 0x06009C30 RID: 39984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<GClass2089.GClass2090> method_3(MagazineClass magazine)
	{
		throw null;
	}

	// Token: 0x06009C31 RID: 39985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equivalent(GClass2089 anotherPreset)
	{
		throw null;
	}

	// Token: 0x06009C32 RID: 39986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2089 Clone(MongoID? newId = null)
	{
		throw null;
	}

	// Token: 0x06009C33 RID: 39987 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_1(GClass2089.GClass2090 presetItem, ref GClass2089.Struct640 struct640_0)
	{
		throw null;
	}

	// Token: 0x0400A356 RID: 41814
	public const int MAX_ITEMS_COUNT = 5;

	// Token: 0x0400A357 RID: 41815
	public static readonly RangeInt NameLengthRange;

	// Token: 0x0400A358 RID: 41816
	[CompilerGenerated]
	private Action<int> action_0;

	// Token: 0x0400A359 RID: 41817
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400A35A RID: 41818
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400A35B RID: 41819
	[CompilerGenerated]
	private Action action_3;

	// Token: 0x0400A35C RID: 41820
	[CompilerGenerated]
	private readonly MongoID mongoID_0;

	// Token: 0x0400A35D RID: 41821
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400A35E RID: 41822
	[CompilerGenerated]
	private string string_1;

	// Token: 0x0400A35F RID: 41823
	[CompilerGenerated]
	private EEquipmentBuildType eequipmentBuildType_0;

	// Token: 0x0400A360 RID: 41824
	private GClass2089.GClass2090[] gclass2090_0;

	// Token: 0x0400A361 RID: 41825
	private int int_0;

	// Token: 0x0400A362 RID: 41826
	private int int_1;

	// Token: 0x0400A363 RID: 41827
	private static readonly List<LootItemClass> list_0;

	// Token: 0x0400A364 RID: 41828
	private static readonly Dictionary<MongoID, int> dictionary_0;

	// Token: 0x0400A365 RID: 41829
	private static readonly Dictionary<MongoID, List<Item>> dictionary_1;

	// Token: 0x0400A366 RID: 41830
	private static readonly List<GClass2089.GClass2090> list_1;

	// Token: 0x02001D94 RID: 7572
	private sealed class Class3149 : InventoryError
	{
		// Token: 0x06009C34 RID: 39988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0()
		{
			throw null;
		}

		// Token: 0x0400A367 RID: 41831
		private const string string_0 = "MagPreset/Error/ContainsMissingItems";

		// Token: 0x0400A368 RID: 41832
		private readonly IReadOnlyDictionary<MongoID, int> ireadOnlyDictionary_0;

		// Token: 0x0400A369 RID: 41833
		private string string_1;
	}

	// Token: 0x02001D95 RID: 7573
	private sealed class Class3150 : InventoryError
	{
		// Token: 0x06009C36 RID: 39990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400A36A RID: 41834
		private const string string_0 = "MagPreset/InvalidName{0}";

		// Token: 0x0400A36B RID: 41835
		private readonly string string_1;
	}

	// Token: 0x02001D96 RID: 7574
	public sealed class GClass2090
	{
		// Token: 0x140001E6 RID: 486
		// (add) Token: 0x06009C37 RID: 39991 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009C38 RID: 39992 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnCountChanged
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

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06009C39 RID: 39993 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009C3A RID: 39994 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Count")]
		public ushort Count
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

		// Token: 0x06009C3B RID: 39995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCount(int count)
		{
			throw null;
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryMerge(GClass2089.GClass2090 anotherItem)
		{
			throw null;
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2089.GClass2090 Clone(int maxCount)
		{
			throw null;
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equivalent(GClass2089.GClass2090 anotherItem)
		{
			throw null;
		}

		// Token: 0x0400A36C RID: 41836
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400A36D RID: 41837
		[JsonProperty("TemplateId")]
		public readonly MongoID TemplateId;

		// Token: 0x0400A36E RID: 41838
		[CompilerGenerated]
		private ushort ushort_0;
	}

	// Token: 0x02001D9A RID: 7578
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1769
	{
		// Token: 0x06009C4E RID: 40014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2089.GClass2090 item)
		{
			throw null;
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MongoID method_1(KeyValuePair<MongoID, int> itemData)
		{
			throw null;
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(KeyValuePair<MongoID, int> itemData)
		{
			throw null;
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_3(MagazineClass mag)
		{
			throw null;
		}

		// Token: 0x0400A37E RID: 41854
		public static readonly GClass2089.Class1769 class1769_0;

		// Token: 0x0400A37F RID: 41855
		public static Func<GClass2089.GClass2090, bool> func_0;

		// Token: 0x0400A380 RID: 41856
		public static Func<KeyValuePair<MongoID, int>, MongoID> func_1;

		// Token: 0x0400A381 RID: 41857
		public static Func<KeyValuePair<MongoID, int>, int> func_2;

		// Token: 0x0400A382 RID: 41858
		public static Func<MagazineClass, IEnumerable<Item>> func_3;
	}

	// Token: 0x02001D9C RID: 7580
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct640
	{
		// Token: 0x0400A38C RID: 41868
		public int freeSpace;
	}
}
