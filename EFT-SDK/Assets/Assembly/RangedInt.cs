using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B55 RID: 2901
[Serializable]
public class RangedInt
{
	// Token: 0x17000A1E RID: 2590
	// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x00002050 File Offset: 0x00000250
	public int Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A1F RID: 2591
	// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x00002050 File Offset: 0x00000250
	public int Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003ECA RID: 16074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Random()
	{
		throw null;
	}

	// Token: 0x06003ECB RID: 16075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Clamp(int input)
	{
		throw null;
	}

	// Token: 0x0400464C RID: 17996
	[SerializeField]
	private int min;

	// Token: 0x0400464D RID: 17997
	[SerializeField]
	private int max;
}
