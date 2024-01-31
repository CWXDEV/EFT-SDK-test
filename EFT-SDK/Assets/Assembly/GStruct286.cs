using System;
using System.Runtime.InteropServices;

// Token: 0x0200203F RID: 8255
[StructLayout(LayoutKind.Auto)]
public struct GStruct286
{
	// Token: 0x0400B1D1 RID: 45521
	public double RemoteTime;

	// Token: 0x0400B1D2 RID: 45522
	public bool IsNeedProcessMovement;

	// Token: 0x0400B1D3 RID: 45523
	public GStruct287 Movement;

	// Token: 0x0400B1D4 RID: 45524
	public GStruct276 PlayerAnimatorModel;

	// Token: 0x0400B1D5 RID: 45525
	public int CommandsCount;

	// Token: 0x0400B1D6 RID: 45526
	public GInterface218[] Commands;
}
