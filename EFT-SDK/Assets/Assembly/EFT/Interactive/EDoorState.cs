using System;

namespace EFT.Interactive
{
	// Token: 0x020027B1 RID: 10161
	[Flags]
	public enum EDoorState : byte
	{
		// Token: 0x0400CBD1 RID: 52177
		None = 0,
		// Token: 0x0400CBD2 RID: 52178
		Locked = 1,
		// Token: 0x0400CBD3 RID: 52179
		Shut = 2,
		// Token: 0x0400CBD4 RID: 52180
		Open = 4,
		// Token: 0x0400CBD5 RID: 52181
		Interacting = 8,
		// Token: 0x0400CBD6 RID: 52182
		Breaching = 16
	}
}
