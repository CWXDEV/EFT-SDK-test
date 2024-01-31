using System;
using System.Runtime.CompilerServices;

// Token: 0x02001272 RID: 4722
public class GClass1398
{
	// Token: 0x060062B9 RID: 25273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsDailyQuestZone(string zoneName)
	{
		throw null;
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass1398.EQuestZoneType method_0(string typePartOfName)
	{
		throw null;
	}

	// Token: 0x04006F41 RID: 28481
	private const string string_0 = "dl_";

	// Token: 0x04006F42 RID: 28482
	private const char char_0 = '_';

	// Token: 0x04006F43 RID: 28483
	public string Name;

	// Token: 0x04006F44 RID: 28484
	public string Location;

	// Token: 0x04006F45 RID: 28485
	public GClass1398.EQuestZoneType ZoneType;

	// Token: 0x02001273 RID: 4723
	public enum EQuestZoneType
	{
		// Token: 0x04006F47 RID: 28487
		Kill,
		// Token: 0x04006F48 RID: 28488
		Hide,
		// Token: 0x04006F49 RID: 28489
		Mark
	}
}
