using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cutscene;
using EFT.GlobalEvents;
using UnityEngine;

namespace EFT.NPC
{
	// Token: 0x02001C8B RID: 7307
	public class NPCReactionController : MonoBehaviour
	{
		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x060098BC RID: 39100 RVA: 0x00002050 File Offset: 0x00000250
		public Animator TestAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddReactionInQueue(int eventID, ReactionOnEvent eventReaction)
		{
			throw null;
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(int objectID, bool visible)
		{
			throw null;
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_5()
		{
			throw null;
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TestChangeIdleAnimationNumber()
		{
			throw null;
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(string clipName)
		{
			throw null;
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x04009FF0 RID: 40944
		[SerializeField]
		private Animator _npcAnimator;

		// Token: 0x04009FF1 RID: 40945
		[SerializeField]
		private NPCGlobalEventsReacting _eventsReacting;

		// Token: 0x04009FF2 RID: 40946
		[SerializeField]
		private NPCAnimationsEventReceiver _animatorEventsReceiver;

		// Token: 0x04009FF3 RID: 40947
		[SerializeField]
		private List<NPCReactionController.ObjectWithID> _objectsForToggleVisibility;

		// Token: 0x04009FF4 RID: 40948
		private LipSyncPlayer lipSyncPlayer_0;

		// Token: 0x04009FF5 RID: 40949
		private GClass737<GClass1950> gclass737_0;

		// Token: 0x04009FF6 RID: 40950
		private Queue<GClass1950> queue_0;

		// Token: 0x04009FF7 RID: 40951
		private NPCReactionController.EProcessQueueState eprocessQueueState_0;

		// Token: 0x04009FF8 RID: 40952
		private WaitForEndOfFrame waitForEndOfFrame_0;

		// Token: 0x04009FF9 RID: 40953
		private GClass1950 gclass1950_0;

		// Token: 0x04009FFA RID: 40954
		private Coroutine coroutine_0;

		// Token: 0x04009FFB RID: 40955
		private Dictionary<int, GameObject> dictionary_0;

		// Token: 0x04009FFC RID: 40956
		private bool bool_0;

		// Token: 0x04009FFD RID: 40957
		private Action action_0;

		// Token: 0x04009FFE RID: 40958
		[HideInInspector]
		public int CurrentIdleAnimationNumber;

		// Token: 0x02001C8C RID: 7308
		private enum EProcessQueueState
		{
			// Token: 0x0400A000 RID: 40960
			Waiting,
			// Token: 0x0400A001 RID: 40961
			HandlingQueue
		}

		// Token: 0x02001C8D RID: 7309
		[Serializable]
		public class ObjectWithID
		{
			// Token: 0x0400A002 RID: 40962
			public int ID;

			// Token: 0x0400A003 RID: 40963
			public GameObject gameObject;
		}

		// Token: 0x02001C8F RID: 7311
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1713
		{
			// Token: 0x060098CF RID: 39119 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1950 method_0()
			{
				throw null;
			}

			// Token: 0x0400A007 RID: 40967
			public static readonly NPCReactionController.Class1713 class1713_0;

			// Token: 0x0400A008 RID: 40968
			public static Func<GClass1950> func_0;
		}
	}
}
