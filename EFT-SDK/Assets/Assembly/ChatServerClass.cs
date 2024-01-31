using System;
using Newtonsoft.Json;

// Token: 0x02000CC6 RID: 3270
public sealed class ChatServerClass
{
	// Token: 0x040050FB RID: 20731
	[JsonProperty("_id")]
	public string ServerId;

	// Token: 0x040050FC RID: 20732
	public int RegistrationId;

	// Token: 0x040050FD RID: 20733
	public string VersionId;

	// Token: 0x040050FE RID: 20734
	public string Ip;

	// Token: 0x040050FF RID: 20735
	public int Port;

	// Token: 0x04005100 RID: 20736
	public DateTime DateTime;

	// Token: 0x04005101 RID: 20737
	public GClass922[] Chats;

	// Token: 0x04005102 RID: 20738
	public string[] Regions;
}
