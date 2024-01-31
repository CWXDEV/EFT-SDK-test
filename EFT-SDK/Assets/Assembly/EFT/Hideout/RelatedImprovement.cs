using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Hideout
{
	// Token: 0x02001BAE RID: 7086
	[Serializable]
	public sealed class RelatedImprovement : RelatedData, IEnumerable, IEnumerable<GClass1908>
	{
		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x060094F8 RID: 38136 RVA: 0x00002050 File Offset: 0x00000250
		public override EPanelType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x00002050 File Offset: 0x00000250
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<GClass1908> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04009BBE RID: 39870
		public List<GClass1908> Data;
	}
}
