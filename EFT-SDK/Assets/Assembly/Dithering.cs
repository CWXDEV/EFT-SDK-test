using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A69 RID: 2665
[AddComponentMenu("Image Effects/Dithering")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Dithering : MonoBehaviour
{
	// Token: 0x06003AAE RID: 15022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x170009BE RID: 2494
	// (get) Token: 0x06003AAF RID: 15023 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003AB0 RID: 15024 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003AB1 RID: 15025 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04003E06 RID: 15878
	public Texture DitTex;

	// Token: 0x04003E07 RID: 15879
	public Shader shader;

	// Token: 0x04003E08 RID: 15880
	private Material material_0;

	// Token: 0x04003E09 RID: 15881
	private static readonly int int_0;
}
