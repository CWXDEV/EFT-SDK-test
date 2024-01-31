using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace AnimationEventSystem
{
	// Token: 0x0200101E RID: 4126
	[Serializable]
	public class AnimationEventsContainer : ICloneable
	{
		// Token: 0x0600563C RID: 22076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ResetCache()
		{
			throw null;
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEventsConsumer([NotNull] GInterface84 consumer)
		{
			throw null;
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnsetEventsConsumer([NotNull] GInterface84 consumer)
		{
			throw null;
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStateEnter(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, List<AnimationEvent> animationEvents)
		{
			throw null;
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStateUpdate(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, List<AnimationEvent> animationEvents)
		{
			throw null;
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStateExit(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, List<AnimationEvent> animationEvents)
		{
			throw null;
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, AnimationEventsContainer.EUpdateType updateType, List<AnimationEvent> animationEvents)
		{
			throw null;
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1()
		{
			throw null;
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float previousNormalizedTime, float normalizedTime, List<AnimationEvent> animationEvents)
		{
			throw null;
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(AnimationEvent @event, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime)
		{
			throw null;
		}

		// Token: 0x04006262 RID: 25186
		private const float ALMOST_ONE = 0.99999f;

		// Token: 0x04006263 RID: 25187
		private const float A_BIT_GREATER_THAN_ONE = 1.00001f;

		// Token: 0x04006264 RID: 25188
		private const float MIN_DIFF = 1E-05f;

		// Token: 0x04006265 RID: 25189
		private static readonly AnimationEventsContainer.Class337 Logger;

		// Token: 0x04006266 RID: 25190
		private bool _previousLoop;

		// Token: 0x04006267 RID: 25191
		private float _previousNormalizedTime;

		// Token: 0x04006268 RID: 25192
		private IAnimator _previousAnimator;

		// Token: 0x04006269 RID: 25193
		private GInterface84 _eventsConsumer;

		// Token: 0x0400626A RID: 25194
		private bool _hasEventsAndConsumerCache;

		// Token: 0x0200101F RID: 4127
		private class Class337 : LoggerClass
		{
			// Token: 0x06005647 RID: 22087 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LogEventsCheck(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, AnimationEventsContainer.EUpdateType updateType, float previousNormalizedTime)
			{
				throw null;
			}

			// Token: 0x06005648 RID: 22088 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_3(in AnimatorStateInfoWrapper stateInfo, AnimationEventsContainer.EUpdateType updateType)
			{
				throw null;
			}

			// Token: 0x06005649 RID: 22089 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void DebugAnimatorsSwitch(IAnimator previousAnimator, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, AnimationEventsContainer.EUpdateType updateType)
			{
				throw null;
			}

			// Token: 0x0600564A RID: 22090 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LogEventTimeCheck(AnimationEvent animationEvent, float previousNormalizedTime, float normalizedTime)
			{
				throw null;
			}

			// Token: 0x0400626B RID: 25195
			private AnimationEventsContainer.Class337.Struct171 struct171_0;

			// Token: 0x02001020 RID: 4128
			[StructLayout(LayoutKind.Auto)]
			public struct Struct171
			{
				// Token: 0x0400626C RID: 25196
				public int stateHash;

				// Token: 0x0400626D RID: 25197
				public AnimationEventsContainer.EUpdateType UpdateType;
			}
		}

		// Token: 0x02001021 RID: 4129
		public enum EUpdateType
		{
			// Token: 0x0400626F RID: 25199
			OnEnter,
			// Token: 0x04006270 RID: 25200
			OnUpdate,
			// Token: 0x04006271 RID: 25201
			OnExit
		}
	}
}
