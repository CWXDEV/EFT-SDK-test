using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020012C0 RID: 4800
public sealed class GClass1450<T> : List<string>, ISerializer<T>
{
	// Token: 0x06006399 RID: 25497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Deserialize()
	{
		throw null;
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(T t)
	{
		throw null;
	}

	// Token: 0x020012C1 RID: 4801
	[CompilerGenerated]
	[Serializable]
	private sealed class Class918
	{
		// Token: 0x0600639B RID: 25499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(int acc, string side)
		{
			throw null;
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal T method_1(int acc)
		{
			throw null;
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(T x)
		{
			throw null;
		}

		// Token: 0x04007025 RID: 28709
		public static readonly GClass1450<T>.Class918 class918_0;

		// Token: 0x04007026 RID: 28710
		public static Func<int, string, int> func_0;

		// Token: 0x04007027 RID: 28711
		public static Func<int, T> func_1;

		// Token: 0x04007028 RID: 28712
		public static Func<T, string> func_2;
	}

	// Token: 0x020012C2 RID: 4802
	[CompilerGenerated]
	private sealed class Class919
	{
		// Token: 0x0600639E RID: 25502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T x)
		{
			throw null;
		}

		// Token: 0x04007029 RID: 28713
		public int intValue;
	}
}
