using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C61 RID: 7265
	public class FoldingTarget : MonoBehaviour, GInterface176
	{
		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x060097BA RID: 38842 RVA: 0x00002050 File Offset: 0x00000250
		public bool Unfolded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x00002050 File Offset: 0x00000250
		public bool Folded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Fold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unfold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Rocking(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartCommon()
		{
			throw null;
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCompleteFold()
		{
			throw null;
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCompleteUnfold()
		{
			throw null;
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0(Quaternion leftRotation, Quaternion rightRotation)
		{
			throw null;
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1(float percent)
		{
			throw null;
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayFoldAudio(float volume)
		{
			throw null;
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayUnfoldAudio(float volume)
		{
			throw null;
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayAudio(AudioSource audioSource, float volume)
		{
			throw null;
		}

		// Token: 0x04009F35 RID: 40757
		[Range(0f, 1f)]
		[SerializeField]
		private float _duration;

		// Token: 0x04009F36 RID: 40758
		[SerializeField]
		[Space]
		private Transform _target;

		// Token: 0x04009F37 RID: 40759
		[SerializeField]
		private Vector3 _targetUpRotation;

		// Token: 0x04009F38 RID: 40760
		[SerializeField]
		private Vector3 _targetDownRotation;

		// Token: 0x04009F39 RID: 40761
		[Space]
		[SerializeField]
		private AudioSource _foldAudio;

		// Token: 0x04009F3A RID: 40762
		[SerializeField]
		private AudioSource _unfoldAudio;

		// Token: 0x04009F3B RID: 40763
		private Quaternion quaternion_0;

		// Token: 0x04009F3C RID: 40764
		private Quaternion quaternion_1;

		// Token: 0x04009F3D RID: 40765
		private float float_0;

		// Token: 0x04009F3E RID: 40766
		private FoldingTargetState foldingTargetState_0;

		// Token: 0x04009F3F RID: 40767
		private AudioSource audioSource_0;

		// Token: 0x04009F40 RID: 40768
		private Sequence sequence_0;

		// Token: 0x02001C62 RID: 7266
		[CompilerGenerated]
		private sealed class Class1702
		{
			// Token: 0x060097C8 RID: 38856 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009F41 RID: 40769
			public FoldingTarget foldingTarget_0;

			// Token: 0x04009F42 RID: 40770
			public float percent;
		}

		// Token: 0x02001C63 RID: 7267
		[CompilerGenerated]
		private sealed class Class1703
		{
			// Token: 0x060097C9 RID: 38857 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009F43 RID: 40771
			public FoldingTarget foldingTarget_0;

			// Token: 0x04009F44 RID: 40772
			public float percent;
		}
	}
}
