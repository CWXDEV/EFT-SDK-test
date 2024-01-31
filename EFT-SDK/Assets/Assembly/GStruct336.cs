using System;
using System.Runtime.InteropServices;
using EFT.NetworkPackets;
using UnityEngine;

// Token: 0x020020C0 RID: 8384
[StructLayout(LayoutKind.Auto)]
public struct GStruct336
{
	// Token: 0x0400B3C7 RID: 46023
	public byte Iteration;

	// Token: 0x0400B3C8 RID: 46024
	public Vector3 Position;

	// Token: 0x0400B3C9 RID: 46025
	public SyncPositionReason Reason;
}
