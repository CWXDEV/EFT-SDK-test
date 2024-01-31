using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200065A RID: 1626
public sealed class WeatherEventController : MonoBehaviour
{
	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x06002547 RID: 9543 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002548 RID: 9544 RVA: 0x00002050 File Offset: 0x00000250
	public bool EventActive
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

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x06002549 RID: 9545 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600254A RID: 9546 RVA: 0x00002050 File Offset: 0x00000250
	public static bool ChangeTimeInProgress
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

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x0600254B RID: 9547 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600254C RID: 9548 RVA: 0x00002050 File Offset: 0x00000250
	public int DesiredHour
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

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x0600254D RID: 9549 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600254E RID: 9550 RVA: 0x00002050 File Offset: 0x00000250
	public int DesiredMinute
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

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x0600254F RID: 9551 RVA: 0x00002050 File Offset: 0x00000250
	public WeatherClass DestWeatherNode
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x06002550 RID: 9552 RVA: 0x00002050 File Offset: 0x00000250
	public GameDateTime GameDateTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeather(GClass1479 weatherSettings)
	{
		throw null;
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeather(int hours, int minutes, float cloudness, int windDirection, float wind, float rain, float rainRandomness, float scaterringFogDensity, Vector2 topWindDirection)
	{
		throw null;
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(bool val, int fromPercent = 0, bool force = false)
	{
		throw null;
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0400246B RID: 9323
	public static WeatherEventController Instance;

	// Token: 0x0400246C RID: 9324
	public const string WEATHER_EVENT = "weatherEvent";

	// Token: 0x0400246D RID: 9325
	public const int PRAY_ANIMATION_LAYER = 17;

	// Token: 0x0400246E RID: 9326
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400246F RID: 9327
	[CompilerGenerated]
	private static bool bool_1;

	// Token: 0x04002470 RID: 9328
	private float float_0;

	// Token: 0x04002471 RID: 9329
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04002472 RID: 9330
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04002473 RID: 9331
	public float SecToChange;

	// Token: 0x04002474 RID: 9332
	private DateTime dateTime_0;

	// Token: 0x04002475 RID: 9333
	[CompilerGenerated]
	private readonly WeatherClass gclass2101_0;

	// Token: 0x04002476 RID: 9334
	public float currentPercantage;

	// Token: 0x04002477 RID: 9335
	private long long_0;

	// Token: 0x04002478 RID: 9336
	private float float_1;
}
