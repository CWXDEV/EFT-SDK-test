using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using JetBrains.Annotations;

// Token: 0x020030C3 RID: 12483
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct411<T> : GInterface383 where T : GClass2833
{
	// Token: 0x17002A15 RID: 10773
	// (get) Token: 0x0600F4D2 RID: 62674 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17002A16 RID: 10774
	// (get) Token: 0x0600F4D3 RID: 62675 RVA: 0x00002050 File Offset: 0x00000250
	public bool Succeeded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A17 RID: 10775
	// (get) Token: 0x0600F4D4 RID: 62676 RVA: 0x00002050 File Offset: 0x00000250
	public bool Failed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400FADE RID: 64222
	public readonly GClass2833 Value;

	// Token: 0x0400FADF RID: 64223
	[CompilerGenerated]
	private readonly Error error_0;
}
