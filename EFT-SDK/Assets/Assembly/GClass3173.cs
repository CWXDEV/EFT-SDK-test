using System;
using System.Runtime.CompilerServices;
using ChatShared;
using EFT.UI.Chat;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002E82 RID: 11906
public class GClass3173
{
	// Token: 0x0600EB07 RID: 60167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Comparer(GClass3173 data1, GClass3173 data2)
	{
		throw null;
	}

	// Token: 0x0400EFF3 RID: 61427
	public DateTime LocalDateTime;

	// Token: 0x0400EFF4 RID: 61428
	public ChatMessageClass Message;

	// Token: 0x0400EFF5 RID: 61429
	public GClass1839 SocialNetwork;

	// Token: 0x0400EFF6 RID: 61430
	public EMessageType DialogueType;

	// Token: 0x0400EFF7 RID: 61431
	public EMessageViewType MessageType;

	// Token: 0x0400EFF8 RID: 61432
	public UpdatableChatMember Member;

	// Token: 0x0400EFF9 RID: 61433
	[CanBeNull]
	public GClass939 Quote;

	// Token: 0x0400EFFA RID: 61434
	public Action<ChatMessageClass> ItemsTransfer;

	// Token: 0x0400EFFB RID: 61435
	public Action<ChatMessageClass, Vector2> ContextMenuClicked;

	// Token: 0x0400EFFC RID: 61436
	public Action<ChatMessageClass> MessageDoubleClicked;

	// Token: 0x0400EFFD RID: 61437
	public Action<string> OfferSelected;
}
