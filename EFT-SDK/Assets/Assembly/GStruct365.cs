using System;
using System.Runtime.InteropServices;

// Token: 0x0200223D RID: 8765
[StructLayout(LayoutKind.Auto)]
public struct GStruct365
{
	// Token: 0x0400B743 RID: 46915
	public float Rtt;

	// Token: 0x0400B744 RID: 46916
	public float Lose;

	// Token: 0x0400B745 RID: 46917
	public int Disordered;

	// Token: 0x0400B746 RID: 46918
	public int Duplicated;

	// Token: 0x0400B747 RID: 46919
	public float ReliableReceivedAverage;

	// Token: 0x0400B748 RID: 46920
	public float ReliableSentAverage;

	// Token: 0x0400B749 RID: 46921
	public float UnreliableReceivedAverage;

	// Token: 0x0400B74A RID: 46922
	public float UnreliableSentAverage;

	// Token: 0x0400B74B RID: 46923
	public float ReceivedAverage;

	// Token: 0x0400B74C RID: 46924
	public float SentAverage;

	// Token: 0x0400B74D RID: 46925
	public int ReceivedTotal;

	// Token: 0x0400B74E RID: 46926
	public int SentTotal;
}
