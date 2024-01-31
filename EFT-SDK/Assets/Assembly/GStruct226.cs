using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001639 RID: 5689
[StructLayout(LayoutKind.Auto)]
public struct GStruct226 : GInterface141<GStruct226>
{
	// Token: 0x17001377 RID: 4983
	// (get) Token: 0x06007B89 RID: 31625 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B8A RID: 31626 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct226> Nested
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

	// Token: 0x04008095 RID: 32917
	public string WeaponId;

	// Token: 0x04008096 RID: 32918
	public float LastShotTime;

	// Token: 0x04008097 RID: 32919
	public float LastOverheat;

	// Token: 0x04008098 RID: 32920
	public bool SlideOnOverheatReached;

	// Token: 0x04008099 RID: 32921
	[CompilerGenerated]
	private GInterface141<GStruct226> ginterface141_0;
}
