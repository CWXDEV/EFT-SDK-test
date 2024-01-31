using System;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200113E RID: 4414
	[Flags]
	public enum ConnectionState : byte
	{
		// Token: 0x04006852 RID: 26706
		Outgoing = 2,
		// Token: 0x04006853 RID: 26707
		Connected = 4,
		// Token: 0x04006854 RID: 26708
		ShutdownRequested = 8,
		// Token: 0x04006855 RID: 26709
		Disconnected = 16,
		// Token: 0x04006856 RID: 26710
		Any = 14
	}
}
