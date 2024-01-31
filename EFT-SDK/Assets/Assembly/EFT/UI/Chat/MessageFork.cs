using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI.Chat
{
	// Token: 0x02002E80 RID: 11904
	public class MessageFork : UIElement
	{
		// Token: 0x0600EAFE RID: 60158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3173 data)
		{
			throw null;
		}

		// Token: 0x0600EAFF RID: 60159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400EFDF RID: 61407
		[SerializeField]
		private MessageView _yourChatMessage;

		// Token: 0x0400EFE0 RID: 61408
		[SerializeField]
		private MessageView _opponentChatMessage;

		// Token: 0x0400EFE1 RID: 61409
		[SerializeField]
		private MessageView _systemMessage;

		// Token: 0x0400EFE2 RID: 61410
		[SerializeField]
		private AttachmentMessageView _attachmentMessage;
	}
}
