using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02001183 RID: 4483
public static class GClass1293
{
	// Token: 0x17000EA6 RID: 3750
	// (get) Token: 0x06005E87 RID: 24199 RVA: 0x00002050 File Offset: 0x00000250
	public static DateTime UtcNow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EA7 RID: 3751
	// (get) Token: 0x06005E88 RID: 24200 RVA: 0x00002050 File Offset: 0x00000250
	public static DateTime Now
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EA8 RID: 3752
	// (get) Token: 0x06005E89 RID: 24201 RVA: 0x00002050 File Offset: 0x00000250
	public static double UtcNowUnix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EA9 RID: 3753
	// (get) Token: 0x06005E8A RID: 24202 RVA: 0x00002050 File Offset: 0x00000250
	public static int UtcNowUnixInt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EAA RID: 3754
	// (get) Token: 0x06005E8B RID: 24203 RVA: 0x00002050 File Offset: 0x00000250
	public static double NowUnix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EAB RID: 3755
	// (get) Token: 0x06005E8C RID: 24204 RVA: 0x00002050 File Offset: 0x00000250
	public static DateTime MoscowNow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005E8D RID: 24205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime LocalDateTimeFromUnixTime(double milliseconds)
	{
		throw null;
	}

	// Token: 0x06005E8E RID: 24206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime UniversalDateTimeFromUnixTime(double seconds)
	{
		throw null;
	}

	// Token: 0x06005E8F RID: 24207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double ToUnixTime(this DateTime dateTime)
	{
		throw null;
	}

	// Token: 0x06005E90 RID: 24208 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetServerTime(double milliseconds)
	{
		throw null;
	}

	// Token: 0x06005E91 RID: 24209 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime FromHour(int hour)
	{
		throw null;
	}

	// Token: 0x06005E92 RID: 24210 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime StartOfDay()
	{
		throw null;
	}

	// Token: 0x0400691C RID: 26908
	public const int SECONDS_IN_MINUTE = 60;

	// Token: 0x0400691D RID: 26909
	public const int SECONDS_IN_HOUR = 3600;

	// Token: 0x0400691E RID: 26910
	public const int SECONDS_IN_DAY = 86400;

	// Token: 0x0400691F RID: 26911
	public static readonly DateTime UnixEpoch;

	// Token: 0x04006920 RID: 26912
	private static DateTime dateTime_0;

	// Token: 0x04006921 RID: 26913
	private static DateTime dateTime_1;

	// Token: 0x04006922 RID: 26914
	private static Stopwatch stopwatch_0;
}
