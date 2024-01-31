using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200086E RID: 2158
[Serializable]
public class CoverSearchDebugPointsGroup : BotZoneDebugPointsGroup
{
	// Token: 0x1700086E RID: 2158
	// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00002050 File Offset: 0x00000250
	public float SearchRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030F3 RID: 12531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRadius(string label, float radius)
	{
		throw null;
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x040031C7 RID: 12743
	[SerializeField]
	private List<float> _searchRadiuses;

	// Token: 0x040031C8 RID: 12744
	public float SpecialRadius;

	// Token: 0x040031C9 RID: 12745
	public bool DrawAll;
}
