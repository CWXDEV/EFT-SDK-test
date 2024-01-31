using System;
using Comfort.Common;

namespace ChatShared
{
	// Token: 0x02000CC8 RID: 3272
	public interface IChatsSession
	{
		// Token: 0x0600463E RID: 17982
		void Start(IChatMember member, Callback<IChatHandle, ChatInfo> callback);

		// Token: 0x0600463F RID: 17983
		void Start(IChatMember member, string chatId, Callback<IChatHandle, ChatInfo> callback);

		// Token: 0x06004640 RID: 17984
		void Close(Action callback);

		// Token: 0x06004641 RID: 17985
		void Ban(string profileId, TimeSpan timeSpan, string description, Callback<DateTime> callback);

		// Token: 0x06004642 RID: 17986
		void Unban(string profileId, string description, Callback callback);
	}
}
