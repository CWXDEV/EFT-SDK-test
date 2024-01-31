using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A6B RID: 2667
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class LocalDustParticlesParent : MonoBehaviour
{
	// Token: 0x06003AB4 RID: 15028 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003AB5 RID: 15029 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003AB6 RID: 15030 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003AB7 RID: 15031 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GenerateMesh()
	{
		throw null;
	}

	// Token: 0x06003AB8 RID: 15032 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(int i, int[] triangles, Vector3[] positions, Vector2[] uv0, Vector2[] uv1, Vector4[] tangents, Color32[] colors, Matrix4x4 matrix, float sideSpeed, Vector2[][] uvs, Vector2[][] shifts, Color32[] rndColors)
	{
		throw null;
	}

	// Token: 0x06003AB9 RID: 15033 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color32[] smethod_1(Color color, int count, float randomnessAlpha)
	{
		throw null;
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06003ABB RID: 15035 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x06003ABC RID: 15036 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003ABD RID: 15037 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2[][] smethod_2(Vector2 size, int steps, float randomnessSize)
	{
		throw null;
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2[][] smethod_3(int width, int heigth, float padding = 0f)
	{
		throw null;
	}

	// Token: 0x06003ABF RID: 15039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T[] smethod_4<T>(T[] array, Func<T, bool> needToRemove)
	{
		throw null;
	}

	// Token: 0x06003AC0 RID: 15040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D[] smethod_5(Texture3D tex)
	{
		throw null;
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture3D smethod_6(Texture2D[] textures)
	{
		throw null;
	}

	// Token: 0x06003AC2 RID: 15042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D smethod_7(Texture2D tex, int width, int height, float xScale, float yScale, float xOffset, float yOffset)
	{
		throw null;
	}

	// Token: 0x06003AC3 RID: 15043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_8(Texture2D[] textures, int width, int height)
	{
		throw null;
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04003E16 RID: 15894
	public LocalDustParticles[] Childs;

	// Token: 0x04003E17 RID: 15895
	public float TimeSpeed;

	// Token: 0x04003E18 RID: 15896
	public float Size;

	// Token: 0x04003E19 RID: 15897
	public int QuadTileSetSide;

	// Token: 0x04003E1A RID: 15898
	public float UvTilePadding;

	// Token: 0x04003E1B RID: 15899
	private Material material_0;

	// Token: 0x04003E1C RID: 15900
	private static Vector2 vector2_0;

	// Token: 0x04003E1D RID: 15901
	private Vector3 vector3_0;

	// Token: 0x04003E1E RID: 15902
	public bool Regenerate;

	// Token: 0x04003E1F RID: 15903
	private Mesh mesh_0;

	// Token: 0x04003E20 RID: 15904
	private float float_0;

	// Token: 0x04003E21 RID: 15905
	private static readonly int int_0;

	// Token: 0x02000A6C RID: 2668
	[CompilerGenerated]
	[Serializable]
	private sealed class Class541
	{
		// Token: 0x06003AC5 RID: 15045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(LocalDustParticles ldp)
		{
			throw null;
		}

		// Token: 0x04003E22 RID: 15906
		public static readonly LocalDustParticlesParent.Class541 class541_0;

		// Token: 0x04003E23 RID: 15907
		public static Func<LocalDustParticles, bool> func_0;
	}
}
