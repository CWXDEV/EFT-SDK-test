using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.CameraControl;
using UnityEngine;

// Token: 0x020008AB RID: 2219
public class ArmorHitSoundPlayer : BulletSoundPlayer
{
	// Token: 0x06003226 RID: 12838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(Camera camera, PlayerCameraController playerCameraController)
	{
		throw null;
	}

	// Token: 0x06003227 RID: 12839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003229 RID: 12841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x0600322A RID: 12842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(IPlayer player, IPlayer enemy, Vector3 directionFromPlayer)
	{
		throw null;
	}

	// Token: 0x0600322B RID: 12843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3 forward, Vector3 normal)
	{
		throw null;
	}

	// Token: 0x0600322C RID: 12844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(IPlayer player, float distance)
	{
		throw null;
	}

	// Token: 0x0400332D RID: 13101
	[SerializeField]
	private AudioClip[] _fpSounds;

	// Token: 0x0400332E RID: 13102
	[SerializeField]
	private SoundBank _closeDistandeSound;

	// Token: 0x0400332F RID: 13103
	private PlayerCameraController playerCameraController_0;
}
