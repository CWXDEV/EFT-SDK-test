using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200048D RID: 1165
public class BotGroupTalk
{
	// Token: 0x06001C10 RID: 7184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PhraseSad(BotOwner bot, EPhraseTrigger ePhrase)
	{
		throw null;
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSay(BotOwner bot, EPhraseTrigger ePhrase)
	{
		throw null;
	}

	// Token: 0x040017C9 RID: 6089
	private float _groupAnyPhraseDelay;

	// Token: 0x040017CA RID: 6090
	private float _groupExactlyPhraseDelay;

	// Token: 0x040017CB RID: 6091
	private readonly Dictionary<EPhraseTrigger, float> _nextPossibleTalkTTime;

	// Token: 0x040017CC RID: 6092
	private float _totalNextTime;
}
