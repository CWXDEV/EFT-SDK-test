using System;
using System.Runtime.InteropServices;

// Token: 0x02000592 RID: 1426
[StructLayout(LayoutKind.Auto)]
public struct Struct32
{
	// Token: 0x04002081 RID: 8321
	public string EndpointUrl;

	// Token: 0x04002082 RID: 8322
	public string TokenB64;

	// Token: 0x04002083 RID: 8323
	public float KeepAliveInterval;

	// Token: 0x04002084 RID: 8324
	public float[] ConfirmationTimeouts;

	// Token: 0x04002085 RID: 8325
	public Action ActionOnReconnect;
}
