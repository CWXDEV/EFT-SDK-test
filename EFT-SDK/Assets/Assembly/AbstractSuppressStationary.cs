using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000467 RID: 1127
public abstract class AbstractSuppressStationary : GClass362
{
	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B31 RID: 6961 RVA: 0x00002050 File Offset: 0x00000250
	public float EndSuppressTime
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

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06001B32 RID: 6962 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B33 RID: 6963 RVA: 0x00002050 File Offset: 0x00000250
	public float StartArtSupress
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

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06001B34 RID: 6964
	public abstract bool Usable { get; }

	// Token: 0x06001B35 RID: 6965
	public abstract bool CanStartSuppressAt(Vector3 enemyPos);

	// Token: 0x06001B36 RID: 6966
	public abstract bool CanStartSupressEnemy(EnemyInfo memoryGoalEnemy);

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInProcess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsReady()
	{
		throw null;
	}

	// Token: 0x06001B39 RID: 6969
	public abstract void StopExternal(Vector3 badPos);

	// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPeriod(float sec)
	{
		throw null;
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Stop()
	{
		throw null;
	}

	// Token: 0x0400174B RID: 5963
	private readonly BotSuppressStationary _suppressStationary;
}
