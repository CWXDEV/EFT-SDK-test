using System;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x020008F7 RID: 2295
[RequireComponent(typeof(LimbIK))]
[RequireComponent(typeof(Animator))]
public class KibaIK : MonoBehaviour
{
	// Token: 0x060033E1 RID: 13281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060033E2 RID: 13282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060033E3 RID: 13283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GripOn(float t)
	{
		throw null;
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GripOff(float t)
	{
		throw null;
	}

	// Token: 0x04003481 RID: 13441
	private float float_0;

	// Token: 0x04003482 RID: 13442
	private Animator animator_0;

	// Token: 0x04003483 RID: 13443
	private LimbIK limbIK_0;

	// Token: 0x04003484 RID: 13444
	private AnimationCurve animationCurve_0;

	// Token: 0x04003485 RID: 13445
	[Header("Curves")]
	public AnimationCurve OnCurve;

	// Token: 0x04003486 RID: 13446
	public AnimationCurve OffCurve;

	// Token: 0x04003487 RID: 13447
	private float float_1;

	// Token: 0x04003488 RID: 13448
	[Header("Debug")]
	public float TimeScale;

	// Token: 0x04003489 RID: 13449
	public int GripType;

	// Token: 0x0400348A RID: 13450
	private float float_2;
}
