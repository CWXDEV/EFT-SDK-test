using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace AnimationEventSystem
{
	// Token: 0x0200102D RID: 4141
	[CreateAssetMenu]
	public class AnimatorControllerStaticData : ScriptableObject
	{
		// Token: 0x0600566B RID: 22123 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<AnimationEvent> GetEventsByIndex(int index)
		{
			throw null;
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LActionSetup GetLActionSetupById(int lActionSetupId)
		{
			throw null;
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValidListIndex(int index)
		{
			throw null;
		}

		// Token: 0x04006292 RID: 25234
		[SerializeField]
		private List<EventsCollection> _stateHashToEventsCollection;

		// Token: 0x04006293 RID: 25235
		[SerializeField]
		private List<LActionSetup> _stateHashToLActionSetups;
	}
}
