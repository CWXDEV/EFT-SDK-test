using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.GlobalEvents;
using UnityEngine;

namespace EFT.NPC
{
	// Token: 0x02001C82 RID: 7298
	public class AnimationIntRandomizerByTimer : MonoBehaviour
	{
		// Token: 0x0600986A RID: 39018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(BaseEventFilter ef, GClass2885 ev)
		{
			throw null;
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(BaseEventFilter ef, GClass2885 ev)
		{
			throw null;
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool toggle)
		{
			throw null;
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_5()
		{
			throw null;
		}

		// Token: 0x04009FC6 RID: 40902
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04009FC7 RID: 40903
		[SerializeField]
		private Vector2 _randomizeMinMaxSeconds;

		// Token: 0x04009FC8 RID: 40904
		[SerializeField]
		private string _paramForRandomize;

		// Token: 0x04009FC9 RID: 40905
		[SerializeField]
		private int _defaultValue;

		// Token: 0x04009FCA RID: 40906
		[SerializeField]
		private Vector2 _randomValueFromTo;

		// Token: 0x04009FCB RID: 40907
		[Header("If false - fills list and randomize from it repeatedly")]
		[SerializeField]
		private bool fullRandom;

		// Token: 0x04009FCC RID: 40908
		[SerializeField]
		private BaseEventFilter _startWorkFilter;

		// Token: 0x04009FCD RID: 40909
		[SerializeField]
		private BaseEventFilter _stopWorkFilter;

		// Token: 0x04009FCE RID: 40910
		private Coroutine coroutine_0;

		// Token: 0x04009FCF RID: 40911
		private List<int> list_0;
	}
}
