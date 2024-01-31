using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005D8 RID: 1496
public class GClass570<T>
{
	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x0600228E RID: 8846 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<Type, T>.ValueCollection Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsType(Type type)
	{
		throw null;
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add<GT>(Type type, GT t) where GT : T
	{
		throw null;
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add<GT>(GT t) where GT : T
	{
		throw null;
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GT Get<GT>() where GT : T
	{
		throw null;
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GT Get<GT>(Type type) where GT : T
	{
		throw null;
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(Type t)
	{
		throw null;
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(T element)
	{
		throw null;
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x040021FD RID: 8701
	private readonly Dictionary<Type, T> dictionary_0;
}
