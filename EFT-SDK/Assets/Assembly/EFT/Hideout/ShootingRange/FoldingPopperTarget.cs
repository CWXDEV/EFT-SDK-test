using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C5E RID: 7262
	public class FoldingPopperTarget : MonoBehaviour, GInterface176
	{
		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x00002050 File Offset: 0x00000250
		public bool Folded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x060097A9 RID: 38825 RVA: 0x00002050 File Offset: 0x00000250
		public bool Unfolded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x00002050 File Offset: 0x00000250
		public float StateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Fold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unfold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Rocking(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartCommon()
		{
			throw null;
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCompleteFold()
		{
			throw null;
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCompleteUnfold()
		{
			throw null;
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0(Quaternion leftRotation, Quaternion rightRotation, float defaultAngle)
		{
			throw null;
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1(float percent)
		{
			throw null;
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayFoldAudio(float volume)
		{
			throw null;
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayUnfoldAudio(float volume)
		{
			throw null;
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayRockingAudio()
		{
			throw null;
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayAudio(AudioSource audioSource, float volume)
		{
			throw null;
		}

		// Token: 0x04009F19 RID: 40729
		[SerializeField]
		[Range(0f, 1f)]
		private float _duration;

		// Token: 0x04009F1A RID: 40730
		[Space]
		[SerializeField]
		private Transform _target;

		// Token: 0x04009F1B RID: 40731
		[SerializeField]
		private AnimationCurve _targetUpEase;

		// Token: 0x04009F1C RID: 40732
		[SerializeField]
		private AnimationCurve _targetDownEase;

		// Token: 0x04009F1D RID: 40733
		[SerializeField]
		private Vector3 _targetUpRotation;

		// Token: 0x04009F1E RID: 40734
		[SerializeField]
		private Vector3 _targetDownRotation;

		// Token: 0x04009F1F RID: 40735
		[Space]
		[SerializeField]
		private Transform _roller;

		// Token: 0x04009F20 RID: 40736
		[SerializeField]
		private AnimationCurve _rollerUpEase;

		// Token: 0x04009F21 RID: 40737
		[SerializeField]
		private AnimationCurve _rollerDownEase;

		// Token: 0x04009F22 RID: 40738
		[SerializeField]
		private Vector3 _rollerUpRotation;

		// Token: 0x04009F23 RID: 40739
		[SerializeField]
		private Vector3 _rollerDownRotation;

		// Token: 0x04009F24 RID: 40740
		[SerializeField]
		[Space]
		private AudioSource[] _foldAudios;

		// Token: 0x04009F25 RID: 40741
		[SerializeField]
		private AudioSource _unfoldAudio;

		// Token: 0x04009F26 RID: 40742
		[SerializeField]
		private AudioSource _rockingAudio;

		// Token: 0x04009F27 RID: 40743
		private Quaternion quaternion_0;

		// Token: 0x04009F28 RID: 40744
		private Quaternion quaternion_1;

		// Token: 0x04009F29 RID: 40745
		private Quaternion quaternion_2;

		// Token: 0x04009F2A RID: 40746
		private Quaternion quaternion_3;

		// Token: 0x04009F2B RID: 40747
		private float float_0;

		// Token: 0x04009F2C RID: 40748
		private float float_1;

		// Token: 0x04009F2D RID: 40749
		private FoldingTargetState foldingTargetState_0;

		// Token: 0x04009F2E RID: 40750
		private float float_2;

		// Token: 0x04009F2F RID: 40751
		private AudioSource audioSource_0;

		// Token: 0x04009F30 RID: 40752
		private Sequence sequence_0;

		// Token: 0x02001C5F RID: 7263
		[CompilerGenerated]
		private sealed class Class1700
		{
			// Token: 0x060097B8 RID: 38840 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009F31 RID: 40753
			public FoldingPopperTarget foldingPopperTarget_0;

			// Token: 0x04009F32 RID: 40754
			public float targetPercent;
		}

		// Token: 0x02001C60 RID: 7264
		[CompilerGenerated]
		private sealed class Class1701
		{
			// Token: 0x060097B9 RID: 38841 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009F33 RID: 40755
			public FoldingPopperTarget foldingPopperTarget_0;

			// Token: 0x04009F34 RID: 40756
			public float targetPercent;
		}
	}
}
