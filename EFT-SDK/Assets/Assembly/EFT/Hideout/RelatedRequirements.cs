using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Hideout
{
	// Token: 0x02001BA7 RID: 7079
	[Serializable]
	public sealed class RelatedRequirements : RelatedData, IEnumerable, IEnumerable<Requirement>
	{
		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x060094DD RID: 38109 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x060094DE RID: 38110 RVA: 0x00002050 File Offset: 0x00000250
		public override EPanelType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x060094DF RID: 38111 RVA: 0x00002050 File Offset: 0x00000250
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<Requirement> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<Type> GetFilteredTypeList()
		{
			throw null;
		}

		// Token: 0x04009BB4 RID: 39860
		public List<Requirement> Data;

		// Token: 0x02001BA8 RID: 7080
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1674
		{
			// Token: 0x060094E3 RID: 38115 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Type x)
			{
				throw null;
			}

			// Token: 0x060094E4 RID: 38116 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Type x)
			{
				throw null;
			}

			// Token: 0x060094E5 RID: 38117 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Type x)
			{
				throw null;
			}

			// Token: 0x04009BB5 RID: 39861
			public static readonly RelatedRequirements.Class1674 class1674_0;

			// Token: 0x04009BB6 RID: 39862
			public static Func<Type, bool> func_0;

			// Token: 0x04009BB7 RID: 39863
			public static Func<Type, bool> func_1;

			// Token: 0x04009BB8 RID: 39864
			public static Func<Type, bool> func_2;
		}
	}
}
