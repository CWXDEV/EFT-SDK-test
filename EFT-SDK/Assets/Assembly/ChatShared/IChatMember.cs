using System;

namespace ChatShared
{
	// Token: 0x02000CCA RID: 3274
	public interface IChatMember
	{
		// Token: 0x06004643 RID: 17987
		void Receive(Message message);

		// Token: 0x06004644 RID: 17988
		void ReceiveReplay(Message message, Message replayMessage);

		// Token: 0x06004645 RID: 17989
		void Add(ChatRoomMember[] members);

		// Token: 0x06004646 RID: 17990
		void Remove(string[] members);

		// Token: 0x06004647 RID: 17991
		void SetBanned(string memberId, DateTime toDateTime);

		// Token: 0x06004648 RID: 17992
		void SetUnbanned(string memberId);

		// Token: 0x06004649 RID: 17993
		void Drop();
	}
}
