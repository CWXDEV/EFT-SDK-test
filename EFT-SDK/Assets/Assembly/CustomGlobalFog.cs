using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A46 RID: 2630
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/CustomGlobalFog")]
[DisallowMultipleComponent]
public class CustomGlobalFog : MonoBehaviour
{
	// Token: 0x060039B2 RID: 14770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x17000996 RID: 2454
	// (get) Token: 0x060039B3 RID: 14771 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060039B4 RID: 14772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060039B5 RID: 14773 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060039B6 RID: 14774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Camera cam, out Vector3 topLeft, out Vector3 topRight, out Vector3 bottomLeft, out Vector3 bottomRight)
	{
		throw null;
	}

	// Token: 0x060039B7 RID: 14775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CustomBlit(Camera cam, RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr = 0)
	{
		throw null;
	}

	// Token: 0x060039B8 RID: 14776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(RenderTexture source, RenderTexture dest, Material mat)
	{
		throw null;
	}

	// Token: 0x060039B9 RID: 14777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Mesh smethod_1()
	{
		throw null;
	}

	// Token: 0x04003CB7 RID: 15543
	public Shader shader;

	// Token: 0x04003CB8 RID: 15544
	public CustomGlobalFog.BlendModes BlendMode;

	// Token: 0x04003CB9 RID: 15545
	public Color FogColor;

	// Token: 0x04003CBA RID: 15546
	public float FogStrength;

	// Token: 0x04003CBB RID: 15547
	public float FogY;

	// Token: 0x04003CBC RID: 15548
	public float FogToplength;

	// Token: 0x04003CBD RID: 15549
	public float FogTopIntensity;

	// Token: 0x04003CBE RID: 15550
	public float FogMaxDistance;

	// Token: 0x04003CBF RID: 15551
	public float FogStart;

	// Token: 0x04003CC0 RID: 15552
	public float DirectionDifferenceThreshold;

	// Token: 0x04003CC1 RID: 15553
	public float FuncSoftness;

	// Token: 0x04003CC2 RID: 15554
	public float FuncStart;

	// Token: 0x04003CC3 RID: 15555
	private Material material_0;

	// Token: 0x04003CC4 RID: 15556
	private Mesh mesh_0;

	// Token: 0x04003CC5 RID: 15557
	private Camera camera_0;

	// Token: 0x04003CC6 RID: 15558
	private static readonly int int_0;

	// Token: 0x04003CC7 RID: 15559
	private static readonly int int_1;

	// Token: 0x04003CC8 RID: 15560
	private static readonly int int_2;

	// Token: 0x04003CC9 RID: 15561
	private static readonly int int_3;

	// Token: 0x04003CCA RID: 15562
	private static readonly int int_4;

	// Token: 0x04003CCB RID: 15563
	private static readonly int int_5;

	// Token: 0x04003CCC RID: 15564
	private static readonly int int_6;

	// Token: 0x04003CCD RID: 15565
	private static readonly int int_7;

	// Token: 0x04003CCE RID: 15566
	private static readonly int int_8;

	// Token: 0x04003CCF RID: 15567
	private static readonly int int_9;

	// Token: 0x04003CD0 RID: 15568
	private static readonly int int_10;

	// Token: 0x02000A47 RID: 2631
	public enum BlendModes
	{
		// Token: 0x04003CD2 RID: 15570
		Normal,
		// Token: 0x04003CD3 RID: 15571
		Lighten,
		// Token: 0x04003CD4 RID: 15572
		Screen,
		// Token: 0x04003CD5 RID: 15573
		Overlay,
		// Token: 0x04003CD6 RID: 15574
		SoftLight
	}
}
