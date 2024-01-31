using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02000FD8 RID: 4056
public class GClass1203 : Dictionary<string, ItemTemplate>
{
	// Token: 0x06005534 RID: 21812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<ItemTemplate> GetItemTemplates()
	{
		throw null;
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceKey[] GetResourceKeys(Func<ItemTemplate, bool> predicate)
	{
		throw null;
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06005537 RID: 21815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ResourceType GetResourceType(ItemTemplate template, ResourceKey resource)
	{
		throw null;
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(GClass2529 template, string key)
	{
		throw null;
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct105 GetResourceTypeByBundlePath(string bundlePath)
	{
		throw null;
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<ItemTemplate> GetAllCompatibleTemplates(IEnumerable<ItemTemplate> parentTemplates, Dictionary<ItemTemplate, ItemTemplate[]> allChildrenDict)
	{
		throw null;
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerable<ItemTemplate> smethod_0(GClass2529 parentTemplate, Dictionary<ItemTemplate, ItemTemplate[]> allChildrenDict)
	{
		throw null;
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerable<ItemTemplate> smethod_1(ItemTemplate template, IDictionary<ItemTemplate, ItemTemplate[]> allChildrenDict)
	{
		throw null;
	}

	// Token: 0x040060DC RID: 24796
	private Dictionary<string, GStruct105> dictionary_0;

	// Token: 0x02000FD9 RID: 4057
	[CompilerGenerated]
	[Serializable]
	private sealed class Class786
	{
		// Token: 0x0600553D RID: 21821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ResourceKey method_1(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ItemFilter> method_2(Slot x)
		{
			throw null;
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<string> method_3(ItemFilter x)
		{
			throw null;
		}

		// Token: 0x040060DD RID: 24797
		public static readonly GClass1203.Class786 class786_0;

		// Token: 0x040060DE RID: 24798
		public static Func<ItemTemplate, bool> func_0;

		// Token: 0x040060DF RID: 24799
		public static Func<ItemTemplate, ResourceKey> func_1;

		// Token: 0x040060E0 RID: 24800
		public static Func<Slot, IEnumerable<ItemFilter>> func_2;

		// Token: 0x040060E1 RID: 24801
		public static Func<ItemFilter, IEnumerable<string>> func_3;
	}

	// Token: 0x02000FDA RID: 4058
	[CompilerGenerated]
	private sealed class Class787
	{
		// Token: 0x06005541 RID: 21825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x040060E2 RID: 24802
		public Func<ItemTemplate, bool> predicate;
	}

	// Token: 0x02000FDB RID: 4059
	[CompilerGenerated]
	private sealed class Class788
	{
		// Token: 0x06005542 RID: 21826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ItemTemplate> method_0(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x040060E3 RID: 24803
		public Dictionary<ItemTemplate, ItemTemplate[]> allChildrenDict;
	}

	// Token: 0x02000FDC RID: 4060
	[CompilerGenerated]
	private sealed class Class789
	{
		// Token: 0x06005543 RID: 21827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(string x)
		{
			throw null;
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ItemTemplate method_1(string x)
		{
			throw null;
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ItemTemplate> method_2(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x040060E4 RID: 24804
		public GClass1203 itemTemplates;

		// Token: 0x040060E5 RID: 24805
		public GClass2529 parentTemplate;

		// Token: 0x040060E6 RID: 24806
		public Dictionary<ItemTemplate, ItemTemplate[]> allChildrenDict;
	}

	// Token: 0x02000FDD RID: 4061
	[CompilerGenerated]
	private sealed class Class790
	{
		// Token: 0x06005546 RID: 21830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ItemTemplate> method_0(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x040060E7 RID: 24807
		public IDictionary<ItemTemplate, ItemTemplate[]> allChildrenDict;
	}
}
