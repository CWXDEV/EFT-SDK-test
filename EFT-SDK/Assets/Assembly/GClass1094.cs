using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F1D RID: 3869
public abstract class GClass1094<T, U, V> : IDisposable where U : GClass1094<T, U, V>
{
	// Token: 0x0600512F RID: 20783
	public abstract void Clear();

	// Token: 0x06005130 RID: 20784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(float time, T value)
	{
		throw null;
	}

	// Token: 0x06005131 RID: 20785
	protected abstract void InternalAdd(float time, in T value1);

	// Token: 0x06005132 RID: 20786
	public abstract GStruct96<T> GetTimeStampedValue(int index);

	// Token: 0x06005133 RID: 20787
	public abstract float GetTimeStamp(int index);

	// Token: 0x06005134 RID: 20788
	public abstract int Interpolate(GStruct95 start, GStruct95 end, GClass1097<GStruct92<T>> result);

	// Token: 0x06005135 RID: 20789
	public abstract T InterpolateThroughRange(in GStruct95 start, in GStruct95 end);

	// Token: 0x06005136 RID: 20790
	public abstract int GetValuesCount();

	// Token: 0x06005137 RID: 20791
	public abstract float GetLeftTime(float currentTime);

	// Token: 0x06005138 RID: 20792
	public abstract V GetValueShortData(int index);

	// Token: 0x06005139 RID: 20793
	public abstract void RemoveValues(int count);

	// Token: 0x0600513A RID: 20794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDataUntil(in GStruct94 startRangeTime)
	{
		throw null;
	}

	// Token: 0x0600513B RID: 20795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetInterpolatorSpan(in GStruct94 start, in GStruct94 end, out GStruct93<T, U, V> interpolatorSpan)
	{
		throw null;
	}

	// Token: 0x0600513C RID: 20796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(in GStruct94 start, in GStruct94 end, out GStruct95 resultStartBound, out GStruct95 resultEndBound)
	{
		throw null;
	}

	// Token: 0x0600513D RID: 20797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int index, int increment, GStruct94 rightSideValue, GStruct94 leftSideValue, ref GStruct95 resultStartIndex, ref GStruct95 resultEndIndex, bool incrementIndexInCaseOfLess)
	{
		throw null;
	}

	// Token: 0x0600513E RID: 20798
	public abstract void Dispose();

	// Token: 0x17000CA5 RID: 3237
	// (get) Token: 0x0600513F RID: 20799 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}
}
