using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using uLipSync;
using UnityEngine;

namespace Cutscene
{
	// Token: 0x02000CA4 RID: 3236
	public class LipSyncPlayer : MonoBehaviour
	{
		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06004584 RID: 17796 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004585 RID: 17797 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnStartPlay
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

		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06004586 RID: 17798 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004587 RID: 17799 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnStopPlay
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

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06004588 RID: 17800 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004589 RID: 17801 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action<string> TestOnStartPlay
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600458B RID: 17803 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsPlaying
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600458D RID: 17805 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAllowPlaySound
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

		// Token: 0x0600458E RID: 17806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySettings(GameObject source, GameObject target)
		{
			throw null;
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartPlay(BakedData bakedData)
		{
			throw null;
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePlay(float normalizedTime)
		{
			throw null;
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyBakeFrame(LipSyncInfo info)
		{
			throw null;
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ContinueDetachedPlay()
		{
			throw null;
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool StopPlay()
		{
			throw null;
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_4(float value, float target, ref float velocity)
		{
			throw null;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(AnimationTrack data, Action<string> onStart, Action onFinish)
		{
			throw null;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_7(float startTime)
		{
			throw null;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(float normalizedTime)
		{
			throw null;
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_11(string param)
		{
			throw null;
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static LipSyncPlayer GetPlayer(GameObject target)
		{
			throw null;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Play(AnimationTrack data, GameObject target, Action<string> onStart, Action onFinish)
		{
			throw null;
		}

		// Token: 0x04005045 RID: 20549
		private SkinnedMeshRenderer skinnedMeshRenderer_0;

		// Token: 0x04005046 RID: 20550
		private BakedData bakedData_0;

		// Token: 0x04005047 RID: 20551
		private BakedDataWithCurves.CurveData[] curveData_0;

		// Token: 0x04005048 RID: 20552
		private List<uLipSyncBlendShape.BlendShapeInfo> list_0;

		// Token: 0x04005049 RID: 20553
		[SerializeField]
		private float minVolume;

		// Token: 0x0400504A RID: 20554
		[SerializeField]
		private float maxVolume;

		// Token: 0x0400504B RID: 20555
		[SerializeField]
		private float smoothness;

		// Token: 0x0400504C RID: 20556
		[SerializeField]
		private float timeOffset;

		// Token: 0x0400504D RID: 20557
		[SerializeField]
		private float playVolume;

		// Token: 0x0400504E RID: 20558
		private AudioClip audioClip_0;

		// Token: 0x0400504F RID: 20559
		private AudioSource audioSource_0;

		// Token: 0x04005050 RID: 20560
		private Animator animator_0;

		// Token: 0x04005051 RID: 20561
		private bool bool_0;

		// Token: 0x04005052 RID: 20562
		private float float_0;

		// Token: 0x04005053 RID: 20563
		private float float_1;

		// Token: 0x04005054 RID: 20564
		private bool bool_1;

		// Token: 0x04005055 RID: 20565
		private float float_2;

		// Token: 0x04005056 RID: 20566
		private float float_3;

		// Token: 0x04005057 RID: 20567
		private float float_4;

		// Token: 0x04005058 RID: 20568
		private Dictionary<string, int> dictionary_0;

		// Token: 0x04005059 RID: 20569
		private Action<string> action_0;

		// Token: 0x0400505A RID: 20570
		private Action action_1;

		// Token: 0x0400505B RID: 20571
		private Coroutine coroutine_0;

		// Token: 0x0400505C RID: 20572
		private LipSyncInfo lipSyncInfo_0;

		// Token: 0x0400505D RID: 20573
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x0400505E RID: 20574
		[CompilerGenerated]
		private Action action_3;

		// Token: 0x0400505F RID: 20575
		[CompilerGenerated]
		private static Action<string> action_4;

		// Token: 0x04005060 RID: 20576
		[CompilerGenerated]
		private bool bool_2;
	}
}
