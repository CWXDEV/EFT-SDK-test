using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x020004F1 RID: 1265
public static class GClass530
{
	// Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotDifficulty CheckOnExclude(BotDifficulty d, WildSpawnType wst)
	{
		throw null;
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotSettingsComponents GetSettings(BotDifficulty difficulty, WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Save(GClass535<BotDifficulty, WildSpawnType, BotSettingsComponents> internalSettings)
	{
		throw null;
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Save(BotDifficulty difficulty, WildSpawnType botRole, BotSettingsComponents internalSettings, Func<string, BotDifficulty, string> jsonPostprocessor = null)
	{
		throw null;
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LoadCoreByString()
	{
		throw null;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LoadDifficultyStringInternal(BotDifficulty botDifficulty, WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LoadInternalCoreByString()
	{
		throw null;
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoadInternal(out GClass529 core)
	{
		throw null;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoadExternal()
	{
		throw null;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Load()
	{
		throw null;
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Save(bool codeSettings)
	{
		throw null;
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static WildSpawnType smethod_0(WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static BotSettingsComponents smethod_1(BotDifficulty d, WildSpawnType role, bool external)
	{
		throw null;
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2(BotDifficulty botDifficulty, WildSpawnType role, BotSettingsComponents settings, Func<string, BotDifficulty, string> jsonPostprocessor = null)
	{
		throw null;
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_3(BotDifficulty botDifficulty, WildSpawnType role, bool dropSettings)
	{
		throw null;
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(string path, string data)
	{
		throw null;
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00002050 File Offset: 0x00000250
	private static WildSpawnType[] WildSpawnType_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04001B1F RID: 6943
	private const string string_0 = "Settings/{0}_{1}_BotGlobalSettings";

	// Token: 0x04001B20 RID: 6944
	private static readonly string string_1;

	// Token: 0x04001B21 RID: 6945
	private static readonly string string_2;

	// Token: 0x04001B22 RID: 6946
	private static readonly string string_3;

	// Token: 0x04001B23 RID: 6947
	public static GClass535<BotDifficulty, WildSpawnType, BotSettingsComponents> AllSettings;

	// Token: 0x04001B24 RID: 6948
	public static GClass529 Core;

	// Token: 0x04001B25 RID: 6949
	public static Dictionary<WildSpawnType, WildSpawnType> MappingSettings;

	// Token: 0x04001B26 RID: 6950
	public static Dictionary<WildSpawnType, List<BotDifficulty>> ExcludedDifficulties;

	// Token: 0x04001B27 RID: 6951
	private static bool bool_0;
}
