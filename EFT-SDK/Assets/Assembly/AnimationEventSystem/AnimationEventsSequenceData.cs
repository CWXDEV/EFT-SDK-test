using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AnimationEventSystem
{
	// Token: 0x02001027 RID: 4135
	public class AnimationEventsSequenceData
	{
		// Token: 0x0600565B RID: 22107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAnimationEventToDebugQueue(string eventName, int stateShortNameHash, bool conditionPassed)
		{
			throw null;
		}

		// Token: 0x04006283 RID: 25219
		private const int MAX_QUEUE_SIZE = 15;

		// Token: 0x04006284 RID: 25220
		public readonly Queue<AnimationEventsSequenceData.GStruct107> AnimationEventsDebugQueue;

		// Token: 0x02001028 RID: 4136
		[StructLayout(LayoutKind.Auto)]
		public readonly struct GStruct107
		{
			// Token: 0x04006285 RID: 25221
			public readonly string EventName;

			// Token: 0x04006286 RID: 25222
			public readonly int StateNameShortHash;

			// Token: 0x04006287 RID: 25223
			public readonly bool ConditionPassed;
		}
	}
}
