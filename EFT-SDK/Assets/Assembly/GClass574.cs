using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020005F4 RID: 1524
public abstract class GClass574
{
	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x060022D4 RID: 8916
	public abstract List<int> LayersToActivate { get; }

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x060022D5 RID: 8917
	public abstract List<int> LayersToDeActivate { get; }

	// Token: 0x060022D6 RID: 8918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool Start(string cause)
	{
		throw null;
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x060022DA RID: 8922
	protected abstract bool CanActivate(BotOwner bot);

	// Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void BotEventActive(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x04002291 RID: 8849
	protected bool bool_0;

	// Token: 0x04002292 RID: 8850
	protected readonly BotsClass gclass579_0;

	// Token: 0x04002293 RID: 8851
	public const int FORCE_ATTACK_EVENT = 501;

	// Token: 0x04002294 RID: 8852
	public const int PURSUIT_LAYER = 502;

	// Token: 0x04002295 RID: 8853
	public const int KHOROVOD_CHRISTMAS_EVENT_LAYER = 503;

	// Token: 0x04002296 RID: 8854
	public const int FOLLOW_PLAYER_LAYER = 504;

	// Token: 0x020005F5 RID: 1525
	[CompilerGenerated]
	private sealed class Class295
	{
		// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(BaseBrain state)
		{
			throw null;
		}

		// Token: 0x04002297 RID: 8855
		public GClass574 gclass574_0;

		// Token: 0x04002298 RID: 8856
		public BotOwner bot;
	}
}
