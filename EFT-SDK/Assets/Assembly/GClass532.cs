using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;

// Token: 0x020004F5 RID: 1269
public class GClass532 : Singleton<GClass532>
{
	// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSettings(BotPresetClass[] botPresets, GClass525[] botScatterings, BotLocationModifier botLocationModifier)
	{
		throw null;
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotDifficultySettingsClass GetSettings(BotDifficulty difficulty, WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x04001B47 RID: 6983
	public BotLocationModifier BotLocationModifier;

	// Token: 0x04001B48 RID: 6984
	public BotCurvSettings _CurvSettings;

	// Token: 0x04001B49 RID: 6985
	private readonly GClass535<BotDifficulty, WildSpawnType, BotDifficultySettingsClass> gclass535_0;

	// Token: 0x020004F6 RID: 1270
	[CompilerGenerated]
	private sealed class Class250
	{
		// Token: 0x04001B4A RID: 6986
		public WildSpawnType role;
	}

	// Token: 0x020004F7 RID: 1271
	[CompilerGenerated]
	private sealed class Class251
	{
		// Token: 0x06001F91 RID: 8081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotPresetClass x)
		{
			throw null;
		}

		// Token: 0x04001B4B RID: 6987
		public BotDifficulty difficulty;

		// Token: 0x04001B4C RID: 6988
		public GClass532.Class250 class250_0;
	}
}
