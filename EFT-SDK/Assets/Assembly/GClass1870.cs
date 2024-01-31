using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x0200197E RID: 6526
public sealed class GClass1870
{
	// Token: 0x1700154C RID: 5452
	// (get) Token: 0x06008BC6 RID: 35782 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008BC7 RID: 35783 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06008BC8 RID: 35784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(GClass1870 other)
	{
		throw null;
	}

	// Token: 0x06008BC9 RID: 35785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetCorners(Vector3[] outCorners)
	{
		throw null;
	}

	// Token: 0x06008BCA RID: 35786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetPlanes(Plane[] outPlanes)
	{
		throw null;
	}

	// Token: 0x06008BCB RID: 35787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(Camera camera)
	{
		throw null;
	}

	// Token: 0x06008BCC RID: 35788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(Camera camera, float farClipPlane)
	{
		throw null;
	}

	// Token: 0x06008BCD RID: 35789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateEx(Vector3 position, Quaternion orientation, bool orthographic, float farClipPlane, float nearClipPlane, float fieldOfView, float aspect, float orthographicSize)
	{
		throw null;
	}

	// Token: 0x06008BCE RID: 35790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(Vector3 position, Quaternion orientation, float fov, float nearClipPlane, float farClipPlane, float aspect)
	{
		throw null;
	}

	// Token: 0x06008BCF RID: 35791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(ref Vector3 point)
	{
		throw null;
	}

	// Token: 0x06008BD0 RID: 35792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1870.IntersectionType GetSphereIntersection(ref Vector3 center, float radius, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD1 RID: 35793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1870.IntersectionType GetSphereIntersection(ref BoundingSphere sphere, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD2 RID: 35794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CullSpheres(GClass1870.GStruct233[] spheres, int sphereCount)
	{
		throw null;
	}

	// Token: 0x06008BD3 RID: 35795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IntersectsSphere(ref Vector3 center, float radius, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD4 RID: 35796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IntersectsSphere(ref BoundingSphere sphere, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD5 RID: 35797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IntersectsBox(ref Bounds box, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD6 RID: 35798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1870.IntersectionType GetBoxIntersection(ref Bounds box, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD7 RID: 35799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CullBoxes(GClass1870.GStruct232[] boxes, int boxCount)
	{
		throw null;
	}

	// Token: 0x06008BD8 RID: 35800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IntersectsOrientedBox(ref Bounds box, ref Vector3 right, ref Vector3 up, ref Vector3 forward, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BD9 RID: 35801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1870.IntersectionType GetOrientedBoxIntersection(ref Bounds box, ref Vector3 right, ref Vector3 up, ref Vector3 forward, float frustumPadding = 0f)
	{
		throw null;
	}

	// Token: 0x06008BDA RID: 35802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Camera camera)
	{
		throw null;
	}

	// Token: 0x06008BDB RID: 35803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3 position, Quaternion orientation, float farClipPlane, float nearClipPlane, float orthographicSize, float aspect)
	{
		throw null;
	}

	// Token: 0x06008BDC RID: 35804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetNearHeight()
	{
		throw null;
	}

	// Token: 0x06008BDD RID: 35805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(ref Vector3 position, ref Quaternion orientation, float fov, float nearClipPlane, float farClipPlane, float aspect)
	{
		throw null;
	}

	// Token: 0x04009166 RID: 37222
	public const int PlaneCount = 6;

	// Token: 0x04009167 RID: 37223
	public const int CornerCount = 8;

	// Token: 0x04009168 RID: 37224
	[CompilerGenerated]
	private Vector3 vector3_0;

	// Token: 0x04009169 RID: 37225
	private Vector3[] vector3_1;

	// Token: 0x0400916A RID: 37226
	private Plane[] plane_0;

	// Token: 0x0400916B RID: 37227
	private Vector3[] vector3_2;

	// Token: 0x0400916C RID: 37228
	private Vector3[] vector3_3;

	// Token: 0x0400916D RID: 37229
	private float[] float_0;

	// Token: 0x0200197F RID: 6527
	public enum IntersectionType
	{
		// Token: 0x0400916F RID: 37231
		Disjoint,
		// Token: 0x04009170 RID: 37232
		Intersects,
		// Token: 0x04009171 RID: 37233
		Contains
	}

	// Token: 0x02001980 RID: 6528
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct232
	{
		// Token: 0x04009172 RID: 37234
		public Vector3 BoxCenter;

		// Token: 0x04009173 RID: 37235
		public Vector3 BoxExtents;

		// Token: 0x04009174 RID: 37236
		public bool IsInFrustum;
	}

	// Token: 0x02001981 RID: 6529
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct233
	{
		// Token: 0x04009175 RID: 37237
		public Vector3 SphereCenter;

		// Token: 0x04009176 RID: 37238
		public float SphereRadius;

		// Token: 0x04009177 RID: 37239
		public bool IsInFrustum;
	}
}
