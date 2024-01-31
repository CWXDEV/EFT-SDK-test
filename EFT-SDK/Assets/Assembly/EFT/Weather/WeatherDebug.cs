using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DF0 RID: 7664
	[Serializable]
	public class WeatherDebug : IWeatherCurve
	{
		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x00002050 File Offset: 0x00000250
		Vector2 IWeatherCurve.Wind
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06009DDF RID: 40415 RVA: 0x00002050 File Offset: 0x00000250
		Vector2 IWeatherCurve.TopWind
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x00002050 File Offset: 0x00000250
		float IWeatherCurve.Rain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x00002050 File Offset: 0x00000250
		float IWeatherCurve.Cloudiness
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x00002050 File Offset: 0x00000250
		float IWeatherCurve.Fog
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x00002050 File Offset: 0x00000250
		float IWeatherCurve.Temperature
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06009DE4 RID: 40420 RVA: 0x00002050 File Offset: 0x00000250
		float IWeatherCurve.LightningThunderProbability
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DE6 RID: 40422 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
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

		// Token: 0x06009DE7 RID: 40423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHour(float hour)
		{
			throw null;
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetHour()
		{
			throw null;
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyParams(IWeatherCurve curve)
		{
			throw null;
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyParams(WeatherDebug from)
		{
			throw null;
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SavePreset()
		{
			throw null;
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadPreset()
		{
			throw null;
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private WeatherDebug method_0(WeatherDebug from)
		{
			throw null;
		}

		// Token: 0x0400A5DE RID: 42462
		[SerializeField]
		private bool isEnabled;

		// Token: 0x0400A5DF RID: 42463
		public bool IsDynamicSunWeatherDebug;

		// Token: 0x0400A5E0 RID: 42464
		[Range(0f, 1f)]
		public float WindMagnitude;

		// Token: 0x0400A5E1 RID: 42465
		public WeatherDebug.Direction WindDirection;

		// Token: 0x0400A5E2 RID: 42466
		public Vector2 TopWindDirection;

		// Token: 0x0400A5E3 RID: 42467
		[Range(-1f, 1f)]
		public float CloudDensity;

		// Token: 0x0400A5E4 RID: 42468
		[Range(0f, 0.255f)]
		public float Fog;

		// Token: 0x0400A5E5 RID: 42469
		[Range(0f, 1f)]
		public float Rain;

		// Token: 0x0400A5E6 RID: 42470
		[Range(0f, 1f)]
		public float LightningThunderProbability;

		// Token: 0x0400A5E7 RID: 42471
		[Range(-50f, 50f)]
		public float Temperature;

		// Token: 0x0400A5E8 RID: 42472
		public bool DebugMieMultiplier;

		// Token: 0x0400A5E9 RID: 42473
		[Range(0f, 10f)]
		public float MieMultiplier;

		// Token: 0x0400A5EA RID: 42474
		public bool MBOITFog;

		// Token: 0x0400A5EB RID: 42475
		public bool DebugMBOITFog;

		// Token: 0x0400A5EC RID: 42476
		public Color MBOITScatterColorMultiplier;

		// Token: 0x0400A5ED RID: 42477
		public float MBOITScatterDensityMultiplier;

		// Token: 0x0400A5EE RID: 42478
		public float MBOITScatterDensityPower;

		// Token: 0x0400A5EF RID: 42479
		public float ScatterDensityBias;

		// Token: 0x0400A5F0 RID: 42480
		[Range(0f, 1f)]
		public float ScatterGreyscale;

		// Token: 0x0400A5F1 RID: 42481
		[Range(2f, 100f)]
		public int MBOITScatterSlices;

		// Token: 0x0400A5F2 RID: 42482
		[Range(0.0001f, 0.5f)]
		public float MBOITScatterSlicesFar;

		// Token: 0x0400A5F3 RID: 42483
		public float MBOITScatterSlicesDistributionExp;

		// Token: 0x0400A5F4 RID: 42484
		public float MBOITFogSoftScale;

		// Token: 0x0400A5F5 RID: 42485
		public float MBOITFogSoftPower;

		// Token: 0x0400A5F6 RID: 42486
		[SerializeField]
		internal TOD_CycleParameters Date;

		// Token: 0x0400A5F7 RID: 42487
		private static WeatherDebug cachedWeather;

		// Token: 0x02001DF1 RID: 7665
		public enum Direction
		{
			// Token: 0x0400A5F9 RID: 42489
			East = 1,
			// Token: 0x0400A5FA RID: 42490
			North,
			// Token: 0x0400A5FB RID: 42491
			West,
			// Token: 0x0400A5FC RID: 42492
			South,
			// Token: 0x0400A5FD RID: 42493
			SE,
			// Token: 0x0400A5FE RID: 42494
			SW,
			// Token: 0x0400A5FF RID: 42495
			NW,
			// Token: 0x0400A600 RID: 42496
			NE
		}
	}
}
