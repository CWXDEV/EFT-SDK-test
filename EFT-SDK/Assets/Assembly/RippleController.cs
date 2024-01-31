using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B78 RID: 2936
[ExecuteInEditMode]
public class RippleController : MonoBehaviour
{
	// Token: 0x17000A53 RID: 2643
	// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x06003FB4 RID: 16308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0()
	{
		throw null;
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003FB6 RID: 16310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float dt, Vector4 waterCycle, Vector4 environmentCycle)
	{
		throw null;
	}

	// Token: 0x040047D1 RID: 18385
	private static int int_0;

	// Token: 0x040047D2 RID: 18386
	private static int int_1;

	// Token: 0x040047D3 RID: 18387
	private static int int_2;

	// Token: 0x040047D4 RID: 18388
	private static int int_3;

	// Token: 0x040047D5 RID: 18389
	private static int int_4;

	// Token: 0x040047D6 RID: 18390
	private static int int_5;

	// Token: 0x040047D7 RID: 18391
	private static int int_6;

	// Token: 0x040047D8 RID: 18392
	private static int int_7;

	// Token: 0x040047D9 RID: 18393
	private static int int_8;

	// Token: 0x040047DA RID: 18394
	private static int int_9;

	// Token: 0x040047DB RID: 18395
	private static int int_10;

	// Token: 0x040047DC RID: 18396
	private static bool bool_0;

	// Token: 0x040047DD RID: 18397
	[CompilerGenerated]
	private float float_0;

	// Token: 0x040047DE RID: 18398
	public Texture2D RippleTexture;

	// Token: 0x040047DF RID: 18399
	[Header("Water Ripples")]
	public RippleController.Cycle WaterCucle;

	// Token: 0x040047E0 RID: 18400
	public int RippleWaveCount;

	// Token: 0x040047E1 RID: 18401
	public float RippleWaveFreq;

	// Token: 0x040047E2 RID: 18402
	[Header("Environment Ripples")]
	public RippleController.Cycle EnvironmentCucle;

	// Token: 0x040047E3 RID: 18403
	[Range(0f, 1f)]
	public float WetDropsSpecular;

	// Token: 0x040047E4 RID: 18404
	[Range(0f, 1f)]
	public float WetDropsGlossness;

	// Token: 0x040047E5 RID: 18405
	[Range(0f, 1f)]
	public float WetDropsAlbedo;

	// Token: 0x040047E6 RID: 18406
	[Range(0f, 1f)]
	public float WetDropsNormal;

	// Token: 0x040047E7 RID: 18407
	[Range(0f, 3f)]
	public float RippleFakeLightIntensity;

	// Token: 0x040047E8 RID: 18408
	[Range(0f, 5f)]
	public float RainIntensityRippleScale;

	// Token: 0x040047E9 RID: 18409
	[SerializeField]
	private bool _forceTriplanar;

	// Token: 0x040047EA RID: 18410
	[SerializeField]
	private bool _useFakeRippleLight;

	// Token: 0x02000B79 RID: 2937
	[Serializable]
	public class Cycle
	{
		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector4 Update(float dt, float intensity)
		{
			throw null;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_0(float currentTime, float lastCucleLengthRelation, float newCucleLengthRelation)
		{
			throw null;
		}

		// Token: 0x040047EB RID: 18411
		public float CucleSpeed;

		// Token: 0x040047EC RID: 18412
		public Vector2 CucleLengthRelationMinMax;

		// Token: 0x040047ED RID: 18413
		public Vector2 IntensityMinMax;

		// Token: 0x040047EE RID: 18414
		private float _time;

		// Token: 0x040047EF RID: 18415
		private float _lastCucleLengthRelation;
	}
}
