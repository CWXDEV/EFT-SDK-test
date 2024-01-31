using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200025C RID: 604
public class GClass355<T>
{
	// Token: 0x17000306 RID: 774
	// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enqueue(float priority, T item)
	{
		throw null;
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Dequeue()
	{
		throw null;
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Log()
	{
		throw null;
	}

	// Token: 0x04000C33 RID: 3123
	private readonly List<GClass355<T>.Struct7<T>> list_0;

	// Token: 0x0200025D RID: 605
	[StructLayout(LayoutKind.Auto)]
	public struct Struct7<U>
	{
		// Token: 0x04000C34 RID: 3124
		public readonly U data;

		// Token: 0x04000C35 RID: 3125
		public readonly float priority;
	}
}
