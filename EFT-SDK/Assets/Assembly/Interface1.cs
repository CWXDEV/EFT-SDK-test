using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x02000579 RID: 1401
internal interface Interface1
{
	// Token: 0x06002185 RID: 8581
	Task<GClass556> WaitResponse(string url, byte[] data, Dictionary<string, string> headers, int timeoutSeconds);
}
