using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000995 RID: 2453
public class RoadsGeneratorFixed : MonoBehaviour
{
	// Token: 0x06003721 RID: 14113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003722 RID: 14114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(RoadsGeneratorFixed.RoadPoint[] points)
	{
		throw null;
	}

	// Token: 0x06003723 RID: 14115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(RoadsGeneratorFixed.RoadPoint roadPoint, Vector3 direction)
	{
		throw null;
	}

	// Token: 0x06003724 RID: 14116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3[] method_2(RoadsGeneratorFixed.RoadPoint[] roadPoints)
	{
		throw null;
	}

	// Token: 0x06003725 RID: 14117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int[] method_3(Vector3[] vert)
	{
		throw null;
	}

	// Token: 0x06003726 RID: 14118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3[] method_4(RoadsGeneratorFixed.RoadPoint[] roadPoints)
	{
		throw null;
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2[] method_5(RoadsGeneratorFixed.RoadPoint[] points, int vertLen)
	{
		throw null;
	}

	// Token: 0x0400386B RID: 14443
	[SerializeField]
	private Material _material;

	// Token: 0x0400386C RID: 14444
	[SerializeField]
	private float _textureLength;

	// Token: 0x0400386D RID: 14445
	[SerializeField]
	private float _offsetAmount;

	// Token: 0x0400386E RID: 14446
	[SerializeField]
	private float _halfRaycastLength;

	// Token: 0x0400386F RID: 14447
	[SerializeField]
	public int OneSideAdditionalPointsAmount;

	// Token: 0x04003870 RID: 14448
	[SerializeField]
	private LayerMask _mask;

	// Token: 0x04003871 RID: 14449
	[SerializeField]
	private RoadsGeneratorFixed.RoadPoint[] _roadPoints;

	// Token: 0x04003872 RID: 14450
	private int int_0;

	// Token: 0x02000996 RID: 2454
	[Serializable]
	public class RoadPoint
	{
		// Token: 0x04003873 RID: 14451
		public Transform Point;

		// Token: 0x04003874 RID: 14452
		public float Width;

		// Token: 0x04003875 RID: 14453
		[HideInInspector]
		public Vector3[] Points;

		// Token: 0x04003876 RID: 14454
		[HideInInspector]
		public Vector3[] Normals;
	}
}
