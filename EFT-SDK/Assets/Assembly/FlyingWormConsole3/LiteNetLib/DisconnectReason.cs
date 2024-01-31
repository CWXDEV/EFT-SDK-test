using System;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02001111 RID: 4369
	public enum DisconnectReason
	{
		// Token: 0x04006791 RID: 26513
		ConnectionFailed,
		// Token: 0x04006792 RID: 26514
		Timeout,
		// Token: 0x04006793 RID: 26515
		HostUnreachable,
		// Token: 0x04006794 RID: 26516
		NetworkUnreachable,
		// Token: 0x04006795 RID: 26517
		RemoteConnectionClose,
		// Token: 0x04006796 RID: 26518
		DisconnectPeerCalled,
		// Token: 0x04006797 RID: 26519
		ConnectionRejected,
		// Token: 0x04006798 RID: 26520
		InvalidProtocol,
		// Token: 0x04006799 RID: 26521
		UnknownHost,
		// Token: 0x0400679A RID: 26522
		Reconnect,
		// Token: 0x0400679B RID: 26523
		PeerToPeerConnection
	}
}
