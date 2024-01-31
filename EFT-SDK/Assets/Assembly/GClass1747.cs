using System;
using EFT;
using Newtonsoft.Json;

// Token: 0x020015F6 RID: 5622
public class GClass1747
{
	// Token: 0x04007F6B RID: 32619
	public GClass748 profile;

	// Token: 0x04007F6C RID: 32620
	public ExitStatus result;

	// Token: 0x04007F6D RID: 32621
	public string killerId;

	// Token: 0x04007F6E RID: 32622
	public string killerAid;

	// Token: 0x04007F6F RID: 32623
	public string exitName;

	// Token: 0x04007F70 RID: 32624
	public bool inSession;

	// Token: 0x04007F71 RID: 32625
	public bool favorite;

	// Token: 0x04007F72 RID: 32626
	public int playTime;

	// Token: 0x04007F73 RID: 32627
	[JsonIgnore]
	public InsuredItemClass[] InsuredItems;

	// Token: 0x04007F74 RID: 32628
	[JsonIgnore]
	public string ProfileId;
}
