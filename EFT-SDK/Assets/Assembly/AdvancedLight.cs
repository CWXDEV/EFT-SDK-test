using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000AB7 RID: 2743
[ExecuteInEditMode]
public class AdvancedLight : MonoBehaviour, GInterface39
{
	// Token: 0x06003C15 RID: 15381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003C16 RID: 15382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003C17 RID: 15383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003C18 RID: 15384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateKeywords(Material material, Enum enumValue)
	{
		throw null;
	}

	// Token: 0x06003C19 RID: 15385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003C1A RID: 15386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003C1B RID: 15387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003C1E RID: 15390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x06003C1F RID: 15391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06003C20 RID: 15392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(CommandBuffer buffer, Plane[] frustrumPlanes, Camera cam)
	{
		throw null;
	}

	// Token: 0x04004182 RID: 16770
	public Shader Shader;

	// Token: 0x04004183 RID: 16771
	public AdvancedLight.LightTypeEnum LightType;

	// Token: 0x04004184 RID: 16772
	public Mesh Mesh;

	// Token: 0x04004185 RID: 16773
	public int SubMesh;

	// Token: 0x04004186 RID: 16774
	public Transform LightPosition;

	// Token: 0x04004187 RID: 16775
	[ColorUsage(false, true)]
	public Color Color;

	// Token: 0x04004188 RID: 16776
	public float Radius;

	// Token: 0x04004189 RID: 16777
	public AdvancedLight.ShadingTypeEnum ShadingType;

	// Token: 0x0400418A RID: 16778
	public bool ShowDebugShapes;

	// Token: 0x0400418B RID: 16779
	public Transform CubeControlHelper;

	// Token: 0x0400418C RID: 16780
	public bool FullScreen;

	// Token: 0x0400418D RID: 16781
	[HideInInspector]
	public Vector3 CubeScale;

	// Token: 0x0400418E RID: 16782
	[HideInInspector]
	public Vector3 CubeShift;

	// Token: 0x0400418F RID: 16783
	private Material material_0;

	// Token: 0x04004190 RID: 16784
	private Transform transform_0;

	// Token: 0x04004191 RID: 16785
	private Transform transform_1;

	// Token: 0x04004192 RID: 16786
	private int int_0;

	// Token: 0x04004193 RID: 16787
	private int int_1;

	// Token: 0x04004194 RID: 16788
	private int int_2;

	// Token: 0x04004195 RID: 16789
	private int int_3;

	// Token: 0x04004196 RID: 16790
	private int int_4;

	// Token: 0x04004197 RID: 16791
	private int int_5;

	// Token: 0x04004198 RID: 16792
	private float float_0;

	// Token: 0x04004199 RID: 16793
	private static readonly Vector3 vector3_0;

	// Token: 0x0400419A RID: 16794
	private static readonly Vector3 vector3_1;

	// Token: 0x0400419B RID: 16795
	private static readonly int int_6;

	// Token: 0x0400419C RID: 16796
	private static readonly int int_7;

	// Token: 0x0400419D RID: 16797
	private static readonly int int_8;

	// Token: 0x0400419E RID: 16798
	private static readonly int int_9;

	// Token: 0x0400419F RID: 16799
	private static readonly int int_10;

	// Token: 0x02000AB8 RID: 2744
	public enum LightTypeEnum
	{
		// Token: 0x040041A1 RID: 16801
		Point,
		// Token: 0x040041A2 RID: 16802
		Directional
	}

	// Token: 0x02000AB9 RID: 2745
	public enum ShadingTypeEnum
	{
		// Token: 0x040041A4 RID: 16804
		Diffuse,
		// Token: 0x040041A5 RID: 16805
		Specular,
		// Token: 0x040041A6 RID: 16806
		DiffuseAndSpecular
	}
}
