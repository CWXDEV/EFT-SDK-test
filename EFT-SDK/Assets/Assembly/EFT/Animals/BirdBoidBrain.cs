using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animals
{
	// Token: 0x02002FBA RID: 12218
	[RequireComponent(typeof(Bird))]
	public class BirdBoidBrain : MonoBehaviour
	{
		// Token: 0x0600F13E RID: 61758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(BirdBoidsSpawner swarmBrain)
		{
			throw null;
		}

		// Token: 0x0600F13F RID: 61759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Start()
		{
			throw null;
		}

		// Token: 0x0600F140 RID: 61760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		// Token: 0x0600F141 RID: 61761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected IEnumerator CalculateVelocity()
		{
			throw null;
		}

		// Token: 0x0600F142 RID: 61762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected IEnumerator UpdateBirdDirection()
		{
			throw null;
		}

		// Token: 0x0400F74C RID: 63308
		protected const string _birdsLayer = "Water";

		// Token: 0x0400F74D RID: 63309
		protected Bird _bird;

		// Token: 0x0400F74E RID: 63310
		protected int _layersMask;

		// Token: 0x0400F74F RID: 63311
		protected SphereCollider _collider;

		// Token: 0x0400F750 RID: 63312
		protected Vector3 _cohesion;

		// Token: 0x0400F751 RID: 63313
		protected Vector3 _separation;

		// Token: 0x0400F752 RID: 63314
		protected Vector3 _alignment;

		// Token: 0x0400F753 RID: 63315
		[HideInInspector]
		public Vector3 Velocity;

		// Token: 0x0400F754 RID: 63316
		[HideInInspector]
		public Transform TransformCache;

		// Token: 0x0400F755 RID: 63317
		protected BirdBoidsSpawner _swarmBrain;
	}
}
