using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001550 RID: 5456
	public class KnifeCollider : MonoBehaviour
	{
		// Token: 0x060074F4 RID: 29940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFire()
		{
			throw null;
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFireEnd()
		{
			throw null;
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBotParameters(Vector3 colliderScaleMultiplier)
		{
			throw null;
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate()
		{
			throw null;
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Collider hitCollider)
		{
			throw null;
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector3 startPoint, Vector3 direction, Vector3 castSize)
		{
			throw null;
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(PlayerSpirit victimSpirit)
		{
			throw null;
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Vector3 startPoint, Vector3 direction, Player victimPlayer, Vector3 castSize)
		{
			throw null;
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PlayerSpirit method_6(Vector3 startPoint, Vector3 direction, Vector3 castSize)
		{
			throw null;
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_7(Vector3 startPoint, Vector3 direction, float maxDistance)
		{
			throw null;
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_8(Vector3 startPoint, Vector3 direction, int mask, Collider[] colliders, Vector3 castSize)
		{
			throw null;
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_9(Collider x)
		{
			throw null;
		}

		// Token: 0x04007B26 RID: 31526
		public BoxCollider Collider;

		// Token: 0x04007B27 RID: 31527
		public Vector3 CastDirection;

		// Token: 0x04007B28 RID: 31528
		public RaycastHit[] hits;

		// Token: 0x04007B29 RID: 31529
		public Action<Player.GStruct134> OnHit;

		// Token: 0x04007B2A RID: 31530
		public float MaxDistance;

		// Token: 0x04007B2B RID: 31531
		internal Player.BaseKnifeController baseKnifeController_0;

		// Token: 0x04007B2C RID: 31532
		internal Player player_0;

		// Token: 0x04007B2D RID: 31533
		public int _hitMask;

		// Token: 0x04007B2E RID: 31534
		public int _spiritMask;

		// Token: 0x04007B2F RID: 31535
		private Collider[] collider_0;

		// Token: 0x04007B30 RID: 31536
		private bool bool_0;

		// Token: 0x04007B31 RID: 31537
		private Vector3 vector3_0;

		// Token: 0x04007B32 RID: 31538
		private Vector3 vector3_1;

		// Token: 0x04007B33 RID: 31539
		private Quaternion quaternion_0;

		// Token: 0x04007B34 RID: 31540
		private HashSet<Player> hashSet_0;

		// Token: 0x04007B35 RID: 31541
		private Vector3 vector3_2;

		// Token: 0x04007B36 RID: 31542
		public Func<Vector3> GetPlayerOrientation;

		// Token: 0x04007B37 RID: 31543
		public Func<PlayerBones> GetPlayerBones;

		// Token: 0x04007B38 RID: 31544
		[SerializeField]
		[Header("Server setting")]
		private float _weaponRootExtension;

		// Token: 0x02001551 RID: 5457
		[CompilerGenerated]
		private sealed class Class1127
		{
			// Token: 0x06007504 RID: 29956 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BodyPartCollider c)
			{
				throw null;
			}

			// Token: 0x04007B39 RID: 31545
			public Collider x;
		}
	}
}
