using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200107C RID: 4220
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		// Token: 0x06005827 RID: 22567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Vector3 GetPivotPoint()
		{
			throw null;
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool animationGrounded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			throw null;
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x040063B1 RID: 25521
		public bool smoothFollow;

		// Token: 0x040063B2 RID: 25522
		public float smoothFollowSpeed;

		// Token: 0x040063B3 RID: 25523
		private Vector3 vector3_0;

		// Token: 0x040063B4 RID: 25524
		private Vector3 vector3_1;

		// Token: 0x040063B5 RID: 25525
		private Quaternion quaternion_0;

		// Token: 0x040063B6 RID: 25526
		private Quaternion quaternion_1;
	}
}
