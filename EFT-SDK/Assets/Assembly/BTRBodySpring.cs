using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000658 RID: 1624
[Serializable]
public class BTRBodySpring
{
	// Token: 0x06002544 RID: 9540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAccelerationLimitless(int comp, float val)
	{
		throw null;
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector3 GetValue(bool useOffset)
	{
		throw null;
	}

	// Token: 0x0400245E RID: 9310
	public float ReturnSpeed;

	// Token: 0x0400245F RID: 9311
	public float Damping;

	// Token: 0x04002460 RID: 9312
	public float Intensity;

	// Token: 0x04002461 RID: 9313
	public bool UseOffset;

	// Token: 0x04002462 RID: 9314
	[HideInInspector]
	public Vector3 Offset;

	// Token: 0x04002463 RID: 9315
	[HideInInspector]
	public Vector3 Velocity;

	// Token: 0x04002464 RID: 9316
	[HideInInspector]
	public Vector3 Current;

	// Token: 0x04002465 RID: 9317
	[HideInInspector]
	public Vector3 ForceAccumulatorLimitless;

	// Token: 0x04002466 RID: 9318
	[HideInInspector]
	public bool NeedUpdate;

	// Token: 0x04002467 RID: 9319
	[HideInInspector]
	public bool StableOn;
}
