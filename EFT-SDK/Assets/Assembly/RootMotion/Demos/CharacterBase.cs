using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200107F RID: 4223
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		// Token: 0x06005834 RID: 22580
		public abstract void Move(Vector3 deltaPosition);

		// Token: 0x06005835 RID: 22581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual RaycastHit GetSpherecastHit()
		{
			throw null;
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			throw null;
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
			throw null;
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ScaleCapsule(float mlp)
		{
			throw null;
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void HighFriction()
		{
			throw null;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ZeroFriction()
		{
			throw null;
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			throw null;
		}

		// Token: 0x040063C4 RID: 25540
		[SerializeField]
		[Header("Base Parameters")]
		[Range(1f, 4f)]
		protected float gravityMultiplier;

		// Token: 0x040063C5 RID: 25541
		[SerializeField]
		protected float airborneThreshold;

		// Token: 0x040063C6 RID: 25542
		[SerializeField]
		private float slopeStartAngle;

		// Token: 0x040063C7 RID: 25543
		[SerializeField]
		private float slopeEndAngle;

		// Token: 0x040063C8 RID: 25544
		[SerializeField]
		private float spherecastRadius;

		// Token: 0x040063C9 RID: 25545
		[SerializeField]
		private LayerMask groundLayers;

		// Token: 0x040063CA RID: 25546
		private PhysicMaterial physicMaterial_0;

		// Token: 0x040063CB RID: 25547
		private PhysicMaterial physicMaterial_1;

		// Token: 0x040063CC RID: 25548
		protected Rigidbody r;

		// Token: 0x040063CD RID: 25549
		protected const float half = 0.5f;

		// Token: 0x040063CE RID: 25550
		protected float originalHeight;

		// Token: 0x040063CF RID: 25551
		protected Vector3 originalCenter;

		// Token: 0x040063D0 RID: 25552
		protected CapsuleCollider capsule;
	}
}
