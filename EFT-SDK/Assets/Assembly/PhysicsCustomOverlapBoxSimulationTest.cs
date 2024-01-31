using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006B6 RID: 1718
public class PhysicsCustomOverlapBoxSimulationTest : MonoBehaviour
{
	// Token: 0x060026CC RID: 9932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0()
	{
		throw null;
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int count, Collider[] result)
	{
		throw null;
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(BoxCollider col)
	{
		throw null;
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3()
	{
		throw null;
	}

	// Token: 0x04002612 RID: 9746
	[SerializeField]
	private BoxCollider _tester;

	// Token: 0x04002613 RID: 9747
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x04002614 RID: 9748
	[SerializeField]
	private bool _manualMode;

	// Token: 0x04002615 RID: 9749
	[SerializeField]
	private bool _simulateTriggers;

	// Token: 0x04002616 RID: 9750
	private BoxCollider[] boxCollider_0;

	// Token: 0x04002617 RID: 9751
	private Dictionary<Collider, PhysicsCustomOverlapBoxSimulationTest.BoxColliderGizmoDrawer> dictionary_0;

	// Token: 0x04002618 RID: 9752
	private PhysicsCustomOverlapBoxSimulationTest.BoxColliderGizmoDrawer[] boxColliderGizmoDrawer_0;

	// Token: 0x04002619 RID: 9753
	private GClass645 gclass645_0;

	// Token: 0x0400261A RID: 9754
	private Collider[] collider_0;

	// Token: 0x0400261B RID: 9755
	private Collider[][] collider_1;

	// Token: 0x0400261C RID: 9756
	private Transform transform_0;

	// Token: 0x0400261D RID: 9757
	private bool bool_0;

	// Token: 0x020006B7 RID: 1719
	public class BoxColliderGizmoDrawer : MonoBehaviour
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTriggerEnter(Collider other)
		{
			throw null;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTriggerExit(Collider other)
		{
			throw null;
		}

		// Token: 0x0400261E RID: 9758
		public BoxCollider Tester;

		// Token: 0x0400261F RID: 9759
		public BoxCollider Collider;

		// Token: 0x04002620 RID: 9760
		public bool IsOverlapDetected;

		// Token: 0x04002621 RID: 9761
		public bool IsTriggerDetected;

		// Token: 0x04002622 RID: 9762
		public bool IsTriggerDetectedPrevFrame;

		// Token: 0x04002623 RID: 9763
		public Func<bool> AllowSimulatePhysics;
	}
}
