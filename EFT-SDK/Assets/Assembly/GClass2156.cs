using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationEventSystem;
using EFT;
using EFT.Vaulting;
using UnityEngine;

// Token: 0x02001E71 RID: 7793
public abstract class GClass2156 : IDisposable
{
	// Token: 0x06009FDA RID: 40922
	protected abstract float GetDistanceToCamera();

	// Token: 0x06009FDB RID: 40923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBaseVolume(float volume)
	{
		throw null;
	}

	// Token: 0x06009FDC RID: 40924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06009FDD RID: 40925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06009FDE RID: 40926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Subscribe()
	{
		throw null;
	}

	// Token: 0x06009FDF RID: 40927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Unsubscribe()
	{
		throw null;
	}

	// Token: 0x06009FE0 RID: 40928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnStart(IAnimatorEventParameter eventParameter)
	{
		throw null;
	}

	// Token: 0x06009FE1 RID: 40929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnGrab(IAnimatorEventParameter eventParameter)
	{
		throw null;
	}

	// Token: 0x06009FE2 RID: 40930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnSlide(IAnimatorEventParameter eventParameter)
	{
		throw null;
	}

	// Token: 0x06009FE3 RID: 40931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnd(IAnimatorEventParameter eventParameter)
	{
		throw null;
	}

	// Token: 0x06009FE4 RID: 40932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06009FE5 RID: 40933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_3(EVaultingSoundState soundState, BaseBallistic.ESurfaceSound surfaceSound, out VaultingSoundSet.VaultingSoundElement soundElement)
	{
		throw null;
	}

	// Token: 0x06009FE6 RID: 40934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_4(BaseBallistic.ESurfaceSound surface, out SurfaceSet surfaceSet)
	{
		throw null;
	}

	// Token: 0x06009FE7 RID: 40935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void PlayGearSound(bool stereo = true)
	{
		throw null;
	}

	// Token: 0x06009FE8 RID: 40936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5(SoundBank bank, in VolumeRange volumeRange, bool stereo = true)
	{
		throw null;
	}

	// Token: 0x06009FE9 RID: 40937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_6(SoundBank bank, float minVolume = 0.1f, float maxVolume = 1f, bool stereo = true)
	{
		throw null;
	}

	// Token: 0x06009FEA RID: 40938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06009FEB RID: 40939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x06009FEC RID: 40940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9(Vector3 startPos, Vector3 direction, float radius, float maxDistance, out BaseBallistic.ESurfaceSound surface)
	{
		throw null;
	}

	// Token: 0x06009FED RID: 40941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10(Vector3 startPos, Vector3 endPos, float maxDistance, out BaseBallistic.ESurfaceSound surface)
	{
		throw null;
	}

	// Token: 0x06009FEE RID: 40942 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_11(in RaycastHit hit, out BaseBallistic.ESurfaceSound surface)
	{
		throw null;
	}

	// Token: 0x06009FEF RID: 40943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400A804 RID: 43012
	private const float float_0 = 0.5f;

	// Token: 0x0400A805 RID: 43013
	private const float float_1 = 0.1f;

	// Token: 0x0400A806 RID: 43014
	private const float float_2 = 0.1f;

	// Token: 0x0400A807 RID: 43015
	private readonly IVaultingParameters ivaultingParameters_0;

	// Token: 0x0400A808 RID: 43016
	private readonly Sounds sounds_0;

	// Token: 0x0400A809 RID: 43017
	private readonly BetterSource betterSource_0;

	// Token: 0x0400A80A RID: 43018
	private readonly Dictionary<BaseBallistic.ESurfaceSound, SurfaceSet> dictionary_0;

	// Token: 0x0400A80B RID: 43019
	private readonly LayerMask layerMask_0;

	// Token: 0x0400A80C RID: 43020
	private SoundBank soundBank_0;

	// Token: 0x0400A80D RID: 43021
	private float float_3;

	// Token: 0x0400A80E RID: 43022
	protected readonly EVaultingSoundType evaultingSoundType_0;

	// Token: 0x0400A80F RID: 43023
	protected readonly IVaultingSoundsEvents ivaultingSoundsEvents_0;

	// Token: 0x0400A810 RID: 43024
	protected readonly IPlayer iplayer_0;

	// Token: 0x0400A811 RID: 43025
	protected BaseBallistic.ESurfaceSound esurfaceSound_0;

	// Token: 0x0400A812 RID: 43026
	protected BaseBallistic.ESurfaceSound esurfaceSound_1;
}
