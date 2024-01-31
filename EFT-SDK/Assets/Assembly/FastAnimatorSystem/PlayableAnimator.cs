using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationSystem.RootMotionTable;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace FastAnimatorSystem
{
	// Token: 0x02000F4F RID: 3919
	public sealed class PlayableAnimator : MonoBehaviour, GInterface71
	{
		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06005224 RID: 21028 RVA: 0x00002050 File Offset: 0x00000250
		public bool Initialized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06005225 RID: 21029 RVA: 0x00002050 File Offset: 0x00000250
		public bool ManualUpdateMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator FastAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06005227 RID: 21031 RVA: 0x00002050 File Offset: 0x00000250
		public PlayableGraph Graph
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00002050 File Offset: 0x00000250
		public int LayersCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(IAnimator animator, GInterface82 parametersCache, RootMotionBlendTable rootMotionBlendTable, CharacterClipsKeeper clipsKeeper, bool manualUpdate)
		{
			throw null;
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Play()
		{
			throw null;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process(bool isVisible, float dt)
		{
			throw null;
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayerWeight(int layerIndex, float weight)
		{
			throw null;
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetLayerWeight(int layerIndex)
		{
			throw null;
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RaiseImmediateTransitionHappened(int layerIndex)
		{
			throw null;
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCuller(GInterface72 culler)
		{
			throw null;
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GInterface73 GetLayerProcessor(int layerIndex)
		{
			throw null;
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationClip GetClipByIndex(int layerIndex, int clipIndex)
		{
			throw null;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAnimatorMove()
		{
			throw null;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04005DCC RID: 24012
		public Animator outputAnimator;

		// Token: 0x04005DCD RID: 24013
		public InitialLayerInfo[] initialLayerInfo;

		// Token: 0x04005DCE RID: 24014
		private bool bool_0;

		// Token: 0x04005DCF RID: 24015
		private PlayableGraph playableGraph_0;

		// Token: 0x04005DD0 RID: 24016
		private List<GClass1131> list_0;

		// Token: 0x04005DD1 RID: 24017
		private List<AnimationClip>[] list_1;

		// Token: 0x04005DD2 RID: 24018
		private AnimationPlayableOutput animationPlayableOutput_0;

		// Token: 0x04005DD3 RID: 24019
		private AnimationLayerMixerPlayable animationLayerMixerPlayable_0;

		// Token: 0x04005DD4 RID: 24020
		private IAnimator ianimator_0;

		// Token: 0x04005DD5 RID: 24021
		private GInterface72 ginterface72_0;

		// Token: 0x04005DD6 RID: 24022
		private bool bool_1;
	}
}
