using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B77 RID: 2935
[DisallowMultipleComponent]
[AddComponentMenu("Image Effects/ScreenWater")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ScreenWater : MonoBehaviour
{
	// Token: 0x17000A51 RID: 2641
	// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003FAA RID: 16298 RVA: 0x00002050 File Offset: 0x00000250
	public float Intensity
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Awake()
	{
		throw null;
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Start()
	{
		throw null;
	}

	// Token: 0x17000A52 RID: 2642
	// (get) Token: 0x06003FAD RID: 16301 RVA: 0x00002050 File Offset: 0x00000250
	protected Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003FAE RID: 16302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIntensity(float intensity)
	{
		throw null;
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeGlassesState(bool hasGlases)
	{
		throw null;
	}

	// Token: 0x040047C0 RID: 18368
	[CompilerGenerated]
	private float float_0;

	// Token: 0x040047C1 RID: 18369
	public Shader shaderRGB;

	// Token: 0x040047C2 RID: 18370
	public float _distortionCooldownTime;

	// Token: 0x040047C3 RID: 18371
	public Texture2D WaterFlows;

	// Token: 0x040047C4 RID: 18372
	public Texture2D WaterMask;

	// Token: 0x040047C5 RID: 18373
	public Texture2D WetScreen;

	// Token: 0x040047C6 RID: 18374
	public float Speed;

	// Token: 0x040047C7 RID: 18375
	public float InitialIntensity;

	// Token: 0x040047C8 RID: 18376
	private Material material_0;

	// Token: 0x040047C9 RID: 18377
	private float float_1;

	// Token: 0x040047CA RID: 18378
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x040047CB RID: 18379
	private bool bool_0;

	// Token: 0x040047CC RID: 18380
	private static readonly int int_0;

	// Token: 0x040047CD RID: 18381
	private static readonly int int_1;

	// Token: 0x040047CE RID: 18382
	private static readonly int int_2;

	// Token: 0x040047CF RID: 18383
	private static readonly int int_3;

	// Token: 0x040047D0 RID: 18384
	private static readonly int int_4;
}
