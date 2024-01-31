using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B34 RID: 2868
[AddComponentMenu("Image Effects/TopLight")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class TopLight : MonoBehaviour
{
	// Token: 0x17000A06 RID: 2566
	// (get) Token: 0x06003E0C RID: 15884 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003E0D RID: 15885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003E0E RID: 15886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003E0F RID: 15887 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400451D RID: 17693
	public Shader TheShader;

	// Token: 0x0400451E RID: 17694
	public Color Color;

	// Token: 0x0400451F RID: 17695
	private Material material_0;

	// Token: 0x04004520 RID: 17696
	private Color color_0;

	// Token: 0x04004521 RID: 17697
	private static readonly int int_0;
}
