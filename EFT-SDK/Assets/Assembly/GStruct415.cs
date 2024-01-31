using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using JetBrains.Annotations;

// Token: 0x020030C7 RID: 12487
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct415<T> : GInterface383
{
	// Token: 0x17002A21 RID: 10785
	// (get) Token: 0x0600F4DE RID: 62686 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17002A22 RID: 10786
	// (get) Token: 0x0600F4DF RID: 62687 RVA: 0x00002050 File Offset: 0x00000250
	public bool Succeeded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A23 RID: 10787
	// (get) Token: 0x0600F4E0 RID: 62688 RVA: 0x00002050 File Offset: 0x00000250
	public bool Failed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F4E1 RID: 62689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T OrElse(T elseValue)
	{
		throw null;
	}

	// Token: 0x0600F4E2 RID: 62690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct415<TOut> Select<TOut>(Func<T, TOut> selector)
	{
		throw null;
	}

	// Token: 0x0400FAE5 RID: 64229
	public readonly T Value;

	// Token: 0x0400FAE6 RID: 64230
	[CompilerGenerated]
	private readonly Error error_0;
}
