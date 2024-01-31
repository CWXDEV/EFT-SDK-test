using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027F2 RID: 10226
	public sealed class BrokenWindowPieceCollider : MonoBehaviour, IPhysicsTrigger, IPhysicsTriggerWithStay
	{
		// Token: 0x140002DA RID: 730
		// (add) Token: 0x0600CCBA RID: 52410 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600CCBB RID: 52411 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Vector3, Vector3> OnPlayerCollision
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

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x0600CCBC RID: 52412 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CCBD RID: 52413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerStay(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CCBE RID: 52414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnsubscibeAction()
		{
			throw null;
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600CCC1 RID: 52417 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CCC2 RID: 52418 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0400CD07 RID: 52487
		[CompilerGenerated]
		private Action<Vector3, Vector3> action_0;

		// Token: 0x0400CD08 RID: 52488
		public BoxCollider Collider;

		// Token: 0x0400CD09 RID: 52489
		private float float_0;
	}
}
