using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B73 RID: 2931
public class RainFallDrops : MonoBehaviour
{
	// Token: 0x17000A4F RID: 2639
	// (get) Token: 0x06003F96 RID: 16278 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003F97 RID: 16279 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x06003F98 RID: 16280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private MeshRenderer method_1(int particlesCount, Material material)
	{
		throw null;
	}

	// Token: 0x06003F9D RID: 16285 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Mesh smethod_0(int count)
	{
		throw null;
	}

	// Token: 0x04004791 RID: 18321
	[SerializeField]
	[Range(0f, 1f)]
	private float _intensity;

	// Token: 0x04004792 RID: 18322
	[SerializeField]
	[Range(0f, 1f)]
	private float _intensityThreshold;

	// Token: 0x04004793 RID: 18323
	[Range(128f, 16383f)]
	public int Count;

	// Token: 0x04004794 RID: 18324
	public Vector2 MinSize;

	// Token: 0x04004795 RID: 18325
	public Vector2 MaxSize;

	// Token: 0x04004796 RID: 18326
	public Vector2 MinMaxSideSpeed;

	// Token: 0x04004797 RID: 18327
	public Vector2 MinMaxDensity;

	// Token: 0x04004798 RID: 18328
	[SerializeField]
	private Material _close;

	// Token: 0x04004799 RID: 18329
	[SerializeField]
	[Range(0f, 1f)]
	public float DropsAlphaClose;

	// Token: 0x0400479A RID: 18330
	[SerializeField]
	[Range(0f, 1f)]
	public float MinAmbient;

	// Token: 0x0400479B RID: 18331
	[SerializeField]
	[Range(0f, 1f)]
	public float MinAmbientAddition;

	// Token: 0x0400479C RID: 18332
	[SerializeField]
	[Range(0f, 1f)]
	public float MinAmbientAdditionCoef;

	// Token: 0x0400479D RID: 18333
	public float SideSpeed;

	// Token: 0x0400479E RID: 18334
	private const int int_0 = 16383;

	// Token: 0x0400479F RID: 18335
	private MeshRenderer meshRenderer_0;

	// Token: 0x040047A0 RID: 18336
	private GameObject gameObject_0;

	// Token: 0x040047A1 RID: 18337
	private Material material_0;

	// Token: 0x040047A2 RID: 18338
	private static readonly int int_1;

	// Token: 0x040047A3 RID: 18339
	private static readonly int int_2;

	// Token: 0x040047A4 RID: 18340
	private static readonly int int_3;

	// Token: 0x040047A5 RID: 18341
	private static readonly int int_4;

	// Token: 0x040047A6 RID: 18342
	private static readonly int int_5;

	// Token: 0x040047A7 RID: 18343
	private static readonly int int_6;

	// Token: 0x040047A8 RID: 18344
	private static readonly int int_7;
}
