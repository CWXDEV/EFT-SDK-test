using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using EFT;
using JetBrains.Annotations;

// Token: 0x020003CF RID: 975
public class BotEnemyChooser : GClass362
{
	// Token: 0x0600176D RID: 5997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotEnemyChooser Create(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual EnemyInfo FindDangerEnemy()
	{
		throw null;
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EnemyInfo BetterEnemy(List<EnemyInfo> enemiesInfos, bool isLogging)
	{
		throw null;
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual float CalcWeight(float distSqr, EnemyInfo enemyInfo)
	{
		throw null;
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x0400146F RID: 5231
	private StringBuilder _loggerBuilder;

	// Token: 0x04001470 RID: 5232
	private int _oldHashBetterLog;

	// Token: 0x04001471 RID: 5233
	private int _oldHashPrepareLog;
}
