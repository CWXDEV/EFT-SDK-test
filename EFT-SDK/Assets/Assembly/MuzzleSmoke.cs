using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B16 RID: 2838
[ExecuteInEditMode]
public class MuzzleSmoke : MonoBehaviour
{
	// Token: 0x17000A00 RID: 2560
	// (get) Token: 0x06003D96 RID: 15766 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003D97 RID: 15767 RVA: 0x00002050 File Offset: 0x00000250
	public bool Destroyed
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003D99 RID: 15769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003D9A RID: 15770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateUpdateValues(Camera cam, float dt)
	{
		throw null;
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderObject()
	{
		throw null;
	}

	// Token: 0x06003D9C RID: 15772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06003D9E RID: 15774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shot()
	{
		throw null;
	}

	// Token: 0x06003D9F RID: 15775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Camera cam)
	{
		throw null;
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_0(float t)
	{
		throw null;
	}

	// Token: 0x06003DA1 RID: 15777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float velocity, bool skipProcess = true)
	{
		throw null;
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x040043F5 RID: 17397
	public Material Material;

	// Token: 0x040043F6 RID: 17398
	public float SmokeEnd;

	// Token: 0x040043F7 RID: 17399
	public float BrakeDistance;

	// Token: 0x040043F8 RID: 17400
	[Space(8f)]
	public float DragValue;

	// Token: 0x040043F9 RID: 17401
	public float Gravity;

	// Token: 0x040043FA RID: 17402
	public float SmokeVelocity;

	// Token: 0x040043FB RID: 17403
	[Space(8f)]
	public float TurbulenceDensity;

	// Token: 0x040043FC RID: 17404
	public float TurbulenceIntensity;

	// Token: 0x040043FD RID: 17405
	[Space(8f)]
	public float SmokeDiffusionBySmokeVelocity;

	// Token: 0x040043FE RID: 17406
	[Header("Driven By Muzzle Speed")]
	public float MuzzleSpeedMultiplier;

	// Token: 0x040043FF RID: 17407
	public AnimationCurve SpeedTurbulenceDensity;

	// Token: 0x04004400 RID: 17408
	public AnimationCurve SpeedTurbulenceStrength;

	// Token: 0x04004401 RID: 17409
	public AnimationCurve SpeedSmokeStrength;

	// Token: 0x04004402 RID: 17410
	public AnimationCurve SpeedStartDiffusion;

	// Token: 0x04004403 RID: 17411
	[Header("Driven By Time")]
	public AnimationCurve Smoke;

	// Token: 0x04004404 RID: 17412
	public float SmokeStrength;

	// Token: 0x04004405 RID: 17413
	public float SmokeLength;

	// Token: 0x04004406 RID: 17414
	public float SmokeLengthRandomness;

	// Token: 0x04004407 RID: 17415
	public float SmokeIncreasingByShot;

	// Token: 0x04004408 RID: 17416
	public float ShotFactorDropTime;

	// Token: 0x04004409 RID: 17417
	private float float_0;

	// Token: 0x0400440A RID: 17418
	private Transform transform_0;

	// Token: 0x0400440B RID: 17419
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400440C RID: 17420
	private float float_1;

	// Token: 0x0400440D RID: 17421
	private LinkedList<MuzzleSmoke.Class581> linkedList_0;

	// Token: 0x0400440E RID: 17422
	private Vector3 vector3_0;

	// Token: 0x0400440F RID: 17423
	private Vector3 vector3_1;

	// Token: 0x04004410 RID: 17424
	private Vector3 vector3_2;

	// Token: 0x04004411 RID: 17425
	private float float_2;

	// Token: 0x04004412 RID: 17426
	private int int_0;

	// Token: 0x04004413 RID: 17427
	private float float_3;

	// Token: 0x04004414 RID: 17428
	private float float_4;

	// Token: 0x04004415 RID: 17429
	private float float_5;

	// Token: 0x04004416 RID: 17430
	private int int_1;

	// Token: 0x02000B17 RID: 2839
	private class Class581
	{
		// Token: 0x04004417 RID: 17431
		public bool SkipProcess;

		// Token: 0x04004418 RID: 17432
		public Vector3 Position;

		// Token: 0x04004419 RID: 17433
		public Vector3 Velocity;

		// Token: 0x0400441A RID: 17434
		public Vector3 Turbulence;

		// Token: 0x0400441B RID: 17435
		public Vector3 Direction;

		// Token: 0x0400441C RID: 17436
		public Color32 Color;

		// Token: 0x0400441D RID: 17437
		public float Diffusion;

		// Token: 0x0400441E RID: 17438
		public float YUv;
	}
}
