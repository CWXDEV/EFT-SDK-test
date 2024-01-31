using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

// Token: 0x02000669 RID: 1641
public class InteractiveProxy : MonoBehaviour
{
	// Token: 0x0600258C RID: 9612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetInteractionPosition(Vector3 yourPosition)
	{
		throw null;
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(WorldInteractiveObject obj, EDoorState prevstate, EDoorState nextstate)
	{
		throw null;
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1()
	{
		throw null;
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartFlicker()
	{
		throw null;
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetViewDirection(Vector3 yourPosition)
	{
		throw null;
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x040024B0 RID: 9392
	public WorldInteractiveObject Link;

	// Token: 0x040024B1 RID: 9393
	public GripPose[] Grips;

	// Token: 0x040024B2 RID: 9394
	public DoorHandle Handle;

	// Token: 0x040024B3 RID: 9395
	public Light StatusLight;

	// Token: 0x040024B4 RID: 9396
	public Light FlickerLight;

	// Token: 0x040024B5 RID: 9397
	public AnimationCurve FlickCurve;

	// Token: 0x040024B6 RID: 9398
	[SerializeField]
	private Vector3 _viewTarget;

	// Token: 0x040024B7 RID: 9399
	[SerializeField]
	private Vector3 _interactionPosition;
}
