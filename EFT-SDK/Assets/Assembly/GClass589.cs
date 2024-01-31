using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200061F RID: 1567
public sealed class GClass589 : IGetProfileData
{
	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x060023BF RID: 9151 RVA: 0x00002050 File Offset: 0x00000250
	public EPlayerSide? Side
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetRole(out WildSpawnType role, out BotDifficulty difficulty)
	{
		throw null;
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Profile ChooseProfile(List<Profile> profiles2Select, bool withDelete)
	{
		throw null;
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaveInfo[] PrepareToLoadBackend(int count)
	{
		throw null;
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidSpawnType(WildSpawnType wildSpawnType)
	{
		throw null;
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SameSide(EPlayerSide side)
	{
		throw null;
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDebugLocalName()
	{
		throw null;
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
	public BotSpawnParams SpawnParams
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDebugData()
	{
		throw null;
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallChooseByData()
	{
		throw null;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsZeroWave()
	{
		throw null;
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBossOrFollower()
	{
		throw null;
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSpawnOnStart()
	{
		throw null;
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAtZoneByType(BotZone botZone, ZoneLeaveControllerClass botsControllerZonesLeaveController)
	{
		throw null;
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSpawnByHour(int timeHour)
	{
		throw null;
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(int timeHour)
	{
		throw null;
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBossOrFollowerByTime()
	{
		throw null;
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(Profile x)
	{
		throw null;
	}

	// Token: 0x04002355 RID: 9045
	private const float float_0 = 10f;

	// Token: 0x04002356 RID: 9046
	public const float LESS_TIME_SPAWN_SEC = 60f;

	// Token: 0x04002357 RID: 9047
	private readonly WildSpawnType wildSpawnType_0;

	// Token: 0x04002358 RID: 9048
	private readonly BotDifficulty botDifficulty_0;

	// Token: 0x04002359 RID: 9049
	private readonly float float_1;

	// Token: 0x0400235A RID: 9050
	[CompilerGenerated]
	private readonly EPlayerSide? nullable_0;

	// Token: 0x0400235B RID: 9051
	[CompilerGenerated]
	private BotSpawnParams botSpawnParams_0;
}
