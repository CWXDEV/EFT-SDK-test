using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F80 RID: 8064
public abstract class GClass2297<T> : SortedList<byte, T>, GInterface219 where T : GInterface219
{
	// Token: 0x0600A6EB RID: 42731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A6EC RID: 42732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A6ED RID: 42733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WriteFields(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A6EE RID: 42734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteCount(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A6EF RID: 42735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteCount(GClass1078 writer, int value)
	{
		throw null;
	}

	// Token: 0x0600A6F0 RID: 42736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriterIndex(GClass1078 writer, byte value)
	{
		throw null;
	}

	// Token: 0x0600A6F1 RID: 42737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WriterValue(GClass1078 writer, T value)
	{
		throw null;
	}

	// Token: 0x0600A6F2 RID: 42738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReadFields(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A6F3 RID: 42739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ReadCount(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A6F4 RID: 42740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte ReadIndex(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A6F5 RID: 42741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T ReadValue(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A6F6 RID: 42742
	public abstract T CreateInstanceValue();
}
