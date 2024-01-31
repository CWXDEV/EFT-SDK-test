using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02001320 RID: 4896
public sealed class ItemFactory
{
	// Token: 0x1700104B RID: 4171
	// (get) Token: 0x0600653A RID: 25914 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600653B RID: 25915 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1200[] SavedPresets
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

	// Token: 0x1700104C RID: 4172
	// (get) Token: 0x0600653C RID: 25916 RVA: 0x00002050 File Offset: 0x00000250
	private MongoID MongoID_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600653D RID: 25917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, int> GetDiscardLimits()
	{
		throw null;
	}

	// Token: 0x0600653E RID: 25918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<Item> method_0(GClass1186[] flatItems)
	{
		throw null;
	}

	// Token: 0x0600653F RID: 25919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item CreateItem(string itemId, string templateId, [CanBeNull] GClass748 itemDiff)
	{
		throw null;
	}

	// Token: 0x06006540 RID: 25920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StashClass CreateFakeStash(string stashId = null)
	{
		throw null;
	}

	// Token: 0x06006541 RID: 25921 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass748 GetDiff(Item item)
	{
		throw null;
	}

	// Token: 0x06006542 RID: 25922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItemPresets(GClass1200[] itemPresets)
	{
		throw null;
	}

	// Token: 0x06006543 RID: 25923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string BriefItemName(Item item, string defaultName)
	{
		throw null;
	}

	// Token: 0x06006544 RID: 25924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCachedItemName(string name)
	{
		throw null;
	}

	// Token: 0x06006545 RID: 25925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_1(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06006546 RID: 25926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_2(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06006547 RID: 25927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeaponBuildsStorage(GClass3184 storage)
	{
		throw null;
	}

	// Token: 0x06006548 RID: 25928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetHideoutSchemeItem(string templateId, string id, EOwnerType ownerType)
	{
		throw null;
	}

	// Token: 0x06006549 RID: 25929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetPresetItem(string templateId)
	{
		throw null;
	}

	// Token: 0x0600654A RID: 25930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<Item> CreateAllItemsEver()
	{
		throw null;
	}

	// Token: 0x0600654B RID: 25931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item[] CreateAllModsEver()
	{
		throw null;
	}

	// Token: 0x0600654C RID: 25932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item ComponentialItemToItem(GStruct103 item)
	{
		throw null;
	}

	// Token: 0x0600654D RID: 25933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StashClass FlatItemsToStash(GClass1186[] flatItems)
	{
		throw null;
	}

	// Token: 0x0600654E RID: 25934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemFactory.GStruct133 FlatItemsToTree(GClass1186[] flatItems, bool silentMode = false, Dictionary<string, Item> preexistingItems = null)
	{
		throw null;
	}

	// Token: 0x0600654F RID: 25935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1186[] TreeToFlatItems(IEnumerable<Item> rootItems)
	{
		throw null;
	}

	// Token: 0x06006550 RID: 25936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1186[] TreeToFlatItems(params Item[] rootItems)
	{
		throw null;
	}

	// Token: 0x06006551 RID: 25937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct103 ItemToComponentialItem(Item item)
	{
		throw null;
	}

	// Token: 0x06006552 RID: 25938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LogErrors(List<Error> errors, string caption)
	{
		throw null;
	}

	// Token: 0x06006553 RID: 25939 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item method_3(KeyValuePair<string, ItemTemplate> x)
	{
		throw null;
	}

	// Token: 0x06006554 RID: 25940 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item method_4(KeyValuePair<string, ItemTemplate> x)
	{
		throw null;
	}

	// Token: 0x06006555 RID: 25941 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5(GClass1186 x)
	{
		throw null;
	}

	// Token: 0x06006556 RID: 25942 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(GClass1186 x)
	{
		throw null;
	}

	// Token: 0x06006557 RID: 25943 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass1186 method_7(Item item)
	{
		throw null;
	}

	// Token: 0x06006558 RID: 25944 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<GClass1186> method_8(ContainerCollection collection)
	{
		throw null;
	}

	// Token: 0x040071C1 RID: 29121
	public readonly GClass1203 ItemTemplates;

	// Token: 0x040071C2 RID: 29122
	[CompilerGenerated]
	private GClass1200[] gclass1200_0;

	// Token: 0x040071C3 RID: 29123
	private Dictionary<string, Item> dictionary_0;

	// Token: 0x040071C4 RID: 29124
	private List<ItemFactory.Class945> list_0;

	// Token: 0x040071C5 RID: 29125
	private GClass1484 gclass1484_0;

	// Token: 0x040071C6 RID: 29126
	private readonly Dictionary<string, int> dictionary_1;

	// Token: 0x040071C7 RID: 29127
	private readonly Dictionary<string, ItemFactory.Struct205> dictionary_2;

	// Token: 0x040071C8 RID: 29128
	private GClass3184 gclass3184_0;

	// Token: 0x040071C9 RID: 29129
	private MongoID mongoID_0;

	// Token: 0x02001321 RID: 4897
	[StructLayout(LayoutKind.Auto)]
	public readonly struct Struct205
	{
		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06006559 RID: 25945 RVA: 0x00002050 File Offset: 0x00000250
		public string BriefName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040071CA RID: 29130
		private const int int_0 = 30;

		// Token: 0x040071CB RID: 29131
		public readonly int Version;

		// Token: 0x040071CC RID: 29132
		public readonly string WeaponName;

		// Token: 0x040071CD RID: 29133
		public readonly string FoundName;
	}

	// Token: 0x02001322 RID: 4898
	private sealed class Class945
	{
		// Token: 0x040071CE RID: 29134
		public readonly Item Item;

		// Token: 0x040071CF RID: 29135
		public readonly string[] Children;

		// Token: 0x040071D0 RID: 29136
		public readonly string Name;
	}

	// Token: 0x02001323 RID: 4899
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct133
	{
		// Token: 0x040071D1 RID: 29137
		public Dictionary<string, Item> Items;

		// Token: 0x040071D2 RID: 29138
		public List<Error> DeserializationErrors;
	}

	// Token: 0x02001324 RID: 4900
	public class GClass3275 : Error
	{
		// Token: 0x0600655A RID: 25946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040071D3 RID: 29139
		public readonly GClass1186 FlatItem;
	}

	// Token: 0x02001325 RID: 4901
	public class GClass3276 : Error
	{
		// Token: 0x0600655B RID: 25947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040071D4 RID: 29140
		public readonly GClass1186 FlatItem;
	}

	// Token: 0x02001326 RID: 4902
	[CompilerGenerated]
	[Serializable]
	private sealed class Class946
	{
		// Token: 0x0600655C RID: 25948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(KeyValuePair<string, int> limits)
		{
			throw null;
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(KeyValuePair<string, int> limits)
		{
			throw null;
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(Slot x)
		{
			throw null;
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3(Slot x)
		{
			throw null;
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(KeyValuePair<string, ItemTemplate> x)
		{
			throw null;
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_5(KeyValuePair<string, ItemTemplate> x)
		{
			throw null;
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_6(KeyValuePair<string, ItemTemplate> x)
		{
			throw null;
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_7(Item x)
		{
			throw null;
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_8(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Dictionary<string, IContainer> method_9(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_10(IContainer slot)
		{
			throw null;
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IContainer method_11(IContainer slot)
		{
			throw null;
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ContainerCollection> method_12(ContainerCollection collection)
		{
			throw null;
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_13(IContainer container)
		{
			throw null;
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_14(Item item)
		{
			throw null;
		}

		// Token: 0x040071D5 RID: 29141
		public static readonly ItemFactory.Class946 class946_0;

		// Token: 0x040071D6 RID: 29142
		public static Func<KeyValuePair<string, int>, string> func_0;

		// Token: 0x040071D7 RID: 29143
		public static Func<KeyValuePair<string, int>, int> func_1;

		// Token: 0x040071D8 RID: 29144
		public static Func<Slot, bool> func_2;

		// Token: 0x040071D9 RID: 29145
		public static Func<Slot, string> func_3;

		// Token: 0x040071DA RID: 29146
		public static Func<KeyValuePair<string, ItemTemplate>, bool> func_4;

		// Token: 0x040071DB RID: 29147
		public static Func<KeyValuePair<string, ItemTemplate>, bool> func_5;

		// Token: 0x040071DC RID: 29148
		public static Func<KeyValuePair<string, ItemTemplate>, bool> func_6;

		// Token: 0x040071DD RID: 29149
		public static Func<Item, string> func_7;

		// Token: 0x040071DE RID: 29150
		public static Func<ContainerCollection, string> func_8;

		// Token: 0x040071DF RID: 29151
		public static Func<IContainer, string> func_9;

		// Token: 0x040071E0 RID: 29152
		public static Func<IContainer, IContainer> func_10;

		// Token: 0x040071E1 RID: 29153
		public static Func<ContainerCollection, Dictionary<string, IContainer>> func_11;

		// Token: 0x040071E2 RID: 29154
		public static Func<IContainer, IEnumerable<Item>> func_12;

		// Token: 0x040071E3 RID: 29155
		public static Func<ContainerCollection, IEnumerable<ContainerCollection>> func_13;

		// Token: 0x040071E4 RID: 29156
		public static Func<Item, bool> func_14;
	}

	// Token: 0x02001328 RID: 4904
	[CompilerGenerated]
	private sealed class Class948
	{
		// Token: 0x06006570 RID: 25968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(string key)
		{
			throw null;
		}

		// Token: 0x040071ED RID: 29165
		public HashSet<string> itemNamesSet;

		// Token: 0x040071EE RID: 29166
		public Func<string, bool> func_0;
	}

	// Token: 0x02001329 RID: 4905
	[CompilerGenerated]
	private sealed class Class949
	{
		// Token: 0x06006571 RID: 25969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass1186> method_0(IContainer container)
		{
			throw null;
		}

		// Token: 0x040071EF RID: 29167
		public ContainerCollection collection;

		// Token: 0x040071F0 RID: 29168
		public ItemFactory gclass1483_0;
	}

	// Token: 0x0200132A RID: 4906
	[CompilerGenerated]
	private sealed class Class950
	{
		// Token: 0x06006572 RID: 25970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1186 method_0(Item item)
		{
			throw null;
		}

		// Token: 0x040071F1 RID: 29169
		public IContainer container;

		// Token: 0x040071F2 RID: 29170
		public ItemFactory.Class949 class949_0;
	}
}
