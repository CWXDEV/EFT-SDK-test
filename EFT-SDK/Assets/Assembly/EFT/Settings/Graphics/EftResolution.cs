using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace EFT.Settings.Graphics
{
	// Token: 0x020019BE RID: 6590
	[Serializable]
	public struct EftResolution : IEquatable<EftResolution>
	{
		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06008C82 RID: 35970 RVA: 0x00002050 File Offset: 0x00000250
		public static ReadOnlyCollection<EftResolution> AvailableResolutions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x00002050 File Offset: 0x00000250
		public static ReadOnlyCollection<EftResolution> SortedResolutions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Init()
		{
			throw null;
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AspectRatio GetAspectRatio()
		{
			throw null;
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static AspectRatio GetAspectRatio(int width, int height)
		{
			throw null;
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_0(int a, int b)
		{
			throw null;
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EftResolution other)
		{
			throw null;
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04009282 RID: 37506
		private static ReadOnlyCollection<EftResolution> _availableResolutions;

		// Token: 0x04009283 RID: 37507
		private static ReadOnlyCollection<EftResolution> _sortedResolutions;

		// Token: 0x04009284 RID: 37508
		public int Width;

		// Token: 0x04009285 RID: 37509
		public int Height;

		// Token: 0x020019BF RID: 6591
		internal class Class1538 : IComparer<EftResolution>
		{
			// Token: 0x06008C8C RID: 35980 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual int Compare(EftResolution r0, EftResolution r1)
			{
				throw null;
			}
		}

		// Token: 0x020019C0 RID: 6592
		internal sealed class Class1539 : EftResolution.Class1538
		{
			// Token: 0x06008C8D RID: 35981 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override int Compare(EftResolution r0, EftResolution r1)
			{
				throw null;
			}
		}

		// Token: 0x020019C1 RID: 6593
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1540
		{
			// Token: 0x06008C8E RID: 35982 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EftResolution method_0(EftResolution r)
			{
				throw null;
			}

			// Token: 0x04009286 RID: 37510
			public static readonly EftResolution.Class1540 class1540_0;

			// Token: 0x04009287 RID: 37511
			public static Func<EftResolution, EftResolution> func_0;
		}
	}
}
