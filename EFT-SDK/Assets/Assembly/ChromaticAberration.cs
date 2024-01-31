using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A43 RID: 2627
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/ChromaticAberration")]
[ExecuteInEditMode]
public class ChromaticAberration : MonoBehaviour
{
	// Token: 0x060039A3 RID: 14755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060039A4 RID: 14756 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x17000995 RID: 2453
	// (get) Token: 0x060039A5 RID: 14757 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060039A6 RID: 14758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060039A7 RID: 14759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04003C9D RID: 15517
	public float Shift;

	// Token: 0x04003C9E RID: 15518
	public int Aniso;

	// Token: 0x04003C9F RID: 15519
	public bool Simple;

	// Token: 0x04003CA0 RID: 15520
	public Shader shader;

	// Token: 0x04003CA1 RID: 15521
	private Material material_0;

	// Token: 0x04003CA2 RID: 15522
	private static readonly int int_0;

	// Token: 0x04003CA3 RID: 15523
	private SSAAPropagator ssaapropagator_0;
}
