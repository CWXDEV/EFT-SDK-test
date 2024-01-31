using System;
using System.Runtime.CompilerServices;
using Koenigz.PerfectCulling.EFT;
using UnityEngine;

// Token: 0x02000DA5 RID: 3493
public sealed class GClass1012
{
	// Token: 0x17000BB8 RID: 3000
	// (get) Token: 0x060049CD RID: 18893 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060049CE RID: 18894 RVA: 0x00002050 File Offset: 0x00000250
	public int[] CellIndices
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000BB9 RID: 3001
	// (get) Token: 0x060049CF RID: 18895 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060049D0 RID: 18896 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3[] SamplingPoints
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000BBA RID: 3002
	// (get) Token: 0x060049D1 RID: 18897 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060049D2 RID: 18898 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface62 OutputData
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000BBB RID: 3003
	// (get) Token: 0x060049D3 RID: 18899 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060049D4 RID: 18900 RVA: 0x00002050 File Offset: 0x00000250
	public PerfectCullingSuperSamplingVolume OptionalVolume
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemapIds()
	{
		throw null;
	}

	// Token: 0x17000BBC RID: 3004
	// (get) Token: 0x060049D6 RID: 18902 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060049D7 RID: 18903 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1012.Mode WriteMode
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400550A RID: 21770
	[CompilerGenerated]
	private int[] int_0;

	// Token: 0x0400550B RID: 21771
	[CompilerGenerated]
	private Vector3[] vector3_0;

	// Token: 0x0400550C RID: 21772
	[CompilerGenerated]
	private GInterface62 ginterface62_0;

	// Token: 0x0400550D RID: 21773
	[CompilerGenerated]
	private PerfectCullingSuperSamplingVolume perfectCullingSuperSamplingVolume_0;

	// Token: 0x0400550E RID: 21774
	[CompilerGenerated]
	private GClass1012.Mode mode_0;

	// Token: 0x02000DA6 RID: 3494
	public enum Mode
	{
		// Token: 0x04005510 RID: 21776
		Overwrite,
		// Token: 0x04005511 RID: 21777
		Append,
		// Token: 0x04005512 RID: 21778
		Union,
		// Token: 0x04005513 RID: 21779
		SuperSample
	}
}
