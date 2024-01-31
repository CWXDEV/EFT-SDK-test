using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200012D RID: 301
[Serializable]
public class NavPoint
{
	// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEdge(NavEdge navEdge)
	{
		throw null;
	}

	// Token: 0x0400072E RID: 1838
	public int Id;

	// Token: 0x0400072F RID: 1839
	public bool IsValid;

	// Token: 0x04000730 RID: 1840
	public Vector3 Pos;

	// Token: 0x04000731 RID: 1841
	[NonSerialized]
	public HashSet<NavEdge> Edges;
}
