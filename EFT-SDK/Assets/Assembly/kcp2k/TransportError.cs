using System;

namespace kcp2k
{
	// Token: 0x02000F1A RID: 3866
	public enum TransportError
	{
		// Token: 0x04005D42 RID: 23874
		DnsResolve,
		// Token: 0x04005D43 RID: 23875
		Timeout,
		// Token: 0x04005D44 RID: 23876
		Congestion,
		// Token: 0x04005D45 RID: 23877
		InvalidReceive,
		// Token: 0x04005D46 RID: 23878
		InvalidSend,
		// Token: 0x04005D47 RID: 23879
		ConnectionClosed,
		// Token: 0x04005D48 RID: 23880
		Unexpected
	}
}
