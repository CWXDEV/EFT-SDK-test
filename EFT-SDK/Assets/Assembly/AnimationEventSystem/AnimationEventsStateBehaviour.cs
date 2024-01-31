using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace AnimationEventSystem
{
	// Token: 0x0200102A RID: 4138
	public class AnimationEventsStateBehaviour : StateMachineBehaviour, IStateBehaviour, GInterface85
	{
		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		public List<AnimationEvent> AnimationEvents
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005661 RID: 22113 RVA: 0x00002050 File Offset: 0x00000250
		AnimationEventsContainer GInterface85.EventsContainer
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

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06005662 RID: 22114 RVA: 0x00002050 File Offset: 0x00000250
		int GInterface85.FullNameHash
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Animator animator)
		{
			throw null;
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			throw null;
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			throw null;
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			throw null;
		}

		// Token: 0x04006288 RID: 25224
		public AnimationEventsContainer EventsContainer;

		// Token: 0x04006289 RID: 25225
		public string FullName;

		// Token: 0x0400628A RID: 25226
		public int FullNameHash;

		// Token: 0x0400628B RID: 25227
		public AnimatorControllerStaticData EventsData;

		// Token: 0x0400628C RID: 25228
		public int EventsListId;

		// Token: 0x0400628D RID: 25229
		private GClass1235 gclass1235_0;
	}
}
