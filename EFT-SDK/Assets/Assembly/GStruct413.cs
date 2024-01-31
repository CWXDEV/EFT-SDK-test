using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using JetBrains.Annotations;

// Token: 0x020030C5 RID: 12485
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct413<T> : GInterface383 where T : GInterface321
{
	// Token: 0x17002A1B RID: 10779
	// (get) Token: 0x0600F4D8 RID: 62680 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17002A1C RID: 10780
	// (get) Token: 0x0600F4D9 RID: 62681 RVA: 0x00002050 File Offset: 0x00000250
	public bool Succeeded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A1D RID: 10781
	// (get) Token: 0x0600F4DA RID: 62682 RVA: 0x00002050 File Offset: 0x00000250
	public bool Failed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400FAE2 RID: 64226
	public readonly T Value;

	// Token: 0x0400FAE3 RID: 64227
	[CompilerGenerated]
	private readonly Error error_0;
}
