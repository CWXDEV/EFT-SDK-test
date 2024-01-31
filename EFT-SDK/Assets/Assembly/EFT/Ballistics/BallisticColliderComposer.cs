using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Ballistics
{
	// Token: 0x0200280A RID: 10250
	public class BallisticColliderComposer : BallisticCollider
	{
		// Token: 0x0600CD1C RID: 52508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubscribeHitAction(Action<DamageInfo> onHitAction)
		{
			throw null;
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UnsubscribeHitAction()
		{
			throw null;
		}

		// Token: 0x0400CD56 RID: 52566
		[SerializeField]
		private BallisticCollider[] _ballisticColliders;
	}
}
