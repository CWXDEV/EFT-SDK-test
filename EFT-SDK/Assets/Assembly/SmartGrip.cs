using System;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x020008FA RID: 2298
public class SmartGrip : GripPose
{
	// Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CacheAndDestroy()
	{
		throw null;
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Awake()
	{
		throw null;
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookAt(Vector3 target, bool debug = false)
	{
		throw null;
	}

	// Token: 0x060033ED RID: 13293 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableIK()
	{
		throw null;
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x04003497 RID: 13463
	public Quaternion _initial;

	// Token: 0x04003498 RID: 13464
	public Transform Targets;

	// Token: 0x04003499 RID: 13465
	public Transform Pivot;

	// Token: 0x0400349A RID: 13466
	public bool IkEnabled;

	// Token: 0x0400349B RID: 13467
	private LimbIK[] limbIK_0;

	// Token: 0x0400349C RID: 13468
	public Transform DEBUG_TARGET;

	// Token: 0x0400349D RID: 13469
	public float Weight;
}
