using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200075D RID: 1885
public static class BotSettingsRepoClass
{
	// Token: 0x170007FA RID: 2042
	// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetScavRoleKey(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsHostileToEverybody(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsMidPriorityBossOrFollower(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ShallUseFastAnimator(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
		throw null;
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CountAsBossForStatistics(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSiutable(WildSpawnType test1, WildSpawnType test2)
	{
		throw null;
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ETagStatus GetPhraseTagFromRole(WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(List<WildSpawnType> p0)
	{
		throw null;
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBoss(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsExUsec(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSectant(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsFollower(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBossOrFollower(this WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x04002B02 RID: 11010
	private const string string_0 = "ScavRole/Boss";

	// Token: 0x04002B03 RID: 11011
	private const string string_1 = "ScavRole/Follower";

	// Token: 0x04002B04 RID: 11012
	private const string string_2 = "ScavRole/Sectant";

	// Token: 0x04002B05 RID: 11013
	private static bool bool_0;

	// Token: 0x04002B06 RID: 11014
	private static Dictionary<WildSpawnType, BotSettingsValuesClass> dictionary_0;

	// Token: 0x04002B07 RID: 11015
	private static readonly Dictionary<WildSpawnType, HashSet<WildSpawnType>> dictionary_1;

	// Token: 0x04002B08 RID: 11016
	private static readonly List<WildSpawnType> list_0;

	// Token: 0x04002B09 RID: 11017
	private static readonly List<WildSpawnType> list_1;

	// Token: 0x04002B0A RID: 11018
	private static readonly List<WildSpawnType> list_2;

	// Token: 0x04002B0B RID: 11019
	private static readonly List<WildSpawnType> list_3;

	// Token: 0x04002B0C RID: 11020
	private static readonly List<WildSpawnType> list_4;

	// Token: 0x04002B0D RID: 11021
	private static readonly List<WildSpawnType> list_5;

	// Token: 0x04002B0E RID: 11022
	private static readonly List<WildSpawnType> list_6;

	// Token: 0x04002B0F RID: 11023
	private static readonly List<WildSpawnType> list_7;

	// Token: 0x04002B10 RID: 11024
	private static readonly List<WildSpawnType> list_8;

	// Token: 0x04002B11 RID: 11025
	private static readonly List<WildSpawnType> list_9;
}
