using System;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200112B RID: 4395
	public enum DeliveryMethod : byte
	{
		// Token: 0x040067C3 RID: 26563
		Unreliable = 4,
		// Token: 0x040067C4 RID: 26564
		ReliableUnordered = 0,
		// Token: 0x040067C5 RID: 26565
		Sequenced,
		// Token: 0x040067C6 RID: 26566
		ReliableOrdered,
		// Token: 0x040067C7 RID: 26567
		ReliableSequenced
	}
}
