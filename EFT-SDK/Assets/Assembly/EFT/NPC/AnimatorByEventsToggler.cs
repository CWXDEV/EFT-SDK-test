using System;
using System.Runtime.CompilerServices;
using EFT.GlobalEvents;
using UnityEngine;

namespace EFT.NPC
{
	// Token: 0x02001C84 RID: 7300
	public class AnimatorByEventsToggler : MonoBehaviour
	{
		// Token: 0x06009876 RID: 39030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BaseEventFilter filter, GClass2885 invokedEvent)
		{
			throw null;
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(BaseEventFilter filter, GClass2885 invokedEvent)
		{
			throw null;
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool toggle)
		{
			throw null;
		}

		// Token: 0x04009FD6 RID: 40918
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04009FD7 RID: 40919
		[SerializeField]
		private string _triggerOnToggleOn;

		// Token: 0x04009FD8 RID: 40920
		[SerializeField]
		private BaseEventFilter toggleOnEvent;

		// Token: 0x04009FD9 RID: 40921
		[SerializeField]
		private BaseEventFilter toggleOffEvent;
	}
}
