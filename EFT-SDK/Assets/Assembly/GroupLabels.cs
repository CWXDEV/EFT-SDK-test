using System;
using System.Runtime.CompilerServices;
using ChartAndGraph;
using UnityEngine;

// Token: 0x020000CE RID: 206
[Serializable]
public class GroupLabels : ItemLabelsBase
{
	// Token: 0x1700018A RID: 394
	// (get) Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
	public GroupLabelAlignment Alignment
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

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
	protected override Action<IInternalUse, bool> Assign
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(IInternalUse x, bool clear)
	{
		throw null;
	}

	// Token: 0x040004E9 RID: 1257
	[SerializeField]
	[Tooltip("Detemines the alignment of the group labels")]
	private GroupLabelAlignment alignment;
}
