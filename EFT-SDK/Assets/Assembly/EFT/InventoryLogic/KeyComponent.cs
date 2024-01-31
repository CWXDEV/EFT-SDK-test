using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x02002286 RID: 8838
	public class KeyComponent : GClass2750, IItemComponent, IRelativeComponent
	{
		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600B3E5 RID: 46053 RVA: 0x00002050 File Offset: 0x00000250
		public float RelativeValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0(int usage)
		{
			throw null;
		}

		// Token: 0x0400B81B RID: 47131
		private const string string_0 = "keycard_single";

		// Token: 0x0400B81C RID: 47132
		private const string string_1 = "keycard_reusable";

		// Token: 0x0400B81D RID: 47133
		private const string string_2 = "keycard_unlimited";

		// Token: 0x0400B81E RID: 47134
		public int NumberOfUsages;

		// Token: 0x0400B81F RID: 47135
		public readonly GInterface291 Template;

		// Token: 0x0400B820 RID: 47136
		public static readonly string RedColorFormat;

		// Token: 0x0400B821 RID: 47137
		public static readonly string WhiteColorFormat;

		// Token: 0x0400B822 RID: 47138
		public static readonly string CyanColorFormat;

		// Token: 0x02002287 RID: 8839
		[CompilerGenerated]
		private sealed class Class1953
		{
			// Token: 0x0400B823 RID: 47139
			public KeyComponent keyComponent_0;

			// Token: 0x0400B824 RID: 47140
			public GInterface291 template;
		}

		// Token: 0x02002288 RID: 8840
		[CompilerGenerated]
		private sealed class Class1954
		{
			// Token: 0x0600B3E7 RID: 46055 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0()
			{
				throw null;
			}

			// Token: 0x0600B3E8 RID: 46056 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x0400B825 RID: 47141
			public int maximumUsages;

			// Token: 0x0400B826 RID: 47142
			public KeyComponent.Class1953 class1953_0;
		}

		// Token: 0x02002289 RID: 8841
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1955
		{
			// Token: 0x0600B3E9 RID: 46057 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_0()
			{
				throw null;
			}

			// Token: 0x0600B3EA RID: 46058 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_1()
			{
				throw null;
			}

			// Token: 0x0400B827 RID: 47143
			public static readonly KeyComponent.Class1955 class1955_0;

			// Token: 0x0400B828 RID: 47144
			public static Func<EItemAttributeDisplayType> func_0;

			// Token: 0x0400B829 RID: 47145
			public static Func<EItemAttributeDisplayType> func_1;
		}
	}
}
