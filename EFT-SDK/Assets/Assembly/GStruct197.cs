using System;
using System.Runtime.InteropServices;
using EFT.Interactive;

// Token: 0x020015A9 RID: 5545
[StructLayout(LayoutKind.Auto)]
public struct GStruct197
{
	// Token: 0x04007D0C RID: 32012
	public int PlayerId;

	// Token: 0x04007D0D RID: 32013
	public WorldInteractiveObject WorldInteractiveObject;

	// Token: 0x04007D0E RID: 32014
	public InteractionResult Result;

	// Token: 0x04007D0F RID: 32015
	public Action Callback;
}
