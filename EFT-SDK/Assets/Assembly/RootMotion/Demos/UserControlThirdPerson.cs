using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02001086 RID: 4230
	public class UserControlThirdPerson : MonoBehaviour
	{
		// Token: 0x06005857 RID: 22615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0400641B RID: 25627
		public bool walkByDefault;

		// Token: 0x0400641C RID: 25628
		public bool canCrouch;

		// Token: 0x0400641D RID: 25629
		public bool canJump;

		// Token: 0x0400641E RID: 25630
		public UserControlThirdPerson.GStruct111 state;

		// Token: 0x0400641F RID: 25631
		protected Transform cam;

		// Token: 0x02001087 RID: 4231
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct111
		{
			// Token: 0x04006420 RID: 25632
			public Vector3 move;

			// Token: 0x04006421 RID: 25633
			public Vector3 lookPos;

			// Token: 0x04006422 RID: 25634
			public bool crouch;

			// Token: 0x04006423 RID: 25635
			public bool jump;
		}
	}
}
