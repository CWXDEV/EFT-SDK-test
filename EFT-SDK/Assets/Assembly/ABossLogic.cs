using System;
using System.Runtime.CompilerServices;

// Token: 0x02000266 RID: 614
public abstract class ABossLogic : GClass362
{
	// Token: 0x06000B97 RID: 2967
	public abstract void SetPatrolMode();

	// Token: 0x06000B98 RID: 2968
	public abstract void Activate();

	// Token: 0x06000B99 RID: 2969
	public abstract void BossLogicUpdate();

	// Token: 0x06000B9A RID: 2970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000B9B RID: 2971
	public abstract void Dispose();

	// Token: 0x04000C6A RID: 3178
	protected BotBoss _bossLogic;
}
