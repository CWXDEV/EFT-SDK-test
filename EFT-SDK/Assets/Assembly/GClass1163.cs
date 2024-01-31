using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F96 RID: 3990
public static class GClass1163
{
	// Token: 0x06005469 RID: 21609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BitRequired(long min, long max)
	{
		throw null;
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Log2(uint value)
	{
		throw null;
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateDataForQuantizing(float min, float max, float res, out float delta, out int maxIntegerValue, out int bits)
	{
		throw null;
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float DequantizeUIntToFloat(uint integerValue, float min, int maxIntegerValue, float delta)
	{
		throw null;
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint QuantizeFloatValue(float value, float min, float delta, int maxIntegerValue)
	{
		throw null;
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint smethod_0(uint x)
	{
		throw null;
	}

	// Token: 0x02000F97 RID: 3991
	public static class GClass1164<[Attribute1] T> where T : struct
	{
		// Token: 0x0600546F RID: 21615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T ToEnum(long i)
		{
			throw null;
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long ToInt(T e)
		{
			throw null;
		}

		// Token: 0x04006022 RID: 24610
		public static readonly long Min;

		// Token: 0x04006023 RID: 24611
		public static readonly long Max;

		// Token: 0x04006024 RID: 24612
		private static readonly Func<T, long> func_0;

		// Token: 0x04006025 RID: 24613
		private static readonly Dictionary<long, T> dictionary_0;
	}

	// Token: 0x02000F99 RID: 3993
	private static class Class777<[Attribute1] T> where T : struct
	{
		// Token: 0x0600547A RID: 21626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long ToIntCaster(T arg)
		{
			throw null;
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x00002050 File Offset: 0x00000250
		public static int Min
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600547C RID: 21628 RVA: 0x00002050 File Offset: 0x00000250
		public static int Max
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x00002050 File Offset: 0x00000250
		public static Dictionary<int, T> IntToEnumTable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02000F9B RID: 3995
	private static class Class779<[Attribute1] T> where T : struct
	{
		// Token: 0x06005480 RID: 21632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long ToIntCaster(T arg)
		{
			throw null;
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06005481 RID: 21633 RVA: 0x00002050 File Offset: 0x00000250
		public static long Min
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x00002050 File Offset: 0x00000250
		public static long Max
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06005483 RID: 21635 RVA: 0x00002050 File Offset: 0x00000250
		public static Dictionary<long, T> IntToEnumTable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02000F9D RID: 3997
	private static class Class781<[Attribute1] T> where T : struct
	{
		// Token: 0x06005486 RID: 21638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long ToIntCaster(T arg)
		{
			throw null;
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x00002050 File Offset: 0x00000250
		public static short Min
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x00002050 File Offset: 0x00000250
		public static short Max
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x00002050 File Offset: 0x00000250
		public static Dictionary<short, T> IntToEnumTable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}

	// Token: 0x02000F9F RID: 3999
	private static class Class783<[Attribute1] T> where T : struct
	{
		// Token: 0x0600548C RID: 21644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long ToIntCaster(T arg)
		{
			throw null;
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x00002050 File Offset: 0x00000250
		public static byte Min
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x00002050 File Offset: 0x00000250
		public static byte Max
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x00002050 File Offset: 0x00000250
		public static Dictionary<byte, T> IntToEnumTable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}
	}
}
