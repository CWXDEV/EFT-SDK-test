using System;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02000CD6 RID: 3286
public class GClass930
{
	// Token: 0x04005123 RID: 20771
	[JsonProperty("_id")]
	public string Id;

	// Token: 0x04005124 RID: 20772
	public float deleteTime;

	// Token: 0x04005125 RID: 20773
	public int type;

	// Token: 0x04005126 RID: 20774
	public ChatMessageClass message;

	// Token: 0x04005127 RID: 20775
	public int @new;

	// Token: 0x04005128 RID: 20776
	public int attachmentsNew;

	// Token: 0x04005129 RID: 20777
	public bool pinned;

	// Token: 0x0400512A RID: 20778
	public string Owner;

	// Token: 0x0400512B RID: 20779
	public string Name;

	// Token: 0x0400512C RID: 20780
	public UpdatableChatMember[] Users;
}
