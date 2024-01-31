using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.MovingPlatforms;

// Token: 0x0200026E RID: 622
public class GClass367 : ABossLogic
{
	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000BCE RID: 3022 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnScoutWannaAttack
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

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveTrainInfo
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

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
	public AIPlaceInfo TrainBounds
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

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x00002050 File Offset: 0x00000250
	public int GoodCovers
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

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00002050 File Offset: 0x00000250
	public AIPlaceInfo CorePlace
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
	public bool FightAtZone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
	public bool BossShallAttack
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

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
	public bool AssaultFollowersShallAttack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
	public bool SecurityFightAtHomeEnought
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
	public bool SecurityWannaAttack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
	public int SecurityCount
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

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetPatrolMode()
	{
		throw null;
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BossLogicUpdate()
	{
		throw null;
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyInfo FindDangerEnemyFor(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SeenLessTimeBoss(float delta)
	{
		throw null;
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SeenLessTimeFollowersSecurity(float delta, out int count)
	{
		throw null;
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OneScoutDoAttack(BotOwner scoutAttack)
	{
		throw null;
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHaveCover(int id, bool haveCover)
	{
		throw null;
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Locomotive.ETravelState obj)
	{
		throw null;
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BotOwner follower, FollowerStatusChange status)
	{
		throw null;
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(int obj)
	{
		throw null;
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x04000C8D RID: 3213
	private const int int_0 = 4;

	// Token: 0x04000C8E RID: 3214
	private const string string_0 = "BossGluhar";

	// Token: 0x04000C8F RID: 3215
	private const string string_1 = "BossGluharAlt";

	// Token: 0x04000C90 RID: 3216
	private const string string_2 = "TrainBounds";

	// Token: 0x04000C91 RID: 3217
	public bool TrainSecure;

	// Token: 0x04000C92 RID: 3218
	public bool _assaultFollowersShallAttack;

	// Token: 0x04000C93 RID: 3219
	private readonly bool bool_0;

	// Token: 0x04000C94 RID: 3220
	private bool bool_1;

	// Token: 0x04000C95 RID: 3221
	private float float_0;

	// Token: 0x04000C96 RID: 3222
	private float float_1;

	// Token: 0x04000C97 RID: 3223
	private readonly Dictionary<int, bool> dictionary_0;

	// Token: 0x04000C98 RID: 3224
	[CompilerGenerated]
	private Action<BotOwner> action_0;

	// Token: 0x04000C99 RID: 3225
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04000C9A RID: 3226
	[CompilerGenerated]
	private AIPlaceInfo aiplaceInfo_0;

	// Token: 0x04000C9B RID: 3227
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04000C9C RID: 3228
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x04000C9D RID: 3229
	[CompilerGenerated]
	private int int_2;
}
