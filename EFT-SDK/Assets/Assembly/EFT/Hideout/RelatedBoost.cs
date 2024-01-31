using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Hideout
{
	// Token: 0x02001BAB RID: 7083
	[Serializable]
	public sealed class RelatedBoost : RelatedData
	{
		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060094EE RID: 38126 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x00002050 File Offset: 0x00000250
		public override EPanelType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x060094F0 RID: 38128 RVA: 0x00002050 File Offset: 0x00000250
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009BBB RID: 39867
		public List<Requirement> Data;
	}
}
