using System;
using System.Runtime.CompilerServices;
using AnimationSystem.RootMotionTable;
using UnityEngine;

namespace FastAnimatorSystem.TestAnimatorEnvironment
{
	// Token: 0x02000F62 RID: 3938
	public class TestAnimatorSkeleton : MonoBehaviour
	{
		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator Animator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060052DE RID: 21214 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060052DF RID: 21215 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LastDelta
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

		// Token: 0x060052E0 RID: 21216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process(float dt)
		{
			throw null;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string val)
		{
			throw null;
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimatorStateInfoWrapper GetCurrentState()
		{
			throw null;
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimatorStateInfoWrapper GetNextState()
		{
			throw null;
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetDeltaPosition()
		{
			throw null;
		}

		// Token: 0x04005E76 RID: 24182
		public Animator animator;

		// Token: 0x04005E77 RID: 24183
		public RuntimeAnimatorController originalAnimatorController;

		// Token: 0x04005E78 RID: 24184
		public TextAsset fastAnimatorJson;

		// Token: 0x04005E79 RID: 24185
		public RootMotionBlendTable blendTable;

		// Token: 0x04005E7A RID: 24186
		public CharacterClipsKeeper clipsKeeper;

		// Token: 0x04005E7B RID: 24187
		public Camera cam;

		// Token: 0x04005E7C RID: 24188
		public PlayableAnimator playableAnimator;

		// Token: 0x04005E7D RID: 24189
		public bool useFastAnimator;

		// Token: 0x04005E7E RID: 24190
		public bool usePlayableWithFast;

		// Token: 0x04005E7F RID: 24191
		public float speedMult;

		// Token: 0x04005E80 RID: 24192
		public Vector3 rotateAroundVec;

		// Token: 0x04005E81 RID: 24193
		public bool applyDeltaPosition;

		// Token: 0x04005E82 RID: 24194
		public bool isVisible;

		// Token: 0x04005E83 RID: 24195
		private Vector3 vector3_0;

		// Token: 0x04005E84 RID: 24196
		private IAnimator ianimator_0;

		// Token: 0x04005E85 RID: 24197
		private int int_0;
	}
}
