using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006A7 RID: 1703
public class ColliderExtrusion : MonoBehaviour
{
	// Token: 0x170006F3 RID: 1779
	// (get) Token: 0x06002695 RID: 9877 RVA: 0x00002050 File Offset: 0x00000250
	public Collider Collider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(LayerMask castMask)
	{
		throw null;
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCollider(Collider newCollider)
	{
		throw null;
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddIgnoredCollider(Collider collider)
	{
		throw null;
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveIgnoredCollider(Collider collider)
	{
		throw null;
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(Collider collider)
	{
		throw null;
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Calculate()
	{
		throw null;
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateThroughMotion(Vector3 motion)
	{
		throw null;
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator CalculateCoroutine(Vector3 position)
	{
		throw null;
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Calculate(Vector3 position, Quaternion rotation, float depenetrationModification = 0.001f)
	{
		throw null;
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshNeighbours(Vector3 position, Vector3 motion)
	{
		throw null;
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalculateDepenetration(Vector3 position, Quaternion rotation, float depenetrationModification = 0.001f)
	{
		throw null;
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetDepenetration()
	{
		throw null;
	}

	// Token: 0x040025C9 RID: 9673
	[SerializeField]
	private Collider _collider;

	// Token: 0x040025CA RID: 9674
	[SerializeField]
	private float _castHalo;

	// Token: 0x040025CB RID: 9675
	[SerializeField]
	private LayerMask _castMask;

	// Token: 0x040025CC RID: 9676
	private const int int_0 = 16;

	// Token: 0x040025CD RID: 9677
	private Collider[] collider_0;

	// Token: 0x040025CE RID: 9678
	private int int_1;

	// Token: 0x040025CF RID: 9679
	private float float_0;

	// Token: 0x040025D0 RID: 9680
	private Vector3 vector3_0;

	// Token: 0x040025D1 RID: 9681
	private WaitForEndOfFrame waitForEndOfFrame_0;

	// Token: 0x040025D2 RID: 9682
	private HashSet<Collider> hashSet_0;
}
