using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000FA5 RID: 4005
[StructLayout(LayoutKind.Auto)]
public struct GStruct99
{
	// Token: 0x060054A3 RID: 21667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400603B RID: 24635
	public readonly float Min;

	// Token: 0x0400603C RID: 24636
	public readonly float Max;

	// Token: 0x0400603D RID: 24637
	public readonly float Resolution;

	// Token: 0x0400603E RID: 24638
	public readonly int BitsRequired;

	// Token: 0x0400603F RID: 24639
	public readonly float Delta;

	// Token: 0x04006040 RID: 24640
	public readonly int MaxIntegerValue;

	// Token: 0x04006041 RID: 24641
	public readonly bool CheckBounds;
}
