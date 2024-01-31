using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200231C RID: 8988
public static class GClass2513
{
	// Token: 0x17001F0D RID: 7949
	// (get) Token: 0x0600B5E4 RID: 46564 RVA: 0x00002050 File Offset: 0x00000250
	public static IEnumerable<string> CurrencyNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B5E5 RID: 46565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
		throw null;
	}

	// Token: 0x0600B5E6 RID: 46566 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsCurrencyId(string id)
	{
		throw null;
	}

	// Token: 0x0600B5E7 RID: 46567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetCurrencyType(string id, out ECurrencyType type)
	{
		throw null;
	}

	// Token: 0x0600B5E8 RID: 46568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ECurrencyType GetCurrencyTypeByName(string name)
	{
		throw null;
	}

	// Token: 0x0600B5E9 RID: 46569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ECurrencyType GetCurrencyTypeById(string id)
	{
		throw null;
	}

	// Token: 0x0600B5EA RID: 46570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCurrencyId(ECurrencyType currencyType)
	{
		throw null;
	}

	// Token: 0x0600B5EB RID: 46571 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCurrencyCharById(string templateId)
	{
		throw null;
	}

	// Token: 0x0600B5EC RID: 46572 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCurrencyChar(ECurrencyType currencyType)
	{
		throw null;
	}

	// Token: 0x0600B5ED RID: 46573 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCurrencyString(ECurrencyType currencyType)
	{
		throw null;
	}

	// Token: 0x0400B978 RID: 47480
	public const string ROUBLE_ID = "5449016a4bdc2d6f028b456f";

	// Token: 0x0400B979 RID: 47481
	public const string DOLLAR_ID = "5696686a4bdc2da3298b456a";

	// Token: 0x0400B97A RID: 47482
	public const string EURO_ID = "569668774bdc2da2298b4568";

	// Token: 0x0400B97B RID: 47483
	public const string ROUBLE_STACK_ID = "544901bf4bdc2ddf018b456d";

	// Token: 0x0400B97C RID: 47484
	public static readonly Dictionary<ECurrencyType, Color> CurrencyColors;

	// Token: 0x0400B97D RID: 47485
	public static readonly Dictionary<ECurrencyType, GClass2513.GClass2514> CurrencyIndex;

	// Token: 0x0400B97E RID: 47486
	private static readonly Dictionary<string, ECurrencyType> dictionary_0;

	// Token: 0x0400B97F RID: 47487
	private static readonly Dictionary<string, ECurrencyType> dictionary_1;

	// Token: 0x0400B980 RID: 47488
	private static readonly Dictionary<string, string> dictionary_2;

	// Token: 0x0400B981 RID: 47489
	private static readonly List<string> list_0;

	// Token: 0x0400B982 RID: 47490
	private static bool bool_0;

	// Token: 0x0200231D RID: 8989
	public sealed class GClass2514
	{
		// Token: 0x0600B5EE RID: 46574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasId(string id)
		{
			throw null;
		}

		// Token: 0x0400B983 RID: 47491
		public readonly ECurrencyType Type;

		// Token: 0x0400B984 RID: 47492
		public readonly string Char;

		// Token: 0x0400B985 RID: 47493
		public readonly string Name;

		// Token: 0x0400B986 RID: 47494
		public readonly string Id;

		// Token: 0x0400B987 RID: 47495
		[CanBeNull]
		public readonly List<string> FallbackIds;

		// Token: 0x0400B988 RID: 47496
		private readonly HashSet<string> hashSet_0;
	}
}
