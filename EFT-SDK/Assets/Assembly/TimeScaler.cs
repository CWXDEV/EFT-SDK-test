using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020008E6 RID: 2278
public class TimeScaler : MonoBehaviour
{
	// Token: 0x0600338C RID: 13196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x04003435 RID: 13365
	public bool IgnoreFixedUpdates;

	// Token: 0x04003436 RID: 13366
	private float float_0;

	// Token: 0x04003437 RID: 13367
	public Vector2 TimeScaleRange;

	// Token: 0x04003438 RID: 13368
	[Range(0.01f, 1f)]
	public float TimeScale;
}
