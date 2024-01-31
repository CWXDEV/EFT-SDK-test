using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000267 RID: 615
public class GClass363 : ABossLogic, GInterface5
{
	// Token: 0x17000318 RID: 792
	// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsHitted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMoveToAttackPoint(int id)
	{
		throw null;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanStartMoveToAttackPoint(BotOwner askingBot)
	{
		throw null;
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BossLogicUpdate()
	{
		throw null;
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetPatrolMode()
	{
		throw null;
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool WantSuppress()
	{
		throw null;
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWantSuppress()
	{
		throw null;
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportEnemy(IPlayer enemy, Vector3 enemypos, EEnemyPartVisibleType visibleType)
	{
		throw null;
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(DamageInfo arg1, EBodyPart arg2, float arg3)
	{
		throw null;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BotOwner obj)
	{
		throw null;
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(BotOwner bot, IPlayer source)
	{
		throw null;
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(BotOwner follower, FollowerStatusChange status)
	{
		throw null;
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(BotOwner mem)
	{
		throw null;
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x04000C6B RID: 3179
	private const float float_0 = 10f;

	// Token: 0x04000C6C RID: 3180
	private const float float_1 = 4f;

	// Token: 0x04000C6D RID: 3181
	private const float float_2 = 30f;

	// Token: 0x04000C6E RID: 3182
	private const string string_0 = "BossBoarBorn";

	// Token: 0x04000C6F RID: 3183
	private const int int_0 = 2;

	// Token: 0x04000C70 RID: 3184
	private const float float_3 = 5f;

	// Token: 0x04000C71 RID: 3185
	private const float float_4 = 5f;

	// Token: 0x04000C72 RID: 3186
	private const float float_5 = 6400f;

	// Token: 0x04000C73 RID: 3187
	public float _lastTimeHit;

	// Token: 0x04000C74 RID: 3188
	private float float_6;

	// Token: 0x04000C75 RID: 3189
	private float float_7;

	// Token: 0x04000C76 RID: 3190
	private readonly float float_8;

	// Token: 0x04000C77 RID: 3191
	private float float_9;

	// Token: 0x04000C78 RID: 3192
	private float float_10;

	// Token: 0x04000C79 RID: 3193
	private float float_11;

	// Token: 0x04000C7A RID: 3194
	private float float_12;

	// Token: 0x02000268 RID: 616
	[CompilerGenerated]
	private sealed class Class142
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04000C7B RID: 3195
		public BotOwner bot;

		// Token: 0x04000C7C RID: 3196
		public GClass363 gclass363_0;
	}

	// Token: 0x02000269 RID: 617
	[CompilerGenerated]
	private sealed class Class143
	{
		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Vector3 method_0()
		{
			throw null;
		}

		// Token: 0x04000C7D RID: 3197
		public Vector3 posToSuppress;

		// Token: 0x04000C7E RID: 3198
		public Func<Vector3> func_0;
	}
}
