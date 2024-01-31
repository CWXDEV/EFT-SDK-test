using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001626 RID: 5670
[StructLayout(LayoutKind.Auto)]
public struct GStruct208 : GInterface140<GStruct208>, GInterface141<GStruct208>
{
	// Token: 0x1700136D RID: 4973
	// (get) Token: 0x06007B61 RID: 31585 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B62 RID: 31586 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct208> Nested
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

	// Token: 0x04008059 RID: 32857
	public string GroupName;

	// Token: 0x0400805A RID: 32858
	public float Value;

	// Token: 0x0400805B RID: 32859
	[CompilerGenerated]
	private GInterface141<GStruct208> ginterface141_0;

	public bool TryUpdate(GStruct208 source)
	{
		throw new NotImplementedException();
	}
}
