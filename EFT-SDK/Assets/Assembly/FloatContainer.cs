using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200025A RID: 602
public class FloatContainer : IComparable<FloatContainer>
{
	// Token: 0x17000305 RID: 773
	// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(FloatContainer other)
	{
		throw null;
	}

	// Token: 0x04000C26 RID: 3110
	public FloatContainer PrevPoint;

	// Token: 0x04000C27 RID: 3111
	public NavGraphEditorPoint Owner;

	// Token: 0x04000C28 RID: 3112
	public float Val;

	// Token: 0x04000C29 RID: 3113
	public float Dist;
}
