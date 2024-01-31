using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Hideout
{
	// Token: 0x02001BA9 RID: 7081
	[Serializable]
	public sealed class RelatedBonuses : RelatedData, IEnumerable, IEnumerable<GClass1404>
	{
		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x060094E6 RID: 38118 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x060094E7 RID: 38119 RVA: 0x00002050 File Offset: 0x00000250
		public override EPanelType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x060094E8 RID: 38120 RVA: 0x00002050 File Offset: 0x00000250
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<GClass1404> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04009BB9 RID: 39865
		public List<GClass1404> Data;
	}
}
