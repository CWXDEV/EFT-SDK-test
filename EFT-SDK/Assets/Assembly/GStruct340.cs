using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020020C4 RID: 8388
[StructLayout(LayoutKind.Auto)]
public struct GStruct340
{
	// Token: 0x17001C97 RID: 7319
	// (get) Token: 0x0600AD4C RID: 44364 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasCommandsForHands
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400B3DA RID: 46042
	public bool ExamineWeapon;

	// Token: 0x0400B3DB RID: 46043
	public EGesture Gesture;

	// Token: 0x0400B3DC RID: 46044
	public bool ToggleAim;

	// Token: 0x0400B3DD RID: 46045
	public bool IsAiming;

	// Token: 0x0400B3DE RID: 46046
	public bool HideItem;

	// Token: 0x0400B3DF RID: 46047
	public GStruct318 EnableInventoryPacket;

	// Token: 0x0400B3E0 RID: 46048
	public GStruct313 CompassPacket;
}
