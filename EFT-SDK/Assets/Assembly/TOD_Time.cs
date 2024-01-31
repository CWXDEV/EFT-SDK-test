using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020000C1 RID: 193
public class TOD_Time : MonoBehaviour
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnMinute
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnHour
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnDay
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnMonth
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnYear
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshTimeCurve()
	{
		throw null;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ApplyTimeCurve(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddHours(float hours, bool adjust = true)
	{
		throw null;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSeconds(float seconds)
	{
		throw null;
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Keyframe[] keys)
	{
		throw null;
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse)
	{
		throw null;
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private DateTime method_2()
	{
		throw null;
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Awake()
	{
		throw null;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void FixedUpdate()
	{
		throw null;
	}

	// Token: 0x040004AA RID: 1194
	public bool LockCurrentTime;

	// Token: 0x040004AB RID: 1195
	public GameDateTime GameDateTime;

	// Token: 0x040004AC RID: 1196
	public float DayLengthInMinutes;

	// Token: 0x040004AD RID: 1197
	[Tooltip("Set the date to the current device date on start.")]
	public bool UseDeviceDate;

	// Token: 0x040004AE RID: 1198
	[Tooltip("Set the time to the current device time on start.")]
	public bool UseDeviceTime;

	// Token: 0x040004AF RID: 1199
	[Tooltip("Apply the time curve when progressing time.")]
	public bool UseTimeCurve;

	// Token: 0x040004B0 RID: 1200
	[Tooltip("Time progression curve.")]
	public AnimationCurve TimeCurve;

	// Token: 0x040004B1 RID: 1201
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x040004B2 RID: 1202
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x040004B3 RID: 1203
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x040004B4 RID: 1204
	[CompilerGenerated]
	private Action action_3;

	// Token: 0x040004B5 RID: 1205
	[CompilerGenerated]
	private Action action_4;

	// Token: 0x040004B6 RID: 1206
	private TOD_Sky tod_Sky_0;

	// Token: 0x040004B7 RID: 1207
	private AnimationCurve animationCurve_0;

	// Token: 0x040004B8 RID: 1208
	private AnimationCurve animationCurve_1;

	// Token: 0x040004B9 RID: 1209
	private DateTime dateTime_0;

	// Token: 0x040004BA RID: 1210
	private const string string_0 = "d";
}
