using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Audio.SpatialSystem;
using EFT;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020008A7 RID: 2215
public abstract class BetterSource : MonoBehaviour, GClass836.GInterface37
{
	// Token: 0x1700089B RID: 2203
	// (get) Token: 0x060031F0 RID: 12784 RVA: 0x00002050 File Offset: 0x00000250
	public float LowPassFilterLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700089C RID: 2204
	// (get) Token: 0x060031F1 RID: 12785 RVA: 0x00002050 File Offset: 0x00000250
	public float LowPassFilterFrequency
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700089E RID: 2206
	// (get) Token: 0x060031F2 RID: 12786 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060031F3 RID: 12787 RVA: 0x00002050 File Offset: 0x00000250
	public SpatialAudioSettings SpatialSettings
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x1700089F RID: 2207
	// (get) Token: 0x060031F4 RID: 12788 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060031F5 RID: 12789 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
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

	// Token: 0x170008A0 RID: 2208
	// (get) Token: 0x060031F6 RID: 12790 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1400009B RID: 155
	// (add) Token: 0x060031F7 RID: 12791 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060031F8 RID: 12792 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BetterSource> OnReleased
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

	// Token: 0x1400009C RID: 156
	// (add) Token: 0x060031F9 RID: 12793 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060031FA RID: 12794 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnPlayed
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

	// Token: 0x060031FB RID: 12795
	public abstract AudioClip GetClip(int id);

	// Token: 0x060031FC RID: 12796
	protected abstract void ResetFilters();

	// Token: 0x060031FD RID: 12797
	public abstract void SetLowPassFilterParameters(float value, ESoundOcclusionType occlusionType, float lowerFreq = 1600f, float highestFreq = 22000f, bool applyImmediately = false);

	// Token: 0x060031FE RID: 12798
	public abstract void SetHighPassFilterParameters(float value, float maxCutoffFreq = 100f, bool applyImmediately = false);

	// Token: 0x060031FF RID: 12799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnableStereo(bool stereo = false)
	{
		throw null;
	}

	// Token: 0x06003200 RID: 12800
	public abstract void SetSpatialBlend(float spatialBlend = 1f);

	// Token: 0x06003201 RID: 12801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncludeInOcclusionProcess(bool included)
	{
		throw null;
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetOcclusionWithDelay(float delay = 5f)
	{
		throw null;
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0(float delay = 1f)
	{
		throw null;
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetOcclusion()
	{
		throw null;
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Release()
	{
		throw null;
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayScheduled(double time)
	{
		throw null;
	}

	// Token: 0x06003208 RID: 12808
	public abstract void SetScheduledEndTime(double time);

	// Token: 0x170008A1 RID: 2209
	// (get) Token: 0x0600320A RID: 12810
	// (set) Token: 0x06003209 RID: 12809
	public abstract bool Loop { get; set; }

	// Token: 0x0600320B RID: 12811
	public abstract void Init();

	// Token: 0x0600320C RID: 12812
	public abstract void SetPitch(float p);

	// Token: 0x0600320D RID: 12813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Play(AudioClip clip1, AudioClip clip2, float balance, float volume = 1f, bool forceStereo = false, bool oneShot = true)
	{
		throw null;
	}

	// Token: 0x0600320E RID: 12814
	public abstract void Clear(float spatial = 1f, float pitch = 1f);

	// Token: 0x0600320F RID: 12815
	public abstract void Balance(float p);

	// Token: 0x06003210 RID: 12816
	public abstract void Enable(bool p0);

	// Token: 0x06003211 RID: 12817
	public abstract void SetRolloff(float distance);

	// Token: 0x06003212 RID: 12818
	public abstract void SetMixerGroup(AudioMixerGroup mixerGroup);

	// Token: 0x06003213 RID: 12819
	public abstract bool VolumeFadeOut(float time, Action onDone = null);

	// Token: 0x06003214 RID: 12820
	public abstract bool VolumeFadeIn(float time, Action onDone = null);

	// Token: 0x06003215 RID: 12821
	public abstract void SetBaseVolume(float volume);

	// Token: 0x06003216 RID: 12822
	protected abstract void UpdateSourceVolume(float speed = 1f);

	// Token: 0x06003217 RID: 12823
	public abstract void SetSpatialSettings(SpatialAudioSettings settings);

	// Token: 0x06003218 RID: 12824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetPriority(int priority)
	{
		throw null;
	}

	// Token: 0x06003219 RID: 12825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPreset(AudioGroupPreset preset)
	{
		throw null;
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshSpatialization(bool enabledSpat)
	{
		throw null;
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckIfClipLoaded(AudioClip clip)
	{
		throw null;
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float CalculateEndPlaybackTime(AudioClip clip1, AudioClip clip2, float delay = 0f)
	{
		throw null;
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600321E RID: 12830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600321F RID: 12831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x04003313 RID: 13075
	private const float TOO_CLOSE_FOR_BINAURAL = 1.5f;

	// Token: 0x04003314 RID: 13076
	private const float VOLUME_UPDATE_SPEED = 10f;

	// Token: 0x04003315 RID: 13077
	public AudioSource source1;

	// Token: 0x04003316 RID: 13078
	protected float EndPlaybackTime;

	// Token: 0x04003317 RID: 13079
	protected AudioGroupPreset Preset;

	// Token: 0x04003318 RID: 13080
	private Transform _transform;

	// Token: 0x04003319 RID: 13081
	private bool _forceStereo;

	// Token: 0x0400331A RID: 13082
	protected bool IncludedInOcclusionProcess;

	// Token: 0x0400331B RID: 13083
	protected SpatialLowPassFilter LowPassFilter;

	// Token: 0x0400331C RID: 13084
	protected BaseSpatialAudioSource Spatializer;

	// Token: 0x0400331D RID: 13085
	protected float SourcePlayingVolume;

	// Token: 0x0400331E RID: 13086
	public bool checkEveryFrame;

	// Token: 0x0400331F RID: 13087
	public BetterSource.EPlayBackState PlayBackState;

	// Token: 0x04003320 RID: 13088
	public BetterSource.GInterface31 ReleaseListener;

	// Token: 0x020008A8 RID: 2216
	public enum EPlayBackState
	{
		// Token: 0x04003326 RID: 13094
		Playing,
		// Token: 0x04003327 RID: 13095
		Stopped,
		// Token: 0x04003328 RID: 13096
		Released
	}

	// Token: 0x020008A9 RID: 2217
	public interface GInterface31
	{
		// Token: 0x06003221 RID: 12833
		void Release(BetterSource source);
	}
}
