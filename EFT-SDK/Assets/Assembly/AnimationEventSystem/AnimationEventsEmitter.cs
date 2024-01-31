using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AnimationEventSystem
{
	// Token: 0x02001023 RID: 4131
	public class AnimationEventsEmitter : IDisposable, GInterface84
	{
		// Token: 0x140000F5 RID: 245
		// (add) Token: 0x0600564C RID: 22092 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600564D RID: 22093 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, AnimationEventParameter> OnEventAction
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

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x0600564E RID: 22094 RVA: 0x00002050 File Offset: 0x00000250
		public AnimationEventsSequenceData EventsSequenceData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimator(IAnimator animator, AnimationEventsEmitter.EEmitType emitType, string distinctId = "undefined", bool force = false)
		{
			throw null;
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveBindedAnimator()
		{
			throw null;
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface84.ReceiveEvent(AnimationEvent animationEvent, IAnimator animator, in AnimatorStateInfoWrapper animatorStateInfo, float normalizedTime)
		{
			throw null;
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(string functionName, int functionNameHash, AnimationEventParameter parameter, int stateShortNameHash)
		{
			throw null;
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EmitEvents()
		{
			throw null;
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(AnimationEvent @event, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime)
		{
			throw null;
		}

		// Token: 0x04006272 RID: 25202
		private AnimationEventsEmitter.GClass618 _logger;

		// Token: 0x04006273 RID: 25203
		private IAnimator _animator;

		// Token: 0x04006275 RID: 25205
		private AnimationEventsEmitter.EEmitType _emitType;

		// Token: 0x04006276 RID: 25206
		private readonly Queue<AnimationEventsEmitter.Struct172> _delayedEvents;

		// Token: 0x04006277 RID: 25207
		private GInterface85[] _animationEventsStateBehaviours;

		// Token: 0x04006278 RID: 25208
		private AnimationEventsSequenceData _eventsSequenceData;

		// Token: 0x02001024 RID: 4132
		public class GClass618 : LoggerClass
		{
			// Token: 0x06005658 RID: 22104 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WarnNoHandler(string functionName)
			{
				throw null;
			}

			// Token: 0x06005659 RID: 22105 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void TraceEventTestPassed(AnimationEvent e, bool conditionsPassed, float normalizedTime, IAnimator animator, in AnimatorStateInfoWrapper stateInfo)
			{
				throw null;
			}

			// Token: 0x0600565A RID: 22106 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void EventPuttedToDelayedEventsQueue(AnimationEvent e, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime)
			{
				throw null;
			}

			// Token: 0x04006279 RID: 25209
			private readonly AnimationEventsEmitter animationEventsEmitter_0;

			// Token: 0x0400627A RID: 25210
			private readonly string string_0;

			// Token: 0x0400627B RID: 25211
			private readonly string string_1;
		}

		// Token: 0x02001025 RID: 4133
		public enum EEmitType
		{
			// Token: 0x0400627D RID: 25213
			EmitOnAnimatorUpdate,
			// Token: 0x0400627E RID: 25214
			EmitOnDemand
		}

		// Token: 0x02001026 RID: 4134
		[StructLayout(LayoutKind.Auto)]
		public struct Struct172
		{
			// Token: 0x0400627F RID: 25215
			public readonly IAnimator Animator;

			// Token: 0x04006280 RID: 25216
			public readonly float NormalizedTime;

			// Token: 0x04006281 RID: 25217
			public readonly AnimationEvent AnimationEvent;

			// Token: 0x04006282 RID: 25218
			public readonly AnimatorStateInfoWrapper StateInfo;
		}
	}
}
