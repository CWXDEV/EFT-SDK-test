using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.AssetsManager;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002756 RID: 10070
public class RagdollClass
{
	// Token: 0x170023C3 RID: 9155
	// (get) Token: 0x0600C995 RID: 51605 RVA: 0x00002050 File Offset: 0x00000250
	public Rigidbody WeaponRigidbody
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C996 RID: 51606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600C997 RID: 51607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0()
	{
		throw null;
	}

	// Token: 0x0600C998 RID: 51608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceStopRigidBody()
	{
		throw null;
	}

	// Token: 0x0600C999 RID: 51609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WakeUp()
	{
		throw null;
	}

	// Token: 0x0600C99A RID: 51610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Rigidbody rigidbody)
	{
		throw null;
	}

	// Token: 0x0600C99B RID: 51611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600C99C RID: 51612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AttachWeapon(Rigidbody weaponRigidbody, GameObject playerGameObject, PlayerBones playerBones, TransformLinks links, bool fixedHinge, Vector3 velocity)
	{
		throw null;
	}

	// Token: 0x0600C99D RID: 51613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Joint method_3(GameObject body, Rigidbody connectedBody)
	{
		throw null;
	}

	// Token: 0x0600C99E RID: 51614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Joint method_4(GameObject body, Rigidbody connectedBody, Vector3 p1, Vector3 p2)
	{
		throw null;
	}

	// Token: 0x0600C99F RID: 51615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600C9A0 RID: 51616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearWeapon()
	{
		throw null;
	}

	// Token: 0x0600C9A1 RID: 51617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(Collider collider, out RigidbodySpawner rigidbodySpawner)
	{
		throw null;
	}

	// Token: 0x0600C9A2 RID: 51618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyImpulse(Collider collider, Vector3 direction, Vector3 point, float thrust)
	{
		throw null;
	}

	// Token: 0x0600C9A3 RID: 51619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x0600C9A4 RID: 51620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(Rigidbody rigidbody, Vector3 direction, Vector3 point, float thrust)
	{
		throw null;
	}

	// Token: 0x0400C99B RID: 51611
	private RigidbodySpawner[] rigidbodySpawner_0;

	// Token: 0x0400C99C RID: 51612
	private CharacterJointSpawner[] characterJointSpawner_0;

	// Token: 0x0400C99D RID: 51613
	private List<PlayerRigidbodySleepHierarchy> list_0;

	// Token: 0x0400C99E RID: 51614
	private Vector3 vector3_0;

	// Token: 0x0400C99F RID: 51615
	private CollisionDetectionMode collisionDetectionMode_0;

	// Token: 0x0400C9A0 RID: 51616
	private MonoBehaviour monoBehaviour_0;

	// Token: 0x0400C9A1 RID: 51617
	private Func<bool, float, bool> func_0;

	// Token: 0x0400C9A2 RID: 51618
	private Action action_0;

	// Token: 0x0400C9A3 RID: 51619
	private bool bool_0;

	// Token: 0x0400C9A4 RID: 51620
	private bool bool_1;

	// Token: 0x0400C9A5 RID: 51621
	private float float_0;

	// Token: 0x0400C9A6 RID: 51622
	private bool bool_2;

	// Token: 0x0400C9A7 RID: 51623
	[CanBeNull]
	private Func<bool> func_1;

	// Token: 0x0400C9A8 RID: 51624
	private Rigidbody rigidbody_0;

	// Token: 0x0400C9A9 RID: 51625
	private Joint joint_0;

	// Token: 0x0400C9AA RID: 51626
	private bool bool_3;

	// Token: 0x0400C9AB RID: 51627
	private RigidbodySpawner rigidbodySpawner_1;

	// Token: 0x0400C9AC RID: 51628
	private Vector3 vector3_1;

	// Token: 0x0400C9AD RID: 51629
	private Vector3 vector3_2;

	// Token: 0x0400C9AE RID: 51630
	private float float_1;

	// Token: 0x0400C9AF RID: 51631
	private PlayerBody playerBody_0;
}
