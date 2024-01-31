using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C08 RID: 7176
	public class HideoutTargetBallisticCollider : BallisticCollider
	{
		// Token: 0x140001C1 RID: 449
		// (add) Token: 0x06009694 RID: 38548 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009695 RID: 38549 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<TargetColliderType, int> OnHitTarget
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06009696 RID: 38550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass1673 ApplyHit(DamageInfo damageInfo, GStruct389 shotID)
		{
			throw null;
		}

		// Token: 0x06009697 RID: 38551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0(float distance)
		{
			throw null;
		}

		// Token: 0x06009699 RID: 38553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0600969A RID: 38554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawGizmosCircles(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawGizmosCircle(Vector3 pos, Vector3 normal, float radius, int numSegments)
		{
			throw null;
		}

		// Token: 0x04009D8B RID: 40331
		[SerializeField]
		[Space]
		private DecalSystem _decal;

		// Token: 0x04009D8C RID: 40332
		[SerializeField]
		[Space]
		private TargetColliderType _targetType;

		// Token: 0x04009D8D RID: 40333
		[SerializeField]
		private float[] _sizes;

		// Token: 0x04009D8E RID: 40334
		[SerializeField]
		[Space]
		private Vector3 _direction;

		// Token: 0x04009D8F RID: 40335
		private const float float_0 = 0.001f;

		// Token: 0x04009D90 RID: 40336
		public const int MISS_SHOT_TARGET = 2147483647;

		// Token: 0x04009D91 RID: 40337
		public const int PERFECT_SHOT_TARGET = 0;

		// Token: 0x04009D92 RID: 40338
		[CompilerGenerated]
		private Action<TargetColliderType, int> action_1;

		// Token: 0x04009D93 RID: 40339
		private List<int> list_0;
	}
}
