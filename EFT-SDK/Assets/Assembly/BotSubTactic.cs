using System;
using System.Runtime.CompilerServices;

// Token: 0x02000473 RID: 1139
public class BotSubTactic : GClass362
{
	// Token: 0x14000032 RID: 50
	// (add) Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotsGroup.BotCurrentTactic> OnTacticChange
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

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
	public BotsGroup.BotCurrentTactic Tactic
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

	// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float SetTactic(BotsGroup.BotCurrentTactic tactic, bool shallAutoReturnToAttack = false, float delta = -1f)
	{
		throw null;
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastTactic()
	{
		throw null;
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CoverSearchType SearchTypeGoToCover(CoverShootType shootType)
	{
		throw null;
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CoverSearchType SearchTypeAttackMoving(CoverShootType shootType)
	{
		throw null;
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CoverSearchType SearchTypeAttack(CoverShootType shootType)
	{
		throw null;
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CoverSearchType SearchRunToCover(CoverShootType shootType)
	{
		throw null;
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CoverSearchType SearchTypeForCover(CoverShootType shootType)
	{
		throw null;
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001766 RID: 5990
	protected BotsGroup.BotCurrentTactic _lastTactic;
}
