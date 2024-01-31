using System;
using System.Runtime.CompilerServices;
using EFT.UI.Chat;
using TMPro;
using UnityEngine;

// Token: 0x02002E6D RID: 11885
public sealed class GClass3171
{
	// Token: 0x0600EAC1 RID: 60097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Comparer(GClass3171 data1, GClass3171 data2)
	{
		throw null;
	}

	// Token: 0x0400EF6D RID: 61293
	public DateTime LocalDateTime;

	// Token: 0x0400EF6E RID: 61294
	public bool Pinned;

	// Token: 0x0400EF6F RID: 61295
	public TMP_Text UsersCountLabel;

	// Token: 0x0400EF70 RID: 61296
	public ChatMessageSendBlock ChatMessageSendBlock;

	// Token: 0x0400EF71 RID: 61297
	public Action<bool, GClass940, DialogueView> OnDialogueSelected;

	// Token: 0x0400EF72 RID: 61298
	public Action<GClass940> OnDialogueRemoved;

	// Token: 0x0400EF73 RID: 61299
	public GClass1839 SocialNetwork;

	// Token: 0x0400EF74 RID: 61300
	public GClass940 Dialogue;

	// Token: 0x0400EF75 RID: 61301
	public Action<bool, GClass940> OnPinned;

	// Token: 0x0400EF76 RID: 61302
	public Action<GClass940> OnTransferAll;

	// Token: 0x0400EF77 RID: 61303
	public Action<GClass940, Vector2> OnContextMenuCalled;

	// Token: 0x0400EF78 RID: 61304
	public Action<Vector2> OnChannelListCalled;
}
