using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A3E RID: 2622
[DisallowMultipleComponent]
public class BloodOnScreen : MonoBehaviour
{
	// Token: 0x17000992 RID: 2450
	// (get) Token: 0x06003982 RID: 14722 RVA: 0x00002050 File Offset: 0x00000250
	protected Material VignetteMaterial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003983 RID: 14723 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003986 RID: 14726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003987 RID: 14727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0600398B RID: 14731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hit(Vector3 direction)
	{
		throw null;
	}

	// Token: 0x0600398C RID: 14732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HitBleeding(Vector3 direction, bool isArterial = false)
	{
		throw null;
	}

	// Token: 0x0600398D RID: 14733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeGlassesState(bool hasGlasses)
	{
		throw null;
	}

	// Token: 0x0600398E RID: 14734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600398F RID: 14735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(RenderTexture texture)
	{
		throw null;
	}

	// Token: 0x06003992 RID: 14738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x04003C1C RID: 15388
	public bool DebugMode;

	// Token: 0x04003C1D RID: 15389
	public float BloodColorValue;

	// Token: 0x04003C1E RID: 15390
	public float Refraction;

	// Token: 0x04003C1F RID: 15391
	public int DownsamplingCount;

	// Token: 0x04003C20 RID: 15392
	public float MaxBloodTime;

	// Token: 0x04003C21 RID: 15393
	public int InitialBloodDrops;

	// Token: 0x04003C22 RID: 15394
	public Color BloodColor;

	// Token: 0x04003C23 RID: 15395
	public bool GenerateUniqueMaterials;

	// Token: 0x04003C24 RID: 15396
	public Shader BloodShader;

	// Token: 0x04003C25 RID: 15397
	public Material BlitMaterial;

	// Token: 0x04003C26 RID: 15398
	public Material FadeoutMat;

	// Token: 0x04003C27 RID: 15399
	public Material BloodDropMaterial;

	// Token: 0x04003C28 RID: 15400
	private Material material_0;

	// Token: 0x04003C29 RID: 15401
	public int RenderTextureDimension;

	// Token: 0x04003C2A RID: 15402
	private GClass841 gclass841_0;

	// Token: 0x04003C2B RID: 15403
	private RenderTexture renderTexture_0;

	// Token: 0x04003C2C RID: 15404
	public Vector2 StartScaleDimension;

	// Token: 0x04003C2D RID: 15405
	public Vector2 EndScaleDimension;

	// Token: 0x04003C2E RID: 15406
	public Vector2 DropCountRange;

	// Token: 0x04003C2F RID: 15407
	public Vector2 MaxRayLength;

	// Token: 0x04003C30 RID: 15408
	public Vector2 StartXdistribution;

	// Token: 0x04003C31 RID: 15409
	public Vector2 StartYdistribution;

	// Token: 0x04003C32 RID: 15410
	public Vector2 EndXdistribution;

	// Token: 0x04003C33 RID: 15411
	public Vector2 EndYdistribution;

	// Token: 0x04003C34 RID: 15412
	public Vector2 DropLifetimeDistribution;

	// Token: 0x04003C35 RID: 15413
	public float OffGlassScaleMultiplier;

	// Token: 0x04003C36 RID: 15414
	public float OffGlassLifetimeMultiplier;

	// Token: 0x04003C37 RID: 15415
	private GClass840 gclass840_0;

	// Token: 0x04003C38 RID: 15416
	public int Mode;

	// Token: 0x04003C39 RID: 15417
	[HideInInspector]
	[SerializeField]
	public float InputMinL;

	// Token: 0x04003C3A RID: 15418
	[HideInInspector]
	[SerializeField]
	public float InputMaxL;

	// Token: 0x04003C3B RID: 15419
	[SerializeField]
	[HideInInspector]
	public float InputGammaL;

	// Token: 0x04003C3C RID: 15420
	[SerializeField]
	[HideInInspector]
	public float InputMinR;

	// Token: 0x04003C3D RID: 15421
	[SerializeField]
	[HideInInspector]
	public float InputMaxR;

	// Token: 0x04003C3E RID: 15422
	[HideInInspector]
	[SerializeField]
	public float InputGammaR;

	// Token: 0x04003C3F RID: 15423
	[SerializeField]
	[HideInInspector]
	public float InputMinG;

	// Token: 0x04003C40 RID: 15424
	[SerializeField]
	[HideInInspector]
	public float InputMaxG;

	// Token: 0x04003C41 RID: 15425
	[SerializeField]
	[HideInInspector]
	public float InputGammaG;

	// Token: 0x04003C42 RID: 15426
	[HideInInspector]
	[SerializeField]
	public float InputMinB;

	// Token: 0x04003C43 RID: 15427
	[SerializeField]
	[HideInInspector]
	public float InputMaxB;

	// Token: 0x04003C44 RID: 15428
	[HideInInspector]
	[SerializeField]
	public float InputGammaB;

	// Token: 0x04003C45 RID: 15429
	[HideInInspector]
	[SerializeField]
	public float OutputMinL;

	// Token: 0x04003C46 RID: 15430
	[HideInInspector]
	[SerializeField]
	public float OutputMaxL;

	// Token: 0x04003C47 RID: 15431
	[HideInInspector]
	[SerializeField]
	public float OutputMinR;

	// Token: 0x04003C48 RID: 15432
	[HideInInspector]
	[SerializeField]
	public float OutputMaxR;

	// Token: 0x04003C49 RID: 15433
	[SerializeField]
	[HideInInspector]
	public float OutputMinG;

	// Token: 0x04003C4A RID: 15434
	[HideInInspector]
	[SerializeField]
	public float OutputMaxG;

	// Token: 0x04003C4B RID: 15435
	[HideInInspector]
	[SerializeField]
	public float OutputMinB;

	// Token: 0x04003C4C RID: 15436
	[SerializeField]
	[HideInInspector]
	public float OutputMaxB;

	// Token: 0x04003C4D RID: 15437
	public Vector2 center;

	// Token: 0x04003C4E RID: 15438
	[Range(-100f, 100f)]
	public float sharpness;

	// Token: 0x04003C4F RID: 15439
	[Range(0f, 100f)]
	public float darkness;

	// Token: 0x04003C50 RID: 15440
	private float float_0;

	// Token: 0x04003C51 RID: 15441
	protected Material _vignetteMaterial;

	// Token: 0x04003C52 RID: 15442
	private float float_1;

	// Token: 0x04003C53 RID: 15443
	private RenderTexture renderTexture_1;

	// Token: 0x04003C54 RID: 15444
	private RenderTexture renderTexture_2;

	// Token: 0x04003C55 RID: 15445
	private RenderTexture renderTexture_3;

	// Token: 0x04003C56 RID: 15446
	private RenderTexture renderTexture_4;

	// Token: 0x04003C57 RID: 15447
	private bool bool_0;

	// Token: 0x04003C58 RID: 15448
	private bool bool_1;

	// Token: 0x04003C59 RID: 15449
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x04003C5A RID: 15450
	private static readonly int int_0;

	// Token: 0x04003C5B RID: 15451
	private static readonly int int_1;

	// Token: 0x04003C5C RID: 15452
	private static readonly int int_2;

	// Token: 0x04003C5D RID: 15453
	private static readonly int int_3;

	// Token: 0x04003C5E RID: 15454
	private static readonly int int_4;

	// Token: 0x04003C5F RID: 15455
	private static readonly int int_5;

	// Token: 0x04003C60 RID: 15456
	private static readonly int int_6;

	// Token: 0x04003C61 RID: 15457
	private static readonly int int_7;

	// Token: 0x04003C62 RID: 15458
	private static readonly int int_8;

	// Token: 0x04003C63 RID: 15459
	private static readonly int int_9;

	// Token: 0x04003C64 RID: 15460
	private static readonly int int_10;

	// Token: 0x04003C65 RID: 15461
	private static readonly int int_11;

	// Token: 0x04003C66 RID: 15462
	private static readonly int int_12;

	// Token: 0x04003C67 RID: 15463
	private static readonly int int_13;
}
