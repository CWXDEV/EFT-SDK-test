using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;

// Token: 0x020015F3 RID: 5619
public sealed class ProfileStatusClass
{
	// Token: 0x06007A70 RID: 31344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAppropriateStatusChange(EProfileStatus newValue)
	{
		throw null;
	}

	// Token: 0x06007A71 RID: 31345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04007F5B RID: 32603
	private static readonly Dictionary<EProfileStatus, HashSet<EProfileStatus>> dictionary_0;

	// Token: 0x04007F5C RID: 32604
	public string profileid;

	// Token: 0x04007F5D RID: 32605
	public string profileToken;

	// Token: 0x04007F5E RID: 32606
	public EProfileStatus status;

	// Token: 0x04007F5F RID: 32607
	public ERaidMode raidMode;

	// Token: 0x04007F60 RID: 32608
	public string ip;

	// Token: 0x04007F61 RID: 32609
	public int port;

	// Token: 0x04007F62 RID: 32610
	public string location;

	// Token: 0x04007F63 RID: 32611
	public string sid;

	// Token: 0x04007F64 RID: 32612
	[JsonProperty("mode")]
	public string gameMode;

	// Token: 0x04007F65 RID: 32613
	public string shortId;
}
