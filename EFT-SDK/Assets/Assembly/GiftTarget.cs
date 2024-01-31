using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020002BE RID: 702
public class GiftTarget
{
	// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDoGift()
	{
		throw null;
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadyToNextGift()
	{
		throw null;
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TargetLost()
	{
		throw null;
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AllowToDropAdditionalGift()
	{
		throw null;
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkGifted()
	{
		throw null;
	}

	// Token: 0x04000E19 RID: 3609
	private const float REPEAT_TRY_GIFT_PLAYER_TIME = 60f;

	// Token: 0x04000E1A RID: 3610
	private const float TIME_TO_LOSE_GIFT_TARGET = 20f;

	// Token: 0x04000E1B RID: 3611
	public IPlayer player;

	// Token: 0x04000E1C RID: 3612
	public float prevBeginGiftNodeTime;

	// Token: 0x04000E1D RID: 3613
	private bool _alreadyGifted;

	// Token: 0x04000E1E RID: 3614
	private int _additionalGiftsGifted;

	// Token: 0x04000E1F RID: 3615
	private readonly int _additionalGiftsLimit;

	// Token: 0x04000E20 RID: 3616
	private bool _canDoAdditionalGift;
}
