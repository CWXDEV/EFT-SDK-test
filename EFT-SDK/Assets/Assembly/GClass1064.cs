using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000E95 RID: 3733
public class GClass1064<T> where T : GClass1049
{
	// Token: 0x06004DB0 RID: 19888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCell(T cell)
	{
		throw null;
	}

	// Token: 0x06004DB1 RID: 19889 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetCell(int hash, out T cell)
	{
		throw null;
	}

	// Token: 0x06004DB2 RID: 19890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T> GetCellList()
	{
		throw null;
	}

	// Token: 0x06004DB3 RID: 19891 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetCell(T cell)
	{
		throw null;
	}

	// Token: 0x06004DB4 RID: 19892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActiveCellUpdateRequired(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06004DB5 RID: 19893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CalculateActiveCells(Vector3 position)
	{
		throw null;
	}

	// Token: 0x04005A7F RID: 23167
	public int cellRowAndCollumnCountPerTerrain;

	// Token: 0x04005A80 RID: 23168
	public List<T> activeCellList;

	// Token: 0x04005A81 RID: 23169
	private Dictionary<int, T> dictionary_0;

	// Token: 0x04005A82 RID: 23170
	private List<T> list_0;
}
