using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A88 RID: 2696
public class HeatEmitter : MonoBehaviour
{
	// Token: 0x06003B65 RID: 15205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Emit()
	{
		throw null;
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003B68 RID: 15208 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnShot()
	{
		throw null;
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x04003FD0 RID: 16336
	public Vector3 Bounds;

	// Token: 0x04003FD1 RID: 16337
	public Vector3 Center;

	// Token: 0x04003FD2 RID: 16338
	public Vector2 LifetimeDelta;

	// Token: 0x04003FD3 RID: 16339
	public Vector2 Size;

	// Token: 0x04003FD4 RID: 16340
	public float IrradiationRate;

	// Token: 0x04003FD5 RID: 16341
	public float HeatIncreasePerShot;

	// Token: 0x04003FD6 RID: 16342
	public AnimationCurve CountByHeat;

	// Token: 0x04003FD7 RID: 16343
	public AnimationCurve LifeTimeByHeat;

	// Token: 0x04003FD8 RID: 16344
	public float _heat;

	// Token: 0x04003FD9 RID: 16345
	private float float_0;

	// Token: 0x04003FDA RID: 16346
	private Vector3 vector3_0;

	// Token: 0x04003FDB RID: 16347
	public float VelocityFactor;
}
