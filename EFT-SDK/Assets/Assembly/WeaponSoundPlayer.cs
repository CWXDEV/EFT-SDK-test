using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000926 RID: 2342
public class WeaponSoundPlayer : BaseSoundPlayer
{
	// Token: 0x17000905 RID: 2309
	// (get) Token: 0x060034DE RID: 13534 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060034DF RID: 13535 RVA: 0x00002050 File Offset: 0x00000250
	public override bool IsSilenced
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

	// Token: 0x17000906 RID: 2310
	// (get) Token: 0x060034E0 RID: 13536 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAutoWeapon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000907 RID: 2311
	// (get) Token: 0x060034E1 RID: 13537 RVA: 0x00002050 File Offset: 0x00000250
	public float BeatLn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000908 RID: 2312
	// (get) Token: 0x060034E2 RID: 13538 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsOccludedToListener
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000909 RID: 2313
	// (get) Token: 0x060034E3 RID: 13539 RVA: 0x00002050 File Offset: 0x00000250
	private float Distance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700090A RID: 2314
	// (set) Token: 0x060034E4 RID: 13540 RVA: 0x00002050 File Offset: 0x00000250
	public float ReleaseTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Init(BifacialTransform weaponHierarchy)
	{
		throw null;
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update()
	{
		throw null;
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Release(float timeLeftToPlay = 0f)
	{
		throw null;
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMixerGroup()
	{
		throw null;
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePitch(float pitch)
	{
		throw null;
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireBullet(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, float pitchMult, bool malfunctioned = false, bool multiShot = false, bool burstOf2Start = false)
	{
		throw null;
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseOcclusion(float endTime = 0f)
	{
		throw null;
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ReleaseOcclusionCoroutine(float endTime = 0f)
	{
		throw null;
	}

	// Token: 0x060034EF RID: 13551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SmoothResetPitch(float time)
	{
		throw null;
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopSoundCoroutine()
	{
		throw null;
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableSourceOcclusion(bool enabledOcclusion)
	{
		throw null;
	}

	// Token: 0x060034F2 RID: 13554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegisterSourceForOcclusionProcess()
	{
		throw null;
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Balance(SoundBank bank)
	{
		throw null;
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnBreakLoop()
	{
		throw null;
	}

	// Token: 0x060034F5 RID: 13557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopFiringLoop()
	{
		throw null;
	}

	// Token: 0x060034F6 RID: 13558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FireSonicSound(float sonicDelay, float rolloff, BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection)
	{
		throw null;
	}

	// Token: 0x040035B4 RID: 13748
	private const float SOUND_SPEED = 340.29f;

	// Token: 0x040035B5 RID: 13749
	private const float IMPACT_DIVIDER = 6f;

	// Token: 0x040035B6 RID: 13750
	private const float ORIGINAL_PITCH = 1f;

	// Token: 0x040035B7 RID: 13751
	private const float MAX_ALLOWED_PITCH = 1.045f;

	// Token: 0x040035B8 RID: 13752
	private const float MIN_ALLOWED_PITCH = 0.965f;

	// Token: 0x040035B9 RID: 13753
	public SoundBank Body;

	// Token: 0x040035BA RID: 13754
	public SoundBank Tail;

	// Token: 0x040035BB RID: 13755
	public SoundBank Doublet;

	// Token: 0x040035BC RID: 13756
	public SoundBank BodySilenced;

	// Token: 0x040035BD RID: 13757
	public SoundBank TailSilenced;

	// Token: 0x040035BE RID: 13758
	public SoundBank DoubletSilenced;

	// Token: 0x040035BF RID: 13759
	private bool _isSilenced;

	// Token: 0x040035C0 RID: 13760
	private float _prevDistance;

	// Token: 0x040035C1 RID: 13761
	private GClass789 _queue;

	// Token: 0x040035C2 RID: 13762
	private bool _isFiring;

	// Token: 0x040035C3 RID: 13763
	private float _firingLoopLength;

	// Token: 0x040035C4 RID: 13764
	private const int BEATS = 16;

	// Token: 0x040035C5 RID: 13765
	public bool Non_auto;

	// Token: 0x040035C6 RID: 13766
	private float _releaseTime;

	// Token: 0x040035C7 RID: 13767
	private float _occlusionReleaseTime;

	// Token: 0x040035C8 RID: 13768
	private float _startPlayingTime;

	// Token: 0x040035C9 RID: 13769
	private float _pitch;

	// Token: 0x040035CA RID: 13770
	private float _balance;

	// Token: 0x040035CB RID: 13771
	private float _startFire;

	// Token: 0x040035CC RID: 13772
	private float _delay;

	// Token: 0x040035CD RID: 13773
	private AudioMixerGroup _currentMixerGroup;

	// Token: 0x040035CE RID: 13774
	private float _prevPitchMult;

	// Token: 0x040035CF RID: 13775
	private Coroutine _releaseOcclusionCoroutine;
}
