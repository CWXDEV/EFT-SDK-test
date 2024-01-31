using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AAD RID: 2733
[ExecuteInEditMode]
public class AnalyticSource : MonoBehaviour
{
	// Token: 0x170009DA RID: 2522
	// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x00002050 File Offset: 0x00000250
	public int ActualDrawPriority
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003BE1 RID: 15329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003BE2 RID: 15330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Start()
	{
		throw null;
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003BE4 RID: 15332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003BE5 RID: 15333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSettings()
	{
		throw null;
	}

	// Token: 0x04004125 RID: 16677
	public bool IsAdditional;

	// Token: 0x04004126 RID: 16678
	public float LightIntensity;

	// Token: 0x04004127 RID: 16679
	[Range(0f, 8f)]
	public float LightIntensityMultiplicator;

	// Token: 0x04004128 RID: 16680
	public float FadeNormals;

	// Token: 0x04004129 RID: 16681
	public float AddAmbient;

	// Token: 0x0400412A RID: 16682
	public Vector2 DoorSize;

	// Token: 0x0400412B RID: 16683
	public Vector3 CubeScale;

	// Token: 0x0400412C RID: 16684
	public Vector3 CubeShift;

	// Token: 0x0400412D RID: 16685
	public Vector3 FadeOut;

	// Token: 0x0400412E RID: 16686
	public Transform CubeControlHelper;

	// Token: 0x0400412F RID: 16687
	public AmbientLight.CullingSettings Culling;

	// Token: 0x04004130 RID: 16688
	public StencilShadow LinkedStencilShadow;

	// Token: 0x04004131 RID: 16689
	[HideInInspector]
	public Bounds Bounds;

	// Token: 0x04004132 RID: 16690
	[HideInInspector]
	public MaterialPropertyBlock MaterialPropertyBlock;

	// Token: 0x04004133 RID: 16691
	[HideInInspector]
	public Matrix4x4 LocalToWorldMatrix;

	// Token: 0x04004134 RID: 16692
	[HideInInspector]
	public int ShaderPath;

	// Token: 0x04004135 RID: 16693
	public int DesiredDrawPriority;

	// Token: 0x04004136 RID: 16694
	[SerializeField]
	[HideInInspector]
	private int _drawPriority;

	// Token: 0x04004137 RID: 16695
	private static readonly int int_0;

	// Token: 0x04004138 RID: 16696
	private static readonly int int_1;

	// Token: 0x04004139 RID: 16697
	private static readonly int int_2;

	// Token: 0x0400413A RID: 16698
	private static readonly int int_3;

	// Token: 0x0400413B RID: 16699
	private static readonly int int_4;

	// Token: 0x0400413C RID: 16700
	private static readonly int int_5;

	// Token: 0x0400413D RID: 16701
	private static readonly int int_6;

	// Token: 0x0400413E RID: 16702
	private static readonly int int_7;

	// Token: 0x0400413F RID: 16703
	private static readonly int int_8;

	// Token: 0x04004140 RID: 16704
	[NonSerialized]
	public bool IsAutocullVisible;

	// Token: 0x04004141 RID: 16705
	public static bool EnableAutoculling;

	// Token: 0x04004142 RID: 16706
	public static bool EnableDraw;
}
