using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200024F RID: 591
[Serializable]
public class NavGraphEditorPath
{
	// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NavGraphEditorPath Create(NavGraphEditorPoint from, NavGraphEditorPoint to, float dist, NavGraphContainer container)
	{
		throw null;
	}

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
	public float Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 MidPos()
	{
		throw null;
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBaseCoef()
	{
		throw null;
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DropCoef(float coef)
	{
		throw null;
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCoef(float coef)
	{
		throw null;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDoorLinkForOpenState(NavMeshDoorLink link)
	{
		throw null;
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDoorLinkForCloseState(NavMeshDoorLink link)
	{
		throw null;
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmosSelected(Vector3 up)
	{
		throw null;
	}

	// Token: 0x04000BD8 RID: 3032
	public int FromId;

	// Token: 0x04000BD9 RID: 3033
	public int ToId;

	// Token: 0x04000BDA RID: 3034
	public float Dist;

	// Token: 0x04000BDB RID: 3035
	public int Id;

	// Token: 0x04000BDC RID: 3036
	[NonSerialized]
	public NavGraphEditorPoint From;

	// Token: 0x04000BDD RID: 3037
	[NonSerialized]
	public NavGraphEditorPoint To;

	// Token: 0x04000BDE RID: 3038
	[NonSerialized]
	public HashSet<NavGraphEditorPoint> WaysTo;

	// Token: 0x04000BDF RID: 3039
	public int DoorLinkId;

	// Token: 0x04000BE0 RID: 3040
	[NonSerialized]
	private float float_0;
}
