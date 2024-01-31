using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.SpatialSystem;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020008CF RID: 2255
public class SuperSourceDistant : BetterSource
{
	// Token: 0x170008B5 RID: 2229
	// (get) Token: 0x060032CB RID: 13003 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060032CC RID: 13004 RVA: 0x00002050 File Offset: 0x00000250
	public override bool Loop
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

	// Token: 0x060032CD RID: 13005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayScheduled(double time)
	{
		throw null;
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScheduledEndTime(double time)
	{
		throw null;
	}

	// Token: 0x060032CF RID: 13007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AudioClip GetClip(int id)
	{
		throw null;
	}

	// Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060032D1 RID: 13009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init()
	{
		throw null;
	}

	// Token: 0x060032D2 RID: 13010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetPitch(float p)
	{
		throw null;
	}

	// Token: 0x060032D3 RID: 13011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLowPassFilterParameters(float value, ESoundOcclusionType occlusionType, float lowerFreq = 1600f, float highestFreq = 22000f, bool applyImmediately = false)
	{
		throw null;
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetHighPassFilterParameters(float value, float maxCutoffFreq = 100f, bool applyImmediately = false)
	{
		throw null;
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSpatialBlend(float spatialBlend = 1f)
	{
		throw null;
	}

	// Token: 0x060032D6 RID: 13014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ResetFilters()
	{
		throw null;
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Play(AudioClip clip1, AudioClip clip2, float balance, float volume = 1f, bool forceStereo = false, bool oneShot = true)
	{
		throw null;
	}

	// Token: 0x060032D8 RID: 13016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(AudioSource source, AudioClip clip)
	{
		throw null;
	}

	// Token: 0x060032D9 RID: 13017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Clear(float spatial = 1f, float pitch = 1f)
	{
		throw null;
	}

	// Token: 0x060032DA RID: 13018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Balance(float p)
	{
		throw null;
	}

	// Token: 0x060032DB RID: 13019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enable(bool p0)
	{
		throw null;
	}

	// Token: 0x060032DC RID: 13020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetRolloff(float distance)
	{
		throw null;
	}

	// Token: 0x060032DD RID: 13021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetMixerGroup(AudioMixerGroup mixerGroup)
	{
		throw null;
	}

	// Token: 0x060032DE RID: 13022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool VolumeFadeOut(float time, Action onDone = null)
	{
		throw null;
	}

	// Token: 0x060032DF RID: 13023 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool VolumeFadeIn(float time, Action onDone = null)
	{
		throw null;
	}

	// Token: 0x060032E0 RID: 13024 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetBaseVolume(float volume)
	{
		throw null;
	}

	// Token: 0x060032E1 RID: 13025 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateSourceVolume(float speed = 1f)
	{
		throw null;
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSpatialSettings(SpatialAudioSettings settings)
	{
		throw null;
	}

	// Token: 0x060032E3 RID: 13027 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnqueueImportant(AudioClip clip1, AudioClip clip2, float balance, float delay, float clipTime)
	{
		throw null;
	}

	// Token: 0x060032E4 RID: 13028 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProlongCurrent(float clipTime)
	{
		throw null;
	}

	// Token: 0x060032E5 RID: 13029 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshSpatialization(bool enabledSpat)
	{
		throw null;
	}

	// Token: 0x060032E6 RID: 13030 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BaseSpatialAudioSource method_4()
	{
		throw null;
	}

	// Token: 0x060032E7 RID: 13031 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AudioSource method_5()
	{
		throw null;
	}

	// Token: 0x060032E8 RID: 13032 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpatialLowPassFilter method_6()
	{
		throw null;
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Release()
	{
		throw null;
	}

	// Token: 0x040033D0 RID: 13264
	public float Delay;

	// Token: 0x040033D1 RID: 13265
	public float SpatialBlend;

	// Token: 0x040033D2 RID: 13266
	private Queue<GClass792> queue_0;

	// Token: 0x040033D3 RID: 13267
	private AudioSource audioSource_0;

	// Token: 0x040033D4 RID: 13268
	private BaseSpatialAudioSource baseSpatialAudioSource_0;

	// Token: 0x040033D5 RID: 13269
	private SpatialLowPassFilter spatialLowPassFilter_0;

	// Token: 0x040033D6 RID: 13270
	private double double_0;

	// Token: 0x040033D7 RID: 13271
	private float float_0;
}
