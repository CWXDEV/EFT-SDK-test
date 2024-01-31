using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A87 RID: 2695
[RequireComponent(typeof(Camera))]
public class GrenadeFlashScreenEffect : MonoBehaviour
{
	// Token: 0x170009CB RID: 2507
	// (get) Token: 0x06003B5C RID: 15196 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B5D RID: 15197 RVA: 0x00002050 File Offset: 0x00000250
	public float EffectStrength
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

	// Token: 0x06003B5E RID: 15198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003B5F RID: 15199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003B60 RID: 15200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003B61 RID: 15201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003B62 RID: 15202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x06003B63 RID: 15203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Explode(float flashStrength)
	{
		throw null;
	}

	// Token: 0x06003B64 RID: 15204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04003FC5 RID: 16325
	private const string string_0 = "_BlindnessCoef";

	// Token: 0x04003FC6 RID: 16326
	public PrismEffects PrismEffects;

	// Token: 0x04003FC7 RID: 16327
	public AnimationCurve WhiteBlack;

	// Token: 0x04003FC8 RID: 16328
	public Material FlashMaterial;

	// Token: 0x04003FC9 RID: 16329
	[CompilerGenerated]
	private float float_0;

	// Token: 0x04003FCA RID: 16330
	private Vector3 vector3_0;

	// Token: 0x04003FCB RID: 16331
	private float float_1;

	// Token: 0x04003FCC RID: 16332
	private float float_2;

	// Token: 0x04003FCD RID: 16333
	private float float_3;

	// Token: 0x04003FCE RID: 16334
	private static readonly int int_0;

	// Token: 0x04003FCF RID: 16335
	private SSAAPropagator ssaapropagator_0;
}
