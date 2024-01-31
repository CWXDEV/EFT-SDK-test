using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027CE RID: 10190
	public class ObstacleCollider : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600CC41 RID: 52289 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600CC42 RID: 52290 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasSwampSpeedLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600CC43 RID: 52291 RVA: 0x00002050 File Offset: 0x00000250
		public EPhysicalCondition ConditionsMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CC45 RID: 52293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BreakInToPieces()
		{
			throw null;
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600CC47 RID: 52295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CC48 RID: 52296 RVA: 0x00002050 File Offset: 0x00000250
		bool IPhysicsTrigger.enabled
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

		// Token: 0x0400CC4F RID: 52303
		[SerializeField]
		[Tooltip("Запрещено ложиться")]
		private bool _disablesProne;

		// Token: 0x0400CC50 RID: 52304
		[Tooltip("Запрещено ползать")]
		[SerializeField]
		private bool _disablesProneMove;

		// Token: 0x0400CC51 RID: 52305
		[Tooltip("Запрещено прыгать")]
		[SerializeField]
		private bool _disablesJump;

		// Token: 0x0400CC52 RID: 52306
		[Tooltip("Запрещено спринтовать")]
		[SerializeField]
		private bool _disablesSprint;

		// Token: 0x0400CC53 RID: 52307
		[Tooltip("Ограничение скорости (болото)")]
		[SerializeField]
		private bool _hasSwampSpeedLimit;

		// Token: 0x020027CF RID: 10191
		[CompilerGenerated]
		private sealed class Class2305
		{
			// Token: 0x0600CC49 RID: 52297 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RaycastHit c)
			{
				throw null;
			}

			// Token: 0x0400CC54 RID: 52308
			public Collider parentCollider;
		}
	}
}
