using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x0200318B RID: 12683
	public abstract class AlignedItemLabels : ItemLabelsBase
	{
		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600F9FD RID: 63997 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F9FE RID: 63998 RVA: 0x00002050 File Offset: 0x00000250
		public ChartLabelAlignment Alignment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400FE20 RID: 65056
		[Tooltip("Select the alignment of the label relative to the item")]
		[SerializeField]
		private ChartLabelAlignment alignment;
	}
}
