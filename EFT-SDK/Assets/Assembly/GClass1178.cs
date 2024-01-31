using System;
using EFT;
using Newtonsoft.Json;

// Token: 0x02000FBB RID: 4027
public sealed class GClass1178
{
	// Token: 0x04006061 RID: 24673
	[JsonProperty("profile")]
	public Profile Profile;

	// Token: 0x04006062 RID: 24674
	[JsonProperty("profileToken")]
	public string ProfileToken;

	// Token: 0x04006063 RID: 24675
	[JsonProperty("group")]
	public string GroupId;

	// Token: 0x04006064 RID: 24676
	[JsonProperty("team")]
	public string TeamId;

	// Token: 0x04006065 RID: 24677
	[JsonProperty("entryPoint")]
	public string EntryPoint;

	// Token: 0x04006066 RID: 24678
	[JsonProperty("keyId")]
	public string KeyId;

	// Token: 0x04006067 RID: 24679
	[JsonProperty("repeatableQuests")]
	public RawQuestClass[] RepeatableQuests;
}
