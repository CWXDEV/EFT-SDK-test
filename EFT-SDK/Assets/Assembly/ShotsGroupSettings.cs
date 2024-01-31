using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020004D4 RID: 1236
[Serializable]
public class ShotsGroupSettings
{
	// Token: 0x06001EEB RID: 7915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsShotIndexInRange(int shotIndex)
	{
		throw null;
	}

	// Token: 0x040019CA RID: 6602
	public int StartShotIndex;

	// Token: 0x040019CB RID: 6603
	public int EndShotIndex;

	// Token: 0x040019CC RID: 6604
	[Tooltip("Разброс силы вращения, который добавляется к общим расчетам")]
	public Vector2 ShotRecoilRotationStrength;

	// Token: 0x040019CD RID: 6605
	[Tooltip("Разброс смещения позиции, который добавляется к общим расчетам")]
	public Vector2 ShotRecoilPositionStrength;

	// Token: 0x040019CE RID: 6606
	[Tooltip("Разброс угла вращения, который добавляется к общим расчетам")]
	public Vector2 ShotRecoilRadianRange;
}
