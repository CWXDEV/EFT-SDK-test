using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Hideout
{
	// Token: 0x02001BAC RID: 7084
	[Serializable]
	public sealed class RelatedFuelSupply : RelatedData
	{
		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x060094F1 RID: 38129 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x060094F2 RID: 38130 RVA: 0x00002050 File Offset: 0x00000250
		public override EPanelType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x060094F3 RID: 38131 RVA: 0x00002050 File Offset: 0x00000250
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009BBC RID: 39868
		public List<HideoutControllerClass> Data;
	}
}
