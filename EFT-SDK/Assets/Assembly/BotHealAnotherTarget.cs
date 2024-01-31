using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020003F6 RID: 1014
public class BotHealAnotherTarget : GClass362
{
	// Token: 0x1400002A RID: 42
	// (add) Token: 0x06001867 RID: 6247 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001868 RID: 6248 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPlayer> OnHealAsked
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

	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06001869 RID: 6249 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600186A RID: 6250 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInProcess
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

	// Token: 0x0600186B RID: 6251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HealAsk(IPlayer target)
	{
		throw null;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallDoHeal()
	{
		throw null;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool isOok)
	{
		throw null;
	}

	// Token: 0x04001534 RID: 5428
	private const float MAX_SDIST_TO_START_HEAL = 4f;

	// Token: 0x04001535 RID: 5429
	public IPlayer Target;

	// Token: 0x04001536 RID: 5430
	private float _nextPosible;

	// Token: 0x04001537 RID: 5431
	private float _askTime;
}
