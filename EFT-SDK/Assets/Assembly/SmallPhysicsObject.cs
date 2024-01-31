using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Ballistics;
using UnityEngine;

// Token: 0x02000674 RID: 1652
public class SmallPhysicsObject : MonoBehaviour
{
	// Token: 0x060025D8 RID: 9688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x060025D9 RID: 9689 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060025DA RID: 9690 RVA: 0x00002050 File Offset: 0x00000250
	public byte CollisionNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdatePhysics()
	{
		throw null;
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3 force, Vector3 position, float forceMultiplier)
	{
		throw null;
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Vector3 force)
	{
		throw null;
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_3()
	{
		throw null;
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionEnter(Collision collision)
	{
		throw null;
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCollisionHandler(bool resetSound = false)
	{
		throw null;
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Transform t)
	{
		throw null;
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBlowUp(Vector3 grenadePosition)
	{
		throw null;
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetToDefaultPositions()
	{
		throw null;
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x040024E5 RID: 9445
	private const float float_0 = 0.5f;

	// Token: 0x040024E6 RID: 9446
	private const float float_1 = 0.3f;

	// Token: 0x040024E7 RID: 9447
	private const float float_2 = 0.2f;

	// Token: 0x040024E8 RID: 9448
	private const float float_3 = 0.5f;

	// Token: 0x040024E9 RID: 9449
	private static readonly Collider[] collider_0;

	// Token: 0x040024EA RID: 9450
	public SmallPhysicsObject.EPhysicsObjectType SoundType;

	// Token: 0x040024EB RID: 9451
	public List<BallisticCollider> BallisticColliders;

	// Token: 0x040024EC RID: 9452
	public List<Rigidbody> Rigidbodies;

	// Token: 0x040024ED RID: 9453
	public Collider Collider;

	// Token: 0x040024EE RID: 9454
	public GameObject SolidObject;

	// Token: 0x040024EF RID: 9455
	public GameObject FragmentedObject;

	// Token: 0x040024F0 RID: 9456
	public float TimeOfLife;

	// Token: 0x040024F1 RID: 9457
	public float OnHitForceMultiplier;

	// Token: 0x040024F2 RID: 9458
	public float OnTouchForceMultiplier;

	// Token: 0x040024F3 RID: 9459
	public float OnBlowUpForceMultiplier;

	// Token: 0x040024F4 RID: 9460
	public float BlowUpThreshold;

	// Token: 0x040024F5 RID: 9461
	public string ParticlesEffectName;

	// Token: 0x040024F6 RID: 9462
	public List<InitialPosition> InitialPositions;

	// Token: 0x040024F7 RID: 9463
	private byte byte_0;

	// Token: 0x040024F8 RID: 9464
	private float float_4;

	// Token: 0x040024F9 RID: 9465
	protected float IgnoreCollisionTrackingTimer;

	// Token: 0x040024FA RID: 9466
	private float float_5;

	// Token: 0x040024FB RID: 9467
	public Vector3 TestBlowPosition;

	// Token: 0x040024FC RID: 9468
	private Vector3 vector3_0;

	// Token: 0x040024FD RID: 9469
	private Coroutine coroutine_0;

	// Token: 0x040024FE RID: 9470
	private SoundBank soundBank_0;

	// Token: 0x040024FF RID: 9471
	private readonly Vector3 vector3_1;

	// Token: 0x02000675 RID: 1653
	public enum EPhysicsObjectType
	{
		// Token: 0x04002501 RID: 9473
		Books,
		// Token: 0x04002502 RID: 9474
		CardBoard,
		// Token: 0x04002503 RID: 9475
		CoolerBottle,
		// Token: 0x04002504 RID: 9476
		Cup,
		// Token: 0x04002505 RID: 9477
		GlassBottle,
		// Token: 0x04002506 RID: 9478
		HardPlastic,
		// Token: 0x04002507 RID: 9479
		MediumGeneric,
		// Token: 0x04002508 RID: 9480
		MetalCandlestick,
		// Token: 0x04002509 RID: 9481
		Monitor,
		// Token: 0x0400250A RID: 9482
		SmallBox,
		// Token: 0x0400250B RID: 9483
		SmallPaper,
		// Token: 0x0400250C RID: 9484
		SmallPlastic,
		// Token: 0x0400250D RID: 9485
		TincanEmpty
	}

	// Token: 0x02000676 RID: 1654
	[CompilerGenerated]
	[Serializable]
	private sealed class Class318
	{
		// Token: 0x060025EB RID: 9707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Rigidbody x)
		{
			throw null;
		}

		// Token: 0x0400250E RID: 9486
		public static readonly SmallPhysicsObject.Class318 class318_0;

		// Token: 0x0400250F RID: 9487
		public static Action<Rigidbody> action_0;
	}
}
