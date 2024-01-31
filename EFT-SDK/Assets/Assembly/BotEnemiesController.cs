using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x020003CD RID: 973
public class BotEnemiesController : GClass362
{
	// Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotEnemiesController Create([NotNull] BotOwner owner)
	{
		throw null;
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x0600175B RID: 5979 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<IPlayer, EnemyInfo> EnemyInfos
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x0600175C RID: 5980 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanPursueAxeman
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x0600175D RID: 5981 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
	public bool HavePursuitableEnemy
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

	// Token: 0x0600175F RID: 5983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(IPlayer info)
	{
		throw null;
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual EnemyInfo AddNew(BotsGroup botsGroup, IPlayer enemy, BotSettingsClass groupInfo)
	{
		throw null;
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(bool globalPossibility)
	{
		throw null;
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInfo(IPlayer enemy, EnemyInfo info)
	{
		throw null;
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFor(EnemyInfo info)
	{
		throw null;
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFor(EnemyInfo info, bool mainEnemy)
	{
		throw null;
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos()
	{
		throw null;
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckEnemyPursuit(AIData aiData)
	{
		throw null;
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEnemy(Player player)
	{
		throw null;
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSameEnemy(EnemyInfo enemyInfo)
	{
		throw null;
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HitTarget(Player target, DamageInfo damageInfo, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(int a, int b)
	{
		throw null;
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShootDone()
	{
		throw null;
	}

	// Token: 0x04001466 RID: 5222
	public const int CLOSE = 6;

	// Token: 0x04001467 RID: 5223
	public const int MID = 8;

	// Token: 0x04001468 RID: 5224
	private readonly EnemyInfo[] SortedInfos;

	// Token: 0x04001469 RID: 5225
	private int _countEnemies;

	// Token: 0x0400146A RID: 5226
	private bool _havePersuitableEnemy;

	// Token: 0x0400146B RID: 5227
	private bool _canPersueAxeman;

	// Token: 0x020003CE RID: 974
	[CompilerGenerated]
	[Serializable]
	private sealed class Class202
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IPlayer x)
		{
			throw null;
		}

		// Token: 0x0400146D RID: 5229
		public static readonly BotEnemiesController.Class202 class202_0;

		// Token: 0x0400146E RID: 5230
		public static Func<IPlayer, bool> func_0;
	}
}
