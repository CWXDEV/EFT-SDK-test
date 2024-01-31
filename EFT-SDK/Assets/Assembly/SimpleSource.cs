using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio.SpatialSystem;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020008C1 RID: 2241
public class SimpleSource : BetterSource
{
	// Token: 0x170008AD RID: 2221
	// (get) Token: 0x0600327E RID: 12926 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600327F RID: 12927 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x06003280 RID: 12928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init()
	{
		throw null;
	}

	// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AudioClip GetClip(int id)
	{
		throw null;
	}

	// Token: 0x06003282 RID: 12930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLowPassFilterParameters(float value, ESoundOcclusionType occlusionType, float lowerFreq = 1600f, float highestFreq = 22000f, bool applyImmediately = false)
	{
		throw null;
	}

	// Token: 0x06003283 RID: 12931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetHighPassFilterParameters(float value, float maxCutoffFreq = 100f, bool applyImmediately = false)
	{
		throw null;
	}

	// Token: 0x06003284 RID: 12932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSpatialBlend(float spatialBlend = 1f)
	{
		throw null;
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ResetFilters()
	{
		throw null;
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetMixerGroup(AudioMixerGroup mixerGroup)
	{
		throw null;
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayScheduled(double time)
	{
		throw null;
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScheduledEndTime(double time)
	{
		throw null;
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetPitch(float p)
	{
		throw null;
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Play(AudioClip clip1, AudioClip clip2, float balance, float volume = 1f, bool forceStereo = false, bool oneShot = true)
	{
		throw null;
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Clear(float spatial = 1f, float pitch = 1f)
	{
		throw null;
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Balance(float p)
	{
		throw null;
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enable(bool p0)
	{
		throw null;
	}

	// Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetRolloff(float distance)
	{
		throw null;
	}

	// Token: 0x0600328F RID: 12943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool VolumeFadeOut(float time, Action onDone = null)
	{
		throw null;
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool VolumeFadeIn(float time, Action onDone = null)
	{
		throw null;
	}

	// Token: 0x06003291 RID: 12945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetBaseVolume(float volume)
	{
		throw null;
	}

	// Token: 0x06003292 RID: 12946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateSourceVolume(float speed = 1f)
	{
		throw null;
	}

	// Token: 0x06003293 RID: 12947 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSpatialSettings(SpatialAudioSettings settings)
	{
		throw null;
	}

	// Token: 0x06003294 RID: 12948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003295 RID: 12949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_4(float from, float to, float time, Action onDone = null)
	{
		throw null;
	}

	// Token: 0x0400338D RID: 13197
	private float float_0;

	// Token: 0x0400338E RID: 13198
	private SpatialHighPassFilter spatialHighPassFilter_0;

	// Token: 0x0400338F RID: 13199
	private IEnumerator ienumerator_0;

	// Token: 0x04003390 RID: 13200
	private bool bool_0;

	// Token: 0x04003391 RID: 13201
	private bool bool_1;

	// Token: 0x020008C2 RID: 2242
	[CompilerGenerated]
	private sealed class Class461
	{
		// Token: 0x06003296 RID: 12950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04003392 RID: 13202
		public SimpleSource simpleSource_0;

		// Token: 0x04003393 RID: 13203
		public Action onDone;
	}

	// Token: 0x020008C3 RID: 2243
	[CompilerGenerated]
	private sealed class Class462
	{
		// Token: 0x06003297 RID: 12951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04003394 RID: 13204
		public SimpleSource simpleSource_0;

		// Token: 0x04003395 RID: 13205
		public Action onDone;
	}
}
