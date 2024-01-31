using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using JetBrains.Annotations;

// Token: 0x020030C2 RID: 12482
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct410 : GInterface383
{
	// Token: 0x17002A12 RID: 10770
	// (get) Token: 0x0600F4CF RID: 62671 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	public Error Error
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A13 RID: 10771
	// (get) Token: 0x0600F4D0 RID: 62672 RVA: 0x00002050 File Offset: 0x00000250
	public bool Succeeded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A14 RID: 10772
	// (get) Token: 0x0600F4D1 RID: 62673 RVA: 0x00002050 File Offset: 0x00000250
	public bool Failed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400FADC RID: 64220
	public readonly GClass2833 Value;

	// Token: 0x0400FADD RID: 64221
	[CompilerGenerated]
	private readonly Error error_0;
}
