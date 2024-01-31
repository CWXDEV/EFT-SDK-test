using System;
using System.Net;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001121 RID: 4385
public interface GInterface91
{
	// Token: 0x06005C3C RID: 23612
	void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

	// Token: 0x06005C3D RID: 23613
	void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
}
