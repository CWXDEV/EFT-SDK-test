using System;
using System.Runtime.CompilerServices;

// Token: 0x02000474 RID: 1140
public class BotTacticData : GClass362
{
	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00002050 File Offset: 0x00000250
	public BotsGroup.BotCurrentTactic Tactic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B88 RID: 7048 RVA: 0x00002050 File Offset: 0x00000250
	public BotSubTactic SubTactic
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

	// Token: 0x06001B89 RID: 7049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCurTactic(BotsGroup.BotCurrentTactic tactic)
	{
		throw null;
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AggressionChange(float val)
	{
		throw null;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTactic(BotsGroup.BotCurrentTactic tactic, bool shallAutoReturnToAttack = false, float delta = -1f)
	{
		throw null;
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateChangeTactics()
	{
		throw null;
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001769 RID: 5993
	public float AggressionCoef;

	// Token: 0x0400176A RID: 5994
	private bool _shallReturnToAttack;

	// Token: 0x0400176B RID: 5995
	private float _returnToAttackTime;
}
