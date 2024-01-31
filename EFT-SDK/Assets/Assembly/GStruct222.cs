using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Quests;

// Token: 0x02001635 RID: 5685
[StructLayout(LayoutKind.Auto)]
public struct GStruct222
{
	// Token: 0x06007B84 RID: 31620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04008082 RID: 32898
	public int ConditionId;

	// Token: 0x04008083 RID: 32899
	public EQuestStatus Status;

	// Token: 0x04008084 RID: 32900
	public float Value;

	// Token: 0x04008085 RID: 32901
	public bool Notify;
}
