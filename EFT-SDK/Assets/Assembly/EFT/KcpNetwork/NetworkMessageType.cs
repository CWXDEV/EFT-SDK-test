using System;

namespace EFT.KcpNetwork
{
	// Token: 0x0200223B RID: 8763
	public enum NetworkMessageType : byte
	{
		// Token: 0x0400B72F RID: 46895
		None,
		// Token: 0x0400B730 RID: 46896
		Connect,
		// Token: 0x0400B731 RID: 46897
		Ping,
		// Token: 0x0400B732 RID: 46898
		Pong,
		// Token: 0x0400B733 RID: 46899
		Data,
		// Token: 0x0400B734 RID: 46900
		Disconnect
	}
}
