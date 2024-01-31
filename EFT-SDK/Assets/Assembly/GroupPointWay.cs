using System;
using System.Runtime.CompilerServices;

// Token: 0x02000159 RID: 345
[Serializable]
public class GroupPointWay : IComparable<GroupPointWay>
{
	// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(GroupPoint target)
	{
		throw null;
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(GroupPointWay other)
	{
		throw null;
	}

	// Token: 0x04000821 RID: 2081
	[NonSerialized]
	public GroupPoint Target;

	// Token: 0x04000822 RID: 2082
	public float Dist;

	// Token: 0x04000823 RID: 2083
	public int IdTarget;

	// Token: 0x04000824 RID: 2084
	public int Id;
}
