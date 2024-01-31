using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020004EE RID: 1262
public class BotCurvSettings : ScriptableObject
{
	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x06001F63 RID: 8035 RVA: 0x00002050 File Offset: 0x00000250
	public static BotCurvSettings Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotCurvSettings Copy()
	{
		throw null;
	}

	// Token: 0x04001A76 RID: 6774
	private static BotCurvSettings botCurvSettings_0;

	// Token: 0x04001A77 RID: 6775
	public AnimationCurve NightVisionSettings;

	// Token: 0x04001A78 RID: 6776
	public AnimationCurve StandartVisionSettings;

	// Token: 0x04001A79 RID: 6777
	public AnimationCurve VisionAngCoef;

	// Token: 0x04001A7A RID: 6778
	public AnimationCurve AimTime2Dist;

	// Token: 0x04001A7B RID: 6779
	public AnimationCurve AimAngCoef;

	// Token: 0x04001A7C RID: 6780
	public AnimationCurve AgsAimUp;

	// Token: 0x04001A7D RID: 6781
	public AnimationCurve MoveStartCurv;
}
