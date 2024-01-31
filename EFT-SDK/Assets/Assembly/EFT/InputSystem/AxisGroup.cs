using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.InputSystem
{
	// Token: 0x02001A24 RID: 6692
	[Serializable]
	public sealed class AxisGroup
	{
		// Token: 0x06008DEF RID: 36335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AxisGroup Clone()
		{
			throw null;
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AxisGroup other)
		{
			throw null;
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool EqualityCheck(AxisGroup x, AxisGroup y)
		{
			throw null;
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static AxisGroup CopyItem(AxisGroup item)
		{
			throw null;
		}

		// Token: 0x0400944D RID: 37965
		public EAxis axisName;

		// Token: 0x0400944E RID: 37966
		public List<AxisGroup.AxisPair> pairs;

		// Token: 0x0400944F RID: 37967
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool isInverted;

		// Token: 0x04009450 RID: 37968
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float gravity;

		// Token: 0x04009451 RID: 37969
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool snapToZero;

		// Token: 0x02001A25 RID: 6693
		[Serializable]
		public sealed class AxisPair
		{
			// Token: 0x06008DF5 RID: 36341 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AxisGroup.AxisPair Clone()
			{
				throw null;
			}

			// Token: 0x04009452 RID: 37970
			public InputSource positive;

			// Token: 0x04009453 RID: 37971
			public InputSource negative;
		}

		// Token: 0x02001A26 RID: 6694
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1566
		{
			// Token: 0x06008DF6 RID: 36342 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AxisGroup.AxisPair method_0(AxisGroup.AxisPair x)
			{
				throw null;
			}

			// Token: 0x04009454 RID: 37972
			public static readonly AxisGroup.Class1566 class1566_0;

			// Token: 0x04009455 RID: 37973
			public static Converter<AxisGroup.AxisPair, AxisGroup.AxisPair> converter_0;
		}
	}
}
