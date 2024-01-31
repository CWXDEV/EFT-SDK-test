using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A41 RID: 2625
public class SpecialBlur : MonoBehaviour
{
	// Token: 0x06003999 RID: 14745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_0()
	{
		throw null;
	}

	// Token: 0x0600399C RID: 14748 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(RenderTexture from, RenderTexture to)
	{
		throw null;
	}

	// Token: 0x0600399D RID: 14749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(RenderTexture from, RenderTexture to)
	{
		throw null;
	}

	// Token: 0x0600399E RID: 14750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPostRender()
	{
		throw null;
	}

	// Token: 0x04003C90 RID: 15504
	public Shader Shader;

	// Token: 0x04003C91 RID: 15505
	public RenderTexture From;

	// Token: 0x04003C92 RID: 15506
	public RenderTexture To;

	// Token: 0x04003C93 RID: 15507
	public RectTransform Target;

	// Token: 0x04003C94 RID: 15508
	public int BlurIterations;

	// Token: 0x04003C95 RID: 15509
	public float Snrength;

	// Token: 0x04003C96 RID: 15510
	public float Aspect;

	// Token: 0x04003C97 RID: 15511
	private Material material_0;

	// Token: 0x04003C98 RID: 15512
	private static readonly int int_0;
}
