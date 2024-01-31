using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020008E7 RID: 2279
[ExecuteAlways]
public class FakeInteriorTODController : MonoBehaviour
{
	// Token: 0x0600338D RID: 13197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x0600338E RID: 13198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float value, bool isDay, bool isNight)
	{
		throw null;
	}

	// Token: 0x0600338F RID: 13199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(float value)
	{
		throw null;
	}

	// Token: 0x04003439 RID: 13369
	private static readonly int int_0;

	// Token: 0x0400343A RID: 13370
	private static readonly int int_1;

	// Token: 0x0400343B RID: 13371
	private const float float_0 = 0.001f;

	// Token: 0x0400343C RID: 13372
	private float float_1;

	// Token: 0x0400343D RID: 13373
	private bool bool_0;

	// Token: 0x0400343E RID: 13374
	private bool bool_1;

	// Token: 0x0400343F RID: 13375
	private float float_2;

	// Token: 0x04003440 RID: 13376
	[SerializeField]
	private Vector2 _minMaxEmissionMultiplier;

	// Token: 0x04003441 RID: 13377
	[Range(0.01f, 3f)]
	[SerializeField]
	private float _switchDuration;

	// Token: 0x04003442 RID: 13378
	[SerializeField]
	private Vector2 _dayTimeRange;
}
