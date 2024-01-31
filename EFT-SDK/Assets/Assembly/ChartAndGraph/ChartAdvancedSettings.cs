using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003151 RID: 12625
	[Serializable]
	internal class ChartAdvancedSettings
	{
		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600F7C7 RID: 63431 RVA: 0x00002050 File Offset: 0x00000250
		public static ChartAdvancedSettings Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F7C8 RID: 63432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0(string format, double val)
		{
			throw null;
		}

		// Token: 0x0600F7C9 RID: 63433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_1(int value)
		{
			throw null;
		}

		// Token: 0x0600F7CA RID: 63434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string FormatFractionDigits(int digits, double val)
		{
			throw null;
		}

		// Token: 0x0400FD04 RID: 64772
		private static ChartAdvancedSettings mInstance;

		// Token: 0x0400FD05 RID: 64773
		private static string[] FractionDigits;

		// Token: 0x0400FD06 RID: 64774
		[Range(0f, 7f)]
		public int ValueFractionDigits;

		// Token: 0x0400FD07 RID: 64775
		[Range(0f, 7f)]
		public int AxisFractionDigits;
	}
}
