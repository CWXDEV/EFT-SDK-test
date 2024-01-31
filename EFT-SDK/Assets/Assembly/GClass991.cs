using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.Data;
using EFT;

// Token: 0x02000D64 RID: 3428
public class GClass991 : GInterface348
{
	// Token: 0x060048F2 RID: 18674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPhrasesData(BtrDriverSoundBankContainer soundContainer)
	{
		throw null;
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetNamedStationTrigger(string pathID, out EBtrDriverPhraseTrigger trigger)
	{
		throw null;
	}

	// Token: 0x060048F4 RID: 18676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetGreetingTrigger(EPlayerSide playerSide, out EBtrDriverPhraseTrigger trigger)
	{
		throw null;
	}

	// Token: 0x060048F5 RID: 18677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetBank(EBtrDriverPhraseTrigger trigger, out SoundBankWithSettings bank)
	{
		throw null;
	}

	// Token: 0x040053B9 RID: 21433
	private BtrDriverSoundBankContainer btrDriverSoundBankContainer_0;

	// Token: 0x040053BA RID: 21434
	private readonly Dictionary<string, EBtrDriverPhraseTrigger> dictionary_0;

	// Token: 0x040053BB RID: 21435
	private readonly Dictionary<EPlayerSide, EBtrDriverPhraseTrigger> dictionary_1;
}
