using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000280 RID: 640
public class BossWarnData : GClass362
{
	// Token: 0x17000338 RID: 824
	// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Player playerToWarn, EWarnMode warnMode, BotOwner closestBot)
	{
		throw null;
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateDistToScavsPlayersAndWarnIntruders(EWarnMode warnMode)
	{
		throw null;
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_1(Player player)
	{
		throw null;
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_2(Player player)
	{
		throw null;
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_3(Player player)
	{
		throw null;
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4(Player player)
	{
		throw null;
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_5(Player player)
	{
		throw null;
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayerDead(Player player)
	{
		throw null;
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(EWarnMode warnMode, BotOwner botToCheck, List<Player> players2Enemies, BotSettingsClass value)
	{
		throw null;
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(List<Player> players2Enemies)
	{
		throw null;
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(Dictionary<int, BotSettingsClass> warnTargets)
	{
		throw null;
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9(Player enemyInfo)
	{
		throw null;
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BotSettingsClass> method_10(List<BotSettingsClass> warnTargets)
	{
		throw null;
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_11(BotSettingsClass enemyInfo)
	{
		throw null;
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(Player player)
	{
		throw null;
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(Player player)
	{
		throw null;
	}

	// Token: 0x04000D0E RID: 3342
	private readonly Dictionary<Player, GClass361> _playersWarned;

	// Token: 0x04000D0F RID: 3343
	private List<BotSettingsClass> _warnTargets;

	// Token: 0x04000D10 RID: 3344
	private readonly Dictionary<int, BotSettingsClass> _warnTargetsByPlayerId;

	// Token: 0x04000D11 RID: 3345
	private readonly HashSet<int> _warningPlayers;

	// Token: 0x02000281 RID: 641
	[CompilerGenerated]
	private sealed class Class153
	{
		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotOwner botToTest)
		{
			throw null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(BotOwner x)
		{
			throw null;
		}

		// Token: 0x04000D12 RID: 3346
		public BossWarnData bossWarnData_0;

		// Token: 0x04000D13 RID: 3347
		public Player playerToWarn;

		// Token: 0x04000D14 RID: 3348
		public Func<BotOwner, float> func_0;
	}
}
