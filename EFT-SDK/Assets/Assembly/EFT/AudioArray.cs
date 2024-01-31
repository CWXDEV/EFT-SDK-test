using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200176A RID: 5994
	public sealed class AudioArray : MonoBehaviour
	{
		// Token: 0x1400017E RID: 382
		// (add) Token: 0x0600804A RID: 32842 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600804B RID: 32843 RVA: 0x00002050 File Offset: 0x00000250
		private event Action<bool> Event_0
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

		// Token: 0x0600804C RID: 32844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(float? overlap = null)
		{
			throw null;
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySequence(AudioSequence sequence, EAudioSequenceType sequenceType, bool volumetric, Action onCancel = null)
		{
			throw null;
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayWithOffset(AudioClip sound, bool volumetric, float offset, Action onFinish = null, Action onCancel = null)
		{
			throw null;
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayOneShot(AudioClip sound, bool volumetric, Action onFinish = null)
		{
			throw null;
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task PlayOneShotAsync(AudioClip sound, bool volumetric, Action onFinish = null)
		{
			throw null;
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayLoop(AudioClip sound, bool volumetric)
		{
			throw null;
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool isVolumetric, Action onCancelCallback, Action originalCallback = null)
		{
			throw null;
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop(bool volumetric)
		{
			throw null;
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<AudioSource> method_1(bool volumetric)
		{
			throw null;
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(AudioSource source)
		{
			throw null;
		}

		// Token: 0x04008853 RID: 34899
		[SerializeField]
		private AudioSource _audioSource2D;

		// Token: 0x04008854 RID: 34900
		private List<AudioSource> list_0;

		// Token: 0x04008855 RID: 34901
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x0200176B RID: 5995
		[CompilerGenerated]
		private sealed class Class1258
		{
			// Token: 0x06008059 RID: 32857 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float time, bool init)
			{
				throw null;
			}

			// Token: 0x0600805A RID: 32858 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04008856 RID: 34902
			public List<AudioSource> sources;

			// Token: 0x04008857 RID: 34903
			public AudioClip sequenceClip;

			// Token: 0x04008858 RID: 34904
			public bool cancelled;
		}

		// Token: 0x0200176D RID: 5997
		[CompilerGenerated]
		private sealed class Class1259
		{
			// Token: 0x0600805D RID: 32861 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008867 RID: 34919
			public bool cancelled;
		}

		// Token: 0x02001771 RID: 6001
		[CompilerGenerated]
		private sealed class Class1260
		{
			// Token: 0x06008064 RID: 32868 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool volumetric)
			{
				throw null;
			}

			// Token: 0x04008880 RID: 34944
			public bool isVolumetric;

			// Token: 0x04008881 RID: 34945
			public AudioArray audioArray_0;

			// Token: 0x04008882 RID: 34946
			public Action onCancelCallback;

			// Token: 0x04008883 RID: 34947
			public Action originalCallback;
		}
	}
}
