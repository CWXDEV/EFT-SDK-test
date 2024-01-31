using System;
using System.Runtime.CompilerServices;

// Token: 0x02000158 RID: 344
[Serializable]
public class GroupPointPath : IComparable<GroupPointPath>
{
	// Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(GroupPointPath other)
	{
		throw null;
	}

	// Token: 0x0400081B RID: 2075
	public float Dist;

	// Token: 0x0400081C RID: 2076
	public int IdPath;

	// Token: 0x0400081D RID: 2077
	public int IdB;

	// Token: 0x0400081E RID: 2078
	public int IdA;

	// Token: 0x0400081F RID: 2079
	public GroupPointWay WayA;

	// Token: 0x04000820 RID: 2080
	public GroupPointWay WayB;
}
