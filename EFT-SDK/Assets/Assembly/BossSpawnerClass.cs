using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.Game.Spawning;
using JetBrains.Annotations;

// Token: 0x020005E3 RID: 1507
public class BossSpawnerClass
{
	// Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBossSpawnDebug()
	{
		throw null;
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Spawn([CanBeNull] BossLocationSpawn wave, BotSpawnParams spawnParams)
	{
		throw null;
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(BossLocationSpawn wave, BotSpawnParams spawnParams)
	{
		throw null;
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_1(BossLocationSpawn wave, BotSpawnParams spawnParams, BotDifficulty difficulty, int followersCount)
	{
		throw null;
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2(GClass588 creationData, BossLocationSpawn wave, BotSpawnParams spawnParams, int followersCount, BotZone botZone, List<ISpawnPoint> openedPositions)
	{
		throw null;
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(BotsGroup botsGroup, List<WildSpawnType> ignoreRoles)
	{
		throw null;
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_4(GClass588 bossCreationData, BotZone zone, int followersCount, BotSpawnParams spawnParams, BossLocationSpawn wave, EPlayerSide side, List<ISpawnPoint> pointsToSpawn, bool forceSpawn)
	{
		throw null;
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(GClass588 creationData, BotZone zone, EPlayerSide side, BossLocationSpawn wave, List<BossLocationSpawnSubData> escorts, BotSpawnParams spawnParams, List<ISpawnPoint> pointsToSpawn, bool forceSpawn)
	{
		throw null;
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_6(GClass588 creationData, ISpawnPoint point, BotZone ss, int followers, GClass589 data, Action<BotOwner> callback)
	{
		throw null;
	}

	// Token: 0x04002221 RID: 8737
	private List<BossSpawnerClass.Class287> list_0;

	// Token: 0x04002222 RID: 8738
	private const float float_0 = 20f;

	// Token: 0x04002223 RID: 8739
	private readonly BotSpawner botSpawner_0;

	// Token: 0x04002224 RID: 8740
	private readonly ISpawnSystem ginterface346_0;

	// Token: 0x04002225 RID: 8741
	private readonly List<BotZone> list_1;

	// Token: 0x04002226 RID: 8742
	private readonly BotZone[] botZone_0;

	// Token: 0x04002227 RID: 8743
	private readonly List<WildSpawnType> list_2;

	// Token: 0x04002228 RID: 8744
	private readonly List<WildSpawnType> list_3;

	// Token: 0x04002229 RID: 8745
	private float float_1;

	// Token: 0x0400222A RID: 8746
	private WildSpawnType wildSpawnType_0;

	// Token: 0x0400222B RID: 8747
	private BotZone botZone_1;

	// Token: 0x0400222C RID: 8748
	private IBotCreator ginterface20_0;

	// Token: 0x020005E4 RID: 1508
	private class Class287
	{
		// Token: 0x0400222D RID: 8749
		public BossLocationSpawn _wave;

		// Token: 0x0400222E RID: 8750
		public BotZone _botZone;
	}

	// Token: 0x020005E5 RID: 1509
	[CompilerGenerated]
	[Serializable]
	private sealed class Class288
	{
		// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotZone x)
		{
			throw null;
		}

		// Token: 0x0400222F RID: 8751
		public static readonly BossSpawnerClass.Class288 class288_0;

		// Token: 0x04002230 RID: 8752
		public static Func<BotZone, bool> func_0;
	}

	// Token: 0x020005E7 RID: 1511
	[CompilerGenerated]
	private sealed class Class289
	{
		// Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04002237 RID: 8759
		public BossSpawnerClass gclass573_0;

		// Token: 0x04002238 RID: 8760
		public BossLocationSpawn wave;

		// Token: 0x04002239 RID: 8761
		public BotSpawnParams spawnParams;
	}

	// Token: 0x020005E8 RID: 1512
	[CompilerGenerated]
	private sealed class Class290
	{
		// Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BossSpawnerClass.Class287 x)
		{
			throw null;
		}

		// Token: 0x0400223A RID: 8762
		public BotZone botZone;
	}

	// Token: 0x020005EA RID: 1514
	[CompilerGenerated]
	private sealed class Class291
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(BotOwner owner)
		{
			throw null;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(BotOwner botBoss)
		{
			throw null;
		}

		// Token: 0x04002244 RID: 8772
		public BossSpawnerClass gclass573_0;

		// Token: 0x04002245 RID: 8773
		public BossSpawnerClass.Class287 spawnProcessData;

		// Token: 0x04002246 RID: 8774
		public GClass588 creationData;

		// Token: 0x04002247 RID: 8775
		public BotZone botZone;

		// Token: 0x04002248 RID: 8776
		public int followersCount;

		// Token: 0x04002249 RID: 8777
		public BotSpawnParams spawnParams;

		// Token: 0x0400224A RID: 8778
		public BossLocationSpawn wave;

		// Token: 0x0400224B RID: 8779
		public EPlayerSide side;

		// Token: 0x0400224C RID: 8780
		public List<ISpawnPoint> openedPositions;
	}

	// Token: 0x020005EB RID: 1515
	[CompilerGenerated]
	private sealed class Class292
	{
		// Token: 0x060022C2 RID: 8898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(EBotState state)
		{
			throw null;
		}

		// Token: 0x0400224D RID: 8781
		public BotOwner owner;

		// Token: 0x0400224E RID: 8782
		public BossSpawnerClass.Class291 class291_0;
	}

	// Token: 0x020005EC RID: 1516
	[CompilerGenerated]
	private sealed class Class293
	{
		// Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(EBotState state)
		{
			throw null;
		}

		// Token: 0x0400224F RID: 8783
		public BotOwner botBoss;

		// Token: 0x04002250 RID: 8784
		public BossSpawnerClass.Class291 class291_0;
	}

	// Token: 0x020005F0 RID: 1520
	[CompilerGenerated]
	private sealed class Class294
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(BotOwner ownerBoss)
		{
			throw null;
		}

		// Token: 0x04002276 RID: 8822
		public GClass589 data;

		// Token: 0x04002277 RID: 8823
		public int followers;

		// Token: 0x04002278 RID: 8824
		public Action<BotOwner> callback;
	}
}
