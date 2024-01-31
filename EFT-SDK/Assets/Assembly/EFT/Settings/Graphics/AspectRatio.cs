using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Settings.Graphics
{
	// Token: 0x02001998 RID: 6552
	[Serializable]
	public struct AspectRatio : IEquatable<AspectRatio>
	{
		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06008C3B RID: 35899 RVA: 0x00002050 File Offset: 0x00000250
		public static ReadOnlyCollection<AspectRatio> AvailableAspectRatios
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06008C3C RID: 35900 RVA: 0x00002050 File Offset: 0x00000250
		public static ReadOnlyCollection<AspectRatio> SortedAspectRatios
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Init()
		{
			throw null;
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06008C3E RID: 35902 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008C3F RID: 35903 RVA: 0x00002050 File Offset: 0x00000250
		public int X
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

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06008C40 RID: 35904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008C41 RID: 35905 RVA: 0x00002050 File Offset: 0x00000250
		public int Y
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

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06008C42 RID: 35906 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public float Division
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsClose(in AspectRatio ratio)
		{
			throw null;
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryToFindCorrectAspectRatio(ref AspectRatio ratio)
		{
			throw null;
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AspectRatio other)
		{
			throw null;
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static AspectRatio FindCloseRatio(EftResolution resolution)
		{
			throw null;
		}

		// Token: 0x040091DD RID: 37341
		private const float ASPECT_RATIO_THRESHOLD = 0.04f;

		// Token: 0x040091DE RID: 37342
		private static ReadOnlyCollection<AspectRatio> _availableAspectRatios;

		// Token: 0x040091DF RID: 37343
		private static ReadOnlyCollection<AspectRatio> _sortedAspectRatios;

		// Token: 0x040091E0 RID: 37344
		private static readonly AspectRatio[] _landscapeAspectRatios;

		// Token: 0x040091E1 RID: 37345
		private static readonly AspectRatio[] _portraitAspectRatios;

		// Token: 0x02001999 RID: 6553
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1530
		{
			// Token: 0x06008C4A RID: 35914 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(AspectRatio x)
			{
				throw null;
			}

			// Token: 0x040091E4 RID: 37348
			public static readonly AspectRatio.Class1530 class1530_0;

			// Token: 0x040091E5 RID: 37349
			public static Func<AspectRatio, int> func_0;
		}
	}
}
