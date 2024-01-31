using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200156B RID: 5483
	public class Grenade : Throwable
	{
		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06007580 RID: 30080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007581 RID: 30081 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface94 Player
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06007582 RID: 30082 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007583 RID: 30083 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06007584 RID: 30084 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007585 RID: 30085 RVA: 0x00002050 File Offset: 0x00000250
		public GrenadeClass WeaponSource
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x00002050 File Offset: 0x00000250
		public GrenadeSettings GrenadeSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Offset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x00002050 File Offset: 0x00000250
		public override int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06007589 RID: 30089 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual float PhysicsQuality
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x00002050 File Offset: 0x00000250
		protected static float PhysicsQualityForObserved
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual GClass735 GetVisibilityChecker()
		{
			throw null;
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCollisionEnter(Collision collision)
		{
			throw null;
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessContactExplodeCollision(float impulse)
		{
			throw null;
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCollisionHandler()
		{
			throw null;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(Collision collision)
		{
			throw null;
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static GClass735 GetVisibilityCheckerForObserved(Grenade grenade)
		{
			throw null;
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetThrowForce(Vector3 force)
		{
			throw null;
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(GrenadeSettings settings, IPlayer player, GrenadeClass throwWeap, float timeSpent, GInterface355 calculator)
		{
			throw null;
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void StartTimer()
		{
			throw null;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void StopTimer()
		{
			throw null;
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InvokeBlowUpEvent()
		{
			throw null;
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnExplosion()
		{
			throw null;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Attach(Transform t)
		{
			throw null;
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Explosion(Grenade grenade, IExplosiveItem grenadeItem, Vector3 grenadePosition, string playerProfileIDWhoThrew, GInterface355 grenadeBallisticsCalculator, Item originalWeaponItem, Vector3 shift)
		{
			throw null;
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DamageInfo smethod_0(Item originalItemWeapon, string playerWhoThrew, Vector3 explosionPosition)
		{
			throw null;
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x00002050 File Offset: 0x00000250
		public override bool HasNetData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04007B9D RID: 31645
		public const float SHIFT_DISTANCE = 0.08f;

		// Token: 0x04007B9E RID: 31646
		private const int int_2 = 300;

		// Token: 0x04007B9F RID: 31647
		private static readonly Vector3 vector3_0;

		// Token: 0x04007BA0 RID: 31648
		public GInterface355 Calculator;

		// Token: 0x04007BA1 RID: 31649
		[CompilerGenerated]
		private GInterface94 ginterface94_0;

		// Token: 0x04007BA2 RID: 31650
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04007BA3 RID: 31651
		[CompilerGenerated]
		private GrenadeClass gclass2735_0;

		// Token: 0x04007BA4 RID: 31652
		public static GClass2979 GrenadeRandoms;

		// Token: 0x04007BA5 RID: 31653
		protected GrenadeSettings _grenadeSettings;

		// Token: 0x04007BA6 RID: 31654
		private IEnumerator ienumerator_0;

		// Token: 0x04007BA7 RID: 31655
		private bool bool_2;

		// Token: 0x04007BA8 RID: 31656
		private float float_3;

		// Token: 0x04007BA9 RID: 31657
		private float float_4;

		// Token: 0x04007BAA RID: 31658
		private Collider collider_0;

		// Token: 0x04007BAB RID: 31659
		private Transform transform_0;

		// Token: 0x04007BAC RID: 31660
		private static int int_3;

		// Token: 0x04007BAD RID: 31661
		private SoundBank soundBank_0;

		// Token: 0x04007BAE RID: 31662
		private readonly Vector3 vector3_1;

		// Token: 0x04007BAF RID: 31663
		private const float float_5 = 0.2f;

		// Token: 0x04007BB0 RID: 31664
		private const float float_6 = 0.5f;

		// Token: 0x0200156C RID: 5484
		[CompilerGenerated]
		private sealed class Class1137
		{
			// Token: 0x0600759F RID: 30111 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DamageInfo method_0()
			{
				throw null;
			}

			// Token: 0x04007BB1 RID: 31665
			public Item originalWeaponItem;

			// Token: 0x04007BB2 RID: 31666
			public string playerProfileIDWhoThrew;

			// Token: 0x04007BB3 RID: 31667
			public Vector3 grenadePosition;
		}
	}
}
