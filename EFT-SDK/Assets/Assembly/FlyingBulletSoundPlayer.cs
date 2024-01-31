using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Ballistics;
using EFT.CameraControl;
using UnityEngine;

// Token: 0x020008AF RID: 2223
public class FlyingBulletSoundPlayer : BulletSoundPlayer
{
	// Token: 0x06003244 RID: 12868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(Camera camera, PlayerCameraController playerCameraController)
	{
		throw null;
	}

	// Token: 0x06003245 RID: 12869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TryShot(GClass2988 shot, Camera camera, string id, int currentIndex)
	{
		throw null;
	}

	// Token: 0x06003246 RID: 12870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003247 RID: 12871 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003248 RID: 12872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(SonicBulletSoundPlayer.GClass794 obj)
	{
		throw null;
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass2988 shot, Vector3 forward, Vector3 normal)
	{
		throw null;
	}

	// Token: 0x0600324A RID: 12874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(string id)
	{
		throw null;
	}

	// Token: 0x0600324B RID: 12875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_3(string id, Vector3 forward, Vector3 normal, float magnitude)
	{
		throw null;
	}

	// Token: 0x0600324C RID: 12876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_4()
	{
		throw null;
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(float coef)
	{
		throw null;
	}

	// Token: 0x0600324E RID: 12878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_6(float savedValue, float coef)
	{
		throw null;
	}

	// Token: 0x0600324F RID: 12879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x04003336 RID: 13110
	[SerializeField]
	private AudioClip[] _sources;

	// Token: 0x04003337 RID: 13111
	private Vector2 _minMaxRadius;

	// Token: 0x04003338 RID: 13112
	[SerializeField]
	private AnimationCurve _vignette;

	// Token: 0x04003339 RID: 13113
	[SerializeField]
	private float _vignetteTime;

	// Token: 0x0400333A RID: 13114
	[SerializeField]
	private float _vignetteDelta;

	// Token: 0x0400333B RID: 13115
	private List<BallisticsCalculator> list_0;

	// Token: 0x0400333C RID: 13116
	private Dictionary<string, int> dictionary_0;

	// Token: 0x0400333D RID: 13117
	private string[] string_0;

	// Token: 0x0400333E RID: 13118
	private int int_0;

	// Token: 0x0400333F RID: 13119
	private PrismEffects prismEffects_0;

	// Token: 0x04003340 RID: 13120
	private float float_0;

	// Token: 0x04003341 RID: 13121
	private IEnumerator ienumerator_0;

	// Token: 0x04003342 RID: 13122
	private Player player_0;

	// Token: 0x04003343 RID: 13123
	private Coroutine coroutine_0;

	// Token: 0x04003344 RID: 13124
	private float float_1;
}
