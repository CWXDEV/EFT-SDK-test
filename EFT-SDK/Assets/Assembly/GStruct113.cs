using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001112 RID: 4370
[StructLayout(LayoutKind.Auto)]
public struct GStruct113
{
	// Token: 0x0400679C RID: 26524
	public DisconnectReason Reason;

	// Token: 0x0400679D RID: 26525
	public SocketError SocketErrorCode;

	// Token: 0x0400679E RID: 26526
	public GClass1285 AdditionalData;
}
