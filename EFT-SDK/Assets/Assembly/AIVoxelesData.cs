using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200022C RID: 556
public class AIVoxelesData : MonoBehaviour
{
	// Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RestoreData(Dictionary<int, GroupPoint> data)
	{
		throw null;
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxValues(Vector3 max)
	{
		throw null;
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRestored()
	{
		throw null;
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OptimizeSerialization()
	{
		throw null;
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePoint(GroupPoint point)
	{
		throw null;
	}

	// Token: 0x04000B4B RID: 2891
	public NavGraphVoxelSimple[,,] VoxelesArray;

	// Token: 0x04000B4C RID: 2892
	public List<NavGraphVoxelSimple> VoxelsList;

	// Token: 0x04000B4D RID: 2893
	public Vector3 MinVoxelesValues;

	// Token: 0x04000B4E RID: 2894
	public Vector3 MaxVoxelesValues;

	// Token: 0x04000B4F RID: 2895
	public bool DrawVoxeles;

	// Token: 0x04000B50 RID: 2896
	public bool DrawClosestsPoints;

	// Token: 0x04000B51 RID: 2897
	public bool DrawDoorLinks;

	// Token: 0x04000B52 RID: 2898
	public float DistDrawVoxeles;

	// Token: 0x04000B53 RID: 2899
	public int MaxX;

	// Token: 0x04000B54 RID: 2900
	public int MaxY;

	// Token: 0x04000B55 RID: 2901
	public int MaxZ;

	// Token: 0x0200022D RID: 557
	[CompilerGenerated]
	[Serializable]
	private sealed class Class129
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(NavGraphVoxelSimple x)
		{
			throw null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(NavGraphVoxelSimple x)
		{
			throw null;
		}

		// Token: 0x04000B56 RID: 2902
		public static readonly AIVoxelesData.Class129 class129_0;

		// Token: 0x04000B57 RID: 2903
		public static Func<NavGraphVoxelSimple, bool> func_0;

		// Token: 0x04000B58 RID: 2904
		public static Func<NavGraphVoxelSimple, bool> func_1;
	}
}
