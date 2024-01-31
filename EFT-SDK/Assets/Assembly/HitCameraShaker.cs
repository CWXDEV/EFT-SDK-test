using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A8E RID: 2702
[DisallowMultipleComponent]
public class HitCameraShaker : MonoBehaviour
{
	// Token: 0x06003B79 RID: 15225 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003B7A RID: 15226 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hit(Vector3 hitDirection, float hitPower)
	{
		throw null;
	}

	// Token: 0x06003B7B RID: 15227 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateUpdate()
	{
		throw null;
	}

	// Token: 0x04003FFE RID: 16382
	[SerializeField]
	private AnimationCurve _positionCurve;

	// Token: 0x04003FFF RID: 16383
	[SerializeField]
	private AnimationCurve _hitBackCurve;

	// Token: 0x04004000 RID: 16384
	[SerializeField]
	private float _maxOffset;

	// Token: 0x04004001 RID: 16385
	[SerializeField]
	private float _goForwardTime;

	// Token: 0x04004002 RID: 16386
	[SerializeField]
	private float _goBackTime;

	// Token: 0x04004003 RID: 16387
	[SerializeField]
	private float _eulersNoiseXYMaxValue;

	// Token: 0x04004004 RID: 16388
	[SerializeField]
	private float _eulersNoiseZMaxValue;

	// Token: 0x04004005 RID: 16389
	[SerializeField]
	private float _positionXYNoise;

	// Token: 0x04004006 RID: 16390
	[SerializeField]
	private float _positionZNoise;

	// Token: 0x04004007 RID: 16391
	private float float_0;

	// Token: 0x04004008 RID: 16392
	private Vector3 vector3_0;

	// Token: 0x04004009 RID: 16393
	private Vector3 vector3_1;

	// Token: 0x0400400A RID: 16394
	[SerializeField]
	private Transform _transform;

	// Token: 0x0400400B RID: 16395
	private bool bool_0;

	// Token: 0x0400400C RID: 16396
	private Vector3 vector3_2;

	// Token: 0x0400400D RID: 16397
	private Vector3 vector3_3;

	// Token: 0x0400400E RID: 16398
	private AnimationCurve animationCurve_0;

	// Token: 0x0400400F RID: 16399
	private float float_1;
}
