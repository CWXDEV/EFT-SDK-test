using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;

// Token: 0x02002247 RID: 8775
public sealed class GClass2490 : IParametersCache
{
	// Token: 0x17001DFD RID: 7677
	// (get) Token: 0x0600B2EB RID: 45803 RVA: 0x00002050 File Offset: 0x00000250
	public IBindable<bool> TransactionInProcess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001DFE RID: 7678
	// (get) Token: 0x0600B2EC RID: 45804 RVA: 0x00002050 File Offset: 0x00000250
	BindableState<bool> IParametersCache.Locked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B2ED RID: 45805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct413<GStruct375> AddNote(GClass2489 note, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B2EE RID: 45806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertNote(int index, GClass2489 note)
	{
		throw null;
	}

	// Token: 0x0600B2EF RID: 45807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct413<GStruct376> EditNote(int index, GClass2489 note, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B2F0 RID: 45808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct413<GClass2800> DeleteNote(int index, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B2F1 RID: 45809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveNote(GClass2489 note)
	{
		throw null;
	}

	// Token: 0x0400B76B RID: 46955
	public readonly List<GClass2489> Notes;

	// Token: 0x0400B76C RID: 46956
	private readonly BindableState<bool> gclass3370_0;
}
