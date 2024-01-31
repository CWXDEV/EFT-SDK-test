using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B74 RID: 2932
public class RainSplashController : MonoBehaviour
{
	// Token: 0x17000A50 RID: 2640
	// (get) Token: 0x06003F9F RID: 16287 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003FA0 RID: 16288 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x06003FA1 RID: 16289 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Camera targetCamera)
	{
		throw null;
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x040047A9 RID: 18345
	[SerializeField]
	private DepthPhotograper _depthPhoto;

	// Token: 0x040047AA RID: 18346
	[SerializeField]
	private ParticleSystem _splashes;

	// Token: 0x040047AB RID: 18347
	[SerializeField]
	private float _splashLifetime;

	// Token: 0x040047AC RID: 18348
	[SerializeField]
	private Vector2 _particleSizeRange;

	// Token: 0x040047AD RID: 18349
	[SerializeField]
	private float _splashesOffset;

	// Token: 0x040047AE RID: 18350
	[SerializeField]
	private float _minDistance;

	// Token: 0x040047AF RID: 18351
	[SerializeField]
	private float _maxDistance;

	// Token: 0x040047B0 RID: 18352
	[SerializeField]
	private float _maxGeneratedParticlesInFrame;

	// Token: 0x040047B1 RID: 18353
	[SerializeField]
	private AnimationCurve _falloffCurve;

	// Token: 0x040047B2 RID: 18354
	[SerializeField]
	private AnimationCurve _dispersionCurve;

	// Token: 0x040047B3 RID: 18355
	private Transform transform_0;

	// Token: 0x040047B4 RID: 18356
	private float float_0;

	// Token: 0x040047B5 RID: 18357
	private GClass2981 gclass2981_0;
}
