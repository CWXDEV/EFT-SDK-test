using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using JetBrains.Annotations;

// Token: 0x020030C4 RID: 12484
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct412 : GInterface383
{
	// Token: 0x17002A18 RID: 10776
	// (get) Token: 0x0600F4D5 RID: 62677 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17002A19 RID: 10777
	// (get) Token: 0x0600F4D6 RID: 62678 RVA: 0x00002050 File Offset: 0x00000250
	public bool Succeeded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A1A RID: 10778
	// (get) Token: 0x0600F4D7 RID: 62679 RVA: 0x00002050 File Offset: 0x00000250
	public bool Failed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400FAE0 RID: 64224
	public readonly GInterface321 Value;

	// Token: 0x0400FAE1 RID: 64225
	[CompilerGenerated]
	private readonly Error error_0;
}
