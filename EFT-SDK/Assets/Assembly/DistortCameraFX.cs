using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A67 RID: 2663
public class DistortCameraFX : MonoBehaviour
{
	// Token: 0x170009BB RID: 2491
	// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003A94 RID: 14996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003A95 RID: 14997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003A96 RID: 14998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003A97 RID: 14999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_0()
	{
		throw null;
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_1()
	{
		throw null;
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreCull()
	{
		throw null;
	}

	// Token: 0x06003A9E RID: 15006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(RenderTexture src, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(CommandBuffer buffer, Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(RenderTexture src)
	{
		throw null;
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddRenderer(DistortRenderer renderer)
	{
		throw null;
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveRenderer(DistortRenderer renderer)
	{
		throw null;
	}

	// Token: 0x04003DF1 RID: 15857
	private static readonly List<DistortRenderer> list_0;

	// Token: 0x04003DF2 RID: 15858
	public Shader Shader;

	// Token: 0x04003DF3 RID: 15859
	public float Distortion;

	// Token: 0x04003DF4 RID: 15860
	[Range(1f, 4f)]
	public int BlurIterations;

	// Token: 0x04003DF5 RID: 15861
	private Material material_0;

	// Token: 0x04003DF6 RID: 15862
	private Camera camera_0;

	// Token: 0x04003DF7 RID: 15863
	private SSAA ssaa_0;

	// Token: 0x04003DF8 RID: 15864
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x04003DF9 RID: 15865
	private CommandBuffer commandBuffer_0;

	// Token: 0x04003DFA RID: 15866
	private RenderTexture renderTexture_0;

	// Token: 0x04003DFB RID: 15867
	private RenderTexture renderTexture_1;

	// Token: 0x04003DFC RID: 15868
	private bool bool_0;

	// Token: 0x04003DFD RID: 15869
	private Vector2 vector2_0;

	// Token: 0x04003DFE RID: 15870
	private int int_0;

	// Token: 0x04003DFF RID: 15871
	private int int_1;

	// Token: 0x04003E00 RID: 15872
	private static readonly int int_2;

	// Token: 0x04003E01 RID: 15873
	private static readonly int int_3;

	// Token: 0x04003E02 RID: 15874
	private static readonly int int_4;

	// Token: 0x04003E03 RID: 15875
	private static readonly int int_5;
}
