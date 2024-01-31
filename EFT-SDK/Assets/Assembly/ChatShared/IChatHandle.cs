using System;

namespace ChatShared
{
	// Token: 0x02000CCB RID: 3275
	public interface IChatHandle
	{
		// Token: 0x0600464A RID: 17994
		void Send(string text);

		// Token: 0x0600464B RID: 17995
		void Replay(string text, string replayMessageId);

		// Token: 0x0600464C RID: 17996
		void Close(Action callback);
	}
}
