using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010CF RID: 4303
	[Serializable]
	public class InteractionEffector
	{
		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x00002050 File Offset: 0x00000250
		public bool isPaused
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AB2 RID: 23218 RVA: 0x00002050 File Offset: 0x00000250
		public InteractionObject interactionObject
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x00002050 File Offset: 0x00000250
		public bool inInteraction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(InteractionSystem interactionSystem)
		{
			throw null;
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ResetToDefaults(float speed)
		{
			throw null;
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Pause()
		{
			throw null;
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Resume()
		{
			throw null;
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			throw null;
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(Transform root, float speed)
		{
			throw null;
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06005ABB RID: 23227 RVA: 0x00002050 File Offset: 0x00000250
		public float progress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool checkTime, out bool pickUp, out bool pause)
		{
			throw null;
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Transform root)
		{
			throw null;
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Stop()
		{
			throw null;
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPostFBBIK()
		{
			throw null;
		}

		// Token: 0x0400662D RID: 26157
		private Poser poser;

		// Token: 0x0400662E RID: 26158
		private IKEffector effector;

		// Token: 0x0400662F RID: 26159
		private float timer;

		// Token: 0x04006630 RID: 26160
		private float length;

		// Token: 0x04006631 RID: 26161
		private float weight;

		// Token: 0x04006632 RID: 26162
		private float fadeInSpeed;

		// Token: 0x04006633 RID: 26163
		private float defaultPositionWeight;

		// Token: 0x04006634 RID: 26164
		private float defaultRotationWeight;

		// Token: 0x04006635 RID: 26165
		private float defaultPull;

		// Token: 0x04006636 RID: 26166
		private float defaultReach;

		// Token: 0x04006637 RID: 26167
		private float defaultPush;

		// Token: 0x04006638 RID: 26168
		private float defaultPushParent;

		// Token: 0x04006639 RID: 26169
		private float resetTimer;

		// Token: 0x0400663A RID: 26170
		private bool positionWeightUsed;

		// Token: 0x0400663B RID: 26171
		private bool rotationWeightUsed;

		// Token: 0x0400663C RID: 26172
		private bool pullUsed;

		// Token: 0x0400663D RID: 26173
		private bool reachUsed;

		// Token: 0x0400663E RID: 26174
		private bool pushUsed;

		// Token: 0x0400663F RID: 26175
		private bool pushParentUsed;

		// Token: 0x04006640 RID: 26176
		private bool pickedUp;

		// Token: 0x04006641 RID: 26177
		private bool defaults;

		// Token: 0x04006642 RID: 26178
		private bool pickUpOnPostFBBIK;

		// Token: 0x04006643 RID: 26179
		private Vector3 pickUpPosition;

		// Token: 0x04006644 RID: 26180
		private Vector3 pausePositionRelative;

		// Token: 0x04006645 RID: 26181
		private Quaternion pickUpRotation;

		// Token: 0x04006646 RID: 26182
		private Quaternion pauseRotationRelative;

		// Token: 0x04006647 RID: 26183
		private InteractionTarget interactionTarget;

		// Token: 0x04006648 RID: 26184
		private Transform target;

		// Token: 0x04006649 RID: 26185
		private List<bool> triggered;

		// Token: 0x0400664A RID: 26186
		private InteractionSystem interactionSystem;

		// Token: 0x0400664B RID: 26187
		private bool started;
	}
}
