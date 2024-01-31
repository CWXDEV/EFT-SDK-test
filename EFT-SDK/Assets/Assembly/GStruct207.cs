using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001625 RID: 5669
[StructLayout(LayoutKind.Auto)]
public struct GStruct207 : GInterface140<GStruct207>, GInterface141<GStruct207>
{
	// Token: 0x1700136C RID: 4972
	// (get) Token: 0x06007B5F RID: 31583 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B60 RID: 31584 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct207> Nested
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04008055 RID: 32853
	public byte SkillId;

	// Token: 0x04008056 RID: 32854
	public float Value;

	// Token: 0x04008057 RID: 32855
	public float Effectiveness;

	// Token: 0x04008058 RID: 32856
	[CompilerGenerated]
	private GInterface141<GStruct207> ginterface141_0;

	public bool TryUpdate(GStruct207 source)
	{
		throw new NotImplementedException();
	}
}
