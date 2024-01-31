using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A74 RID: 2676
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class FakeCharacterGI : MonoBehaviour
{
	// Token: 0x06003AEC RID: 15084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_0()
	{
		throw null;
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x04003E58 RID: 15960
	public Shader FakeCharacterGIShader;

	// Token: 0x04003E59 RID: 15961
	public Color GIColor;

	// Token: 0x04003E5A RID: 15962
	public Vector3 GIDirection;

	// Token: 0x04003E5B RID: 15963
	public float GIPower;

	// Token: 0x04003E5C RID: 15964
	public Color SkylightColor;

	// Token: 0x04003E5D RID: 15965
	public Vector3 SkylightDirection;

	// Token: 0x04003E5E RID: 15966
	public float SkylightPower;

	// Token: 0x04003E5F RID: 15967
	private Material material_0;

	// Token: 0x04003E60 RID: 15968
	private Camera camera_0;

	// Token: 0x04003E61 RID: 15969
	private static readonly int int_0;

	// Token: 0x04003E62 RID: 15970
	private static readonly int int_1;

	// Token: 0x04003E63 RID: 15971
	private static readonly int int_2;

	// Token: 0x04003E64 RID: 15972
	private static readonly int int_3;

	// Token: 0x04003E65 RID: 15973
	private static readonly int int_4;

	// Token: 0x04003E66 RID: 15974
	private static readonly int int_5;

	// Token: 0x04003E67 RID: 15975
	private static readonly int int_6;
}
