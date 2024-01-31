using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200048F RID: 1167
public class BotZoneGroupsDictionary : Dictionary<BotZone, GClass492>
{
	// Token: 0x14000037 RID: 55
	// (add) Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotsGroup> OnAddGroup
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(BotZone zone, EPlayerSide side, WildSpawnType spawnType, out BotsGroup group, bool isBossOrFollower)
	{
		throw null;
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(BotZone zone, EPlayerSide side, BotsGroup gr, bool isBossOrFollower)
	{
		throw null;
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNoKey(BotsGroup gr, BotZone zone)
	{
		throw null;
	}

	// Token: 0x040017D1 RID: 6097
	[CompilerGenerated]
	private Action<BotsGroup> action_0;

	// Token: 0x02000490 RID: 1168
	[CompilerGenerated]
	[Serializable]
	private sealed class Class235
	{
		// Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(BotsGroup x)
		{
			throw null;
		}

		// Token: 0x040017D2 RID: 6098
		public static readonly BotZoneGroupsDictionary.Class235 class235_0;

		// Token: 0x040017D3 RID: 6099
		public static Func<BotsGroup, int> func_0;
	}
}
