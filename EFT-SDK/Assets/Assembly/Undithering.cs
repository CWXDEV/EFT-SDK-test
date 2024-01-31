using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B39 RID: 2873
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Undithering")]
public class Undithering : MonoBehaviour
{
	// Token: 0x06003E26 RID: 15910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003E27 RID: 15911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003E29 RID: 15913 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x17000A07 RID: 2567
	// (get) Token: 0x06003E2A RID: 15914 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04004544 RID: 17732
	public Shader shader;

	// Token: 0x04004545 RID: 17733
	public bool useTriangleBlit;

	// Token: 0x04004546 RID: 17734
	[SerializeField]
	private bool _distortion;

	// Token: 0x04004547 RID: 17735
	private bool bool_0;

	// Token: 0x04004548 RID: 17736
	private Material material_0;

	// Token: 0x04004549 RID: 17737
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x0400454A RID: 17738
	private static readonly int int_0;

	// Token: 0x0400454B RID: 17739
	private static readonly int int_1;

	// Token: 0x0400454C RID: 17740
	private CommandBuffer commandBuffer_0;
}
