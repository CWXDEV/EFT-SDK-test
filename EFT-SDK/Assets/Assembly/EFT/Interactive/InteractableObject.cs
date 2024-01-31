using System;
using System.Runtime.CompilerServices;
using EFT.AssetsManager;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002763 RID: 10083
	public abstract class InteractableObject : PoolSafeMonoBehaviour, GInterface12, GInterface102
	{
		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600C9F8 RID: 51704 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Transform TrackableTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetStateUpdateTime()
		{
			throw null;
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600C9FA RID: 51706 RVA: 0x00002050 File Offset: 0x00000250
		public float StateUpdateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600C9FB RID: 51707 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 WorldInteractionDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C9FC RID: 51708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool InteractsFromAppropriateDirection(Vector3 playerForward)
		{
			throw null;
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Kill()
		{
			throw null;
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0400C9E0 RID: 51680
		public ESpecificInteractionContext specificInteractionContext;

		// Token: 0x0400C9E1 RID: 51681
		private float _stateUpdateTime;

		// Token: 0x0400C9E2 RID: 51682
		public float InteractionDot;

		// Token: 0x0400C9E3 RID: 51683
		public Vector3 InteractionDirection;

		// Token: 0x0400C9E4 RID: 51684
		private BetterSource _source;
	}
}
