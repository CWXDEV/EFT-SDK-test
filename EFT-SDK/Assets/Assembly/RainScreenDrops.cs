using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B7A RID: 2938
[DisallowMultipleComponent]
public class RainScreenDrops : MonoBehaviour
{
	// Token: 0x17000A54 RID: 2644
	// (get) Token: 0x06003FBB RID: 16315 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003FBC RID: 16316 RVA: 0x00002050 File Offset: 0x00000250
	public float Intensity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeGlassesState(bool hasGlasses)
	{
		throw null;
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06003FC0 RID: 16320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003FC3 RID: 16323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(RenderTexture source, RenderTexture destanation)
	{
		throw null;
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003FC5 RID: 16325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIntensity(float intensity)
	{
		throw null;
	}

	// Token: 0x040047F0 RID: 18416
	[SerializeField]
	[Header("Appearance settings")]
	private Shader _blitShader;

	// Token: 0x040047F1 RID: 18417
	[SerializeField]
	[Range(0f, 1f)]
	private float _intensity;

	// Token: 0x040047F2 RID: 18418
	[SerializeField]
	private float _refraction;

	// Token: 0x040047F3 RID: 18419
	[SerializeField]
	private float _refractionWithoutGlass;

	// Token: 0x040047F4 RID: 18420
	[SerializeField]
	private int _downsamplingCount;

	// Token: 0x040047F5 RID: 18421
	[Header("Drops settings")]
	[SerializeField]
	private AnimationCurve _dropScaleCurve;

	// Token: 0x040047F6 RID: 18422
	[SerializeField]
	private int _dropsAmount;

	// Token: 0x040047F7 RID: 18423
	[SerializeField]
	private float _rainDropsDelay;

	// Token: 0x040047F8 RID: 18424
	[SerializeField]
	private Vector2 _dropScale;

	// Token: 0x040047F9 RID: 18425
	[SerializeField]
	private float _dropLifetime;

	// Token: 0x040047FA RID: 18426
	[SerializeField]
	private float _dropLifetimeWithoutGlass;

	// Token: 0x040047FB RID: 18427
	[SerializeField]
	private bool _isDropsShouldMove;

	// Token: 0x040047FC RID: 18428
	[SerializeField]
	private int _maxDropsAtOnce;

	// Token: 0x040047FD RID: 18429
	[SerializeField]
	private Material _dropMaterial;

	// Token: 0x040047FE RID: 18430
	[SerializeField]
	private float _scaleMultiplierWithoutGlass;

	// Token: 0x040047FF RID: 18431
	private Material material_0;

	// Token: 0x04004800 RID: 18432
	public RenderTexture DuDvMap;

	// Token: 0x04004801 RID: 18433
	[Space(10f)]
	private RenderTexture renderTexture_0;

	// Token: 0x04004802 RID: 18434
	private GameObject gameObject_0;

	// Token: 0x04004803 RID: 18435
	private GClass870 gclass870_0;

	// Token: 0x04004804 RID: 18436
	private float float_0;

	// Token: 0x04004805 RID: 18437
	private float float_1;

	// Token: 0x04004806 RID: 18438
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x04004807 RID: 18439
	private bool bool_0;

	// Token: 0x04004808 RID: 18440
	[HideInInspector]
	public int Mode;

	// Token: 0x04004809 RID: 18441
	[SerializeField]
	[HideInInspector]
	public float InputMinL;

	// Token: 0x0400480A RID: 18442
	[SerializeField]
	[HideInInspector]
	public float InputMaxL;

	// Token: 0x0400480B RID: 18443
	[SerializeField]
	[HideInInspector]
	public float InputGammaL;

	// Token: 0x0400480C RID: 18444
	[SerializeField]
	[HideInInspector]
	public float InputMinR;

	// Token: 0x0400480D RID: 18445
	[SerializeField]
	[HideInInspector]
	public float InputMaxR;

	// Token: 0x0400480E RID: 18446
	[SerializeField]
	[HideInInspector]
	public float InputGammaR;

	// Token: 0x0400480F RID: 18447
	[HideInInspector]
	[SerializeField]
	public float InputMinG;

	// Token: 0x04004810 RID: 18448
	[HideInInspector]
	[SerializeField]
	public float InputMaxG;

	// Token: 0x04004811 RID: 18449
	[SerializeField]
	[HideInInspector]
	public float InputGammaG;

	// Token: 0x04004812 RID: 18450
	[HideInInspector]
	[SerializeField]
	public float InputMinB;

	// Token: 0x04004813 RID: 18451
	[HideInInspector]
	[SerializeField]
	public float InputMaxB;

	// Token: 0x04004814 RID: 18452
	[HideInInspector]
	[SerializeField]
	public float InputGammaB;

	// Token: 0x04004815 RID: 18453
	[SerializeField]
	[HideInInspector]
	public float OutputMinL;

	// Token: 0x04004816 RID: 18454
	[HideInInspector]
	[SerializeField]
	public float OutputMaxL;

	// Token: 0x04004817 RID: 18455
	[SerializeField]
	[HideInInspector]
	public float OutputMinR;

	// Token: 0x04004818 RID: 18456
	[SerializeField]
	[HideInInspector]
	public float OutputMaxR;

	// Token: 0x04004819 RID: 18457
	[SerializeField]
	[HideInInspector]
	public float OutputMinG;

	// Token: 0x0400481A RID: 18458
	[HideInInspector]
	[SerializeField]
	public float OutputMaxG;

	// Token: 0x0400481B RID: 18459
	[HideInInspector]
	[SerializeField]
	public float OutputMinB;

	// Token: 0x0400481C RID: 18460
	[HideInInspector]
	[SerializeField]
	public float OutputMaxB;

	// Token: 0x0400481D RID: 18461
	private static readonly int int_0;

	// Token: 0x0400481E RID: 18462
	private static readonly int int_1;

	// Token: 0x0400481F RID: 18463
	private static readonly int int_2;

	// Token: 0x04004820 RID: 18464
	private static readonly int int_3;

	// Token: 0x04004821 RID: 18465
	private static readonly int int_4;

	// Token: 0x04004822 RID: 18466
	private static readonly int int_5;

	// Token: 0x04004823 RID: 18467
	private static readonly int int_6;

	// Token: 0x04004824 RID: 18468
	private static readonly int int_7;

	// Token: 0x04004825 RID: 18469
	private static readonly int int_8;
}
