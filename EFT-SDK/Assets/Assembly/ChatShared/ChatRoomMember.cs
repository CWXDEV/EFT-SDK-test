using System;
using EFT;
using Newtonsoft.Json;

namespace ChatShared
{
	// Token: 0x02000CD4 RID: 3284
	public class ChatRoomMember
	{
		// Token: 0x0400511B RID: 20763
		[JsonProperty("_id")]
		public string Id;

		// Token: 0x0400511C RID: 20764
		[JsonProperty("aid")]
		public string Aid;

		// Token: 0x0400511D RID: 20765
		public ChatRoomMember.MemberInfo Info;

		// Token: 0x02000CD5 RID: 3285
		public class MemberInfo
		{
			// Token: 0x0400511E RID: 20766
			public string Nickname;

			// Token: 0x0400511F RID: 20767
			public EChatMemberSide Side;

			// Token: 0x04005120 RID: 20768
			public int Level;

			// Token: 0x04005121 RID: 20769
			public EMemberCategory MemberCategory;

			// Token: 0x04005122 RID: 20770
			public DateTime GlobalMuteTime;
		}
	}
}
