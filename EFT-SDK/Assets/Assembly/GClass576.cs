using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020005FD RID: 1533
public class GClass576
{
	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x06002312 RID: 8978 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002313 RID: 8979 RVA: 0x00002050 File Offset: 0x00000250
	public BossLocationSpawn[] BossSpawnWaves
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x06002314 RID: 8980 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002315 RID: 8981 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveSectants
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GClass576 smethod_0(BossLocationSpawn[] bossWaves, Action<BossLocationSpawn> spawnBossAction)
	{
		throw null;
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(BossLocationSpawn[] bossWaves)
	{
		throw null;
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run(EBotsSpawnMode spawnMode = EBotsSpawnMode.Anyway)
	{
		throw null;
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BossLocationSpawn wave)
	{
		throw null;
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(BossLocationSpawn wave, [CanBeNull] GClass551.GInterface13 timer)
	{
		throw null;
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(BossLocationSpawn wave, string trgId, [CanBeNull] GClass551.GInterface13 timer)
	{
		throw null;
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(BossLocationSpawn wave)
	{
		throw null;
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x040022C1 RID: 8897
	private readonly List<GClass551.GInterface13> list_0;

	// Token: 0x040022C2 RID: 8898
	private Action<BossLocationSpawn> action_0;

	// Token: 0x040022C3 RID: 8899
	public readonly List<WaveInfo> BotsCountProfiles;

	// Token: 0x040022C4 RID: 8900
	[CompilerGenerated]
	private BossLocationSpawn[] bossLocationSpawn_0;

	// Token: 0x040022C5 RID: 8901
	private GClass577 gclass577_0;

	// Token: 0x040022C6 RID: 8902
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040022C7 RID: 8903
	private bool bool_1;

	// Token: 0x020005FE RID: 1534
	[CompilerGenerated]
	private sealed class Class297
	{
		// Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040022C8 RID: 8904
		public BossLocationSpawn wave;

		// Token: 0x040022C9 RID: 8905
		public GClass576 gclass576_0;

		// Token: 0x040022CA RID: 8906
		public GClass551.GInterface13 timer;
	}

	// Token: 0x020005FF RID: 1535
	[CompilerGenerated]
	private sealed class Class298
	{
		// Token: 0x040022CB RID: 8907
		public GClass576 gclass576_0;

		// Token: 0x040022CC RID: 8908
		public BossLocationSpawn wave;

		// Token: 0x040022CD RID: 8909
		public GClass551.GInterface13 timer;
	}

	// Token: 0x02000600 RID: 1536
	[CompilerGenerated]
	private sealed class Class299
	{
		// Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string eventId)
		{
			throw null;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string eventId, Vector3 position)
		{
			throw null;
		}

		// Token: 0x040022CE RID: 8910
		public Action<string> onEvent;

		// Token: 0x040022CF RID: 8911
		public GClass595.GDelegate21 delActions;

		// Token: 0x040022D0 RID: 8912
		public GClass576.Class298 class298_0;
	}

	// Token: 0x02000601 RID: 1537
	[CompilerGenerated]
	private sealed class Class300
	{
		// Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040022D1 RID: 8913
		public GClass576 gclass576_0;

		// Token: 0x040022D2 RID: 8914
		public BossLocationSpawn wave;
	}
}
