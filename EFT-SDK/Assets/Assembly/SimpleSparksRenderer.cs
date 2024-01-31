using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AF7 RID: 2807
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class SimpleSparksRenderer : MonoBehaviour
{
	// Token: 0x06003D0F RID: 15631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fill(int pos, Vector2[] uv0, Vector2[] uv1, int[] triangles)
	{
		throw null;
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmitSeg(Vector3 position, Vector3 velocity, float time, float gravity, float drag, float lifeTime, byte emission = 255, byte size = 255, byte turbulence = 255, byte frequency = 255)
	{
		throw null;
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExpandBoundsFast(ref Bounds bounds, Vector3 position, float size)
	{
		throw null;
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003D16 RID: 15638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04004334 RID: 17204
	public int Segments;

	// Token: 0x04004335 RID: 17205
	public int Count;

	// Token: 0x04004336 RID: 17206
	private Vector3[] vector3_0;

	// Token: 0x04004337 RID: 17207
	private Vector3[] vector3_1;

	// Token: 0x04004338 RID: 17208
	private Vector4[] vector4_0;

	// Token: 0x04004339 RID: 17209
	private Color32[] color32_0;

	// Token: 0x0400433A RID: 17210
	private Mesh mesh_0;

	// Token: 0x0400433B RID: 17211
	private Bounds bounds_0;

	// Token: 0x0400433C RID: 17212
	private bool bool_0;

	// Token: 0x0400433D RID: 17213
	private int int_0;

	// Token: 0x0400433E RID: 17214
	private float float_0;

	// Token: 0x0400433F RID: 17215
	private Renderer renderer_0;

	// Token: 0x04004340 RID: 17216
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x04004341 RID: 17217
	private static readonly int int_1;

	// Token: 0x04004342 RID: 17218
	private static readonly int int_2;
}
