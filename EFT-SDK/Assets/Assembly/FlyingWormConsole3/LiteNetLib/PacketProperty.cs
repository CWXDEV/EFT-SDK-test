using System;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02001139 RID: 4409
	internal enum PacketProperty : byte
	{
		// Token: 0x0400682D RID: 26669
		Unreliable,
		// Token: 0x0400682E RID: 26670
		Channeled,
		// Token: 0x0400682F RID: 26671
		Ack,
		// Token: 0x04006830 RID: 26672
		Ping,
		// Token: 0x04006831 RID: 26673
		Pong,
		// Token: 0x04006832 RID: 26674
		ConnectRequest,
		// Token: 0x04006833 RID: 26675
		ConnectAccept,
		// Token: 0x04006834 RID: 26676
		Disconnect,
		// Token: 0x04006835 RID: 26677
		UnconnectedMessage,
		// Token: 0x04006836 RID: 26678
		MtuCheck,
		// Token: 0x04006837 RID: 26679
		MtuOk,
		// Token: 0x04006838 RID: 26680
		Broadcast,
		// Token: 0x04006839 RID: 26681
		Merged,
		// Token: 0x0400683A RID: 26682
		ShutdownOk,
		// Token: 0x0400683B RID: 26683
		PeerNotFound,
		// Token: 0x0400683C RID: 26684
		InvalidProtocol,
		// Token: 0x0400683D RID: 26685
		NatMessage,
		// Token: 0x0400683E RID: 26686
		Empty
	}
}
