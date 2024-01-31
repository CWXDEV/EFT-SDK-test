using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020008F8 RID: 2296
public class MouseLook : MonoBehaviour
{
	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00002050 File Offset: 0x00000250
	public float RotationY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUpdate()
	{
		throw null;
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float ClampAngle(float angle, float min, float max)
	{
		throw null;
	}

	// Token: 0x0400348B RID: 13451
	public float MaximumY;

	// Token: 0x0400348C RID: 13452
	public float MinimumY;

	// Token: 0x0400348D RID: 13453
	public Vector3 Axis;

	// Token: 0x0400348E RID: 13454
	public Transform Root;

	// Token: 0x0400348F RID: 13455
	public float SensitivityY;

	// Token: 0x04003490 RID: 13456
	public MouseLook.InputAxisEnum InputAxis;

	// Token: 0x04003491 RID: 13457
	private Quaternion quaternion_0;

	// Token: 0x04003492 RID: 13458
	public bool UseLocalUpdate;

	// Token: 0x04003493 RID: 13459
	private float float_0;

	// Token: 0x020008F9 RID: 2297
	public enum InputAxisEnum
	{
		// Token: 0x04003495 RID: 13461
		X,
		// Token: 0x04003496 RID: 13462
		Y
	}
}
