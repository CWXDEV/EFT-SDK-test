using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;

// Token: 0x020002CB RID: 715
public class BotLootOpener : GClass362
{
	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Interact(LootableContainer door, EInteractionType Etype)
	{
		throw null;
	}

	// Token: 0x04000E73 RID: 3699
	public const float DIR_SIDE_MAX_SQRT = 4f;

	// Token: 0x04000E74 RID: 3700
	private const float CHECK_RUN_DIST = 27.039997f;

	// Token: 0x04000E75 RID: 3701
	private const float MAX_DIST = 49f;

	// Token: 0x04000E76 RID: 3702
	private const float OPEN_DIST = 16f;

	// Token: 0x04000E77 RID: 3703
	private LootableContainer _curLoot;

	// Token: 0x04000E78 RID: 3704
	private float _nextPosibleDoorOpenTime;

	// Token: 0x04000E79 RID: 3705
	private float _traversingEnd;

	// Token: 0x04000E7A RID: 3706
	private float _deltaTime;

	// Token: 0x04000E7B RID: 3707
	private float _searchCloseDoorTime;

	// Token: 0x04000E7C RID: 3708
	private bool _traversingLink;
}
