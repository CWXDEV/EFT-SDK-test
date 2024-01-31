using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.PrefabSettings;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200156A RID: 5482
	public class FlareCartridge : Throwable
	{
		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x00002050 File Offset: 0x00000250
		private static PhysicMaterial PhysicMaterial_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06007570 RID: 30064 RVA: 0x00002050 File Offset: 0x00000250
		public override int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06007571 RID: 30065 RVA: 0x00002050 File Offset: 0x00000250
		public override bool HasNetData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(FlareCartridgeSettings flareCartridgeSettings, IPlayer player, BulletClass flareCartridge, Weapon weapon)
		{
			throw null;
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_2()
		{
			throw null;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(Collider other, out bool contactWithOwnerPlayer)
		{
			throw null;
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(BodyPartCollider bodyPart, IPlayer player, RaycastHit hit)
		{
			throw null;
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_5(BodyPartCollider bodyPart, RaycastHit hit)
		{
			throw null;
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(Collision collision)
		{
			throw null;
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Launch()
		{
			throw null;
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCollisionEnter(Collision collision)
		{
			throw null;
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCollisionHandler()
		{
			throw null;
		}

		// Token: 0x04007B85 RID: 31621
		private const float float_3 = 3f;

		// Token: 0x04007B86 RID: 31622
		private const float float_4 = 10f;

		// Token: 0x04007B87 RID: 31623
		private readonly Vector3 vector3_0;

		// Token: 0x04007B88 RID: 31624
		private static PhysicMaterial physicMaterial_0;

		// Token: 0x04007B89 RID: 31625
		private FlareColorType flareColorType_0;

		// Token: 0x04007B8A RID: 31626
		private FlareCartridgeSettings flareCartridgeSettings_0;

		// Token: 0x04007B8B RID: 31627
		private GameObject gameObject_0;

		// Token: 0x04007B8C RID: 31628
		private IPlayer iplayer_0;

		// Token: 0x04007B8D RID: 31629
		private BulletClass gclass2732_0;

		// Token: 0x04007B8E RID: 31630
		private Weapon weapon_0;

		// Token: 0x04007B8F RID: 31631
		private CapsuleCollider capsuleCollider_0;

		// Token: 0x04007B90 RID: 31632
		private SphereCollider sphereCollider_0;

		// Token: 0x04007B91 RID: 31633
		private bool bool_2;

		// Token: 0x04007B92 RID: 31634
		private bool bool_3;

		// Token: 0x04007B93 RID: 31635
		private bool bool_4;

		// Token: 0x04007B94 RID: 31636
		private float float_5;

		// Token: 0x04007B95 RID: 31637
		private Vector3 vector3_1;

		// Token: 0x04007B96 RID: 31638
		private GameObject gameObject_1;

		// Token: 0x04007B97 RID: 31639
		private float float_6;

		// Token: 0x04007B98 RID: 31640
		private float float_7;

		// Token: 0x04007B99 RID: 31641
		private bool bool_5;

		// Token: 0x04007B9A RID: 31642
		private bool bool_6;

		// Token: 0x04007B9B RID: 31643
		private const float float_8 = 0.2f;

		// Token: 0x04007B9C RID: 31644
		private const float float_9 = 0.5f;
	}
}
