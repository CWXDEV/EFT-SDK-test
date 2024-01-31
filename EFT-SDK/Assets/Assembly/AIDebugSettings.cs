using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000107 RID: 263
public class AIDebugSettings : ScriptableObject
{
	// Token: 0x170001AB RID: 427
	// (get) Token: 0x0600058B RID: 1419 RVA: 0x00002050 File Offset: 0x00000250
	public static AIDebugSettings Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x040006A3 RID: 1699
	private static AIDebugSettings aidebugSettings_0;

	// Token: 0x040006A4 RID: 1700
	public bool CoverPointDrawEnable;

	// Token: 0x040006A5 RID: 1701
	public Texture2D BearingPointIcon;

	// Token: 0x040006A6 RID: 1702
	public Texture2D SelectedBearingPointIcon;
}
