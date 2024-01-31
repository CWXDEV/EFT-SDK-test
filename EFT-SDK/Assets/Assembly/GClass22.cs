using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using JetBrains.Annotations;

// Token: 0x02000102 RID: 258
public sealed class GClass22
{
	// Token: 0x0600057B RID: 1403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double smethod_0(double ticks)
	{
		throw null;
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private double method_0()
	{
		throw null;
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass18.GClass19 method_1(string name)
	{
		throw null;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass18.GClass19 counter)
	{
		throw null;
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeginSample(string name)
	{
		throw null;
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass22.GStruct4 BeginSampleWithToken(string name)
	{
		throw null;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndSample(string name)
	{
		throw null;
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndSample()
	{
		throw null;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetStringReport()
	{
		throw null;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintReport()
	{
		throw null;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GClass22.GStruct5> GetSamples(bool fullSampleName)
	{
		throw null;
	}

	// Token: 0x04000694 RID: 1684
	private readonly Stopwatch stopwatch_0;

	// Token: 0x04000695 RID: 1685
	private readonly StringBuilder stringBuilder_0;

	// Token: 0x04000696 RID: 1686
	private readonly GClass18 gclass18_0;

	// Token: 0x04000697 RID: 1687
	private GClass18.GClass19 gclass19_0;

	// Token: 0x04000698 RID: 1688
	private bool bool_0;

	// Token: 0x02000103 RID: 259
	[StructLayout(LayoutKind.Auto)]
	public readonly struct GStruct4 : IDisposable
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04000699 RID: 1689
		private readonly GClass22 gclass22_0;

		// Token: 0x0400069A RID: 1690
		private readonly GClass18.GClass19 gclass19_0;
	}

	// Token: 0x02000104 RID: 260
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct5
	{
		// Token: 0x0400069B RID: 1691
		public string name;

		// Token: 0x0400069C RID: 1692
		public double value;
	}
}
