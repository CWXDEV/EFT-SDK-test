using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.Data;
using EFT;
using UnityEngine;

// Token: 0x02000D6C RID: 3436
public class GClass2092 : GClass2091, IDisposable, GInterface58
{
	// Token: 0x06004905 RID: 18693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(SurfaceSet surfaceSet, IPlayer player)
	{
		throw null;
	}

	// Token: 0x06004906 RID: 18694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(SurfaceSet surfaceSet)
	{
		throw null;
	}

	// Token: 0x06004907 RID: 18695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitializeSource(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06004908 RID: 18696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSoundRolloff(float rolloff)
	{
		throw null;
	}

	// Token: 0x06004909 RID: 18697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSurface(BaseBallistic.ESurfaceSound surface)
	{
		throw null;
	}

	// Token: 0x0600490A RID: 18698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateUnderRoofStatus(bool isUnderRoof)
	{
		throw null;
	}

	// Token: 0x0600490B RID: 18699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Play(EAudioMovementState movementState, EnvironmentType environment, float distance = 0f, float baseStepVolume = 1f, float blendParameter = 0f, bool stereo = false, float customRolloff = 0f)
	{
		throw null;
	}

	// Token: 0x0600490C RID: 18700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_3(float baseStepVolume)
	{
		throw null;
	}

	// Token: 0x0600490D RID: 18701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4()
	{
		throw null;
	}

	// Token: 0x0600490E RID: 18702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_5(EAudioMovementState movementState, out SoundBank bank)
	{
		throw null;
	}

	// Token: 0x0600490F RID: 18703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x040053DD RID: 21469
	private const float float_1 = 0f;

	// Token: 0x040053DE RID: 21470
	private const float float_2 = 1.1f;

	// Token: 0x040053DF RID: 21471
	private const float float_3 = 0.62f;

	// Token: 0x040053E0 RID: 21472
	private const float float_4 = 1f;

	// Token: 0x040053E1 RID: 21473
	private readonly float float_5;

	// Token: 0x040053E2 RID: 21474
	private readonly float float_6;

	// Token: 0x040053E3 RID: 21475
	private Dictionary<EAudioMovementState, SoundBank> dictionary_0;

	// Token: 0x040053E4 RID: 21476
	protected BetterSource betterSource_0;

	// Token: 0x040053E5 RID: 21477
	private BaseBallistic.ESurfaceSound esurfaceSound_0;

	// Token: 0x040053E6 RID: 21478
	private bool bool_0;

	// Token: 0x040053E7 RID: 21479
	private readonly Vector2 vector2_0;
}
