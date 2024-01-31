using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x0200047F RID: 1151
public class BotRandomPlanItemDropper : GClass362
{
	// Token: 0x06001BC4 RID: 7108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotRandomPlanItemDropper Create(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass346 obj)
	{
		throw null;
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Item FindItemToDropToBot()
	{
		throw null;
	}

	// Token: 0x0400179B RID: 6043
	private float _activateTime;

	// Token: 0x0400179C RID: 6044
	private float _nextTimePossible;

	// Token: 0x0400179D RID: 6045
	private const float NO_DROP_SEC_FROM_START = 60f;

	// Token: 0x0400179E RID: 6046
	private const float CHANCE_TO_DROP = 160f;

	// Token: 0x0400179F RID: 6047
	protected readonly List<Item> _cacheItemsList;
}
