using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200107E RID: 4222
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		// Token: 0x0600582F RID: 22575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Vector3 GetPivotPoint()
		{
			throw null;
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06005831 RID: 22577 RVA: 0x00002050 File Offset: 0x00000250
		public override bool animationGrounded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAnimatorMove()
		{
			throw null;
		}

		// Token: 0x040063BB RID: 25531
		public CharacterThirdPerson characterController;

		// Token: 0x040063BC RID: 25532
		[SerializeField]
		private float turnSensitivity;

		// Token: 0x040063BD RID: 25533
		[SerializeField]
		private float turnSpeed;

		// Token: 0x040063BE RID: 25534
		[SerializeField]
		private float runCycleLegOffset;

		// Token: 0x040063BF RID: 25535
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		// Token: 0x040063C0 RID: 25536
		protected Animator animator;

		// Token: 0x040063C1 RID: 25537
		private Vector3 vector3_2;

		// Token: 0x040063C2 RID: 25538
		private const string string_0 = "Grounded Directional";

		// Token: 0x040063C3 RID: 25539
		private const string string_1 = "Grounded Strafe";
	}
}
