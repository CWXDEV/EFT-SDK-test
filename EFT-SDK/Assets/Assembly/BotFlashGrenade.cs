using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020002B9 RID: 697
public class BotFlashGrenade : GClass362
{
	// Token: 0x1700038A RID: 906
	// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFlashed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700038B RID: 907
	// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3? PlaceToShoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallShoot()
	{
		throw null;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSoundEffect(float time, Vector3 position)
	{
		throw null;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBlindEffect(float time, Vector3 position)
	{
		throw null;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(IEffect obj)
	{
		throw null;
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(IEffect obj)
	{
		throw null;
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass527 method_3()
	{
		throw null;
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000DFE RID: 3582
	private float _flashEndTimne;

	// Token: 0x04000DFF RID: 3583
	private float _shootInFlashEndTime;

	// Token: 0x04000E00 RID: 3584
	private bool _isFlashed;

	// Token: 0x04000E01 RID: 3585
	private bool _shallRun;

	// Token: 0x04000E02 RID: 3586
	private Vector3? _lastTargetToShoot;

	// Token: 0x04000E03 RID: 3587
	private GClass527 _lastBlindEffectModif;

	// Token: 0x04000E04 RID: 3588
	private GClass527 _lastBlindEffectModif2;

	// Token: 0x04000E05 RID: 3589
	private GClass527 _lastSoundEffectModif;
}
