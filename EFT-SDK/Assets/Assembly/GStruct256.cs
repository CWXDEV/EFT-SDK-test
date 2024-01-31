using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001DF4 RID: 7668
[StructLayout(LayoutKind.Auto)]
public struct GStruct256
{
	// Token: 0x170018F4 RID: 6388
	// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x00002050 File Offset: 0x00000250
	public static int Stride
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A60E RID: 42510
	public GStruct255 Global;

	// Token: 0x0400A60F RID: 42511
	public GStruct255 Branch;

	// Token: 0x0400A610 RID: 42512
	public GStruct255 Leaf1Ripple;

	// Token: 0x0400A611 RID: 42513
	public GStruct255 Leaf2Ripple;

	// Token: 0x0400A612 RID: 42514
	public GStruct255 Leaf1Tumble;

	// Token: 0x0400A613 RID: 42515
	public GStruct255 Leaf2Tumble;

	// Token: 0x0400A614 RID: 42516
	public GStruct255 Leaf1Twitch;

	// Token: 0x0400A615 RID: 42517
	public GStruct255 Leaf2Twitch;

	// Token: 0x0400A616 RID: 42518
	public GStruct255 FrondRipple;
}
