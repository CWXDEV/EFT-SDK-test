using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using Newtonsoft.Json;

// Token: 0x02001316 RID: 4886
public static class GClass1482
{
	// Token: 0x06006524 RID: 25892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass1482.Class939 smethod_0(Type type)
	{
		throw null;
	}

	// Token: 0x06006525 RID: 25893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass1482.Class937 smethod_1(this GClass1482.Class939 typeMetaInfo, string name)
	{
		throw null;
	}

	// Token: 0x06006526 RID: 25894 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item CreateItem(Item item, GClass748 properties)
	{
		throw null;
	}

	// Token: 0x06006527 RID: 25895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, object> GetItemProperties(Item item)
	{
		throw null;
	}

	// Token: 0x06006528 RID: 25896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, object> smethod_2<T>(T obj)
	{
		throw null;
	}

	// Token: 0x06006529 RID: 25897 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_3<T, U, V>(V item, T[] members, IDictionary<string, object> result, Func<V, T, object> getValue) where T : GClass1482.Class936<U> where U : MemberInfo
	{
		throw null;
	}

	// Token: 0x0600652A RID: 25898 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CreateItemLocation<T>([CanBeNull] GClass748 locationData)
	{
		throw null;
	}

	// Token: 0x0600652B RID: 25899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass748 SaveItemLocation(LocationInGrid itemLocation)
	{
		throw null;
	}

	// Token: 0x0600652C RID: 25900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass748 SaveItemLocation(int stackSlotPosition)
	{
		throw null;
	}

	// Token: 0x040071AC RID: 29100
	private static readonly Dictionary<Type, GClass1482.Class939> dictionary_0;

	// Token: 0x02001317 RID: 4887
	private class Class936<T> where T : MemberInfo
	{
		// Token: 0x040071AD RID: 29101
		public readonly string Name;

		// Token: 0x040071AE RID: 29102
		public readonly T MemberInfo;

		// Token: 0x040071AF RID: 29103
		public readonly JsonPropertyAttribute JsonPropertyAttribute;

		// Token: 0x040071B0 RID: 29104
		public readonly GAttribute22[] ComponentAtrributes;

		// Token: 0x040071B1 RID: 29105
		public readonly DefaultValueAttribute DefaultValueAttribute;

		// Token: 0x040071B2 RID: 29106
		public readonly GAttribute21 DiffableAttribute;
	}

	// Token: 0x02001318 RID: 4888
	private sealed class Class937 : GClass1482.Class936<FieldInfo>
	{
		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x00002050 File Offset: 0x00000250
		public Type FieldType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetValue(object obj)
		{
			throw null;
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetValue(object obj, object value)
		{
			throw null;
		}
	}

	// Token: 0x02001319 RID: 4889
	private sealed class Class938 : GClass1482.Class936<PropertyInfo>
	{
		// Token: 0x06006530 RID: 25904 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetValue(object it, object[] obj)
		{
			throw null;
		}
	}

	// Token: 0x0200131A RID: 4890
	private sealed class Class939
	{
		// Token: 0x06006531 RID: 25905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1482.Class937 GetField(string name)
		{
			throw null;
		}

		// Token: 0x040071B3 RID: 29107
		private readonly Type type_0;

		// Token: 0x040071B4 RID: 29108
		public readonly string Name;

		// Token: 0x040071B5 RID: 29109
		public readonly GClass1482.Class937[] Fields;

		// Token: 0x040071B6 RID: 29110
		public readonly GClass1482.Class938[] Properties;

		// Token: 0x040071B7 RID: 29111
		private readonly Dictionary<string, GClass1482.Class937> dictionary_0;

		// Token: 0x0200131B RID: 4891
		[CompilerGenerated]
		[Serializable]
		private sealed class Class940
		{
			// Token: 0x06006532 RID: 25906 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1482.Class937 method_0(FieldInfo m)
			{
				throw null;
			}

			// Token: 0x06006533 RID: 25907 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1482.Class938 method_1(PropertyInfo m)
			{
				throw null;
			}

			// Token: 0x040071B8 RID: 29112
			public static readonly GClass1482.Class939.Class940 class940_0;

			// Token: 0x040071B9 RID: 29113
			public static Func<FieldInfo, GClass1482.Class937> func_0;

			// Token: 0x040071BA RID: 29114
			public static Func<PropertyInfo, GClass1482.Class938> func_1;
		}
	}

	// Token: 0x0200131C RID: 4892
	[CompilerGenerated]
	[Serializable]
	private sealed class Class941
	{
		// Token: 0x06006534 RID: 25908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Type t)
		{
			throw null;
		}

		// Token: 0x040071BB RID: 29115
		public static readonly GClass1482.Class941 class941_0;
	}

	// Token: 0x0200131D RID: 4893
	[CompilerGenerated]
	private sealed class Class942
	{
		// Token: 0x06006535 RID: 25909 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1482.Class937 f)
		{
			throw null;
		}

		// Token: 0x040071BC RID: 29116
		public string name;
	}

	// Token: 0x0200131E RID: 4894
	[CompilerGenerated]
	private sealed class Class943
	{
		// Token: 0x06006536 RID: 25910 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1482.Class938 prop)
		{
			throw null;
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass1482.Class937 prop)
		{
			throw null;
		}

		// Token: 0x040071BD RID: 29117
		public IItemComponent component;
	}

	// Token: 0x0200131F RID: 4895
	[CompilerGenerated]
	[Serializable]
	private sealed class Class944<TObject>
	{
		// Token: 0x06006538 RID: 25912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object method_0(TObject it, GClass1482.Class937 member)
		{
			throw null;
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object method_1(TObject it, GClass1482.Class938 member)
		{
			throw null;
		}

		// Token: 0x040071BE RID: 29118
		public static readonly GClass1482.Class944<TObject> class944_0;

		// Token: 0x040071BF RID: 29119
		public static Func<TObject, GClass1482.Class937, object> func_0;

		// Token: 0x040071C0 RID: 29120
		public static Func<TObject, GClass1482.Class938, object> func_1;
	}
}
