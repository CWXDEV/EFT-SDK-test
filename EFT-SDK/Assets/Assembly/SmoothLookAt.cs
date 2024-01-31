using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200099D RID: 2461
public class SmoothLookAt : MonoBehaviour
{
	// Token: 0x0600373C RID: 14140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0600373D RID: 14141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600373E RID: 14142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTransformForRotation(Transform forRotation)
	{
		throw null;
	}

	// Token: 0x0600373F RID: 14143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTransformToLookAt(Transform toLookAt)
	{
		throw null;
	}

	// Token: 0x06003740 RID: 14144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleWorking(bool enable)
	{
		throw null;
	}

	// Token: 0x06003741 RID: 14145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1()
	{
		throw null;
	}

	// Token: 0x06003742 RID: 14146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetTimeToLookAt()
	{
		throw null;
	}

	// Token: 0x06003743 RID: 14147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_2()
	{
		throw null;
	}

	// Token: 0x0400388F RID: 14479
	[SerializeField]
	private float _lerpToTargetRotationSpeed;

	// Token: 0x04003890 RID: 14480
	[SerializeField]
	private float _angleDifForStartRotation;

	// Token: 0x04003891 RID: 14481
	[SerializeField]
	private float _angleDifForStopRotation;

	// Token: 0x04003892 RID: 14482
	[SerializeField]
	private bool _returnStartRotationOnEnd;

	// Token: 0x04003893 RID: 14483
	[SerializeField]
	private float _returnToStartRotationTime;

	// Token: 0x04003894 RID: 14484
	private Transform transform_0;

	// Token: 0x04003895 RID: 14485
	private Transform transform_1;

	// Token: 0x04003896 RID: 14486
	private Vector3 vector3_0;

	// Token: 0x04003897 RID: 14487
	private Vector3 vector3_1;

	// Token: 0x04003898 RID: 14488
	private Coroutine coroutine_0;

	// Token: 0x04003899 RID: 14489
	private Coroutine coroutine_1;

	// Token: 0x0400389A RID: 14490
	private Quaternion quaternion_0;
}
