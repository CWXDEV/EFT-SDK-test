using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B0C RID: 2828
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Pixelation : MonoBehaviour
{
	// Token: 0x06003D71 RID: 15729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003D72 RID: 15730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destanation)
	{
		throw null;
	}

	// Token: 0x06003D73 RID: 15731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_0()
	{
		throw null;
	}

	// Token: 0x06003D74 RID: 15732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x040043AE RID: 17326
	public bool On;

	// Token: 0x040043AF RID: 17327
	public Pixelation.PixelationMode Mode;

	// Token: 0x040043B0 RID: 17328
	[SerializeField]
	private Shader _pixelationShader;

	// Token: 0x040043B1 RID: 17329
	[SerializeField]
	[Range(2f, 2048f)]
	private float _blockCount;

	// Token: 0x040043B2 RID: 17330
	[SerializeField]
	[Range(0f, 1f)]
	private float _alpha;

	// Token: 0x040043B3 RID: 17331
	[SerializeField]
	private Texture _pixelationMask;

	// Token: 0x040043B4 RID: 17332
	private Camera camera_0;

	// Token: 0x040043B5 RID: 17333
	private Material material_0;

	// Token: 0x040043B6 RID: 17334
	private static readonly int int_0;

	// Token: 0x040043B7 RID: 17335
	private static readonly int int_1;

	// Token: 0x040043B8 RID: 17336
	private static readonly int int_2;

	// Token: 0x040043B9 RID: 17337
	private static readonly int int_3;

	// Token: 0x02000B0D RID: 2829
	public enum PixelationMode
	{
		// Token: 0x040043BB RID: 17339
		Point,
		// Token: 0x040043BC RID: 17340
		CRT,
		// Token: 0x040043BD RID: 17341
		None = 10
	}
}
