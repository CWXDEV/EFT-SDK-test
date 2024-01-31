using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200030E RID: 782
public abstract class BaseBrain : AICoreStrategyClass<BotLogicDecision>
{
	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
	public AICoreLayerClass<BotLogicDecision> CurLayerInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateDebug(DebugBotDesition logic)
	{
		throw null;
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint FindPoint(CoverSearchData data, Func<CoverSearchData, CustomNavigationPoint> getCoverPointMain2, bool checkCurrent)
	{
		throw null;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateLayers(List<int> layers)
	{
		throw null;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcActionNextFrame()
	{
		throw null;
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugHandler()
	{
		throw null;
	}

	// Token: 0x060010C1 RID: 4289
	public abstract string ShortName();

	// Token: 0x060010C2 RID: 4290
	protected abstract GClass575 EventsPriority();

	// Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x04000FB2 RID: 4018
	public const int DEBUG_LOGIC = 1000;

	// Token: 0x04000FB3 RID: 4019
	protected BotOwner _owner;

	// Token: 0x04000FB4 RID: 4020
	private readonly GClass57 _debug;
}
