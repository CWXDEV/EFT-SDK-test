using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002658 RID: 9816
	public class NPCGlobalEventsReacting : MonoBehaviour
	{
		// Token: 0x140002C2 RID: 706
		// (add) Token: 0x0600C2B0 RID: 49840 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C2B1 RID: 49841 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, ReactionOnEvent> OnNeedReactOnEvent
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

		// Token: 0x0600C2B2 RID: 49842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C2B3 RID: 49843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BaseEventFilter filter, GClass2885 passedEvent)
		{
			throw null;
		}

		// Token: 0x0400C475 RID: 50293
		[SerializeField]
		private List<EventFilterAnimationRelation> eventsFilters;

		// Token: 0x0400C476 RID: 50294
		private Dictionary<BaseEventFilter, ReactionOnEvent> dictionary_0;

		// Token: 0x0400C477 RID: 50295
		[CompilerGenerated]
		private Action<int, ReactionOnEvent> action_0;

		// Token: 0x02002659 RID: 9817
		[Serializable]
		public class AnimationInt
		{
			// Token: 0x0600C2B5 RID: 49845 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetValue()
			{
				throw null;
			}

			// Token: 0x0400C478 RID: 50296
			public string paramName;

			// Token: 0x0400C479 RID: 50297
			public bool randomizeValue;

			// Token: 0x0400C47A RID: 50298
			public int paramValue;

			// Token: 0x0400C47B RID: 50299
			public int minValue;

			// Token: 0x0400C47C RID: 50300
			public int maxValue;
		}
	}
}
