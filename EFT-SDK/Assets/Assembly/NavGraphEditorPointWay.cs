using System;
using System.Runtime.CompilerServices;

// Token: 0x02000253 RID: 595
[Serializable]
public class NavGraphEditorPointWay : IComparable<NavGraphEditorPointWay>
{
	// Token: 0x170002FF RID: 767
	// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00002050 File Offset: 0x00000250
	public float Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(NavGraphEditorPointWay other)
	{
		throw null;
	}

	// Token: 0x04000BF6 RID: 3062
	public int TargetPointId;

	// Token: 0x04000BF7 RID: 3063
	public int StartPointId;

	// Token: 0x04000BF8 RID: 3064
	public int PathId;

	// Token: 0x04000BF9 RID: 3065
	public int Id;

	// Token: 0x04000BFA RID: 3066
	public int ReverseId;

	// Token: 0x04000BFB RID: 3067
	[NonSerialized]
	public NavGraphEditorPoint StartPoint;

	// Token: 0x04000BFC RID: 3068
	[NonSerialized]
	public NavGraphEditorPoint TargetPoint;

	// Token: 0x04000BFD RID: 3069
	[NonSerialized]
	public NavGraphEditorPath Path;

	// Token: 0x04000BFE RID: 3070
	[NonSerialized]
	public NavGraphEditorPointWay Reverse;
}
