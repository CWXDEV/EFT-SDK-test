using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AB5 RID: 2741
public class LaserBeam : MonoBehaviour
{
	// Token: 0x06003C07 RID: 15367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(bool isYourPlayer)
	{
		throw null;
	}

	// Token: 0x06003C08 RID: 15368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003C09 RID: 15369 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Reset")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reset()
	{
		throw null;
	}

	// Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003C0B RID: 15371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003C0C RID: 15372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04004167 RID: 16743
	public float RayStart;

	// Token: 0x04004168 RID: 16744
	public float MaxDistance;

	// Token: 0x04004169 RID: 16745
	public bool UsePointLight;

	// Token: 0x0400416A RID: 16746
	public Material BeamMaterial;

	// Token: 0x0400416B RID: 16747
	public Material PointMaterial;

	// Token: 0x0400416C RID: 16748
	public LayerMask Mask;

	// Token: 0x0400416D RID: 16749
	public float BeamSize;

	// Token: 0x0400416E RID: 16750
	public float PointSizeClose;

	// Token: 0x0400416F RID: 16751
	public float PointSizeFar;

	// Token: 0x04004170 RID: 16752
	public float SurfaceOffsetForLight;

	// Token: 0x04004171 RID: 16753
	public float LightRange;

	// Token: 0x04004172 RID: 16754
	public float LightIntensity;

	// Token: 0x04004173 RID: 16755
	[SerializeField]
	private float IntensityFactor;

	// Token: 0x04004174 RID: 16756
	public Texture Cookie;

	// Token: 0x04004175 RID: 16757
	public Vector2 AngleCloseFar;

	// Token: 0x04004176 RID: 16758
	private bool bool_0;

	// Token: 0x04004177 RID: 16759
	private Mesh mesh_0;

	// Token: 0x04004178 RID: 16760
	private Mesh mesh_1;

	// Token: 0x04004179 RID: 16761
	private Light light_0;

	// Token: 0x0400417A RID: 16762
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x0400417B RID: 16763
	private MaterialPropertyBlock materialPropertyBlock_1;

	// Token: 0x0400417C RID: 16764
	private static readonly int int_0;

	// Token: 0x0400417D RID: 16765
	private static readonly int int_1;

	// Token: 0x0400417E RID: 16766
	private static readonly int int_2;

	// Token: 0x0400417F RID: 16767
	private static readonly int int_3;

	// Token: 0x04004180 RID: 16768
	private static readonly int int_4;

	// Token: 0x04004181 RID: 16769
	private static readonly int int_5;
}
