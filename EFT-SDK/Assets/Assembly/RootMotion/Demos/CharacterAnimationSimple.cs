using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200107D RID: 4221
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		// Token: 0x0600582C RID: 22572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Vector3 GetPivotPoint()
		{
			throw null;
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x040063B7 RID: 25527
		[SerializeField]
		private CharacterThirdPerson characterController;

		// Token: 0x040063B8 RID: 25528
		[SerializeField]
		private float pivotOffset;

		// Token: 0x040063B9 RID: 25529
		[SerializeField]
		private AnimationCurve moveSpeed;

		// Token: 0x040063BA RID: 25530
		private Animator animator_0;
	}
}
