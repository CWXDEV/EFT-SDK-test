using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Profiling;

// Token: 0x02000B86 RID: 2950
public class DepthPhotograper : MonoBehaviour
{
	// Token: 0x17000A5E RID: 2654
	// (get) Token: 0x0600400D RID: 16397 RVA: 0x00002050 File Offset: 0x00000250
	public static DepthPhotograper Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A5F RID: 2655
	// (get) Token: 0x0600400E RID: 16398 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Render")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Render()
	{
		throw null;
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckIfCameraUnderRain(Transform cameraTransform)
	{
		throw null;
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x040048AF RID: 18607
	private static DepthPhotograper depthPhotograper_0;

	// Token: 0x040048B0 RID: 18608
	[SerializeField]
	private PowOfTwoDimensions _depthTextureDimension;

	// Token: 0x040048B1 RID: 18609
	[SerializeField]
	private float _yBias;

	// Token: 0x040048B2 RID: 18610
	private float float_0;

	// Token: 0x040048B3 RID: 18611
	private float float_1;

	// Token: 0x040048B4 RID: 18612
	private Vector3 vector3_0;

	// Token: 0x040048B5 RID: 18613
	private Camera camera_0;

	// Token: 0x040048B6 RID: 18614
	private Material material_0;

	// Token: 0x040048B7 RID: 18615
	[SerializeField]
	private RenderTexture _depthRT;

	// Token: 0x040048B8 RID: 18616
	private RenderTexture renderTexture_0;

	// Token: 0x040048B9 RID: 18617
	private static readonly int int_0;

	// Token: 0x040048BA RID: 18618
	private static readonly int int_1;

	// Token: 0x040048BB RID: 18619
	private static readonly int int_2;

	// Token: 0x040048BC RID: 18620
	private const float float_2 = 100f;

	// Token: 0x040048BD RID: 18621
	private int int_3;

	// Token: 0x040048BE RID: 18622
	private CustomSampler customSampler_0;

	// Token: 0x040048BF RID: 18623
	private Bounds bounds_0;
}
