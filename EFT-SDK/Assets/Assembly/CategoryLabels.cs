using System;
using System.Runtime.CompilerServices;
using ChartAndGraph;
using UnityEngine;

// Token: 0x020000CB RID: 203
[Serializable]
public class CategoryLabels : AlignedItemLabels
{
	// Token: 0x17000188 RID: 392
	// (get) Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
	public CategoryLabels.ChartCategoryLabelOptions VisibleLabels
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

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
	protected override Action<IInternalUse, bool> Assign
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(IInternalUse x, bool clear)
	{
		throw null;
	}

	// Token: 0x040004E2 RID: 1250
	[SerializeField]
	[Tooltip("Determines which labels are visible")]
	private CategoryLabels.ChartCategoryLabelOptions visibleLabels;

	// Token: 0x020000CC RID: 204
	public enum ChartCategoryLabelOptions
	{
		// Token: 0x040004E4 RID: 1252
		All,
		// Token: 0x040004E5 RID: 1253
		FirstOnly
	}
}
