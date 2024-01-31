using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000620 RID: 1568
public sealed class ProfileDataClass : IGetProfileData
{
	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
	public EPlayerSide? Side
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetRole(out WildSpawnType role, out BotDifficulty difficulty)
	{
		throw null;
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Profile ChooseProfile(List<Profile> profiles2Select, bool withDelete)
	{
		throw null;
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsZeroWave()
	{
		throw null;
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBossOrFollower()
	{
		throw null;
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSpawnOnStart()
	{
		throw null;
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAtZoneByType(BotZone botZone, ZoneLeaveControllerClass botsControllerZonesLeaveController)
	{
		throw null;
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBossOrFollowerByTime()
	{
		throw null;
	}

	// Token: 0x060023DA RID: 9178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSpawnByHour(int timeHour)
	{
		throw null;
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaveInfo[] PrepareToLoadBackend(int count)
	{
		throw null;
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidSpawnType(WildSpawnType wildSpawnType)
	{
		throw null;
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDebugLocalName()
	{
		throw null;
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060023DF RID: 9183 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x060023E0 RID: 9184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDebugData()
	{
		throw null;
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallChooseByData()
	{
		throw null;
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Profile x)
	{
		throw null;
	}

	// Token: 0x0400235C RID: 9052
	[CompilerGenerated]
	private readonly EPlayerSide? nullable_0;

	// Token: 0x0400235D RID: 9053
	[CompilerGenerated]
	private BotSpawnParams botSpawnParams_0;

	// Token: 0x02000621 RID: 1569
	[CompilerGenerated]
	[Serializable]
	private sealed class Class308
	{
		// Token: 0x060023E3 RID: 9187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(DebugBotProfileChooser item)
		{
			throw null;
		}

		// Token: 0x0400235E RID: 9054
		public static readonly ProfileDataClass.Class308 class308_0;

		// Token: 0x0400235F RID: 9055
		public static Func<DebugBotProfileChooser, bool> func_0;
	}
}
