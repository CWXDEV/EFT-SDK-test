using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.Weather;
using UnityEngine;

// Token: 0x02000BF8 RID: 3064
internal sealed class WinterEventVisual : MonoBehaviour, Interface3
{
	// Token: 0x17000ACA RID: 2762
	// (get) Token: 0x0600428E RID: 17038 RVA: 0x00002050 File Offset: 0x00000250
	private static LoggerClass GClass611_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000ACB RID: 2763
	// (get) Token: 0x0600428F RID: 17039 RVA: 0x00002050 File Offset: 0x00000250
	WeatherObstacle Interface3.WinterWeatherObstacle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000ACC RID: 2764
	// (get) Token: 0x06004290 RID: 17040 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000ACD RID: 2765
	// (get) Token: 0x06004291 RID: 17041 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004292 RID: 17042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Class419 controller)
	{
		throw null;
	}

	// Token: 0x06004295 RID: 17045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Setup()
	{
		throw null;
	}

	// Token: 0x06004296 RID: 17046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupOnReconnect()
	{
		throw null;
	}

	// Token: 0x06004297 RID: 17047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static WeatherDebug smethod_0()
	{
		throw null;
	}

	// Token: 0x06004298 RID: 17048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(WeatherDebug weather)
	{
		throw null;
	}

	// Token: 0x06004299 RID: 17049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2(WeatherDebug weather, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600429A RID: 17050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_3(WeatherDebug weather, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600429B RID: 17051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_4(WeatherDebug weather, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600429C RID: 17052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(WeatherDebug weather, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600429D RID: 17053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_6(WeatherDebug weather, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600429E RID: 17054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task smethod_1(RainController rainController, float delaySeconds, float incrementSeconds, float maximum, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600429F RID: 17055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7(RainController rainController, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x060042A0 RID: 17056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_8(RainController rainController, CancellationToken token)
	{
		throw null;
	}

	// Token: 0x04004BD9 RID: 19417
	public WeatherObstacle WinterWeatherObstacle;

	// Token: 0x04004BDA RID: 19418
	[Range(0f, 1f)]
	public float WIND_MAX;

	// Token: 0x04004BDB RID: 19419
	[Range(0f, 1f)]
	public float CLOUDS_MAX;

	// Token: 0x04004BDC RID: 19420
	[Range(0f, 0.255f)]
	public float FOG_MAX;

	// Token: 0x04004BDD RID: 19421
	[Range(0f, 1f)]
	public float SNOW_FLAKES_MAX;

	// Token: 0x04004BDE RID: 19422
	[Range(0f, 1f)]
	public float SNOWY_MAX;

	// Token: 0x04004BDF RID: 19423
	public Vector2 Common;

	// Token: 0x04004BE0 RID: 19424
	public Vector2 Wind;

	// Token: 0x04004BE1 RID: 19425
	public Vector2 Clouds;

	// Token: 0x04004BE2 RID: 19426
	public Vector2 Fog;

	// Token: 0x04004BE3 RID: 19427
	public Vector2 SnowFlakes;

	// Token: 0x04004BE4 RID: 19428
	public Vector2 Snowy;

	// Token: 0x04004BE5 RID: 19429
	public Vector2 Opaqueness;

	// Token: 0x04004BE6 RID: 19430
	public float SnowFlakesSideSpeedIncrementSeconds;

	// Token: 0x04004BE7 RID: 19431
	public float SnowFlakesSideSpeedMaximum;

	// Token: 0x04004BE8 RID: 19432
	private Task task_0;

	// Token: 0x04004BE9 RID: 19433
	private CancellationTokenSource cancellationTokenSource_0;
}
