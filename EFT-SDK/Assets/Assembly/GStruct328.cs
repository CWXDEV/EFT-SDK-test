using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020020B4 RID: 8372
[StructLayout(LayoutKind.Auto)]
public struct GStruct328
{
	// Token: 0x17001C93 RID: 7315
	// (get) Token: 0x0600AD3B RID: 44347 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasCommandsForHands
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400B392 RID: 45970
	public bool ExamineWeapon;

	// Token: 0x0400B393 RID: 45971
	public bool BrakeCombo;

	// Token: 0x0400B394 RID: 45972
	public bool MakeKnifeKick;

	// Token: 0x0400B395 RID: 45973
	public bool AlternativeKick;

	// Token: 0x0400B396 RID: 45974
	public EGesture Gesture;

	// Token: 0x0400B397 RID: 45975
	public GStruct318 EnableInventoryPacket;

	// Token: 0x0400B398 RID: 45976
	public GStruct330<GStruct327> HitsForApproval;

	// Token: 0x0400B399 RID: 45977
	public GStruct313 CompassPacket;
}
