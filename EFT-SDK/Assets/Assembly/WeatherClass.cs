using System;
using System.Runtime.CompilerServices;
using EFT.Weather;
using UnityEngine;

// Token: 0x02001DE5 RID: 7653
public class WeatherClass
{
	// Token: 0x06009D83 RID: 40323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WeatherClass CreateDefault()
	{
		throw null;
	}

	// Token: 0x06009D84 RID: 40324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EWeatherType GetWeatherTypeByNode()
	{
		throw null;
	}

	// Token: 0x06009D85 RID: 40325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WeatherClass[] GetFineTestWeatherNodes()
	{
		throw null;
	}

	// Token: 0x06009D86 RID: 40326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WeatherClass[] GetRandomTestWeatherNodes(int nodeDurationSeconds = 600, int nodeCount = 12)
	{
		throw null;
	}

	// Token: 0x06009D87 RID: 40327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static WeatherClass smethod_0(DateTime dateTime)
	{
		throw null;
	}

	// Token: 0x06009D88 RID: 40328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static WeatherClass smethod_1(DateTime dateTime)
	{
		throw null;
	}

	// Token: 0x06009D89 RID: 40329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static WeatherClass smethod_2(DateTime dateTime)
	{
		throw null;
	}

	// Token: 0x06009D8A RID: 40330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WeatherClass GetHalloweenWeatherNode(int secDuration)
	{
		throw null;
	}

	// Token: 0x06009D8B RID: 40331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400A53D RID: 42301
	public static readonly Vector2[] WindDirections;

	// Token: 0x0400A53E RID: 42302
	public long Time;

	// Token: 0x0400A53F RID: 42303
	public float Cloudness;

	// Token: 0x0400A540 RID: 42304
	public float Wind;

	// Token: 0x0400A541 RID: 42305
	public int WindDirection;

	// Token: 0x0400A542 RID: 42306
	public float Turbulence;

	// Token: 0x0400A543 RID: 42307
	public float Rain;

	// Token: 0x0400A544 RID: 42308
	public float RainRandomness;

	// Token: 0x0400A545 RID: 42309
	public float ScaterringFogDensity;

	// Token: 0x0400A546 RID: 42310
	public float ScaterringFogHeight;

	// Token: 0x0400A547 RID: 42311
	public float GlobalFogDensity;

	// Token: 0x0400A548 RID: 42312
	public float GlobalFogHeight;

	// Token: 0x0400A549 RID: 42313
	public float Temperature;

	// Token: 0x0400A54A RID: 42314
	public float AtmospherePressure;

	// Token: 0x0400A54B RID: 42315
	public Vector2 MainWindPosition;

	// Token: 0x0400A54C RID: 42316
	public Vector2 MainWindDirection;

	// Token: 0x0400A54D RID: 42317
	public Vector2 TopWindPosition;

	// Token: 0x0400A54E RID: 42318
	public Vector2 TopWindDirection;

	// Token: 0x0400A54F RID: 42319
	public float LyingWater;
}
